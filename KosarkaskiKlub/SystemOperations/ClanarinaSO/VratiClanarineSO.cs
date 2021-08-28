using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.ClanKlubaSO
{
    public class VratiClanarineSO : SystemOperationBase
    {
        public List<Clanarina> Result { get; set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            Result = Repository.GetSpecific(entity).Cast<Clanarina>().ToList();
        }
    }
}
