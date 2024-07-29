//using Lesson9Joins.Data;
//using Lesson9Joins.Models;
//using Microsoft.EntityFrameworkCore;

//using var context = new LibraryContext();

//#region INNER JOIN

////var query = from author in context.Authors
////            join book in context.Books on author.Id equals book.IdAuthor
////            select new
////            {
////                author.FirstName,
////                author.LastName,
////                book.Name,
////            };

////var query1 = from author in context.Authors
////            join book in context.Books on author.Id equals book.IdAuthor
////            select author;

////var datas = query1.ToList();

////var query = context.Books.Join(context.Authors,
////                                book => book.IdAuthor,
////                                auhtor => auhtor.Id,
////                                (book, author) => new
////                                {
////                                    book.Name,
////                                    author.FirstName
////                                });

////var data = query.ToList();

////var query = from author in context.Authors
////            join book in context.Books
////                on author.Id equals book.IdAuthor
////            join category in context.Categories
////                on book.IdCategory equals category.Id
////            select new
////            {
////                author.FirstName,
////                author.LastName,
////                BookName = book.Name,
////                CategoryName = category.Name,
////            };
////var datas = query.ToList();

////var datas = context.Authors.
////            Join(context.Books,
////                  author => author.Id,
////                  book => book.IdAuthor,
////                  (author, book) => new
////                  {
////                      book.IdCategory,
////                      author.FirstName,
////                      book.Name,
////                  })
////            .Join(context.Categories, 
////                   ab => ab.IdCategory,
////                   c => c.Id,
////                   (authorBook, category) => new
////                   {
////                       authorBook.FirstName,
////                       authorBook.Name,
////                       CategoryName = category.Name
////                   }).ToList();

////SELECT[a].[FirstName], [b].[Name], [c].[Name] AS[CategoryName]
////FROM[Authors] AS[a]
////INNER JOIN[Books] AS [b] ON[a].[Id] = [b].[Id_Author]
////INNER JOIN[Categories] AS [c] ON[b].[Id_Category] = [c].[Id]

//#endregion

//#region LEFT JOIN

////var query = from author in context.Authors
////            join book in context.Books
////                on author.Id equals book.IdAuthor into authorBooks
////            from book in authorBooks.DefaultIfEmpty()
////            select new
////            {
////                author.FirstName,
////                book.Name,
////            };


////var query = from book in context.Books
////            join author in context.Authors
////                on book.IdAuthor equals author.Id into authorBooks
////            from author in authorBooks.DefaultIfEmpty()
////            select new
////            {
////                author.FirstName,
////                book.Name,
////            };

////var data = query.ToList();


////var datas = query.ToList();

////var data = context.Books.Include(b => b.IdAuthorNavigation).ToList(); // LEFT JOIN (chunki idAuhtor nullabledi)
////data = context.Books.Include(b => b.IdCategoryNavigation).ToList(); // INNER JOIN (chunki idCategory not nulldur)

//#endregion

//#region FULL JOIN

//var left = from author in context.Authors
//           join book in context.Books
//                on author.Id equals book.IdAuthor into authorBooks
//           from book in authorBooks.DefaultIfEmpty()
//           select new
//           {
//               book.Name,
//               author.FirstName,
//           };

//var right = from book in context.Books
//            join author in context.Authors
//                on book.IdAuthor equals author.Id into bookAuhtors
//            from author in bookAuhtors.DefaultIfEmpty()
//            select new
//            {
//                book.Name,
//                author.FirstName,
//            };

//var full = left.Union(right);

//var datas = full.ToList();

//#endregion



//Console.WriteLine();

//Console.WriteLine();

