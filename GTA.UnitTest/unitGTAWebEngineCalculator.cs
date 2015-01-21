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
        // Variables for the facts
        private int x = 70;
        private int y = 7;
        
        // Facts for all the unit tests
        [Fact]
        public void TestAddNumbers()
        {
            Assert.Equal(77, AddNumbers(x, y));
        }

        [Fact]
        public void TestSubstractNumbers()
        {
            Assert.Equal(63, SubstractNumbers(x, y));
        }

        [Fact]
        public void TestMultiplyNumbers()
        {
            Assert.Equal(490, MultiplyNumbers(x, y));
        }

        [Fact]
        public void TestDivisionNumbers()
        {
            Assert.Equal(10, DivisionNumbers(x, y));
        }


        // Run the actual methods

        double AddNumbers(int x, int y)
        {
            Calculator calc = new Calculator();

            double result = calc.AddNumbers(x, y);

            return result;
        }

        double SubstractNumbers(int x, int y)
        {
            Calculator calc = new Calculator();

            double result = calc.SubstractNumbers(x, y);

            return result;
        }

        double MultiplyNumbers(int x, int y)
        {
            Calculator calc = new Calculator();

            double result = calc.MultiplyNumbers(x, y);

            return result;
        }

        double DivisionNumbers(int x, int y)
        {
            Calculator calc = new Calculator();

            double result = calc.DivisionNumbers(x, y);

            return result;
        }
    }
}
