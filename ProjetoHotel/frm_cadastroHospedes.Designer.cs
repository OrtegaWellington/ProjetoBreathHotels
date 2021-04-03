namespace ProjetoHotel
{
    partial class frm_cadastroHospedes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cadastroHospedes));
            this.lbl_endereco = new System.Windows.Forms.Label();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.msk_cpf = new System.Windows.Forms.MaskedTextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.msk_telefone = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_pesquisar = new System.Windows.Forms.Label();
            this.txt_pesquisar = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_duvidas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_endereco
            // 
            this.lbl_endereco.AutoSize = true;
            this.lbl_endereco.Location = new System.Drawing.Point(47, 185);
            this.lbl_endereco.Name = "lbl_endereco";
            this.lbl_endereco.Size = new System.Drawing.Size(73, 17);
            this.lbl_endereco.TabIndex = 0;
            this.lbl_endereco.Text = "Endereço:";
            this.lbl_endereco.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Location = new System.Drawing.Point(556, 94);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(68, 17);
            this.lbl_telefone.TabIndex = 1;
            this.lbl_telefone.Text = "Telefone:";
            this.lbl_telefone.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(47, 94);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(49, 17);
            this.lbl_nome.TabIndex = 2;
            this.lbl_nome.Text = "Nome:";
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Location = new System.Drawing.Point(423, 94);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(38, 17);
            this.lbl_cpf.TabIndex = 3;
            this.lbl_cpf.Text = "CPF:";
            // 
            // msk_cpf
            // 
            this.msk_cpf.Location = new System.Drawing.Point(426, 141);
            this.msk_cpf.Mask = "999,999,999-99";
            this.msk_cpf.Name = "msk_cpf";
            this.msk_cpf.Size = new System.Drawing.Size(100, 22);
            this.msk_cpf.TabIndex = 4;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(50, 141);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(317, 22);
            this.txt_nome.TabIndex = 5;
            // 
            // txt_endereco
            // 
            this.txt_endereco.Location = new System.Drawing.Point(50, 221);
            this.txt_endereco.Multiline = true;
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(317, 79);
            this.txt_endereco.TabIndex = 6;
            // 
            // msk_telefone
            // 
            this.msk_telefone.Location = new System.Drawing.Point(559, 141);
            this.msk_telefone.Mask = "(99)00000-0000";
            this.msk_telefone.Name = "msk_telefone";
            this.msk_telefone.Size = new System.Drawing.Size(100, 22);
            this.msk_telefone.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(50, 327);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(582, 183);
            this.dataGridView1.TabIndex = 8;
            // 
            // lbl_pesquisar
            // 
            this.lbl_pesquisar.AutoSize = true;
            this.lbl_pesquisar.Location = new System.Drawing.Point(47, 36);
            this.lbl_pesquisar.Name = "lbl_pesquisar";
            this.lbl_pesquisar.Size = new System.Drawing.Size(79, 17);
            this.lbl_pesquisar.TabIndex = 9;
            this.lbl_pesquisar.Text = "Pesquisar: ";
            // 
            // txt_pesquisar
            // 
            this.txt_pesquisar.Location = new System.Drawing.Point(132, 33);
            this.txt_pesquisar.Name = "txt_pesquisar";
            this.txt_pesquisar.Size = new System.Drawing.Size(178, 22);
            this.txt_pesquisar.TabIndex = 10;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(423, 185);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(51, 17);
            this.lbl_email.TabIndex = 11;
            this.lbl_email.Text = "E-mail:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(426, 221);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 22);
            this.textBox1.TabIndex = 12;
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.Transparent;
            this.btn_editar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_editar.BackgroundImage")));
            this.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_editar.FlatAppearance.BorderSize = 0;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_editar.Location = new System.Drawing.Point(261, 540);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(75, 71);
            this.btn_editar.TabIndex = 15;
            this.btn_editar.UseVisualStyleBackColor = false;
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_salvar.BackgroundImage")));
            this.btn_salvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_salvar.FlatAppearance.BorderSize = 0;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Location = new System.Drawing.Point(376, 540);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 71);
            this.btn_salvar.TabIndex = 16;
            this.btn_salvar.UseVisualStyleBackColor = true;
            // 
            // btn_sair
            // 
            this.btn_sair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sair.BackgroundImage")));
            this.btn_sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sair.FlatAppearance.BorderSize = 0;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btn_sair.Location = new System.Drawing.Point(497, 538);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(78, 74);
            this.btn_sair.TabIndex = 17;
            this.btn_sair.UseVisualStyleBackColor = true;
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.BackColor = System.Drawing.Color.Transparent;
            this.btn_adicionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_adicionar.BackgroundImage")));
            this.btn_adicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_adicionar.FlatAppearance.BorderSize = 0;
            this.btn_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adicionar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_adicionar.Location = new System.Drawing.Point(147, 538);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(70, 75);
            this.btn_adicionar.TabIndex = 18;
            this.btn_adicionar.UseVisualStyleBackColor = false;
            // 
            // btn_duvidas
            // 
            this.btn_duvidas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_duvidas.BackgroundImage")));
            this.btn_duvidas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_duvidas.FlatAppearance.BorderSize = 0;
            this.btn_duvidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_duvidas.Location = new System.Drawing.Point(316, 33);
            this.btn_duvidas.Name = "btn_duvidas";
            this.btn_duvidas.Size = new System.Drawing.Size(29, 22);
            this.btn_duvidas.TabIndex = 13;
            this.btn_duvidas.UseVisualStyleBackColor = true;
            // 
            // frm_cadastroHospedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 654);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_duvidas);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.txt_pesquisar);
            this.Controls.Add(this.lbl_pesquisar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.msk_telefone);
            this.Controls.Add(this.txt_endereco);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.msk_cpf);
            this.Controls.Add(this.lbl_cpf);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_telefone);
            this.Controls.Add(this.lbl_endereco);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_cadastroHospedes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Hóspedes";
            this.Load += new System.EventHandler(this.frm_cadastroHospedes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_endereco;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_cpf;
        public System.Windows.Forms.MaskedTextBox msk_cpf;
        public System.Windows.Forms.TextBox txt_nome;
        public System.Windows.Forms.TextBox txt_endereco;
        public System.Windows.Forms.MaskedTextBox msk_telefone;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_pesquisar;
        public System.Windows.Forms.TextBox txt_pesquisar;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_duvidas;
    }
}