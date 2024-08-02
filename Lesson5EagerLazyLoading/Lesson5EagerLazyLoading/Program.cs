using Lesson5EagerLazyLoading.Data;
using Lesson5EagerLazyLoading.Models;
using Microsoft.EntityFrameworkCore;

// IQueryable
// IEnumerable


// Linq 
// Method => context.Books.ToList()
// Query  => (from book in books select book).ToList()

// Method => context.Books.Where(b => b.Id == 5).ToList()
// Query  => (from book in books select book where book.Id == 5).ToList()


var context = new LibraryContext();

//var books = context.Books.ToList(); // use Linq Methods
//var books1 = (from Book in context.Books select Book).ToList(); // use Linq Query
//var books = context.Books.FromSqlRaw("SELECT * FROM Books").ToList(); // use Sql Query


//foreach (var item in context.Books)
//{
//    Console.WriteLine(item);
//}


//var count = context.Books.ToList().Count(); // melumatlari dbden chekib ramda saxlayib sonra saydiq. maliyyet yuxaridir
var count = context.Books.Count(b => b.Quantity > 5);
Console.WriteLine(count);

//var students = context.Students.Where(s => s.FirstName.Contains("s")).ToList();

var students = context.Students.Select(s => new { Name = s.FirstName, Surname = s.LastName });

foreach (var student in students)
{
    Console.WriteLine(student);
}



//var book = context.Books.FirstOrDefault(b => b.Name == "SQL");

// Eager Loading
// Lazy  Loading

#region Eager Loading

// Include, ThenInclude


//var book = context.Books.Include(b => b.Author).FirstOrDefault(b => b.Name == "SQL");

//var author = context.Authors.Include(a => a.Books).ThenInclude(b => b.SCards).ToList();


#endregion

#region Lazy Loading

//var book = context.Books.FirstOrDefault();

//Console.WriteLine(book?.Author.FirstName);


//var books = context.Books.First();

//foreach (var item in books.SCards)
//{
//    Console.WriteLine(item.Student.FirstName);
//}

#endregion

#region AutoLoading

//var books = context.Books.ToList();
//var authors = context.Authors.ToList();


//Console.WriteLine();




#endregion

#region Expilict Loading

//var book = context.Books.FirstOrDefault(b => b.Id == 5);
//if (book is not null)
//{
//    context.Entry(book).Collection(b => b.SCards).Load();
//    context.Entry(book).Reference(b => b.Author).Load();
//}


#endregion

#region Tracking

//var author = new Author
//{
//    Id = 17,
//    FirstName = "Elxan",
//    LastName = "Elatli",
//};

//Console.WriteLine(context.Entry(author).State);

//context.Authors.Add(author);

//Console.WriteLine(context.Entry(author).State);

//context.SaveChanges();

//Console.WriteLine(context.Entry(author).State);


//var author = context.Authors.AsNoTracking().FirstOrDefault(a => a.Id == 17);
//if(author is not null)
//{
//    Console.WriteLine(context.Entry(author).State);
//    author.FirstName = "Elxan";
//    context.Authors.Update(author);
//    Console.WriteLine(context.Entry(author).State);
//    context.SaveChanges();
//}


//Console.WriteLine();





#endregion





Console.WriteLine();

Console.WriteLine();