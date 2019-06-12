namespace Bookids
{
    partial class FormVendas
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
            this.btApagarVenda = new System.Windows.Forms.Button();
            this.btEditarVenda = new System.Windows.Forms.Button();
            this.btRegistarVenda = new System.Windows.Forms.Button();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.tbValorOferta = new System.Windows.Forms.TextBox();
            this.dgvVendas = new System.Windows.Forms.DataGridView();
            this.btCancelCleanVenda = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNrCartao = new System.Windows.Forms.TextBox();
            this.cbClientes = new System.Windows.Forms.ComboBox();
            this.btGuardarVenda = new System.Windows.Forms.Button();
            this.dgvDetalhesCompra = new System.Windows.Forms.DataGridView();
            this.btImprimir = new System.Windows.Forms.Button();
            this.gbProdutos = new System.Windows.Forms.GroupBox();
            this.btRemoverProduto = new System.Windows.Forms.Button();
            this.btAdicionarProduto = new System.Windows.Forms.Button();
            this.nmQuantidade = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.lbProdutos = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTipoProduto = new System.Windows.Forms.ComboBox();
            this.DesignacaoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalheComprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nrCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utilizouCartaoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.comprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalhesCompra)).BeginInit();
            this.gbProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalheComprasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btApagarVenda
            // 
            this.btApagarVenda.Location = new System.Drawing.Point(33, 106);
            this.btApagarVenda.Name = "btApagarVenda";
            this.btApagarVenda.Size = new System.Drawing.Size(182, 23);
            this.btApagarVenda.TabIndex = 8;
            this.btApagarVenda.Text = "Apagar Venda";
            this.btApagarVenda.UseVisualStyleBackColor = true;
            this.btApagarVenda.Click += new System.EventHandler(this.btApagarVenda_Click);
            // 
            // btEditarVenda
            // 
            this.btEditarVenda.Location = new System.Drawing.Point(33, 48);
            this.btEditarVenda.Name = "btEditarVenda";
            this.btEditarVenda.Size = new System.Drawing.Size(182, 23);
            this.btEditarVenda.TabIndex = 7;
            this.btEditarVenda.Text = "Editar Venda";
            this.btEditarVenda.UseVisualStyleBackColor = true;
            this.btEditarVenda.Click += new System.EventHandler(this.btEditarVenda_Click);
            // 
            // btRegistarVenda
            // 
            this.btRegistarVenda.Location = new System.Drawing.Point(33, 19);
            this.btRegistarVenda.Name = "btRegistarVenda";
            this.btRegistarVenda.Size = new System.Drawing.Size(182, 23);
            this.btRegistarVenda.TabIndex = 6;
            this.btRegistarVenda.Text = "Registar Venda";
            this.btRegistarVenda.UseVisualStyleBackColor = true;
            this.btRegistarVenda.Click += new System.EventHandler(this.btRegistarVenda_Click);
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.tbValorOferta);
            this.gbCliente.Controls.Add(this.dgvVendas);
            this.gbCliente.Controls.Add(this.btCancelCleanVenda);
            this.gbCliente.Controls.Add(this.label3);
            this.gbCliente.Controls.Add(this.label2);
            this.gbCliente.Controls.Add(this.label1);
            this.gbCliente.Controls.Add(this.tbNrCartao);
            this.gbCliente.Controls.Add(this.cbClientes);
            this.gbCliente.Controls.Add(this.btRegistarVenda);
            this.gbCliente.Controls.Add(this.btGuardarVenda);
            this.gbCliente.Controls.Add(this.btEditarVenda);
            this.gbCliente.Controls.Add(this.btApagarVenda);
            this.gbCliente.Location = new System.Drawing.Point(12, 12);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(641, 168);
            this.gbCliente.TabIndex = 10;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Dados Cliente";
            // 
            // tbValorOferta
            // 
            this.tbValorOferta.Enabled = false;
            this.tbValorOferta.Location = new System.Drawing.Point(527, 47);
            this.tbValorOferta.Name = "tbValorOferta";
            this.tbValorOferta.Size = new System.Drawing.Size(73, 20);
            this.tbValorOferta.TabIndex = 17;
            // 
            // dgvVendas
            // 
            this.dgvVendas.AllowUserToAddRows = false;
            this.dgvVendas.AllowUserToDeleteRows = false;
            this.dgvVendas.AutoGenerateColumns = false;
            this.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nrCompraDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.utilizouCartaoDataGridViewCheckBoxColumn});
            this.dgvVendas.DataSource = this.comprasBindingSource;
            this.dgvVendas.Location = new System.Drawing.Point(255, 74);
            this.dgvVendas.Name = "dgvVendas";
            this.dgvVendas.ReadOnly = true;
            this.dgvVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVendas.Size = new System.Drawing.Size(345, 81);
            this.dgvVendas.TabIndex = 16;
            this.dgvVendas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvVendas_MouseClick);
            // 
            // btCancelCleanVenda
            // 
            this.btCancelCleanVenda.Location = new System.Drawing.Point(33, 135);
            this.btCancelCleanVenda.Name = "btCancelCleanVenda";
            this.btCancelCleanVenda.Size = new System.Drawing.Size(182, 23);
            this.btCancelCleanVenda.TabIndex = 16;
            this.btCancelCleanVenda.Text = "Cancelar/Limpar Alterações";
            this.btCancelCleanVenda.UseVisualStyleBackColor = true;
            this.btCancelCleanVenda.Click += new System.EventHandler(this.btCancelCleanVenda_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(455, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor Oferta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cartão Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome Cliente:";
            // 
            // tbNrCartao
            // 
            this.tbNrCartao.Enabled = false;
            this.tbNrCartao.Location = new System.Drawing.Point(334, 47);
            this.tbNrCartao.Name = "tbNrCartao";
            this.tbNrCartao.Size = new System.Drawing.Size(64, 20);
            this.tbNrCartao.TabIndex = 3;
            // 
            // cbClientes
            // 
            this.cbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Location = new System.Drawing.Point(334, 16);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(266, 21);
            this.cbClientes.TabIndex = 0;
            this.cbClientes.SelectedIndexChanged += new System.EventHandler(this.cbClientes_SelectedIndexChanged);
            // 
            // btGuardarVenda
            // 
            this.btGuardarVenda.Location = new System.Drawing.Point(33, 77);
            this.btGuardarVenda.Name = "btGuardarVenda";
            this.btGuardarVenda.Size = new System.Drawing.Size(182, 23);
            this.btGuardarVenda.TabIndex = 9;
            this.btGuardarVenda.Text = "Guardar Alterações";
            this.btGuardarVenda.UseVisualStyleBackColor = true;
            // 
            // dgvDetalhesCompra
            // 
            this.dgvDetalhesCompra.AllowUserToAddRows = false;
            this.dgvDetalhesCompra.AllowUserToDeleteRows = false;
            this.dgvDetalhesCompra.AutoGenerateColumns = false;
            this.dgvDetalhesCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalhesCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DesignacaoProduto,
            this.quantidadeDataGridViewTextBoxColumn,
            this.precoUnitario,
            this.subtotal});
            this.dgvDetalhesCompra.DataSource = this.detalheComprasBindingSource;
            this.dgvDetalhesCompra.Location = new System.Drawing.Point(18, 186);
            this.dgvDetalhesCompra.Name = "dgvDetalhesCompra";
            this.dgvDetalhesCompra.ReadOnly = true;
            this.dgvDetalhesCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalhesCompra.Size = new System.Drawing.Size(444, 226);
            this.dgvDetalhesCompra.TabIndex = 11;
            this.dgvDetalhesCompra.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvDetalhesCompra_MouseClick);
            // 
            // btImprimir
            // 
            this.btImprimir.Location = new System.Drawing.Point(18, 418);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(181, 23);
            this.btImprimir.TabIndex = 12;
            this.btImprimir.Text = "Imprimir Fatura";
            this.btImprimir.UseVisualStyleBackColor = true;
            // 
            // gbProdutos
            // 
            this.gbProdutos.Controls.Add(this.btAdicionarProduto);
            this.gbProdutos.Controls.Add(this.nmQuantidade);
            this.gbProdutos.Controls.Add(this.label6);
            this.gbProdutos.Controls.Add(this.lbProdutos);
            this.gbProdutos.Controls.Add(this.label5);
            this.gbProdutos.Controls.Add(this.cbTipoProduto);
            this.gbProdutos.Location = new System.Drawing.Point(468, 186);
            this.gbProdutos.Name = "gbProdutos";
            this.gbProdutos.Size = new System.Drawing.Size(185, 266);
            this.gbProdutos.TabIndex = 13;
            this.gbProdutos.TabStop = false;
            this.gbProdutos.Text = "Produtos";
            // 
            // btRemoverProduto
            // 
            this.btRemoverProduto.Location = new System.Drawing.Point(281, 418);
            this.btRemoverProduto.Name = "btRemoverProduto";
            this.btRemoverProduto.Size = new System.Drawing.Size(181, 23);
            this.btRemoverProduto.TabIndex = 30;
            this.btRemoverProduto.Text = "Remover da Lista";
            this.btRemoverProduto.UseVisualStyleBackColor = true;
            // 
            // btAdicionarProduto
            // 
            this.btAdicionarProduto.Location = new System.Drawing.Point(27, 232);
            this.btAdicionarProduto.Name = "btAdicionarProduto";
            this.btAdicionarProduto.Size = new System.Drawing.Size(141, 23);
            this.btAdicionarProduto.TabIndex = 29;
            this.btAdicionarProduto.Text = "Adicionar à Lista";
            this.btAdicionarProduto.UseVisualStyleBackColor = true;
            this.btAdicionarProduto.Click += new System.EventHandler(this.btAdicionarProduto_Click);
            // 
            // nmQuantidade
            // 
            this.nmQuantidade.Location = new System.Drawing.Point(95, 206);
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
            this.nmQuantidade.TabIndex = 28;
            this.nmQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Quantidade:";
            // 
            // lbProdutos
            // 
            this.lbProdutos.FormattingEnabled = true;
            this.lbProdutos.Location = new System.Drawing.Point(27, 66);
            this.lbProdutos.Name = "lbProdutos";
            this.lbProdutos.Size = new System.Drawing.Size(141, 134);
            this.lbProdutos.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Selecionar o tipo de Produto:";
            // 
            // cbTipoProduto
            // 
            this.cbTipoProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoProduto.FormattingEnabled = true;
            this.cbTipoProduto.Location = new System.Drawing.Point(27, 39);
            this.cbTipoProduto.Name = "cbTipoProduto";
            this.cbTipoProduto.Size = new System.Drawing.Size(141, 21);
            this.cbTipoProduto.TabIndex = 25;
            this.cbTipoProduto.SelectedIndexChanged += new System.EventHandler(this.cbTipoProduto_SelectedIndexChanged);
            // 
            // DesignacaoProduto
            // 
            this.DesignacaoProduto.DataPropertyName = "Quantidade";
            this.DesignacaoProduto.HeaderText = "Designação";
            this.DesignacaoProduto.Name = "DesignacaoProduto";
            this.DesignacaoProduto.ReadOnly = true;
            // 
            // precoUnitario
            // 
            this.precoUnitario.HeaderText = "Preço Unitário";
            this.precoUnitario.Name = "precoUnitario";
            this.precoUnitario.ReadOnly = true;
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Total";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // detalheComprasBindingSource
            // 
            this.detalheComprasBindingSource.DataSource = typeof(Bookids.DetalheCompras);
            // 
            // nrCompraDataGridViewTextBoxColumn
            // 
            this.nrCompraDataGridViewTextBoxColumn.DataPropertyName = "NrCompra";
            this.nrCompraDataGridViewTextBoxColumn.HeaderText = "NrCompra";
            this.nrCompraDataGridViewTextBoxColumn.Name = "nrCompraDataGridViewTextBoxColumn";
            this.nrCompraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // utilizouCartaoDataGridViewCheckBoxColumn
            // 
            this.utilizouCartaoDataGridViewCheckBoxColumn.DataPropertyName = "UtilizouCartao";
            this.utilizouCartaoDataGridViewCheckBoxColumn.HeaderText = "UtilizouCartao";
            this.utilizouCartaoDataGridViewCheckBoxColumn.Name = "utilizouCartaoDataGridViewCheckBoxColumn";
            this.utilizouCartaoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // comprasBindingSource
            // 
            this.comprasBindingSource.DataSource = typeof(Bookids.Compras);
            // 
            // FormVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 457);
            this.Controls.Add(this.btRemoverProduto);
            this.Controls.Add(this.gbProdutos);
            this.Controls.Add(this.btImprimir);
            this.Controls.Add(this.dgvDetalhesCompra);
            this.Controls.Add(this.gbCliente);
            this.Name = "FormVendas";
            this.Text = "FormVendas";
            this.Load += new System.EventHandler(this.FormVendas_Load);
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalhesCompra)).EndInit();
            this.gbProdutos.ResumeLayout(false);
            this.gbProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalheComprasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btApagarVenda;
        private System.Windows.Forms.Button btEditarVenda;
        private System.Windows.Forms.Button btRegistarVenda;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.ComboBox cbClientes;
        private System.Windows.Forms.TextBox tbNrCartao;
        private System.Windows.Forms.Button btCancelCleanVenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvVendas;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn utilizouCartaoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource comprasBindingSource;
        private System.Windows.Forms.TextBox tbValorOferta;
        private System.Windows.Forms.BindingSource detalheComprasBindingSource;
        private System.Windows.Forms.Button btGuardarVenda;
        private System.Windows.Forms.DataGridView dgvDetalhesCompra;
        private System.Windows.Forms.Button btImprimir;
        private System.Windows.Forms.GroupBox gbProdutos;
        private System.Windows.Forms.Button btRemoverProduto;
        private System.Windows.Forms.Button btAdicionarProduto;
        private System.Windows.Forms.NumericUpDown nmQuantidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbProdutos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTipoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesignacaoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
    }
}