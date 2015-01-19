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
        [ConfigurationProperty("useInfluxdb", DefaultValue = "true", IsRequired = false)]
        public Boolean useInfluxdb
        {
            get
            {
                return (Boolean)this["useInfluxdb"];
            }
            set
            {
                this["useInfluxdb"] = value;
            }
        }

        [ConfigurationProperty("influxdburl", DefaultValue = "http://localhost:8086", IsRequired = false)]
        public string influxdburl
        {
            get
            {
                return (string)this["influxdburl"];
            }
            set
            {
                this["influxdburl"] = value;
            }
        }

        [ConfigurationProperty("influxdbuser", DefaultValue = "admin", IsRequired = false)]
        public string influxdbuser
        {
            get
            {
                return (string)this["influxdbuser"];
            }
            set
            {
                this["influxdbuser"] = value;
            }
        }

        [ConfigurationProperty("influxdbpass", DefaultValue = "secret", IsRequired = false)]
        public string influxdbpass
        {
            get
            {
                return (string)this["influxdbpass"];
            }
            set
            {
                this["influxdbpass"] = value;
            }
        }

        public async void Write_Metric(double number1, double number2, double result, string calculation) // TO-DO Overload can be variable
        {

            //var _db = new LibInfluxDB.Net.InfluxDb("http://influxdbservert:8086", "gebruikert", "wachtwoordje"); // TO-DO Use web.conf for this.
            var _db = new LibInfluxDB.Net.InfluxDb(influxdburl, influxdbuser, influxdbpass); // TO-DO Use web.conf for this.
            string dbName = "GTACalculator";
            LibInfluxDB.Net.Models.Serie serie = new LibInfluxDB.Net.Models.Serie.Builder("GTA.Wcf.Service")
                .Columns("First", "Second", "Result", "Calculation") // TO-DO Overload can be variable
                .Values(number1, number2, result, calculation) // TO-DO Overload can be variable
                .Build();
            LibInfluxDB.Net.InfluxDbApiResponse writeResponse = await _db.WriteAsync(dbName, LibInfluxDB.Net.TimeUnit.Milliseconds, serie);
        }
    }
}