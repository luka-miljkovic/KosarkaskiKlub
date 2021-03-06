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
    public class ClanKluba:IEntity
    {
        public int ClanKlubaId { get; set; }
        public string ImePrezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public DateTime DatumUpisa { get; set; }
        public string NazivSkole { get; set; }
        public GrupaZaTreniranje GrupaZaTreniranje { get; set; }

        [Browsable(false)]
        public string TableName => "ClanKluba";
        [Browsable(false)]
        public string InsertValues => $"'{ImePrezime}', '{DatumRodjenja}', '{DatumUpisa}', '{NazivSkole}', {GrupaZaTreniranje.GrupaId}";
        [Browsable(false)]
        public string IdName => "ClanKlubaId";
        [Browsable(false)]
        public string JoinCondition => "ON (CK.GrupaZaTreniranjeID = GT.GrupaID) JOIN Trener T ON (GT.TrenerID = T.TrenerID)";
        [Browsable(false)]
        public string JoinTable => "JOIN GrupaZaTreniranje GT";
        [Browsable(false)]
        public string TableAlias => "CK";
        [Browsable(false)]
        public object SelectValues => "*";
        [Browsable(false)]
        public string WhereCondition => $"ClanKlubaID={ClanKlubaId}";
        [Browsable(false)]
        public string GetUpdateValues => $"ImePrezime='{ImePrezime}', DatumRodjenja='{DatumRodjenja}', DatumUpisa='{DatumUpisa}', NazivSkole='{NazivSkole}', GrupaZaTreniranjeID={GrupaZaTreniranje.GrupaId}";
        [Browsable(false)]
        public string GCondition { get; set; }
        [Browsable(false)]
        public string GeneralCondition => $"{GCondition}";
        [Browsable(false)]
        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                result.Add(new ClanKluba { 
                    ClanKlubaId = (int)reader[0],
                    ImePrezime = (string)reader[1],
                    DatumRodjenja = Convert.ToDateTime(reader[2]),
                    DatumUpisa = Convert.ToDateTime(reader[3]),
                    NazivSkole = (string)reader[4],
                    GrupaZaTreniranje = new GrupaZaTreniranje
                    {
                        GrupaId = (int)reader[5],
                        Trener = new Trener
                        {
                            TrenerId = (int)reader[10]
                        }
                    }
                });
            }
            return result;
        }

        public override string ToString()
        {
            return ImePrezime;
        }
    }
}
