using System;
using Xunit;

namespace project_euler
{
    public class LargestPalindromeTest
    {
        [Fact]
        public void intIsPalindrome(){
            LargestPalindromeProduct lpp = new LargestPalindromeProduct(999,999);
            Assert.Equal("906609", lpp.BiggestPalindromeNumber());
        }
        [Fact]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            LargestPalindromeProduct lpp = new LargestPalindromeProduct(10000000,1948948498);
            string res = lpp.BiggestPalindromeNumber();
            Assert.Equal(res, "I couldn't find a palindrome product, did you insert whole numbers between 0 and 9999?");
        }
    }
}
