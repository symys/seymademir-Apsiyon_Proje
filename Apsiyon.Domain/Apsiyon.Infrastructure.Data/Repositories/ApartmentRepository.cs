using Apsiyon.Domain.Interfaces;
using Apsiyon.Domain.Models;
using Apsiyon.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apsiyon.Infrastructure.Data.Repositories
{
    public class ApartmentRepository : Repository<Apartment>, IApartmentRepository
    {
        public ApartmentRepository(ApsiyonDbContext context) : base(context)
        {

        }
    }
}
