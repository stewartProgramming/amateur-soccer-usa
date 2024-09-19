using AutoMapper;
using Entities.Database;
using Entities.DTO.League;

namespace amateur_soccer_usa.MappingProfiles
{
    public class LeagueProfile : Profile
    {
        public LeagueProfile()
        {
            CreateMap<League, LeagueDTO>()
                .ForMember(x => x.Teams, y => y.MapFrom(z => z.Teams))
                ;

            CreateMap<LeagueUpdateDTO, League>()
                .ForMember(x => x.Name, y => y.MapFrom(z => z.LeagueName))
                .ForMember(x => x.StartingYear, y => y.MapFrom(z => z.StartYear))
                .ForMember(x => x.Logo, y => y.MapFrom(z => z.LogoUrl))
                ;
        }
    }
}
