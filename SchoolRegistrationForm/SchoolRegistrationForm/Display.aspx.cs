using DataBaseConn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SchoolRegistrationForm
{
    public partial class Display : System.Web.UI.Page
    {
        
        AddDataClass ADC = new AddDataClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataBaseFache conData = new DataBaseFache();
            GridView1.DataSource = conData.GetEmployees();
            GridView1.DataBind();
        }
        protected void OnRowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            DataBaseFache conData = new DataBaseFache();
            int StudentId = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values[0]);
            conData.DelectEmployees(StudentId);
            Label1.Text = Convert.ToString(StudentId);
            GridView1.DataSource = conData.GetEmployees();
            GridView1.DataBind();
            //Page_Load(this,null);

        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            int sid = 0;
            Response.Redirect("Registration.aspx?Sid="+ sid);
           
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sid = Convert.ToInt32(GridView1.SelectedRow.Cells[1].Text);

             Response.Redirect("Registration.aspx?Sid="+sid);
        }
    }
}