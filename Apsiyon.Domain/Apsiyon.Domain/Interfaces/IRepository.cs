using Apsiyon.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apsiyon.Domain.Interfaces
{
    public interface IRepository<TEntity> where TEntity : IEntity
    {
        Task<int> Add(TEntity entity);
        int Update(TEntity entity);
        int Delete(int Id);
        List<TEntity> GetAll();
    }
}
