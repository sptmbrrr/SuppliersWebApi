using Application.Common.DTOs;
using AutoMapper;
using Domain.Entity;

namespace Application.Mappings;

public class MappingsProfiles : Profile
{
    public MappingsProfiles()
    {
        CreateMap<Car, CarDTO>();
    }
}