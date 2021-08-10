using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudentData;


namespace RegistrationForm
{
    public partial class Student : System.Web.UI.Page
    {
        StudentReff Cl = new StudentReff();
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Text = "Hii";
            
                GridView1.DataSource = Cl.GetEmployees();
                GridView1.DataBind();
         
        }
        protected void OnRowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int StudentId = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values[0]);
            TextBox1.Text = StudentId.ToString();
            Cl.DelectEmployees(StudentId);
            GridView1.DataSource = Cl.GetEmployees();
            GridView1.DataBind();
        }
            //protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
            //  {
            //     TextBox1.Text =GridView1.SelectedRow.Cells[1].Text;
            // }
        }
}