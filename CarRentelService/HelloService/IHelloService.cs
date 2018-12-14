using CarService.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HelloService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IHelloService" in both code and config file together.
    [ServiceContract(ProtectionLevel = ProtectionLevel.None)]
    public interface IHelloService
    {
        [OperationContract]
        string GetMessage(string name);

        [OperationContract]
        void AddCar(Car car);

        [OperationContract]
        void RemoveCar(int carId);

        [OperationContract(ProtectionLevel = System.Net.Security.ProtectionLevel.None)]
        Car GetCarById(int carId);

        [OperationContract(ProtectionLevel = System.Net.Security.ProtectionLevel.None)]
        void AddCustomer(Customer customer);
       
    }
}
