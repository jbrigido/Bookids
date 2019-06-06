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
            this.nrCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utilizouCartaoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.comprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detalheComprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalheComprasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.btEditarVenda.Click += new System.EventHandler(this.btEditarVenda_Click);
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
            this.gbCliente.Size = new System.Drawing.Size(531, 168);
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
            this.dgvVendas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvVendas_MouseClick);
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
            this.cbClientes.SelectedIndexChanged += new System.EventHandler(this.cbClientes_SelectedIndexChanged);
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
            // detalheComprasBindingSource
            // 
            this.detalheComprasBindingSource.DataSource = typeof(Bookids.DetalheCompras);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codProdutoDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.precoUnitario,
            this.subtotal});
            this.dataGridView1.DataSource = this.detalheComprasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(39, 203);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(450, 119);
            this.dataGridView1.TabIndex = 11;
            // 
            // codProdutoDataGridViewTextBoxColumn
            // 
            this.codProdutoDataGridViewTextBoxColumn.DataPropertyName = "CodProduto";
            this.codProdutoDataGridViewTextBoxColumn.HeaderText = "CodProduto";
            this.codProdutoDataGridViewTextBoxColumn.Name = "codProdutoDataGridViewTextBoxColumn";
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
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
            // FormVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 407);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbCliente);
            this.Name = "FormVendas";
            this.Text = "FormVendas";
            this.Load += new System.EventHandler(this.FormVendas_Load);
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalheComprasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
    }
}