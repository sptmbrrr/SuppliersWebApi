using Microsoft.EntityFrameworkCore;
using Infrastructure.Persistence;
using Domain.Entity;
using Application.Common.DTOs;
using Application.Common.Repository.Interfaces;

namespace Application.Common.Repository.Repositories;

public class PartRepository : RepositoryBase<Part>, IPartRepository
{
    public PartRepository(DataContext context)
        : base(context) { }

    public async Task CreatePartAsync(PartDTO partDTO)
    {
        var part = new Part
        {
            Id = partDTO.Id,
            CarId = partDTO.CarId,
            ParentPartId = partDTO.ParentPartId,
            PartLevelId = partDTO.PartLevelId,
            PartManufacturerId = partDTO.PartManufacturerId,
            PartTypeId = partDTO.PartTypeId,
            SupplierId = partDTO.SupplierId,
            C_Name = partDTO.C_Name,
            Weight = partDTO.Weight,
            C_Condition = partDTO.C_Condition,
            MileageDonorVehicle = partDTO.MileageDonorVehicle,
            C_Details = partDTO.C_Details
        };

        Create(part);
    }

    public Task DeletePartAsync(int id)
    {
        var part = FindByCondition(x => x.Id.Equals(id)).FirstOrDefaultAsync();

        //Delete(part);

        return Task.CompletedTask;
    }

    public async Task<IEnumerable<Part>> GetPartsAsync()
    {
        return await FindAll().ToListAsync();
    }
    public async Task<Part> GetPartByIdAsync(int id)
    {
        return await FindByCondition(x => x.Id.Equals(id)).FirstOrDefaultAsync();
    }

    public Task UpdatePartAsync(PartDTO partDTO, int id)
    {
        var updatePart = FindByCondition(x => x.Id.Equals(id)).FirstOrDefaultAsync();
        if (partDTO.Id == updatePart.Id)
        {
            var part = new Part
            {
                Id = partDTO.Id,
                CarId = partDTO.CarId,
                ParentPartId = partDTO.ParentPartId,
                PartLevelId = partDTO.PartLevelId,
                PartManufacturerId = partDTO.PartManufacturerId,
                PartTypeId = partDTO.PartTypeId,
                SupplierId = partDTO.SupplierId,
                C_Name = partDTO.C_Name,
                Weight = partDTO.Weight,
                C_Condition = partDTO.C_Condition,
                MileageDonorVehicle = partDTO.MileageDonorVehicle,
                C_Details = partDTO.C_Details
            };
            Update(part);
        }
        return Task.CompletedTask;
    }
}
