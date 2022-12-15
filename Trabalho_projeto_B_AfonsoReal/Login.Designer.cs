
namespace Trabalho_projeto_B_AfonsoReal
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lbl_criar_conta = new System.Windows.Forms.Label();
            this.lbl_nao_tem_conta = new System.Windows.Forms.Label();
            this.btn_apagar = new System.Windows.Forms.Button();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.chk_mostrar = new System.Windows.Forms.CheckBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_utilizador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_criar_conta
            // 
            this.lbl_criar_conta.AutoSize = true;
            this.lbl_criar_conta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_criar_conta.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_criar_conta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_criar_conta.Location = new System.Drawing.Point(118, 432);
            this.lbl_criar_conta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_criar_conta.Name = "lbl_criar_conta";
            this.lbl_criar_conta.Size = new System.Drawing.Size(65, 13);
            this.lbl_criar_conta.TabIndex = 53;
            this.lbl_criar_conta.Text = "Criar Conta";
            this.lbl_criar_conta.Click += new System.EventHandler(this.lbl_criar_conta_Click);
            // 
            // lbl_nao_tem_conta
            // 
            this.lbl_nao_tem_conta.AutoSize = true;
            this.lbl_nao_tem_conta.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nao_tem_conta.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_nao_tem_conta.Location = new System.Drawing.Point(93, 409);
            this.lbl_nao_tem_conta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nao_tem_conta.Name = "lbl_nao_tem_conta";
            this.lbl_nao_tem_conta.Size = new System.Drawing.Size(114, 13);
            this.lbl_nao_tem_conta.TabIndex = 52;
            this.lbl_nao_tem_conta.Text = "Ainda não tem conta";
            // 
            // btn_apagar
            // 
            this.btn_apagar.BackColor = System.Drawing.Color.Silver;
            this.btn_apagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_apagar.FlatAppearance.BorderSize = 0;
            this.btn_apagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_apagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_apagar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_apagar.Location = new System.Drawing.Point(59, 337);
            this.btn_apagar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_apagar.Name = "btn_apagar";
            this.btn_apagar.Size = new System.Drawing.Size(182, 28);
            this.btn_apagar.TabIndex = 51;
            this.btn_apagar.Text = "APAGAR";
            this.btn_apagar.UseVisualStyleBackColor = false;
            this.btn_apagar.Click += new System.EventHandler(this.btn_apagar_Click);
            // 
            // btn_entrar
            // 
            this.btn_entrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_entrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_entrar.FlatAppearance.BorderSize = 0;
            this.btn_entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_entrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entrar.ForeColor = System.Drawing.Color.White;
            this.btn_entrar.Location = new System.Drawing.Point(59, 292);
            this.btn_entrar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(182, 32);
            this.btn_entrar.TabIndex = 50;
            this.btn_entrar.Text = "ENTRAR";
            this.btn_entrar.UseVisualStyleBackColor = false;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // chk_mostrar
            // 
            this.chk_mostrar.AutoSize = true;
            this.chk_mostrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_mostrar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_mostrar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.chk_mostrar.Location = new System.Drawing.Point(108, 227);
            this.chk_mostrar.Margin = new System.Windows.Forms.Padding(2);
            this.chk_mostrar.Name = "chk_mostrar";
            this.chk_mostrar.Size = new System.Drawing.Size(139, 17);
            this.chk_mostrar.TabIndex = 49;
            this.chk_mostrar.Text = "Mostrar palavra-chave";
            this.chk_mostrar.UseVisualStyleBackColor = true;
            this.chk_mostrar.CheckedChanged += new System.EventHandler(this.chk_mostrar_CheckedChanged);
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.Color.LightGray;
            this.txt_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(59, 199);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(2);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(182, 22);
            this.txt_pass.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(55, 184);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Password:";
            // 
            // txt_utilizador
            // 
            this.txt_utilizador.BackColor = System.Drawing.Color.LightGray;
            this.txt_utilizador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_utilizador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_utilizador.Location = new System.Drawing.Point(59, 134);
            this.txt_utilizador.Margin = new System.Windows.Forms.Padding(2);
            this.txt_utilizador.Name = "txt_utilizador";
            this.txt_utilizador.Size = new System.Drawing.Size(182, 22);
            this.txt_utilizador.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(55, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Utilizador";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Trabalho_projeto_B_AfonsoReal.Properties.Resources.Capturar;
            this.pictureBox1.Location = new System.Drawing.Point(101, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(301, 470);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_criar_conta);
            this.Controls.Add(this.lbl_nao_tem_conta);
            this.Controls.Add(this.btn_apagar);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.chk_mostrar);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_utilizador);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Real Company";
           
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_criar_conta;
        private System.Windows.Forms.Label lbl_nao_tem_conta;
        private System.Windows.Forms.Button btn_apagar;
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.CheckBox chk_mostrar;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_utilizador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

