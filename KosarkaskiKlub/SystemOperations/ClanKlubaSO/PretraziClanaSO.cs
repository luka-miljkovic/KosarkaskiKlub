using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.ClanKlubaSO
{
    public class PretraziClanaSO : SystemOperationBase
    {
        private static int brojac = 1;
        public List<ClanKluba> Result { get; private set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            Result = (List<ClanKluba>)Repository.GetSpecific(entity).Cast<ClanKluba>().ToList();

            foreach(ClanKluba clan in Result)
            {
                clan.GrupaZaTreniranje = Repository.GetSpecific(new GrupaZaTreniranje { GCondition = $"GrupaID={clan.GrupaZaTreniranje.GrupaId}"}).Cast<GrupaZaTreniranje>().ToList()[0];
            }
        }
    }
}
