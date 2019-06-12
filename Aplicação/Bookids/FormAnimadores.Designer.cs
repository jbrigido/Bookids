namespace Bookids
{
    partial class FormAnimadores
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
            this.dgvAnimadores = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especialidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxAnimadores = new System.Windows.Forms.GroupBox();
            this.tbTelemovelAnimadores = new System.Windows.Forms.MaskedTextBox();
            this.tbTelefoneAnimadores = new System.Windows.Forms.MaskedTextBox();
            this.tbEspecialidadeAnimadores = new System.Windows.Forms.TextBox();
            this.labelEspecialidade = new System.Windows.Forms.Label();
            this.btCancelClean = new System.Windows.Forms.Button();
            this.labelMail = new System.Windows.Forms.Label();
            this.tbMailAnimadores = new System.Windows.Forms.TextBox();
            this.labelTelemovel = new System.Windows.Forms.Label();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.labelLocalidade = new System.Windows.Forms.Label();
            this.tbCodPostalAnimadores = new System.Windows.Forms.MaskedTextBox();
            this.labelCodPostal = new System.Windows.Forms.Label();
            this.labelMoradaAnimadores = new System.Windows.Forms.Label();
            this.labelNomeAnimadores = new System.Windows.Forms.Label();
            this.btEditarAnimadores = new System.Windows.Forms.Button();
            this.btAdicionarAnimadores = new System.Windows.Forms.Button();
            this.tbNomeAnimadores = new System.Windows.Forms.TextBox();
            this.btApagarAnimadores = new System.Windows.Forms.Button();
            this.btGuardarAnimadores = new System.Windows.Forms.Button();
            this.tbMoradaAnimadores = new System.Windows.Forms.TextBox();
            this.tbLocalidadeAnimadores = new System.Windows.Forms.TextBox();
            this.labelNomeForm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animadoresBindingSource)).BeginInit();
            this.groupBoxAnimadores.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAnimadores
            // 
            this.dgvAnimadores.AllowUserToAddRows = false;
            this.dgvAnimadores.AllowUserToDeleteRows = false;
            this.dgvAnimadores.AutoGenerateColumns = false;
            this.dgvAnimadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.localidadeDataGridViewTextBoxColumn,
            this.especialidadeDataGridViewTextBoxColumn});
            this.dgvAnimadores.DataSource = this.animadoresBindingSource;
            this.dgvAnimadores.Location = new System.Drawing.Point(289, 85);
            this.dgvAnimadores.Name = "dgvAnimadores";
            this.dgvAnimadores.ReadOnly = true;
            this.dgvAnimadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAnimadores.Size = new System.Drawing.Size(346, 383);
            this.dgvAnimadores.TabIndex = 37;
            this.dgvAnimadores.Click += new System.EventHandler(this.dgvAnimadores_Click);
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // localidadeDataGridViewTextBoxColumn
            // 
            this.localidadeDataGridViewTextBoxColumn.DataPropertyName = "Localidade";
            this.localidadeDataGridViewTextBoxColumn.HeaderText = "Localidade";
            this.localidadeDataGridViewTextBoxColumn.Name = "localidadeDataGridViewTextBoxColumn";
            this.localidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // especialidadeDataGridViewTextBoxColumn
            // 
            this.especialidadeDataGridViewTextBoxColumn.DataPropertyName = "Especialidade";
            this.especialidadeDataGridViewTextBoxColumn.HeaderText = "Especialidade";
            this.especialidadeDataGridViewTextBoxColumn.Name = "especialidadeDataGridViewTextBoxColumn";
            this.especialidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // animadoresBindingSource
            // 
            this.animadoresBindingSource.DataSource = typeof(Bookids.Animadores);
            // 
            // groupBoxAnimadores
            // 
            this.groupBoxAnimadores.Controls.Add(this.tbTelemovelAnimadores);
            this.groupBoxAnimadores.Controls.Add(this.tbTelefoneAnimadores);
            this.groupBoxAnimadores.Controls.Add(this.tbEspecialidadeAnimadores);
            this.groupBoxAnimadores.Controls.Add(this.labelEspecialidade);
            this.groupBoxAnimadores.Controls.Add(this.btCancelClean);
            this.groupBoxAnimadores.Controls.Add(this.labelMail);
            this.groupBoxAnimadores.Controls.Add(this.tbMailAnimadores);
            this.groupBoxAnimadores.Controls.Add(this.labelTelemovel);
            this.groupBoxAnimadores.Controls.Add(this.labelTelefone);
            this.groupBoxAnimadores.Controls.Add(this.labelLocalidade);
            this.groupBoxAnimadores.Controls.Add(this.tbCodPostalAnimadores);
            this.groupBoxAnimadores.Controls.Add(this.labelCodPostal);
            this.groupBoxAnimadores.Controls.Add(this.labelMoradaAnimadores);
            this.groupBoxAnimadores.Controls.Add(this.labelNomeAnimadores);
            this.groupBoxAnimadores.Controls.Add(this.btEditarAnimadores);
            this.groupBoxAnimadores.Controls.Add(this.btAdicionarAnimadores);
            this.groupBoxAnimadores.Controls.Add(this.tbNomeAnimadores);
            this.groupBoxAnimadores.Controls.Add(this.btApagarAnimadores);
            this.groupBoxAnimadores.Controls.Add(this.btGuardarAnimadores);
            this.groupBoxAnimadores.Controls.Add(this.tbMoradaAnimadores);
            this.groupBoxAnimadores.Controls.Add(this.tbLocalidadeAnimadores);
            this.groupBoxAnimadores.Location = new System.Drawing.Point(12, 85);
            this.groupBoxAnimadores.Name = "groupBoxAnimadores";
            this.groupBoxAnimadores.Size = new System.Drawing.Size(271, 383);
            this.groupBoxAnimadores.TabIndex = 38;
            this.groupBoxAnimadores.TabStop = false;
            this.groupBoxAnimadores.Text = "Dados Animadores";
            // 
            // tbTelemovelAnimadores
            // 
            this.tbTelemovelAnimadores.Location = new System.Drawing.Point(87, 153);
            this.tbTelemovelAnimadores.Mask = "000 000 000";
            this.tbTelemovelAnimadores.Name = "tbTelemovelAnimadores";
            this.tbTelemovelAnimadores.Size = new System.Drawing.Size(69, 20);
            this.tbTelemovelAnimadores.TabIndex = 51;
            // 
            // tbTelefoneAnimadores
            // 
            this.tbTelefoneAnimadores.Location = new System.Drawing.Point(87, 127);
            this.tbTelefoneAnimadores.Mask = "000 000 000";
            this.tbTelefoneAnimadores.Name = "tbTelefoneAnimadores";
            this.tbTelefoneAnimadores.Size = new System.Drawing.Size(69, 20);
            this.tbTelefoneAnimadores.TabIndex = 50;
            // 
            // tbEspecialidadeAnimadores
            // 
            this.tbEspecialidadeAnimadores.Location = new System.Drawing.Point(87, 209);
            this.tbEspecialidadeAnimadores.Name = "tbEspecialidadeAnimadores";
            this.tbEspecialidadeAnimadores.Size = new System.Drawing.Size(177, 20);
            this.tbEspecialidadeAnimadores.TabIndex = 49;
            // 
            // labelEspecialidade
            // 
            this.labelEspecialidade.AutoSize = true;
            this.labelEspecialidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelEspecialidade.Location = new System.Drawing.Point(6, 212);
            this.labelEspecialidade.Name = "labelEspecialidade";
            this.labelEspecialidade.Size = new System.Drawing.Size(76, 13);
            this.labelEspecialidade.TabIndex = 48;
            this.labelEspecialidade.Text = "Especialidade:";
            // 
            // btCancelClean
            // 
            this.btCancelClean.Location = new System.Drawing.Point(6, 355);
            this.btCancelClean.Name = "btCancelClean";
            this.btCancelClean.Size = new System.Drawing.Size(258, 23);
            this.btCancelClean.TabIndex = 47;
            this.btCancelClean.Text = "Cancelar/Limpar Seleção";
            this.btCancelClean.UseVisualStyleBackColor = true;
            this.btCancelClean.Click += new System.EventHandler(this.btCancelClean_Click);
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelMail.Location = new System.Drawing.Point(6, 182);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(39, 13);
            this.labelMail.TabIndex = 46;
            this.labelMail.Text = "E-Mail:";
            // 
            // tbMailAnimadores
            // 
            this.tbMailAnimadores.Location = new System.Drawing.Point(87, 179);
            this.tbMailAnimadores.Name = "tbMailAnimadores";
            this.tbMailAnimadores.Size = new System.Drawing.Size(177, 20);
            this.tbMailAnimadores.TabIndex = 45;
            // 
            // labelTelemovel
            // 
            this.labelTelemovel.AutoSize = true;
            this.labelTelemovel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelTelemovel.Location = new System.Drawing.Point(6, 156);
            this.labelTelemovel.Name = "labelTelemovel";
            this.labelTelemovel.Size = new System.Drawing.Size(67, 13);
            this.labelTelemovel.TabIndex = 44;
            this.labelTelemovel.Text = "**Telemóvel:";
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelTelefone.Location = new System.Drawing.Point(6, 130);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(60, 13);
            this.labelTelefone.TabIndex = 43;
            this.labelTelefone.Text = "**Telefone:";
            // 
            // labelLocalidade
            // 
            this.labelLocalidade.AutoSize = true;
            this.labelLocalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelLocalidade.Location = new System.Drawing.Point(6, 104);
            this.labelLocalidade.Name = "labelLocalidade";
            this.labelLocalidade.Size = new System.Drawing.Size(66, 13);
            this.labelLocalidade.TabIndex = 42;
            this.labelLocalidade.Text = "*Localidade:";
            // 
            // tbCodPostalAnimadores
            // 
            this.tbCodPostalAnimadores.Location = new System.Drawing.Point(87, 75);
            this.tbCodPostalAnimadores.Mask = "0000-000";
            this.tbCodPostalAnimadores.Name = "tbCodPostalAnimadores";
            this.tbCodPostalAnimadores.Size = new System.Drawing.Size(54, 20);
            this.tbCodPostalAnimadores.TabIndex = 39;
            // 
            // labelCodPostal
            // 
            this.labelCodPostal.AutoSize = true;
            this.labelCodPostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelCodPostal.Location = new System.Drawing.Point(6, 78);
            this.labelCodPostal.Name = "labelCodPostal";
            this.labelCodPostal.Size = new System.Drawing.Size(79, 13);
            this.labelCodPostal.TabIndex = 41;
            this.labelCodPostal.Text = "*Código Postal:";
            // 
            // labelMoradaAnimadores
            // 
            this.labelMoradaAnimadores.AutoSize = true;
            this.labelMoradaAnimadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelMoradaAnimadores.Location = new System.Drawing.Point(6, 52);
            this.labelMoradaAnimadores.Name = "labelMoradaAnimadores";
            this.labelMoradaAnimadores.Size = new System.Drawing.Size(50, 13);
            this.labelMoradaAnimadores.TabIndex = 40;
            this.labelMoradaAnimadores.Text = "*Morada:";
            // 
            // labelNomeAnimadores
            // 
            this.labelNomeAnimadores.AutoSize = true;
            this.labelNomeAnimadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelNomeAnimadores.Location = new System.Drawing.Point(6, 22);
            this.labelNomeAnimadores.Name = "labelNomeAnimadores";
            this.labelNomeAnimadores.Size = new System.Drawing.Size(42, 13);
            this.labelNomeAnimadores.TabIndex = 39;
            this.labelNomeAnimadores.Text = "*Nome:";
            // 
            // btEditarAnimadores
            // 
            this.btEditarAnimadores.Location = new System.Drawing.Point(6, 268);
            this.btEditarAnimadores.Name = "btEditarAnimadores";
            this.btEditarAnimadores.Size = new System.Drawing.Size(258, 23);
            this.btEditarAnimadores.TabIndex = 36;
            this.btEditarAnimadores.Text = "Editar Animador";
            this.btEditarAnimadores.UseVisualStyleBackColor = true;
            this.btEditarAnimadores.Click += new System.EventHandler(this.btEditarAnimadores_Click);
            // 
            // btAdicionarAnimadores
            // 
            this.btAdicionarAnimadores.Location = new System.Drawing.Point(6, 239);
            this.btAdicionarAnimadores.Name = "btAdicionarAnimadores";
            this.btAdicionarAnimadores.Size = new System.Drawing.Size(258, 23);
            this.btAdicionarAnimadores.TabIndex = 35;
            this.btAdicionarAnimadores.Text = "Adicionar Animador";
            this.btAdicionarAnimadores.UseVisualStyleBackColor = true;
            this.btAdicionarAnimadores.Click += new System.EventHandler(this.btAdicionarAnimadores_Click);
            // 
            // tbNomeAnimadores
            // 
            this.tbNomeAnimadores.Location = new System.Drawing.Point(87, 19);
            this.tbNomeAnimadores.Name = "tbNomeAnimadores";
            this.tbNomeAnimadores.Size = new System.Drawing.Size(177, 20);
            this.tbNomeAnimadores.TabIndex = 23;
            // 
            // btApagarAnimadores
            // 
            this.btApagarAnimadores.Location = new System.Drawing.Point(6, 326);
            this.btApagarAnimadores.Name = "btApagarAnimadores";
            this.btApagarAnimadores.Size = new System.Drawing.Size(258, 23);
            this.btApagarAnimadores.TabIndex = 34;
            this.btApagarAnimadores.Text = "Apagar Animadores";
            this.btApagarAnimadores.UseVisualStyleBackColor = true;
            this.btApagarAnimadores.Click += new System.EventHandler(this.btApagarAnimadores_Click);
            // 
            // btGuardarAnimadores
            // 
            this.btGuardarAnimadores.Location = new System.Drawing.Point(6, 297);
            this.btGuardarAnimadores.Name = "btGuardarAnimadores";
            this.btGuardarAnimadores.Size = new System.Drawing.Size(258, 23);
            this.btGuardarAnimadores.TabIndex = 32;
            this.btGuardarAnimadores.Text = "Guardar Alterações";
            this.btGuardarAnimadores.UseVisualStyleBackColor = true;
            this.btGuardarAnimadores.Click += new System.EventHandler(this.btGuardarAnimadores_Click);
            // 
            // tbMoradaAnimadores
            // 
            this.tbMoradaAnimadores.Location = new System.Drawing.Point(87, 49);
            this.tbMoradaAnimadores.Name = "tbMoradaAnimadores";
            this.tbMoradaAnimadores.Size = new System.Drawing.Size(177, 20);
            this.tbMoradaAnimadores.TabIndex = 25;
            // 
            // tbLocalidadeAnimadores
            // 
            this.tbLocalidadeAnimadores.Location = new System.Drawing.Point(87, 101);
            this.tbLocalidadeAnimadores.Name = "tbLocalidadeAnimadores";
            this.tbLocalidadeAnimadores.Size = new System.Drawing.Size(177, 20);
            this.tbLocalidadeAnimadores.TabIndex = 29;
            // 
            // labelNomeForm
            // 
            this.labelNomeForm.AutoSize = true;
            this.labelNomeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeForm.Location = new System.Drawing.Point(9, 9);
            this.labelNomeForm.Name = "labelNomeForm";
            this.labelNomeForm.Size = new System.Drawing.Size(295, 59);
            this.labelNomeForm.TabIndex = 39;
            this.labelNomeForm.Text = "Animadores";
            // 
            // FormAnimadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 480);
            this.Controls.Add(this.labelNomeForm);
            this.Controls.Add(this.groupBoxAnimadores);
            this.Controls.Add(this.dgvAnimadores);
            this.Name = "FormAnimadores";
            this.ShowIcon = false;
            this.Text = "Bookids - Animadores";
            this.Load += new System.EventHandler(this.FormAnimadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animadoresBindingSource)).EndInit();
            this.groupBoxAnimadores.ResumeLayout(false);
            this.groupBoxAnimadores.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAnimadores;
        private System.Windows.Forms.BindingSource animadoresBindingSource;
        private System.Windows.Forms.GroupBox groupBoxAnimadores;
        private System.Windows.Forms.Label labelTelemovel;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.Label labelLocalidade;
        private System.Windows.Forms.MaskedTextBox tbCodPostalAnimadores;
        private System.Windows.Forms.Label labelCodPostal;
        private System.Windows.Forms.Label labelMoradaAnimadores;
        private System.Windows.Forms.Label labelNomeAnimadores;
        private System.Windows.Forms.Button btEditarAnimadores;
        private System.Windows.Forms.Button btAdicionarAnimadores;
        private System.Windows.Forms.TextBox tbNomeAnimadores;
        private System.Windows.Forms.Button btApagarAnimadores;
        private System.Windows.Forms.Button btGuardarAnimadores;
        private System.Windows.Forms.TextBox tbMoradaAnimadores;
        private System.Windows.Forms.TextBox tbLocalidadeAnimadores;
        private System.Windows.Forms.TextBox tbMailAnimadores;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Button btCancelClean;
        private System.Windows.Forms.TextBox tbEspecialidadeAnimadores;
        private System.Windows.Forms.Label labelEspecialidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.MaskedTextBox tbTelemovelAnimadores;
        private System.Windows.Forms.MaskedTextBox tbTelefoneAnimadores;
        private System.Windows.Forms.Label labelNomeForm;
    }
}