using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class Delete : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Person person;
        SqlConnection sqlConnection;

        if (Request.QueryString["id"] != null)
        {

            //Create connection to database
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["TutorialConnection"].ConnectionString);
            person = new Person(sqlConnection);

            int id = int.Parse(Request.QueryString["id"].ToString());
            person.Delete(id);

            Response.Redirect("Delete.aspx");
        }
    }
}