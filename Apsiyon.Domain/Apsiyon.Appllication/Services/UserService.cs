using Apsiyon.Application.Interfaces;
using Apsiyon.Application.ViewModel;
using Apsiyon.Domain.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apsiyon.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository = null;
        private readonly IMapper _mapper;
        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }


        public async Task<bool> Add(UserViewModel user)
        {
            //user.UserEMail = blog.SelectedCategories.Select(x => new CategoryViewModel { Id = x }).ToList();

            int id = await _userRepository.Add(new Domain.Models.User
            { 
                UserName=user.UserName,
                CreatedAt = DateTime.Now,
                UserSurname = user.UserSurname,
                UserEMail = user.UserEMail,
                UserPhone = user.UserPhone,
                UserNumberPlate = user.UserNumberPlate
            });
            return id > 0;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<UserViewModel> GetAll()
        {
            return _mapper.Map<List<UserViewModel>>(_userRepository.GetAll());
        }

        public bool Update(UserViewModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
