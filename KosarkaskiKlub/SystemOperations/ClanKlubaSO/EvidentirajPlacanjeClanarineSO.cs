using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.ClanKlubaSO
{
    public class EvidentirajPlacanjeClanarineSO : SystemOperationBase
    {
        protected override void ExecuteOperation(IEntity entity)
        {
            Clanarina clanarina = (Clanarina)entity;
            clanarina.ClanarinaId = Repository.GetNewId(entity);
            //clanarina.ClanarinaId = 10;
            Repository.Save(clanarina);
        }
    }
}
