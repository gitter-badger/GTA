using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTA.Shared.Components
{
    public enum RequestTypes
    {
        AccountableOfflineAllocations,
        AnalysisAccountableNearRealTimeAllocations,
        BufferZones,
        ParameterDampingFormula,
        OperationalAccountableAllocations,
        OperationalAccountableAllocationsEnecogen,
        OperationalAccountablePOS,
        OperationalAccountableSBS,
        OperationalPrognosisPOS,
        OperationalPrognosisSBS,
        StamData,
        StuursignaalShipper,
        ProvidePublicBplInformation,
        NeutralGasPrice
    }
}
