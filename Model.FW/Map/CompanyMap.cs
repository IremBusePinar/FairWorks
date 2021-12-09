using Core.FW.CoreMap;
using Model.FW.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.FW.Map
{
     public class CompanyMap:CoreMap<Company>
    {
        public CompanyMap()
        {
            ToTable("Companies");

            Property(x => x.CompanyName).IsRequired();
            Property(x => x.CompanyName).HasMaxLength(100);
            Property(x => x.Sector).IsRequired();


        }
    }
}
