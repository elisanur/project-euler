using System;
using Xunit;

namespace project_euler
{
    public class SumSquareDifferenceTest
    {
        [Fact]
        public void positiveDifference(){
          SumSquareDifference m = new SumSquareDifference(100);
          Assert.Equal(25164150, m.result());
            
        }
    }
}