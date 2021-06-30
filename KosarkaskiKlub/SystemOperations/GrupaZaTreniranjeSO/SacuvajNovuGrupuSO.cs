using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.GrupaZaTreniranjeSO
{
    public class SacuvajNovuGrupuSO : SystemOperationBase
    {
        protected override void ExecuteOperation(IEntity entity)
        {
            GrupaZaTreniranje grupa = (GrupaZaTreniranje)entity;
            Repository.Save(grupa);

            int grupaId = Repository.GetNewId(new GrupaZaTreniranje());

            foreach(Trening trening in grupa.Treninzi)
            {
                trening.GrupaZaTreniranje = new GrupaZaTreniranje
                {
                    GrupaId = grupaId
                };
                Repository.Save(trening);
            }
        }
    }
}
