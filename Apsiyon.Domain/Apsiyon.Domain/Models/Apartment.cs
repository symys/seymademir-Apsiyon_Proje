using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apsiyon.Domain.Models
{
    public class Apartment :Entity
    {
        public int ApartmentId { get; set; }
        [ForeignKey("UserId")] 

        public virtual User User { get; set; } 

        public string ApartmentBloc { get; set; }
        public bool IsEmpty { get; set; }
        public string ApartmentType { get; set; }
        public int FloorNumber { get; set; }
        public int ApartmentNumber { get; set; }
        public bool IsOwner { get; set; }
        
    }
}
