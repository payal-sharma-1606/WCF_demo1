using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Web;

namespace WCFDEMO.Contracts
{
    [DataContract]
    public class AuthorData
    {
        [DataMember]
        public string id { get; set; }

        [DataMember]
        public string firstname { get; set; }

        [DataMember]
        public string lastname { get; set; }

        [DataMember]
        public string article { get; set; }
    }

    [DataContract]
    public class DivisionData
    {
        [DataMember]
        public string no1 { get; set; }

        [DataMember]
        public string no2 { get; set; }

        [DataMember]
        public string divisionResult { get; set; }
    }

    //[MessageContract(ProtectionLevel = System.Net.Security.ProtectionLevel.EncryptAndSign)]
    public class PushAuthorDataRequest
    {
        [MessageHeader(Name = "AuthorID")]
        public string authorid { get; set; }
    }

    //[MessageContract(ProtectionLevel = System.Net.Security.ProtectionLevel.EncryptAndSign)]
    public class PullAuthorDataResponse
    {
        [MessageHeader(Name = "IsAuthorValid", Namespace = "http://localhost:5631/AuthorTestService.svc")]
        public bool authorValid;

        [MessageBodyMember(Name = "AuthorData")]
        public AuthorData _authorData { get; set; }
    }


    //[MessageContract(ProtectionLevel = System.Net.Security.ProtectionLevel.EncryptAndSign)]
    public class PushDivideDataRequest
    {
        [MessageHeader(Name = "N1")]
        public string Number1 { get; set; }

        [MessageHeader(Name = "N2")]
        public string Number2 { get; set; }
    }

    //[MessageContract(ProtectionLevel = System.Net.Security.ProtectionLevel.EncryptAndSign)]
    public class PullDivideDataResponse
    {
        [MessageHeader(Name = "IsValidDivide", Namespace = "http://localhost:5631/AuthorTestService.svc")]
        public bool divisionValid;

        [MessageBodyMember(Name = "AuthorData")]
        public DivisionData _divisionData { get; set; }
    }

}