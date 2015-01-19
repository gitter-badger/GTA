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
        // this should add thre doubles and then output "succes"
    }
}
