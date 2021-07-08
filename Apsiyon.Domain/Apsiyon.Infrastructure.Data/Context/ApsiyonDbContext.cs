using Apsiyon.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apsiyon.Infrastructure.Data.Context
{
    public class ApsiyonDbContext :DbContext
    {
        public ApsiyonDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Apartment> Apartments { get; set; }
    }
}
