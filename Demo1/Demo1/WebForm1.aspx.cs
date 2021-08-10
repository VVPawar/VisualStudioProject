using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataBaseConnection;
using StudentD;

namespace Demo1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        LinkStudent Student = new LinkStudent();
        DataConnect d = new DataConnect();
        Connection conData = new Connection();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = conData.GetEmployees();
            GridView1.DataBind();
        }
        protected void OnRowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int StudentId = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values[0]);
           // TextBox1.Text = StudentId.ToString();
            conData.DelectEmployees(StudentId);
            GridView1.DataSource = conData.GetEmployees();
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Student.SD_get = new StudentDetail();
            Student.MD_get = new MotherDetail();
            Student.FD_get = new FatherDetail();
            Student.SD_get.StudentName = TextBox1.Text;
            Student.SD_get.MiddleName = TextBox2.Text;
            Student.SD_get.LastName = TextBox3.Text;
            Student.MD_get.MotherName = TextBox7.Text;
            Student.MD_get.MotherEmail = TextBox9.Text;
            Student.MD_get.MotherMob = Convert.ToDouble(TextBox8.Text);
            Student.FD_get.FatherName = TextBox4.Text;
            Student.FD_get.Email = TextBox6.Text;
            Student.FD_get.Mob = Convert.ToDouble(TextBox5.Text);
            d.InserStudent(Student);
            GridView1.DataSource = conData.GetEmployees();
            GridView1.DataBind();
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Button2.Visible = true;            
            TextBox1.Text = GridView1.SelectedRow.Cells[2].Text;
            TextBox2.Text = GridView1.SelectedRow.Cells[3].Text;
            TextBox3.Text = GridView1.SelectedRow.Cells[4].Text;
            TextBox4.Text = GridView1.SelectedRow.Cells[5].Text;
            TextBox5.Text = GridView1.SelectedRow.Cells[6].Text;
            TextBox6.Text = GridView1.SelectedRow.Cells[7].Text;
            TextBox7.Text = GridView1.SelectedRow.Cells[8].Text;
            TextBox8.Text = GridView1.SelectedRow.Cells[10].Text; 
            TextBox9.Text = GridView1.SelectedRow.Cells[9].Text;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(GridView1.SelectedRow.Cells[1].Text);
            Student.SD_get = new StudentDetail();
            Student.MD_get = new MotherDetail();
            Student.FD_get = new FatherDetail();
            Student.SD_get.StudentName = TextBox1.Text;
            Student.SD_get.MiddleName = TextBox2.Text;
            Student.SD_get.LastName = TextBox3.Text;
            Student.MD_get.MotherName = TextBox7.Text;
            Student.MD_get.MotherEmail = TextBox9.Text; 
            Student.MD_get.MotherMob = Convert.ToDouble(TextBox8.Text);
            Student.FD_get.FatherName = TextBox4.Text;
            Student.FD_get.Email = TextBox6.Text;
            Student.FD_get.Mob = Convert.ToDouble(TextBox5.Text); 
            d.UpdateStudent(ID,Student);
            GridView1.DataSource = conData.GetEmployees();
            GridView1.DataBind();
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";
            Button2.Visible = false;
        }
    }
}