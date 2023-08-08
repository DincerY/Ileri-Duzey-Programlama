// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Database database = new();
var state1 = database + DatabaseType.SqlServer;
var state2 = database + DatabaseType.Oracle;
var state3 = database + DatabaseType.PostgreSql;
var state4 = database + DatabaseType.MySql;
var state5 = database + DatabaseType.Deneme;

Console.WriteLine(state1);
Console.WriteLine(state2);
Console.WriteLine(state3);
Console.WriteLine(state4);
Console.WriteLine(state5);



class Database
{
    private static string _connectionString;
    public static bool operator +(Database database, DatabaseType databaseType)
    {
        _connectionString = databaseType switch
        {
            DatabaseType.MySql => "MySql connectionString",
            DatabaseType.Oracle => "Oracle connectionString",
            DatabaseType.PostgreSql => "Postgres connectionString",
            DatabaseType.SqlServer => "SqlServer connectionString",
            DatabaseType.Deneme => "Deneme"

        };
        if (OpenConnection(_connectionString))
        {
            return true;
        }
        return false;



    }

    static bool OpenConnection(string connectionString)
    {
        if (connectionString == "Deneme")
        {
            return false;
        }
        Console.WriteLine(connectionString);
        //....
        return true;
    }

}

enum DatabaseType
{
    SqlServer, Oracle, PostgreSql, MySql, Deneme
}