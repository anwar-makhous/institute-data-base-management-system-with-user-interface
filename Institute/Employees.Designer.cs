namespace Institute
{
    partial class Employees
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
            System.Windows.Forms.Label emp_idLabel;
            System.Windows.Forms.Label emp_nameLabel;
            System.Windows.Forms.Label emp_jobLabel;
            System.Windows.Forms.Label dept_noLabel;
            System.Windows.Forms.Label emp_mobLabel;
            System.Windows.Forms.Label emp_emailLabel;
            System.Windows.Forms.Label join_dateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees));
            this.instituteDataSet = new Institute.instituteDataSet();
            this.eMPOLYEESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMPOLYEESTableAdapter = new Institute.instituteDataSetTableAdapters.EMPOLYEESTableAdapter();
            this.tableAdapterManager = new Institute.instituteDataSetTableAdapters.TableAdapterManager();
            this.dEPARTMENTSTableAdapter = new Institute.instituteDataSetTableAdapters.DEPARTMENTSTableAdapter();
            this.eMPLOYEES_JOBSTableAdapter = new Institute.instituteDataSetTableAdapters.EMPLOYEES_JOBSTableAdapter();
            this.eMPOLYEESBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.eMPOLYEESBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.emp_idTextBox = new System.Windows.Forms.TextBox();
            this.emp_nameTextBox = new System.Windows.Forms.TextBox();
            this.emp_mobTextBox = new System.Windows.Forms.TextBox();
            this.emp_emailTextBox = new System.Windows.Forms.TextBox();
            this.join_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.eMPOLYEESDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.eMPLOYEESJOBSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dEPARTMENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dEPARTMENTSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            emp_idLabel = new System.Windows.Forms.Label();
            emp_nameLabel = new System.Windows.Forms.Label();
            emp_jobLabel = new System.Windows.Forms.Label();
            dept_noLabel = new System.Windows.Forms.Label();
            emp_mobLabel = new System.Windows.Forms.Label();
            emp_emailLabel = new System.Windows.Forms.Label();
            join_dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.instituteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPOLYEESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPOLYEESBindingNavigator)).BeginInit();
            this.eMPOLYEESBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMPOLYEESDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEESJOBSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTMENTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTMENTSBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // emp_idLabel
            // 
            emp_idLabel.AutoSize = true;
            emp_idLabel.Location = new System.Drawing.Point(29, 36);
            emp_idLabel.Name = "emp_idLabel";
            emp_idLabel.Size = new System.Drawing.Size(42, 13);
            emp_idLabel.TabIndex = 1;
            emp_idLabel.Text = "emp id:";
            // 
            // emp_nameLabel
            // 
            emp_nameLabel.AutoSize = true;
            emp_nameLabel.Location = new System.Drawing.Point(29, 62);
            emp_nameLabel.Name = "emp_nameLabel";
            emp_nameLabel.Size = new System.Drawing.Size(60, 13);
            emp_nameLabel.TabIndex = 3;
            emp_nameLabel.Text = "emp name:";
            // 
            // emp_jobLabel
            // 
            emp_jobLabel.AutoSize = true;
            emp_jobLabel.Location = new System.Drawing.Point(29, 88);
            emp_jobLabel.Name = "emp_jobLabel";
            emp_jobLabel.Size = new System.Drawing.Size(49, 13);
            emp_jobLabel.TabIndex = 5;
            emp_jobLabel.Text = "emp job:";
            // 
            // dept_noLabel
            // 
            dept_noLabel.AutoSize = true;
            dept_noLabel.Location = new System.Drawing.Point(29, 114);
            dept_noLabel.Name = "dept_noLabel";
            dept_noLabel.Size = new System.Drawing.Size(48, 13);
            dept_noLabel.TabIndex = 7;
            dept_noLabel.Text = "dept no:";
            // 
            // emp_mobLabel
            // 
            emp_mobLabel.AutoSize = true;
            emp_mobLabel.Location = new System.Drawing.Point(29, 140);
            emp_mobLabel.Name = "emp_mobLabel";
            emp_mobLabel.Size = new System.Drawing.Size(54, 13);
            emp_mobLabel.TabIndex = 9;
            emp_mobLabel.Text = "emp mob:";
            // 
            // emp_emailLabel
            // 
            emp_emailLabel.AutoSize = true;
            emp_emailLabel.Location = new System.Drawing.Point(29, 166);
            emp_emailLabel.Name = "emp_emailLabel";
            emp_emailLabel.Size = new System.Drawing.Size(58, 13);
            emp_emailLabel.TabIndex = 11;
            emp_emailLabel.Text = "emp email:";
            // 
            // join_dateLabel
            // 
            join_dateLabel.AutoSize = true;
            join_dateLabel.Location = new System.Drawing.Point(29, 193);
            join_dateLabel.Name = "join_dateLabel";
            join_dateLabel.Size = new System.Drawing.Size(53, 13);
            join_dateLabel.TabIndex = 13;
            join_dateLabel.Text = "join date:";
            // 
            // instituteDataSet
            // 
            this.instituteDataSet.DataSetName = "instituteDataSet";
            this.instituteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eMPOLYEESBindingSource
            // 
            this.eMPOLYEESBindingSource.DataMember = "EMPOLYEES";
            this.eMPOLYEESBindingSource.DataSource = this.instituteDataSet;
            // 
            // eMPOLYEESTableAdapter
            // 
            this.eMPOLYEESTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DEPARTMENTSTableAdapter = this.dEPARTMENTSTableAdapter;
            this.tableAdapterManager.EMPLOYEES_JOBSTableAdapter = this.eMPLOYEES_JOBSTableAdapter;
            this.tableAdapterManager.EMPOLYEESTableAdapter = this.eMPOLYEESTableAdapter;
            this.tableAdapterManager.STUDENTSTableAdapter = null;
            this.tableAdapterManager.SUBJECTSTableAdapter = null;
            this.tableAdapterManager.TEACHERSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Institute.instituteDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dEPARTMENTSTableAdapter
            // 
            this.dEPARTMENTSTableAdapter.ClearBeforeFill = true;
            // 
            // eMPLOYEES_JOBSTableAdapter
            // 
            this.eMPLOYEES_JOBSTableAdapter.ClearBeforeFill = true;
            // 
            // eMPOLYEESBindingNavigator
            // 
            this.eMPOLYEESBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.eMPOLYEESBindingNavigator.BindingSource = this.eMPOLYEESBindingSource;
            this.eMPOLYEESBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.eMPOLYEESBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.eMPOLYEESBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.eMPOLYEESBindingNavigatorSaveItem});
            this.eMPOLYEESBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.eMPOLYEESBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.eMPOLYEESBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.eMPOLYEESBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.eMPOLYEESBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.eMPOLYEESBindingNavigator.Name = "eMPOLYEESBindingNavigator";
            this.eMPOLYEESBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.eMPOLYEESBindingNavigator.Size = new System.Drawing.Size(770, 25);
            this.eMPOLYEESBindingNavigator.TabIndex = 0;
            this.eMPOLYEESBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // eMPOLYEESBindingNavigatorSaveItem
            // 
            this.eMPOLYEESBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eMPOLYEESBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("eMPOLYEESBindingNavigatorSaveItem.Image")));
            this.eMPOLYEESBindingNavigatorSaveItem.Name = "eMPOLYEESBindingNavigatorSaveItem";
            this.eMPOLYEESBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.eMPOLYEESBindingNavigatorSaveItem.Text = "Save Data";
            this.eMPOLYEESBindingNavigatorSaveItem.Click += new System.EventHandler(this.eMPOLYEESBindingNavigatorSaveItem_Click);
            // 
            // emp_idTextBox
            // 
            this.emp_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPOLYEESBindingSource, "emp_id", true));
            this.emp_idTextBox.Location = new System.Drawing.Point(95, 33);
            this.emp_idTextBox.Name = "emp_idTextBox";
            this.emp_idTextBox.Size = new System.Drawing.Size(200, 20);
            this.emp_idTextBox.TabIndex = 2;
            // 
            // emp_nameTextBox
            // 
            this.emp_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPOLYEESBindingSource, "emp_name", true));
            this.emp_nameTextBox.Location = new System.Drawing.Point(95, 59);
            this.emp_nameTextBox.Name = "emp_nameTextBox";
            this.emp_nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.emp_nameTextBox.TabIndex = 4;
            // 
            // emp_mobTextBox
            // 
            this.emp_mobTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPOLYEESBindingSource, "emp_mob", true));
            this.emp_mobTextBox.Location = new System.Drawing.Point(95, 137);
            this.emp_mobTextBox.Name = "emp_mobTextBox";
            this.emp_mobTextBox.Size = new System.Drawing.Size(200, 20);
            this.emp_mobTextBox.TabIndex = 10;
            // 
            // emp_emailTextBox
            // 
            this.emp_emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPOLYEESBindingSource, "emp_email", true));
            this.emp_emailTextBox.Location = new System.Drawing.Point(95, 163);
            this.emp_emailTextBox.Name = "emp_emailTextBox";
            this.emp_emailTextBox.Size = new System.Drawing.Size(200, 20);
            this.emp_emailTextBox.TabIndex = 12;
            // 
            // join_dateDateTimePicker
            // 
            this.join_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eMPOLYEESBindingSource, "join_date", true));
            this.join_dateDateTimePicker.Location = new System.Drawing.Point(95, 189);
            this.join_dateDateTimePicker.Name = "join_dateDateTimePicker";
            this.join_dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.join_dateDateTimePicker.TabIndex = 14;
            // 
            // eMPOLYEESDataGridView
            // 
            this.eMPOLYEESDataGridView.AutoGenerateColumns = false;
            this.eMPOLYEESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eMPOLYEESDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.eMPOLYEESDataGridView.DataSource = this.eMPOLYEESBindingSource;
            this.eMPOLYEESDataGridView.Location = new System.Drawing.Point(12, 236);
            this.eMPOLYEESDataGridView.Name = "eMPOLYEESDataGridView";
            this.eMPOLYEESDataGridView.Size = new System.Drawing.Size(742, 220);
            this.eMPOLYEESDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "emp_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "emp_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "emp_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "emp_name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "emp_job";
            this.dataGridViewTextBoxColumn3.HeaderText = "emp_job";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "dept_no";
            this.dataGridViewTextBoxColumn4.HeaderText = "dept_no";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "emp_mob";
            this.dataGridViewTextBoxColumn5.HeaderText = "emp_mob";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "emp_email";
            this.dataGridViewTextBoxColumn6.HeaderText = "emp_email";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "join_date";
            this.dataGridViewTextBoxColumn7.HeaderText = "join_date";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 20);
            this.button1.TabIndex = 16;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(301, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(22, 21);
            this.button2.TabIndex = 17;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.eMPOLYEESBindingSource, "emp_job", true));
            this.comboBox1.DataSource = this.eMPLOYEESJOBSBindingSource;
            this.comboBox1.DisplayMember = "job";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(95, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.ValueMember = "job_id";
            // 
            // eMPLOYEESJOBSBindingSource
            // 
            this.eMPLOYEESJOBSBindingSource.DataMember = "EMPLOYEES_JOBS";
            this.eMPLOYEESJOBSBindingSource.DataSource = this.instituteDataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.eMPOLYEESBindingSource, "dept_no", true));
            this.comboBox2.DataSource = this.dEPARTMENTSBindingSource;
            this.comboBox2.DisplayMember = "dept_name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(95, 111);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 21);
            this.comboBox2.TabIndex = 19;
            this.comboBox2.ValueMember = "dept_id";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // dEPARTMENTSBindingSource
            // 
            this.dEPARTMENTSBindingSource.DataMember = "DEPARTMENTS";
            this.dEPARTMENTSBindingSource.DataSource = this.instituteDataSet;
            // 
            // dEPARTMENTSBindingSource1
            // 
            this.dEPARTMENTSBindingSource1.DataMember = "DEPARTMENTS";
            this.dEPARTMENTSBindingSource1.DataSource = this.instituteDataSet;
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 480);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.eMPOLYEESDataGridView);
            this.Controls.Add(emp_idLabel);
            this.Controls.Add(this.emp_idTextBox);
            this.Controls.Add(emp_nameLabel);
            this.Controls.Add(this.emp_nameTextBox);
            this.Controls.Add(emp_jobLabel);
            this.Controls.Add(dept_noLabel);
            this.Controls.Add(emp_mobLabel);
            this.Controls.Add(this.emp_mobTextBox);
            this.Controls.Add(emp_emailLabel);
            this.Controls.Add(this.emp_emailTextBox);
            this.Controls.Add(join_dateLabel);
            this.Controls.Add(this.join_dateDateTimePicker);
            this.Controls.Add(this.eMPOLYEESBindingNavigator);
            this.Name = "Employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.instituteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPOLYEESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPOLYEESBindingNavigator)).EndInit();
            this.eMPOLYEESBindingNavigator.ResumeLayout(false);
            this.eMPOLYEESBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMPOLYEESDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEESJOBSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTMENTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTMENTSBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private instituteDataSet instituteDataSet;
        private System.Windows.Forms.BindingSource eMPOLYEESBindingSource;
        private instituteDataSetTableAdapters.EMPOLYEESTableAdapter eMPOLYEESTableAdapter;
        private instituteDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator eMPOLYEESBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton eMPOLYEESBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox emp_idTextBox;
        private System.Windows.Forms.TextBox emp_nameTextBox;
        private System.Windows.Forms.TextBox emp_mobTextBox;
        private System.Windows.Forms.TextBox emp_emailTextBox;
        private System.Windows.Forms.DateTimePicker join_dateDateTimePicker;
        private System.Windows.Forms.DataGridView eMPOLYEESDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private instituteDataSetTableAdapters.EMPLOYEES_JOBSTableAdapter eMPLOYEES_JOBSTableAdapter;
        private System.Windows.Forms.BindingSource eMPLOYEESJOBSBindingSource;
        private instituteDataSetTableAdapters.DEPARTMENTSTableAdapter dEPARTMENTSTableAdapter;
        private System.Windows.Forms.BindingSource dEPARTMENTSBindingSource;
        private System.Windows.Forms.BindingSource dEPARTMENTSBindingSource1;
    }
}