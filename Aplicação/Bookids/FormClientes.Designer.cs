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
            this.btAdicionarClientes = new System.Windows.Forms.Button();
            this.btApagarClientes = new System.Windows.Forms.Button();
            this.btEditarClientes = new System.Windows.Forms.Button();
            this.gbFilhos = new System.Windows.Forms.GroupBox();
            this.btCancelCleanFilhos = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpDataNascFilho = new System.Windows.Forms.DateTimePicker();
            this.cbEscolaFilho = new System.Windows.Forms.ComboBox();
            this.btGuardarFilhos = new System.Windows.Forms.Button();
            this.dgvFilhos = new System.Windows.Forms.DataGridView();
            this.cbSexoFilho = new System.Windows.Forms.ComboBox();
            this.tbNomeFilho = new System.Windows.Forms.TextBox();
            this.btEditarFilhos = new System.Windows.Forms.Button();
            this.btAdicionarFilhos = new System.Windows.Forms.Button();
            this.btApagarFilhos = new System.Windows.Forms.Button();
            this.gbClientes = new System.Windows.Forms.GroupBox();
            this.btCancelCleanClientes = new System.Windows.Forms.Button();
            this.btGuardarClientes = new System.Windows.Forms.Button();
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
            this.nomeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascicmentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filhosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbFilhos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilhos)).BeginInit();
            this.gbClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmValorOferta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filhosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btAdicionarClientes
            // 
            this.btAdicionarClientes.Location = new System.Drawing.Point(29, 39);
            this.btAdicionarClientes.Name = "btAdicionarClientes";
            this.btAdicionarClientes.Size = new System.Drawing.Size(112, 23);
            this.btAdicionarClientes.TabIndex = 9;
            this.btAdicionarClientes.Text = "Adicionar Cliente";
            this.btAdicionarClientes.UseVisualStyleBackColor = true;
            this.btAdicionarClientes.Click += new System.EventHandler(this.btAdicionarClientes_Click);
            // 
            // btApagarClientes
            // 
            this.btApagarClientes.Location = new System.Drawing.Point(383, 39);
            this.btApagarClientes.Name = "btApagarClientes";
            this.btApagarClientes.Size = new System.Drawing.Size(112, 23);
            this.btApagarClientes.TabIndex = 10;
            this.btApagarClientes.Text = "Apagar Cliente";
            this.btApagarClientes.UseVisualStyleBackColor = true;
            this.btApagarClientes.Click += new System.EventHandler(this.btApagarClientes_Click);
            // 
            // btEditarClientes
            // 
            this.btEditarClientes.Location = new System.Drawing.Point(147, 39);
            this.btEditarClientes.Name = "btEditarClientes";
            this.btEditarClientes.Size = new System.Drawing.Size(112, 23);
            this.btEditarClientes.TabIndex = 11;
            this.btEditarClientes.Text = "Editar Cliente";
            this.btEditarClientes.UseVisualStyleBackColor = true;
            this.btEditarClientes.Click += new System.EventHandler(this.btEditarClientes_Click);
            // 
            // gbFilhos
            // 
            this.gbFilhos.Controls.Add(this.btCancelCleanFilhos);
            this.gbFilhos.Controls.Add(this.label13);
            this.gbFilhos.Controls.Add(this.label12);
            this.gbFilhos.Controls.Add(this.label11);
            this.gbFilhos.Controls.Add(this.label10);
            this.gbFilhos.Controls.Add(this.dtpDataNascFilho);
            this.gbFilhos.Controls.Add(this.cbEscolaFilho);
            this.gbFilhos.Controls.Add(this.btGuardarFilhos);
            this.gbFilhos.Controls.Add(this.dgvFilhos);
            this.gbFilhos.Controls.Add(this.cbSexoFilho);
            this.gbFilhos.Controls.Add(this.tbNomeFilho);
            this.gbFilhos.Controls.Add(this.btEditarFilhos);
            this.gbFilhos.Controls.Add(this.btAdicionarFilhos);
            this.gbFilhos.Controls.Add(this.btApagarFilhos);
            this.gbFilhos.Location = new System.Drawing.Point(501, 19);
            this.gbFilhos.Name = "gbFilhos";
            this.gbFilhos.Size = new System.Drawing.Size(487, 215);
            this.gbFilhos.TabIndex = 12;
            this.gbFilhos.TabStop = false;
            this.gbFilhos.Text = "Filhos";
            // 
            // btCancelCleanFilhos
            // 
            this.btCancelCleanFilhos.Location = new System.Drawing.Point(307, 186);
            this.btCancelCleanFilhos.Name = "btCancelCleanFilhos";
            this.btCancelCleanFilhos.Size = new System.Drawing.Size(167, 23);
            this.btCancelCleanFilhos.TabIndex = 45;
            this.btCancelCleanFilhos.Text = "Cancelar/Limpar Alterações";
            this.btCancelCleanFilhos.UseVisualStyleBackColor = true;
            this.btCancelCleanFilhos.Click += new System.EventHandler(this.btCancelCleanFilhos_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(28, 193);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 13);
            this.label13.TabIndex = 49;
            this.label13.Text = "Data de Nascimento:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(177, 164);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 48;
            this.label12.Text = "Escola:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 47;
            this.label11.Text = "Sexo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "Nome:";
            // 
            // dtpDataNascFilho
            // 
            this.dtpDataNascFilho.Location = new System.Drawing.Point(141, 187);
            this.dtpDataNascFilho.Name = "dtpDataNascFilho";
            this.dtpDataNascFilho.Size = new System.Drawing.Size(160, 20);
            this.dtpDataNascFilho.TabIndex = 45;
            // 
            // cbEscolaFilho
            // 
            this.cbEscolaFilho.FormattingEnabled = true;
            this.cbEscolaFilho.Location = new System.Drawing.Point(225, 160);
            this.cbEscolaFilho.Name = "cbEscolaFilho";
            this.cbEscolaFilho.Size = new System.Drawing.Size(249, 21);
            this.cbEscolaFilho.TabIndex = 20;
            // 
            // btGuardarFilhos
            // 
            this.btGuardarFilhos.Location = new System.Drawing.Point(15, 102);
            this.btGuardarFilhos.Name = "btGuardarFilhos";
            this.btGuardarFilhos.Size = new System.Drawing.Size(109, 23);
            this.btGuardarFilhos.TabIndex = 19;
            this.btGuardarFilhos.Text = "Guardar Alterações";
            this.btGuardarFilhos.UseVisualStyleBackColor = true;
            this.btGuardarFilhos.Click += new System.EventHandler(this.btGuardarFilhos_Click);
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
            this.dgvFilhos.Location = new System.Drawing.Point(130, 15);
            this.dgvFilhos.MultiSelect = false;
            this.dgvFilhos.Name = "dgvFilhos";
            this.dgvFilhos.ReadOnly = true;
            this.dgvFilhos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFilhos.Size = new System.Drawing.Size(344, 109);
            this.dgvFilhos.TabIndex = 18;
            this.dgvFilhos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvFilhos_MouseClick);
            // 
            // cbSexoFilho
            // 
            this.cbSexoFilho.FormattingEnabled = true;
            this.cbSexoFilho.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cbSexoFilho.Location = new System.Drawing.Point(72, 161);
            this.cbSexoFilho.Name = "cbSexoFilho";
            this.cbSexoFilho.Size = new System.Drawing.Size(90, 21);
            this.cbSexoFilho.TabIndex = 9;
            // 
            // tbNomeFilho
            // 
            this.tbNomeFilho.Location = new System.Drawing.Point(72, 135);
            this.tbNomeFilho.Name = "tbNomeFilho";
            this.tbNomeFilho.Size = new System.Drawing.Size(402, 20);
            this.tbNomeFilho.TabIndex = 1;
            // 
            // btEditarFilhos
            // 
            this.btEditarFilhos.Location = new System.Drawing.Point(15, 44);
            this.btEditarFilhos.Name = "btEditarFilhos";
            this.btEditarFilhos.Size = new System.Drawing.Size(109, 23);
            this.btEditarFilhos.TabIndex = 16;
            this.btEditarFilhos.Text = "Editar Filho";
            this.btEditarFilhos.UseVisualStyleBackColor = true;
            this.btEditarFilhos.Click += new System.EventHandler(this.btEditarFilhos_Click);
            // 
            // btAdicionarFilhos
            // 
            this.btAdicionarFilhos.Location = new System.Drawing.Point(15, 15);
            this.btAdicionarFilhos.Name = "btAdicionarFilhos";
            this.btAdicionarFilhos.Size = new System.Drawing.Size(109, 23);
            this.btAdicionarFilhos.TabIndex = 14;
            this.btAdicionarFilhos.Text = "Adicionar Filho";
            this.btAdicionarFilhos.UseVisualStyleBackColor = true;
            this.btAdicionarFilhos.Click += new System.EventHandler(this.btAdicionarFilho_Click);
            // 
            // btApagarFilhos
            // 
            this.btApagarFilhos.Location = new System.Drawing.Point(15, 73);
            this.btApagarFilhos.Name = "btApagarFilhos";
            this.btApagarFilhos.Size = new System.Drawing.Size(109, 23);
            this.btApagarFilhos.TabIndex = 15;
            this.btApagarFilhos.Text = "Apagar Filho";
            this.btApagarFilhos.UseVisualStyleBackColor = true;
            // 
            // gbClientes
            // 
            this.gbClientes.Controls.Add(this.btCancelCleanClientes);
            this.gbClientes.Controls.Add(this.btGuardarClientes);
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
            this.gbClientes.Controls.Add(this.btAdicionarClientes);
            this.gbClientes.Controls.Add(this.btApagarClientes);
            this.gbClientes.Controls.Add(this.btEditarClientes);
            this.gbClientes.Location = new System.Drawing.Point(12, 12);
            this.gbClientes.Name = "gbClientes";
            this.gbClientes.Size = new System.Drawing.Size(988, 503);
            this.gbClientes.TabIndex = 13;
            this.gbClientes.TabStop = false;
            this.gbClientes.Text = "Clientes";
            // 
            // btCancelCleanClientes
            // 
            this.btCancelCleanClientes.Location = new System.Drawing.Point(32, 207);
            this.btCancelCleanClientes.Name = "btCancelCleanClientes";
            this.btCancelCleanClientes.Size = new System.Drawing.Size(167, 23);
            this.btCancelCleanClientes.TabIndex = 50;
            this.btCancelCleanClientes.Text = "Cancelar/Limpar Alterações";
            this.btCancelCleanClientes.UseVisualStyleBackColor = true;
            this.btCancelCleanClientes.Click += new System.EventHandler(this.btCancelCleanClientes_Click);
            // 
            // btGuardarClientes
            // 
            this.btGuardarClientes.Location = new System.Drawing.Point(265, 39);
            this.btGuardarClientes.Name = "btGuardarClientes";
            this.btGuardarClientes.Size = new System.Drawing.Size(112, 23);
            this.btGuardarClientes.TabIndex = 44;
            this.btGuardarClientes.Text = "Guardar Alterações";
            this.btGuardarClientes.UseVisualStyleBackColor = true;
            this.btGuardarClientes.Click += new System.EventHandler(this.btGuardarClientes_Click);
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
            this.nmValorOferta.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
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
            this.dgvClientes.Location = new System.Drawing.Point(32, 240);
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
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 525);
            this.Controls.Add(this.gbClientes);
            this.Name = "FormClientes";
            this.Text = "FormClientes";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            this.gbFilhos.ResumeLayout(false);
            this.gbFilhos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilhos)).EndInit();
            this.gbClientes.ResumeLayout(false);
            this.gbClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmValorOferta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filhosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btAdicionarClientes;
        private System.Windows.Forms.Button btApagarClientes;
        private System.Windows.Forms.Button btEditarClientes;
        private System.Windows.Forms.GroupBox gbFilhos;
        private System.Windows.Forms.ComboBox cbSexoFilho;
        private System.Windows.Forms.TextBox tbNomeFilho;
        private System.Windows.Forms.Button btEditarFilhos;
        private System.Windows.Forms.Button btApagarFilhos;
        private System.Windows.Forms.Button btAdicionarFilhos;
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
        private System.Windows.Forms.Button btGuardarFilhos;
        private System.Windows.Forms.Button btGuardarClientes;
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
        private System.Windows.Forms.Button btCancelCleanFilhos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btCancelCleanClientes;
    }
}