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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AuthorTestService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AuthorTestService.svc or AuthorTestService.svc.cs at the Solution Explorer and start debugging.
    public class AuthorTestService : IAuthorTestService
    {
        public long Divide(PushDivideDataRequest request)
        {
            try
            {
                long n1 = Convert.ToInt64(request.Number1);
                long n2 = Convert.ToInt64(request.Number2);

                return n1 / n2;
            }
            catch (Exception ex)
            {
                DivisionFault fault = new DivisionFault();
                fault.Operation = ex.GetType().BaseType.FullName;
                fault.ProblemType = ex.GetType().Name;
                throw new FaultException<DivisionFault>(fault, fault.ProblemType);
            }
        }

        public PullAuthorDataResponse DoWork(PushAuthorDataRequest request)
        {
            if (request == null)
                throw new FaultException<string>("Request cannot be null");

            //if (request.authorid != "100")
            //    throw new FaultException<string>("Invalid Author", "User is invalid.");


            PullAuthorDataResponse response = new PullAuthorDataResponse();
            response.authorValid = true;
            response._authorData = new AuthorData();
            response._authorData.id = request.authorid;
            response._authorData.firstname = "Payal";
            response._authorData.lastname = "Sharma";
            response._authorData.article = "article-101";

            return response;
        }
    }
}
