using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Trabalho_projeto_B_AfonsoReal
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void lbl_criar_conta_Click(object sender, EventArgs e)
        {
            new Registar().Show();
            this.Hide();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            con.Open();
            string login = "SELECT * FROM tbl_users WHERE username='" + txt_utilizador.Text + "' and password= '" + txt_pass.Text + "'";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                new frm_menu().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nome de utilizador ou senha Inválidos, tente novamente", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_utilizador.Text = "";
                txt_pass.Text = "";
                txt_utilizador.Focus();
            }
        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            txt_utilizador.Text = "";
            txt_pass.Text = "";
            txt_utilizador.Focus();
        }

        private void chk_mostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_mostrar.Checked)
            {
                txt_pass.PasswordChar = '\0';
            }
            else
            {
                txt_pass.PasswordChar = '*';
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
