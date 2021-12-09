using Core.FW.CoreMap;
using Model.FW.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.FW.Map
{
    public class SalloonMap:CoreMap<Salloon>
    {
        public SalloonMap()
        {
            ToTable("Salloons");
            Property(x => x.WhichSector).IsRequired();
            Property(x => x.StandNumber).IsRequired();

        }
    }
}
