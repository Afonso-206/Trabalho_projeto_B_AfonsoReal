using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_projeto_B_AfonsoReal
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        private void btn_autor_Click(object sender, EventArgs e)
        {
            new frm_autor().Show();
            this.Hide();
        }

        private void frm_menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja Sair?","SAIR",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                MessageBox.Show("Obrigado por usufruir da nossa aplicação!", "SAIR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        private void btn_funcionarios_Click(object sender, EventArgs e)
        {
            new frm_funcionários().Show();
            this.Hide();
        }

        private void btn_consultas_Click(object sender, EventArgs e)
        {
            new frm_consultas().Show();
            this.Hide();
        }

        private void btn_consulta_Salários_Click(object sender, EventArgs e)
        {
            new frm_consulta_salarios().Show();
            this.Hide();
        }

        private void btn_consulta_cargo_Click(object sender, EventArgs e)
        {
            new frm_consulta_cargo().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void frm_menu_Load(object sender, EventArgs e)
        {
            
        }
    }
}
