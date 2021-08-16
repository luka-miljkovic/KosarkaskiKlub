using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.PrisustvoSO
{
    public class SacuvajPrisustvaSO : SystemOperationBase
    {
        public List<Prisustvo> listaPrisustva { get; set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            foreach(Prisustvo p in listaPrisustva)
            {
                Repository.Save(p);
            }
        }
    }
}
