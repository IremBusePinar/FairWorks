using Core.FW.CoreMap;
using Model.FW.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.FW.Map
{
   public class FairMap:CoreMap<Fair>
    {
        public FairMap()
        {
            ToTable("Fairs");
            Property(x => x.FairName).IsRequired();
           

        }
    }
}
