using AutoMapper;
using Apsiyon.Application.ViewModel;
using Apsiyon.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apsiyon.Application.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserViewModel, User>();
            CreateMap<User, UserViewModel >();
        }
    }
}
