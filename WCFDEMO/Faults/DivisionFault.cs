using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFDEMO.Faults
{
    [DataContract(Namespace = "http://localhost:5631/AuthorTestService.svc")]
    public class DivisionFault
    {
        private string operation;
        private string problemType;

        [DataMember]
        public string Operation
        {
            get { return operation; }
            set { operation = value; }
        }

        [DataMember]
        public string ProblemType
        {
            get { return problemType; }
            set { problemType = value; }
        }
    }
}