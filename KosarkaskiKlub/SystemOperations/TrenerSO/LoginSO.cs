using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.TrenerSO
{
    public class LoginSO : SystemOperationBase
    {
        public Trener Result { get; private set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            Trener trener = (Trener)entity;
            foreach(Trener t in Repository.GetAll(new Trener()))
            {
                if(t.KorisnickoIme == trener.KorisnickoIme &&
                    t.Lozinka == trener.Lozinka)
                {
                    trener.ImePrezime = t.ImePrezime;
                    trener.TrenerId = t.TrenerId;
                    trener.DatumZaposlenja = t.DatumZaposlenja;
                    trener.DatumRodjenja = t.DatumRodjenja;
                    Result = trener;
                }
            }
        }
    }
}
