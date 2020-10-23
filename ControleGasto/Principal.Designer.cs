namespace ControleGasto
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.lblMesAno = new System.Windows.Forms.Label();
            this.btnProximoMes = new System.Windows.Forms.Button();
            this.dtGridViewDividas = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnInserirNovaDivida = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lbltotals = new System.Windows.Forms.Label();
            this.lblVlrTotal = new System.Windows.Forms.Label();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtPagas = new System.Windows.Forms.RadioButton();
            this.rbtDividas = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSaldoTotal = new System.Windows.Forms.Label();
            this.lblSaltoPagas = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnExlcuirDivida = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewDividas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mês/Ano:";
            // 
            // lblMesAno
            // 
            this.lblMesAno.AutoSize = true;
            this.lblMesAno.ForeColor = System.Drawing.Color.Blue;
            this.lblMesAno.Location = new System.Drawing.Point(176, 41);
            this.lblMesAno.Name = "lblMesAno";
            this.lblMesAno.Size = new System.Drawing.Size(25, 15);
            this.lblMesAno.TabIndex = 1;
            this.lblMesAno.Text = "......";
            // 
            // btnProximoMes
            // 
            this.btnProximoMes.BackColor = System.Drawing.Color.LightGreen;
            this.btnProximoMes.Image = ((System.Drawing.Image)(resources.GetObject("btnProximoMes.Image")));
            this.btnProximoMes.Location = new System.Drawing.Point(179, 57);
            this.btnProximoMes.Name = "btnProximoMes";
            this.btnProximoMes.Size = new System.Drawing.Size(68, 29);
            this.btnProximoMes.TabIndex = 2;
            this.btnProximoMes.UseVisualStyleBackColor = false;
            this.btnProximoMes.Click += new System.EventHandler(this.btnProximoMes_Click);
            // 
            // dtGridViewDividas
            // 
            this.dtGridViewDividas.AllowUserToAddRows = false;
            this.dtGridViewDividas.AllowUserToDeleteRows = false;
            this.dtGridViewDividas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewDividas.Location = new System.Drawing.Point(15, 92);
            this.dtGridViewDividas.Name = "dtGridViewDividas";
            this.dtGridViewDividas.Size = new System.Drawing.Size(559, 279);
            this.dtGridViewDividas.TabIndex = 3;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Green;
            this.btnInsert.ForeColor = System.Drawing.Color.Black;
            this.btnInsert.Image = ((System.Drawing.Image)(resources.GetObject("btnInsert.Image")));
            this.btnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsert.Location = new System.Drawing.Point(467, 372);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(107, 36);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "Marcar Pagos";
            this.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnInserirNovaDivida
            // 
            this.btnInserirNovaDivida.BackColor = System.Drawing.Color.LightSalmon;
            this.btnInserirNovaDivida.Image = ((System.Drawing.Image)(resources.GetObject("btnInserirNovaDivida.Image")));
            this.btnInserirNovaDivida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInserirNovaDivida.Location = new System.Drawing.Point(15, 372);
            this.btnInserirNovaDivida.Name = "btnInserirNovaDivida";
            this.btnInserirNovaDivida.Size = new System.Drawing.Size(101, 36);
            this.btnInserirNovaDivida.TabIndex = 5;
            this.btnInserirNovaDivida.Text = "Nova Divida";
            this.btnInserirNovaDivida.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInserirNovaDivida.UseVisualStyleBackColor = false;
            this.btnInserirNovaDivida.Click += new System.EventHandler(this.btnInserirNovaDivida_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bem Vindo(a):";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.Blue;
            this.lblUsuario.Location = new System.Drawing.Point(91, 9);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(45, 15);
            this.lblUsuario.TabIndex = 7;
            this.lblUsuario.Text = "Nome";
            // 
            // lbltotals
            // 
            this.lbltotals.AutoSize = true;
            this.lbltotals.Location = new System.Drawing.Point(252, 7);
            this.lbltotals.Name = "lbltotals";
            this.lbltotals.Size = new System.Drawing.Size(111, 15);
            this.lbltotals.TabIndex = 8;
            this.lbltotals.Text = "Valor Total Dividas:";
            // 
            // lblVlrTotal
            // 
            this.lblVlrTotal.AutoSize = true;
            this.lblVlrTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVlrTotal.ForeColor = System.Drawing.Color.Red;
            this.lblVlrTotal.Location = new System.Drawing.Point(283, 20);
            this.lblVlrTotal.Name = "lblVlrTotal";
            this.lblVlrTotal.Size = new System.Drawing.Size(32, 16);
            this.lblVlrTotal.TabIndex = 9;
            this.lblVlrTotal.Text = "......";
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.LightGreen;
            this.btnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Image")));
            this.btnAnterior.Location = new System.Drawing.Point(108, 57);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(65, 29);
            this.btnAnterior.TabIndex = 10;
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtPagas);
            this.groupBox1.Controls.Add(this.rbtDividas);
            this.groupBox1.Location = new System.Drawing.Point(15, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(87, 59);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exibir";
            // 
            // rbtPagas
            // 
            this.rbtPagas.AutoSize = true;
            this.rbtPagas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtPagas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rbtPagas.Location = new System.Drawing.Point(6, 37);
            this.rbtPagas.Name = "rbtPagas";
            this.rbtPagas.Size = new System.Drawing.Size(65, 19);
            this.rbtPagas.TabIndex = 13;
            this.rbtPagas.TabStop = true;
            this.rbtPagas.Text = "Pagos";
            this.rbtPagas.UseVisualStyleBackColor = true;
            this.rbtPagas.CheckedChanged += new System.EventHandler(this.rbtPagas_CheckedChanged);
            // 
            // rbtDividas
            // 
            this.rbtDividas.AutoSize = true;
            this.rbtDividas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtDividas.ForeColor = System.Drawing.Color.Maroon;
            this.rbtDividas.Location = new System.Drawing.Point(6, 20);
            this.rbtDividas.Name = "rbtDividas";
            this.rbtDividas.Size = new System.Drawing.Size(72, 19);
            this.rbtDividas.TabIndex = 12;
            this.rbtDividas.TabStop = true;
            this.rbtDividas.Text = "Dividas";
            this.rbtDividas.UseVisualStyleBackColor = true;
            this.rbtDividas.CheckedChanged += new System.EventHandler(this.rbtDividas_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(252, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "R$";
            // 
            // btnEntrada
            // 
            this.btnEntrada.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEntrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnEntrada.Image = ((System.Drawing.Image)(resources.GetObject("btnEntrada.Image")));
            this.btnEntrada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntrada.Location = new System.Drawing.Point(490, 9);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(84, 29);
            this.btnEntrada.TabIndex = 13;
            this.btnEntrada.Text = "Entradas";
            this.btnEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEntrada.UseVisualStyleBackColor = false;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(410, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Saldo Total:";
            // 
            // lblSaldoTotal
            // 
            this.lblSaldoTotal.AutoSize = true;
            this.lblSaldoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoTotal.ForeColor = System.Drawing.Color.Blue;
            this.lblSaldoTotal.Location = new System.Drawing.Point(488, 45);
            this.lblSaldoTotal.Name = "lblSaldoTotal";
            this.lblSaldoTotal.Size = new System.Drawing.Size(26, 16);
            this.lblSaldoTotal.TabIndex = 15;
            this.lblSaldoTotal.Text = "......";
            // 
            // lblSaltoPagas
            // 
            this.lblSaltoPagas.AutoSize = true;
            this.lblSaltoPagas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaltoPagas.ForeColor = System.Drawing.Color.Green;
            this.lblSaltoPagas.Location = new System.Drawing.Point(487, 70);
            this.lblSaltoPagas.Name = "lblSaltoPagas";
            this.lblSaltoPagas.Size = new System.Drawing.Size(26, 16);
            this.lblSaltoPagas.TabIndex = 17;
            this.lblSaltoPagas.Text = "......";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(395, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Saldo - Pagas:";
            // 
            // btnExlcuirDivida
            // 
            this.btnExlcuirDivida.BackColor = System.Drawing.Color.Firebrick;
            this.btnExlcuirDivida.ForeColor = System.Drawing.Color.Black;
            this.btnExlcuirDivida.Image = ((System.Drawing.Image)(resources.GetObject("btnExlcuirDivida.Image")));
            this.btnExlcuirDivida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExlcuirDivida.Location = new System.Drawing.Point(255, 372);
            this.btnExlcuirDivida.Name = "btnExlcuirDivida";
            this.btnExlcuirDivida.Size = new System.Drawing.Size(59, 36);
            this.btnExlcuirDivida.TabIndex = 19;
            this.btnExlcuirDivida.Text = "Excluir";
            this.btnExlcuirDivida.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExlcuirDivida.UseVisualStyleBackColor = false;
            this.btnExlcuirDivida.Click += new System.EventHandler(this.btnExlcuirDivida_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 411);
            this.Controls.Add(this.btnExlcuirDivida);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblSaltoPagas);
            this.Controls.Add(this.lblSaldoTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEntrada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.lblVlrTotal);
            this.Controls.Add(this.lbltotals);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnInserirNovaDivida);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dtGridViewDividas);
            this.Controls.Add(this.btnProximoMes);
            this.Controls.Add(this.lblMesAno);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Activated += new System.EventHandler(this.Principal_Load);
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewDividas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMesAno;
        private System.Windows.Forms.Button btnProximoMes;
        private System.Windows.Forms.DataGridView dtGridViewDividas;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnInserirNovaDivida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lbltotals;
        private System.Windows.Forms.Label lblVlrTotal;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtPagas;
        private System.Windows.Forms.RadioButton rbtDividas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSaldoTotal;
        private System.Windows.Forms.Label lblSaltoPagas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnExlcuirDivida;
    }
}