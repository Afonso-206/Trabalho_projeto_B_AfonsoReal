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
    public partial class frm_funcionários : Form
    {
        public frm_funcionários()
        {
            InitializeComponent();
        }

        private void frm_funcionários_FormClosing(object sender, FormClosingEventArgs e)
        {
            new frm_menu().Show();
            this.Hide();
        }

        int indice;
        private void dgv_dados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = dgv_dados.CurrentRow.Index+1;

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("funcionários.xml");

            XmlNodeList xmlnodelist = xmlDoc.DocumentElement.ChildNodes;
            XmlNode xmlnode = xmlnodelist.Item(indice);

            txt_n_func.Text = xmlnode["Nfuncionario"].InnerText;
            txt_nome_func.Text = xmlnode["nome"].InnerText;
            cbo_cargo.Text = xmlnode["cargo"].InnerText;
            txt_n_horas_sem.Text = xmlnode["NhorasSem"].InnerText;
            txt_valor_hora.Text = xmlnode["ValorHoras"].InnerText;
        }

        private void frm_funcionários_Load(object sender, EventArgs e)
        {
            CarregaDadosXML();
            dgv_dados.Columns[0].HeaderText = "Nº Funcionário";
            dgv_dados.Columns[1].HeaderText = "Nome";
            dgv_dados.Columns[2].HeaderText = "Cargo";
            dgv_dados.Columns[3].HeaderText = "Nº Horas Semanais";
            dgv_dados.Columns[4].HeaderText = "Valor Horas";
        }
        public void CarregaDadosXML()
        {
            DataSet ds = new DataSet();
            ds.ReadXml("funcionários.xml");
            dgv_dados.DataSource = ds;
            dgv_dados.DataMember = "funcionario";
            dgv_dados.Rows.RemoveAt(0);
        }
        public static void AllowNumber(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) ||char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_n_func_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_n_func_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowNumber(e);
        }

        private void txt_n_horas_sem_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowNumber(e);
        }

        private void txt_valor_hora_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowNumber(e);
        }

        public static void AllowLetter(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_nome_func_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_nome_func_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowLetter(e);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if (txt_n_func.Text=="")
            {
                MessageBox.Show("Deve digitar o nº do funcionário!");
                txt_n_func.Focus();
            }
            else if (txt_nome_func.Text == "")
            {
                MessageBox.Show("Deve digitar o nome do funcionário!");
                txt_nome_func.Focus();
            }
            else if (string.IsNullOrEmpty(cbo_cargo.Text) || (System.Text.RegularExpressions.Regex.IsMatch(cbo_cargo.Text, "[^a-zA-Z]+$")))
            {
                MessageBox.Show("Deve escolher o cargo");
            }
            else if (txt_n_horas_sem.Text == "")
            {
                MessageBox.Show("Deve digitar o nº de horas semanais!");
                txt_n_horas_sem.Focus();
            }
            else if (txt_valor_hora.Text == "")
            {
                MessageBox.Show("Deve digitar o valor por hora!");
                txt_valor_hora.Focus();
            }
            else
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("funcionários.xml");

                XmlElement func = xmlDoc.CreateElement("funcionario");
                XmlElement Nfunc = xmlDoc.CreateElement("Nfuncionario");
                XmlElement Nome = xmlDoc.CreateElement("nome");
                XmlElement Cargo = xmlDoc.CreateElement("cargo");
                XmlElement NhorasS = xmlDoc.CreateElement("NhorasSem");
                XmlElement ValorH = xmlDoc.CreateElement("ValorHoras");

                Nfunc.InnerText = txt_n_func.Text;
                Nome.InnerText = txt_nome_func.Text;
                Cargo.InnerText = cbo_cargo.Text;
                NhorasS.InnerText = txt_n_horas_sem.Text;
                ValorH.InnerText = txt_valor_hora.Text;

                func.AppendChild(Nfunc);
                func.AppendChild(Nome);
                func.AppendChild(Cargo);
                func.AppendChild(NhorasS);
                func.AppendChild(ValorH);

                xmlDoc.DocumentElement.AppendChild(func);

                xmlDoc.Save("funcionários.xml");

                CarregaDadosXML();

                limpar();
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            limpar();
        }
        public void limpar()
        {
            txt_n_func.ResetText();
            txt_nome_func.ResetText();
            cbo_cargo.SelectedIndex=-1; 
            txt_n_horas_sem.ResetText();
            txt_valor_hora.ResetText();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("funcionários.xml");

            XmlNode xmlnode = xmlDoc.DocumentElement.ChildNodes.Item(indice);
            xmlnode["Nfuncionario"].InnerText = txt_n_func.Text;
            xmlnode["nome"].InnerText = txt_nome_func.Text;
            xmlnode["cargo"].InnerText = cbo_cargo.Text;
            xmlnode["NhorasSem"].InnerText = txt_n_horas_sem.Text;
            xmlnode["ValorHoras"].InnerText = txt_valor_hora.Text;

            xmlDoc.Save("funcionários.xml");
            CarregaDadosXML();
        }

        private void btn_elim_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma a Eliminação do Funcionário(a) " + txt_nome_func.Text + "?", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("funcionários.xml");

                XmlNode xmlnode = xmlDoc.DocumentElement.ChildNodes.Item(indice);
                xmlnode.ParentNode.RemoveChild(xmlnode);

                xmlDoc.Save("funcionários.xml");

                CarregaDadosXML();

                limpar();
            }
        }

        private void dgv_dados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
