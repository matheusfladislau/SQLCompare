using SQLCompare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SQLCompare {
    public partial class Principal : Form {
        public Principal() {
            InitializeComponent();
        }

        private void btnComparar_Click(object sender, EventArgs e) {
            if (!CamposValidados()) {
                MessageBox.Show("Preencha todos os campos!", "Erro.");
                return;
            }

            if (!CompararConexao()) {
                return;
            }

            var Origem = new Credencial(txtServerO.Text, cmbDatabaseO.SelectedItem.ToString(), txtUsernameO.Text, txtPasswordO.Text);
            var Destino = new Credencial(txtServerD.Text, cmbDatabaseD.SelectedItem.ToString(), txtUsernameD.Text, txtPasswordD.Text);

            var CompareForm = new Compare(Origem, Destino);
            CompareForm.Show();
        }

        private void btnTestarConexao_Click(object sender, EventArgs e) {
            if (!CamposValidados()) {
                MessageBox.Show("Preencha todos os campos!", "Erro.");
                return;
            }

            if (CompararConexao()) {
                MessageBox.Show("As conexões foram estabelecidas com sucesso.", "Sucesso.");
            }
        }

        private bool CamposValidados() {
            return !(txtServerO.TextLength == 0 || txtServerD.TextLength == 0 || cmbDatabaseO.SelectedItem.ToString().Length == 0 || cmbDatabaseD.SelectedItem.ToString().Length == 0 || txtPasswordO.TextLength == 0 || txtPasswordD.TextLength == 0 || txtUsernameO.TextLength == 0 || txtUsernameD.TextLength == 0);
        }

        private bool CompararConexao() {
            var pers = new Persistencia();

            bool SucessoOrigem = pers.AbrirConexao(txtServerO.Text, cmbDatabaseO.SelectedItem.ToString(), txtUsernameO.Text, txtPasswordO.Text);
            pers.FecharConexao();

            bool SucessoDestino = pers.AbrirConexao(txtServerD.Text, cmbDatabaseD.SelectedItem.ToString(), txtUsernameD.Text, txtPasswordD.Text, false);
            pers.FecharConexao();

            pers.Dispose();
            if (!SucessoDestino && !SucessoOrigem) {
                MessageBox.Show("As duas conexões não foram estabelecidas com sucesso.", "Erro.");
                return false;
            } 
            if (!SucessoOrigem) {
                MessageBox.Show("A conexão de origem não foi estabelecida com sucesso.", "Erro.");
                return false;
            }
            if (!SucessoDestino) {
                MessageBox.Show("A conexão de destino não foi estabelecida com sucesso.", "Erro.");
                return false;
            }
            return true;
        }

        private void btnConectarO_Click(object sender, EventArgs e) {
            var pers = new Persistencia();

            var databaseSelected = cmbDatabaseO.SelectedItem != null ? cmbDatabaseO.SelectedItem.ToString() : null;

            bool SucessoOrigem = pers.AbrirConexao(txtServerO.Text, databaseSelected, txtUsernameO.Text, txtPasswordO.Text);
            if (!SucessoOrigem) {
                MessageBox.Show("A conexão não foi estabelecida com sucesso.", "Erro.");
                txtUsernameO.Enabled = false;
                txtPasswordO.Enabled = false;
                btnConectarO.Enabled = false;
                cmbDatabaseO.DataSource = null;
                cmbDatabaseO.Enabled = false;
                btnCopiaP.Enabled = false;
                txtServerO.Clear();
                txtServerO.Focus();
                pers.Dispose();
                return;
            }
            pers.Dispose();
            btnCopiaP.Enabled = true;

            var Credencial = new Credencial(txtServerO.Text, databaseSelected, txtUsernameO.Text, txtPasswordO.Text);

            var lstDatabase = new List<Database>(ListaDatabase.ListarDatabases(Credencial));
            cmbDatabaseO.DataSource = new List<string>(lstDatabase.Select(x => x.Nome));
            cmbDatabaseO.Enabled = true;
            return;
        }

        private void txtServerO_TextChanged(object sender, EventArgs e) {
            if (txtServerO.TextLength > 0) {
                txtUsernameO.Enabled = true;
                txtPasswordO.Enabled = true;
                btnConectarO.Enabled = true;
            } else {
                txtUsernameO.Enabled = false;
                txtPasswordO.Enabled = false;
                btnConectarO.Enabled = false;
                cmbDatabaseO.DataSource = null;
                cmbDatabaseO.Enabled = false;
            }
        }

        private void txtUserIDO_TextChanged(object sender, EventArgs e) {
            if (txtUsernameO.Modified) {
                cmbDatabaseO.DataSource = null;
                cmbDatabaseO.Enabled = false;
            } 
        }

        private void txtPasswordO_TextChanged(object sender, EventArgs e) {
            if (txtPasswordO.Modified) {
                cmbDatabaseO.DataSource = null;
                cmbDatabaseO.Enabled = false;
            } 
        }

        private void btnCopiaP_Click(object sender, EventArgs e) {
            txtServerD.Text = txtServerO.Text;
            txtUsernameD.Text = txtUsernameO.Text;
            txtPasswordD.Text = txtPasswordO.Text;
            

            var Credencial = new Credencial(txtServerD.Text, null, txtUsernameD.Text, txtPasswordD.Text);
            var lstDatabase = new List<Database>(ListaDatabase.ListarDatabases(Credencial));
            cmbDatabaseD.DataSource = new List<string>(lstDatabase.Select(x => x.Nome));
            cmbDatabaseD.SelectedIndex = cmbDatabaseO.SelectedIndex;

            txtUsernameD.Enabled = true;
            txtPasswordD.Enabled = true;
            btnConectarD.Enabled = true;
            cmbDatabaseD.Enabled = true;
        }

        private void txtServerD_TextChanged(object sender, EventArgs e) {
            if (txtServerD.TextLength > 0) {
                txtUsernameD.Enabled = true;
                txtPasswordD.Enabled = true;
                btnConectarD.Enabled = true;
            } else {
                txtUsernameD.Enabled = false;
                txtPasswordD.Enabled = false;
                btnConectarD.Enabled = false;
                cmbDatabaseD.DataSource = null;
                cmbDatabaseD.Enabled = false;
            }
        }

        private void txtUsernameD_TextChanged(object sender, EventArgs e) {
            if (txtUsernameD.Modified) {
                cmbDatabaseD.DataSource = null;
                cmbDatabaseD.Enabled = false;
            } 
        }

        private void txtPasswordD_TextChanged(object sender, EventArgs e) {
            if (txtPasswordD.Modified) {
                cmbDatabaseD.DataSource = null;
                cmbDatabaseD.Enabled = false;
            } 
        }

        private void btnConectarD_Click(object sender, EventArgs e) {
            var pers = new Persistencia();

            var databaseSelected = cmbDatabaseD.SelectedItem != null ? cmbDatabaseD.SelectedItem.ToString() : null;

            bool SucessoOrigem = pers.AbrirConexao(txtServerD.Text, databaseSelected, txtUsernameO.Text, txtPasswordD.Text);
            if (!SucessoOrigem) {
                MessageBox.Show("A conexão não foi estabelecida com sucesso.", "Erro.");
                txtUsernameD.Enabled = false;
                txtPasswordD.Enabled = false;
                btnConectarD.Enabled = false;
                cmbDatabaseD.DataSource = null;
                cmbDatabaseD.Enabled = false;
                txtServerD.Clear();
                txtServerD.Focus();
                pers.Dispose();
                return;
            }
            pers.Dispose();

            var Credencial = new Credencial(txtServerD.Text, databaseSelected, txtUsernameD.Text, txtPasswordD.Text);

            var lstDatabase = new List<Database>(ListaDatabase.ListarDatabases(Credencial));
            cmbDatabaseD.DataSource = new List<string>(lstDatabase.Select(x => x.Nome));
            cmbDatabaseD.Enabled = true;
            return;
        }

        private void cmbDatabaseO_SelectedIndexChanged(object sender, EventArgs e) {
            lblDatabaseO.Text = cmbDatabaseO.SelectedItem.ToString();
        }

        private void cmbDatabaseD_SelectedIndexChanged(object sender, EventArgs e) {
            lblDatabaseD.Text = cmbDatabaseD.SelectedItem.ToString();
        }
    }
}
