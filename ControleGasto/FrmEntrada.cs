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
    public partial class FrmEntrada : Form
    {
        public FrmEntrada()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        public Usuario usuario { get; set; }
        int proximo = 0;
        int anterior = 0;

        private void btnNovaEntrada_Click(object sender, EventArgs e)
        {
            CadastroEntrada cdE = new CadastroEntrada();
            cdE.usuario = usuario;
            cdE.ShowDialog();
            CarregaGridEntradasMes(lblMesAno.Text);
        }

        private void FrmEntrada_Load(object sender, EventArgs e)
        {
            proximo = 0;
            anterior = 0;
            lblMesAno.Text = DateTime.Now.ToString("MM/yyyy");
            CarregaGridEntradasMes(lblMesAno.Text);
        }

        public void CarregaGridEntradasMes(string mesAno)
        {
            string inSQL = string.Empty;
            dt.Clear();
            dtGridViewEntradas.DataSource = dt.DefaultView;
            conexaoSGBD conexao = new conexaoSGBD();

            inSQL = "select tev.ID, tev.STATUS_ENTRADA as 'Selecionar'," +
                " tev.VALOR_ENTRADA as 'Valor Entrada'," +
                " tev.DESCRICAO_ENTRADA as 'Descrição'," +
                " tev.DATA_ENTRADA as 'Dt. Entrada'" +
                " from tb_entrada_valores tev " +
                $"where tev.DATA_ENTRADA like '%{mesAno}' " +
                $"and tev.ID_LOGIN = {usuario.id_Usuario}";

            conexao.DataAdapter(inSQL).Fill(dt);
            var list = dt.Rows;
            decimal somatotal = 0;
            decimal aux;
            foreach (var valor in list)
            {
                aux = Convert.ToDecimal(((System.Data.DataRow)valor).ItemArray[2]);
                somatotal += aux;
            }
            lblVlrTotal.Text = somatotal.ToString();

            dtGridViewEntradas.DataSource = dt.DefaultView;
            dtGridViewEntradas.Columns[0].Visible = false;
        }

        private void btnProximoMes_Click(object sender, EventArgs e)
        {
            proximo++;
            anterior = proximo;
            lblMesAno.Text = DateTime.Now.AddMonths(proximo).ToString("MM/yyyy");
            CarregaGridEntradasMes(lblMesAno.Text);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            anterior--;
            proximo = anterior;
            lblMesAno.Text = DateTime.Now.AddMonths(anterior).ToString("MM/yyyy");
            CarregaGridEntradasMes(lblMesAno.Text);
        }

        private void btnExcluiEntrada_Click(object sender, EventArgs e)
        {
            conexaoSGBD conexao = new conexaoSGBD();
            List<int> id_Entrada = new List<int>();
            var list = dt.Rows;

            foreach (var data in list)
            {
                if (((DataRow)data).ItemArray[1].ToString().ToUpper() == "TRUE")
                    id_Entrada.Add(Convert.ToInt32(((System.Data.DataRow)data).ItemArray[0]));
            }
            if (id_Entrada.Count == 0)
            {
                MessageBox.Show("Nenhuma DIVIDA selecionada!");
            }
            else
            {
                if (conexao.excluirEntrada(id_Entrada))
                    MessageBox.Show("Selecionados registrados Excluidos!");
                else
                    MessageBox.Show("Erro ao EXCLUIR!");
            }
            CarregaGridEntradasMes(lblMesAno.Text);
            return;
        }
    }
}