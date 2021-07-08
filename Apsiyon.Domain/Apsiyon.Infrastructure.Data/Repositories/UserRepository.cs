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
    public class UserRepository : Repository<User>, IUserRepository
    {
        
        public UserRepository (ApsiyonDbContext context) :base(context)
        {
          
        }

    }
}
