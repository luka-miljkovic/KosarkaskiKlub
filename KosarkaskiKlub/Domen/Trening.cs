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
    public class Trening : IEntity
    {
        public GrupaZaTreniranje GrupaZaTreniranje { get; set; }
        public int TreningId { get; set; }
        public string VremeOd { get; set; }
        public string VremeDo { get; set; }
        public string DanTreninga { get; set; }
        public DateTime DatumTreninga { get; set; }
        public SalaZaTrening SalaZaTrening { get; set; }

        [Browsable(false)]
        public string TableName => "Trening";
        [Browsable(false)]
        public string InsertValues => $"{TreningId}, {GrupaZaTreniranje.GrupaId}, '{VremeOd}', '{VremeDo}', '{DatumTreninga}', '{DanTreninga}', {SalaZaTrening.SalaZaTreningId}";
        [Browsable(false)]
        public string IdName => "TreningID";
        [Browsable(false)]
        public string JoinCondition => "";
        [Browsable(false)]
        public string JoinTable => "";
        [Browsable(false)]
        public string TableAlias => "";
        [Browsable(false)]
        public object SelectValues => "*";
        [Browsable(false)]
        public string WhereCondition => $"TreningID={TreningId} and GrupaZaTreniranjeID={GrupaZaTreniranje.GrupaId}";
        [Browsable(false)]
        public string GetUpdateValues => $"VremeOd='{VremeOd}', VremeDo='{VremeDo}', DatumTreninga='{DatumTreninga}', DanTreninga='{DanTreninga}', SalaZaTreningID={SalaZaTrening.SalaZaTreningId}";
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
                result.Add(new Trening
                {
                    TreningId = (int)reader[0],
                    GrupaZaTreniranje = new GrupaZaTreniranje
                    {
                        GrupaId = (int)reader[1]
                    },
                    VremeOd = (string)reader[2],
                    VremeDo = (string)reader[3],
                    DatumTreninga = Convert.ToDateTime(reader[4]),
                    DanTreninga = (string)reader[5],
                    SalaZaTrening = new SalaZaTrening
                    {
                        SalaZaTreningId = (int)reader[6]
                    }
                });
            }
            return result;
        }

    }
}
