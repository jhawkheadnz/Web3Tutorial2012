using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

/// <summary>
/// A simple class that holds all the connection information
/// and runs queries. Basically a wrapper class
/// </summary>
class Connection
{
    private SqlConnection sqlConnection;
    
    private string username;
    private string password;
    private string database;
    private string server;

    private string sql;

    private static string ConnectionStringFormat = "";

    /// <summary>
    /// Constructor with details about connection
    /// </summary>
    /// <param name="server">Server ip address or hostname</param>
    /// <param name="database">Database name</param>
    /// <param name="username">Database Username</param>
    /// <param name="password">Database Password</param>
    public Connection(
        string server,
        string database,
        string username, 
        string password)
    {
        this.username = username;
        this.password = password;
        this.database = database;
        this.server = server;
    }

    /// <summary>
    /// Connect to the database
    /// </summary>
    public void Connect()
    {

    }
}