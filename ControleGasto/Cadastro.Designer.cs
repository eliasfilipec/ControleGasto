namespace ControleGasto
{
    partial class Cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            this.dTpInicioDivida = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQtdParcelas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbVlrParcela1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbDescricao = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.txbQtd = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txbQtd)).BeginInit();
            this.SuspendLayout();
            // 
            // dTpInicioDivida
            // 
            this.dTpInicioDivida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTpInicioDivida.Location = new System.Drawing.Point(18, 37);
            this.dTpInicioDivida.Name = "dTpInicioDivida";
            this.dTpInicioDivida.Size = new System.Drawing.Size(96, 20);
            this.dTpInicioDivida.TabIndex = 0;
            this.dTpInicioDivida.Value = new System.DateTime(2019, 1, 30, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Inicio:";
            // 
            // lblQtdParcelas
            // 
            this.lblQtdParcelas.AutoSize = true;
            this.lblQtdParcelas.Location = new System.Drawing.Point(130, 21);
            this.lblQtdParcelas.Name = "lblQtdParcelas";
            this.lblQtdParcelas.Size = new System.Drawing.Size(71, 13);
            this.lblQtdParcelas.TabIndex = 2;
            this.lblQtdParcelas.Text = "Qtd Parcelas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor Parcelas:";
            // 
            // txbVlrParcela1
            // 
            this.txbVlrParcela1.Location = new System.Drawing.Point(18, 91);
            this.txbVlrParcela1.Name = "txbVlrParcela1";
            this.txbVlrParcela1.Size = new System.Drawing.Size(219, 20);
            this.txbVlrParcela1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descrição:";
            // 
            // txbDescricao
            // 
            this.txbDescricao.Location = new System.Drawing.Point(18, 149);
            this.txbDescricao.Multiline = true;
            this.txbDescricao.Name = "txbDescricao";
            this.txbDescricao.Size = new System.Drawing.Size(219, 66);
            this.txbDescricao.TabIndex = 7;
            // 
            // btnInserir
            // 
            this.btnInserir.Image = ((System.Drawing.Image)(resources.GetObject("btnInserir.Image")));
            this.btnInserir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInserir.Location = new System.Drawing.Point(133, 221);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(104, 32);
            this.btnInserir.TabIndex = 8;
            this.btnInserir.Text = "Inserir Divida";
            this.btnInserir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // txbQtd
            // 
            this.txbQtd.Location = new System.Drawing.Point(133, 37);
            this.txbQtd.Name = "txbQtd";
            this.txbQtd.Size = new System.Drawing.Size(104, 20);
            this.txbQtd.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(170, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ex: 1.253,58";
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 265);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbQtd);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txbDescricao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbVlrParcela1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblQtdParcelas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dTpInicioDivida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Divida";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txbQtd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dTpInicioDivida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQtdParcelas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbVlrParcela1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbDescricao;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.NumericUpDown txbQtd;
        private System.Windows.Forms.Label label4;
    }
}