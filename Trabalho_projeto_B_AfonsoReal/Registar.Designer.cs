
namespace Trabalho_projeto_B_AfonsoReal
{
    partial class Registar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registar));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_criar_conta = new System.Windows.Forms.Label();
            this.lbl_nao_tem_conta = new System.Windows.Forms.Label();
            this.btn_apagar = new System.Windows.Forms.Button();
            this.btn_registar = new System.Windows.Forms.Button();
            this.chk_mostrar = new System.Windows.Forms.CheckBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_utilizador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_conf_pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Trabalho_projeto_B_AfonsoReal.Properties.Resources.Capturar;
            this.pictureBox1.Location = new System.Drawing.Point(99, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_criar_conta
            // 
            this.lbl_criar_conta.AutoSize = true;
            this.lbl_criar_conta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_criar_conta.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_criar_conta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_criar_conta.Location = new System.Drawing.Point(113, 441);
            this.lbl_criar_conta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_criar_conta.Name = "lbl_criar_conta";
            this.lbl_criar_conta.Size = new System.Drawing.Size(69, 13);
            this.lbl_criar_conta.TabIndex = 63;
            this.lbl_criar_conta.Text = "Voltar Login";
            this.lbl_criar_conta.Click += new System.EventHandler(this.lbl_criar_conta_Click);
            // 
            // lbl_nao_tem_conta
            // 
            this.lbl_nao_tem_conta.AutoSize = true;
            this.lbl_nao_tem_conta.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nao_tem_conta.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_nao_tem_conta.Location = new System.Drawing.Point(99, 416);
            this.lbl_nao_tem_conta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nao_tem_conta.Name = "lbl_nao_tem_conta";
            this.lbl_nao_tem_conta.Size = new System.Drawing.Size(96, 13);
            this.lbl_nao_tem_conta.TabIndex = 62;
            this.lbl_nao_tem_conta.Text = "Já tem uma conta";
            // 
            // btn_apagar
            // 
            this.btn_apagar.BackColor = System.Drawing.Color.Silver;
            this.btn_apagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_apagar.FlatAppearance.BorderSize = 0;
            this.btn_apagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_apagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_apagar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_apagar.Location = new System.Drawing.Point(58, 362);
            this.btn_apagar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_apagar.Name = "btn_apagar";
            this.btn_apagar.Size = new System.Drawing.Size(182, 28);
            this.btn_apagar.TabIndex = 61;
            this.btn_apagar.Text = "APAGAR";
            this.btn_apagar.UseVisualStyleBackColor = false;
            this.btn_apagar.Click += new System.EventHandler(this.btn_apagar_Click);
            // 
            // btn_registar
            // 
            this.btn_registar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_registar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_registar.FlatAppearance.BorderSize = 0;
            this.btn_registar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registar.ForeColor = System.Drawing.Color.White;
            this.btn_registar.Location = new System.Drawing.Point(58, 317);
            this.btn_registar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_registar.Name = "btn_registar";
            this.btn_registar.Size = new System.Drawing.Size(182, 32);
            this.btn_registar.TabIndex = 60;
            this.btn_registar.Text = "REGISTAR";
            this.btn_registar.UseVisualStyleBackColor = false;
            this.btn_registar.Click += new System.EventHandler(this.btn_registar_Click);
            // 
            // chk_mostrar
            // 
            this.chk_mostrar.AutoSize = true;
            this.chk_mostrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_mostrar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_mostrar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.chk_mostrar.Location = new System.Drawing.Point(102, 270);
            this.chk_mostrar.Margin = new System.Windows.Forms.Padding(2);
            this.chk_mostrar.Name = "chk_mostrar";
            this.chk_mostrar.Size = new System.Drawing.Size(139, 17);
            this.chk_mostrar.TabIndex = 59;
            this.chk_mostrar.Text = "Mostrar palavra-chave";
            this.chk_mostrar.UseVisualStyleBackColor = true;
            this.chk_mostrar.CheckedChanged += new System.EventHandler(this.chk_mostrar_CheckedChanged);
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.Color.LightGray;
            this.txt_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(58, 187);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(2);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(182, 22);
            this.txt_pass.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(54, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Password:";
            // 
            // txt_utilizador
            // 
            this.txt_utilizador.BackColor = System.Drawing.Color.LightGray;
            this.txt_utilizador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_utilizador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_utilizador.Location = new System.Drawing.Point(58, 132);
            this.txt_utilizador.Margin = new System.Windows.Forms.Padding(2);
            this.txt_utilizador.Name = "txt_utilizador";
            this.txt_utilizador.Size = new System.Drawing.Size(182, 22);
            this.txt_utilizador.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(55, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Utilizador";
            // 
            // txt_conf_pass
            // 
            this.txt_conf_pass.BackColor = System.Drawing.Color.LightGray;
            this.txt_conf_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_conf_pass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_conf_pass.Location = new System.Drawing.Point(58, 244);
            this.txt_conf_pass.Margin = new System.Windows.Forms.Padding(2);
            this.txt_conf_pass.Name = "txt_conf_pass";
            this.txt_conf_pass.PasswordChar = '*';
            this.txt_conf_pass.Size = new System.Drawing.Size(182, 22);
            this.txt_conf_pass.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(54, 229);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "Confirmar Password:";
            // 
            // Registar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(301, 470);
            this.Controls.Add(this.txt_conf_pass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_criar_conta);
            this.Controls.Add(this.lbl_nao_tem_conta);
            this.Controls.Add(this.btn_apagar);
            this.Controls.Add(this.btn_registar);
            this.Controls.Add(this.chk_mostrar);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_utilizador);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Registar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registar";
            this.Activated += new System.EventHandler(this.Registar_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Registar_FormClosing);
            this.Load += new System.EventHandler(this.Registar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_criar_conta;
        private System.Windows.Forms.Label lbl_nao_tem_conta;
        private System.Windows.Forms.Button btn_apagar;
        private System.Windows.Forms.Button btn_registar;
        private System.Windows.Forms.CheckBox chk_mostrar;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_utilizador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_conf_pass;
        private System.Windows.Forms.Label label1;
    }
}