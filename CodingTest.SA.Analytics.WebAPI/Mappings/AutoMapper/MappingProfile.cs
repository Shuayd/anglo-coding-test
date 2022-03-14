using AutoMapper;
using CodingTest.SA.Analytics.DataAccess.Models;
using CodingTest.SA.Analytics.Services;
using CodingTest.SA.Analytics.Services.Models;

namespace CodingTest.SA.Analytics.WebAPI.Mappings.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Model, ModelDto>().ReverseMap();
            CreateMap<Contract, ContractDto>().ReverseMap();
            CreateMap<Position, PositionDto>().ReverseMap();
            CreateMap<NewTradeAction, NewTradeActionDto>().ReverseMap();
            CreateMap<Commodity, CommodityDto>().ReverseMap();
            CreateMap<ModelResult, ModelResultDto>().ReverseMap();
        }
    }
}
