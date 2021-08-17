using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace AssignmentDashboard.Server
{
    public class AutoMappingProfile : Profile
    {
        public AutoMappingProfile()
        {
            /* CreateMap<ClientUsersDto, Users>()
                .ForMember(x => x.Title, x => x.MapFrom(x => x.Name));
            CreateMap<Users, ClientUsersDto>()
                .ForMember(x => x.Id, x => x.MapFrom(x => new UsersAttemps(x.UserId))); */
        }
    }
}
