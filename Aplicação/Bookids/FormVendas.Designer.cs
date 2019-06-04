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
            this.btGuardarVenda = new System.Windows.Forms.Button();
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
            this.checkCartaoCliente = new System.Windows.Forms.CheckBox();
            this.lbDetalhesVenda = new System.Windows.Forms.ListBox();
            this.gbDetalhesVenda = new System.Windows.Forms.GroupBox();
            this.btRemoverProduto = new System.Windows.Forms.Button();
            this.btAdicionarProduto = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.lbProdutos = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTipoProduto = new System.Windows.Forms.ComboBox();
            this.dtpDataVenda = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.nrCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utilizouCartaoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.comprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
            this.gbDetalhesVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btGuardarVenda
            // 
            this.btGuardarVenda.Location = new System.Drawing.Point(6, 77);
            this.btGuardarVenda.Name = "btGuardarVenda";
            this.btGuardarVenda.Size = new System.Drawing.Size(148, 23);
            this.btGuardarVenda.TabIndex = 9;
            this.btGuardarVenda.Text = "Guardar Alterações";
            this.btGuardarVenda.UseVisualStyleBackColor = true;
            // 
            // btApagarVenda
            // 
            this.btApagarVenda.Location = new System.Drawing.Point(6, 106);
            this.btApagarVenda.Name = "btApagarVenda";
            this.btApagarVenda.Size = new System.Drawing.Size(148, 23);
            this.btApagarVenda.TabIndex = 8;
            this.btApagarVenda.Text = "Apagar Venda";
            this.btApagarVenda.UseVisualStyleBackColor = true;
            // 
            // btEditarVenda
            // 
            this.btEditarVenda.Location = new System.Drawing.Point(6, 48);
            this.btEditarVenda.Name = "btEditarVenda";
            this.btEditarVenda.Size = new System.Drawing.Size(148, 23);
            this.btEditarVenda.TabIndex = 7;
            this.btEditarVenda.Text = "Editar Venda";
            this.btEditarVenda.UseVisualStyleBackColor = true;
            // 
            // btRegistarVenda
            // 
            this.btRegistarVenda.Location = new System.Drawing.Point(6, 19);
            this.btRegistarVenda.Name = "btRegistarVenda";
            this.btRegistarVenda.Size = new System.Drawing.Size(148, 23);
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
            this.gbCliente.Size = new System.Drawing.Size(529, 168);
            this.gbCliente.TabIndex = 10;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Dados Cliente";
            // 
            // tbValorOferta
            // 
            this.tbValorOferta.Enabled = false;
            this.tbValorOferta.Location = new System.Drawing.Point(456, 50);
            this.tbValorOferta.Name = "tbValorOferta";
            this.tbValorOferta.Size = new System.Drawing.Size(64, 20);
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
            this.dgvVendas.Location = new System.Drawing.Point(176, 77);
            this.dgvVendas.Name = "dgvVendas";
            this.dgvVendas.ReadOnly = true;
            this.dgvVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVendas.Size = new System.Drawing.Size(344, 81);
            this.dgvVendas.TabIndex = 16;
            // 
            // btCancelCleanVenda
            // 
            this.btCancelCleanVenda.Location = new System.Drawing.Point(6, 135);
            this.btCancelCleanVenda.Name = "btCancelCleanVenda";
            this.btCancelCleanVenda.Size = new System.Drawing.Size(148, 23);
            this.btCancelCleanVenda.TabIndex = 16;
            this.btCancelCleanVenda.Text = "Cancelar/Limpar Alterações";
            this.btCancelCleanVenda.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor Oferta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cartão Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome Cliente:";
            // 
            // tbNrCartao
            // 
            this.tbNrCartao.Enabled = false;
            this.tbNrCartao.Location = new System.Drawing.Point(255, 51);
            this.tbNrCartao.Name = "tbNrCartao";
            this.tbNrCartao.Size = new System.Drawing.Size(64, 20);
            this.tbNrCartao.TabIndex = 3;
            // 
            // cbClientes
            // 
            this.cbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Location = new System.Drawing.Point(255, 19);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(265, 21);
            this.cbClientes.TabIndex = 0;
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
            // lbDetalhesVenda
            // 
            this.lbDetalhesVenda.FormattingEnabled = true;
            this.lbDetalhesVenda.Location = new System.Drawing.Point(10, 43);
            this.lbDetalhesVenda.Name = "lbDetalhesVenda";
            this.lbDetalhesVenda.Size = new System.Drawing.Size(177, 160);
            this.lbDetalhesVenda.TabIndex = 15;
            // 
            // gbDetalhesVenda
            // 
            this.gbDetalhesVenda.Controls.Add(this.btRemoverProduto);
            this.gbDetalhesVenda.Controls.Add(this.btAdicionarProduto);
            this.gbDetalhesVenda.Controls.Add(this.numericUpDown1);
            this.gbDetalhesVenda.Controls.Add(this.label6);
            this.gbDetalhesVenda.Controls.Add(this.lbProdutos);
            this.gbDetalhesVenda.Controls.Add(this.label5);
            this.gbDetalhesVenda.Controls.Add(this.cbTipoProduto);
            this.gbDetalhesVenda.Controls.Add(this.dtpDataVenda);
            this.gbDetalhesVenda.Controls.Add(this.lbDetalhesVenda);
            this.gbDetalhesVenda.Controls.Add(this.checkCartaoCliente);
            this.gbDetalhesVenda.Controls.Add(this.label4);
            this.gbDetalhesVenda.Location = new System.Drawing.Point(12, 187);
            this.gbDetalhesVenda.Name = "gbDetalhesVenda";
            this.gbDetalhesVenda.Size = new System.Drawing.Size(529, 214);
            this.gbDetalhesVenda.TabIndex = 16;
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
            // 
            // btAdicionarProduto
            // 
            this.btAdicionarProduto.Location = new System.Drawing.Point(196, 119);
            this.btAdicionarProduto.Name = "btAdicionarProduto";
            this.btAdicionarProduto.Size = new System.Drawing.Size(141, 23);
            this.btAdicionarProduto.TabIndex = 22;
            this.btAdicionarProduto.Text = "Adicionar à Lista";
            this.btAdicionarProduto.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(265, 81);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(72, 20);
            this.numericUpDown1.TabIndex = 21;
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
            this.dtpDataVenda.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataVenda.Location = new System.Drawing.Point(100, 17);
            this.dtpDataVenda.Name = "dtpDataVenda";
            this.dtpDataVenda.Size = new System.Drawing.Size(168, 20);
            this.dtpDataVenda.TabIndex = 17;
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
            this.ClientSize = new System.Drawing.Size(796, 407);
            this.Controls.Add(this.gbDetalhesVenda);
            this.Controls.Add(this.gbCliente);
            this.Name = "FormVendas";
            this.Text = "FormVendas";
            this.Load += new System.EventHandler(this.FormVendas_Load);
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            this.gbDetalhesVenda.ResumeLayout(false);
            this.gbDetalhesVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btGuardarVenda;
        private System.Windows.Forms.Button btApagarVenda;
        private System.Windows.Forms.Button btEditarVenda;
        private System.Windows.Forms.Button btRegistarVenda;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.ComboBox cbClientes;
        private System.Windows.Forms.TextBox tbNrCartao;
        private System.Windows.Forms.CheckBox checkCartaoCliente;
        private System.Windows.Forms.ListBox lbDetalhesVenda;
        private System.Windows.Forms.Button btCancelCleanVenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvVendas;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn utilizouCartaoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource comprasBindingSource;
        private System.Windows.Forms.GroupBox gbDetalhesVenda;
        private System.Windows.Forms.DateTimePicker dtpDataVenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbValorOferta;
        private System.Windows.Forms.ComboBox cbTipoProduto;
        private System.Windows.Forms.Button btRemoverProduto;
        private System.Windows.Forms.Button btAdicionarProduto;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbProdutos;
        private System.Windows.Forms.Label label5;
    }
}