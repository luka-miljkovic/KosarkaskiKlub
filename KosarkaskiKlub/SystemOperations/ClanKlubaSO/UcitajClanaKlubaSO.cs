using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.ClanKlubaSO
{
    public class UcitajClanaKlubaSO : SystemOperationBase
    {
        public List<ClanKluba> Result { get; private set; }

        protected override void ExecuteOperation(IEntity entity)
        {
            Result = Repository.GetSpecific(entity).Cast<ClanKluba>().ToList();
            //Result.GrupaZaTreniranje = Repository.GetSpecific(new GrupaZaTreniranje { GCondition = $"GrupaID={Result.GrupaZaTreniranje.GrupaId}" }).Cast<GrupaZaTreniranje>().ToList()[0];
        }
    }
}
