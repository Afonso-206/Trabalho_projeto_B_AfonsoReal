
namespace Trabalho_projeto_B_AfonsoReal
{
    partial class frm_funcionários
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_funcionários));
            this.dgv_dados = new System.Windows.Forms.DataGridView();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_elim = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.txt_nome_func = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_cargo = new System.Windows.Forms.ComboBox();
            this.txt_n_func = new System.Windows.Forms.TextBox();
            this.txt_n_horas_sem = new System.Windows.Forms.TextBox();
            this.txt_valor_hora = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_dados
            // 
            this.dgv_dados.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_dados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_dados.Location = new System.Drawing.Point(43, 192);
            this.dgv_dados.Name = "dgv_dados";
            this.dgv_dados.Size = new System.Drawing.Size(556, 249);
            this.dgv_dados.TabIndex = 0;
            this.dgv_dados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dados_CellClick);
            this.dgv_dados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dados_CellContentClick);
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_adicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adicionar.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btn_adicionar.ForeColor = System.Drawing.Color.White;
            this.btn_adicionar.Location = new System.Drawing.Point(133, 158);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(76, 28);
            this.btn_adicionar.TabIndex = 1;
            this.btn_adicionar.Text = "ADICIONAR";
            this.btn_adicionar.UseVisualStyleBackColor = false;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_alterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alterar.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btn_alterar.ForeColor = System.Drawing.Color.White;
            this.btn_alterar.Location = new System.Drawing.Point(237, 158);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(76, 28);
            this.btn_alterar.TabIndex = 2;
            this.btn_alterar.Text = "ALTERAR";
            this.btn_alterar.UseVisualStyleBackColor = false;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_elim
            // 
            this.btn_elim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_elim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_elim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_elim.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btn_elim.ForeColor = System.Drawing.Color.White;
            this.btn_elim.Location = new System.Drawing.Point(344, 158);
            this.btn_elim.Name = "btn_elim";
            this.btn_elim.Size = new System.Drawing.Size(76, 28);
            this.btn_elim.TabIndex = 3;
            this.btn_elim.Text = "ELIMINAR";
            this.btn_elim.UseVisualStyleBackColor = false;
            this.btn_elim.Click += new System.EventHandler(this.btn_elim_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_limpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btn_limpar.ForeColor = System.Drawing.Color.White;
            this.btn_limpar.Location = new System.Drawing.Point(441, 158);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(76, 28);
            this.btn_limpar.TabIndex = 4;
            this.btn_limpar.Text = "LIMPAR";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // txt_nome_func
            // 
            this.txt_nome_func.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txt_nome_func.Location = new System.Drawing.Point(168, 90);
            this.txt_nome_func.Name = "txt_nome_func";
            this.txt_nome_func.Size = new System.Drawing.Size(100, 22);
            this.txt_nome_func.TabIndex = 6;
            this.txt_nome_func.TextChanged += new System.EventHandler(this.txt_nome_func_TextChanged);
            this.txt_nome_func.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nome_func_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label1.Location = new System.Drawing.Point(40, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nº de Funcionário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label2.Location = new System.Drawing.Point(40, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nome do Funcionário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label3.Location = new System.Drawing.Point(292, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Cargo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label4.Location = new System.Drawing.Point(292, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nº Horas Semanais:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label5.Location = new System.Drawing.Point(529, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Valor de Horas:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cbo_cargo
            // 
            this.cbo_cargo.BackColor = System.Drawing.Color.White;
            this.cbo_cargo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbo_cargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_cargo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cbo_cargo.FormattingEnabled = true;
            this.cbo_cargo.Items.AddRange(new object[] {
            "Chefe",
            "Diretor",
            "Sub-chefe",
            "Técnico"});
            this.cbo_cargo.Location = new System.Drawing.Point(400, 43);
            this.cbo_cargo.Name = "cbo_cargo";
            this.cbo_cargo.Size = new System.Drawing.Size(100, 21);
            this.cbo_cargo.TabIndex = 15;
            // 
            // txt_n_func
            // 
            this.txt_n_func.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txt_n_func.Location = new System.Drawing.Point(168, 37);
            this.txt_n_func.Name = "txt_n_func";
            this.txt_n_func.Size = new System.Drawing.Size(100, 22);
            this.txt_n_func.TabIndex = 16;
            this.txt_n_func.TextChanged += new System.EventHandler(this.txt_n_func_TextChanged);
            this.txt_n_func.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_n_func_KeyPress);
            // 
            // txt_n_horas_sem
            // 
            this.txt_n_horas_sem.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txt_n_horas_sem.Location = new System.Drawing.Point(400, 96);
            this.txt_n_horas_sem.Name = "txt_n_horas_sem";
            this.txt_n_horas_sem.Size = new System.Drawing.Size(100, 22);
            this.txt_n_horas_sem.TabIndex = 17;
            this.txt_n_horas_sem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_n_horas_sem_KeyPress);
            // 
            // txt_valor_hora
            // 
            this.txt_valor_hora.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txt_valor_hora.Location = new System.Drawing.Point(520, 99);
            this.txt_valor_hora.Name = "txt_valor_hora";
            this.txt_valor_hora.Size = new System.Drawing.Size(100, 22);
            this.txt_valor_hora.TabIndex = 18;
            this.txt_valor_hora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_valor_hora_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Trabalho_projeto_B_AfonsoReal.Properties.Resources.Capturarrrr1;
            this.pictureBox1.Location = new System.Drawing.Point(586, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // frm_funcionários
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(652, 453);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_valor_hora);
            this.Controls.Add(this.txt_n_horas_sem);
            this.Controls.Add(this.txt_n_func);
            this.Controls.Add(this.cbo_cargo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nome_func);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_elim);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.dgv_dados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_funcionários";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionários";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_funcionários_FormClosing);
            this.Load += new System.EventHandler(this.frm_funcionários_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_dados;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_elim;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.TextBox txt_nome_func;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_cargo;
        private System.Windows.Forms.TextBox txt_n_func;
        private System.Windows.Forms.TextBox txt_n_horas_sem;
        private System.Windows.Forms.TextBox txt_valor_hora;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}