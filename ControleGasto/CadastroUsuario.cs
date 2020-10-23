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
    public partial class CadastroUsuario : Form
    {
        public CadastroUsuario()
        {
            InitializeComponent();
        }

        Utils util = new Utils();
        conexaoSGBD con = new conexaoSGBD();

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbUsuario.Text) ||
                string.IsNullOrEmpty(tbUsuario.Text) ||
                string.IsNullOrEmpty(tbUsuario.Text))
            {
                MessageBox.Show("Todos os campos são obrigatórios!");
                return;
            }

            if(tbSenha.Text != tbConfirmaSenha.Text)
            {
                MessageBox.Show("Senhas não conferem!");
                return;
            }

            if(con.insertUsuario(tbUsuario.Text.ToUpper(), util.Base64Encode(tbSenha.Text.ToUpper())))
            {
                MessageBox.Show("Usuario cadastrado com\n Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Login login = new Login();
                login.Focus();
                Dispose();
            }
        }
    }
}
