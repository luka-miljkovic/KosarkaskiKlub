using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public string Mesec { get; set; }
        public int Godina { get; set; }
        public DateTime DatumIsplate { get; set; }
        public double Iznos { get; set; }
        [Browsable(false)]
        public string TableName => "Clanarina";
        [Browsable(false)]
        public string InsertValues => $"{ClanKluba.ClanKlubaId}, '{Mesec}', {Godina}, '{DatumIsplate}', {Iznos}";
        [Browsable(false)]
        public string IdName => "ClanarinaID";
        [Browsable(false)]
        public string JoinCondition => "";
        [Browsable(false)]
        public string JoinTable => "";
        [Browsable(false)]
        public string TableAlias => "";
        [Browsable(false)]
        public object SelectValues => "*";
        [Browsable(false)]
        public string WhereCondition => throw new NotImplementedException();
        [Browsable(false)]
        public string GetUpdateValues => throw new NotImplementedException();
        [Browsable(false)]
        public string GCondition { get; set; }
        [Browsable(false)]
        public string GeneralCondition => $"{GCondition}";

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                result.Add(new Clanarina
                    {
                        ClanarinaId = (int)reader[0],
                        ClanKluba = new ClanKluba { ClanKlubaId = (int)reader[1]},
                        Mesec = (string)reader[2],
                        Godina = (int)reader[3],
                        DatumIsplate = Convert.ToDateTime(reader[4]),
                        Iznos = (double)reader[5]
                    }
               );
            }
            return result;
        }
    }
}
