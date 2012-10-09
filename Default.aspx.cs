using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection sqlConnection;
    Person person;
        
    protected void Page_Load(object sender, EventArgs e)
    {
        //Create connection to database
        sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["TutorialConnection"].ConnectionString);

        //Create instance of person
        person = new Person(sqlConnection);

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //Create a Person info object
        PersonInfo personInfo = new PersonInfo();

        personInfo.FirstName = tbxFirstName.Text;
        personInfo.LastName = tbxLastName.Text;

        person.Add(personInfo);

        Response.Redirect("Edit.aspx");

    }
}