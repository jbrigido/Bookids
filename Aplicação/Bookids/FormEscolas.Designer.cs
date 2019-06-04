namespace Bookids
{
    partial class FormEscolas
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
            this.groupBoxEscolas = new System.Windows.Forms.GroupBox();
            this.tbTelefoneEscolas = new System.Windows.Forms.MaskedTextBox();
            this.btCancelClean = new System.Windows.Forms.Button();
            this.labelMailEscolas = new System.Windows.Forms.Label();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.labelLocalidade = new System.Windows.Forms.Label();
            this.tbCodPostalEscolas = new System.Windows.Forms.MaskedTextBox();
            this.labelCodPostal = new System.Windows.Forms.Label();
            this.labelMoradaEscola = new System.Windows.Forms.Label();
            this.labelNomeEscola = new System.Windows.Forms.Label();
            this.btEditarEscola = new System.Windows.Forms.Button();
            this.btAdicionarEscola = new System.Windows.Forms.Button();
            this.tbNomeEscolas = new System.Windows.Forms.TextBox();
            this.btApagarEscola = new System.Windows.Forms.Button();
            this.btGuardarEscola = new System.Windows.Forms.Button();
            this.tbMoradaEscolas = new System.Windows.Forms.TextBox();
            this.tbLocalidadeEscolas = new System.Windows.Forms.TextBox();
            this.tbMailEscolas = new System.Windows.Forms.TextBox();
            this.dgvEscolas = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.escolasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxEscolas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEscolas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escolasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxEscolas
            // 
            this.groupBoxEscolas.Controls.Add(this.tbTelefoneEscolas);
            this.groupBoxEscolas.Controls.Add(this.btCancelClean);
            this.groupBoxEscolas.Controls.Add(this.labelMailEscolas);
            this.groupBoxEscolas.Controls.Add(this.labelTelefone);
            this.groupBoxEscolas.Controls.Add(this.labelLocalidade);
            this.groupBoxEscolas.Controls.Add(this.tbCodPostalEscolas);
            this.groupBoxEscolas.Controls.Add(this.labelCodPostal);
            this.groupBoxEscolas.Controls.Add(this.labelMoradaEscola);
            this.groupBoxEscolas.Controls.Add(this.labelNomeEscola);
            this.groupBoxEscolas.Controls.Add(this.btEditarEscola);
            this.groupBoxEscolas.Controls.Add(this.btAdicionarEscola);
            this.groupBoxEscolas.Controls.Add(this.tbNomeEscolas);
            this.groupBoxEscolas.Controls.Add(this.btApagarEscola);
            this.groupBoxEscolas.Controls.Add(this.btGuardarEscola);
            this.groupBoxEscolas.Controls.Add(this.tbMoradaEscolas);
            this.groupBoxEscolas.Controls.Add(this.tbLocalidadeEscolas);
            this.groupBoxEscolas.Controls.Add(this.tbMailEscolas);
            this.groupBoxEscolas.Location = new System.Drawing.Point(12, 12);
            this.groupBoxEscolas.Name = "groupBoxEscolas";
            this.groupBoxEscolas.Size = new System.Drawing.Size(241, 332);
            this.groupBoxEscolas.TabIndex = 37;
            this.groupBoxEscolas.TabStop = false;
            this.groupBoxEscolas.Text = "Dados Escolas";
            // 
            // tbTelefoneEscolas
            // 
            this.tbTelefoneEscolas.Location = new System.Drawing.Point(74, 123);
            this.tbTelefoneEscolas.Mask = "000 000 000";
            this.tbTelefoneEscolas.Name = "tbTelefoneEscolas";
            this.tbTelefoneEscolas.Size = new System.Drawing.Size(69, 20);
            this.tbTelefoneEscolas.TabIndex = 46;            // 
            // btCancelClean
            // 
            this.btCancelClean.Location = new System.Drawing.Point(6, 301);
            this.btCancelClean.Name = "btCancelClean";
            this.btCancelClean.Size = new System.Drawing.Size(229, 23);
            this.btCancelClean.TabIndex = 45;
            this.btCancelClean.Text = "Cancelar/Limpar Selecção";
            this.btCancelClean.UseVisualStyleBackColor = true;
            this.btCancelClean.Click += new System.EventHandler(this.btCancelClean_Click);
            // 
            // labelMailEscolas
            // 
            this.labelMailEscolas.AutoSize = true;
            this.labelMailEscolas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelMailEscolas.Location = new System.Drawing.Point(6, 156);
            this.labelMailEscolas.Name = "labelMailEscolas";
            this.labelMailEscolas.Size = new System.Drawing.Size(39, 13);
            this.labelMailEscolas.TabIndex = 44;
            this.labelMailEscolas.Text = "E-Mail:";
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelTelefone.Location = new System.Drawing.Point(6, 130);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(56, 13);
            this.labelTelefone.TabIndex = 43;
            this.labelTelefone.Text = "*Telefone:";
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
            // tbCodPostalEscolas
            // 
            this.tbCodPostalEscolas.Location = new System.Drawing.Point(87, 71);
            this.tbCodPostalEscolas.Mask = "0000-000";
            this.tbCodPostalEscolas.Name = "tbCodPostalEscolas";
            this.tbCodPostalEscolas.Size = new System.Drawing.Size(54, 20);
            this.tbCodPostalEscolas.TabIndex = 39;
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
            // labelMoradaEscola
            // 
            this.labelMoradaEscola.AutoSize = true;
            this.labelMoradaEscola.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelMoradaEscola.Location = new System.Drawing.Point(6, 52);
            this.labelMoradaEscola.Name = "labelMoradaEscola";
            this.labelMoradaEscola.Size = new System.Drawing.Size(46, 13);
            this.labelMoradaEscola.TabIndex = 40;
            this.labelMoradaEscola.Text = "Morada:";
            // 
            // labelNomeEscola
            // 
            this.labelNomeEscola.AutoSize = true;
            this.labelNomeEscola.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelNomeEscola.Location = new System.Drawing.Point(6, 26);
            this.labelNomeEscola.Name = "labelNomeEscola";
            this.labelNomeEscola.Size = new System.Drawing.Size(42, 13);
            this.labelNomeEscola.TabIndex = 39;
            this.labelNomeEscola.Text = "*Nome:";
            // 
            // btEditarEscola
            // 
            this.btEditarEscola.Location = new System.Drawing.Point(6, 214);
            this.btEditarEscola.Name = "btEditarEscola";
            this.btEditarEscola.Size = new System.Drawing.Size(229, 23);
            this.btEditarEscola.TabIndex = 36;
            this.btEditarEscola.Text = "Editar Escola";
            this.btEditarEscola.UseVisualStyleBackColor = true;
            this.btEditarEscola.Click += new System.EventHandler(this.btEditarEscola_Click);
            // 
            // btAdicionarEscola
            // 
            this.btAdicionarEscola.Location = new System.Drawing.Point(6, 185);
            this.btAdicionarEscola.Name = "btAdicionarEscola";
            this.btAdicionarEscola.Size = new System.Drawing.Size(229, 23);
            this.btAdicionarEscola.TabIndex = 35;
            this.btAdicionarEscola.Text = "Adicionar Escola";
            this.btAdicionarEscola.UseVisualStyleBackColor = true;
            this.btAdicionarEscola.Click += new System.EventHandler(this.btAdicionarEscola_Click);
            // 
            // tbNomeEscolas
            // 
            this.tbNomeEscolas.Location = new System.Drawing.Point(58, 19);
            this.tbNomeEscolas.Name = "tbNomeEscolas";
            this.tbNomeEscolas.Size = new System.Drawing.Size(177, 20);
            this.tbNomeEscolas.TabIndex = 23;
            // 
            // btApagarEscola
            // 
            this.btApagarEscola.Location = new System.Drawing.Point(6, 272);
            this.btApagarEscola.Name = "btApagarEscola";
            this.btApagarEscola.Size = new System.Drawing.Size(229, 23);
            this.btApagarEscola.TabIndex = 34;
            this.btApagarEscola.Text = "Apagar Escola";
            this.btApagarEscola.UseVisualStyleBackColor = true;
            this.btApagarEscola.Click += new System.EventHandler(this.btApagarEscola_Click);
            // 
            // btGuardarEscola
            // 
            this.btGuardarEscola.Location = new System.Drawing.Point(6, 243);
            this.btGuardarEscola.Name = "btGuardarEscola";
            this.btGuardarEscola.Size = new System.Drawing.Size(229, 23);
            this.btGuardarEscola.TabIndex = 32;
            this.btGuardarEscola.Text = "Guardar Alterações";
            this.btGuardarEscola.UseVisualStyleBackColor = true;
            this.btGuardarEscola.Click += new System.EventHandler(this.btGuardarEscola_Click);
            // 
            // tbMoradaEscolas
            // 
            this.tbMoradaEscolas.Location = new System.Drawing.Point(58, 45);
            this.tbMoradaEscolas.Name = "tbMoradaEscolas";
            this.tbMoradaEscolas.Size = new System.Drawing.Size(177, 20);
            this.tbMoradaEscolas.TabIndex = 25;
            // 
            // tbLocalidadeEscolas
            // 
            this.tbLocalidadeEscolas.Location = new System.Drawing.Point(74, 97);
            this.tbLocalidadeEscolas.Name = "tbLocalidadeEscolas";
            this.tbLocalidadeEscolas.Size = new System.Drawing.Size(161, 20);
            this.tbLocalidadeEscolas.TabIndex = 29;
            // 
            // tbMailEscolas
            // 
            this.tbMailEscolas.Location = new System.Drawing.Point(74, 149);
            this.tbMailEscolas.Name = "tbMailEscolas";
            this.tbMailEscolas.Size = new System.Drawing.Size(161, 20);
            this.tbMailEscolas.TabIndex = 30;
            // 
            // dgvEscolas
            // 
            this.dgvEscolas.AllowUserToAddRows = false;
            this.dgvEscolas.AllowUserToDeleteRows = false;
            this.dgvEscolas.AutoGenerateColumns = false;
            this.dgvEscolas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEscolas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.localidadeDataGridViewTextBoxColumn});
            this.dgvEscolas.DataSource = this.escolasBindingSource;
            this.dgvEscolas.Location = new System.Drawing.Point(259, 12);
            this.dgvEscolas.Name = "dgvEscolas";
            this.dgvEscolas.ReadOnly = true;
            this.dgvEscolas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEscolas.Size = new System.Drawing.Size(347, 332);
            this.dgvEscolas.TabIndex = 38;
            this.dgvEscolas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvEscolas_MouseClick);
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // localidadeDataGridViewTextBoxColumn
            // 
            this.localidadeDataGridViewTextBoxColumn.DataPropertyName = "Localidade";
            this.localidadeDataGridViewTextBoxColumn.HeaderText = "Localidade";
            this.localidadeDataGridViewTextBoxColumn.Name = "localidadeDataGridViewTextBoxColumn";
            this.localidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // escolasBindingSource
            // 
            this.escolasBindingSource.DataSource = typeof(Bookids.Escolas);
            // 
            // FormEscolas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 356);
            this.Controls.Add(this.dgvEscolas);
            this.Controls.Add(this.groupBoxEscolas);
            this.Name = "FormEscolas";
            this.Text = "FormEscolas";
            this.Load += new System.EventHandler(this.FormEscolas_Load);
            this.groupBoxEscolas.ResumeLayout(false);
            this.groupBoxEscolas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEscolas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escolasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEscolas;
        private System.Windows.Forms.TextBox tbNomeEscolas;
        private System.Windows.Forms.Button btApagarEscola;
        private System.Windows.Forms.Button btGuardarEscola;
        private System.Windows.Forms.TextBox tbMoradaEscolas;
        private System.Windows.Forms.TextBox tbLocalidadeEscolas;
        private System.Windows.Forms.TextBox tbMailEscolas;
        private System.Windows.Forms.Button btAdicionarEscola;
        private System.Windows.Forms.Button btEditarEscola;
        private System.Windows.Forms.DataGridView dgvEscolas;
        private System.Windows.Forms.BindingSource escolasBindingSource;
        private System.Windows.Forms.Label labelNomeEscola;
        private System.Windows.Forms.Label labelMoradaEscola;
        private System.Windows.Forms.Label labelCodPostal;
        private System.Windows.Forms.MaskedTextBox tbCodPostalEscolas;
        private System.Windows.Forms.Label labelMailEscolas;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.Label labelLocalidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btCancelClean;
        private System.Windows.Forms.MaskedTextBox tbTelefoneEscolas;
    }
}