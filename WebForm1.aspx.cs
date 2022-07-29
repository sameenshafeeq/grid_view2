using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Grid_View_Task02
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Session["data_list"] = 
           // var my_list = new Staff().GetStaffList();
            //Session["length_mylist"] = my_list.Count;
           // Session["length_of_my_array"] = Convert.ToInt32(new Staff().GetStaffList().Count);
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
            //Update_List();
            //STAFFGRIDDATA.DataSource = Session["data_list"];
            //STAFFGRIDDATA.DataBind();
;            ///here i am going to store my_list of staff in a secsion_state so that the value can later on be acheived 
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


        protected void GV_RowEditing(object sender, GridViewDeleteEventArgs e)
        {
            int indexrow = e.RowIndex;
            List<Staff> list = (List<Staff>)Session["data_list"];
            Session["data_list"] = list;
            STAFFGRIDDATA.DataSource = Session["data_list"];
            STAFFGRIDDATA.DataBind();

        }
        protected void Purani_return_krdoo()
        {
          //  var my_list = new Staff().GetStaffList();
            STAFFGRIDDATA.DataSource = Session["data_list"];
            STAFFGRIDDATA.DataBind();
        }

        protected void New_gnerate_krdoo()
        {
            //STAFFGRIDDATA.DataSource = new Staff().GetStaffList();
            //STAFFGRIDDATA.DataBind();
            //var list = Session["data_list"] as List<Staff>;
            var list = new Staff().GetStaffList();
            int number = Convert.ToInt32(Session["length_mylist"]);
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
        protected void Update_List()
        {
            //STAFFGRIDDATA.DataSource = new Staff().GetStaffList();
            //STAFFGRIDDATA.DataBind();
             //var list = Session["data_list"] as List<Staff>;
            var list = new Staff().GetStaffList(); 
            int number=Convert.ToInt32(Session["length_mylist"]);
            Random rnd = new Random();
            foreach(var elemnt in list)
             {
                 int temp= rnd.Next(10, 99);
                 string con = (elemnt.StaffID).ToString() + temp.ToString();
                 elemnt.StaffID = Convert.ToInt32(con);
             }
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
                Staff staff = new Staff();
                staff.StaffID = 1;
                staff.StaffName = "Talha Shafeeq";
                staff.StaffRole = "Manager";
                staff.StaffSalary = "15000";
                staff.StaffAddress = "123 Xyz City,Lahore";
                lstStaff.Add(staff);

                staff = new Staff();
                staff.StaffID = 2;
                staff.StaffName = "Tuba";
                staff.StaffRole = "Assiatant";
                staff.StaffSalary = "12000";
                staff.StaffAddress = "123 Xyz City,Lahore";
                lstStaff.Add(staff);


                staff = new Staff();
                staff.StaffID = 3;
                staff.StaffName = "Tahira";
                staff.StaffRole = "Manager";
                staff.StaffSalary = "12000";
                staff.StaffAddress = "123 Xyz City,Lahore";
                lstStaff.Add(staff);



                staff = new Staff();
                staff.StaffID = 4;
                staff.StaffName = "lala";
                staff.StaffRole = "Worker";
                staff.StaffSalary = "11000";
                staff.StaffAddress = "123 Xyz City,Lahore";
                lstStaff.Add(staff);


                staff = new Staff();
                staff.StaffID = 5;
                staff.StaffName = "Hadeeqa";
                staff.StaffRole = "Worker";
                staff.StaffSalary = "11000";
                staff.StaffAddress = "123 Xyz City,Lahore";
                lstStaff.Add(staff);

                staff = new Staff();
                staff.StaffID = 6;
                staff.StaffName = "Rana";
                staff.StaffRole = "Sweeper";
                staff.StaffSalary = "1000";
                staff.StaffAddress = "123 Xyz City,Lahore";
                lstStaff.Add(staff);

                staff = new Staff();
                staff.StaffID = 7;
                staff.StaffName = "Majid";
                staff.StaffRole = "Programmer";
                staff.StaffSalary = "11000";
                staff.StaffAddress = "123 Xyz City,Lahore";
                lstStaff.Add(staff);

                staff = new Staff();
                staff.StaffID = 8;
                staff.StaffName = "Kamran";
                staff.StaffRole = "Programmer";
                staff.StaffSalary = "11000";
                staff.StaffAddress = "123 Xyz City,Lahore";
                lstStaff.Add(staff);

                staff = new Staff();
                staff.StaffID = 9;
                staff.StaffName = "Azra";
                staff.StaffRole = "Programmer";
                staff.StaffSalary = "11000";
                staff.StaffAddress = "123 Xyz City,Lahore";
                lstStaff.Add(staff);

                staff = new Staff();
                staff.StaffID = 10;
                staff.StaffName = "Ruhma";
                staff.StaffRole = "Worker";
                staff.StaffSalary = "11000";
                staff.StaffAddress = "123 Xyz City,Lahore";
                lstStaff.Add(staff);

                staff = new Staff();
                staff.StaffID = 11;
                staff.StaffName = "Nasir";
                staff.StaffRole = "Worker";
                staff.StaffSalary = "11000";
                staff.StaffAddress = "123 Xyz City,Lahore";
                lstStaff.Add(staff);


                staff = new Staff();
                staff.StaffID = 12;
                staff.StaffName = "Waqar";
                staff.StaffRole = "Worker";
                staff.StaffSalary = "11000";
                staff.StaffAddress = "123 Xyz City,Lahore";
                lstStaff.Add(staff);

                staff = new Staff();
                staff.StaffID = 13;
                staff.StaffName = "Sameen ul allah";
                staff.StaffRole = "Worker";
                staff.StaffSalary = "11000";
                staff.StaffAddress = "123 Xyz City,Lahore";
                lstStaff.Add(staff);

                staff = new Staff();
                staff.StaffID = 14;
                staff.StaffName = "Usama";
                staff.StaffRole = "Worker";
                staff.StaffSalary = "11000";
                staff.StaffAddress = "123 Xyz City,Lahore";
                lstStaff.Add(staff);


                staff = new Staff();
                staff.StaffID = 15;
                staff.StaffName = "Mukhtaar";
                staff.StaffRole = "Worker";
                staff.StaffSalary = "11000";
                staff.StaffAddress = "123 Xyz City,Lahore";
                lstStaff.Add(staff);
                return lstStaff;

            }
         }

         protected void search_button_Click()
         {
             var data_to_be_compared = search_box.Text.ToLower();
             var list = Session["data_list"] as List<Staff>;
             List <Staff> output_array= new List<Staff>();
             foreach(var elemnt in  list)
             {
                 if (elemnt.StaffName==data_to_be_compared)
                 {
                     Output_label.Text = elemnt.StaffName;
                 }
             }
         }

         protected void search_button_Click1(object sender, EventArgs e)
         {
             var data_to_be_compared = search_box.Text;
             var list = Session["data_list"] as List<Staff>;
             List<Staff> output_array = new List<Staff>();
             foreach (var elemnt in list)
             {
                 if (elemnt.StaffName.ToLower().StartsWith(data_to_be_compared.ToLower()))
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