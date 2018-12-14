using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarRentelWebClient
{
    public partial class CustomerForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            CarRentelService.HelloServiceClient client = new CarRentelService.HelloServiceClient("BasicHttpBinding_IHelloService");
            CarRentelService.Customer customer = new CarRentelService.Customer();
            customer.FirstName = txtFirstname.Text;
            customer.LastName = txtLastname.Text;
            customer.TelephoneNumeber = Convert.ToInt32(txtTelephone.Text);
            client.AddCustomer(customer);
        }
    }

        //protected void Send(object sender, EventArgs e)
        //{
        //    CarRentelService.HelloServiceClient client = new CarRentelService.HelloServiceClient("BasicHttpBinding_IHelloService");

        //}
    
}