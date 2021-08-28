using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
            List<Trening> lista = Repository.GetAll(new Trening()).Cast<Trening>().ToList();
            int rbTreninga = ((Repository.GetNewId(new Trening()) == 1 && (lista == null || lista.Count == 0)) ? 1 : Repository.GetNewId(new Trening()) + 1);


            foreach (Trening trening in grupa.Treninzi)
            {
                trening.GrupaZaTreniranje = new GrupaZaTreniranje
                {
                    GrupaId = grupaId
                };
                DateTime dateIterator = grupa.DatumOd;
                while (true)
                {
                    if (Convert.ToString(dateIterator.DayOfWeek) == trening.DanTreninga)
                    {
                        
                        while (dateIterator <= grupa.DatumDo)
                        {
                            trening.TreningId = rbTreninga;
                            trening.DatumTreninga = dateIterator;
                            Repository.Save(trening);
                            dateIterator = dateIterator.AddDays(7);
                            rbTreninga++;
                        }
                        break;
                    }
                    else
                    { 
                        dateIterator = dateIterator.AddDays(1);
                    }
                    
                }
                
                
            }
       

            
        }
    }
}
