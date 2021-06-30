using Domen;
using Storage;
using Storage.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOperations.GrupaZaTreniranjeSO;
using SystemOperations.SalaZaTreningSO;
using SystemOperations.TrenerSO;

namespace Controller
{
    public class Controller
    {
        private IGenericRepository Repository;
        public Trener Trener { get; set; }
        private static Controller instance;

        private Controller()
        {
            Repository = new GenericRepository();
        }


        public static Controller Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Controller();
                }
                return instance;
            }
        }

        //TRENER
        public Trener Login(Trener trener)
        {
            LoginSO so = new LoginSO();
            so.ExecuteTemplate(trener);
            return so.Result;
        }
        
        //Grupa za treniranje

        public object VratiSveSale(SalaZaTrening salaZaTrening)
        {
            VratiSveSaleSO so = new VratiSveSaleSO();
            so.ExecuteTemplate(salaZaTrening);
            return so.Result;
        }

        public void SacuvajGrupu(GrupaZaTreniranje grupa)
        {
            SacuvajNovuGrupuSO so = new SacuvajNovuGrupuSO();
            so.ExecuteTemplate(grupa);
            
        }
    }
}
