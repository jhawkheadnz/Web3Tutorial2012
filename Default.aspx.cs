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

        //Load a list of people from the person table
        List<PersonInfo> personInfoList = new List<PersonInfo>();

        //Get data from person table and place it into personInfo by reference
        person.Get(ref personInfoList);

        //Display details of person by looping through list
        foreach (PersonInfo personInfo in personInfoList)
        {
            Label1.Text += personInfo.FirstName + " " + personInfo.LastName + "<br/>\n";
        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //Create a Person info object
        PersonInfo personInfo = new PersonInfo();


    }
}