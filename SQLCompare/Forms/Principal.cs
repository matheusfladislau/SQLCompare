using SQLCompare.Models;
using System;
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

            var Origem = new Credencial(txtDataSourceO.Text, txtInitialO.Text, txtUserIDO.Text, txtPasswordO.Text);
            var Destino = new Credencial(txtDataSourceD.Text, txtInitialD.Text, txtUserIDD.Text, txtPasswordD.Text);

            Compare CompareForm = new Compare(Origem, Destino);
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
            return !(txtDataSourceO.TextLength == 0 || txtDataSourceD.TextLength == 0 || txtInitialO.TextLength == 0 || txtInitialD.TextLength == 0 || txtPasswordO.TextLength == 0 || txtPasswordD.TextLength == 0 || txtUserIDO.TextLength == 0 || txtUserIDD.TextLength == 0);
        }

        private bool CompararConexao() {
            Persistencia pers = new Persistencia();

            bool SucessoOrigem = pers.AbrirConexao(txtDataSourceO.Text, txtInitialO.Text, txtUserIDO.Text, txtPasswordO.Text);
            pers.FecharConexao();

            bool SucessoDestino = pers.AbrirConexao(txtDataSourceD.Text, txtInitialD.Text, txtUserIDD.Text, txtPasswordD.Text, false);
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

        private void btnCopiaDS_Click(object sender, EventArgs e) {
            txtDataSourceD.Text = txtDataSourceO.Text;
        }

        private void btnCopiaIC_Click(object sender, EventArgs e) {
            txtInitialD.Text = txtInitialO.Text;

        }

        private void btnCopiaID_Click(object sender, EventArgs e) {
            txtUserIDD.Text = txtUserIDO.Text;
        }

        private void btnCopiaP_Click(object sender, EventArgs e) {
            txtPasswordD.Text = txtPasswordO.Text;
        }
    }
}
