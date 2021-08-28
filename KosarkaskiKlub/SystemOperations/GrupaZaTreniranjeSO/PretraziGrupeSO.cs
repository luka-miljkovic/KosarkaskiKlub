using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.GrupaZaTreniranjeSO
{
    public class PretraziGrupeSO : SystemOperationBase
    {
        public List<GrupaZaTreniranje> Result { get; set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            Result = Repository.GetSpecific(entity).Cast<GrupaZaTreniranje>().ToList();
        }
    }
}
