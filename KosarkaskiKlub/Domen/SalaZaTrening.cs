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
    public class SalaZaTrening : IEntity
    {
        public int SalaZaTreningId { get; set; }
        public string NazivSaleZaTrening { get; set; }
        public string Adresa { get; set; }

        [Browsable(false)]
        public string TableName => "SalaZaTrening";
        [Browsable(false)]
        public string InsertValues => "";
        [Browsable(false)]
        public string IdName => "SalaZaTreningID";
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
                result.Add(new SalaZaTrening
                {
                    SalaZaTreningId = (int)reader[0],
                    NazivSaleZaTrening = (string)reader[1],
                    Adresa = (string)reader[2]
                });
                
            }
            return result;
        }
        public override string ToString()
        {
            return NazivSaleZaTrening;
        }
    }
}
