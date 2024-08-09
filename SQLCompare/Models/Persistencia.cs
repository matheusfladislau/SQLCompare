using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace SQLCompare.Models {
    public class Persistencia {
        public string ConexaoOrigem { get; set; }
        public string ConexaoDestino { get; set; }

        StreamReader udl;
        public string strBase = "";
        private DataSet dts;
        private SqlDataAdapter adapter;
        public SqlConnection cn;
        private SqlCommand cmd;
        private List<SqlParameter> parameters;
        private bool tran = false;
        private SqlDataReader dtr;

        #region "Abrir, Fechar e Formatar conexão"
        public bool AbrirConexao(string DataSource, string InitialCatalog, string UserID, string Password, bool icOrigem = true) {
            try {
                if (icOrigem) {
                    ConexaoOrigem = FormatarConexao(DataSource, InitialCatalog, UserID, Password);
                    cn = new SqlConnection(ConexaoOrigem);
                    cn.Open();
                    BeginTrans();
                    return true;
                }
                ConexaoDestino = FormatarConexao(DataSource, InitialCatalog, UserID, Password);
                cn = new SqlConnection(ConexaoDestino);
                cn.Open();
                BeginTrans();
                return true;
            } catch  {
                return false;
            }
        }

        public void FecharConexao() {
            if (cn != null) {
                cn.Close();
                cn.Dispose();
            }
            if (adapter != null) {
                adapter.Dispose();
            }
        }
        private string FormatarConexao(string DataSource, string InitialCatalog, string UserID, string Password) {
            return $"Data Source={DataSource};Initial Catalog={InitialCatalog};Persist Security Info=True;User ID={UserID};Password={Password}";
        }
        #endregion

        #region "Metodos de Consulta e Execucao"
        public SqlDataReader retQueryReader(string _strSQL) {
            cmd = new SqlCommand(_strSQL, cn);
            cmd.CommandText = _strSQL;
            cmd.CommandType = CommandType.Text;

            dtr = cmd.ExecuteReader();
            return dtr;
        }

        public Boolean ExecQuery(string _strSQL) {
            return ExecQuery(_strSQL, false);
        }

        public Boolean ExecQuery(string _strSQL, bool usarparametros) {
            try {
                cmd = new SqlCommand(_strSQL, cn);
                if (usarparametros) {
                    cmd.Parameters.AddRange(parameters.ToArray());
                }

                return cmd.ExecuteNonQuery() != 0;
            } catch (SqlException sqlEx) {
                throw new Exception(sqlEx.Message.ToString() + " - " + sqlEx.StackTrace.ToString());
            } catch {
                throw new Exception("Erro ao executar a Query de SQL na base de dados.");
            }
        }
        #endregion

        #region MetodosPrivados
        private void CommitTrans() {
            if (tran) this.ExecQuery("commit transaction");
            tran = false;
        }

        private void BeginTrans() {
            this.ExecQuery("begin transaction");
            tran = true;
        }

        private void RollBackTrans() {
            if (tran) this.ExecQuery("rollback transaction");
            tran = false;
        }

        #endregion

        #region Destrutor
        ~Persistencia() {
            Dispose(false);
        }
        #endregion

        #region IDisposable Members

        bool disposed;

        private void Dispose(bool disposing) {
            if (!this.disposed) {
                if (disposing) {
                    if (this.dts != null) {
                        this.dts.Dispose();
                    }
                    if (adapter != null) {
                        this.adapter.Dispose();
                    }
                    if (cn != null) {
                        this.cn.Dispose();
                    }
                    if (cmd != null) {
                        this.cmd.Dispose();
                    }
                    if (udl != null) {
                        this.udl.Dispose();
                    }
                }
                disposed = true;
            }
        }

        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
