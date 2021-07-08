using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apsiyon.Application.Interfaces
{
    public interface IService<TEntity>
    {
        Task<bool> Add(TEntity entity);
        bool Update(TEntity entity);
        bool Delete(int id);
        List<TEntity> GetAll();
    }
}
