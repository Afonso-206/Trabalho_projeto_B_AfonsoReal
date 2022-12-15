
namespace Trabalho_projeto_B_AfonsoReal
{
    partial class frm_consulta_salarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_consulta_salarios));
            this.dgv_salarios = new System.Windows.Forms.DataGridView();
            this.nome_func = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nhoras_trab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_total_horas = new System.Windows.Forms.Label();
            this.lbl_total_valor_hora = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_total_salarios = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_salarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_salarios
            // 
            this.dgv_salarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_salarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome_func,
            this.Nhoras_trab,
            this.valor_hora,
            this.Salario});
            this.dgv_salarios.Location = new System.Drawing.Point(130, 35);
            this.dgv_salarios.Name = "dgv_salarios";
            this.dgv_salarios.Size = new System.Drawing.Size(446, 150);
            this.dgv_salarios.TabIndex = 0;
            // 
            // nome_func
            // 
            this.nome_func.HeaderText = "Nome";
            this.nome_func.Name = "nome_func";
            // 
            // Nhoras_trab
            // 
            this.Nhoras_trab.HeaderText = "Nº Horas";
            this.Nhoras_trab.Name = "Nhoras_trab";
            // 
            // valor_hora
            // 
            this.valor_hora.HeaderText = "Valor Hora";
            this.valor_hora.Name = "valor_hora";
            // 
            // Salario
            // 
            this.Salario.HeaderText = "Salário";
            this.Salario.Name = "Salario";
            // 
            // btn_calcular
            // 
            this.btn_calcular.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btn_calcular.Location = new System.Drawing.Point(307, 191);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_calcular.TabIndex = 4;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Soma Total Horas:";
            // 
            // lbl_total_horas
            // 
            this.lbl_total_horas.Location = new System.Drawing.Point(115, 266);
            this.lbl_total_horas.Name = "lbl_total_horas";
            this.lbl_total_horas.Size = new System.Drawing.Size(84, 13);
            this.lbl_total_horas.TabIndex = 6;
            // 
            // lbl_total_valor_hora
            // 
            this.lbl_total_valor_hora.Location = new System.Drawing.Point(343, 266);
            this.lbl_total_valor_hora.Name = "lbl_total_valor_hora";
            this.lbl_total_valor_hora.Size = new System.Drawing.Size(82, 13);
            this.lbl_total_valor_hora.TabIndex = 8;
            this.lbl_total_valor_hora.Click += new System.EventHandler(this.lbl_total_valor_hora_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Soma Total valor por hora:";
            // 
            // lbl_total_salarios
            // 
            this.lbl_total_salarios.Location = new System.Drawing.Point(570, 266);
            this.lbl_total_salarios.Name = "lbl_total_salarios";
            this.lbl_total_salarios.Size = new System.Drawing.Size(89, 13);
            this.lbl_total_salarios.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(447, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Soma Total de salarios:";
            // 
            // frm_consulta_salarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 303);
            this.Controls.Add(this.lbl_total_salarios);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_total_valor_hora);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_total_horas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.dgv_salarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_consulta_salarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTA SALÁRIOS";
            this.Load += new System.EventHandler(this.frm_consulta_salarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_salarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_salarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_func;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nhoras_trab;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salario;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_total_horas;
        private System.Windows.Forms.Label lbl_total_valor_hora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_total_salarios;
        private System.Windows.Forms.Label label5;
    }
}