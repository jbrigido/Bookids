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
            this.checkBoxUtilizouCartao = new System.Windows.Forms.CheckBox();
            this.tbValorOferta = new System.Windows.Forms.TextBox();
            this.dgvVendas = new System.Windows.Forms.DataGridView();
            this.nrCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btCancelCleanVenda = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNrCartao = new System.Windows.Forms.TextBox();
            this.cbClientes = new System.Windows.Forms.ComboBox();
            this.gbProdutos = new System.Windows.Forms.GroupBox();
            this.btAdicionarProduto = new System.Windows.Forms.Button();
            this.nmQuantidade = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.lbProdutos = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTipoProduto = new System.Windows.Forms.ComboBox();
            this.gbDetalhes = new System.Windows.Forms.GroupBox();
            this.btExportar = new System.Windows.Forms.Button();
            this.labelTotalCompra = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btRemoverDetalhe = new System.Windows.Forms.Button();
            this.lbListaDetalhes = new System.Windows.Forms.ListBox();
            this.labelNomeForm = new System.Windows.Forms.Label();
            this.saveFileDialogExportar = new System.Windows.Forms.SaveFileDialog();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detalheComprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).BeginInit();
            this.gbProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantidade)).BeginInit();
            this.gbDetalhes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalheComprasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btApagarVenda
            // 
            this.btApagarVenda.Location = new System.Drawing.Point(12, 151);
            this.btApagarVenda.Name = "btApagarVenda";
            this.btApagarVenda.Size = new System.Drawing.Size(154, 23);
            this.btApagarVenda.TabIndex = 8;
            this.btApagarVenda.Text = "Apagar Venda";
            this.btApagarVenda.UseVisualStyleBackColor = true;
            this.btApagarVenda.Click += new System.EventHandler(this.btApagarVenda_Click);
            // 
            // btEditarVenda
            // 
            this.btEditarVenda.Location = new System.Drawing.Point(12, 122);
            this.btEditarVenda.Name = "btEditarVenda";
            this.btEditarVenda.Size = new System.Drawing.Size(154, 23);
            this.btEditarVenda.TabIndex = 7;
            this.btEditarVenda.Text = "Editar Venda";
            this.btEditarVenda.UseVisualStyleBackColor = true;
            this.btEditarVenda.Click += new System.EventHandler(this.btEditarVenda_Click);
            // 
            // btRegistarVenda
            // 
            this.btRegistarVenda.Location = new System.Drawing.Point(12, 93);
            this.btRegistarVenda.Name = "btRegistarVenda";
            this.btRegistarVenda.Size = new System.Drawing.Size(154, 23);
            this.btRegistarVenda.TabIndex = 6;
            this.btRegistarVenda.Text = "Registar Venda";
            this.btRegistarVenda.UseVisualStyleBackColor = true;
            this.btRegistarVenda.Click += new System.EventHandler(this.btRegistarVenda_Click);
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.checkBoxUtilizouCartao);
            this.gbCliente.Controls.Add(this.tbValorOferta);
            this.gbCliente.Controls.Add(this.dgvVendas);
            this.gbCliente.Controls.Add(this.btCancelCleanVenda);
            this.gbCliente.Controls.Add(this.label3);
            this.gbCliente.Controls.Add(this.label2);
            this.gbCliente.Controls.Add(this.label1);
            this.gbCliente.Controls.Add(this.tbNrCartao);
            this.gbCliente.Controls.Add(this.cbClientes);
            this.gbCliente.Controls.Add(this.btRegistarVenda);
            this.gbCliente.Controls.Add(this.btEditarVenda);
            this.gbCliente.Controls.Add(this.btApagarVenda);
            this.gbCliente.Location = new System.Drawing.Point(12, 71);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(528, 232);
            this.gbCliente.TabIndex = 10;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Dados Cliente";
            // 
            // checkBoxUtilizouCartao
            // 
            this.checkBoxUtilizouCartao.AutoSize = true;
            this.checkBoxUtilizouCartao.Checked = true;
            this.checkBoxUtilizouCartao.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxUtilizouCartao.Enabled = false;
            this.checkBoxUtilizouCartao.Location = new System.Drawing.Point(25, 70);
            this.checkBoxUtilizouCartao.Name = "checkBoxUtilizouCartao";
            this.checkBoxUtilizouCartao.Size = new System.Drawing.Size(129, 17);
            this.checkBoxUtilizouCartao.TabIndex = 18;
            this.checkBoxUtilizouCartao.Text = "Utilizou Cartão Cliente";
            this.checkBoxUtilizouCartao.UseVisualStyleBackColor = true;
            // 
            // tbValorOferta
            // 
            this.tbValorOferta.Enabled = false;
            this.tbValorOferta.Location = new System.Drawing.Point(81, 47);
            this.tbValorOferta.Name = "tbValorOferta";
            this.tbValorOferta.Size = new System.Drawing.Size(85, 20);
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
            this.TotalCompra});
            this.dgvVendas.DataSource = this.comprasBindingSource;
            this.dgvVendas.Location = new System.Drawing.Point(176, 47);
            this.dgvVendas.Name = "dgvVendas";
            this.dgvVendas.ReadOnly = true;
            this.dgvVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVendas.Size = new System.Drawing.Size(346, 156);
            this.dgvVendas.TabIndex = 16;
            this.dgvVendas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvVendas_MouseClick);
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
            // TotalCompra
            // 
            this.TotalCompra.HeaderText = "Total";
            this.TotalCompra.Name = "TotalCompra";
            this.TotalCompra.ReadOnly = true;
            // 
            // comprasBindingSource
            // 
            this.comprasBindingSource.DataSource = typeof(Bookids.Compras);
            // 
            // btCancelCleanVenda
            // 
            this.btCancelCleanVenda.Location = new System.Drawing.Point(12, 180);
            this.btCancelCleanVenda.Name = "btCancelCleanVenda";
            this.btCancelCleanVenda.Size = new System.Drawing.Size(154, 23);
            this.btCancelCleanVenda.TabIndex = 16;
            this.btCancelCleanVenda.Text = "Cancelar/Limpar Alterações";
            this.btCancelCleanVenda.UseVisualStyleBackColor = true;
            this.btCancelCleanVenda.Click += new System.EventHandler(this.btCancelCleanVenda_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor Oferta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nº Cartão:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cliente:";
            // 
            // tbNrCartao
            // 
            this.tbNrCartao.Enabled = false;
            this.tbNrCartao.Location = new System.Drawing.Point(444, 14);
            this.tbNrCartao.Name = "tbNrCartao";
            this.tbNrCartao.Size = new System.Drawing.Size(84, 20);
            this.tbNrCartao.TabIndex = 3;
            // 
            // cbClientes
            // 
            this.cbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Location = new System.Drawing.Point(57, 13);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(310, 21);
            this.cbClientes.TabIndex = 0;
            this.cbClientes.SelectedIndexChanged += new System.EventHandler(this.cbClientes_SelectedIndexChanged);
            // 
            // gbProdutos
            // 
            this.gbProdutos.Controls.Add(this.btAdicionarProduto);
            this.gbProdutos.Controls.Add(this.nmQuantidade);
            this.gbProdutos.Controls.Add(this.label6);
            this.gbProdutos.Controls.Add(this.lbProdutos);
            this.gbProdutos.Controls.Add(this.label5);
            this.gbProdutos.Controls.Add(this.cbTipoProduto);
            this.gbProdutos.Location = new System.Drawing.Point(282, 309);
            this.gbProdutos.Name = "gbProdutos";
            this.gbProdutos.Size = new System.Drawing.Size(258, 230);
            this.gbProdutos.TabIndex = 13;
            this.gbProdutos.TabStop = false;
            this.gbProdutos.Text = "Produtos";
            // 
            // btAdicionarProduto
            // 
            this.btAdicionarProduto.Location = new System.Drawing.Point(138, 199);
            this.btAdicionarProduto.Name = "btAdicionarProduto";
            this.btAdicionarProduto.Size = new System.Drawing.Size(109, 23);
            this.btAdicionarProduto.TabIndex = 29;
            this.btAdicionarProduto.Text = "Adicionar à Lista";
            this.btAdicionarProduto.UseVisualStyleBackColor = true;
            this.btAdicionarProduto.Click += new System.EventHandler(this.btAdicionarProduto_Click);
            // 
            // nmQuantidade
            // 
            this.nmQuantidade.Location = new System.Drawing.Point(88, 200);
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
            this.nmQuantidade.Size = new System.Drawing.Size(46, 20);
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
            this.label6.Location = new System.Drawing.Point(17, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Quantidade:";
            // 
            // lbProdutos
            // 
            this.lbProdutos.FormattingEnabled = true;
            this.lbProdutos.Location = new System.Drawing.Point(20, 59);
            this.lbProdutos.Name = "lbProdutos";
            this.lbProdutos.Size = new System.Drawing.Size(227, 134);
            this.lbProdutos.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Selecionar o tipo de Produto:";
            // 
            // cbTipoProduto
            // 
            this.cbTipoProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoProduto.FormattingEnabled = true;
            this.cbTipoProduto.Location = new System.Drawing.Point(20, 32);
            this.cbTipoProduto.Name = "cbTipoProduto";
            this.cbTipoProduto.Size = new System.Drawing.Size(227, 21);
            this.cbTipoProduto.TabIndex = 25;
            this.cbTipoProduto.SelectedIndexChanged += new System.EventHandler(this.cbTipoProduto_SelectedIndexChanged);
            // 
            // gbDetalhes
            // 
            this.gbDetalhes.Controls.Add(this.btExportar);
            this.gbDetalhes.Controls.Add(this.labelTotalCompra);
            this.gbDetalhes.Controls.Add(this.label4);
            this.gbDetalhes.Controls.Add(this.btRemoverDetalhe);
            this.gbDetalhes.Controls.Add(this.lbListaDetalhes);
            this.gbDetalhes.Location = new System.Drawing.Point(12, 309);
            this.gbDetalhes.Name = "gbDetalhes";
            this.gbDetalhes.Size = new System.Drawing.Size(258, 230);
            this.gbDetalhes.TabIndex = 30;
            this.gbDetalhes.TabStop = false;
            this.gbDetalhes.Text = "Lista de Compras";
            // 
            // btExportar
            // 
            this.btExportar.Location = new System.Drawing.Point(12, 19);
            this.btExportar.Name = "btExportar";
            this.btExportar.Size = new System.Drawing.Size(232, 23);
            this.btExportar.TabIndex = 15;
            this.btExportar.Text = "Exportar Fatura";
            this.btExportar.UseVisualStyleBackColor = true;
            this.btExportar.Click += new System.EventHandler(this.btExportar_Click);
            // 
            // labelTotalCompra
            // 
            this.labelTotalCompra.AutoSize = true;
            this.labelTotalCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalCompra.Location = new System.Drawing.Point(168, 172);
            this.labelTotalCompra.Name = "labelTotalCompra";
            this.labelTotalCompra.Size = new System.Drawing.Size(0, 24);
            this.labelTotalCompra.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Total:";
            // 
            // btRemoverDetalhe
            // 
            this.btRemoverDetalhe.Location = new System.Drawing.Point(12, 199);
            this.btRemoverDetalhe.Name = "btRemoverDetalhe";
            this.btRemoverDetalhe.Size = new System.Drawing.Size(232, 23);
            this.btRemoverDetalhe.TabIndex = 3;
            this.btRemoverDetalhe.Text = "Remover da Lista";
            this.btRemoverDetalhe.UseVisualStyleBackColor = true;
            this.btRemoverDetalhe.Click += new System.EventHandler(this.btRemoverDetalhe_Click);
            // 
            // lbListaDetalhes
            // 
            this.lbListaDetalhes.FormattingEnabled = true;
            this.lbListaDetalhes.Location = new System.Drawing.Point(12, 48);
            this.lbListaDetalhes.Name = "lbListaDetalhes";
            this.lbListaDetalhes.Size = new System.Drawing.Size(232, 121);
            this.lbListaDetalhes.TabIndex = 0;
            // 
            // labelNomeForm
            // 
            this.labelNomeForm.AutoSize = true;
            this.labelNomeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F);
            this.labelNomeForm.Location = new System.Drawing.Point(9, 9);
            this.labelNomeForm.Name = "labelNomeForm";
            this.labelNomeForm.Size = new System.Drawing.Size(197, 59);
            this.labelNomeForm.TabIndex = 31;
            this.labelNomeForm.Text = "Vendas";
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataSource = typeof(Bookids.Produtos);
            // 
            // detalheComprasBindingSource
            // 
            this.detalheComprasBindingSource.DataSource = typeof(Bookids.DetalheCompras);
            // 
            // FormVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 551);
            this.Controls.Add(this.labelNomeForm);
            this.Controls.Add(this.gbProdutos);
            this.Controls.Add(this.gbDetalhes);
            this.Controls.Add(this.gbCliente);
            this.Name = "FormVendas";
            this.ShowIcon = false;
            this.Text = "Bookids - Gestão de Vendas";
            this.Load += new System.EventHandler(this.FormVendas_Load);
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).EndInit();
            this.gbProdutos.ResumeLayout(false);
            this.gbProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantidade)).EndInit();
            this.gbDetalhes.ResumeLayout(false);
            this.gbDetalhes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalheComprasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.BindingSource comprasBindingSource;
        private System.Windows.Forms.TextBox tbValorOferta;
        private System.Windows.Forms.GroupBox gbProdutos;
        private System.Windows.Forms.Button btAdicionarProduto;
        private System.Windows.Forms.NumericUpDown nmQuantidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbProdutos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTipoProduto;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private System.Windows.Forms.BindingSource detalheComprasBindingSource;
        private System.Windows.Forms.GroupBox gbDetalhes;
        private System.Windows.Forms.Button btRemoverDetalhe;
        private System.Windows.Forms.ListBox lbListaDetalhes;
        private System.Windows.Forms.Label labelNomeForm;
        private System.Windows.Forms.CheckBox checkBoxUtilizouCartao;
        private System.Windows.Forms.Label labelTotalCompra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCompra;
        private System.Windows.Forms.Button btExportar;
        private System.Windows.Forms.SaveFileDialog saveFileDialogExportar;
    }
}