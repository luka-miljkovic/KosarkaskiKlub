using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.GrupaZaTreniranjeSO
{
    public class UcitajTreningSO : SystemOperationBase
    {
        public Trening Result { get; private set; }

        protected override void ExecuteOperation(IEntity entity)
        {
            Result = Repository.GetSpecific(entity).Cast<Trening>().ToList()[0];
            Result.GrupaZaTreniranje = Repository.GetSpecific(new GrupaZaTreniranje { GCondition = $"GrupaID={Result.GrupaZaTreniranje.GrupaId}" }).Cast<GrupaZaTreniranje>().ToList()[0];
        }
    }
}
