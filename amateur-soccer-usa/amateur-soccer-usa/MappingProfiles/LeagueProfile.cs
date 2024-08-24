﻿using AutoMapper;
using Entities.Database;
using Entities.DTO;

namespace amateur_soccer_usa.MappingProfiles
{
    public class LeagueProfile : Profile
    {
        public LeagueProfile()
        {
            CreateMap<League, LeagueDTO>();
        }
    }
}
