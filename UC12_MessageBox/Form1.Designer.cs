namespace UC12_MessageBox
{
    partial class Form1
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
            this.buttonMB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMB
            // 
            this.buttonMB.Location = new System.Drawing.Point(310, 177);
            this.buttonMB.Name = "buttonMB";
            this.buttonMB.Size = new System.Drawing.Size(180, 64);
            this.buttonMB.TabIndex = 0;
            this.buttonMB.Text = "MessageBox";
            this.buttonMB.UseVisualStyleBackColor = true;
            this.buttonMB.Click += new System.EventHandler(this.buttonMB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMB;
    }
}

