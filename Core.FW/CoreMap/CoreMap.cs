using Core.FW.CoreEntity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.FW.CoreMap
{
   public class CoreMap<T> : EntityTypeConfiguration<T> where T : BaseEntity
    {
       
    }
}
