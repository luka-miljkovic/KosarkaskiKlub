using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.ClanKlubaSO
{
    public class SacuvajIzmeneClanaSO : SystemOperationBase
    {
        protected override void ExecuteOperation(IEntity entity)
        {
            ClanKluba clanKluba = (ClanKluba)entity;
            Repository.Update(clanKluba);
        }
    }
}
