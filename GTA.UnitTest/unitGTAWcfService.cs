using GTA.UnitTest.GTAService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GTA.UnitTest
{
    public class unitGTAWcfService
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
            using (var client = new GTAServiceClient())
            {
                double result = client.AddNumbers(x, y);

                return result;
            }
        }
    }
}
