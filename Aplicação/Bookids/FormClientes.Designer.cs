namespace Bookids
{
    partial class FormClientes
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
            this.btCriarCliente = new System.Windows.Forms.Button();
            this.btApagarCliente = new System.Windows.Forms.Button();
            this.btEditarCliente = new System.Windows.Forms.Button();
            this.gbFilhos = new System.Windows.Forms.GroupBox();
            this.btGuardarFilho = new System.Windows.Forms.Button();
            this.btEditarFilho = new System.Windows.Forms.Button();
            this.btApagarFilho = new System.Windows.Forms.Button();
            this.btAdicionarFilho = new System.Windows.Forms.Button();
            this.lbFilhos = new System.Windows.Forms.ListBox();
            this.tbTelemovelFilho = new System.Windows.Forms.TextBox();
            this.tbDtaNascimentoFilho = new System.Windows.Forms.TextBox();
            this.tbEscolaFilho = new System.Windows.Forms.TextBox();
            this.cbSexoFilho = new System.Windows.Forms.ComboBox();
            this.tbMoradaFilho = new System.Windows.Forms.TextBox();
            this.tbLocalidadeFilho = new System.Windows.Forms.TextBox();
            this.tbNifFilho = new System.Windows.Forms.TextBox();
            this.tbNomeFilho = new System.Windows.Forms.TextBox();
            this.gbClientes = new System.Windows.Forms.GroupBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.nrCartaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorOfertaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filhosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPessoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codPostalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telemovelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbFilhos.SuspendLayout();
            this.gbClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btCriarCliente
            // 
            this.btCriarCliente.Location = new System.Drawing.Point(6, 312);
            this.btCriarCliente.Name = "btCriarCliente";
            this.btCriarCliente.Size = new System.Drawing.Size(145, 23);
            this.btCriarCliente.TabIndex = 9;
            this.btCriarCliente.Text = "Criar Novo Cliente";
            this.btCriarCliente.UseVisualStyleBackColor = true;
            // 
            // btApagarCliente
            // 
            this.btApagarCliente.Location = new System.Drawing.Point(307, 312);
            this.btApagarCliente.Name = "btApagarCliente";
            this.btApagarCliente.Size = new System.Drawing.Size(142, 23);
            this.btApagarCliente.TabIndex = 10;
            this.btApagarCliente.Text = "Apagar Cliente";
            this.btApagarCliente.UseVisualStyleBackColor = true;
            // 
            // btEditarCliente
            // 
            this.btEditarCliente.Location = new System.Drawing.Point(157, 312);
            this.btEditarCliente.Name = "btEditarCliente";
            this.btEditarCliente.Size = new System.Drawing.Size(144, 23);
            this.btEditarCliente.TabIndex = 11;
            this.btEditarCliente.Text = "Editar Cliente";
            this.btEditarCliente.UseVisualStyleBackColor = true;
            // 
            // gbFilhos
            // 
            this.gbFilhos.Controls.Add(this.btGuardarFilho);
            this.gbFilhos.Controls.Add(this.btEditarFilho);
            this.gbFilhos.Controls.Add(this.btApagarFilho);
            this.gbFilhos.Controls.Add(this.btAdicionarFilho);
            this.gbFilhos.Controls.Add(this.lbFilhos);
            this.gbFilhos.Controls.Add(this.tbTelemovelFilho);
            this.gbFilhos.Controls.Add(this.tbDtaNascimentoFilho);
            this.gbFilhos.Controls.Add(this.tbEscolaFilho);
            this.gbFilhos.Controls.Add(this.cbSexoFilho);
            this.gbFilhos.Controls.Add(this.tbMoradaFilho);
            this.gbFilhos.Controls.Add(this.tbLocalidadeFilho);
            this.gbFilhos.Controls.Add(this.tbNifFilho);
            this.gbFilhos.Controls.Add(this.tbNomeFilho);
            this.gbFilhos.Location = new System.Drawing.Point(456, 19);
            this.gbFilhos.Name = "gbFilhos";
            this.gbFilhos.Size = new System.Drawing.Size(314, 316);
            this.gbFilhos.TabIndex = 12;
            this.gbFilhos.TabStop = false;
            this.gbFilhos.Text = "Filhos";
            // 
            // btGuardarFilho
            // 
            this.btGuardarFilho.Location = new System.Drawing.Point(212, 260);
            this.btGuardarFilho.Name = "btGuardarFilho";
            this.btGuardarFilho.Size = new System.Drawing.Size(86, 23);
            this.btGuardarFilho.TabIndex = 17;
            this.btGuardarFilho.Text = "Guardar Alterações";
            this.btGuardarFilho.UseVisualStyleBackColor = true;
            // 
            // btEditarFilho
            // 
            this.btEditarFilho.Location = new System.Drawing.Point(109, 231);
            this.btEditarFilho.Name = "btEditarFilho";
            this.btEditarFilho.Size = new System.Drawing.Size(97, 23);
            this.btEditarFilho.TabIndex = 16;
            this.btEditarFilho.Text = "Editar Filho";
            this.btEditarFilho.UseVisualStyleBackColor = true;
            // 
            // btApagarFilho
            // 
            this.btApagarFilho.Location = new System.Drawing.Point(212, 231);
            this.btApagarFilho.Name = "btApagarFilho";
            this.btApagarFilho.Size = new System.Drawing.Size(86, 23);
            this.btApagarFilho.TabIndex = 15;
            this.btApagarFilho.Text = "Apagar Filho";
            this.btApagarFilho.UseVisualStyleBackColor = true;
            // 
            // btAdicionarFilho
            // 
            this.btAdicionarFilho.Location = new System.Drawing.Point(17, 231);
            this.btAdicionarFilho.Name = "btAdicionarFilho";
            this.btAdicionarFilho.Size = new System.Drawing.Size(86, 23);
            this.btAdicionarFilho.TabIndex = 14;
            this.btAdicionarFilho.Text = "Adicionar Filho";
            this.btAdicionarFilho.UseVisualStyleBackColor = true;
            // 
            // lbFilhos
            // 
            this.lbFilhos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbFilhos.FormattingEnabled = true;
            this.lbFilhos.Location = new System.Drawing.Point(12, 19);
            this.lbFilhos.Name = "lbFilhos";
            this.lbFilhos.Size = new System.Drawing.Size(286, 95);
            this.lbFilhos.TabIndex = 13;
            // 
            // tbTelemovelFilho
            // 
            this.tbTelemovelFilho.Enabled = false;
            this.tbTelemovelFilho.Location = new System.Drawing.Point(18, 200);
            this.tbTelemovelFilho.Name = "tbTelemovelFilho";
            this.tbTelemovelFilho.Size = new System.Drawing.Size(99, 20);
            this.tbTelemovelFilho.TabIndex = 12;
            this.tbTelemovelFilho.Text = "Telemovel";
            // 
            // tbDtaNascimentoFilho
            // 
            this.tbDtaNascimentoFilho.Enabled = false;
            this.tbDtaNascimentoFilho.Location = new System.Drawing.Point(100, 147);
            this.tbDtaNascimentoFilho.Name = "tbDtaNascimentoFilho";
            this.tbDtaNascimentoFilho.Size = new System.Drawing.Size(103, 20);
            this.tbDtaNascimentoFilho.TabIndex = 11;
            this.tbDtaNascimentoFilho.Text = "Data de Nascimento";
            // 
            // tbEscolaFilho
            // 
            this.tbEscolaFilho.Enabled = false;
            this.tbEscolaFilho.Location = new System.Drawing.Point(123, 200);
            this.tbEscolaFilho.Name = "tbEscolaFilho";
            this.tbEscolaFilho.Size = new System.Drawing.Size(175, 20);
            this.tbEscolaFilho.TabIndex = 10;
            this.tbEscolaFilho.Text = "Escola do Fiho";
            // 
            // cbSexoFilho
            // 
            this.cbSexoFilho.Enabled = false;
            this.cbSexoFilho.FormattingEnabled = true;
            this.cbSexoFilho.Location = new System.Drawing.Point(209, 147);
            this.cbSexoFilho.Name = "cbSexoFilho";
            this.cbSexoFilho.Size = new System.Drawing.Size(89, 21);
            this.cbSexoFilho.TabIndex = 9;
            // 
            // tbMoradaFilho
            // 
            this.tbMoradaFilho.Enabled = false;
            this.tbMoradaFilho.Location = new System.Drawing.Point(17, 173);
            this.tbMoradaFilho.Name = "tbMoradaFilho";
            this.tbMoradaFilho.Size = new System.Drawing.Size(175, 20);
            this.tbMoradaFilho.TabIndex = 8;
            this.tbMoradaFilho.Text = "Morada Filho";
            // 
            // tbLocalidadeFilho
            // 
            this.tbLocalidadeFilho.Enabled = false;
            this.tbLocalidadeFilho.Location = new System.Drawing.Point(198, 174);
            this.tbLocalidadeFilho.Name = "tbLocalidadeFilho";
            this.tbLocalidadeFilho.Size = new System.Drawing.Size(100, 20);
            this.tbLocalidadeFilho.TabIndex = 7;
            this.tbLocalidadeFilho.Text = "Localidade";
            // 
            // tbNifFilho
            // 
            this.tbNifFilho.Enabled = false;
            this.tbNifFilho.Location = new System.Drawing.Point(17, 147);
            this.tbNifFilho.Name = "tbNifFilho";
            this.tbNifFilho.Size = new System.Drawing.Size(77, 20);
            this.tbNifFilho.TabIndex = 2;
            this.tbNifFilho.Text = "NIF do Filho";
            // 
            // tbNomeFilho
            // 
            this.tbNomeFilho.Enabled = false;
            this.tbNomeFilho.Location = new System.Drawing.Point(17, 121);
            this.tbNomeFilho.Name = "tbNomeFilho";
            this.tbNomeFilho.Size = new System.Drawing.Size(281, 20);
            this.tbNomeFilho.TabIndex = 1;
            this.tbNomeFilho.Text = "Nome do Fiho";
            // 
            // gbClientes
            // 
            this.gbClientes.Controls.Add(this.dgvClientes);
            this.gbClientes.Controls.Add(this.gbFilhos);
            this.gbClientes.Controls.Add(this.btCriarCliente);
            this.gbClientes.Controls.Add(this.btApagarCliente);
            this.gbClientes.Controls.Add(this.btEditarCliente);
            this.gbClientes.Location = new System.Drawing.Point(12, 12);
            this.gbClientes.Name = "gbClientes";
            this.gbClientes.Size = new System.Drawing.Size(785, 348);
            this.gbClientes.TabIndex = 13;
            this.gbClientes.TabStop = false;
            this.gbClientes.Text = "Clientes";
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AutoGenerateColumns = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nrCartaoDataGridViewTextBoxColumn,
            this.valorOfertaDataGridViewTextBoxColumn,
            this.filhosDataGridViewTextBoxColumn,
            this.comprasDataGridViewTextBoxColumn,
            this.idPessoaDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.moradaDataGridViewTextBoxColumn,
            this.localidadeDataGridViewTextBoxColumn,
            this.codPostalDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.telemovelDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn});
            this.dgvClientes.DataSource = this.clientesBindingSource;
            this.dgvClientes.Location = new System.Drawing.Point(7, 19);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(443, 283);
            this.dgvClientes.TabIndex = 13;
            // 
            // nrCartaoDataGridViewTextBoxColumn
            // 
            this.nrCartaoDataGridViewTextBoxColumn.DataPropertyName = "NrCartao";
            this.nrCartaoDataGridViewTextBoxColumn.HeaderText = "NrCartao";
            this.nrCartaoDataGridViewTextBoxColumn.Name = "nrCartaoDataGridViewTextBoxColumn";
            this.nrCartaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorOfertaDataGridViewTextBoxColumn
            // 
            this.valorOfertaDataGridViewTextBoxColumn.DataPropertyName = "ValorOferta";
            this.valorOfertaDataGridViewTextBoxColumn.HeaderText = "ValorOferta";
            this.valorOfertaDataGridViewTextBoxColumn.Name = "valorOfertaDataGridViewTextBoxColumn";
            this.valorOfertaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // filhosDataGridViewTextBoxColumn
            // 
            this.filhosDataGridViewTextBoxColumn.DataPropertyName = "Filhos";
            this.filhosDataGridViewTextBoxColumn.HeaderText = "Filhos";
            this.filhosDataGridViewTextBoxColumn.Name = "filhosDataGridViewTextBoxColumn";
            this.filhosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // comprasDataGridViewTextBoxColumn
            // 
            this.comprasDataGridViewTextBoxColumn.DataPropertyName = "Compras";
            this.comprasDataGridViewTextBoxColumn.HeaderText = "Compras";
            this.comprasDataGridViewTextBoxColumn.Name = "comprasDataGridViewTextBoxColumn";
            this.comprasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idPessoaDataGridViewTextBoxColumn
            // 
            this.idPessoaDataGridViewTextBoxColumn.DataPropertyName = "IdPessoa";
            this.idPessoaDataGridViewTextBoxColumn.HeaderText = "IdPessoa";
            this.idPessoaDataGridViewTextBoxColumn.Name = "idPessoaDataGridViewTextBoxColumn";
            this.idPessoaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moradaDataGridViewTextBoxColumn
            // 
            this.moradaDataGridViewTextBoxColumn.DataPropertyName = "Morada";
            this.moradaDataGridViewTextBoxColumn.HeaderText = "Morada";
            this.moradaDataGridViewTextBoxColumn.Name = "moradaDataGridViewTextBoxColumn";
            this.moradaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // localidadeDataGridViewTextBoxColumn
            // 
            this.localidadeDataGridViewTextBoxColumn.DataPropertyName = "Localidade";
            this.localidadeDataGridViewTextBoxColumn.HeaderText = "Localidade";
            this.localidadeDataGridViewTextBoxColumn.Name = "localidadeDataGridViewTextBoxColumn";
            this.localidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codPostalDataGridViewTextBoxColumn
            // 
            this.codPostalDataGridViewTextBoxColumn.DataPropertyName = "CodPostal";
            this.codPostalDataGridViewTextBoxColumn.HeaderText = "CodPostal";
            this.codPostalDataGridViewTextBoxColumn.Name = "codPostalDataGridViewTextBoxColumn";
            this.codPostalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telemovelDataGridViewTextBoxColumn
            // 
            this.telemovelDataGridViewTextBoxColumn.DataPropertyName = "Telemovel";
            this.telemovelDataGridViewTextBoxColumn.HeaderText = "Telemovel";
            this.telemovelDataGridViewTextBoxColumn.Name = "telemovelDataGridViewTextBoxColumn";
            this.telemovelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            this.mailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataSource = typeof(Bookids.Clientes);
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 372);
            this.Controls.Add(this.gbClientes);
            this.Name = "FormClientes";
            this.Text = "FormClientes";
            this.gbFilhos.ResumeLayout(false);
            this.gbFilhos.PerformLayout();
            this.gbClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btCriarCliente;
        private System.Windows.Forms.Button btApagarCliente;
        private System.Windows.Forms.Button btEditarCliente;
        private System.Windows.Forms.GroupBox gbFilhos;
        private System.Windows.Forms.ComboBox cbSexoFilho;
        private System.Windows.Forms.TextBox tbMoradaFilho;
        private System.Windows.Forms.TextBox tbLocalidadeFilho;
        private System.Windows.Forms.TextBox tbNifFilho;
        private System.Windows.Forms.TextBox tbNomeFilho;
        private System.Windows.Forms.Button btEditarFilho;
        private System.Windows.Forms.Button btApagarFilho;
        private System.Windows.Forms.Button btAdicionarFilho;
        private System.Windows.Forms.ListBox lbFilhos;
        private System.Windows.Forms.TextBox tbTelemovelFilho;
        private System.Windows.Forms.TextBox tbDtaNascimentoFilho;
        private System.Windows.Forms.TextBox tbEscolaFilho;
        private System.Windows.Forms.GroupBox gbClientes;
        private System.Windows.Forms.Button btGuardarFilho;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrCartaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorOfertaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filhosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPessoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codPostalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telemovelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clientesBindingSource;
    }
}