using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using GTA.Shared.Components;
using Stopwatch = System.Diagnostics.Stopwatch;

namespace GTA.Web.Engine
{
    public class Calculator
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public double AddNumbers(double number1, double number2)
        {
            var metrics = new WriteMetric();
            double result = number1 + number2;

            // Send results as metrics to metric database
            string TimeSerie = "AddNumbers";
            object[] Values = new object[3] { number1, number2, result };
            string[] Columns = new string[3] { "Value1", "Value2", "Result" };
            metrics.SendMetrics(TimeSerie, Columns, Values);

            // Do some debugging logging blurp
            logger.Debug("Blablabla");
            return result;
        }

        public double SubstractNumbers(double number1, double number2)
        {
            var metric = new WriteMetric();
            double result = number1 - number2;

            // Send results as metrics to metric database
            string TimeSerie = "SubstractNumbers";
            object[] Values = new object[3] { number1, number2, result };
            string[] Columns = new string[3] { "Value1", "Value2", "Result" };
            metric.SendMetrics(TimeSerie, Columns, Values);
            // Done
            return result;
        }

        public double MultiplyNumbers(double number1, double number2)
        {
            var metric = new WriteMetric();
            double result = number1 * number2;

            // Send results as metrics to metric database
            string TimeSerie = "MultiplyNumbers";
            object[] Values = new object[3] { number1, number2, result };
            string[] Columns = new string[3] { "Value1", "Value2", "Result" };
            metric.SendMetrics(TimeSerie, Columns, Values);
            // Done
            return result;
        }

        public double DivisionNumbers(double number1, double number2)
        {
            var metric = new WriteMetric();
            double result = number1 / number2;

            // Send results as metrics to metric database
            string TimeSerie = "DivisionNumbers";
            object[] Values = new object[3] { number1, number2, result };
            string[] Columns = new string[3] { "Value1", "Value2", "Result" };
            metric.SendMetrics(TimeSerie, Columns, Values);
            // Done
            return result;
        }
    }
}
