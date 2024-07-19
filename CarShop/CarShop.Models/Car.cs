namespace CarShop.Models;

public class Car : BaseEntity
{
    public string Vendor { get; set; }
    public string Model { get; set; }
    public short Year { get; set; }
    public CarType CarType { get; set; }
    public float EngineVolume { get; set; }
    public bool IsNew { get; set; }
    public ICollection<Tag> Tags { get; set; }

    public Car Clone() => new() { CarType = CarType, EngineVolume = EngineVolume, Id = Id, IsNew = IsNew, Model = Model, Tags = Tags, Vendor = Vendor, Year = Year };
}
