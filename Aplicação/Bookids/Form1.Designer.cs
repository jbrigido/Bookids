namespace Bookids
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ficheiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btClientes = new System.Windows.Forms.Button();
            this.btProdutos = new System.Windows.Forms.Button();
            this.btEventos = new System.Windows.Forms.Button();
            this.btAnimadores = new System.Windows.Forms.Button();
            this.btEscolas = new System.Windows.Forms.Button();
            this.lbInfo = new System.Windows.Forms.Label();
            this.btVendas = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheiroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(499, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ficheiroToolStripMenuItem
            // 
            this.ficheiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.ficheiroToolStripMenuItem.Name = "ficheiroToolStripMenuItem";
            this.ficheiroToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ficheiroToolStripMenuItem.Text = "Ficheiro";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // btClientes
            // 
            this.btClientes.Location = new System.Drawing.Point(315, 40);
            this.btClientes.Name = "btClientes";
            this.btClientes.Size = new System.Drawing.Size(172, 24);
            this.btClientes.TabIndex = 1;
            this.btClientes.Text = "Gestão de Clientes";
            this.btClientes.UseVisualStyleBackColor = true;
            this.btClientes.Click += new System.EventHandler(this.btClientes_Click);
            // 
            // btProdutos
            // 
            this.btProdutos.Location = new System.Drawing.Point(315, 70);
            this.btProdutos.Name = "btProdutos";
            this.btProdutos.Size = new System.Drawing.Size(172, 23);
            this.btProdutos.TabIndex = 2;
            this.btProdutos.Text = "Gestão de Produtos (stocks)";
            this.btProdutos.UseVisualStyleBackColor = true;
            this.btProdutos.Click += new System.EventHandler(this.btProdutos_Click);
            // 
            // btEventos
            // 
            this.btEventos.Location = new System.Drawing.Point(315, 99);
            this.btEventos.Name = "btEventos";
            this.btEventos.Size = new System.Drawing.Size(172, 24);
            this.btEventos.TabIndex = 3;
            this.btEventos.Text = "Gestão de Eventos";
            this.btEventos.UseVisualStyleBackColor = true;
            this.btEventos.Click += new System.EventHandler(this.btEventos_Click);
            // 
            // btAnimadores
            // 
            this.btAnimadores.Location = new System.Drawing.Point(315, 129);
            this.btAnimadores.Name = "btAnimadores";
            this.btAnimadores.Size = new System.Drawing.Size(172, 24);
            this.btAnimadores.TabIndex = 4;
            this.btAnimadores.Text = "Gestão de Animadores";
            this.btAnimadores.UseVisualStyleBackColor = true;
            this.btAnimadores.Click += new System.EventHandler(this.btAnimadores_Click);
            // 
            // btEscolas
            // 
            this.btEscolas.Location = new System.Drawing.Point(315, 160);
            this.btEscolas.Name = "btEscolas";
            this.btEscolas.Size = new System.Drawing.Size(172, 23);
            this.btEscolas.TabIndex = 5;
            this.btEscolas.Text = "Gestão de Escolas";
            this.btEscolas.UseVisualStyleBackColor = true;
            this.btEscolas.Click += new System.EventHandler(this.btEscolas_Click);
            // 
            // lbInfo
            // 
            this.lbInfo.BackColor = System.Drawing.SystemColors.Info;
            this.lbInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbInfo.Location = new System.Drawing.Point(12, 40);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(285, 172);
            this.lbInfo.TabIndex = 6;
            this.lbInfo.Text = "Bem-vindo ao Bookids";
            // 
            // btVendas
            // 
            this.btVendas.Location = new System.Drawing.Point(315, 189);
            this.btVendas.Name = "btVendas";
            this.btVendas.Size = new System.Drawing.Size(172, 23);
            this.btVendas.TabIndex = 7;
            this.btVendas.Text = "Gestão de Vendas";
            this.btVendas.UseVisualStyleBackColor = true;
            this.btVendas.Click += new System.EventHandler(this.btVendas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 224);
            this.Controls.Add(this.btVendas);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.btEscolas);
            this.Controls.Add(this.btAnimadores);
            this.Controls.Add(this.btEventos);
            this.Controls.Add(this.btProdutos);
            this.Controls.Add(this.btClientes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Bookids - Menu Principal";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ficheiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Button btClientes;
        private System.Windows.Forms.Button btProdutos;
        private System.Windows.Forms.Button btEventos;
        private System.Windows.Forms.Button btAnimadores;
        private System.Windows.Forms.Button btEscolas;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Button btVendas;
    }
}

