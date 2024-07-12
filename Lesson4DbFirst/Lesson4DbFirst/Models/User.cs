using System;
using System.Collections.Generic;

namespace Lesson4DbFirst.Models;

public partial class User
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int? MediaId { get; set; }

    public virtual Media? Media { get; set; }

    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();
}
