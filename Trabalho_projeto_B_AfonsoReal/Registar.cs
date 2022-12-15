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
    public partial class Registar : Form
    {
        public Registar()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void Registar_Load(object sender, EventArgs e)
        {

        }

        private void btn_registar_Click(object sender, EventArgs e)
        {
            if (txt_utilizador.Text == "" && txt_pass.Text == "" && txt_conf_pass.Text == "")
            {
                MessageBox.Show("Deve digitar o nome de utilizador e a senha!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_pass.Text == txt_conf_pass.Text)
            {
                con.Open();
                string registo = "INSERT INTO tbl_users VALUES ('" + txt_utilizador.Text + "','" + txt_pass.Text + "')";
                cmd = new OleDbCommand(registo, con);
                cmd.ExecuteNonQuery();
                con.Close();

                txt_utilizador.Text = "";
                txt_pass.Text = "";
                txt_conf_pass.Text = "";

                MessageBox.Show("A sua conta foi criada com sucesso!", "Êxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("As palavras-passe não correspondem, por favor reintroduza", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_pass.Text = "";
                txt_conf_pass.Text = "";
                txt_pass.Focus();
            }
        }

        private void chk_mostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_mostrar.Checked)
            {
                txt_pass.PasswordChar = '\0';
                txt_conf_pass.PasswordChar = '\0';
            }
            else
            {
                txt_pass.PasswordChar = '*';
                txt_conf_pass.PasswordChar = '*';
            }
        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            txt_utilizador.Text = "";
            txt_pass.Text = "";
            txt_conf_pass.Text = "";
            txt_utilizador.Focus();
        }

        private void lbl_criar_conta_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void Registar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Registar_Activated(object sender, EventArgs e)
        {
            txt_utilizador.Focus();
        }
    }
}
