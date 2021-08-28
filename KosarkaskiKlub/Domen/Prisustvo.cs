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
    public class Prisustvo : IEntity
    {
        public ClanKluba ClanKluba { get; set; }
        [Browsable(false)]
        public Trening Trening { get; set; }
        public bool Prisutan { get; set; }
        public string RazlogOdsustva { get; set; }
        [Browsable(false)]
        public string TableName => "Prisustvo";
        [Browsable(false)]
        public string InsertValues => $"{ClanKluba.ClanKlubaId}, {Trening.TreningId}, {Trening.GrupaZaTreniranje.GrupaId}, '{Prisutan}', '{RazlogOdsustva}'";
        [Browsable(false)]
        public string IdName => throw new NotImplementedException();
        [Browsable(false)]
        public string JoinCondition => "on (p.TreningID = t.TreningID and p.GrupaZaTreniranjeID = t.GrupaZaTreniranjeID) join ClanKluba ck on(p.ClanKlubaID = ck.ClanKlubaID)";
        [Browsable(false)]
        public string JoinTable => "join Trening t";
        [Browsable(false)]
        public string TableAlias => "p";
        [Browsable(false)]
        public object SelectValues => "*";
        [Browsable(false)]
        public string WhereCondition => $"t.TreningID = {Trening.TreningId} and t.GrupaZaTreniranjeID = {Trening.TreningId}";
        [Browsable(false)]
        public string GetUpdateValues => "";
        [Browsable(false)]
        public string GeneralCondition => $"t.TreningID = {Trening.TreningId} and t.GrupaZaTreniranjeID = {Trening.GrupaZaTreniranje.GrupaId}";

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                result.Add(new Prisustvo
                {
                    ClanKluba = new ClanKluba
                    {
                        ClanKlubaId = (int)reader[0],
                        ImePrezime = (string)reader[13],
                        DatumRodjenja = Convert.ToDateTime(reader[14]),
                        DatumUpisa = Convert.ToDateTime(reader[15]),
                        NazivSkole = (string)reader[16],
                        GrupaZaTreniranje = new GrupaZaTreniranje
                        {
                            GrupaId = (int)reader[17]
                        }
                    },
                    Trening = new Trening
                    {
                        TreningId = (int)reader[5],
                        GrupaZaTreniranje = new GrupaZaTreniranje
                        {
                            GrupaId = (int)reader[6]
                        },
                        VremeOd = (string)reader[7],
                        VremeDo = (string)reader[8],
                        DatumTreninga = Convert.ToDateTime(reader[9]),
                        DanTreninga = (string)reader[10],
                        SalaZaTrening = new SalaZaTrening
                        {
                            SalaZaTreningId = (int)reader[11]
                        }
                    },
                    Prisutan = Convert.ToBoolean(reader[3]),
                    RazlogOdsustva = (string)reader[4]
                });
            }
            return result;
        }
    }
}
