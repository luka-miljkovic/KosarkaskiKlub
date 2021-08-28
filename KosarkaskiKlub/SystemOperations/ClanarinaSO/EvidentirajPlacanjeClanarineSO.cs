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
            List<Clanarina> lista = Repository.GetAll(new Clanarina ()).Cast<Clanarina>().ToList();
            clanarina.ClanarinaId = ((Repository.GetNewId(entity) == 1 &&(lista == null || lista.Count == 0) )? 1 : Repository.GetNewId(entity) + 1);
            //clanarina.ClanarinaId = 10;
            Repository.Save(clanarina);
        }
    }
}
