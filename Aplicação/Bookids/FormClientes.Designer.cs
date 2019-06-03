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
            this.dtpDataNascFilho = new System.Windows.Forms.DateTimePicker();
            this.cbEscolaFilho = new System.Windows.Forms.ComboBox();
            this.btGuardarFilho = new System.Windows.Forms.Button();
            this.dgvFilhos = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascicmentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filhosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btEditarFilho = new System.Windows.Forms.Button();
            this.btApagarFilho = new System.Windows.Forms.Button();
            this.btAdicionarFilho = new System.Windows.Forms.Button();
            this.cbSexoFilho = new System.Windows.Forms.ComboBox();
            this.tbNomeFilho = new System.Windows.Forms.TextBox();
            this.gbClientes = new System.Windows.Forms.GroupBox();
            this.btCancelClean = new System.Windows.Forms.Button();
            this.btGuardarCliente = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbTelefoneCli = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTelemovelCli = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCodPostalCli = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nmValorOferta = new System.Windows.Forms.NumericUpDown();
            this.tbNomeCli = new System.Windows.Forms.TextBox();
            this.tbLocalidadeCli = new System.Windows.Forms.TextBox();
            this.tbMailCli = new System.Windows.Forms.TextBox();
            this.tbCartaoCli = new System.Windows.Forms.TextBox();
            this.tbMoradaCli = new System.Windows.Forms.TextBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrCartaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorOfertaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codPostalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telemovelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbFilhos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilhos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filhosBindingSource)).BeginInit();
            this.gbClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmValorOferta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btCriarCliente
            // 
            this.btCriarCliente.Location = new System.Drawing.Point(29, 39);
            this.btCriarCliente.Name = "btCriarCliente";
            this.btCriarCliente.Size = new System.Drawing.Size(112, 23);
            this.btCriarCliente.TabIndex = 9;
            this.btCriarCliente.Text = "Adicionar Cliente";
            this.btCriarCliente.UseVisualStyleBackColor = true;
            this.btCriarCliente.Click += new System.EventHandler(this.btCriarCliente_Click);
            // 
            // btApagarCliente
            // 
            this.btApagarCliente.Location = new System.Drawing.Point(265, 39);
            this.btApagarCliente.Name = "btApagarCliente";
            this.btApagarCliente.Size = new System.Drawing.Size(112, 23);
            this.btApagarCliente.TabIndex = 10;
            this.btApagarCliente.Text = "Apagar Cliente";
            this.btApagarCliente.UseVisualStyleBackColor = true;
            // 
            // btEditarCliente
            // 
            this.btEditarCliente.Location = new System.Drawing.Point(147, 39);
            this.btEditarCliente.Name = "btEditarCliente";
            this.btEditarCliente.Size = new System.Drawing.Size(112, 23);
            this.btEditarCliente.TabIndex = 11;
            this.btEditarCliente.Text = "Editar Cliente";
            this.btEditarCliente.UseVisualStyleBackColor = true;
            // 
            // gbFilhos
            // 
            this.gbFilhos.Controls.Add(this.dtpDataNascFilho);
            this.gbFilhos.Controls.Add(this.cbEscolaFilho);
            this.gbFilhos.Controls.Add(this.btGuardarFilho);
            this.gbFilhos.Controls.Add(this.dgvFilhos);
            this.gbFilhos.Controls.Add(this.btEditarFilho);
            this.gbFilhos.Controls.Add(this.btApagarFilho);
            this.gbFilhos.Controls.Add(this.btAdicionarFilho);
            this.gbFilhos.Controls.Add(this.cbSexoFilho);
            this.gbFilhos.Controls.Add(this.tbNomeFilho);
            this.gbFilhos.Location = new System.Drawing.Point(560, 19);
            this.gbFilhos.Name = "gbFilhos";
            this.gbFilhos.Size = new System.Drawing.Size(396, 227);
            this.gbFilhos.TabIndex = 12;
            this.gbFilhos.TabStop = false;
            this.gbFilhos.Text = "Filhos";
            // 
            // dtpDataNascFilho
            // 
            this.dtpDataNascFilho.Location = new System.Drawing.Point(183, 166);
            this.dtpDataNascFilho.Name = "dtpDataNascFilho";
            this.dtpDataNascFilho.Size = new System.Drawing.Size(200, 20);
            this.dtpDataNascFilho.TabIndex = 45;
            // 
            // cbEscolaFilho
            // 
            this.cbEscolaFilho.FormattingEnabled = true;
            this.cbEscolaFilho.Location = new System.Drawing.Point(7, 165);
            this.cbEscolaFilho.Name = "cbEscolaFilho";
            this.cbEscolaFilho.Size = new System.Drawing.Size(172, 21);
            this.cbEscolaFilho.TabIndex = 20;
            // 
            // btGuardarFilho
            // 
            this.btGuardarFilho.Location = new System.Drawing.Point(297, 192);
            this.btGuardarFilho.Name = "btGuardarFilho";
            this.btGuardarFilho.Size = new System.Drawing.Size(86, 23);
            this.btGuardarFilho.TabIndex = 19;
            this.btGuardarFilho.Text = "Guardar ";
            this.btGuardarFilho.UseVisualStyleBackColor = true;
            // 
            // dgvFilhos
            // 
            this.dgvFilhos.AllowUserToAddRows = false;
            this.dgvFilhos.AllowUserToDeleteRows = false;
            this.dgvFilhos.AutoGenerateColumns = false;
            this.dgvFilhos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilhos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn1,
            this.sexoDataGridViewTextBoxColumn,
            this.dataNascicmentoDataGridViewTextBoxColumn});
            this.dgvFilhos.DataSource = this.filhosBindingSource;
            this.dgvFilhos.Location = new System.Drawing.Point(39, 20);
            this.dgvFilhos.MultiSelect = false;
            this.dgvFilhos.Name = "dgvFilhos";
            this.dgvFilhos.ReadOnly = true;
            this.dgvFilhos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFilhos.Size = new System.Drawing.Size(344, 109);
            this.dgvFilhos.TabIndex = 18;
            this.dgvFilhos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvFilhos_MouseClick);
            // 
            // nomeDataGridViewTextBoxColumn1
            // 
            this.nomeDataGridViewTextBoxColumn1.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn1.Name = "nomeDataGridViewTextBoxColumn1";
            this.nomeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            this.sexoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataNascicmentoDataGridViewTextBoxColumn
            // 
            this.dataNascicmentoDataGridViewTextBoxColumn.DataPropertyName = "DataNascicmento";
            this.dataNascicmentoDataGridViewTextBoxColumn.HeaderText = "DataNascicmento";
            this.dataNascicmentoDataGridViewTextBoxColumn.Name = "dataNascicmentoDataGridViewTextBoxColumn";
            this.dataNascicmentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // filhosBindingSource
            // 
            this.filhosBindingSource.DataSource = typeof(Bookids.Filhos);
            // 
            // btEditarFilho
            // 
            this.btEditarFilho.Location = new System.Drawing.Point(99, 192);
            this.btEditarFilho.Name = "btEditarFilho";
            this.btEditarFilho.Size = new System.Drawing.Size(97, 23);
            this.btEditarFilho.TabIndex = 16;
            this.btEditarFilho.Text = "Editar Filho";
            this.btEditarFilho.UseVisualStyleBackColor = true;
            // 
            // btApagarFilho
            // 
            this.btApagarFilho.Location = new System.Drawing.Point(205, 192);
            this.btApagarFilho.Name = "btApagarFilho";
            this.btApagarFilho.Size = new System.Drawing.Size(86, 23);
            this.btApagarFilho.TabIndex = 15;
            this.btApagarFilho.Text = "Apagar Filho";
            this.btApagarFilho.UseVisualStyleBackColor = true;
            // 
            // btAdicionarFilho
            // 
            this.btAdicionarFilho.Location = new System.Drawing.Point(7, 192);
            this.btAdicionarFilho.Name = "btAdicionarFilho";
            this.btAdicionarFilho.Size = new System.Drawing.Size(86, 23);
            this.btAdicionarFilho.TabIndex = 14;
            this.btAdicionarFilho.Text = "Adicionar Filho";
            this.btAdicionarFilho.UseVisualStyleBackColor = true;
            this.btAdicionarFilho.Click += new System.EventHandler(this.btAdicionarFilho_Click);
            // 
            // cbSexoFilho
            // 
            this.cbSexoFilho.FormattingEnabled = true;
            this.cbSexoFilho.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cbSexoFilho.Location = new System.Drawing.Point(294, 138);
            this.cbSexoFilho.Name = "cbSexoFilho";
            this.cbSexoFilho.Size = new System.Drawing.Size(89, 21);
            this.cbSexoFilho.TabIndex = 9;
            // 
            // tbNomeFilho
            // 
            this.tbNomeFilho.Location = new System.Drawing.Point(7, 138);
            this.tbNomeFilho.Name = "tbNomeFilho";
            this.tbNomeFilho.Size = new System.Drawing.Size(281, 20);
            this.tbNomeFilho.TabIndex = 1;
            this.tbNomeFilho.Text = "Nome do Fiho";
            // 
            // gbClientes
            // 
            this.gbClientes.Controls.Add(this.btCancelClean);
            this.gbClientes.Controls.Add(this.btGuardarCliente);
            this.gbClientes.Controls.Add(this.label9);
            this.gbClientes.Controls.Add(this.tbTelefoneCli);
            this.gbClientes.Controls.Add(this.label8);
            this.gbClientes.Controls.Add(this.tbTelemovelCli);
            this.gbClientes.Controls.Add(this.label7);
            this.gbClientes.Controls.Add(this.label6);
            this.gbClientes.Controls.Add(this.tbCodPostalCli);
            this.gbClientes.Controls.Add(this.label5);
            this.gbClientes.Controls.Add(this.label4);
            this.gbClientes.Controls.Add(this.label3);
            this.gbClientes.Controls.Add(this.label2);
            this.gbClientes.Controls.Add(this.label1);
            this.gbClientes.Controls.Add(this.nmValorOferta);
            this.gbClientes.Controls.Add(this.tbNomeCli);
            this.gbClientes.Controls.Add(this.tbLocalidadeCli);
            this.gbClientes.Controls.Add(this.tbMailCli);
            this.gbClientes.Controls.Add(this.tbCartaoCli);
            this.gbClientes.Controls.Add(this.tbMoradaCli);
            this.gbClientes.Controls.Add(this.dgvClientes);
            this.gbClientes.Controls.Add(this.gbFilhos);
            this.gbClientes.Controls.Add(this.btCriarCliente);
            this.gbClientes.Controls.Add(this.btApagarCliente);
            this.gbClientes.Controls.Add(this.btEditarCliente);
            this.gbClientes.Location = new System.Drawing.Point(12, 12);
            this.gbClientes.Name = "gbClientes";
            this.gbClientes.Size = new System.Drawing.Size(972, 518);
            this.gbClientes.TabIndex = 13;
            this.gbClientes.TabStop = false;
            this.gbClientes.Text = "Clientes";
            // 
            // btCancelClean
            // 
            this.btCancelClean.Location = new System.Drawing.Point(352, 211);
            this.btCancelClean.Name = "btCancelClean";
            this.btCancelClean.Size = new System.Drawing.Size(167, 23);
            this.btCancelClean.TabIndex = 45;
            this.btCancelClean.Text = "Cancelar/Limpar Alterações";
            this.btCancelClean.UseVisualStyleBackColor = true;
            this.btCancelClean.Click += new System.EventHandler(this.btCancelClean_Click);
            // 
            // btGuardarCliente
            // 
            this.btGuardarCliente.Location = new System.Drawing.Point(383, 39);
            this.btGuardarCliente.Name = "btGuardarCliente";
            this.btGuardarCliente.Size = new System.Drawing.Size(112, 23);
            this.btGuardarCliente.TabIndex = 44;
            this.btGuardarCliente.Text = "Guardar Alterações";
            this.btGuardarCliente.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(295, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "E-mail:";
            // 
            // tbTelefoneCli
            // 
            this.tbTelefoneCli.Location = new System.Drawing.Point(220, 180);
            this.tbTelefoneCli.Mask = "000 000 000";
            this.tbTelefoneCli.Name = "tbTelefoneCli";
            this.tbTelefoneCli.Size = new System.Drawing.Size(69, 20);
            this.tbTelefoneCli.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(162, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Telefone:";
            // 
            // tbTelemovelCli
            // 
            this.tbTelemovelCli.Location = new System.Drawing.Point(87, 180);
            this.tbTelemovelCli.Mask = "000 000 000";
            this.tbTelemovelCli.Name = "tbTelemovelCli";
            this.tbTelemovelCli.Size = new System.Drawing.Size(69, 20);
            this.tbTelemovelCli.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Telemóvel:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(206, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Localidade:";
            // 
            // tbCodPostalCli
            // 
            this.tbCodPostalCli.Location = new System.Drawing.Point(110, 154);
            this.tbCodPostalCli.Mask = "0000 - 000";
            this.tbCodPostalCli.Name = "tbCodPostalCli";
            this.tbCodPostalCli.Size = new System.Drawing.Size(61, 20);
            this.tbCodPostalCli.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Código Postal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Morada:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Valor Oferta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Cartão Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Nome:";
            // 
            // nmValorOferta
            // 
            this.nmValorOferta.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nmValorOferta.Location = new System.Drawing.Point(352, 102);
            this.nmValorOferta.Name = "nmValorOferta";
            this.nmValorOferta.Size = new System.Drawing.Size(120, 20);
            this.nmValorOferta.TabIndex = 31;
            this.nmValorOferta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbNomeCli
            // 
            this.tbNomeCli.Location = new System.Drawing.Point(73, 76);
            this.tbNomeCli.Name = "tbNomeCli";
            this.tbNomeCli.Size = new System.Drawing.Size(399, 20);
            this.tbNomeCli.TabIndex = 22;
            // 
            // tbLocalidadeCli
            // 
            this.tbLocalidadeCli.Location = new System.Drawing.Point(274, 154);
            this.tbLocalidadeCli.Name = "tbLocalidadeCli";
            this.tbLocalidadeCli.Size = new System.Drawing.Size(198, 20);
            this.tbLocalidadeCli.TabIndex = 28;
            // 
            // tbMailCli
            // 
            this.tbMailCli.Location = new System.Drawing.Point(339, 180);
            this.tbMailCli.Name = "tbMailCli";
            this.tbMailCli.Size = new System.Drawing.Size(133, 20);
            this.tbMailCli.TabIndex = 29;
            // 
            // tbCartaoCli
            // 
            this.tbCartaoCli.Location = new System.Drawing.Point(114, 102);
            this.tbCartaoCli.Name = "tbCartaoCli";
            this.tbCartaoCli.Size = new System.Drawing.Size(73, 20);
            this.tbCartaoCli.TabIndex = 30;
            // 
            // tbMoradaCli
            // 
            this.tbMoradaCli.Location = new System.Drawing.Point(81, 128);
            this.tbMoradaCli.Name = "tbMoradaCli";
            this.tbMoradaCli.Size = new System.Drawing.Size(391, 20);
            this.tbMoradaCli.TabIndex = 24;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AutoGenerateColumns = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.nrCartaoDataGridViewTextBoxColumn,
            this.valorOfertaDataGridViewTextBoxColumn,
            this.moradaDataGridViewTextBoxColumn,
            this.localidadeDataGridViewTextBoxColumn,
            this.codPostalDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.telemovelDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn});
            this.dgvClientes.DataSource = this.clientesBindingSource;
            this.dgvClientes.Location = new System.Drawing.Point(12, 252);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(944, 247);
            this.dgvClientes.TabIndex = 13;
            this.dgvClientes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvClientes_MouseClick);
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.ClientSize = new System.Drawing.Size(996, 537);
            this.Controls.Add(this.gbClientes);
            this.Name = "FormClientes";
            this.Text = "FormClientes";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            this.gbFilhos.ResumeLayout(false);
            this.gbFilhos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilhos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filhosBindingSource)).EndInit();
            this.gbClientes.ResumeLayout(false);
            this.gbClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmValorOferta)).EndInit();
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
        private System.Windows.Forms.TextBox tbNomeFilho;
        private System.Windows.Forms.Button btEditarFilho;
        private System.Windows.Forms.Button btApagarFilho;
        private System.Windows.Forms.Button btAdicionarFilho;
        private System.Windows.Forms.GroupBox gbClientes;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private System.Windows.Forms.DataGridView dgvFilhos;
        private System.Windows.Forms.BindingSource filhosBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmValorOferta;
        private System.Windows.Forms.TextBox tbNomeCli;
        private System.Windows.Forms.TextBox tbLocalidadeCli;
        private System.Windows.Forms.TextBox tbMailCli;
        private System.Windows.Forms.TextBox tbCartaoCli;
        private System.Windows.Forms.TextBox tbMoradaCli;
        private System.Windows.Forms.Button btGuardarFilho;
        private System.Windows.Forms.Button btGuardarCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox tbTelefoneCli;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox tbTelemovelCli;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox tbCodPostalCli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbEscolaFilho;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrCartaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorOfertaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codPostalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telemovelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascicmentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dtpDataNascFilho;
        private System.Windows.Forms.Button btCancelClean;
    }
}