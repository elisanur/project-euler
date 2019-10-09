using System;
using Xunit;

namespace project_euler
{
    public class Class1
    {
        [Fact]
        public void intIsPalindrome(){
            LargestPalindromeProduct lpp = new LargestPalindromeProduct(999,999);
            Assert.Equal("906609", lpp.BiggestPalindromeNumber());
        }

    }
}
