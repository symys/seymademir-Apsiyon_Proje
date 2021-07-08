using Apsiyon.Domain.Interfaces;
using Apsiyon.Domain.Models;
using Apsiyon.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apsiyon.Infrastructure.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        protected readonly ApsiyonDbContext _context = null;
        private DbSet<TEntity> _entities;

        public Repository(ApsiyonDbContext context)
        {
            _context = context;
            _entities = context.Set<TEntity>();
        }


        public async Task<int> Add(TEntity entity)
        {
            _entities.Add(entity);
            return await _context.SaveChangesAsync();
        }

        public int Delete(int Id)
        {
            TEntity entity = _entities.FirstOrDefault(x => x.Id == Id);
            if (entity == default) return -1;
            _entities.Remove(entity);
            return _context.SaveChanges();
        }

        public List<TEntity> GetAll()
        {
            return _entities.ToList();
        }

        public int Update(TEntity entity)
        {
            return _context.SaveChanges();
        }
    }
}
