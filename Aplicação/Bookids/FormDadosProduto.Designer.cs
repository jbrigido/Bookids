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
            this.btCancelar = new System.Windows.Forms.Button();
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
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(33, 136);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(202, 23);
            this.btCancelar.TabIndex = 6;
            this.btCancelar.Text = "Cancelar Alterações";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // FormDadosProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 195);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btGuardarProduto);
            this.Name = "FormDadosProduto";
            this.Text = "FormProduto";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btGuardarProduto;
        private System.Windows.Forms.Button btCancelar;
    }
}