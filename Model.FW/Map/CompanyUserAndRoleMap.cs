using Core.FW.CoreMap;
using Model.FW.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.FW.Map
{
    class CompanyUserAndRoleMap:CoreMap<CompanyUserAndRole>
    {
        public CompanyUserAndRoleMap()
        {
            Ignore(x => x.ID);
            HasKey(x => new { x.CompanyUserID, x.CompanyRoleID });
        }
    }
}
