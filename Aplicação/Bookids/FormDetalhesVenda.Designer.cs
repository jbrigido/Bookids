namespace Bookids
{
    partial class FormDetalhesVenda
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
            this.gbDetalhesVenda = new System.Windows.Forms.GroupBox();
            this.btRemoverProduto = new System.Windows.Forms.Button();
            this.btAdicionarProduto = new System.Windows.Forms.Button();
            this.nmQuantidade = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.lbProdutos = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTipoProduto = new System.Windows.Forms.ComboBox();
            this.dtpDataVenda = new System.Windows.Forms.DateTimePicker();
            this.lbDetalhesVenda = new System.Windows.Forms.ListBox();
            this.checkCartaoCliente = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btCancelClean = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.gbDetalhesVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDetalhesVenda
            // 
            this.gbDetalhesVenda.Controls.Add(this.btRemoverProduto);
            this.gbDetalhesVenda.Controls.Add(this.btAdicionarProduto);
            this.gbDetalhesVenda.Controls.Add(this.nmQuantidade);
            this.gbDetalhesVenda.Controls.Add(this.label6);
            this.gbDetalhesVenda.Controls.Add(this.lbProdutos);
            this.gbDetalhesVenda.Controls.Add(this.label5);
            this.gbDetalhesVenda.Controls.Add(this.cbTipoProduto);
            this.gbDetalhesVenda.Controls.Add(this.dtpDataVenda);
            this.gbDetalhesVenda.Controls.Add(this.lbDetalhesVenda);
            this.gbDetalhesVenda.Controls.Add(this.checkCartaoCliente);
            this.gbDetalhesVenda.Controls.Add(this.label4);
            this.gbDetalhesVenda.Location = new System.Drawing.Point(11, 41);
            this.gbDetalhesVenda.Name = "gbDetalhesVenda";
            this.gbDetalhesVenda.Size = new System.Drawing.Size(529, 214);
            this.gbDetalhesVenda.TabIndex = 17;
            this.gbDetalhesVenda.TabStop = false;
            this.gbDetalhesVenda.Text = "Detalhes de Venda";
            // 
            // btRemoverProduto
            // 
            this.btRemoverProduto.Location = new System.Drawing.Point(196, 148);
            this.btRemoverProduto.Name = "btRemoverProduto";
            this.btRemoverProduto.Size = new System.Drawing.Size(141, 23);
            this.btRemoverProduto.TabIndex = 23;
            this.btRemoverProduto.Text = "Remover da Lista";
            this.btRemoverProduto.UseVisualStyleBackColor = true;
            this.btRemoverProduto.Click += new System.EventHandler(this.btRemoverProduto_Click);
            // 
            // btAdicionarProduto
            // 
            this.btAdicionarProduto.Location = new System.Drawing.Point(196, 119);
            this.btAdicionarProduto.Name = "btAdicionarProduto";
            this.btAdicionarProduto.Size = new System.Drawing.Size(141, 23);
            this.btAdicionarProduto.TabIndex = 22;
            this.btAdicionarProduto.Text = "Adicionar à Lista";
            this.btAdicionarProduto.UseVisualStyleBackColor = true;
            this.btAdicionarProduto.Click += new System.EventHandler(this.btAdicionarProduto_Click);
            // 
            // nmQuantidade
            // 
            this.nmQuantidade.Location = new System.Drawing.Point(265, 81);
            this.nmQuantidade.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmQuantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmQuantidade.Name = "nmQuantidade";
            this.nmQuantidade.Size = new System.Drawing.Size(72, 20);
            this.nmQuantidade.TabIndex = 21;
            this.nmQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(193, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Quantidade:";
            // 
            // lbProdutos
            // 
            this.lbProdutos.FormattingEnabled = true;
            this.lbProdutos.Location = new System.Drawing.Point(343, 70);
            this.lbProdutos.Name = "lbProdutos";
            this.lbProdutos.Size = new System.Drawing.Size(158, 134);
            this.lbProdutos.TabIndex = 20;
            this.lbProdutos.SelectedIndexChanged += new System.EventHandler(this.lbProdutos_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Selecionar o tipo de Produto:";
            // 
            // cbTipoProduto
            // 
            this.cbTipoProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoProduto.FormattingEnabled = true;
            this.cbTipoProduto.Location = new System.Drawing.Point(343, 43);
            this.cbTipoProduto.Name = "cbTipoProduto";
            this.cbTipoProduto.Size = new System.Drawing.Size(158, 21);
            this.cbTipoProduto.TabIndex = 18;
            this.cbTipoProduto.SelectedIndexChanged += new System.EventHandler(this.cbTipoProduto_SelectedIndexChanged);
            // 
            // dtpDataVenda
            // 
            this.dtpDataVenda.CustomFormat = "dd:MM:yyyy hh:mm:ss";
            this.dtpDataVenda.Enabled = false;
            this.dtpDataVenda.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataVenda.Location = new System.Drawing.Point(100, 17);
            this.dtpDataVenda.Name = "dtpDataVenda";
            this.dtpDataVenda.Size = new System.Drawing.Size(168, 20);
            this.dtpDataVenda.TabIndex = 17;
            // 
            // lbDetalhesVenda
            // 
            this.lbDetalhesVenda.FormattingEnabled = true;
            this.lbDetalhesVenda.Location = new System.Drawing.Point(10, 43);
            this.lbDetalhesVenda.Name = "lbDetalhesVenda";
            this.lbDetalhesVenda.Size = new System.Drawing.Size(177, 160);
            this.lbDetalhesVenda.TabIndex = 15;
            // 
            // checkCartaoCliente
            // 
            this.checkCartaoCliente.AutoSize = true;
            this.checkCartaoCliente.Location = new System.Drawing.Point(306, 19);
            this.checkCartaoCliente.Name = "checkCartaoCliente";
            this.checkCartaoCliente.Size = new System.Drawing.Size(92, 17);
            this.checkCartaoCliente.TabIndex = 14;
            this.checkCartaoCliente.Text = "Cartão Cliente";
            this.checkCartaoCliente.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Data da Venda:";
            // 
            // btCancelClean
            // 
            this.btCancelClean.Location = new System.Drawing.Point(214, 12);
            this.btCancelClean.Name = "btCancelClean";
            this.btCancelClean.Size = new System.Drawing.Size(148, 23);
            this.btCancelClean.TabIndex = 19;
            this.btCancelClean.Text = "Cancelar/Limpar Alterações";
            this.btCancelClean.UseVisualStyleBackColor = true;
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(60, 12);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(148, 23);
            this.btGuardar.TabIndex = 18;
            this.btGuardar.Text = "Guardar Alterações";
            this.btGuardar.UseVisualStyleBackColor = true;
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(368, 12);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(148, 23);
            this.btSair.TabIndex = 20;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            // 
            // FormDetalhesVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 273);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btCancelClean);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.gbDetalhesVenda);
            this.Name = "FormDetalhesVenda";
            this.Text = "FormDetalhesVenda";
            this.Load += new System.EventHandler(this.FormDetalhesVenda_Load);
            this.gbDetalhesVenda.ResumeLayout(false);
            this.gbDetalhesVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantidade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDetalhesVenda;
        private System.Windows.Forms.Button btRemoverProduto;
        private System.Windows.Forms.Button btAdicionarProduto;
        private System.Windows.Forms.NumericUpDown nmQuantidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbProdutos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTipoProduto;
        private System.Windows.Forms.DateTimePicker dtpDataVenda;
        private System.Windows.Forms.ListBox lbDetalhesVenda;
        private System.Windows.Forms.CheckBox checkCartaoCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btCancelClean;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btSair;
    }
}