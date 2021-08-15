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
        [Browsable(false)]
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
        public object SelectValues => "";

        public string WhereCondition => throw new NotImplementedException();

        public string GetUpdateValues => throw new NotImplementedException();

        public string GeneralCondition => throw new NotImplementedException();

        [Browsable(false)]
        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
