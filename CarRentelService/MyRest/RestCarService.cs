using CarService.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Xml;

namespace MyRest
{
     //NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RestCarService" in both code and config file together.
    public class RestCarService : IRestCarService
    {
        private List<Car> cars;
        private List<Customer> customers;

        public RestCarService()
        {
            List<Car> cars = new List<Car>
            {
                new Car
                {
                    Id= 1,
                    RegistrationNumber = "abc123",
                    Brand = "volvo",
                    Mark = "s60",
                    Year = 1998,
                    IsReturned = true
                }
            };

            List<Customer> customers = new List<Customer>
            {
                new Customer
                {
                    Id = 1,
                    FirstName = "Anna",
                    LastName = "Jam",
                    TelephoneNumeber = 0735031843,
                    Email = "anna.jam@gmail.com",

                }

            };
        }

        public void Addcar(string RegistrationNumber, string Brand, string Mark, int Year)
        {
            throw new NotImplementedException();
        }

        public string AddCar(Car newCar)
        {
            cars.Add(newCar);
                return"I got" + newCar;
        }

        public List<Car> GetCar()
        {
            return cars;
        }

        public void Removecar()
        {
            
        }

        public void AddCustomer()
        {

        }
        public string PostSeveraItems()
        {
            String JSONstring = OperationContext.Current.RequestContext.RequestMessage.ToString();
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(JSONstring);
            string s = "";
            foreach(XmlNode node in doc.DocumentElement.ChildNodes)
            {
                if(node.Name == "otherItems")
                {
                    s += node.Name + " = " + node.InnerText + " - ";
                }
                else
                {
                    s += "Ignoring key" + node.Name + " - ";
                }
            }
            return s;
        }

        public List<Car> GetAllCars()
        {
            return cars;
        }

        public string AddCustomer(Customer newCustomer)
        {
            customers.Add(newCustomer);
            return "I got " + newCustomer;
        }


        public string AddItem(string newItem)
        {
            throw new NotImplementedException();
        }
    }
}


