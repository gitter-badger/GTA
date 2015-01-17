using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using LibInfluxDB.NET;
using NLog;

namespace GTA.Wcf.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "GTAService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select GTAService.svc or GTAService.svc.cs at the Solution Explorer and start debugging.
    public class GTAService : IGTAService
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        //public async void Write_Metric(double number1, double number2, double result)
        //{
        //    var _db = new LibInfluxDB.Net.InfluxDb("http://influxdbserver:8086", "naampje", "wachtwoord");
        //    string dbName = "GTACalculator";
        //    LibInfluxDB.Net.Models.Serie serie = new LibInfluxDB.Net.Models.Serie.Builder("GTA.Wcf.Service")
        //        .Columns("First", "Second", "Result")
        //        .Values(number1, number2, result)
        //        .Build();
        //    LibInfluxDB.Net.InfluxDbApiResponse writeResponse = await _db.WriteAsync(dbName, LibInfluxDB.Net.TimeUnit.Milliseconds, serie);
        //}
        public double AddNumbers(double number1, double number2)
        {
            var sendMetric = new GTAMetricHandler();
            double result = number1 + number2;
            sendMetric.Write_Metric(number1, number2, result, "AddNumbers");
            return result;
        }

        public double SubstractNumbers(double number1, double number2)
        {
            var sendMetric = new GTAMetricHandler();
            double result = number1 - number2;
            sendMetric.Write_Metric(number1, number2, result, "SubstractNumbers");
            return result;
        }

        public double MultiplyNumbers(double number1, double number2)
        {
            var sendMetric = new GTAMetricHandler();
            double result = number1 * number2;
            sendMetric.Write_Metric(number1, number2, result, "MultiplyNumbers");
            return result;
        }

        public double DivisionNumbers(double number1, double number2)
        {
            var sendMetric = new GTAMetricHandler();
            double result = number1 / number2;
            sendMetric.Write_Metric(number1, number2, result, "DivisionNumbers");
            return result;
        }
        protected virtual void FinalizeSetUp()
        {
        }
    }
}
