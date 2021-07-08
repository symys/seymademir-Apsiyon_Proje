using Apsiyon.Application.Interfaces;
using Apsiyon.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apsiyon.Application.Services
{
    public class ApartmentService : IApartmentService
    {
        public Task<bool> Add(ApartmentViewModel entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<ApartmentViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(ApartmentViewModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
