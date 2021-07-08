using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apsiyon.Application.ViewModel
{
    public class ApartmentViewModel
    {
        public int ApartmentId { get; set; }

        public string ApartmentBloc { get; set; }
        public bool IsEmpty { get; set; }
        public string ApartmentType { get; set; }
        public int FloorNumber { get; set; }
        public int ApartmentNumber { get; set; }
        public bool IsOwner { get; set; }
        public UserViewModel User { get; set; }
    }
}
