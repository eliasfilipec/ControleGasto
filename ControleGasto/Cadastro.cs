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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        public Usuario usuario { get; set; }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            var conexao = new conexaoSGBD();

            int id_Divida = 0;
            string dtInicio = dTpInicioDivida.Value.ToString("dd/MM/yyyy");
            int qtdParcela = Convert.ToInt32(txbQtd.Text);
            string vlrParcela = conexao.ConvNumber(txbVlrParcela1.Text);
            string descricacao = txbDescricao.Text;

            if(string.IsNullOrEmpty(dtInicio) || qtdParcela == 0 || string.IsNullOrEmpty(descricacao))
            {
                MessageBox.Show("Todos os campos são obrigatórios!","Alerta!");
                return;
            }


            if (conexao.inserDivida(dtInicio, qtdParcela, vlrParcela, descricacao, usuario.id_Usuario))
            {
                conexao.DataAdapter("SELECT max(ID) FROM TB_DIVIDAS").Fill(dt);

                var list = dt.Rows;
                foreach (var data in list)
                    id_Divida = Convert.ToInt32(((System.Data.DataRow)data).ItemArray[0]);

                if (id_Divida != 0)
                {
                    int aux = 0;
                    for (int i = 1; i < qtdParcela+1; i++)
                    {
                        var dtvencimento = Convert.ToDateTime(dtInicio).AddMonths(aux).ToString("dd/MM/yyyy");
                        conexao.insertParcela(dtvencimento, i, vlrParcela, id_Divida);
                        aux++;
                    }
                }
            };
            MessageBox.Show("Divida cadastrada com\n Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmPrincipal p = new frmPrincipal();
            p.Focus();
            Dispose();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            dTpInicioDivida.Value = DateTime.Now;
        }
    }
}
