namespace Bookids
{
    partial class FormProdutosLoja
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProdutosLoja = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btAdicionarProduto = new System.Windows.Forms.Button();
            this.btEditarProduto = new System.Windows.Forms.Button();
            this.btApagarProduto = new System.Windows.Forms.Button();
            this.btGuardarProduto = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nmStockProduto = new System.Windows.Forms.NumericUpDown();
            this.tbCodProduto = new System.Windows.Forms.TextBox();
            this.nmPreco = new System.Windows.Forms.NumericUpDown();
            this.cbTipoProduto = new System.Windows.Forms.ComboBox();
            this.tbDesignacao = new System.Windows.Forms.TextBox();
            this.btAdicionarTipo = new System.Windows.Forms.Button();
            this.menuEditarTipo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbPL = new System.Windows.Forms.GroupBox();
            this.btCancelClean = new System.Windows.Forms.Button();
            this.labelNomeForm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosLoja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmStockProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPreco)).BeginInit();
            this.menuEditarTipo.SuspendLayout();
            this.gbPL.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProdutosLoja
            // 
            this.dgvProdutosLoja.AllowUserToAddRows = false;
            this.dgvProdutosLoja.AllowUserToDeleteRows = false;
            this.dgvProdutosLoja.AllowUserToOrderColumns = true;
            this.dgvProdutosLoja.AutoGenerateColumns = false;
            this.dgvProdutosLoja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutosLoja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7});
            this.dgvProdutosLoja.DataSource = this.produtosBindingSource;
            this.dgvProdutosLoja.Location = new System.Drawing.Point(289, 71);
            this.dgvProdutosLoja.Name = "dgvProdutosLoja";
            this.dgvProdutosLoja.ReadOnly = true;
            this.dgvProdutosLoja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutosLoja.Size = new System.Drawing.Size(543, 300);
            this.dgvProdutosLoja.TabIndex = 1;
            this.dgvProdutosLoja.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvProdutosLoja_MouseClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Designacao";
            this.dataGridViewTextBoxColumn2.HeaderText = "Designacao";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CodProduto";
            this.dataGridViewTextBoxColumn1.HeaderText = "CodProduto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Preco";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = "0,00";
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn3.HeaderText = "Preco";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "StockExistente";
            this.dataGridViewTextBoxColumn5.HeaderText = "StockExistente";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TipoProduto";
            this.dataGridViewTextBoxColumn7.HeaderText = "TipoProduto";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataSource = typeof(Bookids.Produtos);
            // 
            // btAdicionarProduto
            // 
            this.btAdicionarProduto.Location = new System.Drawing.Point(6, 150);
            this.btAdicionarProduto.Name = "btAdicionarProduto";
            this.btAdicionarProduto.Size = new System.Drawing.Size(254, 23);
            this.btAdicionarProduto.TabIndex = 2;
            this.btAdicionarProduto.Text = "Inserir Novo Produto";
            this.btAdicionarProduto.UseVisualStyleBackColor = true;
            this.btAdicionarProduto.Click += new System.EventHandler(this.btAdicionarProduto_Click);
            // 
            // btEditarProduto
            // 
            this.btEditarProduto.Location = new System.Drawing.Point(6, 179);
            this.btEditarProduto.Name = "btEditarProduto";
            this.btEditarProduto.Size = new System.Drawing.Size(254, 23);
            this.btEditarProduto.TabIndex = 3;
            this.btEditarProduto.Text = "Editar Produto";
            this.btEditarProduto.UseVisualStyleBackColor = true;
            this.btEditarProduto.Click += new System.EventHandler(this.btEditarProduto_Click);
            // 
            // btApagarProduto
            // 
            this.btApagarProduto.Location = new System.Drawing.Point(6, 237);
            this.btApagarProduto.Name = "btApagarProduto";
            this.btApagarProduto.Size = new System.Drawing.Size(254, 23);
            this.btApagarProduto.TabIndex = 4;
            this.btApagarProduto.Text = "Apagar Produto";
            this.btApagarProduto.UseVisualStyleBackColor = true;
            this.btApagarProduto.Click += new System.EventHandler(this.btApagarProduto_Click);
            // 
            // btGuardarProduto
            // 
            this.btGuardarProduto.Location = new System.Drawing.Point(6, 208);
            this.btGuardarProduto.Name = "btGuardarProduto";
            this.btGuardarProduto.Size = new System.Drawing.Size(254, 23);
            this.btGuardarProduto.TabIndex = 5;
            this.btGuardarProduto.Text = "Guardar Alterações";
            this.btGuardarProduto.UseVisualStyleBackColor = true;
            this.btGuardarProduto.Click += new System.EventHandler(this.btGuardarProduto_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "*Preço:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "*Stock:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "*Designação:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "*Tipo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Código:";
            // 
            // nmStockProduto
            // 
            this.nmStockProduto.Location = new System.Drawing.Point(77, 71);
            this.nmStockProduto.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmStockProduto.Name = "nmStockProduto";
            this.nmStockProduto.Size = new System.Drawing.Size(74, 20);
            this.nmStockProduto.TabIndex = 26;
            this.nmStockProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbCodProduto
            // 
            this.tbCodProduto.Enabled = false;
            this.tbCodProduto.Location = new System.Drawing.Point(77, 19);
            this.tbCodProduto.Name = "tbCodProduto";
            this.tbCodProduto.Size = new System.Drawing.Size(74, 20);
            this.tbCodProduto.TabIndex = 22;
            this.tbCodProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nmPreco
            // 
            this.nmPreco.DecimalPlaces = 2;
            this.nmPreco.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.nmPreco.Location = new System.Drawing.Point(77, 97);
            this.nmPreco.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmPreco.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nmPreco.Name = "nmPreco";
            this.nmPreco.Size = new System.Drawing.Size(74, 20);
            this.nmPreco.TabIndex = 25;
            this.nmPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmPreco.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // cbTipoProduto
            // 
            this.cbTipoProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoProduto.Enabled = false;
            this.cbTipoProduto.FormattingEnabled = true;
            this.cbTipoProduto.Location = new System.Drawing.Point(77, 123);
            this.cbTipoProduto.Name = "cbTipoProduto";
            this.cbTipoProduto.Size = new System.Drawing.Size(154, 21);
            this.cbTipoProduto.TabIndex = 24;
            this.cbTipoProduto.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cbTipoProduto_MouseUp);
            // 
            // tbDesignacao
            // 
            this.tbDesignacao.Location = new System.Drawing.Point(77, 45);
            this.tbDesignacao.Name = "tbDesignacao";
            this.tbDesignacao.Size = new System.Drawing.Size(183, 20);
            this.tbDesignacao.TabIndex = 23;
            // 
            // btAdicionarTipo
            // 
            this.btAdicionarTipo.Location = new System.Drawing.Point(237, 122);
            this.btAdicionarTipo.Name = "btAdicionarTipo";
            this.btAdicionarTipo.Size = new System.Drawing.Size(23, 22);
            this.btAdicionarTipo.TabIndex = 32;
            this.btAdicionarTipo.Text = "+";
            this.btAdicionarTipo.UseVisualStyleBackColor = true;
            this.btAdicionarTipo.Click += new System.EventHandler(this.btAdicionarTipo_Click);
            // 
            // menuEditarTipo
            // 
            this.menuEditarTipo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.apagarToolStripMenuItem});
            this.menuEditarTipo.Name = "menuEditarTipo";
            this.menuEditarTipo.Size = new System.Drawing.Size(113, 48);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // apagarToolStripMenuItem
            // 
            this.apagarToolStripMenuItem.Name = "apagarToolStripMenuItem";
            this.apagarToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.apagarToolStripMenuItem.Text = "Apagar";
            this.apagarToolStripMenuItem.Click += new System.EventHandler(this.apagarToolStripMenuItem_Click);
            // 
            // gbPL
            // 
            this.gbPL.Controls.Add(this.btCancelClean);
            this.gbPL.Controls.Add(this.tbDesignacao);
            this.gbPL.Controls.Add(this.btAdicionarProduto);
            this.gbPL.Controls.Add(this.btAdicionarTipo);
            this.gbPL.Controls.Add(this.btEditarProduto);
            this.gbPL.Controls.Add(this.label5);
            this.gbPL.Controls.Add(this.btApagarProduto);
            this.gbPL.Controls.Add(this.label4);
            this.gbPL.Controls.Add(this.btGuardarProduto);
            this.gbPL.Controls.Add(this.label3);
            this.gbPL.Controls.Add(this.cbTipoProduto);
            this.gbPL.Controls.Add(this.label2);
            this.gbPL.Controls.Add(this.nmPreco);
            this.gbPL.Controls.Add(this.label1);
            this.gbPL.Controls.Add(this.tbCodProduto);
            this.gbPL.Controls.Add(this.nmStockProduto);
            this.gbPL.Location = new System.Drawing.Point(12, 71);
            this.gbPL.Name = "gbPL";
            this.gbPL.Size = new System.Drawing.Size(271, 300);
            this.gbPL.TabIndex = 34;
            this.gbPL.TabStop = false;
            this.gbPL.Text = "Dados Produto";
            // 
            // btCancelClean
            // 
            this.btCancelClean.Location = new System.Drawing.Point(6, 266);
            this.btCancelClean.Name = "btCancelClean";
            this.btCancelClean.Size = new System.Drawing.Size(254, 23);
            this.btCancelClean.TabIndex = 33;
            this.btCancelClean.Text = "Cancelar/Limpar Selecção";
            this.btCancelClean.UseVisualStyleBackColor = true;
            this.btCancelClean.Click += new System.EventHandler(this.btCancelClean_Click);
            // 
            // labelNomeForm
            // 
            this.labelNomeForm.AutoSize = true;
            this.labelNomeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F);
            this.labelNomeForm.Location = new System.Drawing.Point(9, 9);
            this.labelNomeForm.Name = "labelNomeForm";
            this.labelNomeForm.Size = new System.Drawing.Size(228, 59);
            this.labelNomeForm.TabIndex = 35;
            this.labelNomeForm.Text = "Produtos";
            // 
            // FormProdutosLoja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 384);
            this.Controls.Add(this.labelNomeForm);
            this.Controls.Add(this.gbPL);
            this.Controls.Add(this.dgvProdutosLoja);
            this.Name = "FormProdutosLoja";
            this.ShowIcon = false;
            this.Text = "Bookids - Gestão de Produtos";
            this.Load += new System.EventHandler(this.FormProdutosLoja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosLoja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmStockProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPreco)).EndInit();
            this.menuEditarTipo.ResumeLayout(false);
            this.gbPL.ResumeLayout(false);
            this.gbPL.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource produtosBindingSource;
        private System.Windows.Forms.DataGridView dgvProdutosLoja;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btAdicionarProduto;
        private System.Windows.Forms.Button btEditarProduto;
        private System.Windows.Forms.Button btApagarProduto;
        private System.Windows.Forms.Button btGuardarProduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmStockProduto;
        private System.Windows.Forms.TextBox tbCodProduto;
        private System.Windows.Forms.NumericUpDown nmPreco;
        private System.Windows.Forms.ComboBox cbTipoProduto;
        private System.Windows.Forms.TextBox tbDesignacao;
        private System.Windows.Forms.Button btAdicionarTipo;
        private System.Windows.Forms.ContextMenuStrip menuEditarTipo;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbPL;
        private System.Windows.Forms.Button btCancelClean;
        private System.Windows.Forms.ToolStripMenuItem apagarToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label labelNomeForm;
    }
}