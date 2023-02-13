using Application.Repository;
using Infrastructure.Persistence;

namespace Application.UnitOfWork;
public class UnitOfWork : IUnitOfWork
{
    public UnitOfWork(
        IPartRepository partRepository,
        ICarRepository carsRepository
        //ICarManufacturerRepository carManufacturers,
        //IPartLevelRepository partLevels
        )
    {
        Parts = partRepository;
        Cars = carsRepository;
        //CarManufacturers = carManufacturers;
        //PartLevels = partLevels;
    }
    public IPartRepository Parts { get; set; }
    public ICarRepository Cars { get; set; }
/*    public ICarManufacturerRepository CarManufacturers { get; set; }
    public IPartLevelRepository PartLevels { get; set; }
    public IPartManufacturerRepository PartManufacturers { get; set; }
    public IPartTypeRepository PartTypes { get; set; }
    public ISupplierRepository Suppliers { get; set; }*/
}