using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleGasto
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            var conexao = new conexaoSGBD();
            var util = new Utils();

            string login = txbUsuario.Text.ToUpper();
            string senha = txbSenha.Text;
            var inSQL = $"SELECT * FROM TB_LOGIN WHERE USUARIO = '{login}' AND SENHA = '{util.Base64Encode(senha.ToUpper())}'";
            conexao.DataAdapter(inSQL).Fill(dt);

            if(dt.Rows.Count > 0)
            {
                Usuario usuario = new Usuario();
                var list = dt.Rows;
                foreach (var data in list)
                {
                    usuario.id_Usuario = Convert.ToInt32(((System.Data.DataRow)data).ItemArray[0]);
                    usuario.nome_Usuario = ((System.Data.DataRow)data).ItemArray[1].ToString();
                }
                conexao.desconectar();
                frmPrincipal p = new frmPrincipal();
                p.usuario = usuario;
                this.Hide(); 
                p.Closed += (s, args) => this.Close();
                p.Show();
            }
            else
            {
                MessageBox.Show("USUÁRIO/SENHA INVÁLIDO","ALERTA!", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void lblLinkCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CadastroUsuario cadUsu = new CadastroUsuario();
            cadUsu.ShowDialog();
        }
    }
}
