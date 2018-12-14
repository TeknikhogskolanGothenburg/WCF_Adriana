using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarRentelWebClient
{
    public partial class CarForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGetCar_Click(object sender, EventArgs e)
        {
            CarRentelService.HelloServiceClient client = new CarRentelService.HelloServiceClient("BasicHttpBinding_IHelloService");

            try
            {
                CarRentelService.Car car = client.GetCarById(Convert.ToInt32(txtId.Text));
                txtRegNo.Text = car.RegistrationNumber;
                txtBrand.Text = car.Brand;
                txtMark.Text = car.Mark;
                txtYear.Text = car.Year.ToString();
                chkReturned.Checked = car.IsReturned;
            }
            catch (Exception ex)
            {
                txtBrand.Text = "Failed to connect to service, try again!";
            }

        }

        protected void btnSaveCar_Click(object sender, EventArgs e)
        {
            try
            {
                CarRentelService.HelloServiceClient client = new CarRentelService.HelloServiceClient("BasicHttpBinding_IHelloService");

                CarRentelService.Car car = client.GetCarById(Convert.ToInt32(txtId.Text));
                txtRegNo.Text = car.RegistrationNumber;
                txtBrand.Text = car.Brand;
                txtMark.Text = car.Mark;
                txtYear.Text = car.Year.ToString();
                chkReturned.Checked = car.IsReturned;
            }
            catch (Exception ex)
            {
                txtBrand.Text = "Failed to connect to service, try again!";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {

                CarRentelService.HelloServiceClient client = new CarRentelService.HelloServiceClient("BasicHttpBinding_IHelloService");
                CarRentelService.Car car = new CarRentelService.Car();
                car.RegistrationNumber = txtRegNo.Text;
                car.Brand = txtBrand.Text;
                car.Mark = txtMark.Text;
                car.Year = Convert.ToInt32(txtYear.Text);
                car.IsReturned = Convert.ToBoolean(chkReturned.Checked);
                client.AddCar(car);
            }
            catch (Exception ex)
            {
                txtBrand.Text = "Failed to connect to service, try again!";
            }
        }
    }
}