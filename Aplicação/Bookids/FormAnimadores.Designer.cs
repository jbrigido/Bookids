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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.especialidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codPostalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telemovelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxAnimadores = new System.Windows.Forms.GroupBox();
            this.labelTelemovel = new System.Windows.Forms.Label();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.labelLocalidade = new System.Windows.Forms.Label();
            this.tbCodPostalAnimadores = new System.Windows.Forms.MaskedTextBox();
            this.labelCodPostal = new System.Windows.Forms.Label();
            this.labelMoradaAnimadores = new System.Windows.Forms.Label();
            this.labelNomeAnimadores = new System.Windows.Forms.Label();
            this.btEditarAnimadores = new System.Windows.Forms.Button();
            this.btAdicionarAnimaodres = new System.Windows.Forms.Button();
            this.tbNomeAnimadores = new System.Windows.Forms.TextBox();
            this.btApagarAnimadores = new System.Windows.Forms.Button();
            this.btGuardarAnimadores = new System.Windows.Forms.Button();
            this.tbTelefoneAnimadores = new System.Windows.Forms.TextBox();
            this.tbMoradaAnimadores = new System.Windows.Forms.TextBox();
            this.tbLocalidadeAnimadores = new System.Windows.Forms.TextBox();
            this.tbTelemovelAnimadores = new System.Windows.Forms.TextBox();
            this.tbMailAnimadores = new System.Windows.Forms.TextBox();
            this.labelMail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animadoresBindingSource)).BeginInit();
            this.groupBoxAnimadores.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.especialidadeDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.moradaDataGridViewTextBoxColumn,
            this.localidadeDataGridViewTextBoxColumn,
            this.codPostalDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.telemovelDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.animadoresBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(259, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(511, 332);
            this.dataGridView1.TabIndex = 37;
            // 
            // especialidadeDataGridViewTextBoxColumn
            // 
            this.especialidadeDataGridViewTextBoxColumn.DataPropertyName = "Especialidade";
            this.especialidadeDataGridViewTextBoxColumn.HeaderText = "Especialidade";
            this.especialidadeDataGridViewTextBoxColumn.Name = "especialidadeDataGridViewTextBoxColumn";
            this.especialidadeDataGridViewTextBoxColumn.ReadOnly = true;
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
            // animadoresBindingSource
            // 
            this.animadoresBindingSource.DataSource = typeof(Bookids.Animadores);
            // 
            // groupBoxAnimadores
            // 
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
            this.groupBoxAnimadores.Controls.Add(this.btAdicionarAnimaodres);
            this.groupBoxAnimadores.Controls.Add(this.tbNomeAnimadores);
            this.groupBoxAnimadores.Controls.Add(this.btApagarAnimadores);
            this.groupBoxAnimadores.Controls.Add(this.btGuardarAnimadores);
            this.groupBoxAnimadores.Controls.Add(this.tbTelefoneAnimadores);
            this.groupBoxAnimadores.Controls.Add(this.tbMoradaAnimadores);
            this.groupBoxAnimadores.Controls.Add(this.tbLocalidadeAnimadores);
            this.groupBoxAnimadores.Controls.Add(this.tbTelemovelAnimadores);
            this.groupBoxAnimadores.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAnimadores.Name = "groupBoxAnimadores";
            this.groupBoxAnimadores.Size = new System.Drawing.Size(241, 332);
            this.groupBoxAnimadores.TabIndex = 38;
            this.groupBoxAnimadores.TabStop = false;
            this.groupBoxAnimadores.Text = "Dados Animadores";
            // 
            // labelTelemovel
            // 
            this.labelTelemovel.AutoSize = true;
            this.labelTelemovel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelTelemovel.Location = new System.Drawing.Point(6, 156);
            this.labelTelemovel.Name = "labelTelemovel";
            this.labelTelemovel.Size = new System.Drawing.Size(59, 13);
            this.labelTelemovel.TabIndex = 44;
            this.labelTelemovel.Text = "Telemóvel:";
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelTelefone.Location = new System.Drawing.Point(6, 130);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(52, 13);
            this.labelTelefone.TabIndex = 43;
            this.labelTelefone.Text = "Telefone:";
            // 
            // labelLocalidade
            // 
            this.labelLocalidade.AutoSize = true;
            this.labelLocalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelLocalidade.Location = new System.Drawing.Point(6, 104);
            this.labelLocalidade.Name = "labelLocalidade";
            this.labelLocalidade.Size = new System.Drawing.Size(62, 13);
            this.labelLocalidade.TabIndex = 42;
            this.labelLocalidade.Text = "Localidade:";
            // 
            // tbCodPostalAnimadores
            // 
            this.tbCodPostalAnimadores.Location = new System.Drawing.Point(87, 71);
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
            this.labelCodPostal.Size = new System.Drawing.Size(75, 13);
            this.labelCodPostal.TabIndex = 41;
            this.labelCodPostal.Text = "Código Postal:";
            // 
            // labelMoradaAnimadores
            // 
            this.labelMoradaAnimadores.AutoSize = true;
            this.labelMoradaAnimadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelMoradaAnimadores.Location = new System.Drawing.Point(6, 52);
            this.labelMoradaAnimadores.Name = "labelMoradaAnimadores";
            this.labelMoradaAnimadores.Size = new System.Drawing.Size(46, 13);
            this.labelMoradaAnimadores.TabIndex = 40;
            this.labelMoradaAnimadores.Text = "Morada:";
            // 
            // labelNomeAnimadores
            // 
            this.labelNomeAnimadores.AutoSize = true;
            this.labelNomeAnimadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelNomeAnimadores.Location = new System.Drawing.Point(6, 26);
            this.labelNomeAnimadores.Name = "labelNomeAnimadores";
            this.labelNomeAnimadores.Size = new System.Drawing.Size(38, 13);
            this.labelNomeAnimadores.TabIndex = 39;
            this.labelNomeAnimadores.Text = "Nome:";
            // 
            // btEditarAnimadores
            // 
            this.btEditarAnimadores.Location = new System.Drawing.Point(6, 241);
            this.btEditarAnimadores.Name = "btEditarAnimadores";
            this.btEditarAnimadores.Size = new System.Drawing.Size(229, 23);
            this.btEditarAnimadores.TabIndex = 36;
            this.btEditarAnimadores.Text = "Editar Animador";
            this.btEditarAnimadores.UseVisualStyleBackColor = true;
            // 
            // btAdicionarAnimaodres
            // 
            this.btAdicionarAnimaodres.Location = new System.Drawing.Point(6, 212);
            this.btAdicionarAnimaodres.Name = "btAdicionarAnimaodres";
            this.btAdicionarAnimaodres.Size = new System.Drawing.Size(229, 23);
            this.btAdicionarAnimaodres.TabIndex = 35;
            this.btAdicionarAnimaodres.Text = "Adicionar Animador";
            this.btAdicionarAnimaodres.UseVisualStyleBackColor = true;
            // 
            // tbNomeAnimadores
            // 
            this.tbNomeAnimadores.Location = new System.Drawing.Point(58, 19);
            this.tbNomeAnimadores.Name = "tbNomeAnimadores";
            this.tbNomeAnimadores.Size = new System.Drawing.Size(177, 20);
            this.tbNomeAnimadores.TabIndex = 23;
            // 
            // btApagarAnimadores
            // 
            this.btApagarAnimadores.Location = new System.Drawing.Point(6, 299);
            this.btApagarAnimadores.Name = "btApagarAnimadores";
            this.btApagarAnimadores.Size = new System.Drawing.Size(229, 23);
            this.btApagarAnimadores.TabIndex = 34;
            this.btApagarAnimadores.Text = "Apagar Animadores";
            this.btApagarAnimadores.UseVisualStyleBackColor = true;
            // 
            // btGuardarAnimadores
            // 
            this.btGuardarAnimadores.Location = new System.Drawing.Point(6, 270);
            this.btGuardarAnimadores.Name = "btGuardarAnimadores";
            this.btGuardarAnimadores.Size = new System.Drawing.Size(229, 23);
            this.btGuardarAnimadores.TabIndex = 32;
            this.btGuardarAnimadores.Text = "Guardar Alterações";
            this.btGuardarAnimadores.UseVisualStyleBackColor = true;
            // 
            // tbTelefoneAnimadores
            // 
            this.tbTelefoneAnimadores.Location = new System.Drawing.Point(74, 123);
            this.tbTelefoneAnimadores.Name = "tbTelefoneAnimadores";
            this.tbTelefoneAnimadores.Size = new System.Drawing.Size(161, 20);
            this.tbTelefoneAnimadores.TabIndex = 27;
            // 
            // tbMoradaAnimadores
            // 
            this.tbMoradaAnimadores.Location = new System.Drawing.Point(58, 45);
            this.tbMoradaAnimadores.Name = "tbMoradaAnimadores";
            this.tbMoradaAnimadores.Size = new System.Drawing.Size(177, 20);
            this.tbMoradaAnimadores.TabIndex = 25;
            // 
            // tbLocalidadeAnimadores
            // 
            this.tbLocalidadeAnimadores.Location = new System.Drawing.Point(74, 97);
            this.tbLocalidadeAnimadores.Name = "tbLocalidadeAnimadores";
            this.tbLocalidadeAnimadores.Size = new System.Drawing.Size(161, 20);
            this.tbLocalidadeAnimadores.TabIndex = 29;
            // 
            // tbTelemovelAnimadores
            // 
            this.tbTelemovelAnimadores.Location = new System.Drawing.Point(74, 149);
            this.tbTelemovelAnimadores.Name = "tbTelemovelAnimadores";
            this.tbTelemovelAnimadores.Size = new System.Drawing.Size(161, 20);
            this.tbTelemovelAnimadores.TabIndex = 30;
            // 
            // tbMailAnimadores
            // 
            this.tbMailAnimadores.Location = new System.Drawing.Point(74, 175);
            this.tbMailAnimadores.Name = "tbMailAnimadores";
            this.tbMailAnimadores.Size = new System.Drawing.Size(161, 20);
            this.tbMailAnimadores.TabIndex = 45;
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
            // FormAnimadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 365);
            this.Controls.Add(this.groupBoxAnimadores);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormAnimadores";
            this.Text = "FormAnimadores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animadoresBindingSource)).EndInit();
            this.groupBoxAnimadores.ResumeLayout(false);
            this.groupBoxAnimadores.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codPostalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telemovelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.Button btAdicionarAnimaodres;
        private System.Windows.Forms.TextBox tbNomeAnimadores;
        private System.Windows.Forms.Button btApagarAnimadores;
        private System.Windows.Forms.Button btGuardarAnimadores;
        private System.Windows.Forms.TextBox tbTelefoneAnimadores;
        private System.Windows.Forms.TextBox tbMoradaAnimadores;
        private System.Windows.Forms.TextBox tbLocalidadeAnimadores;
        private System.Windows.Forms.TextBox tbTelemovelAnimadores;
        private System.Windows.Forms.TextBox tbMailAnimadores;
        private System.Windows.Forms.Label labelMail;
    }
}