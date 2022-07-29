using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Grid_View_Task02
{
    public partial class detail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Convert.ToString(Session["StaffName"]);
            Label2.Text = Convert.ToString(Session["StaffId"]);
            Label3.Text = Convert.ToString(Session["StaffSalary"]);
            Label4.Text=  Convert.ToString(Session["StaffRole"] );
            Label5.Text= Convert.ToString (Session["StaffAddress"]);
        }
    }
}