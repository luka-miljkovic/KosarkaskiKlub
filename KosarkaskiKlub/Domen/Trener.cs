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
    public class Trener:IEntity
    {
        
        public int TrenerId { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public string ImePrezime { get; set; }
        public DateTime DatumZaposlenja { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public bool Ulogovan { get; set; }

        //To-Do
        [Browsable(false)]
        public string TableName => "Trener";
        [Browsable(false)]
        public string InsertValues => "";
        [Browsable(false)]
        public string IdName => "TrenerID";
        [Browsable(false)]
        public string JoinCondition => "";
        [Browsable(false)]
        public string JoinTable => "";
        [Browsable(false)]
        public string TableAlias => "";
        [Browsable(false)]
        public object SelectValues => "*";
        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                result.Add(new Trener
                {
                    TrenerId = (int)reader[0],
                    ImePrezime = (string)reader[1],
                    KorisnickoIme = (string)reader[2],
                    Lozinka = (string)reader[3],
                    DatumZaposlenja = Convert.ToDateTime(reader[4]),
                    DatumRodjenja = Convert.ToDateTime(reader[5])
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
