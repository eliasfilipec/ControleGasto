using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleGasto
{
    public partial class CadastroEntrada : Form
    {
        public CadastroEntrada()
        {
            InitializeComponent();
        }

        public Usuario usuario { get; set; }
        conexaoSGBD conexao = new conexaoSGBD();


        private void btnInserirEntrada_Click(object sender, EventArgs e)
        {
            string valor = conexao.ConvNumber(tbValor.Text);
            string descr = tbDescr.Text;
            string dtEnt = dtEntrada.Value.ToString("dd/MM/yyyy");

            if(string.IsNullOrEmpty(valor) || string.IsNullOrEmpty(descr) || string.IsNullOrEmpty(dtEnt))
            {
                MessageBox.Show("Todos os campos são obrigatórios!", "Alerta!");
                return;
            }

            if (conexao.insertEntrada(valor, descr, dtEnt, usuario.id_Usuario))
                MessageBox.Show("Entrada registrada com Sucesso!", "Sucesso!");
            else
                MessageBox.Show("Erro ao registrar a entrada!\nReinicie o software e tente novamente.", "Falha!");

            FrmEntrada fE = new FrmEntrada();
            fE.Focus();
            Dispose();
        }
    }
}
