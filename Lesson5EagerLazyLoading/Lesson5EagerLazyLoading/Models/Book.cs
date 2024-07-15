using System;
using System.Collections.Generic;

namespace Lesson5EagerLazyLoading.Models;

public partial class Book
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Pages { get; set; }

    public int YearPress { get; set; }

    public int IdThemes { get; set; }

    public int IdCategory { get; set; }

    public int IdAuthor { get; set; }

    public int IdPress { get; set; }

    public string? Comment { get; set; }

    public int Quantity { get; set; }

    public virtual Author Author { get; set; } = null!;

    public virtual ICollection<SCard> SCards { get; set; } = new List<SCard>();
}
