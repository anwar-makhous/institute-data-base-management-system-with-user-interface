namespace Institute
{
    partial class Departments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Departments));
            System.Windows.Forms.Label dept_idLabel;
            System.Windows.Forms.Label dept_nameLabel;
            this.instituteDataSet = new Institute.instituteDataSet();
            this.dEPARTMENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dEPARTMENTSTableAdapter = new Institute.instituteDataSetTableAdapters.DEPARTMENTSTableAdapter();
            this.tableAdapterManager = new Institute.instituteDataSetTableAdapters.TableAdapterManager();
            this.dEPARTMENTSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.dEPARTMENTSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dept_idTextBox = new System.Windows.Forms.TextBox();
            this.dept_nameTextBox = new System.Windows.Forms.TextBox();
            this.dEPARTMENTSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dept_idLabel = new System.Windows.Forms.Label();
            dept_nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.instituteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTMENTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTMENTSBindingNavigator)).BeginInit();
            this.dEPARTMENTSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTMENTSDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // instituteDataSet
            // 
            this.instituteDataSet.DataSetName = "instituteDataSet";
            this.instituteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DEPARTMENTSTableAdapter = this.dEPARTMENTSTableAdapter;
            this.tableAdapterManager.EMPLOYEES_JOBSTableAdapter = null;
            this.tableAdapterManager.EMPOLYEESTableAdapter = null;
            this.tableAdapterManager.STUDENTSTableAdapter = null;
            this.tableAdapterManager.SUBJECTSTableAdapter = null;
            this.tableAdapterManager.TEACHERSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Institute.instituteDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dEPARTMENTSBindingNavigator
            // 
            this.dEPARTMENTSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dEPARTMENTSBindingNavigator.BindingSource = this.dEPARTMENTSBindingSource;
            this.dEPARTMENTSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dEPARTMENTSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dEPARTMENTSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.dEPARTMENTSBindingNavigatorSaveItem});
            this.dEPARTMENTSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dEPARTMENTSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dEPARTMENTSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dEPARTMENTSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dEPARTMENTSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dEPARTMENTSBindingNavigator.Name = "dEPARTMENTSBindingNavigator";
            this.dEPARTMENTSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dEPARTMENTSBindingNavigator.Size = new System.Drawing.Size(280, 25);
            this.dEPARTMENTSBindingNavigator.TabIndex = 0;
            this.dEPARTMENTSBindingNavigator.Text = "bindingNavigator1";
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
            // dEPARTMENTSBindingNavigatorSaveItem
            // 
            this.dEPARTMENTSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dEPARTMENTSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dEPARTMENTSBindingNavigatorSaveItem.Image")));
            this.dEPARTMENTSBindingNavigatorSaveItem.Name = "dEPARTMENTSBindingNavigatorSaveItem";
            this.dEPARTMENTSBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.dEPARTMENTSBindingNavigatorSaveItem.Text = "Save Data";
            this.dEPARTMENTSBindingNavigatorSaveItem.Click += new System.EventHandler(this.dEPARTMENTSBindingNavigatorSaveItem_Click);
            // 
            // dept_idLabel
            // 
            dept_idLabel.AutoSize = true;
            dept_idLabel.Location = new System.Drawing.Point(54, 46);
            dept_idLabel.Name = "dept_idLabel";
            dept_idLabel.Size = new System.Drawing.Size(44, 13);
            dept_idLabel.TabIndex = 1;
            dept_idLabel.Text = "dept id:";
            // 
            // dept_idTextBox
            // 
            this.dept_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dEPARTMENTSBindingSource, "dept_id", true));
            this.dept_idTextBox.Location = new System.Drawing.Point(122, 43);
            this.dept_idTextBox.Name = "dept_idTextBox";
            this.dept_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.dept_idTextBox.TabIndex = 2;
            // 
            // dept_nameLabel
            // 
            dept_nameLabel.AutoSize = true;
            dept_nameLabel.Location = new System.Drawing.Point(54, 72);
            dept_nameLabel.Name = "dept_nameLabel";
            dept_nameLabel.Size = new System.Drawing.Size(62, 13);
            dept_nameLabel.TabIndex = 3;
            dept_nameLabel.Text = "dept name:";
            // 
            // dept_nameTextBox
            // 
            this.dept_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dEPARTMENTSBindingSource, "dept_name", true));
            this.dept_nameTextBox.Location = new System.Drawing.Point(122, 69);
            this.dept_nameTextBox.Name = "dept_nameTextBox";
            this.dept_nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.dept_nameTextBox.TabIndex = 4;
            // 
            // dEPARTMENTSDataGridView
            // 
            this.dEPARTMENTSDataGridView.AutoGenerateColumns = false;
            this.dEPARTMENTSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dEPARTMENTSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dEPARTMENTSDataGridView.DataSource = this.dEPARTMENTSBindingSource;
            this.dEPARTMENTSDataGridView.Location = new System.Drawing.Point(22, 95);
            this.dEPARTMENTSDataGridView.Name = "dEPARTMENTSDataGridView";
            this.dEPARTMENTSDataGridView.Size = new System.Drawing.Size(235, 220);
            this.dEPARTMENTSDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "dept_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "dept_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "dept_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "dept_name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Departments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 383);
            this.Controls.Add(this.dEPARTMENTSDataGridView);
            this.Controls.Add(dept_idLabel);
            this.Controls.Add(this.dept_idTextBox);
            this.Controls.Add(dept_nameLabel);
            this.Controls.Add(this.dept_nameTextBox);
            this.Controls.Add(this.dEPARTMENTSBindingNavigator);
            this.Name = "Departments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Departments";
            this.Load += new System.EventHandler(this.Departments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.instituteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTMENTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTMENTSBindingNavigator)).EndInit();
            this.dEPARTMENTSBindingNavigator.ResumeLayout(false);
            this.dEPARTMENTSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTMENTSDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private instituteDataSet instituteDataSet;
        private System.Windows.Forms.BindingSource dEPARTMENTSBindingSource;
        private instituteDataSetTableAdapters.DEPARTMENTSTableAdapter dEPARTMENTSTableAdapter;
        private instituteDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dEPARTMENTSBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton dEPARTMENTSBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox dept_idTextBox;
        private System.Windows.Forms.TextBox dept_nameTextBox;
        private System.Windows.Forms.DataGridView dEPARTMENTSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}