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
        public string JoinCondition => "";
        [Browsable(false)]
        public string JoinTable => "";
        [Browsable(false)]
        public string TableAlias => "";
        [Browsable(false)]
        public object SelectValues => "";
        [Browsable(false)]
        public string WhereCondition => "";
        [Browsable(false)]
        public string GetUpdateValues => "";
        [Browsable(false)]
        public string GeneralCondition => "";

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
