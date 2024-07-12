using System;
using System.Collections.Generic;

namespace Lesson4DbFirst.Models;

public partial class Review
{
    public int Id { get; set; }

    public string? Comment { get; set; }

    public int UserId { get; set; }

    public int RestaurantId { get; set; }

    public virtual Restaurant Restaurant { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
