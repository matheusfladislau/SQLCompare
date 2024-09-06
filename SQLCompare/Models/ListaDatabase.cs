using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SQLCompare.Models {
    public class Database {
        public string Nome { get; set; }
    }

    public class ListaDatabase {
        public static List<Database> ListarDatabases(Credencial credencial) {
            var pers = new Persistencia();
            pers.AbrirConexao(credencial.DataSource, credencial.InitialCatalog, credencial.UserID, credencial.Password);

            var strSQL = "SELECT NAME FROM SYS.DATABASES ORDER BY NAME";
            var dtr = new DataTable();
            dtr.Load(pers.retQueryReader(strSQL));

            var lstDatabase = new List<Database>();
            if (dtr.Rows.Count > 0) {
                lstDatabase.AddRange(dtr.AsEnumerable().Select(x => new Database {
                    Nome = x.Field<string>("NAME"),
                }).ToList());
            }
            dtr.Dispose();
            pers.FecharConexao();
            return lstDatabase;
        }
    }
}
