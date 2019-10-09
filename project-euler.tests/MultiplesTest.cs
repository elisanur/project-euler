using System;
using Xunit;

namespace project_euler
{
    public class MultiplesTest
    {
        [Fact]
        public void GetSumOfMultiples(){
          Multiples m = new Multiples(3, 5);
          Assert.Equal(233168, m.GetSumOfMultiples());
            
        }
    }
}