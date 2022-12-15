
namespace Trabalho_projeto_B_AfonsoReal
{
    partial class frm_consultas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_consultas));
            this.dgv_consultas = new System.Windows.Forms.DataGridView();
            this.btn_consultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consultas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_consultas
            // 
            this.dgv_consultas.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_consultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_consultas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_consultas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_consultas.Location = new System.Drawing.Point(37, 156);
            this.dgv_consultas.Name = "dgv_consultas";
            this.dgv_consultas.Size = new System.Drawing.Size(556, 249);
            this.dgv_consultas.TabIndex = 1;
            this.dgv_consultas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_consultas_CellContentClick);
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(496, 46);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(75, 23);
            this.btn_consultar.TabIndex = 2;
            this.btn_consultar.Text = "button1";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // frm_consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 453);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.dgv_consultas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_consultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTAS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_consultas_FormClosing);
            this.Load += new System.EventHandler(this.frm_consultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consultas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_consultas;
        private System.Windows.Forms.Button btn_consultar;
    }
}