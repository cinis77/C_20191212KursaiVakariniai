namespace DataBindingasSuForma
{
    partial class Form1
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
            this.Labelis = new System.Windows.Forms.Label();
            this.textoLaukas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Labelis
            // 
            this.Labelis.AutoSize = true;
            this.Labelis.Location = new System.Drawing.Point(125, 80);
            this.Labelis.Name = "Labelis";
            this.Labelis.Size = new System.Drawing.Size(35, 13);
            this.Labelis.TabIndex = 0;
            this.Labelis.Text = "label1";
            // 
            // textoLaukas
            // 
            this.textoLaukas.Location = new System.Drawing.Point(109, 97);
            this.textoLaukas.Name = "textoLaukas";
            this.textoLaukas.Size = new System.Drawing.Size(100, 20);
            this.textoLaukas.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textoLaukas);
            this.Controls.Add(this.Labelis);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Labelis;
        private System.Windows.Forms.TextBox textoLaukas;
    }
}

