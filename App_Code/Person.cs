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
    private SqlCommand sqlCommand;
    private SqlConnection sqlConnection;

    public Person(SqlConnection sqlConnection)
    {
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

    }

    public void Get(ref List<PersonInfo> item)
    {
        
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