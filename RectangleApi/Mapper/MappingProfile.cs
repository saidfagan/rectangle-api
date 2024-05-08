using AutoMapper;
using RectangleApi.Data;
using RectangleApi.Model;

namespace RectangleApi.Mapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<RectangleDto, RectangleEntity>()
            .ReverseMap();
    }
}