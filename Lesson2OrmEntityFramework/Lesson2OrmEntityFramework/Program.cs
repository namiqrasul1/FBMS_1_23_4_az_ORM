using Lesson2OrmEntityFramework.Data;
using Lesson2OrmEntityFramework.Models;
using System.Configuration;
using System.Data.SqlClient;

#region SqlConnection

//var conStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;

//var sqlServer = new SqlConnection(conStr);

//void getQuery()
//{
//    SqlDataReader? reader = null;

//    try
//    {
//        sqlServer.Open();
//        var cmd = new SqlCommand(cmdText: "Select * From Authors", connection: sqlServer);
//        reader = cmd.ExecuteReader();
//        while (reader.Read())
//        {
//            Console.WriteLine($"{reader["Id"]} {reader["FirstName"]} {reader["LastName"]}");
//        }
//    }
//    finally
//    {
//        reader?.Close();
//        sqlServer.Close();
//    }

//}

//void insertAuthor(Author author)
//{
//    try
//    {
//        sqlServer.Open();
//        var cmd = new SqlCommand(cmdText: $"Insert Into Authors(Id, FirstName, LastName) Values (@id, @fn, @ln)", connection: sqlServer);

//        cmd.Parameters.AddWithValue("@id", author.Id);
//        cmd.Parameters.AddWithValue("@fn", author.FirstName);
//        cmd.Parameters.AddWithValue("@ln", author.LastName);

//        cmd.ExecuteNonQuery();
//    }
//    finally
//    {
//        sqlServer?.Close();
//    }
//}

//var author = new Author { Id = 16, FirstName = "John", LastName = "Doe" };
//insertAuthor(author);


//getQuery();


#endregion

#region ORM

// Object Relational Mapping

var context = new LibraryDbContext();

var authors = context.Authors.Where(a => a.FirstName.Contains("e")).ToList();

foreach (var author in authors)
{
    Console.WriteLine(author.FirstName);
}

// IQueryable
// IEnumerable


//var author = new Author
//{
//    Id = 17,
//    FirstName = "Dan",
//    LastName = "Brown"
//};

//context.Authors.Add(author);
//context.SaveChanges();

//var auhtor = context.Authors.FirstOrDefault(a => a.Id == 17);
//if(auhtor is not null)
//{
//    auhtor.LastName = "Chox babat yazar";
//    context.Update(auhtor);
//    context.SaveChanges();
//}

//if(auhtor is not null)
//{
//    context.Authors.Remove(auhtor);
//    context.SaveChanges();
//}

#endregion

// Database First
// Code First