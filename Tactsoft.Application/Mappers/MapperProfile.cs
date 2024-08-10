using AutoMapper;
using Tactsoft.Application.ViewModels.VmEntities;
using Tactsoft.SharedKernel.Entities;


namespace Tactsoft.Application.Mappers;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<CountryVm, Country>().ReverseMap();
        CreateMap<StateVm, State>().ReverseMap();
        CreateMap<CityVm, City>().ReverseMap();
        CreateMap<StudentVm, Student>().ReverseMap();


        AllowNullCollections = true;
    }
}
