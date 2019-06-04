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
            this.gbEventos = new System.Windows.Forms.GroupBox();
            this.gbDadosEvento = new System.Windows.Forms.GroupBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btGuardarEvento = new System.Windows.Forms.Button();
            this.tbTipoEve = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nmLimiteParticip = new System.Windows.Forms.NumericUpDown();
            this.dtpDataEve = new System.Windows.Forms.DateTimePicker();
            this.tbLocalEve = new System.Windows.Forms.TextBox();
            this.tbDescricaoEve = new System.Windows.Forms.TextBox();
            this.tbNrEvento = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btApagarEvento = new System.Windows.Forms.Button();
            this.btEditarEvento = new System.Windows.Forms.Button();
            this.btCriarEvento = new System.Windows.Forms.Button();
            this.gbColaboracoes = new System.Windows.Forms.GroupBox();
            this.btRemoverColaboracao = new System.Windows.Forms.Button();
            this.btAdicionarColaboracao = new System.Windows.Forms.Button();
            this.cbAnimadores = new System.Windows.Forms.ComboBox();
            this.lbColaboracoes = new System.Windows.Forms.ListBox();
            this.gbEscolasInscritas = new System.Windows.Forms.GroupBox();
            this.clbEscolas = new System.Windows.Forms.CheckedListBox();
            this.gbEventos.SuspendLayout();
            this.gbDadosEvento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmLimiteParticip)).BeginInit();
            this.gbColaboracoes.SuspendLayout();
            this.gbEscolasInscritas.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEventos
            // 
            this.gbEventos.Controls.Add(this.gbDadosEvento);
            this.gbEventos.Controls.Add(this.comboBox1);
            this.gbEventos.Controls.Add(this.btApagarEvento);
            this.gbEventos.Controls.Add(this.btEditarEvento);
            this.gbEventos.Controls.Add(this.btCriarEvento);
            this.gbEventos.Location = new System.Drawing.Point(12, 88);
            this.gbEventos.Name = "gbEventos";
            this.gbEventos.Size = new System.Drawing.Size(258, 386);
            this.gbEventos.TabIndex = 0;
            this.gbEventos.TabStop = false;
            this.gbEventos.Text = "Eventos";
            // 
            // gbDadosEvento
            // 
            this.gbDadosEvento.Controls.Add(this.btCancelar);
            this.gbDadosEvento.Controls.Add(this.btGuardarEvento);
            this.gbDadosEvento.Controls.Add(this.tbTipoEve);
            this.gbDadosEvento.Controls.Add(this.label3);
            this.gbDadosEvento.Controls.Add(this.numericUpDown2);
            this.gbDadosEvento.Controls.Add(this.numericUpDown1);
            this.gbDadosEvento.Controls.Add(this.label2);
            this.gbDadosEvento.Controls.Add(this.label1);
            this.gbDadosEvento.Controls.Add(this.nmLimiteParticip);
            this.gbDadosEvento.Controls.Add(this.dtpDataEve);
            this.gbDadosEvento.Controls.Add(this.tbLocalEve);
            this.gbDadosEvento.Controls.Add(this.tbDescricaoEve);
            this.gbDadosEvento.Controls.Add(this.tbNrEvento);
            this.gbDadosEvento.Location = new System.Drawing.Point(7, 51);
            this.gbDadosEvento.Name = "gbDadosEvento";
            this.gbDadosEvento.Size = new System.Drawing.Size(238, 198);
            this.gbDadosEvento.TabIndex = 3;
            this.gbDadosEvento.TabStop = false;
            this.gbDadosEvento.Text = "Dados do Evento";
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(119, 165);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(108, 23);
            this.btCancelar.TabIndex = 50;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // btGuardarEvento
            // 
            this.btGuardarEvento.Location = new System.Drawing.Point(6, 165);
            this.btGuardarEvento.Name = "btGuardarEvento";
            this.btGuardarEvento.Size = new System.Drawing.Size(107, 23);
            this.btGuardarEvento.TabIndex = 49;
            this.btGuardarEvento.Text = "Guardar Alterações";
            this.btGuardarEvento.UseVisualStyleBackColor = true;
            // 
            // tbTipoEve
            // 
            this.tbTipoEve.Location = new System.Drawing.Point(6, 118);
            this.tbTipoEve.Name = "tbTipoEve";
            this.tbTipoEve.Size = new System.Drawing.Size(221, 20);
            this.tbTipoEve.TabIndex = 48;
            this.tbTipoEve.Text = "Tipo Evento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Limite Participantes:";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(191, 139);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(36, 20);
            this.numericUpDown2.TabIndex = 46;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(73, 139);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(36, 20);
            this.numericUpDown1.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Idade Máxima:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Idade Mínima:";
            // 
            // nmLimiteParticip
            // 
            this.nmLimiteParticip.Location = new System.Drawing.Point(186, 20);
            this.nmLimiteParticip.Name = "nmLimiteParticip";
            this.nmLimiteParticip.Size = new System.Drawing.Size(41, 20);
            this.nmLimiteParticip.TabIndex = 42;
            // 
            // dtpDataEve
            // 
            this.dtpDataEve.CustomFormat = "";
            this.dtpDataEve.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataEve.Location = new System.Drawing.Point(127, 91);
            this.dtpDataEve.MinDate = new System.DateTime(2019, 6, 4, 15, 0, 55, 0);
            this.dtpDataEve.Name = "dtpDataEve";
            this.dtpDataEve.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpDataEve.ShowUpDown = true;
            this.dtpDataEve.Size = new System.Drawing.Size(100, 20);
            this.dtpDataEve.TabIndex = 41;
            this.dtpDataEve.Value = new System.DateTime(2019, 6, 4, 15, 0, 55, 0);
            // 
            // tbLocalEve
            // 
            this.tbLocalEve.Location = new System.Drawing.Point(6, 91);
            this.tbLocalEve.Name = "tbLocalEve";
            this.tbLocalEve.Size = new System.Drawing.Size(112, 20);
            this.tbLocalEve.TabIndex = 40;
            this.tbLocalEve.Text = "Local";
            // 
            // tbDescricaoEve
            // 
            this.tbDescricaoEve.Location = new System.Drawing.Point(6, 46);
            this.tbDescricaoEve.Multiline = true;
            this.tbDescricaoEve.Name = "tbDescricaoEve";
            this.tbDescricaoEve.Size = new System.Drawing.Size(221, 39);
            this.tbDescricaoEve.TabIndex = 39;
            this.tbDescricaoEve.Text = "Descrição";
            // 
            // tbNrEvento
            // 
            this.tbNrEvento.Location = new System.Drawing.Point(6, 19);
            this.tbNrEvento.Name = "tbNrEvento";
            this.tbNrEvento.ReadOnly = true;
            this.tbNrEvento.Size = new System.Drawing.Size(72, 20);
            this.tbNrEvento.TabIndex = 38;
            this.tbNrEvento.Text = "Nr Evento";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(7, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(238, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // btApagarEvento
            // 
            this.btApagarEvento.Location = new System.Drawing.Point(25, 328);
            this.btApagarEvento.Name = "btApagarEvento";
            this.btApagarEvento.Size = new System.Drawing.Size(193, 23);
            this.btApagarEvento.TabIndex = 13;
            this.btApagarEvento.Text = "Apagar Evento";
            this.btApagarEvento.UseVisualStyleBackColor = true;
            // 
            // btEditarEvento
            // 
            this.btEditarEvento.Location = new System.Drawing.Point(25, 299);
            this.btEditarEvento.Name = "btEditarEvento";
            this.btEditarEvento.Size = new System.Drawing.Size(193, 23);
            this.btEditarEvento.TabIndex = 14;
            this.btEditarEvento.Text = "Editar Evento";
            this.btEditarEvento.UseVisualStyleBackColor = true;
            // 
            // btCriarEvento
            // 
            this.btCriarEvento.Location = new System.Drawing.Point(25, 270);
            this.btCriarEvento.Name = "btCriarEvento";
            this.btCriarEvento.Size = new System.Drawing.Size(193, 23);
            this.btCriarEvento.TabIndex = 12;
            this.btCriarEvento.Text = "Criar Novo Evento";
            this.btCriarEvento.UseVisualStyleBackColor = true;
            // 
            // gbColaboracoes
            // 
            this.gbColaboracoes.Controls.Add(this.btRemoverColaboracao);
            this.gbColaboracoes.Controls.Add(this.btAdicionarColaboracao);
            this.gbColaboracoes.Controls.Add(this.cbAnimadores);
            this.gbColaboracoes.Controls.Add(this.lbColaboracoes);
            this.gbColaboracoes.Location = new System.Drawing.Point(346, 340);
            this.gbColaboracoes.Name = "gbColaboracoes";
            this.gbColaboracoes.Size = new System.Drawing.Size(360, 134);
            this.gbColaboracoes.TabIndex = 1;
            this.gbColaboracoes.TabStop = false;
            this.gbColaboracoes.Text = "Colaboradores";
            // 
            // btRemoverColaboracao
            // 
            this.btRemoverColaboracao.Location = new System.Drawing.Point(214, 76);
            this.btRemoverColaboracao.Name = "btRemoverColaboracao";
            this.btRemoverColaboracao.Size = new System.Drawing.Size(134, 23);
            this.btRemoverColaboracao.TabIndex = 3;
            this.btRemoverColaboracao.Text = "Remover";
            this.btRemoverColaboracao.UseVisualStyleBackColor = true;
            // 
            // btAdicionarColaboracao
            // 
            this.btAdicionarColaboracao.Location = new System.Drawing.Point(214, 47);
            this.btAdicionarColaboracao.Name = "btAdicionarColaboracao";
            this.btAdicionarColaboracao.Size = new System.Drawing.Size(134, 23);
            this.btAdicionarColaboracao.TabIndex = 2;
            this.btAdicionarColaboracao.Text = "Adicionar";
            this.btAdicionarColaboracao.UseVisualStyleBackColor = true;
            // 
            // cbAnimadores
            // 
            this.cbAnimadores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAnimadores.FormattingEnabled = true;
            this.cbAnimadores.Location = new System.Drawing.Point(214, 20);
            this.cbAnimadores.Name = "cbAnimadores";
            this.cbAnimadores.Size = new System.Drawing.Size(134, 21);
            this.cbAnimadores.TabIndex = 1;
            // 
            // lbColaboracoes
            // 
            this.lbColaboracoes.FormattingEnabled = true;
            this.lbColaboracoes.Location = new System.Drawing.Point(7, 20);
            this.lbColaboracoes.Name = "lbColaboracoes";
            this.lbColaboracoes.Size = new System.Drawing.Size(184, 82);
            this.lbColaboracoes.TabIndex = 0;
            // 
            // gbEscolasInscritas
            // 
            this.gbEscolasInscritas.Controls.Add(this.clbEscolas);
            this.gbEscolasInscritas.Location = new System.Drawing.Point(346, 88);
            this.gbEscolasInscritas.Name = "gbEscolasInscritas";
            this.gbEscolasInscritas.Size = new System.Drawing.Size(237, 123);
            this.gbEscolasInscritas.TabIndex = 2;
            this.gbEscolasInscritas.TabStop = false;
            this.gbEscolasInscritas.Text = "Escolas ";
            // 
            // clbEscolas
            // 
            this.clbEscolas.FormattingEnabled = true;
            this.clbEscolas.Location = new System.Drawing.Point(6, 19);
            this.clbEscolas.Name = "clbEscolas";
            this.clbEscolas.Size = new System.Drawing.Size(222, 94);
            this.clbEscolas.TabIndex = 0;
            // 
            // FormEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 486);
            this.Controls.Add(this.gbEscolasInscritas);
            this.Controls.Add(this.gbColaboracoes);
            this.Controls.Add(this.gbEventos);
            this.Name = "FormEventos";
            this.Text = "FormEventos";
            this.gbEventos.ResumeLayout(false);
            this.gbDadosEvento.ResumeLayout(false);
            this.gbDadosEvento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmLimiteParticip)).EndInit();
            this.gbColaboracoes.ResumeLayout(false);
            this.gbEscolasInscritas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEventos;
        private System.Windows.Forms.GroupBox gbColaboracoes;
        private System.Windows.Forms.Button btRemoverColaboracao;
        private System.Windows.Forms.Button btAdicionarColaboracao;
        private System.Windows.Forms.ComboBox cbAnimadores;
        private System.Windows.Forms.ListBox lbColaboracoes;
        private System.Windows.Forms.Button btEditarEvento;
        private System.Windows.Forms.Button btApagarEvento;
        private System.Windows.Forms.Button btCriarEvento;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox gbDadosEvento;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btGuardarEvento;
        private System.Windows.Forms.TextBox tbTipoEve;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmLimiteParticip;
        private System.Windows.Forms.DateTimePicker dtpDataEve;
        private System.Windows.Forms.TextBox tbLocalEve;
        private System.Windows.Forms.TextBox tbDescricaoEve;
        private System.Windows.Forms.TextBox tbNrEvento;
        private System.Windows.Forms.GroupBox gbEscolasInscritas;
        private System.Windows.Forms.CheckedListBox clbEscolas;
    }
}