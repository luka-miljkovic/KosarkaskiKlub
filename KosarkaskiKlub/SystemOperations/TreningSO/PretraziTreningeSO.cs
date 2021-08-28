using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.GrupaZaTreniranjeSO
{
    public class PretraziTreningeSO : SystemOperationBase
    {
        public List<Trening> Result { get; private set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            Result = Repository.GetSpecific(entity).Cast<Trening>().ToList();

            foreach (Trening t in Result)
            {
                t.GrupaZaTreniranje = Repository.GetSpecific(new GrupaZaTreniranje { GrupaId = t.GrupaZaTreniranje.GrupaId, GCondition = $"GrupaID={t.GrupaZaTreniranje.GrupaId}" }).Cast<GrupaZaTreniranje>().ToList()[0];
                t.SalaZaTrening = Repository.GetSpecific(new SalaZaTrening { SalaZaTreningId = t.SalaZaTrening.SalaZaTreningId, GCondition = $"SalaZaTreningID={t.SalaZaTrening.SalaZaTreningId}" }).Cast<SalaZaTrening>().ToList()[0];
            }

        }
    }
}
