using Apsiyon.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apsiyon.Application.ViewModel
{
   
    public class UserViewModel
    {
        //public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string UserEMail { get; set; }
        public int UserPhone { get; set; }
        public string UserNumberPlate { get; set; }
        public int NationalID { get; set; }

        public List<ApartmentViewModel> Apartments { get; set; }

        //viewmodel in karşılığı DTO denilebilir
        //gösterimle alakalı olacak işlemleri yazacağım
    }

}
