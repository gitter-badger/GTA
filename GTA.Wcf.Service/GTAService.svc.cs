﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GTA.Wcf.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "GTAService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select GTAService.svc or GTAService.svc.cs at the Solution Explorer and start debugging.
    public class GTAService : IGTAService
    {
        public double AddNumbers(double number1, double number2)
        {
            double result = number1 + number2;
            return result;
        }

        public double SubstractNumbers(double number1, double number2)
        {
            double result = number1 - number2;
            return result;
        }

        public double MultiplyNumbers(double number1, double number2)
        {
            double result = number1 * number2;
            return result;
        }

        public double DivisionNumbers(double number1, double number2)
        {
            double result = number1 / number2;
            return result;
        }
    }
}
