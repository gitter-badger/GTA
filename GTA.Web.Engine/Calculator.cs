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
            var sendMetric = new WriteMetric();
            double result = number1 + number2;
            string typeofcalculation = "AddNumbers";
            sendMetric.CalcValues(number1, number2, result, typeofcalculation);
            logger.Debug("Blablabla");
            return result;
        }

        public double SubstractNumbers(double number1, double number2)
        {
            var sendMetric = new WriteMetric();
            double result = number1 - number2;
            string typeofcalculation = "SubstractNumbers";
            sendMetric.CalcValues(number1, number2, result, typeofcalculation);
            return result;
        }

        public double MultiplyNumbers(double number1, double number2)
        {
            var sendMetric = new WriteMetric();
            double result = number1 * number2;
            string typeofcalculation = "MultiplyNumbers";
            sendMetric.CalcValues(number1, number2, result, typeofcalculation);
            return result;
        }

        public double DivisionNumbers(double number1, double number2)
        {
            var sendMetric = new WriteMetric();
            double result = number1 / number2;
            string typeofcalculation = "DivisionNumbers";
            sendMetric.CalcValues(number1, number2, result, typeofcalculation);
            return result;
        }
    }
}
