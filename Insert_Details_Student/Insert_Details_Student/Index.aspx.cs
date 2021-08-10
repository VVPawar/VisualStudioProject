using DataBase_Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Insert_Details_Student
{
    public partial class Index : System.Web.UI.Page
    {
        Connection conData = new Connection();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = conData.GetEmployees();
            GridView1.DataBind();
        }
        protected void OnRowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int StudentId = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values[0]);
            TextBox1.Text = StudentId.ToString();
            conData.DelectEmployees(StudentId);
            GridView1.DataSource = conData.GetEmployees();
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String StudentName = Convert.ToString( TextBox1.Text);
            String FatherName = Convert.ToString(TextBox2.Text);
            int Mobile = Convert.ToInt32(TextBox3.Text);
            String EmailId = Convert.ToString(TextBox4.Text);
            conData.InserEmployees(StudentName, FatherName, Mobile, EmailId);
            GridView1.DataSource = conData.GetEmployees();
            GridView1.DataBind();
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
        }
    }
}