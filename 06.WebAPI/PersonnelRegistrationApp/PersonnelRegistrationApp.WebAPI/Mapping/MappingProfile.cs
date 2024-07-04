using AutoMapper;
using PersonnelRegistrationApp.WebAPI.DTOs;
using PersonnelRegistrationApp.WebAPI.Models;

namespace PersonnelRegistrationApp.WebAPI.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<PersonnelDto, Personnel>();
    }
}