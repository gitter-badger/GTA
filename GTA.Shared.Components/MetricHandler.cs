using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Configuration;
using System.Xml;
using System.Threading.Tasks;

namespace GTA.Shared.Components
{
    public class WriteMetric : ConfigurationSection, IMetricHandler
    {
        // Get basic influxdb config
        string myFirstpony = ConfigurationManager.AppSettings["influxdburl"];
        string mySecondpony = ConfigurationManager.AppSettings["influxdbuser"];
        string myThirdpony = ConfigurationManager.AppSettings["influxdbpass"];
        string influxdbdb = ConfigurationManager.AppSettings["influxdbdb"];

        public async Task<string> pushMetric(string metricName, string[] Columns, object[] Values)
        {
            object[] objSerie = new object[3];
            LibInfluxDB.Net.InfluxDb influxConnect = new LibInfluxDB.Net.InfluxDb(myFirstpony, mySecondpony, myThirdpony);

            LibInfluxDB.Net.Models.Serie metricPayload = new LibInfluxDB.Net.Models.Serie.Builder(metricName).Columns(Columns).Values(Values).Build();
            LibInfluxDB.Net.InfluxDbApiResponse pushMetric = await influxConnect.WriteAsync(influxdbdb, LibInfluxDB.Net.TimeUnit.Milliseconds, metricPayload);
            return "Metric sent";
        }

        public async void CalcValues(double number1, double number2, double result, string typeofcalculation)
        {
            string metricName = typeofcalculation;
            String[] Columns = new String[3];
            Columns[0] = "FirstValue";
            Columns[1] = "SecondValue";
            Columns[2] = "ThirdValue";
            object[] Values = new object[3];
            Values[0] = number1;
            Values[1] = number2;
            Values[2] = result;
            await pushMetric(metricName, Columns, Values);
        }
    }
}