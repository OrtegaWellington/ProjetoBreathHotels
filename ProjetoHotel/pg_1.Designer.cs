namespace ProjetoHotel
{
    partial class pg_1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pg_1));
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quartosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_andares = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_quartos = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeQuartosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hóspedesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarHóspedeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_cadastro_fun = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_cargo = new System.Windows.Forms.ToolStripMenuItem();
            this.empresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hospedadoscheckInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_principal = new System.Windows.Forms.MenuStrip();
            this.pnl_pg_lateral = new System.Windows.Forms.Panel();
            this.ptr_relogio = new System.Windows.Forms.PictureBox();
            this.lbl_data = new System.Windows.Forms.Label();
            this.lbl_horas = new System.Windows.Forms.Label();
            this.tmr_horas = new System.Windows.Forms.Timer(this.components);
            this.tmr_data = new System.Windows.Forms.Timer(this.components);
            this.ptr_hotel = new System.Windows.Forms.PictureBox();
            this.ptr_quarto = new System.Windows.Forms.PictureBox();
            this.ptr_atras_hotel = new System.Windows.Forms.PictureBox();
            this.ptr_piscina = new System.Windows.Forms.PictureBox();
            this.mnu_principal.SuspendLayout();
            this.pnl_pg_lateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_relogio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_hotel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_quarto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_atras_hotel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_piscina)).BeginInit();
            this.SuspendLayout();
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logToolStripMenuItem,
            this.fecharSistemaToolStripMenuItem});
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.sairToolStripMenuItem.Text = "Login";
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.logToolStripMenuItem.Text = "Logout";
            // 
            // fecharSistemaToolStripMenuItem
            // 
            this.fecharSistemaToolStripMenuItem.Name = "fecharSistemaToolStripMenuItem";
            this.fecharSistemaToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.fecharSistemaToolStripMenuItem.Text = "Fechar Sistema";
            this.fecharSistemaToolStripMenuItem.Click += new System.EventHandler(this.fecharSistemaToolStripMenuItem_Click);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quartosToolStripMenuItem,
            this.hóspedesToolStripMenuItem,
            this.funcionariosToolStripMenuItem,
            this.empresaToolStripMenuItem,
            this.fornecedoresToolStripMenuItem1});
            this.cadastroToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.cadastroToolStripMenuItem.Text = "Cadastros";
            // 
            // quartosToolStripMenuItem
            // 
            this.quartosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_andares,
            this.tsm_quartos,
            this.tiposDeQuartosToolStripMenuItem1});
            this.quartosToolStripMenuItem.Name = "quartosToolStripMenuItem";
            this.quartosToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.quartosToolStripMenuItem.Text = "Quartos";
            // 
            // tsm_andares
            // 
            this.tsm_andares.Name = "tsm_andares";
            this.tsm_andares.Size = new System.Drawing.Size(196, 22);
            this.tsm_andares.Text = "Andares";
            this.tsm_andares.Click += new System.EventHandler(this.tsm_andares_Click);
            // 
            // tsm_quartos
            // 
            this.tsm_quartos.Name = "tsm_quartos";
            this.tsm_quartos.Size = new System.Drawing.Size(196, 22);
            this.tsm_quartos.Text = "Quartos";
            this.tsm_quartos.Click += new System.EventHandler(this.tsm_quartos_Click);
            // 
            // tiposDeQuartosToolStripMenuItem1
            // 
            this.tiposDeQuartosToolStripMenuItem1.Name = "tiposDeQuartosToolStripMenuItem1";
            this.tiposDeQuartosToolStripMenuItem1.Size = new System.Drawing.Size(196, 22);
            this.tiposDeQuartosToolStripMenuItem1.Text = "Tipos de quartos";
            this.tiposDeQuartosToolStripMenuItem1.Click += new System.EventHandler(this.tiposDeQuartosToolStripMenuItem1_Click);
            // 
            // hóspedesToolStripMenuItem
            // 
            this.hóspedesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarHóspedeToolStripMenuItem});
            this.hóspedesToolStripMenuItem.Name = "hóspedesToolStripMenuItem";
            this.hóspedesToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.hóspedesToolStripMenuItem.Text = "Hóspedes";
            // 
            // cadastrarHóspedeToolStripMenuItem
            // 
            this.cadastrarHóspedeToolStripMenuItem.Name = "cadastrarHóspedeToolStripMenuItem";
            this.cadastrarHóspedeToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.cadastrarHóspedeToolStripMenuItem.Text = "Cadastro Hóspede";
            this.cadastrarHóspedeToolStripMenuItem.Click += new System.EventHandler(this.cadastrarHóspedeToolStripMenuItem_Click);
            // 
            // funcionariosToolStripMenuItem
            // 
            this.funcionariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_cadastro_fun,
            this.tsm_cargo});
            this.funcionariosToolStripMenuItem.Name = "funcionariosToolStripMenuItem";
            this.funcionariosToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.funcionariosToolStripMenuItem.Text = "Funcionários";
            this.funcionariosToolStripMenuItem.Click += new System.EventHandler(this.funcionariosToolStripMenuItem_Click);
            // 
            // tsm_cadastro_fun
            // 
            this.tsm_cadastro_fun.Name = "tsm_cadastro_fun";
            this.tsm_cadastro_fun.Size = new System.Drawing.Size(225, 22);
            this.tsm_cadastro_fun.Text = "Cadastro Funcionário";
            this.tsm_cadastro_fun.Click += new System.EventHandler(this.tsm_cadastro_fun_Click);
            // 
            // tsm_cargo
            // 
            this.tsm_cargo.Name = "tsm_cargo";
            this.tsm_cargo.Size = new System.Drawing.Size(225, 22);
            this.tsm_cargo.Text = "Cargo";
            this.tsm_cargo.Click += new System.EventHandler(this.tsm_cargo_Click);
            // 
            // empresaToolStripMenuItem
            // 
            this.empresaToolStripMenuItem.Name = "empresaToolStripMenuItem";
            this.empresaToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.empresaToolStripMenuItem.Text = "Empresa";
            this.empresaToolStripMenuItem.Click += new System.EventHandler(this.empresaToolStripMenuItem_Click);
            // 
            // fornecedoresToolStripMenuItem1
            // 
            this.fornecedoresToolStripMenuItem1.Name = "fornecedoresToolStripMenuItem1";
            this.fornecedoresToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.fornecedoresToolStripMenuItem1.Text = "Fornecedores";
            this.fornecedoresToolStripMenuItem1.Click += new System.EventHandler(this.fornecedoresToolStripMenuItem1_Click);
            // 
            // reservasToolStripMenuItem
            // 
            this.reservasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservasToolStripMenuItem1,
            this.hospedadoscheckInToolStripMenuItem,
            this.checkOutToolStripMenuItem});
            this.reservasToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            this.reservasToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.reservasToolStripMenuItem.Text = "Reservas";
            // 
            // reservasToolStripMenuItem1
            // 
            this.reservasToolStripMenuItem1.Name = "reservasToolStripMenuItem1";
            this.reservasToolStripMenuItem1.Size = new System.Drawing.Size(228, 22);
            this.reservasToolStripMenuItem1.Text = "Reservas";
            // 
            // hospedadoscheckInToolStripMenuItem
            // 
            this.hospedadoscheckInToolStripMenuItem.Name = "hospedadoscheckInToolStripMenuItem";
            this.hospedadoscheckInToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.hospedadoscheckInToolStripMenuItem.Text = "Hospedados(check-In";
            // 
            // checkOutToolStripMenuItem
            // 
            this.checkOutToolStripMenuItem.Name = "checkOutToolStripMenuItem";
            this.checkOutToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.checkOutToolStripMenuItem.Text = "Check-Out";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem1,
            this.fornecedoresToolStripMenuItem,
            this.novaVendaToolStripMenuItem,
            this.estoqueToolStripMenuItem});
            this.produtosToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // produtosToolStripMenuItem1
            // 
            this.produtosToolStripMenuItem1.Name = "produtosToolStripMenuItem1";
            this.produtosToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.produtosToolStripMenuItem1.Text = "Produtos";
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            // 
            // novaVendaToolStripMenuItem
            // 
            this.novaVendaToolStripMenuItem.Name = "novaVendaToolStripMenuItem";
            this.novaVendaToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.novaVendaToolStripMenuItem.Text = "Nova Venda";
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // mnu_principal
            // 
            this.mnu_principal.BackColor = System.Drawing.Color.White;
            this.mnu_principal.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnu_principal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnu_principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem,
            this.cadastroToolStripMenuItem,
            this.reservasToolStripMenuItem,
            this.produtosToolStripMenuItem});
            this.mnu_principal.Location = new System.Drawing.Point(0, 0);
            this.mnu_principal.Name = "mnu_principal";
            this.mnu_principal.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnu_principal.Size = new System.Drawing.Size(1109, 25);
            this.mnu_principal.TabIndex = 0;
            this.mnu_principal.Text = "menu_pg1";
            this.mnu_principal.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // pnl_pg_lateral
            // 
            this.pnl_pg_lateral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_pg_lateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.pnl_pg_lateral.Controls.Add(this.ptr_relogio);
            this.pnl_pg_lateral.Controls.Add(this.lbl_data);
            this.pnl_pg_lateral.Controls.Add(this.lbl_horas);
            this.pnl_pg_lateral.Location = new System.Drawing.Point(884, 23);
            this.pnl_pg_lateral.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_pg_lateral.Name = "pnl_pg_lateral";
            this.pnl_pg_lateral.Size = new System.Drawing.Size(234, 727);
            this.pnl_pg_lateral.TabIndex = 3;
            // 
            // ptr_relogio
            // 
            this.ptr_relogio.Image = ((System.Drawing.Image)(resources.GetObject("ptr_relogio.Image")));
            this.ptr_relogio.Location = new System.Drawing.Point(21, 22);
            this.ptr_relogio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ptr_relogio.Name = "ptr_relogio";
            this.ptr_relogio.Size = new System.Drawing.Size(45, 50);
            this.ptr_relogio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptr_relogio.TabIndex = 6;
            this.ptr_relogio.TabStop = false;
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data.ForeColor = System.Drawing.Color.White;
            this.lbl_data.Location = new System.Drawing.Point(17, 90);
            this.lbl_data.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(181, 22);
            this.lbl_data.TabIndex = 6;
            this.lbl_data.Text = "DATA:  25/03/2021";
            this.lbl_data.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_horas
            // 
            this.lbl_horas.AutoSize = true;
            this.lbl_horas.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_horas.ForeColor = System.Drawing.Color.White;
            this.lbl_horas.Location = new System.Drawing.Point(90, 36);
            this.lbl_horas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_horas.Name = "lbl_horas";
            this.lbl_horas.Size = new System.Drawing.Size(92, 22);
            this.lbl_horas.TabIndex = 6;
            this.lbl_horas.Text = "20:16:15";
            this.lbl_horas.Click += new System.EventHandler(this.lbl_horas_Click);
            // 
            // tmr_horas
            // 
            this.tmr_horas.Enabled = true;
            this.tmr_horas.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tmr_data
            // 
            this.tmr_data.Enabled = true;
            this.tmr_data.Tick += new System.EventHandler(this.tmr_data_Tick);
            // 
            // ptr_hotel
            // 
            this.ptr_hotel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptr_hotel.Image = ((System.Drawing.Image)(resources.GetObject("ptr_hotel.Image")));
            this.ptr_hotel.Location = new System.Drawing.Point(655, 25);
            this.ptr_hotel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ptr_hotel.Name = "ptr_hotel";
            this.ptr_hotel.Size = new System.Drawing.Size(224, 192);
            this.ptr_hotel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptr_hotel.TabIndex = 6;
            this.ptr_hotel.TabStop = false;
            // 
            // ptr_quarto
            // 
            this.ptr_quarto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptr_quarto.Image = ((System.Drawing.Image)(resources.GetObject("ptr_quarto.Image")));
            this.ptr_quarto.Location = new System.Drawing.Point(655, 222);
            this.ptr_quarto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ptr_quarto.Name = "ptr_quarto";
            this.ptr_quarto.Size = new System.Drawing.Size(224, 192);
            this.ptr_quarto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptr_quarto.TabIndex = 7;
            this.ptr_quarto.TabStop = false;
            // 
            // ptr_atras_hotel
            // 
            this.ptr_atras_hotel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptr_atras_hotel.Image = ((System.Drawing.Image)(resources.GetObject("ptr_atras_hotel.Image")));
            this.ptr_atras_hotel.Location = new System.Drawing.Point(655, 615);
            this.ptr_atras_hotel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ptr_atras_hotel.Name = "ptr_atras_hotel";
            this.ptr_atras_hotel.Size = new System.Drawing.Size(224, 192);
            this.ptr_atras_hotel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptr_atras_hotel.TabIndex = 8;
            this.ptr_atras_hotel.TabStop = false;
            // 
            // ptr_piscina
            // 
            this.ptr_piscina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptr_piscina.Image = ((System.Drawing.Image)(resources.GetObject("ptr_piscina.Image")));
            this.ptr_piscina.Location = new System.Drawing.Point(655, 418);
            this.ptr_piscina.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ptr_piscina.Name = "ptr_piscina";
            this.ptr_piscina.Size = new System.Drawing.Size(224, 192);
            this.ptr_piscina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptr_piscina.TabIndex = 9;
            this.ptr_piscina.TabStop = false;
            // 
            // pg_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 748);
            this.Controls.Add(this.ptr_piscina);
            this.Controls.Add(this.ptr_atras_hotel);
            this.Controls.Add(this.ptr_quarto);
            this.Controls.Add(this.ptr_hotel);
            this.Controls.Add(this.pnl_pg_lateral);
            this.Controls.Add(this.mnu_principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnu_principal;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "pg_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.pg_1_Load);
            this.mnu_principal.ResumeLayout(false);
            this.mnu_principal.PerformLayout();
            this.pnl_pg_lateral.ResumeLayout(false);
            this.pnl_pg_lateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_relogio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_hotel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_quarto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_atras_hotel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_piscina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quartosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsm_andares;
        private System.Windows.Forms.ToolStripMenuItem tsm_quartos;
        private System.Windows.Forms.ToolStripMenuItem tiposDeQuartosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hóspedesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarHóspedeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsm_cargo;
        private System.Windows.Forms.ToolStripMenuItem empresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hospedadoscheckInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mnu_principal;
        private System.Windows.Forms.Panel pnl_pg_lateral;
        private System.Windows.Forms.Label lbl_horas;
        private System.Windows.Forms.Timer tmr_horas;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.Timer tmr_data;
        private System.Windows.Forms.PictureBox ptr_relogio;
        private System.Windows.Forms.PictureBox ptr_hotel;
        private System.Windows.Forms.PictureBox ptr_quarto;
        private System.Windows.Forms.PictureBox ptr_atras_hotel;
        private System.Windows.Forms.PictureBox ptr_piscina;
        private System.Windows.Forms.ToolStripMenuItem tsm_cadastro_fun;
    }
}