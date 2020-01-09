namespace DuomenuBazes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label pavadinimasLabel;
            System.Windows.Forms.Label kainaLabel;
            System.Windows.Forms.Label sudetisLabel;
            System.Windows.Forms.Label autoriusLabel;
            this.duomenysDataSet = new DuomenuBazes.DuomenysDataSet();
            this.receptaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receptaiTableAdapter = new DuomenuBazes.DuomenysDataSetTableAdapters.ReceptaiTableAdapter();
            this.tableAdapterManager = new DuomenuBazes.DuomenysDataSetTableAdapters.TableAdapterManager();
            this.receptaiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.receptaiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.receptaiDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.pavadinimasTextBox = new System.Windows.Forms.TextBox();
            this.kainaTextBox = new System.Windows.Forms.TextBox();
            this.sudetisTextBox = new System.Windows.Forms.TextBox();
            this.autoriusTextBox = new System.Windows.Forms.TextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            idLabel = new System.Windows.Forms.Label();
            pavadinimasLabel = new System.Windows.Forms.Label();
            kainaLabel = new System.Windows.Forms.Label();
            sudetisLabel = new System.Windows.Forms.Label();
            autoriusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.duomenysDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptaiBindingNavigator)).BeginInit();
            this.receptaiBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receptaiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // duomenysDataSet
            // 
            this.duomenysDataSet.DataSetName = "DuomenysDataSet";
            this.duomenysDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // receptaiBindingSource
            // 
            this.receptaiBindingSource.DataMember = "Receptai";
            this.receptaiBindingSource.DataSource = this.duomenysDataSet;
            // 
            // receptaiTableAdapter
            // 
            this.receptaiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ReceptaiTableAdapter = this.receptaiTableAdapter;
            this.tableAdapterManager.UpdateOrder = DuomenuBazes.DuomenysDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // receptaiBindingNavigator
            // 
            this.receptaiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.receptaiBindingNavigator.BindingSource = this.receptaiBindingSource;
            this.receptaiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.receptaiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.receptaiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.receptaiBindingNavigatorSaveItem,
            this.toolStripButton1,
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.printToolStripButton,
            this.toolStripSeparator,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator1,
            this.helpToolStripButton,
            this.toolStripButton2});
            this.receptaiBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.receptaiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.receptaiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.receptaiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.receptaiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.receptaiBindingNavigator.Name = "receptaiBindingNavigator";
            this.receptaiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.receptaiBindingNavigator.Size = new System.Drawing.Size(924, 25);
            this.receptaiBindingNavigator.TabIndex = 0;
            this.receptaiBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // receptaiBindingNavigatorSaveItem
            // 
            this.receptaiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.receptaiBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("receptaiBindingNavigatorSaveItem.Image")));
            this.receptaiBindingNavigatorSaveItem.Name = "receptaiBindingNavigatorSaveItem";
            this.receptaiBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.receptaiBindingNavigatorSaveItem.Text = "Save Data";
            this.receptaiBindingNavigatorSaveItem.Click += new System.EventHandler(this.receptaiBindingNavigatorSaveItem_Click);
            // 
            // receptaiDataGridView
            // 
            this.receptaiDataGridView.AutoGenerateColumns = false;
            this.receptaiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.receptaiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.receptaiDataGridView.DataSource = this.receptaiBindingSource;
            this.receptaiDataGridView.Location = new System.Drawing.Point(12, 40);
            this.receptaiDataGridView.Name = "receptaiDataGridView";
            this.receptaiDataGridView.Size = new System.Drawing.Size(710, 273);
            this.receptaiDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Pavadinimas";
            this.dataGridViewTextBoxColumn2.HeaderText = "Pavadinimas";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Kaina";
            this.dataGridViewTextBoxColumn3.HeaderText = "Kaina";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Sudetis";
            this.dataGridViewTextBoxColumn4.HeaderText = "Sudetis";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Autorius";
            this.dataGridViewTextBoxColumn5.HeaderText = "Autorius";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(728, 47);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 2;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receptaiBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(804, 44);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 3;
            // 
            // pavadinimasLabel
            // 
            pavadinimasLabel.AutoSize = true;
            pavadinimasLabel.Location = new System.Drawing.Point(728, 73);
            pavadinimasLabel.Name = "pavadinimasLabel";
            pavadinimasLabel.Size = new System.Drawing.Size(70, 13);
            pavadinimasLabel.TabIndex = 4;
            pavadinimasLabel.Text = "Pavadinimas:";
            // 
            // pavadinimasTextBox
            // 
            this.pavadinimasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receptaiBindingSource, "Pavadinimas", true));
            this.pavadinimasTextBox.Location = new System.Drawing.Point(804, 70);
            this.pavadinimasTextBox.Name = "pavadinimasTextBox";
            this.pavadinimasTextBox.Size = new System.Drawing.Size(100, 20);
            this.pavadinimasTextBox.TabIndex = 5;
            // 
            // kainaLabel
            // 
            kainaLabel.AutoSize = true;
            kainaLabel.Location = new System.Drawing.Point(728, 99);
            kainaLabel.Name = "kainaLabel";
            kainaLabel.Size = new System.Drawing.Size(37, 13);
            kainaLabel.TabIndex = 6;
            kainaLabel.Text = "Kaina:";
            // 
            // kainaTextBox
            // 
            this.kainaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receptaiBindingSource, "Kaina", true));
            this.kainaTextBox.Location = new System.Drawing.Point(804, 96);
            this.kainaTextBox.Name = "kainaTextBox";
            this.kainaTextBox.Size = new System.Drawing.Size(100, 20);
            this.kainaTextBox.TabIndex = 7;
            // 
            // sudetisLabel
            // 
            sudetisLabel.AutoSize = true;
            sudetisLabel.Location = new System.Drawing.Point(728, 125);
            sudetisLabel.Name = "sudetisLabel";
            sudetisLabel.Size = new System.Drawing.Size(45, 13);
            sudetisLabel.TabIndex = 8;
            sudetisLabel.Text = "Sudetis:";
            // 
            // sudetisTextBox
            // 
            this.sudetisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receptaiBindingSource, "Sudetis", true));
            this.sudetisTextBox.Location = new System.Drawing.Point(804, 122);
            this.sudetisTextBox.Name = "sudetisTextBox";
            this.sudetisTextBox.Size = new System.Drawing.Size(100, 20);
            this.sudetisTextBox.TabIndex = 9;
            // 
            // autoriusLabel
            // 
            autoriusLabel.AutoSize = true;
            autoriusLabel.Location = new System.Drawing.Point(728, 151);
            autoriusLabel.Name = "autoriusLabel";
            autoriusLabel.Size = new System.Drawing.Size(48, 13);
            autoriusLabel.TabIndex = 10;
            autoriusLabel.Text = "Autorius:";
            // 
            // autoriusTextBox
            // 
            this.autoriusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receptaiBindingSource, "Autorius", true));
            this.autoriusTextBox.Location = new System.Drawing.Point(804, 148);
            this.autoriusTextBox.Name = "autoriusTextBox";
            this.autoriusTextBox.Size = new System.Drawing.Size(100, 20);
            this.autoriusTextBox.TabIndex = 11;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "&New";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printToolStripButton.Text = "&Print";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.cutToolStripButton.Text = "C&ut";
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copyToolStripButton.Text = "&Copy";
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.pasteToolStripButton.Text = "&Paste";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 450);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(pavadinimasLabel);
            this.Controls.Add(this.pavadinimasTextBox);
            this.Controls.Add(kainaLabel);
            this.Controls.Add(this.kainaTextBox);
            this.Controls.Add(sudetisLabel);
            this.Controls.Add(this.sudetisTextBox);
            this.Controls.Add(autoriusLabel);
            this.Controls.Add(this.autoriusTextBox);
            this.Controls.Add(this.receptaiDataGridView);
            this.Controls.Add(this.receptaiBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.duomenysDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptaiBindingNavigator)).EndInit();
            this.receptaiBindingNavigator.ResumeLayout(false);
            this.receptaiBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receptaiDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DuomenysDataSet duomenysDataSet;
        private System.Windows.Forms.BindingSource receptaiBindingSource;
        private DuomenysDataSetTableAdapters.ReceptaiTableAdapter receptaiTableAdapter;
        private DuomenysDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator receptaiBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton receptaiBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView receptaiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox pavadinimasTextBox;
        private System.Windows.Forms.TextBox kainaTextBox;
        private System.Windows.Forms.TextBox sudetisTextBox;
        private System.Windows.Forms.TextBox autoriusTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}

