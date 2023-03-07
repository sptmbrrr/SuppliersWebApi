using Application.Common.Repository.Interfaces;

namespace Application.Common.UnitOfWork;
public interface IUnitOfWork
{
    IPartRepository Parts { get; }
    ICarRepository Cars { get; }
    ICarManufacturerRepository CarManufacturers { get; }
    IPartLevelRepository PartLevels { get; }
    IPartManufacturerRepository PartManufacturers { get; }
    IPartTypeRepository PartTypes { get; }
    ISupplierRepository Suppliers { get; }
}