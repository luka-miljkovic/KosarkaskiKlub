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
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
        public string UzrastGrupe { get; set; }
        public Trener Trener { get; set; }
        public BindingList<Trening> Treninzi { get; set; }

        public override string ToString()
        {
            return $"{NazivGrupe}-{UzrastGrupe}";
        }

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
        public object SelectValues => "*";

        public string WhereCondition => throw new NotImplementedException();

        public string GetUpdateValues => throw new NotImplementedException();

        public string GeneralCondition => throw new NotImplementedException();

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
                    UzrastGrupe = (string)reader[3]
                });
            }
            return result;
        }
    }
}
