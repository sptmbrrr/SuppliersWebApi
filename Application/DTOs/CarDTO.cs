using Domain.Entity;
using System.Runtime.Serialization;
using System.Xml.Linq;

namespace Application.DTOs;

[DataContract(Name = "CarDTO", Namespace = "")]
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
    [DataMember]
    public int Id { get; set; }
    [DataMember]
    public int CarManufacturerId { get; set; }
    [DataMember]
    public DateTime YearOfManufacture { get; set; } = DateTime.Now;
    [DataMember]
    public string C_Model { get; set; } = null!;
    [DataMember]
    public string? C_Details { get; set; } = null;
}