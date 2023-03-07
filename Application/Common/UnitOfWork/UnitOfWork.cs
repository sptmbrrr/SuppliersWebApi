using Application.Common.Repository.Interfaces;
using Infrastructure.Persistence;

namespace Application.Common.UnitOfWork;
public class UnitOfWork : IUnitOfWork
{
    public UnitOfWork(
        IPartRepository partRepository,
        ICarRepository carRepository,
        ICarManufacturerRepository carManufacturerRepository,
        IPartLevelRepository partLevelRepository,
        IPartManufacturerRepository partManufacturerRepository,
        IPartTypeRepository partTypeRepository,
        ISupplierRepository supplierRepository
        )
    {
        Parts = partRepository;
        Cars = carRepository;
        CarManufacturers = carManufacturerRepository;
        PartLevels = partLevelRepository;
        PartManufacturers = partManufacturerRepository;
        PartTypes = partTypeRepository;
        Suppliers = supplierRepository;
    }
    public IPartRepository Parts { get; set; }
    public ICarRepository Cars { get; set; }
    public ICarManufacturerRepository CarManufacturers { get; set; }
    public IPartLevelRepository PartLevels { get; set; }
    public IPartManufacturerRepository PartManufacturers { get; set; }
    public IPartTypeRepository PartTypes { get; set; }
    public ISupplierRepository Suppliers { get; set; }
}