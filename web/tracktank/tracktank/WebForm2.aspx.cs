using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace tracktank
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnregistration_Click(object sender, EventArgs e)
        {
            lblmsg.Text = "";
            SqlConnection SQLConn = new SqlConnection("Data Source=localhost; Port=3306; Initial Catalog=Blog; Password=; UserId=root; Integrated Security=True; database=trackTank;");
            SqlDataAdapter SQLAdapter = new SqlDataAdapter("insert into registeredUser values('" + txtfname.Text + "','" + txtemail.Text + "','" + txtpassword.Text + "')", SQLConn);
            DataTable DT = new DataTable();
            SQLAdapter.Fill(DT);


            SqlDataAdapter SQLAAdapter = new SqlDataAdapter("select * from UserMst", SQLConn);
            DataTable DTT = new DataTable();
            SQLAAdapter.Fill(DTT);

            GridView1.DataSource = DTT;
            GridView1.DataBind();

            lblmsg.Text = "Registration Done!!";
            txtfname.Text = "";
            txtemail.Text = "";
            txtfname.Focus();
        }
    }
}