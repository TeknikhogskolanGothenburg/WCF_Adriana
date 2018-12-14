using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Domain
{

    //[KnownType(typeof(VolvoCar))]
    //[KnownType(typeof(BmwCar))]
    [DataContract(Namespace = "")]
    public class Car
    {
        private int _id;
        private string _registrationNumber;
        private string _brand;
        private string _mark;
        private int _year;

       // List<Booking> Bookings;
        public Car()
        {
           // Bookings = new List<Booking>();
        }
       
        [DataMember(Order = 1, Name = "ID")]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [DataMember(Order = 2)]
        public string RegistrationNumber
        {
            get { return _registrationNumber; }
            set { _registrationNumber = value; }
        }

        [DataMember(Order = 3)]
        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        [DataMember(Order = 4)]
        public string Mark
        {
            get { return _mark; }
            set { _mark = value; }
        }

        [DataMember(Order = 5)]
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        [DataMember(Order = 6)]
        public List<Booking> Bookings {get; set; }

        [DataMember]
        public bool IsReturned { get; set; }
    }
    public enum CarType
    {
        VolvoCar = 1,
        BmwCar = 2
    }
    //[DataMember]
    //public CarStatus Status { get; set; }
    //public enum CarStatus 
    //{ Available, Unavailable };
}







