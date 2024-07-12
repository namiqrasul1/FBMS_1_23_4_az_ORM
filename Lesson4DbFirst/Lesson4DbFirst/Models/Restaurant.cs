using System;
using System.Collections.Generic;

namespace Lesson4DbFirst.Models;

public partial class Restaurant
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public TimeOnly OpenTime { get; set; }

    public TimeOnly CloseTime { get; set; }

    public int AddressId { get; set; }

    public virtual Address Address { get; set; } = null!;

    public virtual ICollection<Dish> Dishes { get; set; } = new List<Dish>();

    public virtual ICollection<PhoneNumber> PhoneNumbers { get; set; } = new List<PhoneNumber>();

    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();
}
