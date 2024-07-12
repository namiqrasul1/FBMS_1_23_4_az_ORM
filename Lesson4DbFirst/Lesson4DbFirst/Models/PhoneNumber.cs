using System;
using System.Collections.Generic;

namespace Lesson4DbFirst.Models;

public partial class PhoneNumber
{
    public int Id { get; set; }

    public string Number { get; set; } = null!;

    public int RestaurantId { get; set; }

    public virtual Restaurant Restaurant { get; set; } = null!;
}
