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
    public class GrupaZaTreniranje : IEntity
    {
        public int GrupaId { get; set; }
        public string NazivGrupe { get; set; }
        public DateTime DatumFormiranja { get; set; }
        [Browsable(false)]
        public DateTime DatumOd { get; set; }
        [Browsable(false)]
        public DateTime DatumDo { get; set; }
        public string UzrastGrupe { get; set; }
        public Trener Trener { get; set; }
        public BindingList<Trening> Treninzi { get; set; }

        public override string ToString()
        {
            return $"{GrupaId}) {NazivGrupe}-{UzrastGrupe}";
        }

        [Browsable(false)]
        public string TableName => "GrupaZaTreniranje";
        [Browsable(false)]
        public string InsertValues => $"'{NazivGrupe}', '{DatumFormiranja}', '{UzrastGrupe}', {Trener.TrenerId}";
        [Browsable(false)]
        public string IdName => "GrupaID";
        [Browsable(false)]
        public string JoinCondition => "ON (GT.TrenerID = T.TrenerID)";
        [Browsable(false)]
        public string JoinTable => "JOIN Trener T";
        [Browsable(false)]
        public string TableAlias => "GT";
        [Browsable(false)]
        public object SelectValues => "*";
        [Browsable(false)]
        public string WhereCondition => $"GrupaID={GrupaId}";
        [Browsable(false)]
        public string GetUpdateValues => "";
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
                result.Add(new GrupaZaTreniranje
                {
                    GrupaId = (int)reader[0],
                    NazivGrupe = (string)reader[1],
                    DatumFormiranja = Convert.ToDateTime(reader[2]),
                    UzrastGrupe = (string)reader[3],
                    Trener = new Trener
                    {
                        TrenerId = (int)reader[4],
                        ImePrezime = (string)reader[6],
                        KorisnickoIme = (string)reader[7],
                        Lozinka = (string)reader[8],
                        DatumZaposlenja = Convert.ToDateTime(reader[9]),
                        DatumRodjenja = Convert.ToDateTime(reader[10])
                    }
                });
            }
            return result;
        }
    }
}
