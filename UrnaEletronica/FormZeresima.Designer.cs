namespace UrnaEletronica
{
    partial class FormZeresima
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
            this.labelZeresima = new System.Windows.Forms.Label();
            this.labelCandidatos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelZeresima
            // 
            this.labelZeresima.AutoSize = true;
            this.labelZeresima.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZeresima.ForeColor = System.Drawing.Color.Black;
            this.labelZeresima.Location = new System.Drawing.Point(12, 9);
            this.labelZeresima.Name = "labelZeresima";
            this.labelZeresima.Size = new System.Drawing.Size(168, 37);
            this.labelZeresima.TabIndex = 20;
            this.labelZeresima.Text = "Zerésima:";
            // 
            // labelCandidatos
            // 
            this.labelCandidatos.AutoSize = true;
            this.labelCandidatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCandidatos.ForeColor = System.Drawing.Color.Black;
            this.labelCandidatos.Location = new System.Drawing.Point(15, 46);
            this.labelCandidatos.Name = "labelCandidatos";
            this.labelCandidatos.Size = new System.Drawing.Size(76, 16);
            this.labelCandidatos.TabIndex = 21;
            this.labelCandidatos.Text = "Zerésima:";
            this.labelCandidatos.Click += new System.EventHandler(this.labelCandidatos_Click);
            // 
            // FormZeresima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(384, 421);
            this.Controls.Add(this.labelCandidatos);
            this.Controls.Add(this.labelZeresima);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormZeresima";
            this.Text = "Zerésima";
            this.Load += new System.EventHandler(this.FormZeresima_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelZeresima;
        private System.Windows.Forms.Label labelCandidatos;
    }
}