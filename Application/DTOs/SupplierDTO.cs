using Domain.Entity;

namespace Application.DTOs;
public class SupplierDTO
{
    public SupplierDTO(Supplier supplier)
    {
        this.Id = supplier.Id;
        this.C_Name = supplier.C_Name;
    }
    public int Id { get; set; }
    public string C_Name { get; set; } = null!;
}