using Domain.Entity;

namespace Application.DTOs;
public class CarDTO
{
    public CarDTO(Car car)
    {
        this.Id = car.Id;
        this.CarManufacturerId = car.CarManufacturerId;
        this.YearOfManufacture = car.YearOfManufacture;
        this.C_Model = car.C_Model;
        this.C_Details = car.C_Details;
    }
    public int Id { get; set; }
    public int CarManufacturerId { get; set; }
    public DateTime YearOfManufacture { get; set; } = DateTime.Now;
    public string C_Model { get; set; } = null!;
    public string? C_Details { get; set; } = null;
    public CarManufacturer? CarManufacturer { get; set; }
}