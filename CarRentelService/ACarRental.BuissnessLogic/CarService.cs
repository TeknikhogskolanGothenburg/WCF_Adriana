using CarService.Data;
using CarService.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACarRental.BuissnessLogic
{
    public class CarService
    {
        private ACarRentelContext inputUserData = new ACarRentelContext();

        public void Add(Car car)
        {
            inputUserData.Cars.Add(car);
            inputUserData.SaveChanges();
        }

        public void Remove(Car car)
        {
            inputUserData.Cars.Remove(car);
            inputUserData.SaveChanges();
        }

        public Car GetCar(int Id)
        {
            return inputUserData.Cars.Find(Id);
        }

    //    public CarStatus(int Id)
    //    {
            
    //    }
    }
}
    
