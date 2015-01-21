using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace GTA.Shared.Components
{
    [ServiceContract]
    public interface IMetricHandler
    {
        // Some basic contracts that don't make sense right now (no requirements yet!)
        //[OperationContract]
        //void CalcValues(double number1, double number2, double result, string typeofcalculation);
        //[OperationContract]
        //void TimingMetrics(double GTSPullLatency, double GTSConvertDataTimeTaken, double GTSWriteToFileTime, string GTSType);
        //[OperationContract]
        //void GasPrices();
        [OperationContract]
        void SendMetrics(string TimeSerie, string[] Columns, object[] Values);

        // As long as its calculator we use: (double)INPUT1, (double)INPUT2, (double)RESULT, type of (string)CALCULATION (1 2 3 AddNumbers)
    }
}
