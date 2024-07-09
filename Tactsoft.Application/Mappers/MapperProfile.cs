using AutoMapper;


namespace Tactsoft.Application.Mappers;

public class MapperProfile : Profile
{
    public MapperProfile()
    {


        AllowNullCollections = true;
    }
}
