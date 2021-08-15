using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.ClanKlubaSO
{
    public class PretraziClanaSO : SystemOperationBase
    {
        public List<ClanKluba> Result { get; private set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            Result = Repository.GetSpecific(entity).Cast<ClanKluba>().ToList();
        }
    }
}
