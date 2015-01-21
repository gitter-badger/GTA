using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Configuration;
using System.Xml;
using System.Threading.Tasks;
using NLog;

namespace GTA.Shared.Components
{
    public class WriteMetric : ConfigurationSection, IMetricHandler
    {
        string useInfluxDB = ConfigurationManager.AppSettings["useInfluxdb"].ToLower();
        private static Logger logger = LogManager.GetCurrentClassLogger();
       
        // Get basic influxdb config
        
        string myFirstpony = ConfigurationManager.AppSettings["influxdburl"].ToLower();
        string mySecondpony = ConfigurationManager.AppSettings["influxdbuser"];
        string myThirdpony = ConfigurationManager.AppSettings["influxdbpass"];
        string influxdbdb = ConfigurationManager.AppSettings["influxdbdb"];
        
        // Build payload and send it to influxdb
        public async Task<string> pushMetric(string metricName, string[] Columns, object[] Values)
        {
            object[] objSerie = new object[3];
            LibInfluxDB.Net.InfluxDb influxConnect = new LibInfluxDB.Net.InfluxDb(myFirstpony, mySecondpony, myThirdpony);

            LibInfluxDB.Net.Models.Serie metricPayload = new LibInfluxDB.Net.Models.Serie.Builder(metricName).Columns(Columns).Values(Values).Build();
            LibInfluxDB.Net.InfluxDbApiResponse pushMetric = await influxConnect.WriteAsync(influxdbdb, LibInfluxDB.Net.TimeUnit.Milliseconds, metricPayload);
            return "Metric sent";
        }
        
        public async void SendMetrics(string TimeSerie, string[] Columns, object[] Values)
        {
            if (useInfluxDB == "true")
            {
                await pushMetric(TimeSerie, Columns, Values);
            }
            else
            {
                return;
            }
        }
    }
}




// <add key="useInfluxdb" value="true" />