using Dapper;
using Lesson10Dapper.Models;
using Lesson10Dapper.Models.DTOs;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Net;


Console.WriteLine(AppContext.BaseDirectory);
var builder = new ConfigurationBuilder();
builder.AddJsonFile(@"C:\Users\namiqrasullu\Desktop\FBMS_1_23_4_az_ORM\Lesson10Dapper\Lesson10Dapper\appsettings.json");
var config = builder.Build();

using var connection = new SqlConnection(config.GetConnectionString("conStr"));

#region Querying Scalar Values

//var query = @"Select Sum(Pages) From Books";
//var pattern = Console.ReadLine(); // A% OR 1 = 1 
//var query = @$"Select Sum(Pages) From Books Where [Name] Like {pattern}";
//var query = @$"Select Sum(Pages) From Books";

////var result = connection.ExecuteScalar(query);
//var result = connection.ExecuteScalar<int>(query);

//Console.WriteLine(result);

#endregion



//List<int> ints = [1, 2, 3, 4, 56, 23, 32, 4, 6123];
//var i = ints.Single(i => i == 4);
//Console.WriteLine();

#region Querying Single Row

//var query = $@"SELECT * FROM Books WHERE Id = @bookId";

////var result = connection.QueryFirstOrDefault(query);
//var result = connection.QueryFirstOrDefault<Book>(sql: query, 
//                                                param: new { bookId = 6});

//Console.WriteLine(result);

//var query = @"SELECT * FROM Books B INNER JOIN Authors A ON B.Id_Author = A.Id WHERE B.Id = @bookId";

//var result = connection.Query<Book, Author, Book>(query, map: (b, a) => { b.Author = a; return b; }, param: new { bookId = 5});


#endregion


#region Querying Multiple Rows

//var query = @"select * from books";
//var query = @"select * from books where Pages < @page";

//var result = connection.Query(query);
//var result = connection.Query<Book>(query, param: new { page = 100});

#endregion

#region Querying Multiple Results

//var query = @"select * from books where Id_Author = @AuthorId; 
//                select * from authors where Id = @AuthorId";

//using (var mult = connection.QueryMultiple(query, param: new { AuthorId = 5 }))
//{
//    var books = mult.Read<Book>().ToList();
//    var author = mult.ReadFirst<Author>();
//}


#endregion


#region Querying Specific Columns

//var query = @"Select Id, FirstName From Authors";

//var author = connection.Query<Author>(query);

//var singleRow = @"select [Name], Pages from Books where Id = @BookId";

////var book = connection.QueryFirstOrDefault<Book>(singleRow, param: new { BookId = 5 });
//var book = connection.QueryFirstOrDefault<BookDto>(singleRow, param: new { BookId = 5 });


//Console.WriteLine(book!.Name + book.Pages);


#endregion


#region Inserting Data 

//var cmd = @"insert into Authors(Id, FirstName, LastName) VALUES (@Id, @FirstName, @LastName)";

// anonymous class
//var anonymousObject = new {Id  = 18, FirstName = "Elxan", LastName = "Elatli"};
//connection.Execute(cmd, param: anonymousObject);

// real object
//var author = new Author { Id = 19, FirstName = "Varis", LastName = "Biyabrchiliq" };
//connection.Execute(cmd, author);



//var authors = new List<Author>
//{
//    new(){ Id = 20, FirstName = "Dan", LastName = "Brown"},
//    new(){ Id = 21, FirstName = "Jo", LastName = "Nesbo"},
//};

//var rows = connection.Execute(cmd, param: authors);
//Console.WriteLine(rows);

#endregion

#region Using Relationships

//var query = $@"Select A.Id IdAuthor, A.FirstName, A.LastName, B.Id AS BookId, B.[Name], B.Pages From Authors A Inner Join Books B On A.Id = B.Id_Author";


////var authors = connection
////    .Query<Book, Author, Author>(query,
////                                map: (b, a) => { a.Books.Add(b); return a; }, splitOn: "BookId");

//var result = connection.Query<Author, Book, Book>(query,
//    map: (author, book) =>
//    {
//        book.Author = author;
//        return book;
//    }, splitOn: "Id");


//var sql =
//@"SELECT A.Id, A.FirstName, A.LastName, B.Id, B.Name, B.Pages, B.YearPress, B.Id_Themes, B.Id_Author, B.Id_Category, B.Id_Press, Comment, Quantity 
//FROM Authors A JOIN Books B ON A.Id = B.Id_Author";

//var authorDict = new Dictionary<int, Author>();

//var authors = connection.Query<Author, Book, Author>(
//    sql,
//    (author, book) =>
//    {
//        if (!authorDict.TryGetValue(author.Id, out var currentAuthor))
//        {
//            currentAuthor = author;
//            authorDict.Add(author.Id, currentAuthor);
//        }
//        if (book != null)
//        {
//            book.Author = currentAuthor;
//            currentAuthor.Books.Add(book);
//        }
//        return currentAuthor;
//    },
//    splitOn: "Id"
//    ).ToList();



#endregion


#region Stored Procedure

//var procName = "GetAuthorBook";

//var parameters = new { AuthorId = 5 };

//var result = connection.Query<Book>(procName, parameters, commandType: CommandType.StoredProcedure).ToList();

//var procName = "GetBookCountByAuthor";

//var parameters = new DynamicParameters();
//parameters.Add("@AuthorId", 5, DbType.Int32, ParameterDirection.Input);
//parameters.Add("@bookCount", dbType: DbType.Int32, direction: ParameterDirection.Output);

//connection.Execute(procName, parameters, commandType: CommandType.StoredProcedure);

//var result = parameters.Get<int>("@bookCount");

var procedureName = "sp_lazy_students";

var parameters = new DynamicParameters();
parameters.Add("@count", null, DbType.Int32, ParameterDirection.Output);

var result = connection.Query(procedureName, parameters, commandType: CommandType.StoredProcedure);

Console.WriteLine(parameters.Get<int>("@count"));

#endregion

Console.WriteLine();
Console.WriteLine();