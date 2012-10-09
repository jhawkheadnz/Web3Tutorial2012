using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class Edit : System.Web.UI.Page
{

    Person person;
    SqlConnection sqlConnection;

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

        if (personInfoList.Count != 0)
        {
            //Clear text
            lblUsers.Text = String.Empty;

            //Display details of person by looping through list
            foreach (PersonInfo personInfo in personInfoList)
            {
                lblUsers.Text += personInfo.FirstName + " " + personInfo.LastName + " <a href=\"Delete.aspx?id=" + personInfo.PersonID + "\">Delete</a><br/>\n";
            }
        }
        else
        {
            lblUsers.Text = "There are no people in the database";
        }
    }
}