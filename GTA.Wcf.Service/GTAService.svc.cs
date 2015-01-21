using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Stopwatch = System.Diagnostics.Stopwatch;
using NLog;
using GTA.Shared.Components;
using GTA.Web.Engine;

namespace GTA.Wcf.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "GTAService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select GTAService.svc or GTAService.svc.cs at the Solution Explorer and start debugging.
    public class GTAService : IGTAService
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public double AddNumbers(double number1, double number2)
        {
<<<<<<< HEAD
            Calculator calc = new Calculator();

            double result = calc.AddNumbers(number1, number2);

=======
            var metrics = new WriteMetric();
            double result = number1 + number2;

            // Send results as metrics to metric database
            string TimeSerie = "AddNumbers";
            object[] Values = new object[3] { number1, number2, result };
            string[] Columns = new string[3] { "Value1", "Value2", "Result" };
            metrics.SendMetrics(TimeSerie, Columns, Values);

            // Do some debugging logging blurp
            logger.Debug("Blablabla");
>>>>>>> f947770f31accb3f708abd7e90de05178c18ab59
            return result;
        }

        public double SubstractNumbers(double number1, double number2)
        {
<<<<<<< HEAD
            Calculator calc = new Calculator();

            double result = calc.SubstractNumbers(number1, number2);

=======
            var metric = new WriteMetric();
            double result = number1 - number2;

            // Send results as metrics to metric database
            string TimeSerie = "SubstractNumbers";
            object[] Values = new object[3] { number1, number2, result };
            string[] Columns = new string[3] { "Value1", "Value2", "Result" };
            metric.SendMetrics(TimeSerie, Columns, Values);
            // Done
>>>>>>> f947770f31accb3f708abd7e90de05178c18ab59
            return result;
        }

        public double MultiplyNumbers(double number1, double number2)
        {
<<<<<<< HEAD
            Calculator calc = new Calculator();

            double result = calc.MultiplyNumbers(number1, number2);

=======
            var metric = new WriteMetric();
            double result = number1 * number2;

            // Send results as metrics to metric database
            string TimeSerie = "MultiplyNumbers";
            object[] Values = new object[3] { number1, number2, result };
            string[] Columns = new string[3] { "Value1", "Value2", "Result" };
            metric.SendMetrics(TimeSerie, Columns, Values);
            // Done
>>>>>>> f947770f31accb3f708abd7e90de05178c18ab59
            return result;
        }

        public double DivisionNumbers(double number1, double number2)
        {
<<<<<<< HEAD
            Calculator calc = new Calculator();

            double result = calc.DivisionNumbers(number1, number2);

=======
            var metric = new WriteMetric();
            double result = number1 / number2;

            // Send results as metrics to metric database
            string TimeSerie = "DivisionNumbers";
            object[] Values = new object[3] { number1, number2, result };
            string[] Columns = new string[3] { "Value1", "Value2", "Result" };
            metric.SendMetrics(TimeSerie, Columns, Values);
            // Done
>>>>>>> f947770f31accb3f708abd7e90de05178c18ab59
            return result;
        }

        protected virtual void FinalizeSetUp()
        {
        }
    
        public void Write_Metric(string poep, string pap)
        {
 	        throw new NotImplementedException();
        }
}
}
