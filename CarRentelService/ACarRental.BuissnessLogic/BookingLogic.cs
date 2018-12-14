using CarService.Data;
using CarService.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACarRental.BuissnessLogic
{
    public class BookingService
    {
        private ACarRentelContext inputUserData = new ACarRentelContext();

        public void Add(Booking booking)
        {
            inputUserData.Bookings.Add(booking);
            inputUserData.SaveChanges();
        }

        public void Remove(Booking booking)
        {
            inputUserData.Bookings.Remove(booking);
            inputUserData.SaveChanges();
        }

        public List<Car> searchAvaliableCars(DateTime starDateTime, DateTime endDateTime)
        {
            var query = inputUserData.Cars.Where(c =>
                c.Bookings.Where(b => !(b.StartTime > endDateTime && b.EndTime < starDateTime)).ToList().Count == 0);
            return query.ToList();
        }

        /*
                public void LendCar(Car car)
                }

                    var bookings = inputUserData.Bookings.ToList();
                    //var cars = inputUserData.Cars.ToList().Select(x => x.Id == 3);
                    var okCars= new List<string>();
                    int idForTheOKCar = 0;

                    foreach (var bk in bookings)
                    {
                        if (starDateTime >= bk.EndTime && endDateTime <= bk.StartTime)
                        {
                            int idsearched = bk.CarId;
                            var registredNumber = inputUserData.Cars.Select(x => x.RegistrationNumber);
                            bk.CarId;
                            okCars.Add();
                        }
                    }
                }
            */
        /*
                public void ReturnCar(DateTime returnTime, Booking booking)
                {
                    inputUserData.Cars.Find(car.Id).IsReturned = false;
                    inputUserData.SaveChanges();
                }
                */

        public void ReturnCar(Car car)
        {
            inputUserData.Cars.Find(car.Id).IsReturned = true;
            inputUserData.SaveChanges();
        }
    }
}
