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
    public partial class frm_consulta_salarios : Form
    {
        public frm_consulta_salarios()
        {
            InitializeComponent();
        }

        string nFunc, nome, cargo, nhoras,valor;

        private void lbl_total_valor_hora_Click(object sender, EventArgs e)
        {

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            XmlTextReader ler = new XmlTextReader("funcionários.xml");
            while (ler.Read())
            {

                if (ler.NodeType == XmlNodeType.Element)
                {
                    if (ler.Name == "Nfuncionario")
                    {
                        ler.Read();
                        nFunc = ler.Value;

                    }
                    if (ler.Name == "nome")
                    {
                        ler.Read();
                        nome = ler.Value;

                    }
                    if (ler.Name == "cargo")
                    {
                        ler.Read();
                        cargo = ler.Value;
                    }
                    if (ler.Name == "NhorasSem")
                    {
                        ler.Read();
                        nhoras = ler.Value;
                    }
                    if (ler.Name == "ValorHoras")
                    {
                        ler.Read();
                        valor2 = int.Parse(ler.Value);

                        soma_horas = soma_horas + int.Parse(nhoras);
                        lbl_total_horas.Text = soma_horas.ToString();

                        soma_valor = soma_valor + valor2;
                        lbl_total_valor_hora.Text = soma_valor.ToString();

                        soma_salarios = soma_salarios + (int.Parse(nhoras)*valor2);
                        lbl_total_salarios.Text = soma_salarios.ToString();
                    }
                }
            }
            ler.Close();

        }

        int valor2,salarios,soma_horas=0,soma_valor=0,soma_salarios=0;


        private void frm_consulta_salarios_Load(object sender, EventArgs e)
        {
            dgv_salarios.Rows.Clear();
            
            XmlTextReader ler = new XmlTextReader("funcionários.xml");
            while (ler.Read())
            {

                if (ler.NodeType == XmlNodeType.Element)
                {
                    if (ler.Name == "Nfuncionario")
                    {
                        ler.Read();
                        nFunc = ler.Value;

                    }
                    if (ler.Name == "nome")
                    {
                        ler.Read();
                        nome = ler.Value;

                    }
                    if (ler.Name == "cargo")
                    {
                        ler.Read();
                        cargo = ler.Value;
                    }
                    if (ler.Name == "NhorasSem")
                    {
                        ler.Read();
                        nhoras = ler.Value;
                    }
                    if (ler.Name == "ValorHoras")
                    {
                        ler.Read();
                        valor = ler.Value;

                        salarios = int.Parse(valor) * int.Parse(nhoras);
                        if(nome!="0")
                        {
                            dgv_salarios.Rows.Add(nome, nhoras, valor, salarios);
                        }
                        
                    }
                }
            }
            ler.Close();
        }
    }
}
