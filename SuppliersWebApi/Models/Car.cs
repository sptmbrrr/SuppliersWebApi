namespace SuppliersWebApi.Models;

public class Car
{
    public int Id { get; set; }
    public int CarManufacturerId { get; set; }
    public DateTime YearOfManufacture { get; set; } = DateTime.Now;
    public string C_Model { get; set; } = null!;
    public string? C_Details { get; set; } = null;
    public CarManufacturer? CarManufacturer { get; set; }
}
