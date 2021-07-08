using Apsiyon.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apsiyon.Domain.Interfaces
{
    public interface IUserRepository: IRepository<User>
    {
     
        //List<Apartment> GetAllByUserId(int userId);

    }
}
