using Core.FW.CoreMap;
using Model.FW.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.FW.Map
{
     public class CompanyUserMap:CoreMap<CompanyUser>
    {
        public CompanyUserMap()
        {
            ToTable("CompanyUsers");
            Property(x => x.EMail).IsRequired();
            Property(x => x.Password).IsRequired();


        }
    }
}
