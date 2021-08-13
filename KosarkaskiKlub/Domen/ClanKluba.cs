using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class ClanKluba:IEntity
    {
        public int ClanKlubaId { get; set; }
        public string ImePrezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public DateTime DatumUpisa { get; set; }
        public string NazivSkole { get; set; }
        public GrupaZaTreniranje GrupaZaTreniranje { get; set; }

        public string TableName => "ClanKluba";

        public string InsertValues => $"'{ImePrezime}', '{DatumRodjenja}', '{DatumUpisa}', '{NazivSkole}', {GrupaZaTreniranje.GrupaId}";

        public string IdName => "ClanKlubaId";

        public string JoinCondition => "";

        public string JoinTable => "";

        public string TableAlias => "";

        public object SelectValues => "";

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return ImePrezime;
        }
    }
}
