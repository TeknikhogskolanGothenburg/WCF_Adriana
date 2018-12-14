using CarService.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace MyRest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRestCarService" in both code and config file together.
    [ServiceContract]
    public interface IRestCarService
    {
        [OperationContract]
        void Addcar(string RegistrationNumber, string Brand, string Mark, int Year);
        //[WebGet(UriTemplate = "Cars",
        //    RequestFormat = WebMessageFormat.Json,
        //    ResponseFormat = WebMessageFormat.Json)]

        //List<string> GetAllCar();

        [OperationContract]
        [WebInvoke(Method = "POST",
            UriTemplate = "Car",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped)]
        string AddCustomer(Customer customer);

        [OperationContract]
        [WebInvoke(Method = "POST",
            UriTemplate = "Customer",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        string PostSeveraItems();
    }



}
