using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GTA.Web.Engine;

namespace GTA.Windows.Console
{
    class GTAServiceConsumer
    {
        static void Main(string[] args)
        {
            Calculator client = new Calculator();

            System.Console.WriteLine("Write a number for x");
            int x = Convert.ToInt32(System.Console.ReadLine());

            System.Console.WriteLine("Write a number for y");
            int y = Convert.ToInt32(System.Console.ReadLine());

            double addResult = client.AddNumbers(x, y);

            System.Console.WriteLine("And the awesome result is:");
            System.Console.WriteLine(addResult);


            System.Console.ReadLine();
        }
    }
}
