using AutoMapper;
using MyPortfolio.Models;

namespace MyPortfolio.Mapping.AutoMapperProfile;

public class MapProfile : Profile
{
    public MapProfile()
    {
        CreateMap<UpdateAboutViewModel, TblAbout>().ReverseMap();
        CreateMap<CreateServiceViewModel, TblService>().ReverseMap();
    }
}
