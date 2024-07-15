using System;
using System.Collections.Generic;

namespace Lesson5EagerLazyLoading.Models;

public partial class Student
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public int IdGroup { get; set; }

    public int Term { get; set; }

    public virtual ICollection<SCard> SCards { get; set; } = new List<SCard>();

    public bool CheckFirstName() { return !string.IsNullOrWhiteSpace(FirstName); }
}
