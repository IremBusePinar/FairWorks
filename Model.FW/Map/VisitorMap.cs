using Core.FW.CoreMap;
using Model.FW.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.FW.Map
{
    class VisitorMap:CoreMap<Visitor>
    {
        public VisitorMap()
        {

            ToTable("Visitors");
            Property(x => x.FirstName).IsRequired();
            Property(x => x.LastName).IsRequired();
            Property(x => x.CompanyName).IsRequired();
            Property(x => x.Occupation).IsRequired();

          
        }
    }
}
