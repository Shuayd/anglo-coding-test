using AutoMapper;
using CodingTest.SA.Analytics.DataAccess.Models;
using CodingTest.SA.Analytics.Services;

namespace CodingTest.SA.Analytics.API.Mappings.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Model, ModelDto>().ReverseMap();
            CreateMap<Contract, ContractDto>().ReverseMap();
            CreateMap<Position, PositionDto>().ReverseMap();
            CreateMap<NewTradeAction, NewTradeActionDto>().ReverseMap();
        }
    }
}
