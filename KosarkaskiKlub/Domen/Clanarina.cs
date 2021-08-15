using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Clanarina : IEntity
    {
        public ClanKluba ClanKluba { get; set; }
        public int ClanarinaId { get; set; }
        public int Mesec { get; set; }
        public int Godina { get; set; }
        public DateTime DatumIsplate { get; set; }
        public double Iznos { get; set; }

        public string TableName => "Clanarina";

        public string InsertValues => $"{ClanarinaId}, {ClanKluba.ClanKlubaId}, {Mesec}, {Godina}, '{DatumIsplate}', {Iznos}";

        public string IdName => "ClanarinaId";

        public string JoinCondition => "";

        public string JoinTable => "";

        public string TableAlias => "";

        public object SelectValues => "";

        public string WhereCondition => throw new NotImplementedException();

        public string GetUpdateValues => throw new NotImplementedException();

        public string GeneralCondition => throw new NotImplementedException();

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
