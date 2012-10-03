using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Person
/// </summary>
public class Person : IEntitiy<PersonInfo>
{
    private Connection connection;

    public Person(Connection connection)
    {
        this.connection = connection;
    }

    public void Add(PersonInfo item)
    {
        throw new NotImplementedException();
    }

    public void Get(ref List<PersonInfo> item)
    {
        throw new NotImplementedException();
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