using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SQLCompare.Models {

    public class Tabela {
        public string Nome { get; set; }
    }

    public class ListaTabela {

        public ListaTabela() { } 

        public List<Tabela> ListarTabelas(Credencial credencial) {
            var pers = new Persistencia();
            pers.AbrirConexao(credencial.DataSource, credencial.InitialCatalog, credencial.UserID, credencial.Password);

            var strSQL = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES ORDER BY TABLE_NAME";
            var dtr = new DataTable();
            dtr.Load(pers.retQueryReader(strSQL));

            var lstTabela = new List<Tabela>();
            if (dtr.Rows.Count > 1) {
                lstTabela.AddRange(dtr.AsEnumerable().Select(x => new Tabela {
                    Nome = x.Field<string>("TABLE_NAME")
                }).ToList());
            }
            dtr.Dispose();
            pers.FecharConexao();
            return lstTabela;
        }
    }
}
