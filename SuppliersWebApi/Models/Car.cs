namespace SuppliersWebApi.Models;

public class Car
{
    public int Id { get; set; }
    public int CarManufacturerId { get; set; }
    public DateTime YearOfManufacture { get; set; } = DateTime.Now;
    public string Model { get; set; } = null!;
    public string? Details { get; set; } = null;

    public CarManufacturer CarManufacturer { get; set; }
}
