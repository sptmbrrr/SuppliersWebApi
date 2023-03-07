using Domain.Entity;

namespace Application.Common.DTOs;
public class SupplierDTO
{
    public SupplierDTO(Supplier supplier)
    {
        Id = supplier.Id;
        C_Name = supplier.C_Name;
    }
    public int Id { get; set; }
    public string C_Name { get; set; } = null!;
}