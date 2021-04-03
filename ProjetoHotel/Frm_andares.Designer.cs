namespace ProjetoHotel
{
    partial class Frm_andares
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_andares));
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.txt_andar = new System.Windows.Forms.TextBox();
            this.lbl_andar = new System.Windows.Forms.Label();
            this.dgv_andares = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_andares)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.BackColor = System.Drawing.Color.Transparent;
            this.btn_adicionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_adicionar.BackgroundImage")));
            this.btn_adicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_adicionar.FlatAppearance.BorderSize = 0;
            this.btn_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adicionar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_adicionar.Location = new System.Drawing.Point(174, 496);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(70, 75);
            this.btn_adicionar.TabIndex = 61;
            this.btn_adicionar.UseVisualStyleBackColor = false;
            // 
            // btn_sair
            // 
            this.btn_sair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sair.BackgroundImage")));
            this.btn_sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sair.FlatAppearance.BorderSize = 0;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btn_sair.Location = new System.Drawing.Point(541, 500);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(78, 71);
            this.btn_sair.TabIndex = 60;
            this.btn_sair.UseVisualStyleBackColor = true;
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_salvar.BackgroundImage")));
            this.btn_salvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_salvar.FlatAppearance.BorderSize = 0;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Location = new System.Drawing.Point(412, 500);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 71);
            this.btn_salvar.TabIndex = 59;
            this.btn_salvar.UseVisualStyleBackColor = true;
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.Transparent;
            this.btn_editar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_editar.BackgroundImage")));
            this.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_editar.FlatAppearance.BorderSize = 0;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_editar.Location = new System.Drawing.Point(289, 498);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(75, 71);
            this.btn_editar.TabIndex = 58;
            this.btn_editar.UseVisualStyleBackColor = false;
            // 
            // txt_andar
            // 
            this.txt_andar.Location = new System.Drawing.Point(289, 123);
            this.txt_andar.Name = "txt_andar";
            this.txt_andar.Size = new System.Drawing.Size(178, 22);
            this.txt_andar.TabIndex = 54;
            // 
            // lbl_andar
            // 
            this.lbl_andar.AutoSize = true;
            this.lbl_andar.Location = new System.Drawing.Point(216, 126);
            this.lbl_andar.Name = "lbl_andar";
            this.lbl_andar.Size = new System.Drawing.Size(54, 17);
            this.lbl_andar.TabIndex = 53;
            this.lbl_andar.Text = "Andar: ";
            // 
            // dgv_andares
            // 
            this.dgv_andares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_andares.Location = new System.Drawing.Point(59, 230);
            this.dgv_andares.Name = "dgv_andares";
            this.dgv_andares.RowHeadersWidth = 51;
            this.dgv_andares.RowTemplate.Height = 24;
            this.dgv_andares.Size = new System.Drawing.Size(654, 229);
            this.dgv_andares.TabIndex = 52;
            // 
            // Frm_andares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 609);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.txt_andar);
            this.Controls.Add(this.lbl_andar);
            this.Controls.Add(this.dgv_andares);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_andares";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Andares";
            this.Load += new System.EventHandler(this.Frm_andares_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_andares)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_editar;
        public System.Windows.Forms.TextBox txt_andar;
        private System.Windows.Forms.Label lbl_andar;
        private System.Windows.Forms.DataGridView dgv_andares;
    }
}