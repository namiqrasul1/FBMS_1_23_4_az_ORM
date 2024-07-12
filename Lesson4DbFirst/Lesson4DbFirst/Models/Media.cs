using System;
using System.Collections.Generic;

namespace Lesson4DbFirst.Models;

public partial class Media
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Url { get; set; } = null!;

    public virtual Dish? Dish { get; set; }

    public virtual User? User { get; set; }
}
