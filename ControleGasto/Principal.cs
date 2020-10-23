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
    public partial class frmPrincipal : Form
    {
        DataTable dt = new DataTable();
        public Usuario usuario { get; set; }
        int proximo = 0;
        int anterior = 0;

        public frmPrincipal()
        {
            InitializeComponent();            
        }

        public void Principal_Load(object sender, EventArgs e)
        {
            rbtDividas.Checked = true;
            proximo = 0;
            anterior = 0;
            lblUsuario.Text = usuario.nome_Usuario;
            lblMesAno.Text = DateTime.Now.ToString("MM/yyyy");
            CarregaGridDividasMes(lblMesAno.Text);
            atualizaSaldo(lblMesAno.Text);
        }

        private void btnInserirNovaDivida_Click(object sender, EventArgs e)
        {
            Cadastro cd = new Cadastro();
            cd.usuario = usuario;
            cd.ShowDialog();
        }

        private void btnProximoMes_Click(object sender, EventArgs e)
        {
            proximo++;
            anterior = proximo;
            lblMesAno.Text = DateTime.Now.AddMonths(proximo).ToString("MM/yyyy");
            CarregaGridDividasMes(lblMesAno.Text);
            atualizaSaldo(lblMesAno.Text);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            conexaoSGBD conexao = new conexaoSGBD();
            List<int> id_parcelas = new List<int>();
            var list = dt.Rows;

            if (rbtDividas.Checked)
            {
                foreach (var data in list)
                {
                    if (((DataRow)data).ItemArray[1].ToString().ToUpper() == "TRUE")
                        id_parcelas.Add(Convert.ToInt32(((System.Data.DataRow)data).ItemArray[0]));
                }
                if(id_parcelas.Count == 0)
                {
                    MessageBox.Show("Nenhuma DIVIDA selecionada!");
                }
                else
                {
                    if (conexao.updateDivida(id_parcelas, true))
                        MessageBox.Show("Selecionados registrados como PAGO!\nEnviado para Pagas.");
                    else
                        MessageBox.Show("Erro ao enviar para PAGAS!\nReinicie o sistema e verifique novamente!");
                }                
            }
            else if (rbtPagas.Checked)
            {
                foreach (var data in list)
                {
                    if (((DataRow)data).ItemArray[1].ToString().ToUpper() == "FALSE")
                        id_parcelas.Add(Convert.ToInt32(((System.Data.DataRow)data).ItemArray[0]));
                }
                if (id_parcelas.Count == 0)
                {
                    MessageBox.Show("Nenhuma PAGA selecionada!");
                }
                else
                {
                    if (conexao.updateDivida(id_parcelas, false))
                        MessageBox.Show("Dividas PAGAS selecionadas foram enviadas novamente para Dividas.");
                    else
                        MessageBox.Show("Erro ao enviar para Dividas!\nReinicie o sistema e verifique novamente!");
                }
            }
        }

        public void atualizaSaldo(string mesAno)
        {
            string inSQL = string.Empty;
            DataTable dtlblSaldo = new DataTable();
            conexaoSGBD conexao = new conexaoSGBD();

            inSQL = "select case when sum(round(saldo.V_Saldo,2) - round(divida.V_Divida,2)) is null then 'R$ 0.00'" +
                " when sum(round(saldo.V_Saldo,2) -round(divida.V_Divida, 2)) > 0" +
                " then 'R$ ' || sum(round(saldo.V_Saldo, 2) - round(divida.V_Divida, 2))" +
                " when sum(round(saldo.V_Saldo,2) -round(divida.V_Divida, 2)) <= 0" +
                " then 'R$ ' || sum(round(saldo.V_Saldo, 2) - round(divida.V_Divida, 2)) " +
                "end as 'Saldo' from(select case when sum(tev.VALOR_ENTRADA) is null " +
                "then 0 else sum(tev.VALOR_ENTRADA) end as V_Saldo from TB_ENTRADA_VALORES tev " +
                $"where tev.DATA_ENTRADA like '%{mesAno}' " +
                $"and tev.ID_LOGIN = {usuario.id_Usuario}) as saldo,(select case when sum(tp.VALORPARCELA) is null" +
                " then 0 else sum(tp.VALORPARCELA) " +
                "end as V_Divida from TB_PARCELAS tp, TB_DIVIDAS td " +
                $"where tp.datavenc like '%{mesAno}' " +
                "and td.ID = tp.ID_DIVIDA " +
                "and tp.STATUS_PAGO = 1 " +
                $"and td.ID_LOGIN = {usuario.id_Usuario}) as divida";

            conexao.DataAdapter(inSQL).Fill(dtlblSaldo);

            var list = dtlblSaldo.Rows;
            foreach (var valor in list)
                lblSaltoPagas.Text = Convert.ToString(((System.Data.DataRow)valor).ItemArray[0]);
            if (lblSaltoPagas.Text.Contains("-"))
                lblSaltoPagas.ForeColor = Color.Red;
            else
                lblSaltoPagas.ForeColor = Color.Green;

            dtlblSaldo.Clear();
            dtlblSaldo = new DataTable();
            inSQL = "select case when round(sum(tev.valor_Entrada),2) is null then 'R$ 0.00' else 'R$ ' ||" +
                " round(sum(tev.valor_Entrada),2) end as 'Total Entrada' " +
                "from TB_ENTRADA_VALORES tev" +
                $" where tev.DATA_ENTRADA like '%{mesAno}' " +
                $"and tev.ID_LOGIN = {usuario.id_Usuario}";

            conexao.DataAdapter(inSQL).Fill(dtlblSaldo);
            
            list = dtlblSaldo.Rows;
            foreach (var valor in list)
            {
                lblSaldoTotal.Text = Convert.ToString(((System.Data.DataRow)valor).ItemArray[0]);
            }
            if (lblSaldoTotal.Text.Contains("0.00"))
                lblSaldoTotal.ForeColor = Color.Silver;
            else
                lblSaldoTotal.ForeColor = Color.Blue;
        }

        public void CarregaGridDividasMes(string mesAno)
        {
            string inSQL = string.Empty;
            dt.Clear();
            dtGridViewDividas.DataSource = dt.DefaultView;
            conexaoSGBD conexao = new conexaoSGBD();

            if (rbtDividas.Checked)
            {
                inSQL = "select tp.ID," +
                    " tp.STATUS_PAGO as Pagar," +
                    " tp.DATAVENC as 'Dt. Venc.'," +
                    " td.DESCRICAO as 'Descrição'," +
                    " tp.NRPARCELA || '/' || td.QTDPARCELA as 'Parcela de' ," +
                    " tp.VALORPARCELA as Valor from TB_PARCELAS tp," +
                    " TB_DIVIDAS td " +
                    $"where tp.DATAVENC like '%{mesAno}'" +
                    " and td.ID = tp.ID_DIVIDA " +
                    "and tp.STATUS_PAGO <> 1 " +
                    $"and td.ID_LOGIN = {usuario.id_Usuario}";
            }
            else if (rbtPagas.Checked)
            {
                inSQL = "select tp.ID, tp.STATUS_PAGO as Pagar," +
                        " tp.DATAVENC as 'Dt. Venc.'," +
                        " td.DESCRICAO as 'Descrição'," +
                        " tp.NRPARCELA || '/' || td.QTDPARCELA as 'Parcela de' ," +
                        " tp.VALORPARCELA as Valor" +
                        " from TB_PARCELAS tp, TB_DIVIDAS td " +
                        $"where tp.DATAVENC like '%{mesAno}' and td.ID = tp.ID_DIVIDA and tp.STATUS_PAGO <> 0 " +
                        $"and td.ID_LOGIN = {usuario.id_Usuario}";
            }

            conexao.DataAdapter(inSQL).Fill(dt);
            var list = dt.Rows;
            decimal somatotal = 0;
            decimal aux;
            foreach (var valor in list)
            {
                aux = Convert.ToDecimal(((System.Data.DataRow)valor).ItemArray[5]);
                somatotal += aux;
            }
            lblVlrTotal.Text = somatotal.ToString();

            dtGridViewDividas.DataSource = dt.DefaultView;
            dtGridViewDividas.Columns[0].Visible = false;
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            anterior--;
            proximo = anterior;
            lblMesAno.Text = DateTime.Now.AddMonths(anterior).ToString("MM/yyyy");
            CarregaGridDividasMes(lblMesAno.Text);
            atualizaSaldo(lblMesAno.Text);
        }

        private void rbtDividas_CheckedChanged(object sender, EventArgs e)
        {
            btnExlcuirDivida.Visible = true;
            btnInserirNovaDivida.Visible = true;
            lbltotals.Text = "Valor Total Dividas:";
            btnInsert.Text = "Enviar Pagos";
            btnInsert.BackColor = Color.Green;
            label3.ForeColor = Color.Red;
            lblVlrTotal.ForeColor = Color.Red;
            CarregaGridDividasMes(lblMesAno.Text);
        }

        private void rbtPagas_CheckedChanged(object sender, EventArgs e)
        {
            btnExlcuirDivida.Visible = false;
            btnInserirNovaDivida.Visible = false;
            lbltotals.Text = "Valor Total Pagas:";
            label3.ForeColor = Color.Green;
            lblVlrTotal.ForeColor = Color.Green;
            btnInsert.Text = "Voltar Divida";
            btnInsert.BackColor = Color.LightSalmon;
            CarregaGridDividasMes(lblMesAno.Text);
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            FrmEntrada entrada = new FrmEntrada();
            entrada.usuario = usuario;
            entrada.ShowDialog();
        }

        private void btnExlcuirDivida_Click(object sender, EventArgs e)
        {
            conexaoSGBD conexao = new conexaoSGBD();
            List<int> id_parcelas = new List<int>();
            var list = dt.Rows;

            foreach (var data in list)
            {
                if (((DataRow)data).ItemArray[1].ToString().ToUpper() == "TRUE")
                    id_parcelas.Add(Convert.ToInt32(((System.Data.DataRow)data).ItemArray[0]));
            }           

            if (id_parcelas.Count == 0)
            {
                MessageBox.Show("Nenhuma DIVIDA selecionada!");
                return;
            }
            else
            {
                if (MessageBox.Show("Você deseja realmente DELETAR os itens selecionados?", "", MessageBoxButtons.YesNoCancel) == DialogResult.No)
                    return;
                if (conexao.excluirDivida(id_parcelas))
                {
                    MessageBox.Show("Selecionados DELETADOS como Sucesso!" +
                        "\nTodavia se existem parcelas PAGAS na seleção não serão deletadas" +
                        "\naté retornar as mesmas para DIVIDAS novamente!");
                    CarregaGridDividasMes(lblMesAno.Text);
                    return;
                }
            }
        }
    }
}
