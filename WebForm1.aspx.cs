using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace task02_state_mangemnt
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["data_list"] == null)
                {
                    New_gnerate_krdoo();
                }
                else
                {
                    Purani_return_krdoo();
                }
                STAFFGRIDDATA.DataSource = Session["data_list"];
                STAFFGRIDDATA.DataBind();
            }
        }
        protected void GV_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int indexrow = e.RowIndex;
            List<Staff> list = (List<Staff>)Session["data_list"];
            list.RemoveAt(indexrow);
            Session["data_list"] = list;
            STAFFGRIDDATA.DataSource = Session["data_list"];
            STAFFGRIDDATA.DataBind();
        }


        protected void GV_RowEditing(object sender, GridViewEditEventArgs e)
        {
            STAFFGRIDDATA.EditIndex = e.NewEditIndex;
            Purani_return_krdoo();
            //List<Staff> list = (List<Staff>)Session["data_list"];
        }
        protected void TaskGridView_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            //Reset the edit index.
            // TaskGridView.EditIndex = -1;
            //Bind data to the GridView control.
            STAFFGRIDDATA.EditIndex = -1;
            Purani_return_krdoo();

        }
        protected void STAFFGRIDDATA_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            //RETERIVING DATA FROM THE SCESSION TABLE;
            List<Staff> list = (List<Staff>)Session["data_list"];
            int userid= e.RowIndex;
            GridViewRow row = (GridViewRow)STAFFGRIDDATA.Rows[userid];
            //getting the value of the rows based on that specefied index
            TextBox textName = (TextBox)row.Cells[1].Controls[0];
            TextBox textRole = (TextBox)row.Cells[2].Controls[0];
        
            list[userid].StaffName = textName.Text;
            list[userid].StaffRole = textRole.Text;
            
            STAFFGRIDDATA.EditIndex = -1;
            Session["data_list"]=list;
            Purani_return_krdoo();
        }
        protected void STAFFGRIDDATA_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            STAFFGRIDDATA.PageIndex = e.NewPageIndex;
            //Bind data to the GridView control.
            Purani_return_krdoo();
        }

        protected void Purani_return_krdoo()
        {
            STAFFGRIDDATA.DataSource = Session["data_list"];
            STAFFGRIDDATA.DataBind();
        }

        protected void New_gnerate_krdoo()
        {
            //here updating the index of the array with the randomized key generated
            var list = new Staff().GetStaffList();
            Random rnd = new Random();
            foreach (var elemnt in list)
            {
                int temp = rnd.Next(10, 99);
                string con = (elemnt.StaffID).ToString() + temp.ToString();
                elemnt.StaffID = Convert.ToInt32(con);
            }
            STAFFGRIDDATA.DataSource = list;
            STAFFGRIDDATA.DataBind();
            Session["data_list"] = list;
        }
        public class Staff
        {
            public int StaffID { get; set; }
            public string StaffName { get; set; }
            public string StaffRole { get; set; }
            public string StaffSalary { get; set; }
            public string StaffAddress { get; set; }
            public List<Staff> GetStaffList()
            {
                List<Staff> lstStaff = new List<Staff>();
                //Here setting the values and adding them in our list..

                Staff staff = new Staff
                {
                    StaffID = 1,
                    StaffName = "Talha Shafeeq",
                    StaffRole = "Manager",
                    StaffSalary = "15000",
                    StaffAddress = "123 Xyz City,Lahore"
                };
                lstStaff.Add(staff);

                staff = new Staff
                {
                    StaffID = 2,
                    StaffName = "Tuba",
                    StaffRole = "Assiatant",
                    StaffSalary = "12000",
                    StaffAddress = "123 Xyz City,Lahore"
                };
                lstStaff.Add(staff);


                staff = new Staff
                {
                    StaffID = 3,
                    StaffName = "Tahira",
                    StaffRole = "Manager",
                    StaffSalary = "12000",
                    StaffAddress = "123 Xyz City,Lahore"
                };
                lstStaff.Add(staff);



                staff = new Staff
                {
                    StaffID = 4,
                    StaffName = "lala",
                    StaffRole = "Worker",
                    StaffSalary = "11000",
                    StaffAddress = "123 Xyz City,Lahore"
                };
                lstStaff.Add(staff);


                staff = new Staff
                {
                    StaffID = 5,
                    StaffName = "Hadeeqa",
                    StaffRole = "Worker",
                    StaffSalary = "11000",
                    StaffAddress = "123 Xyz City,Lahore"
                };
                lstStaff.Add(staff);

                staff = new Staff
                {
                    StaffID = 6,
                    StaffName = "Rana",
                    StaffRole = "Sweeper",
                    StaffSalary = "1000",
                    StaffAddress = "123 Xyz City,Lahore"
                };
                lstStaff.Add(staff);

                staff = new Staff
                {
                    StaffID = 7,
                    StaffName = "Majid",
                    StaffRole = "Programmer",
                    StaffSalary = "11000",
                    StaffAddress = "123 Xyz City,Lahore"
                };
                lstStaff.Add(staff);

                staff = new Staff
                {
                    StaffID = 8,
                    StaffName = "Kamran",
                    StaffRole = "Programmer",
                    StaffSalary = "11000",
                    StaffAddress = "123 Xyz City,Lahore"
                };
                lstStaff.Add(staff);

                staff = new Staff
                {
                    StaffID = 9,
                    StaffName = "Azra",
                    StaffRole = "Programmer",
                    StaffSalary = "11000",
                    StaffAddress = "123 Xyz City,Lahore"
                };
                lstStaff.Add(staff);

                staff = new Staff
                {
                    StaffID = 10,
                    StaffName = "Ruhma",
                    StaffRole = "Worker",
                    StaffSalary = "11000",
                    StaffAddress = "123 Xyz City,Lahore"
                };
                lstStaff.Add(staff);

                staff = new Staff
                {
                    StaffID = 11,
                    StaffName = "Nasir",
                    StaffRole = "Worker",
                    StaffSalary = "11000",
                    StaffAddress = "123 Xyz City,Lahore"
                };
                lstStaff.Add(staff);


                staff = new Staff
                {
                    StaffID = 12,
                    StaffName = "Waqar",
                    StaffRole = "Worker",
                    StaffSalary = "11000",
                    StaffAddress = "123 Xyz City,Lahore"
                };
                lstStaff.Add(staff);

                staff = new Staff
                {
                    StaffID = 13,
                    StaffName = "Sameen ul allah",
                    StaffRole = "Worker",
                    StaffSalary = "11000",
                    StaffAddress = "123 Xyz City,Lahore"
                };
                lstStaff.Add(staff);

                staff = new Staff
                {
                    StaffID = 14,
                    StaffName = "Usama",
                    StaffRole = "Worker",
                    StaffSalary = "11000",
                    StaffAddress = "123 Xyz City,Lahore"
                };
                lstStaff.Add(staff);


                staff = new Staff
                {
                    StaffID = 15,
                    StaffName = "Mukhtaar",
                    StaffRole = "Worker",
                    StaffSalary = "11000",
                    StaffAddress = "123 Xyz City,Lahore"
                };
                lstStaff.Add(staff);
                return lstStaff;

            }
        }
        protected void search_button_Click1(object sender, EventArgs e)
        {
            var data_to_be_compared = search_box.Text;
            var list = Session["data_list"] as List<Staff>;

            foreach (var elemnt in list)
            {
                //if (elemnt.StaffName.ToLower().StartsWith(data_to_be_compared.ToLower()))
                if(data_to_be_compared.ToLower().Equals(elemnt.StaffName.ToLower()))
                {
                    Session["StaffName"] = elemnt.StaffName;
                    Session["StaffId"] = elemnt.StaffID;
                    Session["StaffSalary"] = elemnt.StaffSalary;
                    Session["StaffRole"] = elemnt.StaffRole;
                    Session["StaffAddress"] = elemnt.StaffAddress;
                    Response.Redirect("detail.aspx");
                    break;
                }
                else
                {
                    Output_label.Text = "Search value is not found!";
                }
            }
        }

       
    }


}
  