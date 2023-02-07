namespace SuppliersWebApi.Models;

public class Part
{
    public int Id { get; set; }
    public int CarId { get; set; }
    public int ParentId { get; set; }
    public int LevelId { get; set; }
    public int ManufacturerId { get; set; }
    public int TypeId { get; set; }
    public int SupplierId { get; set; }
    public string Name { get; set; } = null!;
    public double Weight { get; set; }
    public string Condition { get; set; } = null!;
    public int MileageDonorVehicle { get; set; }
    public string Details { get; set; } = String.Empty;
    public Car Car { get; set; }
    public Part ParentPart { get; set; }
    public PartLevel PartLevel { get; set; }
    public PartManufacturer PartManufacturer { get; set; }
    public PartType PartType { get; set; }
    public Supplier Supplier { get; set; }
}
