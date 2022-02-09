namespace Institute
{
    partial class Employees_Jobs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees_Jobs));
            System.Windows.Forms.Label job_idLabel;
            System.Windows.Forms.Label jobLabel;
            System.Windows.Forms.Label salaryLabel;
            this.instituteDataSet = new Institute.instituteDataSet();
            this.eMPLOYEES_JOBSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLOYEES_JOBSTableAdapter = new Institute.instituteDataSetTableAdapters.EMPLOYEES_JOBSTableAdapter();
            this.tableAdapterManager = new Institute.instituteDataSetTableAdapters.TableAdapterManager();
            this.eMPLOYEES_JOBSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.eMPLOYEES_JOBSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.eMPLOYEES_JOBSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.job_idTextBox = new System.Windows.Forms.TextBox();
            this.jobTextBox = new System.Windows.Forms.TextBox();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            job_idLabel = new System.Windows.Forms.Label();
            jobLabel = new System.Windows.Forms.Label();
            salaryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.instituteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEES_JOBSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEES_JOBSBindingNavigator)).BeginInit();
            this.eMPLOYEES_JOBSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEES_JOBSDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // instituteDataSet
            // 
            this.instituteDataSet.DataSetName = "instituteDataSet";
            this.instituteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eMPLOYEES_JOBSBindingSource
            // 
            this.eMPLOYEES_JOBSBindingSource.DataMember = "EMPLOYEES_JOBS";
            this.eMPLOYEES_JOBSBindingSource.DataSource = this.instituteDataSet;
            // 
            // eMPLOYEES_JOBSTableAdapter
            // 
            this.eMPLOYEES_JOBSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DEPARTMENTSTableAdapter = null;
            this.tableAdapterManager.EMPLOYEES_JOBSTableAdapter = this.eMPLOYEES_JOBSTableAdapter;
            this.tableAdapterManager.EMPOLYEESTableAdapter = null;
            this.tableAdapterManager.STUDENTSTableAdapter = null;
            this.tableAdapterManager.SUBJECTSTableAdapter = null;
            this.tableAdapterManager.TEACHERSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Institute.instituteDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // eMPLOYEES_JOBSBindingNavigator
            // 
            this.eMPLOYEES_JOBSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.eMPLOYEES_JOBSBindingNavigator.BindingSource = this.eMPLOYEES_JOBSBindingSource;
            this.eMPLOYEES_JOBSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.eMPLOYEES_JOBSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.eMPLOYEES_JOBSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.eMPLOYEES_JOBSBindingNavigatorSaveItem});
            this.eMPLOYEES_JOBSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.eMPLOYEES_JOBSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.eMPLOYEES_JOBSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.eMPLOYEES_JOBSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.eMPLOYEES_JOBSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.eMPLOYEES_JOBSBindingNavigator.Name = "eMPLOYEES_JOBSBindingNavigator";
            this.eMPLOYEES_JOBSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.eMPLOYEES_JOBSBindingNavigator.Size = new System.Drawing.Size(362, 25);
            this.eMPLOYEES_JOBSBindingNavigator.TabIndex = 0;
            this.eMPLOYEES_JOBSBindingNavigator.Text = "bindingNavigator1";
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
            // eMPLOYEES_JOBSBindingNavigatorSaveItem
            // 
            this.eMPLOYEES_JOBSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eMPLOYEES_JOBSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("eMPLOYEES_JOBSBindingNavigatorSaveItem.Image")));
            this.eMPLOYEES_JOBSBindingNavigatorSaveItem.Name = "eMPLOYEES_JOBSBindingNavigatorSaveItem";
            this.eMPLOYEES_JOBSBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.eMPLOYEES_JOBSBindingNavigatorSaveItem.Text = "Save Data";
            this.eMPLOYEES_JOBSBindingNavigatorSaveItem.Click += new System.EventHandler(this.eMPLOYEES_JOBSBindingNavigatorSaveItem_Click);
            // 
            // eMPLOYEES_JOBSDataGridView
            // 
            this.eMPLOYEES_JOBSDataGridView.AutoGenerateColumns = false;
            this.eMPLOYEES_JOBSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eMPLOYEES_JOBSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.eMPLOYEES_JOBSDataGridView.DataSource = this.eMPLOYEES_JOBSBindingSource;
            this.eMPLOYEES_JOBSDataGridView.Location = new System.Drawing.Point(12, 143);
            this.eMPLOYEES_JOBSDataGridView.Name = "eMPLOYEES_JOBSDataGridView";
            this.eMPLOYEES_JOBSDataGridView.Size = new System.Drawing.Size(338, 220);
            this.eMPLOYEES_JOBSDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "job_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "job_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "job";
            this.dataGridViewTextBoxColumn2.HeaderText = "job";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "salary";
            this.dataGridViewTextBoxColumn3.HeaderText = "salary";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // job_idLabel
            // 
            job_idLabel.AutoSize = true;
            job_idLabel.Location = new System.Drawing.Point(83, 46);
            job_idLabel.Name = "job_idLabel";
            job_idLabel.Size = new System.Drawing.Size(37, 13);
            job_idLabel.TabIndex = 2;
            job_idLabel.Text = "job id:";
            // 
            // job_idTextBox
            // 
            this.job_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLOYEES_JOBSBindingSource, "job_id", true));
            this.job_idTextBox.Location = new System.Drawing.Point(129, 43);
            this.job_idTextBox.Name = "job_idTextBox";
            this.job_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.job_idTextBox.TabIndex = 3;
            // 
            // jobLabel
            // 
            jobLabel.AutoSize = true;
            jobLabel.Location = new System.Drawing.Point(83, 72);
            jobLabel.Name = "jobLabel";
            jobLabel.Size = new System.Drawing.Size(26, 13);
            jobLabel.TabIndex = 4;
            jobLabel.Text = "job:";
            // 
            // jobTextBox
            // 
            this.jobTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLOYEES_JOBSBindingSource, "job", true));
            this.jobTextBox.Location = new System.Drawing.Point(129, 69);
            this.jobTextBox.Name = "jobTextBox";
            this.jobTextBox.Size = new System.Drawing.Size(100, 20);
            this.jobTextBox.TabIndex = 5;
            // 
            // salaryLabel
            // 
            salaryLabel.AutoSize = true;
            salaryLabel.Location = new System.Drawing.Point(83, 98);
            salaryLabel.Name = "salaryLabel";
            salaryLabel.Size = new System.Drawing.Size(40, 13);
            salaryLabel.TabIndex = 6;
            salaryLabel.Text = "salary:";
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLOYEES_JOBSBindingSource, "salary", true));
            this.salaryTextBox.Location = new System.Drawing.Point(129, 95);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(100, 20);
            this.salaryTextBox.TabIndex = 7;
            // 
            // Employees_Jobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 418);
            this.Controls.Add(job_idLabel);
            this.Controls.Add(this.job_idTextBox);
            this.Controls.Add(jobLabel);
            this.Controls.Add(this.jobTextBox);
            this.Controls.Add(salaryLabel);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(this.eMPLOYEES_JOBSDataGridView);
            this.Controls.Add(this.eMPLOYEES_JOBSBindingNavigator);
            this.Name = "Employees_Jobs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees_Jobs";
            this.Load += new System.EventHandler(this.Employees_Jobs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.instituteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEES_JOBSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEES_JOBSBindingNavigator)).EndInit();
            this.eMPLOYEES_JOBSBindingNavigator.ResumeLayout(false);
            this.eMPLOYEES_JOBSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEES_JOBSDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private instituteDataSet instituteDataSet;
        private System.Windows.Forms.BindingSource eMPLOYEES_JOBSBindingSource;
        private instituteDataSetTableAdapters.EMPLOYEES_JOBSTableAdapter eMPLOYEES_JOBSTableAdapter;
        private instituteDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator eMPLOYEES_JOBSBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton eMPLOYEES_JOBSBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView eMPLOYEES_JOBSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox job_idTextBox;
        private System.Windows.Forms.TextBox jobTextBox;
        private System.Windows.Forms.TextBox salaryTextBox;
    }
}