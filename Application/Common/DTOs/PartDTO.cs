using Domain.Entity;

namespace Application.Common.DTOs;
public class PartDTO
{
    public PartDTO(Part part)
    {
        Id = part.Id;
        CarId = part.CarId;
        ParentPartId = part.ParentPartId;
        PartLevelId = part.PartLevelId;
        PartManufacturerId = part.PartManufacturerId;
        PartTypeId = part.PartTypeId;
        SupplierId = part.SupplierId;
        C_Name = part.C_Name;
        Weight = part.Weight;
        C_Condition = part.C_Condition;
        MileageDonorVehicle = part.MileageDonorVehicle;
        C_Details = part.C_Details;
    }
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
    public string C_Details { get; set; } = string.Empty;
    public Car? Car { get; set; }
    public Part? ParentPart { get; set; }
    public PartLevel? PartLevel { get; set; }
    public PartManufacturer? PartManufacturer { get; set; }
    public PartType? PartType { get; set; }
    public Supplier? Supplier { get; set; }
}
