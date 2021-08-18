using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.GrupaZaTreniranjeSO
{
    public class SacuvajIzmeneTreningaSO : SystemOperationBase
    {
        protected override void ExecuteOperation(IEntity entity)
        {
            Trening t = (Trening)entity;
            Repository.Update(t);
        }
    }
}
