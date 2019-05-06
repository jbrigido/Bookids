namespace Bookids
{
    partial class FormProdutos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbFichaProduto = new System.Windows.Forms.GroupBox();
            this.btGuardarProduto = new System.Windows.Forms.Button();
            this.tbStock = new System.Windows.Forms.TextBox();
            this.nmPreco = new System.Windows.Forms.NumericUpDown();
            this.cbTipoProduto = new System.Windows.Forms.ComboBox();
            this.tbDesignacao = new System.Windows.Forms.TextBox();
            this.tbCodProduto = new System.Windows.Forms.TextBox();
            this.btEditarProduto = new System.Windows.Forms.Button();
            this.btApagarProduto = new System.Windows.Forms.Button();
            this.btAdicionarProduto = new System.Windows.Forms.Button();
            this.lbProdutos = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.gbFichaProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmPreco)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbFichaProduto);
            this.groupBox1.Controls.Add(this.btEditarProduto);
            this.groupBox1.Controls.Add(this.btApagarProduto);
            this.groupBox1.Controls.Add(this.btAdicionarProduto);
            this.groupBox1.Controls.Add(this.lbProdutos);
            this.groupBox1.Location = new System.Drawing.Point(56, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 254);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produtos";
            // 
            // gbFichaProduto
            // 
            this.gbFichaProduto.Controls.Add(this.btGuardarProduto);
            this.gbFichaProduto.Controls.Add(this.tbStock);
            this.gbFichaProduto.Controls.Add(this.nmPreco);
            this.gbFichaProduto.Controls.Add(this.cbTipoProduto);
            this.gbFichaProduto.Controls.Add(this.tbDesignacao);
            this.gbFichaProduto.Controls.Add(this.tbCodProduto);
            this.gbFichaProduto.Location = new System.Drawing.Point(174, 20);
            this.gbFichaProduto.Name = "gbFichaProduto";
            this.gbFichaProduto.Size = new System.Drawing.Size(215, 134);
            this.gbFichaProduto.TabIndex = 4;
            this.gbFichaProduto.TabStop = false;
            this.gbFichaProduto.Text = "Ficha de Produto";
            // 
            // btGuardarProduto
            // 
            this.btGuardarProduto.Location = new System.Drawing.Point(7, 99);
            this.btGuardarProduto.Name = "btGuardarProduto";
            this.btGuardarProduto.Size = new System.Drawing.Size(202, 23);
            this.btGuardarProduto.TabIndex = 5;
            this.btGuardarProduto.Text = "Guardar Alterações";
            this.btGuardarProduto.UseVisualStyleBackColor = true;
            // 
            // tbStock
            // 
            this.tbStock.Location = new System.Drawing.Point(7, 72);
            this.tbStock.Name = "tbStock";
            this.tbStock.Size = new System.Drawing.Size(100, 20);
            this.tbStock.TabIndex = 4;
            this.tbStock.Text = "Stock Existente";
            // 
            // nmPreco
            // 
            this.nmPreco.Location = new System.Drawing.Point(113, 72);
            this.nmPreco.Name = "nmPreco";
            this.nmPreco.Size = new System.Drawing.Size(96, 20);
            this.nmPreco.TabIndex = 3;
            // 
            // cbTipoProduto
            // 
            this.cbTipoProduto.FormattingEnabled = true;
            this.cbTipoProduto.Items.AddRange(new object[] {
            "Tipo1",
            "Tipo2",
            "Tipo3"});
            this.cbTipoProduto.Location = new System.Drawing.Point(128, 20);
            this.cbTipoProduto.Name = "cbTipoProduto";
            this.cbTipoProduto.Size = new System.Drawing.Size(81, 21);
            this.cbTipoProduto.TabIndex = 2;
            this.cbTipoProduto.Text = "TipoProduto";
            // 
            // tbDesignacao
            // 
            this.tbDesignacao.Location = new System.Drawing.Point(7, 46);
            this.tbDesignacao.Name = "tbDesignacao";
            this.tbDesignacao.Size = new System.Drawing.Size(202, 20);
            this.tbDesignacao.TabIndex = 1;
            this.tbDesignacao.Text = "Designação";
            // 
            // tbCodProduto
            // 
            this.tbCodProduto.Location = new System.Drawing.Point(7, 20);
            this.tbCodProduto.Name = "tbCodProduto";
            this.tbCodProduto.Size = new System.Drawing.Size(114, 20);
            this.tbCodProduto.TabIndex = 0;
            this.tbCodProduto.Text = "Codigo Produto";
            // 
            // btEditarProduto
            // 
            this.btEditarProduto.Location = new System.Drawing.Point(208, 218);
            this.btEditarProduto.Name = "btEditarProduto";
            this.btEditarProduto.Size = new System.Drawing.Size(150, 23);
            this.btEditarProduto.TabIndex = 3;
            this.btEditarProduto.Text = "Editar Produto";
            this.btEditarProduto.UseVisualStyleBackColor = true;
            // 
            // btApagarProduto
            // 
            this.btApagarProduto.Location = new System.Drawing.Point(208, 189);
            this.btApagarProduto.Name = "btApagarProduto";
            this.btApagarProduto.Size = new System.Drawing.Size(150, 23);
            this.btApagarProduto.TabIndex = 2;
            this.btApagarProduto.Text = "Apagar Produto";
            this.btApagarProduto.UseVisualStyleBackColor = true;
            // 
            // btAdicionarProduto
            // 
            this.btAdicionarProduto.Location = new System.Drawing.Point(208, 160);
            this.btAdicionarProduto.Name = "btAdicionarProduto";
            this.btAdicionarProduto.Size = new System.Drawing.Size(150, 23);
            this.btAdicionarProduto.TabIndex = 1;
            this.btAdicionarProduto.Text = "Adicionar Novo Produto";
            this.btAdicionarProduto.UseVisualStyleBackColor = true;
            // 
            // lbProdutos
            // 
            this.lbProdutos.FormattingEnabled = true;
            this.lbProdutos.Location = new System.Drawing.Point(7, 20);
            this.lbProdutos.Name = "lbProdutos";
            this.lbProdutos.Size = new System.Drawing.Size(150, 225);
            this.lbProdutos.TabIndex = 0;
            // 
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 415);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormProdutos";
            this.Text = "FormProdutos";
            this.groupBox1.ResumeLayout(false);
            this.gbFichaProduto.ResumeLayout(false);
            this.gbFichaProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmPreco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbProdutos;
        private System.Windows.Forms.Button btApagarProduto;
        private System.Windows.Forms.Button btAdicionarProduto;
        private System.Windows.Forms.Button btEditarProduto;
        private System.Windows.Forms.GroupBox gbFichaProduto;
        private System.Windows.Forms.TextBox tbDesignacao;
        private System.Windows.Forms.TextBox tbCodProduto;
        private System.Windows.Forms.ComboBox cbTipoProduto;
        private System.Windows.Forms.Button btGuardarProduto;
        private System.Windows.Forms.TextBox tbStock;
        private System.Windows.Forms.NumericUpDown nmPreco;
    }
}