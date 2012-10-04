using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Person
/// </summary>
public class Person : IEntity<PersonInfo>
{
    public string ErrorMessage { get; set; }
    public bool HasError { get; set; }
    
    private SqlCommand sqlCommand;
    private SqlConnection sqlConnection;

    public Person(SqlConnection sqlConnection)
    {
        this.HasError = false;
        this.ErrorMessage = String.Empty;

        this.sqlConnection = sqlConnection;
        this.sqlCommand = new SqlCommand();
        this.sqlCommand.Connection = this.sqlConnection;
    }

    /// <summary>
    /// Add a person to the databaes
    /// </summary>
    /// <param name="item">PersonInfo object with details</param>
    public void Add(PersonInfo item)
    {
        this.sqlCommand.CommandText = "INSERT INTO tblPerson (FirstName, LastName) VALUES ('@firstName', '@lastName');";
        this.sqlCommand.Parameters.AddWithValue("firstName", item.FirstName);
        this.sqlCommand.Parameters.AddWithValue("lastName", item.LastName);
    }

    public void Get(ref List<PersonInfo> item)
    {
        this.sqlCommand.CommandText = "SELECT PersonID, FirstName, LastName FROM tblPerson";
        
        SqlDataReader personData = null;

        try
        {
            sqlConnection.Open();
            personData = sqlCommand.ExecuteReader();
        }
        catch (SqlException sqlException)
        {
            this.HasError = true;
            this.ErrorMessage = sqlException.Message;
        }
        
        //Get the data from the database
        while (personData.Read())
        {
            PersonInfo personDataTemp = new PersonInfo();
            personDataTemp.PersonID = int.Parse(personData["PersonID"].ToString());
            personDataTemp.FirstName = personData["FirstName"].ToString();
            personDataTemp.LastName = personData["LastName"].ToString();

            item.Add(personDataTemp);
        }

    }

    public void Get(ref PersonInfo item, int id)
    {
        throw new NotImplementedException();
    }

    public void Update(PersonInfo item, int id)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    
}