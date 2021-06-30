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
        public string UzrastGrupe { get; set; }
        public Trener Trener { get; set; }
        public BindingList<Trening> Treninzi { get; set; }

        [Browsable(false)]
        public string TableName => "GrupaZaTreniranje";
        [Browsable(false)]
        public string InsertValues => $"'{NazivGrupe}', '{DatumFormiranja}', '{UzrastGrupe}', {Trener.TrenerId}";
        [Browsable(false)]
        public string IdName => "GrupaID";
        [Browsable(false)]
        public string JoinCondition => "";
        [Browsable(false)]
        public string JoinTable => "";
        [Browsable(false)]
        public string TableAlias => "";
        [Browsable(false)]
        public object SelectValues => "";
        [Browsable(false)]
        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
