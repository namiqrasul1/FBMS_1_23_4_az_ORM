namespace Lesson9Joins.Models;

public partial class Author
{
    public static int a = 0;
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
