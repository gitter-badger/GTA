using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using GTA.Web.Engine;

namespace GTA.UnitTest
{
    public class unitGTAWebEngineCalculator
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, Add(2, 2));
        }

        [Fact]
        public void TestAddNumbers()
        {

            int x = 5;
            int y = 7;

            Assert.Equal(12, AddNumbers(x, y));
        }

        int Add(int x, int y)
        {
            return x + y;
        }

        public double AddNumbers(int x, int y)
        {
            Calculator calc = new Calculator();

            double result = calc.AddNumbers(x, y);

            return result;
        }
    }
}
