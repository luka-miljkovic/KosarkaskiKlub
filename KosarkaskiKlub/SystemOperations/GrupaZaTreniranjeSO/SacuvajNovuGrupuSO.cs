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

            int rbTreninga = 1;
            

            foreach (Trening trening in grupa.Treninzi)
            {
                trening.GrupaZaTreniranje = new GrupaZaTreniranje
                {
                    GrupaId = grupaId
                };
                DateTime dateIterator = grupa.DatumOd;
                int brojacNedelja = 7;
                int brojacDana = 1;
                while (true)
                {
                    //System.Windows.Forms.MessageBox.Show("Usao ovde");
                    if (Convert.ToString(dateIterator.DayOfWeek) == trening.DanTreninga)
                    {
                        
                        while (dateIterator <= grupa.DatumDo)
                        {
                            trening.TreningId = rbTreninga;
                            trening.DatumTreninga = dateIterator;
                            Repository.Save(trening);
                            dateIterator = dateIterator.AddDays(7);
                            //brojacNedelja += 7;
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
