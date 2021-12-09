using Core.FW.CoreMap;
using Model.FW.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.FW.Map
{
    class FairParticipantMap:CoreMap<FairParticipant>
    {
        public FairParticipantMap()
        {

            ToTable("FairParticipants");
            Property(x => x.SalesPerson).IsRequired();
            //Property(x => x.).IsRequired();
            //Property(x => x.Company.Sector).IsRequired();


        }
    }
}
