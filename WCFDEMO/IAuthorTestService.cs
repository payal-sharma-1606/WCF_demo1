using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFDEMO.Contracts;
using WCFDEMO.Faults;

namespace WCFDEMO
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAuthorTestService" in both code and config file together.
    [ServiceContract]
    public interface IAuthorTestService
    {
        [OperationContract]
        PullAuthorDataResponse DoWork(PushAuthorDataRequest request);

        [OperationContract(IsOneWay = true)]
        [FaultContract(typeof(DivisionFault))]
        long Divide(PushDivideDataRequest request);

    }
}
