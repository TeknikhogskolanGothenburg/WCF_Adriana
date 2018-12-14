using CarService.Data;
using CarService.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACarRental.BuissnessLogic
{
   
   public class CustomerService
    {
        private ACarRentelContext inputUserData = new ACarRentelContext();

        public void Add(Customer customer)
        {
            inputUserData.Customers.Add(customer);
            inputUserData.SaveChanges();
        }

        public void Change(Customer customer)
        {
            inputUserData.Customers.Update(customer);
            inputUserData.SaveChanges();
        }

        public void Remove(Customer customer)
        {
            inputUserData.Customers.Remove(customer);
            inputUserData.SaveChanges();
        }
    }
}