namespace Projeto
{
    partial class TelaPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnproduto = new System.Windows.Forms.Button();
            this.pnltela = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnproduto);
            this.panel1.Location = new System.Drawing.Point(7, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 438);
            this.panel1.TabIndex = 0;
            // 
            // btnproduto
            // 
            this.btnproduto.Location = new System.Drawing.Point(5, 6);
            this.btnproduto.Name = "btnproduto";
            this.btnproduto.Size = new System.Drawing.Size(96, 63);
            this.btnproduto.TabIndex = 0;
            this.btnproduto.Text = "Produto";
            this.btnproduto.UseVisualStyleBackColor = true;
            this.btnproduto.Click += new System.EventHandler(this.btnproduto_Click);
            // 
            // pnltela
            // 
            this.pnltela.Location = new System.Drawing.Point(132, 6);
            this.pnltela.Name = "pnltela";
            this.pnltela.Size = new System.Drawing.Size(657, 437);
            this.pnltela.TabIndex = 1;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnltela);
            this.Controls.Add(this.panel1);
            this.Name = "TelaPrincipal";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnproduto;
        private System.Windows.Forms.Panel pnltela;
    }
}

