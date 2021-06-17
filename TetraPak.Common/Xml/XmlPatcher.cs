using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;

#pragma warning disable 1998

namespace TetraPak.Xml
{
    /// <summary>
    ///   Supports convenient XML patching capabilities.
    /// </summary>
    public class XmlPatcher
    {
        readonly XDocument _document;
        readonly string _path;

        /// <summary>
        ///   Loads an XML document into a new <see cref="XmlPatcher"/> instance, ready to be patched.
        /// </summary>
        /// <param name="path">
        ///   The path to the XML document to be patched.
        /// </param>
        /// <param name="cancellationToken">
        ///   A <see cref="CancellationToken"/>, allowing the asynchronous load operation to be cancelled.
        /// </param>
        /// <returns>
        ///   A <see cref="Outcome{T}"/> instance to indicate success/failure.
        /// </returns>
        /// <seealso cref="SaveAsync"/>
        public static async Task<Outcome<XmlPatcher>> LoadAsync(string path, CancellationToken cancellationToken)
        {
            try
            {
                await using var fileStream = File.OpenRead(path);
                var document = await XDocument.LoadAsync(fileStream, LoadOptions.None, cancellationToken);
                var patcher = new XmlPatcher(document, path);
                return Outcome<XmlPatcher>.Success(patcher);
            }
            catch (Exception ex)
            {
                return Outcome<XmlPatcher>.Fail(new Exception($"Unexpected error while loading file {path}: {ex.Message}", ex));
            }
        }
        
        /// <summary>
        ///   Saves the patched XML document.
        /// </summary>
        /// <param name="cancellationToken">
        ///   A <see cref="CancellationToken"/>, allowing the asynchronous save operation to be cancelled.
        /// </param>
        /// <param name="path">
        ///   (optional; default=the path used to load the document)<br/>
        ///   The path to the XML document to be saved.
        /// </param>
        /// <returns>
        ///   A <see cref="Outcome{T}"/> instance to indicate success/failure.
        /// </returns>
        public async Task<Outcome<XmlPatcher>> SaveAsync(CancellationToken cancellationToken, string path = null)
        {
            path ??= _path;
            try
            {
                await using var fileStream = File.OpenWrite(path);
                await _document.SaveAsync(fileStream, SaveOptions.None, cancellationToken);
                return Outcome<XmlPatcher>.Success(this);
            }
            catch (Exception ex)
            {
                return Outcome<XmlPatcher>.Fail(new Exception($"Unexpected error when writing file {path}: {ex.Message}"));
            }
        }

        /// <summary>
        ///   Copies a specified value to one or more target nodes.
        /// </summary>
        /// <param name="source">
        ///   Identifies (XPath) the value to be copied.
        /// </param>
        /// <param name="targets">
        ///   Identifies (XPath) the nodes to copy the value to.
        /// </param>
        /// <param name="copyDelegate">
        ///   (optional)<br/>
        ///   A delegate for custom processing. The delegate should set the <see cref="Xml"/>
        /// </param>
        /// <param name="failOnTargetNotFound">
        ///   (optional; default=<c>true</c>)<br/>
        ///   Specifies whether to abort the patching process if one target cannot be found.
        /// </param>
        /// <returns>
        ///   An <see cref="Outcome{T}"/> value to indicate success/failure.
        /// </returns>
        public async Task<Outcome<XmlPatcher>> CopyValue(
            string source,
            IEnumerable<string> targets,
            ValueEventDelegate copyDelegate = null,
            bool failOnTargetNotFound = true)
        {
            try
            {
                var sourceElement = _document.XPathSelectElement(source);
                if (sourceElement is null)
                    return Outcome<XmlPatcher>.Fail(new Exception("No Nuget package version found in file"));

                foreach (var xpath in targets)
                {
                    var targetElement = _document.XPathSelectElement(xpath);
                    var value = sourceElement.Value;
                    var action = XElementAction.Update;
                    if (copyDelegate is { })
                    {
                        var args = new XElementValueEventArgs(value, action, sourceElement, targetElement);
                        copyDelegate(this, args);
                        value = args.Value;
                        action = args.Action;
                    }

                    // ReSharper disable once SwitchStatementHandlesSomeKnownEnumValuesWithDefault
                    switch (action)
                    {
                        case XElementAction.None:
                            continue;
                            
                        case XElementAction.Create:
                            // todo support adding a (missing) element 
                            throw new NotImplementedException($"Unsupported copy action: {action}");
                            
                        case XElementAction.Update:
                            if (targetElement is null)
                            {
                                if (failOnTargetNotFound)
                                    return Outcome<XmlPatcher>.Fail(new Exception($"Target element not found: '{xpath}'"));
                        
                                continue;
                            }
                            targetElement.Value = value;
                            break;
                        
                        default:
                            throw new ArgumentOutOfRangeException($"Unsupported copy action: {action}");
                    }
                }

                return Outcome<XmlPatcher>.Success(this);
            }
            catch (Exception ex)
            {
                return Outcome<XmlPatcher>.Fail(new Exception($"Unexpected error when patching {_path}: {ex.Message}"));
            }
        }

        XmlPatcher(XDocument document, string path)
        {
            _document = document;
            _path = path;
        }
    }

    public class XElementValueEventArgs : EventArgs
    {
        /// <summary>
        ///   The value to be processed.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        ///   Gets or sets an action to be performed by the operation after the delegate is has run.
        ///   The delegate should set this value to <see cref="XElementAction.None"/> to indicate
        ///   no further processing by the invoker. 
        /// </summary>
        public XElementAction Action { get; set; }

        /// <summary>
        ///   The source <see cref="XElement"/> for the process.
        /// </summary>
        public XElement SourceElement { get; }

        /// <summary>
        ///   The intended target <see cref="XElement"/> for the process.
        /// </summary>
        public XElement TargetElement { get; }

        internal XElementValueEventArgs(string value, XElementAction action, XElement sourceElement, XElement targetElement)
        {
            Value = value;
            Action = action;
            SourceElement = sourceElement;
            TargetElement = targetElement;
        }
    }

    public delegate void ValueEventDelegate(object sender, XElementValueEventArgs args);
    
    public enum XElementAction
    {
        None,
        
        Create,
        
        Read,

        Update,
        
        Delete
    }
}