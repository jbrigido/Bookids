namespace Bookids
{
    partial class FormEventos
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
            this.groupBoxEventos = new System.Windows.Forms.GroupBox();
            this.dgvEventos = new System.Windows.Forms.DataGridView();
            this.btCancelClean = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nmIdadeMax = new System.Windows.Forms.NumericUpDown();
            this.labelTipoEvento = new System.Windows.Forms.Label();
            this.labelIdadeMinMax = new System.Windows.Forms.Label();
            this.dtpDataHoraEventos = new System.Windows.Forms.DateTimePicker();
            this.nmIdadeMin = new System.Windows.Forms.NumericUpDown();
            this.labelDataEvento = new System.Windows.Forms.Label();
            this.labelLocalEvento = new System.Windows.Forms.Label();
            this.labelNomeEvento = new System.Windows.Forms.Label();
            this.tbTipoEvento = new System.Windows.Forms.TextBox();
            this.labelNumeroEvento = new System.Windows.Forms.Label();
            this.btGuardarEvento = new System.Windows.Forms.Button();
            this.btCriarEvento = new System.Windows.Forms.Button();
            this.btApagarEvento = new System.Windows.Forms.Button();
            this.btEditarEvento = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDescricaoEvento = new System.Windows.Forms.TextBox();
            this.tbNumeroEvento = new System.Windows.Forms.TextBox();
            this.tbLocalEvento = new System.Windows.Forms.TextBox();
            this.nmLimiteParticipantes = new System.Windows.Forms.NumericUpDown();
            this.groupBoxColaboracoes = new System.Windows.Forms.GroupBox();
            this.btRemoverAnimador = new System.Windows.Forms.Button();
            this.btAdicionarAnimador = new System.Windows.Forms.Button();
            this.cbAnimadores = new System.Windows.Forms.ComboBox();
            this.lbColaboracoes = new System.Windows.Forms.ListBox();
            this.groupBoxParticipacoes = new System.Windows.Forms.GroupBox();
            this.btRemoverEscola = new System.Windows.Forms.Button();
            this.btAdicionarEscola = new System.Windows.Forms.Button();
            this.cbEscolas = new System.Windows.Forms.ComboBox();
            this.lbParticipacoes = new System.Windows.Forms.ListBox();
            this.nrEventoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataHoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limiteParticipacoesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxInscricoes = new System.Windows.Forms.GroupBox();
            this.btRemoverFilho = new System.Windows.Forms.Button();
            this.btAdicionarFilho = new System.Windows.Forms.Button();
            this.cbFilhos = new System.Windows.Forms.ComboBox();
            this.lbInscricoes = new System.Windows.Forms.ListBox();
            this.checkBoxFilhoConfirmado = new System.Windows.Forms.CheckBox();
            this.groupBoxEventos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmIdadeMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmIdadeMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmLimiteParticipantes)).BeginInit();
            this.groupBoxColaboracoes.SuspendLayout();
            this.groupBoxParticipacoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource)).BeginInit();
            this.groupBoxInscricoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxEventos
            // 
            this.groupBoxEventos.Controls.Add(this.dgvEventos);
            this.groupBoxEventos.Controls.Add(this.btCancelClean);
            this.groupBoxEventos.Controls.Add(this.label1);
            this.groupBoxEventos.Controls.Add(this.nmIdadeMax);
            this.groupBoxEventos.Controls.Add(this.labelTipoEvento);
            this.groupBoxEventos.Controls.Add(this.labelIdadeMinMax);
            this.groupBoxEventos.Controls.Add(this.dtpDataHoraEventos);
            this.groupBoxEventos.Controls.Add(this.nmIdadeMin);
            this.groupBoxEventos.Controls.Add(this.labelDataEvento);
            this.groupBoxEventos.Controls.Add(this.labelLocalEvento);
            this.groupBoxEventos.Controls.Add(this.labelNomeEvento);
            this.groupBoxEventos.Controls.Add(this.tbTipoEvento);
            this.groupBoxEventos.Controls.Add(this.labelNumeroEvento);
            this.groupBoxEventos.Controls.Add(this.btGuardarEvento);
            this.groupBoxEventos.Controls.Add(this.btCriarEvento);
            this.groupBoxEventos.Controls.Add(this.btApagarEvento);
            this.groupBoxEventos.Controls.Add(this.btEditarEvento);
            this.groupBoxEventos.Controls.Add(this.label3);
            this.groupBoxEventos.Controls.Add(this.tbDescricaoEvento);
            this.groupBoxEventos.Controls.Add(this.tbNumeroEvento);
            this.groupBoxEventos.Controls.Add(this.tbLocalEvento);
            this.groupBoxEventos.Controls.Add(this.nmLimiteParticipantes);
            this.groupBoxEventos.Location = new System.Drawing.Point(12, 12);
            this.groupBoxEventos.Name = "groupBoxEventos";
            this.groupBoxEventos.Size = new System.Drawing.Size(786, 332);
            this.groupBoxEventos.TabIndex = 0;
            this.groupBoxEventos.TabStop = false;
            this.groupBoxEventos.Text = "Dados Evento";
            // 
            // dgvEventos
            // 
            this.dgvEventos.AllowUserToAddRows = false;
            this.dgvEventos.AllowUserToDeleteRows = false;
            this.dgvEventos.AutoGenerateColumns = false;
            this.dgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nrEventoDataGridViewTextBoxColumn,
            this.localDataGridViewTextBoxColumn,
            this.dataHoraDataGridViewTextBoxColumn,
            this.limiteParticipacoesDataGridViewTextBoxColumn});
            this.dgvEventos.DataSource = this.eventosBindingSource;
            this.dgvEventos.Location = new System.Drawing.Point(305, 19);
            this.dgvEventos.Name = "dgvEventos";
            this.dgvEventos.ReadOnly = true;
            this.dgvEventos.Size = new System.Drawing.Size(475, 299);
            this.dgvEventos.TabIndex = 56;
            this.dgvEventos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvEventos_MouseClick);
            // 
            // btCancelClean
            // 
            this.btCancelClean.Location = new System.Drawing.Point(6, 297);
            this.btCancelClean.Name = "btCancelClean";
            this.btCancelClean.Size = new System.Drawing.Size(293, 23);
            this.btCancelClean.TabIndex = 55;
            this.btCancelClean.Text = "Cancelar/Limpar Seleção";
            this.btCancelClean.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "/";
            // 
            // nmIdadeMax
            // 
            this.nmIdadeMax.Location = new System.Drawing.Point(182, 150);
            this.nmIdadeMax.Name = "nmIdadeMax";
            this.nmIdadeMax.Size = new System.Drawing.Size(36, 20);
            this.nmIdadeMax.TabIndex = 46;
            // 
            // labelTipoEvento
            // 
            this.labelTipoEvento.AutoSize = true;
            this.labelTipoEvento.Location = new System.Drawing.Point(4, 127);
            this.labelTipoEvento.Name = "labelTipoEvento";
            this.labelTipoEvento.Size = new System.Drawing.Size(31, 13);
            this.labelTipoEvento.TabIndex = 53;
            this.labelTipoEvento.Text = "Tipo:";
            // 
            // labelIdadeMinMax
            // 
            this.labelIdadeMinMax.AutoSize = true;
            this.labelIdadeMinMax.Location = new System.Drawing.Point(4, 152);
            this.labelIdadeMinMax.Name = "labelIdadeMinMax";
            this.labelIdadeMinMax.Size = new System.Drawing.Size(116, 13);
            this.labelIdadeMinMax.TabIndex = 43;
            this.labelIdadeMinMax.Text = "Idade Mínima/Máxima:";
            // 
            // dtpDataHoraEventos
            // 
            this.dtpDataHoraEventos.Location = new System.Drawing.Point(80, 98);
            this.dtpDataHoraEventos.Name = "dtpDataHoraEventos";
            this.dtpDataHoraEventos.Size = new System.Drawing.Size(219, 20);
            this.dtpDataHoraEventos.TabIndex = 47;
            // 
            // nmIdadeMin
            // 
            this.nmIdadeMin.Location = new System.Drawing.Point(125, 150);
            this.nmIdadeMin.Name = "nmIdadeMin";
            this.nmIdadeMin.Size = new System.Drawing.Size(36, 20);
            this.nmIdadeMin.TabIndex = 45;
            // 
            // labelDataEvento
            // 
            this.labelDataEvento.AutoSize = true;
            this.labelDataEvento.Location = new System.Drawing.Point(4, 103);
            this.labelDataEvento.Name = "labelDataEvento";
            this.labelDataEvento.Size = new System.Drawing.Size(70, 13);
            this.labelDataEvento.TabIndex = 52;
            this.labelDataEvento.Text = "*Data e hora:";
            // 
            // labelLocalEvento
            // 
            this.labelLocalEvento.AutoSize = true;
            this.labelLocalEvento.Location = new System.Drawing.Point(4, 75);
            this.labelLocalEvento.Name = "labelLocalEvento";
            this.labelLocalEvento.Size = new System.Drawing.Size(40, 13);
            this.labelLocalEvento.TabIndex = 51;
            this.labelLocalEvento.Text = "*Local:";
            // 
            // labelNomeEvento
            // 
            this.labelNomeEvento.AutoSize = true;
            this.labelNomeEvento.Location = new System.Drawing.Point(4, 22);
            this.labelNomeEvento.Name = "labelNomeEvento";
            this.labelNomeEvento.Size = new System.Drawing.Size(48, 13);
            this.labelNomeEvento.TabIndex = 50;
            this.labelNomeEvento.Text = "*Evento:";
            // 
            // tbTipoEvento
            // 
            this.tbTipoEvento.Location = new System.Drawing.Point(80, 124);
            this.tbTipoEvento.Name = "tbTipoEvento";
            this.tbTipoEvento.Size = new System.Drawing.Size(219, 20);
            this.tbTipoEvento.TabIndex = 48;
            // 
            // labelNumeroEvento
            // 
            this.labelNumeroEvento.AutoSize = true;
            this.labelNumeroEvento.Location = new System.Drawing.Point(4, 48);
            this.labelNumeroEvento.Name = "labelNumeroEvento";
            this.labelNumeroEvento.Size = new System.Drawing.Size(25, 13);
            this.labelNumeroEvento.TabIndex = 49;
            this.labelNumeroEvento.Text = "Nº :";
            // 
            // btGuardarEvento
            // 
            this.btGuardarEvento.Location = new System.Drawing.Point(6, 239);
            this.btGuardarEvento.Name = "btGuardarEvento";
            this.btGuardarEvento.Size = new System.Drawing.Size(293, 23);
            this.btGuardarEvento.TabIndex = 16;
            this.btGuardarEvento.Text = "Guardar Alterações";
            this.btGuardarEvento.UseVisualStyleBackColor = true;
            this.btGuardarEvento.Click += new System.EventHandler(this.btGuardarEvento_Click);
            // 
            // btCriarEvento
            // 
            this.btCriarEvento.Location = new System.Drawing.Point(6, 180);
            this.btCriarEvento.Name = "btCriarEvento";
            this.btCriarEvento.Size = new System.Drawing.Size(293, 23);
            this.btCriarEvento.TabIndex = 12;
            this.btCriarEvento.Text = "Criar Evento";
            this.btCriarEvento.UseVisualStyleBackColor = true;
            this.btCriarEvento.Click += new System.EventHandler(this.btCriarEvento_Click);
            // 
            // btApagarEvento
            // 
            this.btApagarEvento.Location = new System.Drawing.Point(6, 268);
            this.btApagarEvento.Name = "btApagarEvento";
            this.btApagarEvento.Size = new System.Drawing.Size(293, 23);
            this.btApagarEvento.TabIndex = 13;
            this.btApagarEvento.Text = "Apagar Evento";
            this.btApagarEvento.UseVisualStyleBackColor = true;
            // 
            // btEditarEvento
            // 
            this.btEditarEvento.Location = new System.Drawing.Point(6, 209);
            this.btEditarEvento.Name = "btEditarEvento";
            this.btEditarEvento.Size = new System.Drawing.Size(293, 23);
            this.btEditarEvento.TabIndex = 14;
            this.btEditarEvento.Text = "Editar Evento";
            this.btEditarEvento.UseVisualStyleBackColor = true;
            this.btEditarEvento.Click += new System.EventHandler(this.btEditarEvento_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "*Limite Participantes:";
            // 
            // tbDescricaoEvento
            // 
            this.tbDescricaoEvento.Location = new System.Drawing.Point(80, 19);
            this.tbDescricaoEvento.Name = "tbDescricaoEvento";
            this.tbDescricaoEvento.Size = new System.Drawing.Size(219, 20);
            this.tbDescricaoEvento.TabIndex = 39;
            // 
            // tbNumeroEvento
            // 
            this.tbNumeroEvento.Location = new System.Drawing.Point(80, 45);
            this.tbNumeroEvento.Name = "tbNumeroEvento";
            this.tbNumeroEvento.ReadOnly = true;
            this.tbNumeroEvento.Size = new System.Drawing.Size(47, 20);
            this.tbNumeroEvento.TabIndex = 38;
            // 
            // tbLocalEvento
            // 
            this.tbLocalEvento.Location = new System.Drawing.Point(80, 72);
            this.tbLocalEvento.Name = "tbLocalEvento";
            this.tbLocalEvento.Size = new System.Drawing.Size(219, 20);
            this.tbLocalEvento.TabIndex = 40;
            // 
            // nmLimiteParticipantes
            // 
            this.nmLimiteParticipantes.Location = new System.Drawing.Point(258, 46);
            this.nmLimiteParticipantes.Name = "nmLimiteParticipantes";
            this.nmLimiteParticipantes.Size = new System.Drawing.Size(41, 20);
            this.nmLimiteParticipantes.TabIndex = 42;
            // 
            // groupBoxColaboracoes
            // 
            this.groupBoxColaboracoes.Controls.Add(this.btRemoverAnimador);
            this.groupBoxColaboracoes.Controls.Add(this.btAdicionarAnimador);
            this.groupBoxColaboracoes.Controls.Add(this.cbAnimadores);
            this.groupBoxColaboracoes.Controls.Add(this.lbColaboracoes);
            this.groupBoxColaboracoes.Location = new System.Drawing.Point(12, 350);
            this.groupBoxColaboracoes.Name = "groupBoxColaboracoes";
            this.groupBoxColaboracoes.Size = new System.Drawing.Size(258, 241);
            this.groupBoxColaboracoes.TabIndex = 1;
            this.groupBoxColaboracoes.TabStop = false;
            this.groupBoxColaboracoes.Text = "Colaborações Animadores";
            // 
            // btRemoverAnimador
            // 
            this.btRemoverAnimador.Location = new System.Drawing.Point(7, 202);
            this.btRemoverAnimador.Name = "btRemoverAnimador";
            this.btRemoverAnimador.Size = new System.Drawing.Size(245, 23);
            this.btRemoverAnimador.TabIndex = 3;
            this.btRemoverAnimador.Text = "Remover";
            this.btRemoverAnimador.UseVisualStyleBackColor = true;
            // 
            // btAdicionarAnimador
            // 
            this.btAdicionarAnimador.Location = new System.Drawing.Point(6, 173);
            this.btAdicionarAnimador.Name = "btAdicionarAnimador";
            this.btAdicionarAnimador.Size = new System.Drawing.Size(246, 23);
            this.btAdicionarAnimador.TabIndex = 2;
            this.btAdicionarAnimador.Text = "Adicionar";
            this.btAdicionarAnimador.UseVisualStyleBackColor = true;
            // 
            // cbAnimadores
            // 
            this.cbAnimadores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAnimadores.FormattingEnabled = true;
            this.cbAnimadores.Location = new System.Drawing.Point(7, 19);
            this.cbAnimadores.Name = "cbAnimadores";
            this.cbAnimadores.Size = new System.Drawing.Size(245, 21);
            this.cbAnimadores.TabIndex = 1;
            // 
            // lbColaboracoes
            // 
            this.lbColaboracoes.FormattingEnabled = true;
            this.lbColaboracoes.Location = new System.Drawing.Point(7, 46);
            this.lbColaboracoes.Name = "lbColaboracoes";
            this.lbColaboracoes.Size = new System.Drawing.Size(245, 121);
            this.lbColaboracoes.TabIndex = 0;
            // 
            // groupBoxParticipacoes
            // 
            this.groupBoxParticipacoes.Controls.Add(this.btRemoverEscola);
            this.groupBoxParticipacoes.Controls.Add(this.btAdicionarEscola);
            this.groupBoxParticipacoes.Controls.Add(this.cbEscolas);
            this.groupBoxParticipacoes.Controls.Add(this.lbParticipacoes);
            this.groupBoxParticipacoes.Location = new System.Drawing.Point(276, 350);
            this.groupBoxParticipacoes.Name = "groupBoxParticipacoes";
            this.groupBoxParticipacoes.Size = new System.Drawing.Size(258, 241);
            this.groupBoxParticipacoes.TabIndex = 4;
            this.groupBoxParticipacoes.TabStop = false;
            this.groupBoxParticipacoes.Text = "Participações Escolas";
            // 
            // btRemoverEscola
            // 
            this.btRemoverEscola.Location = new System.Drawing.Point(7, 202);
            this.btRemoverEscola.Name = "btRemoverEscola";
            this.btRemoverEscola.Size = new System.Drawing.Size(245, 23);
            this.btRemoverEscola.TabIndex = 3;
            this.btRemoverEscola.Text = "Remover";
            this.btRemoverEscola.UseVisualStyleBackColor = true;
            // 
            // btAdicionarEscola
            // 
            this.btAdicionarEscola.Location = new System.Drawing.Point(6, 173);
            this.btAdicionarEscola.Name = "btAdicionarEscola";
            this.btAdicionarEscola.Size = new System.Drawing.Size(246, 23);
            this.btAdicionarEscola.TabIndex = 2;
            this.btAdicionarEscola.Text = "Adicionar";
            this.btAdicionarEscola.UseVisualStyleBackColor = true;
            // 
            // cbEscolas
            // 
            this.cbEscolas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEscolas.FormattingEnabled = true;
            this.cbEscolas.Location = new System.Drawing.Point(7, 19);
            this.cbEscolas.Name = "cbEscolas";
            this.cbEscolas.Size = new System.Drawing.Size(245, 21);
            this.cbEscolas.TabIndex = 1;
            // 
            // lbParticipacoes
            // 
            this.lbParticipacoes.FormattingEnabled = true;
            this.lbParticipacoes.Location = new System.Drawing.Point(7, 46);
            this.lbParticipacoes.Name = "lbParticipacoes";
            this.lbParticipacoes.Size = new System.Drawing.Size(245, 121);
            this.lbParticipacoes.TabIndex = 0;
            // 
            // nrEventoDataGridViewTextBoxColumn
            // 
            this.nrEventoDataGridViewTextBoxColumn.DataPropertyName = "NrEvento";
            this.nrEventoDataGridViewTextBoxColumn.HeaderText = "NrEvento";
            this.nrEventoDataGridViewTextBoxColumn.Name = "nrEventoDataGridViewTextBoxColumn";
            this.nrEventoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // localDataGridViewTextBoxColumn
            // 
            this.localDataGridViewTextBoxColumn.DataPropertyName = "Local";
            this.localDataGridViewTextBoxColumn.HeaderText = "Local";
            this.localDataGridViewTextBoxColumn.Name = "localDataGridViewTextBoxColumn";
            this.localDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataHoraDataGridViewTextBoxColumn
            // 
            this.dataHoraDataGridViewTextBoxColumn.DataPropertyName = "DataHora";
            this.dataHoraDataGridViewTextBoxColumn.HeaderText = "DataHora";
            this.dataHoraDataGridViewTextBoxColumn.Name = "dataHoraDataGridViewTextBoxColumn";
            this.dataHoraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // limiteParticipacoesDataGridViewTextBoxColumn
            // 
            this.limiteParticipacoesDataGridViewTextBoxColumn.DataPropertyName = "LimiteParticipacoes";
            this.limiteParticipacoesDataGridViewTextBoxColumn.HeaderText = "LimiteParticipacoes";
            this.limiteParticipacoesDataGridViewTextBoxColumn.Name = "limiteParticipacoesDataGridViewTextBoxColumn";
            this.limiteParticipacoesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eventosBindingSource
            // 
            this.eventosBindingSource.DataSource = typeof(Bookids.Eventos);
            // 
            // groupBoxInscricoes
            // 
            this.groupBoxInscricoes.Controls.Add(this.checkBoxFilhoConfirmado);
            this.groupBoxInscricoes.Controls.Add(this.btRemoverFilho);
            this.groupBoxInscricoes.Controls.Add(this.btAdicionarFilho);
            this.groupBoxInscricoes.Controls.Add(this.cbFilhos);
            this.groupBoxInscricoes.Controls.Add(this.lbInscricoes);
            this.groupBoxInscricoes.Location = new System.Drawing.Point(540, 350);
            this.groupBoxInscricoes.Name = "groupBoxInscricoes";
            this.groupBoxInscricoes.Size = new System.Drawing.Size(258, 241);
            this.groupBoxInscricoes.TabIndex = 5;
            this.groupBoxInscricoes.TabStop = false;
            this.groupBoxInscricoes.Text = "Filhos Inscritos";
            // 
            // btRemoverFilho
            // 
            this.btRemoverFilho.Location = new System.Drawing.Point(7, 202);
            this.btRemoverFilho.Name = "btRemoverFilho";
            this.btRemoverFilho.Size = new System.Drawing.Size(245, 23);
            this.btRemoverFilho.TabIndex = 3;
            this.btRemoverFilho.Text = "Remover";
            this.btRemoverFilho.UseVisualStyleBackColor = true;
            // 
            // btAdicionarFilho
            // 
            this.btAdicionarFilho.Location = new System.Drawing.Point(6, 173);
            this.btAdicionarFilho.Name = "btAdicionarFilho";
            this.btAdicionarFilho.Size = new System.Drawing.Size(246, 23);
            this.btAdicionarFilho.TabIndex = 2;
            this.btAdicionarFilho.Text = "Adicionar";
            this.btAdicionarFilho.UseVisualStyleBackColor = true;
            // 
            // cbFilhos
            // 
            this.cbFilhos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilhos.FormattingEnabled = true;
            this.cbFilhos.Location = new System.Drawing.Point(7, 19);
            this.cbFilhos.Name = "cbFilhos";
            this.cbFilhos.Size = new System.Drawing.Size(245, 21);
            this.cbFilhos.TabIndex = 1;
            // 
            // lbInscricoes
            // 
            this.lbInscricoes.FormattingEnabled = true;
            this.lbInscricoes.Location = new System.Drawing.Point(7, 46);
            this.lbInscricoes.Name = "lbInscricoes";
            this.lbInscricoes.Size = new System.Drawing.Size(245, 95);
            this.lbInscricoes.TabIndex = 0;
            // 
            // checkBoxFilhoConfirmado
            // 
            this.checkBoxFilhoConfirmado.AutoSize = true;
            this.checkBoxFilhoConfirmado.Location = new System.Drawing.Point(7, 150);
            this.checkBoxFilhoConfirmado.Name = "checkBoxFilhoConfirmado";
            this.checkBoxFilhoConfirmado.Size = new System.Drawing.Size(79, 17);
            this.checkBoxFilhoConfirmado.TabIndex = 4;
            this.checkBoxFilhoConfirmado.Text = "Confirmado";
            this.checkBoxFilhoConfirmado.UseVisualStyleBackColor = true;
            // 
            // FormEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 603);
            this.Controls.Add(this.groupBoxInscricoes);
            this.Controls.Add(this.groupBoxParticipacoes);
            this.Controls.Add(this.groupBoxColaboracoes);
            this.Controls.Add(this.groupBoxEventos);
            this.Name = "FormEventos";
            this.ShowIcon = false;
            this.Text = "Bookids - Gestão de Eventos";
            this.Load += new System.EventHandler(this.FormEventos_Load);
            this.groupBoxEventos.ResumeLayout(false);
            this.groupBoxEventos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmIdadeMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmIdadeMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmLimiteParticipantes)).EndInit();
            this.groupBoxColaboracoes.ResumeLayout(false);
            this.groupBoxParticipacoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource)).EndInit();
            this.groupBoxInscricoes.ResumeLayout(false);
            this.groupBoxInscricoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEventos;
        private System.Windows.Forms.GroupBox groupBoxColaboracoes;
        private System.Windows.Forms.Button btRemoverAnimador;
        private System.Windows.Forms.Button btAdicionarAnimador;
        private System.Windows.Forms.ComboBox cbAnimadores;
        private System.Windows.Forms.ListBox lbColaboracoes;
        private System.Windows.Forms.Button btEditarEvento;
        private System.Windows.Forms.Button btApagarEvento;
        private System.Windows.Forms.Button btCriarEvento;
        private System.Windows.Forms.TextBox tbTipoEvento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmIdadeMax;
        private System.Windows.Forms.NumericUpDown nmIdadeMin;
        private System.Windows.Forms.Label labelIdadeMinMax;
        private System.Windows.Forms.NumericUpDown nmLimiteParticipantes;
        private System.Windows.Forms.TextBox tbLocalEvento;
        private System.Windows.Forms.TextBox tbDescricaoEvento;
        private System.Windows.Forms.TextBox tbNumeroEvento;
        private System.Windows.Forms.Button btGuardarEvento;
        private System.Windows.Forms.Label labelNumeroEvento;
        private System.Windows.Forms.Label labelNomeEvento;
        private System.Windows.Forms.Label labelLocalEvento;
        private System.Windows.Forms.Label labelDataEvento;
        private System.Windows.Forms.Label labelTipoEvento;
        private System.Windows.Forms.DateTimePicker dtpDataHoraEventos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCancelClean;
        private System.Windows.Forms.DataGridView dgvEventos;
        private System.Windows.Forms.BindingSource eventosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrEventoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataHoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn limiteParticipacoesDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBoxParticipacoes;
        private System.Windows.Forms.Button btRemoverEscola;
        private System.Windows.Forms.Button btAdicionarEscola;
        private System.Windows.Forms.ComboBox cbEscolas;
        private System.Windows.Forms.ListBox lbParticipacoes;
        private System.Windows.Forms.GroupBox groupBoxInscricoes;
        private System.Windows.Forms.Button btRemoverFilho;
        private System.Windows.Forms.Button btAdicionarFilho;
        private System.Windows.Forms.ComboBox cbFilhos;
        private System.Windows.Forms.ListBox lbInscricoes;
        private System.Windows.Forms.CheckBox checkBoxFilhoConfirmado;
    }
}