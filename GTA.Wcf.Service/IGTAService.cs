using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GTA.Wcf.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IGTAService" in both code and config file together.
    [ServiceContract]
    public interface IGTAService
    {
        [OperationContract]
        double AddNumbers(double number1, double number2);
        [OperationContract]
        double SubstractNumbers(double number1, double number2);
        [OperationContract]
        double MultiplyNumbers(double number1, double number2);
        [OperationContract]
        double DivisionNumbers(double number1, double number2);
        [OperationContract]

    }
}
