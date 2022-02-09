namespace Institute
{
    partial class Teachers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teachers));
            System.Windows.Forms.Label teach_idLabel;
            System.Windows.Forms.Label teach_nameLabel;
            System.Windows.Forms.Label dept_noLabel;
            System.Windows.Forms.Label sub_nameLabel;
            System.Windows.Forms.Label salaryLabel;
            System.Windows.Forms.Label mobLabel;
            System.Windows.Forms.Label emailLabel;
            this.instituteDataSet = new Institute.instituteDataSet();
            this.tEACHERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tEACHERSTableAdapter = new Institute.instituteDataSetTableAdapters.TEACHERSTableAdapter();
            this.tableAdapterManager = new Institute.instituteDataSetTableAdapters.TableAdapterManager();
            this.tEACHERSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tEACHERSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.teach_idTextBox = new System.Windows.Forms.TextBox();
            this.teach_nameTextBox = new System.Windows.Forms.TextBox();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.mobTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.tEACHERSDataGridView = new System.Windows.Forms.DataGridView();
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            teach_idLabel = new System.Windows.Forms.Label();
            teach_nameLabel = new System.Windows.Forms.Label();
            dept_noLabel = new System.Windows.Forms.Label();
            sub_nameLabel = new System.Windows.Forms.Label();
            salaryLabel = new System.Windows.Forms.Label();
            mobLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.instituteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEACHERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEACHERSBindingNavigator)).BeginInit();
            this.tEACHERSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tEACHERSDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTMENTSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // instituteDataSet
            // 
            this.instituteDataSet.DataSetName = "instituteDataSet";
            this.instituteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DEPARTMENTSTableAdapter = this.dEPARTMENTSTableAdapter;
            this.tableAdapterManager.EMPLOYEES_JOBSTableAdapter = null;
            this.tableAdapterManager.EMPOLYEESTableAdapter = null;
            this.tableAdapterManager.STUDENTSTableAdapter = null;
            this.tableAdapterManager.SUBJECTSTableAdapter = null;
            this.tableAdapterManager.TEACHERSTableAdapter = this.tEACHERSTableAdapter;
            this.tableAdapterManager.UpdateOrder = Institute.instituteDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tEACHERSBindingNavigator
            // 
            this.tEACHERSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tEACHERSBindingNavigator.BindingSource = this.tEACHERSBindingSource;
            this.tEACHERSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tEACHERSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tEACHERSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tEACHERSBindingNavigatorSaveItem});
            this.tEACHERSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tEACHERSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tEACHERSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tEACHERSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tEACHERSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tEACHERSBindingNavigator.Name = "tEACHERSBindingNavigator";
            this.tEACHERSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tEACHERSBindingNavigator.Size = new System.Drawing.Size(764, 25);
            this.tEACHERSBindingNavigator.TabIndex = 0;
            this.tEACHERSBindingNavigator.Text = "bindingNavigator1";
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
            // tEACHERSBindingNavigatorSaveItem
            // 
            this.tEACHERSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tEACHERSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tEACHERSBindingNavigatorSaveItem.Image")));
            this.tEACHERSBindingNavigatorSaveItem.Name = "tEACHERSBindingNavigatorSaveItem";
            this.tEACHERSBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tEACHERSBindingNavigatorSaveItem.Text = "Save Data";
            this.tEACHERSBindingNavigatorSaveItem.Click += new System.EventHandler(this.tEACHERSBindingNavigatorSaveItem_Click);
            // 
            // teach_idLabel
            // 
            teach_idLabel.AutoSize = true;
            teach_idLabel.Location = new System.Drawing.Point(35, 33);
            teach_idLabel.Name = "teach_idLabel";
            teach_idLabel.Size = new System.Drawing.Size(49, 13);
            teach_idLabel.TabIndex = 1;
            teach_idLabel.Text = "teach id:";
            // 
            // teach_idTextBox
            // 
            this.teach_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tEACHERSBindingSource, "teach_id", true));
            this.teach_idTextBox.Location = new System.Drawing.Point(108, 30);
            this.teach_idTextBox.Name = "teach_idTextBox";
            this.teach_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.teach_idTextBox.TabIndex = 2;
            // 
            // teach_nameLabel
            // 
            teach_nameLabel.AutoSize = true;
            teach_nameLabel.Location = new System.Drawing.Point(35, 59);
            teach_nameLabel.Name = "teach_nameLabel";
            teach_nameLabel.Size = new System.Drawing.Size(67, 13);
            teach_nameLabel.TabIndex = 3;
            teach_nameLabel.Text = "teach name:";
            // 
            // teach_nameTextBox
            // 
            this.teach_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tEACHERSBindingSource, "teach_name", true));
            this.teach_nameTextBox.Location = new System.Drawing.Point(108, 56);
            this.teach_nameTextBox.Name = "teach_nameTextBox";
            this.teach_nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.teach_nameTextBox.TabIndex = 4;
            // 
            // dept_noLabel
            // 
            dept_noLabel.AutoSize = true;
            dept_noLabel.Location = new System.Drawing.Point(35, 85);
            dept_noLabel.Name = "dept_noLabel";
            dept_noLabel.Size = new System.Drawing.Size(48, 13);
            dept_noLabel.TabIndex = 5;
            dept_noLabel.Text = "dept no:";
            // 
            // sub_nameLabel
            // 
            sub_nameLabel.AutoSize = true;
            sub_nameLabel.Location = new System.Drawing.Point(35, 111);
            sub_nameLabel.Name = "sub_nameLabel";
            sub_nameLabel.Size = new System.Drawing.Size(57, 13);
            sub_nameLabel.TabIndex = 7;
            sub_nameLabel.Text = "sub name:";
            // 
            // salaryLabel
            // 
            salaryLabel.AutoSize = true;
            salaryLabel.Location = new System.Drawing.Point(35, 137);
            salaryLabel.Name = "salaryLabel";
            salaryLabel.Size = new System.Drawing.Size(40, 13);
            salaryLabel.TabIndex = 9;
            salaryLabel.Text = "salary:";
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tEACHERSBindingSource, "salary", true));
            this.salaryTextBox.Location = new System.Drawing.Point(108, 134);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(100, 20);
            this.salaryTextBox.TabIndex = 10;
            // 
            // mobLabel
            // 
            mobLabel.AutoSize = true;
            mobLabel.Location = new System.Drawing.Point(35, 163);
            mobLabel.Name = "mobLabel";
            mobLabel.Size = new System.Drawing.Size(31, 13);
            mobLabel.TabIndex = 11;
            mobLabel.Text = "mob:";
            // 
            // mobTextBox
            // 
            this.mobTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tEACHERSBindingSource, "mob", true));
            this.mobTextBox.Location = new System.Drawing.Point(108, 160);
            this.mobTextBox.Name = "mobTextBox";
            this.mobTextBox.Size = new System.Drawing.Size(100, 20);
            this.mobTextBox.TabIndex = 12;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(35, 189);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 13;
            emailLabel.Text = "email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tEACHERSBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(108, 186);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 14;
            // 
            // tEACHERSDataGridView
            // 
            this.tEACHERSDataGridView.AutoGenerateColumns = false;
            this.tEACHERSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tEACHERSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.tEACHERSDataGridView.DataSource = this.tEACHERSBindingSource;
            this.tEACHERSDataGridView.Location = new System.Drawing.Point(12, 212);
            this.tEACHERSDataGridView.Name = "tEACHERSDataGridView";
            this.tEACHERSDataGridView.Size = new System.Drawing.Size(740, 220);
            this.tEACHERSDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "teach_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "teach_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "teach_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "teach_name";
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
            this.dataGridViewTextBoxColumn4.DataPropertyName = "sub_name";
            this.dataGridViewTextBoxColumn4.HeaderText = "sub_name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "salary";
            this.dataGridViewTextBoxColumn5.HeaderText = "salary";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "mob";
            this.dataGridViewTextBoxColumn6.HeaderText = "mob";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn7.HeaderText = "email";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 21);
            this.button1.TabIndex = 16;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tEACHERSBindingSource, "dept_no", true));
            this.comboBox1.DataSource = this.dEPARTMENTSBindingSource;
            this.comboBox1.DisplayMember = "dept_name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(108, 82);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(214, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(22, 20);
            this.button2.TabIndex = 19;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Teachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 454);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tEACHERSDataGridView);
            this.Controls.Add(teach_idLabel);
            this.Controls.Add(this.teach_idTextBox);
            this.Controls.Add(teach_nameLabel);
            this.Controls.Add(this.teach_nameTextBox);
            this.Controls.Add(dept_noLabel);
            this.Controls.Add(sub_nameLabel);
            this.Controls.Add(salaryLabel);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(mobLabel);
            this.Controls.Add(this.mobTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.tEACHERSBindingNavigator);
            this.Name = "Teachers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teachers";
            this.Load += new System.EventHandler(this.Teachers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.instituteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEACHERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEACHERSBindingNavigator)).EndInit();
            this.tEACHERSBindingNavigator.ResumeLayout(false);
            this.tEACHERSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tEACHERSDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTMENTSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private instituteDataSet instituteDataSet;
        private System.Windows.Forms.BindingSource tEACHERSBindingSource;
        private instituteDataSetTableAdapters.TEACHERSTableAdapter tEACHERSTableAdapter;
        private instituteDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tEACHERSBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tEACHERSBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox teach_idTextBox;
        private System.Windows.Forms.TextBox teach_nameTextBox;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.TextBox mobTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.DataGridView tEACHERSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private instituteDataSetTableAdapters.DEPARTMENTSTableAdapter dEPARTMENTSTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource dEPARTMENTSBindingSource;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
    }
}