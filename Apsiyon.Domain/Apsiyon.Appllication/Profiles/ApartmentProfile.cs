using Apsiyon.Application.ViewModel;
using Apsiyon.Domain.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apsiyon.Application.Profiles
{
    public class ApartmentProfile : Profile
    {
        public ApartmentProfile()
        {
            CreateMap<ApartmentViewModel, Apartment>();
            CreateMap<Apartment, ApartmentViewModel>();
        }
    }
}
