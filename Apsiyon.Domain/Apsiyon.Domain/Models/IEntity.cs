using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apsiyon.Domain.Models
{
    public interface IEntity
    {
        int Id { get; set; }
        DateTime CreatedAt { get; set; }
    }

    public class Entity : IEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
