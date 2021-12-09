using Core.FW.CoreEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.FW.Entity
{
   public class Log:BaseEntity
    {
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string UserName { get; set; }
    }
}
