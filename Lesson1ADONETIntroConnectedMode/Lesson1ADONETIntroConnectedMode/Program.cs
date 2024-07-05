using System.Data.SqlClient;

internal class Program
{
    SqlConnection sqlConnection = null;

    public Program()
    {
        var conStr = "Data Source=STHQ0118-01;Initial Catalog=Library;User ID=admin;Password=admin;";
        sqlConnection = new SqlConnection(conStr);
    }

    private static void Main(string[] args)
    {
        var pr = new Program();
        //pr.InsertAuthor();
        //pr.SelectQuery();
        //pr.SelectBooks();
        pr.QueryWithParams("Hakuna");

    }

    private void QueryWithParams(string param)
    {
        SqlDataReader? reader = null;
        try
        {
            sqlConnection.Open();
            var query = "select * from Authors Where FirstName = @p1";
            var command = new SqlCommand(query, sqlConnection);

            // way 1

            //var parameter = new SqlParameter();
            //parameter.ParameterName = "@p1";
            //parameter.Value = param;
            //parameter.SqlDbType = System.Data.SqlDbType.NVarChar;
            //command.Parameters.Add(parameter);

            // way 2

            //command.Parameters.Add("@p1", System.Data.SqlDbType.NVarChar).Value = param;

            // way 3 
            command.Parameters.AddWithValue("@p1", param);

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine($"{reader["Id"]} {reader["FirstName"]} {reader["LastName"]} ");
            }
        }
        finally
        {

        }
    }

    private void SelectBooks()
    {
        SqlDataReader? reader = null;
        var cols = new List<string>();
        try
        {
            sqlConnection.Open();
            var query = "SELECT * FROM BOOKS";
            var command = new SqlCommand(query, sqlConnection);
            reader = command.ExecuteReader();
            int line = 0;
            while (reader.Read())
            {
                if (line == 0)
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        cols.Add(reader.GetName(i));
                        Console.Write($"{reader.GetName(i)} ");
                    }
                    line = 1;
                }
                Console.WriteLine();

                foreach (var col in cols)
                {
                    Console.Write($"{reader[col]} ");
                }


            }
        }
        finally
        {
            sqlConnection?.Close();
            reader?.Close();
        }
    }

    private void SelectQuery()
    {
        SqlDataReader reader = null;
        try
        {
            sqlConnection.Open();
            var command = new SqlCommand("Select * From Authors", sqlConnection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                //Console.WriteLine($"{reader[0]} {reader[1]} {reader[2]} ");
                Console.WriteLine($"{reader["Id"]} {reader["FirstName"]} {reader["LastName"]} ");
            }
        }
        finally
        {
            sqlConnection.Close();
            reader?.Close();
        }
    }

    private void InsertAuthor()
    {
        try
        {
            sqlConnection.Open();

            var query = "INSERT INTO Authors(Id, FirstName, LastName) VALUES(15, 'Hakuna', 'Matata')";
            var command = new SqlCommand(query, sqlConnection);
            command.ExecuteNonQuery();
        }
        finally
        {
            sqlConnection.Close();
        }
    }
}