using System;
using TetraPak;
using Xunit;

namespace TestProject1
{
    public class MultiStringValueTests
    {
        const string Pattern1 = "a";
        const string Pattern2 = "a,b";
        const string Pattern3 = "a,b,c";
        const string Pattern4 = "a,b,c,d";
        
        const string Pattern5 = "b,c,d";
        const string Pattern6 = "c,d";
        const string Pattern7 = "d";

        [Fact]
        public void Count()
        {
            var msv = (MultiStringValue) Pattern4;
            Assert.Equal(4, msv.Count);
            msv = "a";
            Assert.Equal(1, msv.Count);
            msv = MultiStringValue.Empty;
            Assert.Equal(0, msv.Count);
        }
        
        [Fact]
        public void Equality()
        {
            var msv = (MultiStringValue) Pattern4;
            Assert.Equal(Pattern4, msv);
            Assert.True(Pattern4 == msv);
            Assert.True(msv == Pattern4);

            const string Empty = "";
            msv = MultiStringValue.Empty;
            Assert.Equal(Empty, msv);
            Assert.True(Empty == msv);
            Assert.True(msv == Empty);
        }
        
        [Fact]
        public void TrimFirst()
        {
            var popped = ((MultiStringValue) Pattern4).TrimFirst();
            Assert.Equal(3, popped.Count);
            Assert.Equal(Pattern5, popped);
            
            popped = popped.TrimFirst();
            Assert.Equal(2, popped.Count);
            Assert.Equal(Pattern6, popped);
            
            popped = popped.TrimFirst();
            Assert.Equal(1, popped.Count);
            Assert.Equal(Pattern7, popped);
            
            popped = ((MultiStringValue) Pattern4).TrimFirst(4);
            Assert.True(popped.IsEmpty);

            try
            {
                ((MultiStringValue) Pattern4).TrimFirst(5);
            }
            catch (Exception ex)
            {
                Assert.IsType<ArgumentOutOfRangeException>(ex);
            }
            popped = ((MultiStringValue) Pattern4).TrimFirst(5, true);
            Assert.True(popped.IsEmpty);
        }

        [Fact]
        public void TrimLast()
        {
            var popped = ((MultiStringValue) Pattern4).TrimLast();
            Assert.Equal(3, popped.Count);
            Assert.Equal(Pattern3, popped);
            
            popped = popped.TrimLast();
            Assert.Equal(2, popped.Count);
            Assert.Equal(Pattern2, popped);
            
            popped = popped.TrimLast();
            Assert.Equal(1, popped.Count);
            Assert.Equal(Pattern1, popped);

            popped = ((MultiStringValue) Pattern4).TrimLast(4);
            Assert.True(popped.IsEmpty);

            try
            {
                ((MultiStringValue) Pattern4).TrimLast(5);
            }
            catch (Exception ex)
            {
                Assert.IsType<ArgumentOutOfRangeException>(ex);
            }
            popped = ((MultiStringValue) Pattern4).TrimLast(5, true);
            Assert.True(popped.IsEmpty);
        }
        
        [Fact]
        public void CopyFirst()
        {
            var msv = (MultiStringValue) Pattern4;
            test(1, Pattern1);
            test(2, Pattern2);
            test(3, Pattern3);
            test(4, Pattern4);
            test(0);
            test(99);

            void test(int count, string expected = null)
            {
                try
                {
                    var copy = msv.CopyFirst(count);
                    Assert.Equal(expected, copy);
                }
                catch (Exception ex)
                {
                    Assert.IsType<ArgumentOutOfRangeException>(ex);
                }
            }
        }
        
        [Fact]
        public void CopyLast()
        {
            var msv = (MultiStringValue) Pattern4;
            test(1, Pattern7);
            test(2, Pattern6);
            test(3, Pattern5);
            test(4, Pattern4);
            test(0);
            test(99);

            void test(uint count, string expected = null)
            {
                try
                {
                    var copy = msv.CopyLast(count);
                    Assert.Equal(expected, copy);
                }
                catch (Exception ex)
                {
                    Assert.IsType<ArgumentOutOfRangeException>(ex);
                }
            }
        }

        [Fact]
        public void StartsWith()
        {
            var msv = (MultiStringValue) Pattern4;
            Assert.True(msv.StartsWith(Pattern1));
            Assert.True(msv.StartsWith(Pattern2));
            Assert.True(msv.StartsWith(Pattern3));
            Assert.True(msv.StartsWith(Pattern4));

            var tooLongPattern = (MultiStringValue) $"{Pattern4},e";
            Assert.False(msv.StartsWith("a,c,b"));
            Assert.False(msv.StartsWith(tooLongPattern));
        }

        [Fact]
        public void EndsWith()
        {
            var msv = (MultiStringValue) Pattern4;
            Assert.True(msv.EndsWith(Pattern4));
            Assert.True(msv.EndsWith(Pattern5));
            Assert.True(msv.EndsWith(Pattern6));
            Assert.True(msv.EndsWith(Pattern7));

            var tooLongPattern = (MultiStringValue) $"{Pattern4},e";
            Assert.False(msv.EndsWith("a,c,b"));
            Assert.False(msv.EndsWith(tooLongPattern));
        }

    }
}