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
    private SqlCommand sqlCommand;
    
    private string username;
    private string password;
    private string database;
    private string server;

    private string sql;

    private const string connectionStringFormat = "Data Source={0};Initial Catalog={1};User ID={2};Password={3};MultipleActiveResultSets=True";

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
        string connectionString = String.Format(connectionStringFormat, this.server, this.database, this.username, this.password);
        this.sqlConnection = new SqlConnection(connectionString);
    }

    /// <summary>
    /// Prepare the statement for execution
    /// </summary>
    /// <param name="sql">SQL Command to execute</param>
    public void Prepare(string sql)
    {
        this.sqlCommand.Connection = sqlConnection;
        this.sqlCommand.CommandText = sql;
    }

    /// <summary>
    /// Close connection
    /// </summary>
    public void Close()
    {
        this.sqlConnection.Close();
    }
}