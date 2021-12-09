using Core.FW.CoreMap;
using Model.FW.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.FW.Map
{
     public class SectorMap:CoreMap<Sector>
    {
        public SectorMap()
        {
            ToTable("Sectors");
            Property(x => x.SectorName).IsRequired();

        }
    }
}
