using Model.FW.Entity;
using Service.FW.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.FW.Concrete
{
    public class CompanyUserService:BaseService<CompanyUser>
    {
        public bool UserLogin(string UserName, string password)
        {
            bool result = Any(x => x.UserName == UserName && x.Password == password);
            return result;
        }
    }
}
