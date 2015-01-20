using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTA.Shared.Components
{
    public interface IMetricHandler
    {
        void Write_Metric(double number1, double number2, double result, string calculation);
        // As long as its calculator we use: (double)INPUT1, (double)INPUT2, (double)RESULT, type of (string)CALCULATION (1 2 3 AddNumbers)
    }
}
