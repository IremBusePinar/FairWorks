using Core.FW.CoreMap;
using Model.FW.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.FW.Map
{
    class CompanyUserRoleMap:CoreMap<CompanyUserRole>
    {
        public CompanyUserRoleMap()
        {
            ToTable("Roles");
        }
    }
}
