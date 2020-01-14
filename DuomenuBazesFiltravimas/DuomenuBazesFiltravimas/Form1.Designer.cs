namespace DuomenuBazesFiltravimas
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
            this.ViewOfDataBase = new System.Windows.Forms.DataGridView();
            this.CodeFiltras = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.CodeFilter = new System.Windows.Forms.CheckBox();
            this.DateTimeFilter = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ViewOfDataBase)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewOfDataBase
            // 
            this.ViewOfDataBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewOfDataBase.Location = new System.Drawing.Point(409, 42);
            this.ViewOfDataBase.Name = "ViewOfDataBase";
            this.ViewOfDataBase.Size = new System.Drawing.Size(850, 414);
            this.ViewOfDataBase.TabIndex = 0;
            // 
            // CodeFiltras
            // 
            this.CodeFiltras.Location = new System.Drawing.Point(33, 42);
            this.CodeFiltras.Name = "CodeFiltras";
            this.CodeFiltras.Size = new System.Drawing.Size(100, 20);
            this.CodeFiltras.TabIndex = 1;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(33, 81);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Ieskoti";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // CodeFilter
            // 
            this.CodeFilter.AutoSize = true;
            this.CodeFilter.Location = new System.Drawing.Point(33, 355);
            this.CodeFilter.Name = "CodeFilter";
            this.CodeFilter.Size = new System.Drawing.Size(78, 17);
            this.CodeFilter.TabIndex = 3;
            this.CodeFilter.Text = "Kodo filtras";
            this.CodeFilter.UseVisualStyleBackColor = true;
            this.CodeFilter.CheckedChanged += new System.EventHandler(this.CodeFilter_CheckedChanged);
            // 
            // DateTimeFilter
            // 
            this.DateTimeFilter.AutoSize = true;
            this.DateTimeFilter.Location = new System.Drawing.Point(33, 379);
            this.DateTimeFilter.Name = "DateTimeFilter";
            this.DateTimeFilter.Size = new System.Drawing.Size(81, 17);
            this.DateTimeFilter.TabIndex = 4;
            this.DateTimeFilter.Text = "Datos filtros";
            this.DateTimeFilter.UseVisualStyleBackColor = true;
            this.DateTimeFilter.CheckedChanged += new System.EventHandler(this.DateTimeFilter_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(107, 128);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(107, 168);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nuo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Iki:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 504);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.DateTimeFilter);
            this.Controls.Add(this.CodeFilter);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.CodeFiltras);
            this.Controls.Add(this.ViewOfDataBase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewOfDataBase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ViewOfDataBase;
        private System.Windows.Forms.TextBox CodeFiltras;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.CheckBox CodeFilter;
        private System.Windows.Forms.CheckBox DateTimeFilter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

