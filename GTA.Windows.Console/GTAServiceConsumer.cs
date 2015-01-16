using GTA.Windows.Console.GTAService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTA.Windows.Console
{
    class GTAServiceConsumer
    {
        static void Main(string[] args)
        {
            GTAServiceClient client = new GTAServiceClient();

            double addResult = client.AddNumbers(5, 3);
            System.Console.WriteLine("And the awesome result is:");
            System.Console.WriteLine(addResult);
            System.Console.ReadLine();
        }
    }
}
