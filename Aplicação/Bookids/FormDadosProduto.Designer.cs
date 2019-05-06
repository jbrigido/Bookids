namespace Bookids
{
    partial class FormDadosProduto
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
            this.btGuardarProduto = new System.Windows.Forms.Button();
            this.tbStock = new System.Windows.Forms.TextBox();
            this.nmPreco = new System.Windows.Forms.NumericUpDown();
            this.cbTipoProduto = new System.Windows.Forms.ComboBox();
            this.tbDesignacao = new System.Windows.Forms.TextBox();
            this.tbCodProduto = new System.Windows.Forms.TextBox();
            this.btCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmPreco)).BeginInit();
            this.SuspendLayout();
            // 
            // btGuardarProduto
            // 
            this.btGuardarProduto.Location = new System.Drawing.Point(33, 107);
            this.btGuardarProduto.Name = "btGuardarProduto";
            this.btGuardarProduto.Size = new System.Drawing.Size(202, 23);
            this.btGuardarProduto.TabIndex = 5;
            this.btGuardarProduto.Text = "Guardar Alterações";
            this.btGuardarProduto.UseVisualStyleBackColor = true;
            // 
            // tbStock
            // 
            this.tbStock.Location = new System.Drawing.Point(33, 81);
            this.tbStock.Name = "tbStock";
            this.tbStock.Size = new System.Drawing.Size(100, 20);
            this.tbStock.TabIndex = 4;
            this.tbStock.Text = "Stock Existente";
            // 
            // nmPreco
            // 
            this.nmPreco.DecimalPlaces = 2;
            this.nmPreco.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.nmPreco.Location = new System.Drawing.Point(139, 81);
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
            this.nmPreco.Size = new System.Drawing.Size(96, 20);
            this.nmPreco.TabIndex = 3;
            this.nmPreco.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // cbTipoProduto
            // 
            this.cbTipoProduto.FormattingEnabled = true;
            this.cbTipoProduto.Items.AddRange(new object[] {
            "Tipo1",
            "Tipo2",
            "Tipo3"});
            this.cbTipoProduto.Location = new System.Drawing.Point(154, 28);
            this.cbTipoProduto.Name = "cbTipoProduto";
            this.cbTipoProduto.Size = new System.Drawing.Size(81, 21);
            this.cbTipoProduto.TabIndex = 2;
            this.cbTipoProduto.Text = "TipoProduto";
            // 
            // tbDesignacao
            // 
            this.tbDesignacao.Location = new System.Drawing.Point(33, 55);
            this.tbDesignacao.Name = "tbDesignacao";
            this.tbDesignacao.Size = new System.Drawing.Size(202, 20);
            this.tbDesignacao.TabIndex = 1;
            this.tbDesignacao.Text = "Designação";
            // 
            // tbCodProduto
            // 
            this.tbCodProduto.Location = new System.Drawing.Point(33, 29);
            this.tbCodProduto.Name = "tbCodProduto";
            this.tbCodProduto.Size = new System.Drawing.Size(114, 20);
            this.tbCodProduto.TabIndex = 0;
            this.tbCodProduto.Text = "Codigo Produto";
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(33, 136);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(202, 23);
            this.btCancelar.TabIndex = 6;
            this.btCancelar.Text = "Cancelar Alterações";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // FormProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 195);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btGuardarProduto);
            this.Controls.Add(this.tbCodProduto);
            this.Controls.Add(this.nmPreco);
            this.Controls.Add(this.tbStock);
            this.Controls.Add(this.cbTipoProduto);
            this.Controls.Add(this.tbDesignacao);
            this.Name = "FormProduto";
            this.Text = "FormProduto";
            ((System.ComponentModel.ISupportInitialize)(this.nmPreco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbDesignacao;
        private System.Windows.Forms.TextBox tbCodProduto;
        private System.Windows.Forms.ComboBox cbTipoProduto;
        private System.Windows.Forms.Button btGuardarProduto;
        private System.Windows.Forms.TextBox tbStock;
        private System.Windows.Forms.NumericUpDown nmPreco;
        private System.Windows.Forms.Button btCancelar;
    }
}