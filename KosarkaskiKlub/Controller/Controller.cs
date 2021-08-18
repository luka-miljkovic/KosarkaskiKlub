using Domen;
using Storage;
using Storage.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOperations.ClanKlubaSO;
using SystemOperations.GrupaZaTreniranjeSO;
using SystemOperations.PrisustvoSO;
using SystemOperations.SalaZaTreningSO;
using SystemOperations.TrenerSO;

namespace Controller
{
    public class Controller
    {
        private IGenericRepository Repository;
        public Trener Trener { get; set; }
        private static Controller instance;

        private static object _lock = new object();

        public static Controller Instance
        {
            get
            {
                if(instance == null)
                {
                    lock (_lock)
                    {
                        if (instance == null)
                        {
                            instance = new Controller();
                        }
                    }
                }
                return instance;
            }
        }

        private Controller()
        {
            Repository = new GenericRepository();
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

        public List<GrupaZaTreniranje> VratiSveGrupe(GrupaZaTreniranje grupaZaTreniranje)
        {
            VratiSveGrupeSO so = new VratiSveGrupeSO();
            so.ExecuteTemplate(grupaZaTreniranje);
            return so.Result;
        }

        public void SacuvajClana(ClanKluba clanKluba)
        {
            SacuvajNovogClanaSO so = new SacuvajNovogClanaSO();
            so.ExecuteTemplate(clanKluba);
        }

        public List<ClanKluba> PretraziClana(string requestObject)
        {
            PretraziClanaSO so = new PretraziClanaSO();
            so.ExecuteTemplate(new ClanKluba { GCondition = requestObject });
            return so.Result;
        }

        public void EvidentirajPlacanjeClanarine(Clanarina clanarina)
        {
            EvidentirajPlacanjeClanarineSO so = new EvidentirajPlacanjeClanarineSO();
            so.ExecuteTemplate(clanarina);
        }

        public List<Trening> PretraziTreninge(string requestObject)
        {
            PretraziTreningeSO so = new PretraziTreningeSO();
            so.ExecuteTemplate(new Trening { DatumTreninga = Convert.ToDateTime(requestObject), GCondition = $"DatumTreninga='{Convert.ToDateTime(requestObject)}'" });
            return so.Result;
        }

        public void SacuvajPrisustva(List<Prisustvo> listaPrisustva)
        {
            SacuvajPrisustvaSO so = new SacuvajPrisustvaSO
            {
                listaPrisustva = listaPrisustva
            };
            so.ExecuteTemplate(new Prisustvo());
        }

        public void SacuvajIzmeneClana(ClanKluba requestObject)
        {
            SacuvajIzmeneClanaSO so = new SacuvajIzmeneClanaSO();
            so.ExecuteTemplate(requestObject);
        }

        public Trening UcitajTrening(Trening requestObject)
        {
            UcitajTreningSO so = new UcitajTreningSO();
            so.ExecuteTemplate(requestObject);
            return so.Result;
        }

        public void SacuvajIzmeneTreninga(Trening requestObject)
        {
            SacuvajIzmeneTreningaSO so = new SacuvajIzmeneTreningaSO();
            so.ExecuteTemplate(requestObject);
        }
    }
}
