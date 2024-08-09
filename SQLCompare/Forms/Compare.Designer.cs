namespace SQLCompare {
    partial class Compare {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.lblOrigemNome = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDataSourceOrigem = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.ColunasNDestino = new System.Windows.Forms.DataGridView();
            this.ColunasNOrigem = new System.Windows.Forms.DataGridView();
            this.Tabela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.DestinoNOrigem = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.OrigemNDestino = new System.Windows.Forms.DataGridView();
            this.tabAbas = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.TamanhoNDestino = new System.Windows.Forms.DataGridView();
            this.TamanhoNOrigem = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDataSourceDestino = new System.Windows.Forms.Label();
            this.lblDestinoNome = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColunasNDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColunasNOrigem)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DestinoNOrigem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrigemNDestino)).BeginInit();
            this.tabAbas.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TamanhoNDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TamanhoNOrigem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Banco de ORIGEM:";
            // 
            // lblOrigemNome
            // 
            this.lblOrigemNome.AutoSize = true;
            this.lblOrigemNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigemNome.ForeColor = System.Drawing.Color.Red;
            this.lblOrigemNome.Location = new System.Drawing.Point(18, 42);
            this.lblOrigemNome.Name = "lblOrigemNome";
            this.lblOrigemNome.Size = new System.Drawing.Size(0, 24);
            this.lblOrigemNome.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(18, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data Source:";
            // 
            // lblDataSourceOrigem
            // 
            this.lblDataSourceOrigem.AutoSize = true;
            this.lblDataSourceOrigem.Location = new System.Drawing.Point(89, 66);
            this.lblDataSourceOrigem.Name = "lblDataSourceOrigem";
            this.lblDataSourceOrigem.Size = new System.Drawing.Size(0, 13);
            this.lblDataSourceOrigem.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.ColunasNDestino);
            this.tabPage2.Controls.Add(this.ColunasNOrigem);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1055, 547);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Colunas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(531, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Colunas que faltam no DESTINO";
            // 
            // ColunasNDestino
            // 
            this.ColunasNDestino.AllowUserToAddRows = false;
            this.ColunasNDestino.AllowUserToDeleteRows = false;
            this.ColunasNDestino.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ColunasNDestino.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ColunasNDestino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ColunasNDestino.ColumnHeadersVisible = false;
            this.ColunasNDestino.Location = new System.Drawing.Point(534, 26);
            this.ColunasNDestino.Name = "ColunasNDestino";
            this.ColunasNDestino.RowHeadersVisible = false;
            this.ColunasNDestino.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.ColunasNDestino.Size = new System.Drawing.Size(515, 521);
            this.ColunasNDestino.TabIndex = 4;
            // 
            // ColunasNOrigem
            // 
            this.ColunasNOrigem.AllowUserToAddRows = false;
            this.ColunasNOrigem.AllowUserToDeleteRows = false;
            this.ColunasNOrigem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ColunasNOrigem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ColunasNOrigem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ColunasNOrigem.ColumnHeadersVisible = false;
            this.ColunasNOrigem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tabela,
            this.Coluna});
            this.ColunasNOrigem.Location = new System.Drawing.Point(6, 26);
            this.ColunasNOrigem.Name = "ColunasNOrigem";
            this.ColunasNOrigem.RowHeadersVisible = false;
            this.ColunasNOrigem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.ColunasNOrigem.Size = new System.Drawing.Size(515, 521);
            this.ColunasNOrigem.TabIndex = 3;
            // 
            // Tabela
            // 
            this.Tabela.HeaderText = "Tabela";
            this.Tabela.Name = "Tabela";
            // 
            // Coluna
            // 
            this.Coluna.HeaderText = "Coluna";
            this.Coluna.Name = "Coluna";
            this.Coluna.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Colunas que faltam na ORIGEM";
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.DestinoNOrigem);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.OrigemNDestino);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1055, 547);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tabelas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(531, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tabelas que faltam no DESTINO";
            // 
            // DestinoNOrigem
            // 
            this.DestinoNOrigem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DestinoNOrigem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DestinoNOrigem.ColumnHeadersVisible = false;
            this.DestinoNOrigem.Location = new System.Drawing.Point(534, 26);
            this.DestinoNOrigem.Name = "DestinoNOrigem";
            this.DestinoNOrigem.Size = new System.Drawing.Size(515, 521);
            this.DestinoNOrigem.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tabelas que faltam na ORIGEM";
            // 
            // OrigemNDestino
            // 
            this.OrigemNDestino.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrigemNDestino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrigemNDestino.ColumnHeadersVisible = false;
            this.OrigemNDestino.Location = new System.Drawing.Point(6, 26);
            this.OrigemNDestino.Name = "OrigemNDestino";
            this.OrigemNDestino.Size = new System.Drawing.Size(515, 521);
            this.OrigemNDestino.TabIndex = 0;
            // 
            // tabAbas
            // 
            this.tabAbas.Controls.Add(this.tabPage1);
            this.tabAbas.Controls.Add(this.tabPage2);
            this.tabAbas.Controls.Add(this.tabPage3);
            this.tabAbas.Location = new System.Drawing.Point(12, 108);
            this.tabAbas.Name = "tabAbas";
            this.tabAbas.SelectedIndex = 0;
            this.tabAbas.Size = new System.Drawing.Size(1063, 573);
            this.tabAbas.TabIndex = 8;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.TamanhoNDestino);
            this.tabPage3.Controls.Add(this.TamanhoNOrigem);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1055, 547);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Colunas - Infos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(531, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(222, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Colunas com tamanho diferente no DESTINO";
            // 
            // TamanhoNDestino
            // 
            this.TamanhoNDestino.AllowUserToAddRows = false;
            this.TamanhoNDestino.AllowUserToDeleteRows = false;
            this.TamanhoNDestino.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TamanhoNDestino.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TamanhoNDestino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TamanhoNDestino.ColumnHeadersVisible = false;
            this.TamanhoNDestino.Location = new System.Drawing.Point(534, 26);
            this.TamanhoNDestino.Name = "TamanhoNDestino";
            this.TamanhoNDestino.RowHeadersVisible = false;
            this.TamanhoNDestino.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.TamanhoNDestino.Size = new System.Drawing.Size(515, 530);
            this.TamanhoNDestino.TabIndex = 8;
            // 
            // TamanhoNOrigem
            // 
            this.TamanhoNOrigem.AllowUserToAddRows = false;
            this.TamanhoNOrigem.AllowUserToDeleteRows = false;
            this.TamanhoNOrigem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TamanhoNOrigem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TamanhoNOrigem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TamanhoNOrigem.ColumnHeadersVisible = false;
            this.TamanhoNOrigem.Location = new System.Drawing.Point(6, 26);
            this.TamanhoNOrigem.Name = "TamanhoNOrigem";
            this.TamanhoNOrigem.RowHeadersVisible = false;
            this.TamanhoNOrigem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.TamanhoNOrigem.Size = new System.Drawing.Size(515, 530);
            this.TamanhoNOrigem.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(217, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Colunas com tamanho diferente na ORIGEM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(383, 90);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lblDataSourceDestino
            // 
            this.lblDataSourceDestino.AutoSize = true;
            this.lblDataSourceDestino.Location = new System.Drawing.Point(485, 66);
            this.lblDataSourceDestino.Name = "lblDataSourceDestino";
            this.lblDataSourceDestino.Size = new System.Drawing.Size(0, 13);
            this.lblDataSourceDestino.TabIndex = 13;
            // 
            // lblDestinoNome
            // 
            this.lblDestinoNome.AutoSize = true;
            this.lblDestinoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinoNome.ForeColor = System.Drawing.Color.Red;
            this.lblDestinoNome.Location = new System.Drawing.Point(414, 42);
            this.lblDestinoNome.Name = "lblDestinoNome";
            this.lblDestinoNome.Size = new System.Drawing.Size(0, 24);
            this.lblDestinoNome.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(414, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Banco de DESTINO:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox2.Location = new System.Drawing.Point(408, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(383, 90);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(414, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Data Source:";
            // 
            // Compare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 693);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDataSourceDestino);
            this.Controls.Add(this.lblDestinoNome);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tabAbas);
            this.Controls.Add(this.lblDataSourceOrigem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblOrigemNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "Compare";
            this.Text = "SQLCompare";
            this.Load += new System.EventHandler(this.Compare_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColunasNDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColunasNOrigem)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DestinoNOrigem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrigemNDestino)).EndInit();
            this.tabAbas.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TamanhoNDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TamanhoNOrigem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOrigemNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDataSourceOrigem;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DestinoNOrigem;
        private System.Windows.Forms.TabControl tabAbas;
        private System.Windows.Forms.DataGridView OrigemNDestino;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDataSourceDestino;
        private System.Windows.Forms.Label lblDestinoNome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView ColunasNDestino;
        private System.Windows.Forms.DataGridView ColunasNOrigem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView TamanhoNDestino;
        private System.Windows.Forms.DataGridView TamanhoNOrigem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tabela;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna;
    }
}