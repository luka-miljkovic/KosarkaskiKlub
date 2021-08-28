using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.PrisustvoSO
{
    public class VratiPrisustvaSO : SystemOperationBase
    {
        public List<Prisustvo> Result { get; set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            List<Prisustvo> lista = (List<Prisustvo>)Repository.GetSpecific(entity).Cast<Prisustvo>().ToList();
            Result = lista;
        }
    }
}
