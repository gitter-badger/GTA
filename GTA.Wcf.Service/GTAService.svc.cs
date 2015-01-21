﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Stopwatch = System.Diagnostics.Stopwatch;
using NLog;
using GTA.Shared.Components;

namespace GTA.Wcf.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "GTAService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select GTAService.svc or GTAService.svc.cs at the Solution Explorer and start debugging.
    public class GTAService : IGTAService
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

        protected virtual void FinalizeSetUp()
        {
        }
    
        public void Write_Metric(string poep, string pap)
        {
 	        throw new NotImplementedException();
        }
}
}
