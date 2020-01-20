namespace BindingSU2Formomis
{
    partial class FormaTextas
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
            this.Vardas = new System.Windows.Forms.TextBox();
            this.Pavarde = new System.Windows.Forms.TextBox();
            this.Amzius = new System.Windows.Forms.TextBox();
            this.DarboViete = new System.Windows.Forms.TextBox();
            this.Pareigos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Vardas
            // 
            this.Vardas.Location = new System.Drawing.Point(110, 27);
            this.Vardas.Name = "Vardas";
            this.Vardas.Size = new System.Drawing.Size(100, 20);
            this.Vardas.TabIndex = 0;
            // 
            // Pavarde
            // 
            this.Pavarde.Location = new System.Drawing.Point(110, 53);
            this.Pavarde.Name = "Pavarde";
            this.Pavarde.Size = new System.Drawing.Size(100, 20);
            this.Pavarde.TabIndex = 1;
            // 
            // Amzius
            // 
            this.Amzius.Location = new System.Drawing.Point(110, 80);
            this.Amzius.Name = "Amzius";
            this.Amzius.Size = new System.Drawing.Size(100, 20);
            this.Amzius.TabIndex = 2;
            // 
            // DarboViete
            // 
            this.DarboViete.Location = new System.Drawing.Point(110, 107);
            this.DarboViete.Name = "DarboViete";
            this.DarboViete.Size = new System.Drawing.Size(100, 20);
            this.DarboViete.TabIndex = 3;
            // 
            // Pareigos
            // 
            this.Pareigos.Location = new System.Drawing.Point(110, 134);
            this.Pareigos.Name = "Pareigos";
            this.Pareigos.Size = new System.Drawing.Size(100, 20);
            this.Pareigos.TabIndex = 4;
            // 
            // FormaTextas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pareigos);
            this.Controls.Add(this.DarboViete);
            this.Controls.Add(this.Amzius);
            this.Controls.Add(this.Pavarde);
            this.Controls.Add(this.Vardas);
            this.Name = "FormaTextas";
            this.Text = "FormaTextas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Vardas;
        private System.Windows.Forms.TextBox Pavarde;
        private System.Windows.Forms.TextBox Amzius;
        private System.Windows.Forms.TextBox DarboViete;
        private System.Windows.Forms.TextBox Pareigos;
    }
}