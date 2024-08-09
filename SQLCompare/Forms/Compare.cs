using SQLCompare.Models;
using System.Windows.Forms;
using System.Linq;
using System.ComponentModel;
using System.Collections.Generic;

namespace SQLCompare {
    public partial class Compare : Form {
        private Credencial Origem;
        private Credencial Destino;

        private List<DBField> InfoOrigem; 
        private List<DBField> InfoDestino; 
        
        public Compare(Credencial Origem, Credencial Destino) {
            this.Origem = Origem;
            this.Destino = Destino;

            InitializeComponent();
        }

        private void Compare_Load(object sender, System.EventArgs e) {
            lblDestinoNome.Text = Destino.InitialCatalog;
            lblOrigemNome.Text = Origem.InitialCatalog;

            lblDataSourceDestino.Text = Destino.DataSource;
            lblDataSourceOrigem.Text = Origem.DataSource;

            PreencherDados();
        }

        private void PreencherDados() {
            PreencherTabela();
            //PreencherColuna();
            //PreencherColunaTamanho();
        }

        private void PreencherTabela() {
            var coluna = new ListaDBField();
            this.InfoOrigem = coluna.ListarColunas(Origem);
            this.InfoDestino = coluna.ListarColunas(Destino);

            var hashOrigem = new HashSet<string>(InfoOrigem.Select(x => x.Tabela).Distinct());
            var hashDestino = new HashSet<string>(InfoDestino.Select(x => x.Tabela).Distinct());

            var tabelasOrigemNNoDestino = InfoOrigem
                .Where(x => !hashDestino.Contains(x.Tabela))
                .Select(x => new { Value = x.Tabela })
                .Distinct() 
                .ToList();

            var tabelasDestinoNNoOrigem = InfoDestino
                .Where(x => !hashOrigem.Contains(x.Tabela))
                .Select(x => new { Value = x.Tabela })
                .Distinct() 
                .ToList();

            DestinoNOrigem.DataSource = tabelasOrigemNNoDestino;
            OrigemNDestino.DataSource = tabelasDestinoNNoOrigem;
        }


        //private void PreencherColuna() {
        //    var hashOrigem = new HashSet<DBField>(InfoOrigem);
        //    var hashDestino = new HashSet<DBField>(InfoDestino);

        //    ColunasNOrigem.DataSource = new BindingList<Coluna>(hashDestino.Where(x => !hashOrigem.Any(y => x.Tabela == y.Tabela && x.Coluna == y.Coluna)).Select(x => new Coluna { Tabela = x.Tabela, Nome = x.Coluna }).ToList());
        //    ColunasNDestino.DataSource = new BindingList<Coluna>(hashOrigem.Where(x => !hashDestino.Any(y => x.Tabela == y.Tabela && x.Coluna == y.Coluna)).Select(x => new Coluna { Tabela = x.Tabela, Nome = x.Coluna }).ToList());
        //}

        //private void PreencherColunaTamanho() {
        //    var hashOrigem = new HashSet<DBField>(InfoOrigem);
        //    var hashDestino = new HashSet<DBField>(InfoDestino);

        //    ColunasNOrigem.DataSource = new BindingList<DBField>(hashDestino.Where(x => !hashOrigem.Any(y => x.Tabela == y.Tabela && x.Coluna == y.Coluna)).ToList());
        //    ColunasNDestino.DataSource = new BindingList<DBField>(hashOrigem.Where(x => !hashDestino.Any(y => x.Tabela == y.Tabela && x.Coluna == y.Coluna)).ToList());
        //}
    }
} 