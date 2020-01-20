namespace BindingSU2Formomis
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
            this.Vardas = new System.Windows.Forms.Label();
            this.Pavarde = new System.Windows.Forms.Label();
            this.Amzius = new System.Windows.Forms.Label();
            this.DarboViete = new System.Windows.Forms.Label();
            this.Pareigos = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Vardas
            // 
            this.Vardas.AutoSize = true;
            this.Vardas.Location = new System.Drawing.Point(61, 37);
            this.Vardas.Name = "Vardas";
            this.Vardas.Size = new System.Drawing.Size(35, 13);
            this.Vardas.TabIndex = 0;
            this.Vardas.Text = "label1";
            // 
            // Pavarde
            // 
            this.Pavarde.AutoSize = true;
            this.Pavarde.Location = new System.Drawing.Point(61, 62);
            this.Pavarde.Name = "Pavarde";
            this.Pavarde.Size = new System.Drawing.Size(35, 13);
            this.Pavarde.TabIndex = 1;
            this.Pavarde.Text = "label2";
            // 
            // Amzius
            // 
            this.Amzius.AutoSize = true;
            this.Amzius.Location = new System.Drawing.Point(61, 93);
            this.Amzius.Name = "Amzius";
            this.Amzius.Size = new System.Drawing.Size(35, 13);
            this.Amzius.TabIndex = 2;
            this.Amzius.Text = "label3";
            // 
            // DarboViete
            // 
            this.DarboViete.AutoSize = true;
            this.DarboViete.Location = new System.Drawing.Point(64, 123);
            this.DarboViete.Name = "DarboViete";
            this.DarboViete.Size = new System.Drawing.Size(35, 13);
            this.DarboViete.TabIndex = 3;
            this.DarboViete.Text = "label4";
            // 
            // Pareigos
            // 
            this.Pareigos.AutoSize = true;
            this.Pareigos.Location = new System.Drawing.Point(64, 150);
            this.Pareigos.Name = "Pareigos";
            this.Pareigos.Size = new System.Drawing.Size(35, 13);
            this.Pareigos.TabIndex = 4;
            this.Pareigos.Text = "label5";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Pildyti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Pareigos);
            this.Controls.Add(this.DarboViete);
            this.Controls.Add(this.Amzius);
            this.Controls.Add(this.Pavarde);
            this.Controls.Add(this.Vardas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Vardas;
        private System.Windows.Forms.Label Pavarde;
        private System.Windows.Forms.Label Amzius;
        private System.Windows.Forms.Label DarboViete;
        private System.Windows.Forms.Label Pareigos;
        private System.Windows.Forms.Button button1;
    }
}

