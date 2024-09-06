namespace SQLCompare {
    partial class Principal {
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnConectarO = new System.Windows.Forms.Button();
            this.cmbDatabaseO = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPasswordO = new System.Windows.Forms.TextBox();
            this.txtServerO = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUsernameO = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTestarConexao = new System.Windows.Forms.Button();
            this.btnComparar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConectarD = new System.Windows.Forms.Button();
            this.cmbDatabaseD = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPasswordD = new System.Windows.Forms.TextBox();
            this.txtServerD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsernameD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCopiaP = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblDatabaseO = new System.Windows.Forms.Label();
            this.lblDatabaseD = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnConectarO);
            this.groupBox2.Controls.Add(this.cmbDatabaseO);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtPasswordO);
            this.groupBox2.Controls.Add(this.txtServerO);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtUsernameO);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(14, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 298);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ORIGEM";
            // 
            // btnConectarO
            // 
            this.btnConectarO.Enabled = false;
            this.btnConectarO.Location = new System.Drawing.Point(221, 176);
            this.btnConectarO.Name = "btnConectarO";
            this.btnConectarO.Size = new System.Drawing.Size(94, 23);
            this.btnConectarO.TabIndex = 8;
            this.btnConectarO.Text = "Conectar";
            this.btnConectarO.UseVisualStyleBackColor = true;
            this.btnConectarO.Click += new System.EventHandler(this.btnConectarO_Click);
            // 
            // cmbDatabaseO
            // 
            this.cmbDatabaseO.Enabled = false;
            this.cmbDatabaseO.FormattingEnabled = true;
            this.cmbDatabaseO.Location = new System.Drawing.Point(21, 256);
            this.cmbDatabaseO.Name = "cmbDatabaseO";
            this.cmbDatabaseO.Size = new System.Drawing.Size(294, 21);
            this.cmbDatabaseO.TabIndex = 8;
            this.cmbDatabaseO.SelectedIndexChanged += new System.EventHandler(this.cmbDatabaseO_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Server";
            // 
            // txtPasswordO
            // 
            this.txtPasswordO.Enabled = false;
            this.txtPasswordO.Location = new System.Drawing.Point(130, 150);
            this.txtPasswordO.Name = "txtPasswordO";
            this.txtPasswordO.PasswordChar = '*';
            this.txtPasswordO.Size = new System.Drawing.Size(185, 20);
            this.txtPasswordO.TabIndex = 4;
            this.txtPasswordO.TextChanged += new System.EventHandler(this.txtPasswordO_TextChanged);
            // 
            // txtServerO
            // 
            this.txtServerO.Location = new System.Drawing.Point(21, 51);
            this.txtServerO.Name = "txtServerO";
            this.txtServerO.Size = new System.Drawing.Size(294, 20);
            this.txtServerO.TabIndex = 1;
            this.txtServerO.TextChanged += new System.EventHandler(this.txtServerO_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(127, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Username";
            // 
            // txtUsernameO
            // 
            this.txtUsernameO.Enabled = false;
            this.txtUsernameO.Location = new System.Drawing.Point(130, 105);
            this.txtUsernameO.Name = "txtUsernameO";
            this.txtUsernameO.Size = new System.Drawing.Size(185, 20);
            this.txtUsernameO.TabIndex = 3;
            this.txtUsernameO.TextChanged += new System.EventHandler(this.txtUserIDO_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Database";
            // 
            // btnTestarConexao
            // 
            this.btnTestarConexao.Location = new System.Drawing.Point(627, 422);
            this.btnTestarConexao.Name = "btnTestarConexao";
            this.btnTestarConexao.Size = new System.Drawing.Size(94, 33);
            this.btnTestarConexao.TabIndex = 6;
            this.btnTestarConexao.Text = "Testar conexões";
            this.btnTestarConexao.UseVisualStyleBackColor = true;
            this.btnTestarConexao.Click += new System.EventHandler(this.btnTestarConexao_Click);
            // 
            // btnComparar
            // 
            this.btnComparar.Location = new System.Drawing.Point(727, 422);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(94, 33);
            this.btnComparar.TabIndex = 7;
            this.btnComparar.Text = "Comparar";
            this.btnComparar.UseVisualStyleBackColor = true;
            this.btnComparar.Click += new System.EventHandler(this.btnComparar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConectarD);
            this.groupBox1.Controls.Add(this.cmbDatabaseD);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPasswordD);
            this.groupBox1.Controls.Add(this.txtServerD);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtUsernameD);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(479, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 298);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DESTINO";
            // 
            // btnConectarD
            // 
            this.btnConectarD.Enabled = false;
            this.btnConectarD.Location = new System.Drawing.Point(221, 176);
            this.btnConectarD.Name = "btnConectarD";
            this.btnConectarD.Size = new System.Drawing.Size(94, 23);
            this.btnConectarD.TabIndex = 8;
            this.btnConectarD.Text = "Conectar";
            this.btnConectarD.UseVisualStyleBackColor = true;
            this.btnConectarD.Click += new System.EventHandler(this.btnConectarD_Click);
            // 
            // cmbDatabaseD
            // 
            this.cmbDatabaseD.Enabled = false;
            this.cmbDatabaseD.FormattingEnabled = true;
            this.cmbDatabaseD.Location = new System.Drawing.Point(21, 256);
            this.cmbDatabaseD.Name = "cmbDatabaseD";
            this.cmbDatabaseD.Size = new System.Drawing.Size(294, 21);
            this.cmbDatabaseD.TabIndex = 8;
            this.cmbDatabaseD.SelectedIndexChanged += new System.EventHandler(this.cmbDatabaseD_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Server";
            // 
            // txtPasswordD
            // 
            this.txtPasswordD.Enabled = false;
            this.txtPasswordD.Location = new System.Drawing.Point(130, 150);
            this.txtPasswordD.Name = "txtPasswordD";
            this.txtPasswordD.PasswordChar = '*';
            this.txtPasswordD.Size = new System.Drawing.Size(185, 20);
            this.txtPasswordD.TabIndex = 4;
            this.txtPasswordD.TextChanged += new System.EventHandler(this.txtPasswordD_TextChanged);
            // 
            // txtServerD
            // 
            this.txtServerD.Location = new System.Drawing.Point(21, 51);
            this.txtServerD.Name = "txtServerD";
            this.txtServerD.Size = new System.Drawing.Size(294, 20);
            this.txtServerD.TabIndex = 1;
            this.txtServerD.TextChanged += new System.EventHandler(this.txtServerD_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Username";
            // 
            // txtUsernameD
            // 
            this.txtUsernameD.Enabled = false;
            this.txtUsernameD.Location = new System.Drawing.Point(130, 105);
            this.txtUsernameD.Name = "txtUsernameD";
            this.txtUsernameD.Size = new System.Drawing.Size(185, 20);
            this.txtUsernameD.TabIndex = 3;
            this.txtUsernameD.TextChanged += new System.EventHandler(this.txtUsernameD_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Database";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SQLCompare.Properties.Resources.database;
            this.pictureBox1.Location = new System.Drawing.Point(14, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnCopiaP
            // 
            this.btnCopiaP.Enabled = false;
            this.btnCopiaP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCopiaP.Image = global::SQLCompare.Properties.Resources.seta;
            this.btnCopiaP.Location = new System.Drawing.Point(393, 238);
            this.btnCopiaP.Name = "btnCopiaP";
            this.btnCopiaP.Size = new System.Drawing.Size(51, 36);
            this.btnCopiaP.TabIndex = 4;
            this.btnCopiaP.UseVisualStyleBackColor = true;
            this.btnCopiaP.Click += new System.EventHandler(this.btnCopiaP_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "ORIGEM";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(86, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Database:";
            // 
            // lblDatabaseO
            // 
            this.lblDatabaseO.AutoSize = true;
            this.lblDatabaseO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatabaseO.Location = new System.Drawing.Point(157, 43);
            this.lblDatabaseO.Name = "lblDatabaseO";
            this.lblDatabaseO.Size = new System.Drawing.Size(0, 13);
            this.lblDatabaseO.TabIndex = 13;
            // 
            // lblDatabaseD
            // 
            this.lblDatabaseD.AutoSize = true;
            this.lblDatabaseD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatabaseD.Location = new System.Drawing.Point(622, 43);
            this.lblDatabaseD.Name = "lblDatabaseD";
            this.lblDatabaseD.Size = new System.Drawing.Size(0, 13);
            this.lblDatabaseD.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(551, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Database:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(476, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "DESTINO";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SQLCompare.Properties.Resources.database;
            this.pictureBox2.Location = new System.Drawing.Point(479, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 469);
            this.Controls.Add(this.lblDatabaseD);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblDatabaseO);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCopiaP);
            this.Controls.Add(this.btnComparar);
            this.Controls.Add(this.btnTestarConexao);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQLCompare";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTestarConexao;
        private System.Windows.Forms.Button btnComparar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPasswordO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUsernameO;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtServerO;
        private System.Windows.Forms.Button btnCopiaP;
        private System.Windows.Forms.ComboBox cmbDatabaseO;
        private System.Windows.Forms.Button btnConectarO;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConectarD;
        private System.Windows.Forms.ComboBox cmbDatabaseD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPasswordD;
        private System.Windows.Forms.TextBox txtServerD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsernameD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblDatabaseO;
        private System.Windows.Forms.Label lblDatabaseD;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

