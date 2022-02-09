namespace Institute
{
    partial class Subjects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Subjects));
            System.Windows.Forms.Label sub_idLabel;
            System.Windows.Forms.Label sub_nameLabel;
            System.Windows.Forms.Label dept_noLabel;
            System.Windows.Forms.Label teach_idLabel;
            System.Windows.Forms.Label costLabel;
            System.Windows.Forms.Label sessionsLabel;
            System.Windows.Forms.Label start_dateLabel;
            this.instituteDataSet = new Institute.instituteDataSet();
            this.sUBJECTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sUBJECTSTableAdapter = new Institute.instituteDataSetTableAdapters.SUBJECTSTableAdapter();
            this.tableAdapterManager = new Institute.instituteDataSetTableAdapters.TableAdapterManager();
            this.sUBJECTSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.sUBJECTSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.sub_idTextBox = new System.Windows.Forms.TextBox();
            this.sub_nameTextBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.sessionsTextBox = new System.Windows.Forms.TextBox();
            this.start_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sUBJECTSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dEPARTMENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dEPARTMENTSTableAdapter = new Institute.instituteDataSetTableAdapters.DEPARTMENTSTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tEACHERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tEACHERSTableAdapter = new Institute.instituteDataSetTableAdapters.TEACHERSTableAdapter();
            sub_idLabel = new System.Windows.Forms.Label();
            sub_nameLabel = new System.Windows.Forms.Label();
            dept_noLabel = new System.Windows.Forms.Label();
            teach_idLabel = new System.Windows.Forms.Label();
            costLabel = new System.Windows.Forms.Label();
            sessionsLabel = new System.Windows.Forms.Label();
            start_dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.instituteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUBJECTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUBJECTSBindingNavigator)).BeginInit();
            this.sUBJECTSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sUBJECTSDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTMENTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEACHERSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // instituteDataSet
            // 
            this.instituteDataSet.DataSetName = "instituteDataSet";
            this.instituteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sUBJECTSBindingSource
            // 
            this.sUBJECTSBindingSource.DataMember = "SUBJECTS";
            this.sUBJECTSBindingSource.DataSource = this.instituteDataSet;
            // 
            // sUBJECTSTableAdapter
            // 
            this.sUBJECTSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DEPARTMENTSTableAdapter = this.dEPARTMENTSTableAdapter;
            this.tableAdapterManager.EMPLOYEES_JOBSTableAdapter = null;
            this.tableAdapterManager.EMPOLYEESTableAdapter = null;
            this.tableAdapterManager.STUDENTSTableAdapter = null;
            this.tableAdapterManager.SUBJECTSTableAdapter = this.sUBJECTSTableAdapter;
            this.tableAdapterManager.TEACHERSTableAdapter = this.tEACHERSTableAdapter;
            this.tableAdapterManager.UpdateOrder = Institute.instituteDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sUBJECTSBindingNavigator
            // 
            this.sUBJECTSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sUBJECTSBindingNavigator.BindingSource = this.sUBJECTSBindingSource;
            this.sUBJECTSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sUBJECTSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sUBJECTSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.sUBJECTSBindingNavigatorSaveItem});
            this.sUBJECTSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sUBJECTSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sUBJECTSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sUBJECTSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sUBJECTSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sUBJECTSBindingNavigator.Name = "sUBJECTSBindingNavigator";
            this.sUBJECTSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sUBJECTSBindingNavigator.Size = new System.Drawing.Size(741, 25);
            this.sUBJECTSBindingNavigator.TabIndex = 0;
            this.sUBJECTSBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // sUBJECTSBindingNavigatorSaveItem
            // 
            this.sUBJECTSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sUBJECTSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sUBJECTSBindingNavigatorSaveItem.Image")));
            this.sUBJECTSBindingNavigatorSaveItem.Name = "sUBJECTSBindingNavigatorSaveItem";
            this.sUBJECTSBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.sUBJECTSBindingNavigatorSaveItem.Text = "Save Data";
            this.sUBJECTSBindingNavigatorSaveItem.Click += new System.EventHandler(this.sUBJECTSBindingNavigatorSaveItem_Click);
            // 
            // sub_idLabel
            // 
            sub_idLabel.AutoSize = true;
            sub_idLabel.Location = new System.Drawing.Point(45, 41);
            sub_idLabel.Name = "sub_idLabel";
            sub_idLabel.Size = new System.Drawing.Size(39, 13);
            sub_idLabel.TabIndex = 1;
            sub_idLabel.Text = "sub id:";
            // 
            // sub_idTextBox
            // 
            this.sub_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sUBJECTSBindingSource, "sub_id", true));
            this.sub_idTextBox.Location = new System.Drawing.Point(110, 38);
            this.sub_idTextBox.Name = "sub_idTextBox";
            this.sub_idTextBox.Size = new System.Drawing.Size(200, 20);
            this.sub_idTextBox.TabIndex = 2;
            // 
            // sub_nameLabel
            // 
            sub_nameLabel.AutoSize = true;
            sub_nameLabel.Location = new System.Drawing.Point(45, 67);
            sub_nameLabel.Name = "sub_nameLabel";
            sub_nameLabel.Size = new System.Drawing.Size(57, 13);
            sub_nameLabel.TabIndex = 3;
            sub_nameLabel.Text = "sub name:";
            // 
            // sub_nameTextBox
            // 
            this.sub_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sUBJECTSBindingSource, "sub_name", true));
            this.sub_nameTextBox.Location = new System.Drawing.Point(110, 64);
            this.sub_nameTextBox.Name = "sub_nameTextBox";
            this.sub_nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.sub_nameTextBox.TabIndex = 4;
            // 
            // dept_noLabel
            // 
            dept_noLabel.AutoSize = true;
            dept_noLabel.Location = new System.Drawing.Point(45, 93);
            dept_noLabel.Name = "dept_noLabel";
            dept_noLabel.Size = new System.Drawing.Size(48, 13);
            dept_noLabel.TabIndex = 5;
            dept_noLabel.Text = "dept no:";
            // 
            // teach_idLabel
            // 
            teach_idLabel.AutoSize = true;
            teach_idLabel.Location = new System.Drawing.Point(45, 119);
            teach_idLabel.Name = "teach_idLabel";
            teach_idLabel.Size = new System.Drawing.Size(49, 13);
            teach_idLabel.TabIndex = 7;
            teach_idLabel.Text = "teach id:";
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new System.Drawing.Point(45, 145);
            costLabel.Name = "costLabel";
            costLabel.Size = new System.Drawing.Size(31, 13);
            costLabel.TabIndex = 9;
            costLabel.Text = "cost:";
            // 
            // costTextBox
            // 
            this.costTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sUBJECTSBindingSource, "cost", true));
            this.costTextBox.Location = new System.Drawing.Point(110, 142);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(200, 20);
            this.costTextBox.TabIndex = 10;
            // 
            // sessionsLabel
            // 
            sessionsLabel.AutoSize = true;
            sessionsLabel.Location = new System.Drawing.Point(45, 171);
            sessionsLabel.Name = "sessionsLabel";
            sessionsLabel.Size = new System.Drawing.Size(51, 13);
            sessionsLabel.TabIndex = 11;
            sessionsLabel.Text = "sessions:";
            // 
            // sessionsTextBox
            // 
            this.sessionsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sUBJECTSBindingSource, "sessions", true));
            this.sessionsTextBox.Location = new System.Drawing.Point(110, 168);
            this.sessionsTextBox.Name = "sessionsTextBox";
            this.sessionsTextBox.Size = new System.Drawing.Size(200, 20);
            this.sessionsTextBox.TabIndex = 12;
            // 
            // start_dateLabel
            // 
            start_dateLabel.AutoSize = true;
            start_dateLabel.Location = new System.Drawing.Point(45, 198);
            start_dateLabel.Name = "start_dateLabel";
            start_dateLabel.Size = new System.Drawing.Size(59, 13);
            start_dateLabel.TabIndex = 13;
            start_dateLabel.Text = "start date:";
            // 
            // start_dateDateTimePicker
            // 
            this.start_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.sUBJECTSBindingSource, "start_date", true));
            this.start_dateDateTimePicker.Location = new System.Drawing.Point(110, 194);
            this.start_dateDateTimePicker.Name = "start_dateDateTimePicker";
            this.start_dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.start_dateDateTimePicker.TabIndex = 14;
            // 
            // sUBJECTSDataGridView
            // 
            this.sUBJECTSDataGridView.AutoGenerateColumns = false;
            this.sUBJECTSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sUBJECTSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.sUBJECTSDataGridView.DataSource = this.sUBJECTSBindingSource;
            this.sUBJECTSDataGridView.Location = new System.Drawing.Point(12, 220);
            this.sUBJECTSDataGridView.Name = "sUBJECTSDataGridView";
            this.sUBJECTSDataGridView.Size = new System.Drawing.Size(715, 220);
            this.sUBJECTSDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "sub_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "sub_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "sub_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "sub_name";
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
            this.dataGridViewTextBoxColumn4.DataPropertyName = "teach_id";
            this.dataGridViewTextBoxColumn4.HeaderText = "teach_id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "cost";
            this.dataGridViewTextBoxColumn5.HeaderText = "cost";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "sessions";
            this.dataGridViewTextBoxColumn6.HeaderText = "sessions";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "start_date";
            this.dataGridViewTextBoxColumn7.HeaderText = "start_date";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 21);
            this.button1.TabIndex = 16;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sUBJECTSBindingSource, "dept_no", true));
            this.comboBox1.DataSource = this.dEPARTMENTSBindingSource;
            this.comboBox1.DisplayMember = "dept_name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(110, 89);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.ValueMember = "dept_id";
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
            this.button2.Location = new System.Drawing.Point(316, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 21);
            this.button2.TabIndex = 18;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sUBJECTSBindingSource, "teach_id", true));
            this.comboBox2.DataSource = this.tEACHERSBindingSource;
            this.comboBox2.DisplayMember = "teach_name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(110, 115);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 21);
            this.comboBox2.TabIndex = 19;
            this.comboBox2.ValueMember = "teach_id";
            // 
            // tEACHERSBindingSource
            // 
            this.tEACHERSBindingSource.DataMember = "TEACHERS";
            this.tEACHERSBindingSource.DataSource = this.instituteDataSet;
            // 
            // tEACHERSTableAdapter
            // 
            this.tEACHERSTableAdapter.ClearBeforeFill = true;
            // 
            // Subjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 468);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sUBJECTSDataGridView);
            this.Controls.Add(sub_idLabel);
            this.Controls.Add(this.sub_idTextBox);
            this.Controls.Add(sub_nameLabel);
            this.Controls.Add(this.sub_nameTextBox);
            this.Controls.Add(dept_noLabel);
            this.Controls.Add(teach_idLabel);
            this.Controls.Add(costLabel);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(sessionsLabel);
            this.Controls.Add(this.sessionsTextBox);
            this.Controls.Add(start_dateLabel);
            this.Controls.Add(this.start_dateDateTimePicker);
            this.Controls.Add(this.sUBJECTSBindingNavigator);
            this.Name = "Subjects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subjects";
            this.Load += new System.EventHandler(this.Subjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.instituteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUBJECTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUBJECTSBindingNavigator)).EndInit();
            this.sUBJECTSBindingNavigator.ResumeLayout(false);
            this.sUBJECTSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sUBJECTSDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTMENTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEACHERSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private instituteDataSet instituteDataSet;
        private System.Windows.Forms.BindingSource sUBJECTSBindingSource;
        private instituteDataSetTableAdapters.SUBJECTSTableAdapter sUBJECTSTableAdapter;
        private instituteDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sUBJECTSBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton sUBJECTSBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox sub_idTextBox;
        private System.Windows.Forms.TextBox sub_nameTextBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.TextBox sessionsTextBox;
        private System.Windows.Forms.DateTimePicker start_dateDateTimePicker;
        private System.Windows.Forms.DataGridView sUBJECTSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private instituteDataSetTableAdapters.DEPARTMENTSTableAdapter dEPARTMENTSTableAdapter;
        private System.Windows.Forms.BindingSource dEPARTMENTSBindingSource;
        private System.Windows.Forms.Button button2;
        private instituteDataSetTableAdapters.TEACHERSTableAdapter tEACHERSTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource tEACHERSBindingSource;
    }
}