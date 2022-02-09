namespace Institute
{
    partial class Students
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Students));
            System.Windows.Forms.Label std_idLabel;
            System.Windows.Forms.Label std_nameLabel;
            System.Windows.Forms.Label dept_noLabel;
            System.Windows.Forms.Label std_subLabel;
            System.Windows.Forms.Label std_mobLabel;
            System.Windows.Forms.Label reg_dateLabel;
            System.Windows.Forms.Label std_emailLabel;
            this.instituteDataSet = new Institute.instituteDataSet();
            this.sTUDENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTUDENTSTableAdapter = new Institute.instituteDataSetTableAdapters.STUDENTSTableAdapter();
            this.tableAdapterManager = new Institute.instituteDataSetTableAdapters.TableAdapterManager();
            this.sTUDENTSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.sTUDENTSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.std_idTextBox = new System.Windows.Forms.TextBox();
            this.std_nameTextBox = new System.Windows.Forms.TextBox();
            this.std_mobTextBox = new System.Windows.Forms.TextBox();
            this.reg_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.std_emailTextBox = new System.Windows.Forms.TextBox();
            this.sTUDENTSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dEPARTMENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dEPARTMENTSTableAdapter = new Institute.instituteDataSetTableAdapters.DEPARTMENTSTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.std_subTextBox = new System.Windows.Forms.TextBox();
            std_idLabel = new System.Windows.Forms.Label();
            std_nameLabel = new System.Windows.Forms.Label();
            dept_noLabel = new System.Windows.Forms.Label();
            std_subLabel = new System.Windows.Forms.Label();
            std_mobLabel = new System.Windows.Forms.Label();
            reg_dateLabel = new System.Windows.Forms.Label();
            std_emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.instituteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTSBindingNavigator)).BeginInit();
            this.sTUDENTSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTSDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTMENTSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // instituteDataSet
            // 
            this.instituteDataSet.DataSetName = "instituteDataSet";
            this.instituteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTUDENTSBindingSource
            // 
            this.sTUDENTSBindingSource.DataMember = "STUDENTS";
            this.sTUDENTSBindingSource.DataSource = this.instituteDataSet;
            // 
            // sTUDENTSTableAdapter
            // 
            this.sTUDENTSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DEPARTMENTSTableAdapter = this.dEPARTMENTSTableAdapter;
            this.tableAdapterManager.EMPLOYEES_JOBSTableAdapter = null;
            this.tableAdapterManager.EMPOLYEESTableAdapter = null;
            this.tableAdapterManager.STUDENTSTableAdapter = this.sTUDENTSTableAdapter;
            this.tableAdapterManager.SUBJECTSTableAdapter = null;
            this.tableAdapterManager.TEACHERSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Institute.instituteDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sTUDENTSBindingNavigator
            // 
            this.sTUDENTSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sTUDENTSBindingNavigator.BindingSource = this.sTUDENTSBindingSource;
            this.sTUDENTSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sTUDENTSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sTUDENTSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.sTUDENTSBindingNavigatorSaveItem});
            this.sTUDENTSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sTUDENTSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sTUDENTSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sTUDENTSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sTUDENTSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sTUDENTSBindingNavigator.Name = "sTUDENTSBindingNavigator";
            this.sTUDENTSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sTUDENTSBindingNavigator.Size = new System.Drawing.Size(767, 25);
            this.sTUDENTSBindingNavigator.TabIndex = 0;
            this.sTUDENTSBindingNavigator.Text = "bindingNavigator1";
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
            // sTUDENTSBindingNavigatorSaveItem
            // 
            this.sTUDENTSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sTUDENTSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sTUDENTSBindingNavigatorSaveItem.Image")));
            this.sTUDENTSBindingNavigatorSaveItem.Name = "sTUDENTSBindingNavigatorSaveItem";
            this.sTUDENTSBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.sTUDENTSBindingNavigatorSaveItem.Text = "Save Data";
            this.sTUDENTSBindingNavigatorSaveItem.Click += new System.EventHandler(this.sTUDENTSBindingNavigatorSaveItem_Click);
            // 
            // std_idLabel
            // 
            std_idLabel.AutoSize = true;
            std_idLabel.Location = new System.Drawing.Point(38, 45);
            std_idLabel.Name = "std_idLabel";
            std_idLabel.Size = new System.Drawing.Size(37, 13);
            std_idLabel.TabIndex = 1;
            std_idLabel.Text = "std id:";
            // 
            // std_idTextBox
            // 
            this.std_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sTUDENTSBindingSource, "std_id", true));
            this.std_idTextBox.Location = new System.Drawing.Point(99, 42);
            this.std_idTextBox.Name = "std_idTextBox";
            this.std_idTextBox.Size = new System.Drawing.Size(200, 20);
            this.std_idTextBox.TabIndex = 2;
            // 
            // std_nameLabel
            // 
            std_nameLabel.AutoSize = true;
            std_nameLabel.Location = new System.Drawing.Point(38, 71);
            std_nameLabel.Name = "std_nameLabel";
            std_nameLabel.Size = new System.Drawing.Size(55, 13);
            std_nameLabel.TabIndex = 3;
            std_nameLabel.Text = "std name:";
            // 
            // std_nameTextBox
            // 
            this.std_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sTUDENTSBindingSource, "std_name", true));
            this.std_nameTextBox.Location = new System.Drawing.Point(99, 68);
            this.std_nameTextBox.Name = "std_nameTextBox";
            this.std_nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.std_nameTextBox.TabIndex = 4;
            // 
            // dept_noLabel
            // 
            dept_noLabel.AutoSize = true;
            dept_noLabel.Location = new System.Drawing.Point(38, 97);
            dept_noLabel.Name = "dept_noLabel";
            dept_noLabel.Size = new System.Drawing.Size(48, 13);
            dept_noLabel.TabIndex = 5;
            dept_noLabel.Text = "dept no:";
            // 
            // std_subLabel
            // 
            std_subLabel.AutoSize = true;
            std_subLabel.Location = new System.Drawing.Point(38, 123);
            std_subLabel.Name = "std_subLabel";
            std_subLabel.Size = new System.Drawing.Size(46, 13);
            std_subLabel.TabIndex = 7;
            std_subLabel.Text = "std sub:";
            // 
            // std_mobLabel
            // 
            std_mobLabel.AutoSize = true;
            std_mobLabel.Location = new System.Drawing.Point(38, 149);
            std_mobLabel.Name = "std_mobLabel";
            std_mobLabel.Size = new System.Drawing.Size(49, 13);
            std_mobLabel.TabIndex = 9;
            std_mobLabel.Text = "std mob:";
            // 
            // std_mobTextBox
            // 
            this.std_mobTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sTUDENTSBindingSource, "std_mob", true));
            this.std_mobTextBox.Location = new System.Drawing.Point(99, 146);
            this.std_mobTextBox.Name = "std_mobTextBox";
            this.std_mobTextBox.Size = new System.Drawing.Size(200, 20);
            this.std_mobTextBox.TabIndex = 10;
            // 
            // reg_dateLabel
            // 
            reg_dateLabel.AutoSize = true;
            reg_dateLabel.Location = new System.Drawing.Point(38, 176);
            reg_dateLabel.Name = "reg_dateLabel";
            reg_dateLabel.Size = new System.Drawing.Size(52, 13);
            reg_dateLabel.TabIndex = 11;
            reg_dateLabel.Text = "reg date:";
            // 
            // reg_dateDateTimePicker
            // 
            this.reg_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.sTUDENTSBindingSource, "reg_date", true));
            this.reg_dateDateTimePicker.Location = new System.Drawing.Point(99, 172);
            this.reg_dateDateTimePicker.Name = "reg_dateDateTimePicker";
            this.reg_dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.reg_dateDateTimePicker.TabIndex = 12;
            // 
            // std_emailLabel
            // 
            std_emailLabel.AutoSize = true;
            std_emailLabel.Location = new System.Drawing.Point(38, 201);
            std_emailLabel.Name = "std_emailLabel";
            std_emailLabel.Size = new System.Drawing.Size(53, 13);
            std_emailLabel.TabIndex = 13;
            std_emailLabel.Text = "std email:";
            // 
            // std_emailTextBox
            // 
            this.std_emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sTUDENTSBindingSource, "std_email", true));
            this.std_emailTextBox.Location = new System.Drawing.Point(99, 198);
            this.std_emailTextBox.Name = "std_emailTextBox";
            this.std_emailTextBox.Size = new System.Drawing.Size(200, 20);
            this.std_emailTextBox.TabIndex = 14;
            // 
            // sTUDENTSDataGridView
            // 
            this.sTUDENTSDataGridView.AutoGenerateColumns = false;
            this.sTUDENTSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sTUDENTSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.sTUDENTSDataGridView.DataSource = this.sTUDENTSBindingSource;
            this.sTUDENTSDataGridView.Location = new System.Drawing.Point(12, 235);
            this.sTUDENTSDataGridView.Name = "sTUDENTSDataGridView";
            this.sTUDENTSDataGridView.Size = new System.Drawing.Size(742, 220);
            this.sTUDENTSDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "std_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "std_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "std_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "std_name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "dept_no";
            this.dataGridViewTextBoxColumn3.HeaderText = "dept_no";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "std_sub";
            this.dataGridViewTextBoxColumn4.HeaderText = "std_sub";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "std_mob";
            this.dataGridViewTextBoxColumn5.HeaderText = "std_mob";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "reg_date";
            this.dataGridViewTextBoxColumn6.HeaderText = "reg_date";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "std_email";
            this.dataGridViewTextBoxColumn7.HeaderText = "std_email";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sTUDENTSBindingSource, "dept_no", true));
            this.comboBox1.DataSource = this.dEPARTMENTSBindingSource;
            this.comboBox1.DisplayMember = "dept_name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(99, 94);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.ValueMember = "dept_id";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 21);
            this.button1.TabIndex = 17;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dEPARTMENTSBindingSource
            // 
            this.dEPARTMENTSBindingSource.DataMember = "DEPARTMENTS";
            this.dEPARTMENTSBindingSource.DataSource = this.instituteDataSet;
            // 
            // dEPARTMENTSTableAdapter
            // 
            this.dEPARTMENTSTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(305, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 21);
            this.button2.TabIndex = 18;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // std_subTextBox
            // 
            this.std_subTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sTUDENTSBindingSource, "std_sub", true));
            this.std_subTextBox.Location = new System.Drawing.Point(99, 120);
            this.std_subTextBox.Name = "std_subTextBox";
            this.std_subTextBox.Size = new System.Drawing.Size(200, 20);
            this.std_subTextBox.TabIndex = 8;
            this.std_subTextBox.TextChanged += new System.EventHandler(this.std_subTextBox_TextChanged);
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 475);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.sTUDENTSDataGridView);
            this.Controls.Add(std_idLabel);
            this.Controls.Add(this.std_idTextBox);
            this.Controls.Add(std_nameLabel);
            this.Controls.Add(this.std_nameTextBox);
            this.Controls.Add(dept_noLabel);
            this.Controls.Add(std_subLabel);
            this.Controls.Add(this.std_subTextBox);
            this.Controls.Add(std_mobLabel);
            this.Controls.Add(this.std_mobTextBox);
            this.Controls.Add(reg_dateLabel);
            this.Controls.Add(this.reg_dateDateTimePicker);
            this.Controls.Add(std_emailLabel);
            this.Controls.Add(this.std_emailTextBox);
            this.Controls.Add(this.sTUDENTSBindingNavigator);
            this.Name = "Students";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Students";
            this.Load += new System.EventHandler(this.Students_Load);
            ((System.ComponentModel.ISupportInitialize)(this.instituteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTSBindingNavigator)).EndInit();
            this.sTUDENTSBindingNavigator.ResumeLayout(false);
            this.sTUDENTSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTSDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTMENTSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private instituteDataSet instituteDataSet;
        private System.Windows.Forms.BindingSource sTUDENTSBindingSource;
        private instituteDataSetTableAdapters.STUDENTSTableAdapter sTUDENTSTableAdapter;
        private instituteDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sTUDENTSBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton sTUDENTSBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox std_idTextBox;
        private System.Windows.Forms.TextBox std_nameTextBox;
        private System.Windows.Forms.TextBox std_mobTextBox;
        private System.Windows.Forms.DateTimePicker reg_dateDateTimePicker;
        private System.Windows.Forms.TextBox std_emailTextBox;
        private System.Windows.Forms.DataGridView sTUDENTSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private instituteDataSetTableAdapters.DEPARTMENTSTableAdapter dEPARTMENTSTableAdapter;
        private System.Windows.Forms.BindingSource dEPARTMENTSBindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox std_subTextBox;
    }
}