using System.ComponentModel.DataAnnotations.Schema;

namespace Lesson4EntityRelationship.Models
{
    #region Default convension
    //public class Book
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public ICollection<Author> Authors { get; set; }
    //}

    //public class Author
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public ICollection<Book> Books { get; set; }
    //}

    #endregion

    #region Data Annotation
    //public class Book
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public ICollection<AuthorBook> Authors { get; set; }
    //}

    //public class AuthorBook
    //{
    //    [ForeignKey(nameof(Book))]
    //    public int BookId { get; set; }

    //    [ForeignKey(nameof(Author))]
    //    public int AuthorId { get; set; }

    //    public Author Author { get; set; }
    //    public Book Book { get; set; }

    //}

    //public class Author
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public ICollection<AuthorBook> Books { get; set; }
    //}

    #endregion

    #region FluentApi
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<AuthorBook> Authors { get; set; }
    }

    public class AuthorBook
    {
        public int BookId { get; set; }
        public int AuhtorId { get; set; }

        public Author Author { get; set; }
        public Book Book { get; set; }
    }

    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<AuthorBook> Books { get; set; }
    }

    #endregion
}
