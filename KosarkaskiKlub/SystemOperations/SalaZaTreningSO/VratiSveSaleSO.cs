using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.SalaZaTreningSO
{
    public class VratiSveSaleSO : SystemOperationBase
    {

        public List<SalaZaTrening> Result { get; private set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            Result = Repository.GetAll(new SalaZaTrening()).Cast<SalaZaTrening>().ToList();
        }
    }
}
