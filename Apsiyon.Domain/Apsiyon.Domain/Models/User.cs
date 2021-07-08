using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apsiyon.Domain.Models
{
    public class User : Entity
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public int NationalID { get; set; }
        public string UserEMail { get; set; }
        public int UserPhone { get; set; }
        public string UserNumberPlate { get; set; }

        public virtual ICollection<Apartment> Apartments { get; set; }
    }
}
