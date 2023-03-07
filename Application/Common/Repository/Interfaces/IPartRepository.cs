using Application.Common.DTOs;
using Domain.Entity;

namespace Application.Common.Repository.Interfaces;

public interface IPartRepository : IRepositoryBase<Part>
{
    Task<IEnumerable<Part>> GetPartsAsync();
    Task<Part> GetPartByIdAsync(int id);
    Task CreatePartAsync(PartDTO part);
    Task DeletePartAsync(int id);
    Task UpdatePartAsync(PartDTO part, int id);
}