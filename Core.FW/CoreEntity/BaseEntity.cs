using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.FW.CoreEntity
{
   public class BaseEntity : IEntity<Guid>
    {
        public Guid ID { get; set; }
    }
}
