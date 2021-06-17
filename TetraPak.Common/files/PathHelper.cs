using System;
using System.IO;
using System.Text;

namespace TetraPak.files
{
    public static class PathHelper
    {
        public static Outcome<DirectoryInfo> ResolveRelativeDirectory(this DirectoryInfo self, string relativePath)
        {
            if (!self.Exists)
                return Outcome<DirectoryInfo>.Fail(new FileNotFoundException($"Folder does not exist: {self}"));

            var ca = relativePath.ToCharArray();
            var dir = new DirectoryInfo(self.FullName);
            var end = ca.Length;
            for (var i = 0; i < ca.Length; i++)
            {
                var c = ca[i];
                switch (c)
                {
                    case '.':
                    {
                        if (i < end && ca[i + 1] == '.')
                        {
                            // .. (up)
                            ++i;
                            dir = dir?.Parent;
                        }
                        continue;
                    }
                    case '/':
                    case '\\':
                        continue;

                    default:
                        var name = eatName();
                        dir = new DirectoryInfo(Path.Combine(dir.FullName, name));
                        if (!dir.Exists)
                            return Outcome<DirectoryInfo>.Fail(new FormatException( $"Cannot resolve relative path \"{relativePath}\" from: {self}"));
                        continue;
                }

                string eatName()
                {
                    var sb = new StringBuilder();
                    sb.Append(c);
                    var j = i + 1;
                    for (; j < ca.Length; j++)
                    {
                        c = ca[j];
                        if (c != '/' && c != '\\')
                        {
                            sb.Append(c);
                            continue;
                        }
                        
                        i = j;
                    }

                    i = j;
                    return sb.ToString();
                }
            }
            return Outcome<DirectoryInfo>.Success(dir);
        }
    }
}