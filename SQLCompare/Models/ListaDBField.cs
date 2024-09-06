using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SQLCompare.Models {

    public class Coluna {
        public string Tabela { get; set; }
        public string Nome { get; set; }
    }

    public class DBField {
        public string Tabela { get; set; }
        public string Coluna { get; set; }
        public string Tipo { get; set; }
        public bool IsNullable { get; set; }
        public int? Tamanho { get; set; } 
    }

    public class ListaDBField {
        public ListaDBField() { } 

        public List<DBField> ListarColunas(Credencial credencial) {
            var pers = new Persistencia();
            pers.AbrirConexao(credencial.DataSource, credencial.InitialCatalog, credencial.UserID, credencial.Password);

            var strSQL = "SELECT TABLE_NAME, COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS ORDER BY TABLE_NAME";
            var dtr = new DataTable();
            dtr.Load(pers.retQueryReader(strSQL));

            var lstTabela = new List<DBField>();
            if (dtr.Rows.Count > 0) {
                lstTabela.AddRange(dtr.AsEnumerable().Select(x => new DBField {
                    Tabela = x.Field<string>("TABLE_NAME"),
                    Coluna = x.Field<string>("COLUMN_NAME")
                }).ToList());
            }
            dtr.Dispose();
            pers.FecharConexao();
            return lstTabela;
        }

        //public List<DBField> ListarColunasInfo(Credencial credencial) {
        //    var pers = new Persistencia();
        //    pers.AbrirConexao(credencial.DataSource, credencial.InitialCatalog, credencial.UserID, credencial.Password);

        //    var strSQL = "SELECT TABLE_NAME, COLUMN_NAME, DATA_TYPE, IS_NULLABLE, " +
        //        "CASE WHEN DATA_TYPE LIKE '%char' " +
        //               "OR DATA_TYPE = 'image'" +
        //               "OR DATA_TYPE = 'varbinary'" +
        //               "OR DATA_TYPE LIKE '%text' THEN CHARACTER_MAXIMUM_LENGTH " +
        //             "WHEN DATA_TYPE LIKE '%time' THEN DATETIME_PRECISION " +
        //             "ELSE NUMERIC_PRECISION END AS SIZE " + 
        //        "FROM INFORMATION_SCHEMA.COLUMNS " +
        //        "ORDER BY TABLE_NAME";

        //    var dtr = new DataTable();
        //    dtr.Load(pers.retQueryReader(strSQL));

        //    var lstTabela = new List<DBField>();
        //    if (dtr.Rows.Count > 1) {
        //        lstTabela.AddRange(dtr.AsEnumerable().Select(x => new DBField {
        //            Tabela = x.Field<string>("TABLE_NAME"),
        //            Coluna = x.Field<string>("COLUMN_NAME"),
        //            Tipo = x.Field<string>("DATA_TYPE"),
        //            IsNullable = Convert.ToBoolean(x.Field<string>("IS_NULLABLE") == "YES"),
        //            Tamanho = x.Field<int?>("SIZE")
        //        }).ToList());
        //    }
        //    dtr.Dispose();
        //    pers.FecharConexao();
        //    return lstTabela;
        //}
    }
}
