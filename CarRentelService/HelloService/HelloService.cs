using ACarRental.BuissnessLogic;
using CarService.Domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


namespace HelloService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HelloService" in both code and config file together.
    public class HelloService : IHelloService
    {
        private readonly ACarRental.BuissnessLogic.CarService carService;
        private readonly ACarRental.BuissnessLogic.CustomerService customerService;

        public Car GetCar(int id)
        {
            Car car = new Car();
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spGetEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parameterId = new SqlParameter();
                parameterId.ParameterName = "@Id";
                parameterId.Value = id;

                cmd.Parameters.Add(parameterId);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    car.Id = Convert.ToInt32(reader["Id"]);
                    car.RegistrationNumber = reader["RegistrationNumber"].ToString();
                    car.Brand = reader["Brand"].ToString();
                    car.Mark = reader["Mark"].ToString();
                    car.Year = Convert.ToInt32(reader["Year"]);
                    car.IsReturned = Convert.ToBoolean(reader["IsReturned "]);
                }
            }
            return car;
        }

        public void SaveCustomer(Customer customer)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spSaveEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parameterFirstname = new SqlParameter
                {
                    ParameterName = "@FirstName",
                    Value = customer.FirstName
                };
                cmd.Parameters.Add(parameterFirstname);

                SqlParameter parameterLastName = new SqlParameter
                {
                    ParameterName = "@LastName",
                    Value = customer.LastName
                };
                cmd.Parameters.Add(parameterLastName);

                SqlParameter parameterTelephone = new SqlParameter
                {
                    ParameterName = "@TelephoneNumeber",
                    Value = customer.TelephoneNumeber
                };
                cmd.Parameters.Add(parameterTelephone);


                SqlParameter parameterEmail = new SqlParameter
                {
                    ParameterName = "@Email",
                    Value = customer.Email
                };
                cmd.Parameters.Add(parameterEmail);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
  
        public HelloService()
        {
            carService = new ACarRental.BuissnessLogic.CarService();
            customerService = new ACarRental.BuissnessLogic.CustomerService();
        }

        public void AddCar(Car car)
        {
            carService.Add(car);
        }

        public Car GetCarById(int carId)
        {
            return carService.GetCar(carId);
        }

        public string GetMessage(string name)
        {
            return "Hello " + name;
        }

        public void RemoveCar(int carId)
        {
            var car = new Car();
            car.Id = carId;
            carService.Remove(car);
        }



        public void AddCustomer(Customer customer)
        {
            customerService.Add(customer);
        }
        
        //public void CarStatus(CarService car)
        //{
        //    CarService.Add.(car)


        //}

    }
}
