namespace ControleGasto
{
    partial class FrmEntrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEntrada));
            this.dtGridViewEntradas = new System.Windows.Forms.DataGridView();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnProximoMes = new System.Windows.Forms.Button();
            this.lblMesAno = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNovaEntrada = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblVlrTotal = new System.Windows.Forms.Label();
            this.lbltotals = new System.Windows.Forms.Label();
            this.btnExcluiEntrada = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewEntradas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridViewEntradas
            // 
            this.dtGridViewEntradas.AllowUserToAddRows = false;
            this.dtGridViewEntradas.AllowUserToDeleteRows = false;
            this.dtGridViewEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewEntradas.Location = new System.Drawing.Point(15, 65);
            this.dtGridViewEntradas.Name = "dtGridViewEntradas";
            this.dtGridViewEntradas.Size = new System.Drawing.Size(476, 230);
            this.dtGridViewEntradas.TabIndex = 7;
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.LightGreen;
            this.btnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Image")));
            this.btnAnterior.Location = new System.Drawing.Point(15, 33);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(65, 26);
            this.btnAnterior.TabIndex = 12;
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnProximoMes
            // 
            this.btnProximoMes.BackColor = System.Drawing.Color.LightGreen;
            this.btnProximoMes.Image = ((System.Drawing.Image)(resources.GetObject("btnProximoMes.Image")));
            this.btnProximoMes.Location = new System.Drawing.Point(86, 33);
            this.btnProximoMes.Name = "btnProximoMes";
            this.btnProximoMes.Size = new System.Drawing.Size(68, 26);
            this.btnProximoMes.TabIndex = 11;
            this.btnProximoMes.UseVisualStyleBackColor = false;
            this.btnProximoMes.Click += new System.EventHandler(this.btnProximoMes_Click);
            // 
            // lblMesAno
            // 
            this.lblMesAno.AutoSize = true;
            this.lblMesAno.ForeColor = System.Drawing.Color.Blue;
            this.lblMesAno.Location = new System.Drawing.Point(72, 9);
            this.lblMesAno.Name = "lblMesAno";
            this.lblMesAno.Size = new System.Drawing.Size(25, 13);
            this.lblMesAno.TabIndex = 14;
            this.lblMesAno.Text = "......";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mês/Ano:";
            // 
            // btnNovaEntrada
            // 
            this.btnNovaEntrada.BackColor = System.Drawing.Color.Green;
            this.btnNovaEntrada.ForeColor = System.Drawing.Color.Black;
            this.btnNovaEntrada.Image = ((System.Drawing.Image)(resources.GetObject("btnNovaEntrada.Image")));
            this.btnNovaEntrada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovaEntrada.Location = new System.Drawing.Point(15, 301);
            this.btnNovaEntrada.Name = "btnNovaEntrada";
            this.btnNovaEntrada.Size = new System.Drawing.Size(139, 33);
            this.btnNovaEntrada.TabIndex = 15;
            this.btnNovaEntrada.Text = "Nova Entrada";
            this.btnNovaEntrada.UseVisualStyleBackColor = false;
            this.btnNovaEntrada.Click += new System.EventHandler(this.btnNovaEntrada_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(202, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "R$";
            // 
            // lblVlrTotal
            // 
            this.lblVlrTotal.AutoSize = true;
            this.lblVlrTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVlrTotal.ForeColor = System.Drawing.Color.Green;
            this.lblVlrTotal.Location = new System.Drawing.Point(235, 27);
            this.lblVlrTotal.Name = "lblVlrTotal";
            this.lblVlrTotal.Size = new System.Drawing.Size(32, 16);
            this.lblVlrTotal.TabIndex = 17;
            this.lblVlrTotal.Text = "......";
            // 
            // lbltotals
            // 
            this.lbltotals.AutoSize = true;
            this.lbltotals.Location = new System.Drawing.Point(201, 9);
            this.lbltotals.Name = "lbltotals";
            this.lbltotals.Size = new System.Drawing.Size(106, 13);
            this.lbltotals.TabIndex = 16;
            this.lbltotals.Text = "Valor Total Entradas:";
            // 
            // btnExcluiEntrada
            // 
            this.btnExcluiEntrada.BackColor = System.Drawing.Color.Firebrick;
            this.btnExcluiEntrada.ForeColor = System.Drawing.Color.Black;
            this.btnExcluiEntrada.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluiEntrada.Image")));
            this.btnExcluiEntrada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluiEntrada.Location = new System.Drawing.Point(413, 301);
            this.btnExcluiEntrada.Name = "btnExcluiEntrada";
            this.btnExcluiEntrada.Size = new System.Drawing.Size(76, 33);
            this.btnExcluiEntrada.TabIndex = 20;
            this.btnExcluiEntrada.Text = "Excluir";
            this.btnExcluiEntrada.UseVisualStyleBackColor = false;
            this.btnExcluiEntrada.Click += new System.EventHandler(this.btnExcluiEntrada_Click);
            // 
            // FrmEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 339);
            this.Controls.Add(this.btnExcluiEntrada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblVlrTotal);
            this.Controls.Add(this.lbltotals);
            this.Controls.Add(this.btnNovaEntrada);
            this.Controls.Add(this.lblMesAno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnProximoMes);
            this.Controls.Add(this.dtGridViewEntradas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entradas";
            this.Load += new System.EventHandler(this.FrmEntrada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewEntradas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtGridViewEntradas;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnProximoMes;
        private System.Windows.Forms.Label lblMesAno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNovaEntrada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblVlrTotal;
        private System.Windows.Forms.Label lbltotals;
        private System.Windows.Forms.Button btnExcluiEntrada;
    }
}