using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Configuration;
using System.Xml;

namespace GTA.Wcf.Service
{
    public class GTAMetricHandler : ConfigurationSection
    {
        public async void Write_Metric(double number1, double number2, double result, string calculation) // TO-DO Overload can be variable
        {
            string myFirstpony = ConfigurationManager.AppSettings["influxdburl"];
            string mySecondpony = ConfigurationManager.AppSettings["influxdbuser"];
            string myThirdpony = ConfigurationManager.AppSettings["influxdbpass"];
            //var _db = new LibInfluxDB.Net.InfluxDb("http://influxdbservert:8086", "gebruikert", "wachtwoordje"); // TO-DO Use web.conf for this.
            var _db = new LibInfluxDB.Net.InfluxDb(myFirstpony, mySecondpony, myThirdpony); // TO-DO Use web.conf for this.
            string dbName = "GTACalculator";
            LibInfluxDB.Net.Models.Serie serie = new LibInfluxDB.Net.Models.Serie.Builder("GTA.Wcf.Service")
                .Columns("First", "Second", "Result", "Calculation") // TO-DO Overload can be variable
                .Values(number1, number2, result, calculation) // TO-DO Overload can be variable
                .Build();
            LibInfluxDB.Net.InfluxDbApiResponse writeResponse = await _db.WriteAsync(dbName, LibInfluxDB.Net.TimeUnit.Milliseconds, serie);
        }

        public class MetricParser
        {
            public string InputValue1 { get; set; }
            public string InputValue2 { get; set; }
            public string Result { get; set; }
            public string Calculation { get; set; }
        }
    }
}