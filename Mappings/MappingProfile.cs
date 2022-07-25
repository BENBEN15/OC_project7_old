using AutoMapper;
using WebApi.Dtos;
using WebApi.Models;


namespace WebApi.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Bids, BidDTO>();
            CreateMap<CurvePoints, CurvePointDTO>();
            CreateMap<Ratings, RatingDTO>();
            CreateMap<Rules, RuleDTO>();
            CreateMap<Trades, TradeDTO>();
            CreateMap<Users, UserDTO>();

            CreateMap<BidDTO, Bids>();
            CreateMap<CurvePointDTO, CurvePoints>();
            CreateMap<RatingDTO, Ratings>();
            CreateMap<RuleDTO, Rules>();
            CreateMap<TradeDTO, Trades>();
            CreateMap<UserDTO, Users>();
        }
    }
}
