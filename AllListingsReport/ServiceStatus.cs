using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllListingsReport
{
    public enum ServiceStatus
    {
        Unknown,
        AppStart,
        AppFinish,
        InsertingData,
        NetworkTrouble,
        AWS_Submitted,
        AWS_InProgress,
        AWS_Canceled,
        AWS_Done,
        AWS_NoData
    }
}
