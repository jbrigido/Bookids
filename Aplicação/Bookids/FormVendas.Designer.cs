namespace Bookids
{
    partial class FormVendas
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
            this.btGuardar = new System.Windows.Forms.Button();
            this.btApagarVenda = new System.Windows.Forms.Button();
            this.btAlterarVenda = new System.Windows.Forms.Button();
            this.btRegistarVenda = new System.Windows.Forms.Button();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.tbNifCli = new System.Windows.Forms.MaskedTextBox();
            this.tbNrCartao = new System.Windows.Forms.TextBox();
            this.cbNomeCli = new System.Windows.Forms.ComboBox();
            this.lbCompras = new System.Windows.Forms.ListBox();
            this.tbDataCompra = new System.Windows.Forms.TextBox();
            this.tbNrCompra = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lbDetalhesDaCompra = new System.Windows.Forms.ListBox();
            this.gbCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(423, 12);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(131, 23);
            this.btGuardar.TabIndex = 9;
            this.btGuardar.Text = "Guardar Alterações";
            this.btGuardar.UseVisualStyleBackColor = true;
            // 
            // btApagarVenda
            // 
            this.btApagarVenda.Location = new System.Drawing.Point(286, 12);
            this.btApagarVenda.Name = "btApagarVenda";
            this.btApagarVenda.Size = new System.Drawing.Size(131, 23);
            this.btApagarVenda.TabIndex = 8;
            this.btApagarVenda.Text = "Apagar Venda";
            this.btApagarVenda.UseVisualStyleBackColor = true;
            // 
            // btAlterarVenda
            // 
            this.btAlterarVenda.Location = new System.Drawing.Point(149, 12);
            this.btAlterarVenda.Name = "btAlterarVenda";
            this.btAlterarVenda.Size = new System.Drawing.Size(131, 23);
            this.btAlterarVenda.TabIndex = 7;
            this.btAlterarVenda.Text = "Alterar Venda";
            this.btAlterarVenda.UseVisualStyleBackColor = true;
            // 
            // btRegistarVenda
            // 
            this.btRegistarVenda.Location = new System.Drawing.Point(12, 12);
            this.btRegistarVenda.Name = "btRegistarVenda";
            this.btRegistarVenda.Size = new System.Drawing.Size(131, 23);
            this.btRegistarVenda.TabIndex = 6;
            this.btRegistarVenda.Text = "Registar Venda";
            this.btRegistarVenda.UseVisualStyleBackColor = true;
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.tbNifCli);
            this.gbCliente.Controls.Add(this.tbNrCartao);
            this.gbCliente.Controls.Add(this.cbNomeCli);
            this.gbCliente.Location = new System.Drawing.Point(12, 41);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(542, 59);
            this.gbCliente.TabIndex = 10;
            this.gbCliente.TabStop = false;
            // 
            // tbNifCli
            // 
            this.tbNifCli.Location = new System.Drawing.Point(376, 20);
            this.tbNifCli.Mask = "000 000 000";
            this.tbNifCli.Name = "tbNifCli";
            this.tbNifCli.Size = new System.Drawing.Size(64, 20);
            this.tbNifCli.TabIndex = 4;
            // 
            // tbNrCartao
            // 
            this.tbNrCartao.Location = new System.Drawing.Point(446, 20);
            this.tbNrCartao.Name = "tbNrCartao";
            this.tbNrCartao.Size = new System.Drawing.Size(90, 20);
            this.tbNrCartao.TabIndex = 3;
            this.tbNrCartao.Text = "Nº Cartao Cliente";
            // 
            // cbNomeCli
            // 
            this.cbNomeCli.FormattingEnabled = true;
            this.cbNomeCli.Location = new System.Drawing.Point(6, 19);
            this.cbNomeCli.Name = "cbNomeCli";
            this.cbNomeCli.Size = new System.Drawing.Size(364, 21);
            this.cbNomeCli.TabIndex = 0;
            this.cbNomeCli.Text = "Nome Cliente";
            // 
            // lbCompras
            // 
            this.lbCompras.FormattingEnabled = true;
            this.lbCompras.Location = new System.Drawing.Point(18, 116);
            this.lbCompras.Name = "lbCompras";
            this.lbCompras.Size = new System.Drawing.Size(139, 238);
            this.lbCompras.TabIndex = 11;
            // 
            // tbDataCompra
            // 
            this.tbDataCompra.Location = new System.Drawing.Point(201, 119);
            this.tbDataCompra.Name = "tbDataCompra";
            this.tbDataCompra.Size = new System.Drawing.Size(92, 20);
            this.tbDataCompra.TabIndex = 12;
            this.tbDataCompra.Text = "Data da Compra";
            // 
            // tbNrCompra
            // 
            this.tbNrCompra.Location = new System.Drawing.Point(201, 145);
            this.tbNrCompra.Name = "tbNrCompra";
            this.tbNrCompra.Size = new System.Drawing.Size(92, 20);
            this.tbNrCompra.TabIndex = 13;
            this.tbNrCompra.Text = "Nº Compra";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(201, 171);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(92, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Cartão Cliente";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // lbDetalhesDaCompra
            // 
            this.lbDetalhesDaCompra.FormattingEnabled = true;
            this.lbDetalhesDaCompra.Location = new System.Drawing.Point(201, 194);
            this.lbDetalhesDaCompra.Name = "lbDetalhesDaCompra";
            this.lbDetalhesDaCompra.Size = new System.Drawing.Size(164, 160);
            this.lbDetalhesDaCompra.TabIndex = 15;
            // 
            // FormVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 558);
            this.Controls.Add(this.lbDetalhesDaCompra);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.tbNrCompra);
            this.Controls.Add(this.tbDataCompra);
            this.Controls.Add(this.lbCompras);
            this.Controls.Add(this.gbCliente);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.btApagarVenda);
            this.Controls.Add(this.btAlterarVenda);
            this.Controls.Add(this.btRegistarVenda);
            this.Name = "FormVendas";
            this.Text = "FormVendas";
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btApagarVenda;
        private System.Windows.Forms.Button btAlterarVenda;
        private System.Windows.Forms.Button btRegistarVenda;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.ComboBox cbNomeCli;
        private System.Windows.Forms.MaskedTextBox tbNifCli;
        private System.Windows.Forms.TextBox tbNrCartao;
        private System.Windows.Forms.ListBox lbCompras;
        private System.Windows.Forms.TextBox tbDataCompra;
        private System.Windows.Forms.TextBox tbNrCompra;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListBox lbDetalhesDaCompra;
    }
}