using Core.FW.CoreEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.FW.Entity
{
    public class CompanyUserAndRole:BaseEntity
    {
        public Guid CompanyUserID { get; set; }
        public Guid CompanyRoleID { get; set; }

        public virtual CompanyUser CompanyUser{ get; set; }
        public virtual CompanyUserRole CompanyUserRole { get; set; }
    }
}
