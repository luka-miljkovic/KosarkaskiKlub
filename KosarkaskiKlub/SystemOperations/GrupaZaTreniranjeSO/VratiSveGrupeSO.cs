using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.GrupaZaTreniranjeSO
{
    public class VratiSveGrupeSO : SystemOperationBase
    {
        public List<GrupaZaTreniranje> Result { get; private set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            Result = Repository.GetAll(new GrupaZaTreniranje()).Cast<GrupaZaTreniranje>().ToList();
        }
    }
}
