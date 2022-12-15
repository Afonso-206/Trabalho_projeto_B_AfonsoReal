using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Trabalho_projeto_B_AfonsoReal
{
    public partial class frm_consultas : Form
    {
        public frm_consultas()
        {
            InitializeComponent();
        }

        private void frm_consultas_FormClosing(object sender, FormClosingEventArgs e)
        {
            new frm_menu().Show();
            this.Hide();
        }

        private void frm_consultas_Load(object sender, EventArgs e)
        {
            CarregaDadosXML();
            dgv_consultas.Columns[0].HeaderText = "Nº Funcionário";
            dgv_consultas.Columns[1].HeaderText = "Nome";
            dgv_consultas.Columns[2].HeaderText = "Cargo";
            dgv_consultas.Columns[3].HeaderText = "Nº Horas Semanais";
            dgv_consultas.Columns[4].HeaderText = "Valor Horas";
        }

        public void CarregaDadosXML()
        {
            DataSet ds = new DataSet();
            ds.ReadXml("funcionários.xml");
            dgv_consultas.DataSource = ds;
            dgv_consultas.DataMember = "funcionario";
            dgv_consultas.Rows.RemoveAt(0);
        }

        private void dgv_consultas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            

        }
    }
}
