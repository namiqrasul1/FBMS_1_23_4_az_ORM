using System;
using System.Collections.Generic;

namespace Lesson4DbFirst.Models;

public partial class Dish
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public double Price { get; set; }

    public int CategoryId { get; set; }

    public int RestaurantId { get; set; }

    public int? MediaId { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual Media? Media { get; set; }

    public virtual Restaurant Restaurant { get; set; } = null!;
}
