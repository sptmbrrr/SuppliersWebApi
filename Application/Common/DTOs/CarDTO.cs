using Domain.Entity;
using System.Runtime.Serialization;
using System.Xml.Linq;

namespace Application.Common.DTOs;

[DataContract(Name = "CarDTO", Namespace = "")]
public class CarDTO
{
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