﻿using AutoMapper;
using Entities.Database;
using Entities.DTO.League;

namespace amateur_soccer_usa.MappingProfiles
{
    public class TeamProfile : Profile
    {
        public TeamProfile()
        {
            CreateMap<Team, LeagueTeamDTO>();
        }
    }
}
