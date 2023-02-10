namespace SuppliersWebApi.Models;

public class Part
{
    public int Id { get; set; }
    public int? CarId { get; set; }
    public int? ParentPartId { get; set; }
    public int? PartLevelId { get; set; }
    public int? PartManufacturerId { get; set; }
    public int? PartTypeId { get; set; }
    public int? SupplierId { get; set; }
    public string C_Name { get; set; } = null!;
    public double Weight { get; set; }
    public string C_Condition { get; set; } = null!;
    public int MileageDonorVehicle { get; set; }
    public string C_Details { get; set; } = String.Empty;
    public Car? Car { get; set; }
    public Part? ParentPart { get; set; }
    public PartLevel? PartLevel { get; set; }
    public PartManufacturer? PartManufacturer { get; set; }
    public PartType? PartType { get; set; }
    public Supplier? Supplier { get; set; }
}
