using Domain.Entity;

namespace Application.DTOs;
public class PartDTO
{
    public PartDTO(Part part)
    {
        this.Id = part.Id;
        this.CarId = part.CarId;
        this.ParentPartId = part.ParentPartId;
        this.PartLevelId = part.PartLevelId;
        this.PartManufacturerId = part.PartManufacturerId;
        this.PartTypeId = part.PartTypeId;
        this.SupplierId = part.SupplierId;
        this.C_Name = part.C_Name;
        this.Weight = part.Weight;
        this.C_Condition = part.C_Condition;
        this.MileageDonorVehicle = part.MileageDonorVehicle;
        this.C_Details = part.C_Details;
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
    public string C_Details { get; set; } = String.Empty;
}
