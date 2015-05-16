namespace BFH.NetDS.WebServices.Terminal {
	partial class MainForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.employeeDataSet = new System.Data.DataSet();
			this.employeeDataTable = new System.Data.DataTable();
			this.employeeLoginColumn = new System.Data.DataColumn();
			this.employeeNameColumn = new System.Data.DataColumn();
			this.rootTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.employeeGroupBox = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.employeeDataGridView = new System.Windows.Forms.DataGridView();
			this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.addEmployeeButton = new System.Windows.Forms.Button();
			this.newsGroupBox = new System.Windows.Forms.GroupBox();
			this.newsTextBox = new System.Windows.Forms.RichTextBox();
			this.hostLabel = new System.Windows.Forms.Label();
			this.hostTextBox = new System.Windows.Forms.TextBox();
			this.connectButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.employeeDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.employeeDataTable)).BeginInit();
			this.rootTableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			this.employeeGroupBox.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
			this.newsGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// employeeDataSet
			// 
			this.employeeDataSet.DataSetName = "EmployeeDataSet";
			this.employeeDataSet.Tables.AddRange(new System.Data.DataTable[] {
            this.employeeDataTable});
			// 
			// employeeDataTable
			// 
			this.employeeDataTable.Columns.AddRange(new System.Data.DataColumn[] {
            this.employeeLoginColumn,
            this.employeeNameColumn});
			this.employeeDataTable.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "login"}, true)});
			this.employeeDataTable.PrimaryKey = new System.Data.DataColumn[] {
        this.employeeLoginColumn};
			this.employeeDataTable.TableName = "EmployeeDataTable";
			// 
			// employeeLoginColumn
			// 
			this.employeeLoginColumn.AllowDBNull = false;
			this.employeeLoginColumn.ColumnName = "login";
			this.employeeLoginColumn.DefaultValue = "";
			// 
			// employeeNameColumn
			// 
			this.employeeNameColumn.AllowDBNull = false;
			this.employeeNameColumn.ColumnName = "name";
			this.employeeNameColumn.DefaultValue = "";
			// 
			// rootTableLayoutPanel
			// 
			this.rootTableLayoutPanel.ColumnCount = 3;
			this.rootTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.rootTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.rootTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.rootTableLayoutPanel.Controls.Add(this.splitContainer, 0, 1);
			this.rootTableLayoutPanel.Controls.Add(this.hostLabel, 0, 0);
			this.rootTableLayoutPanel.Controls.Add(this.hostTextBox, 1, 0);
			this.rootTableLayoutPanel.Controls.Add(this.connectButton, 2, 0);
			this.rootTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rootTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.rootTableLayoutPanel.Name = "rootTableLayoutPanel";
			this.rootTableLayoutPanel.RowCount = 2;
			this.rootTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.rootTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.rootTableLayoutPanel.Size = new System.Drawing.Size(594, 403);
			this.rootTableLayoutPanel.TabIndex = 0;
			// 
			// splitContainer
			// 
			this.rootTableLayoutPanel.SetColumnSpan(this.splitContainer, 3);
			this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer.Location = new System.Drawing.Point(0, 29);
			this.splitContainer.Margin = new System.Windows.Forms.Padding(0);
			this.splitContainer.Name = "splitContainer";
			// 
			// splitContainer.Panel1
			// 
			this.splitContainer.Panel1.Controls.Add(this.employeeGroupBox);
			this.splitContainer.Panel1.Padding = new System.Windows.Forms.Padding(5, 5, 2, 5);
			this.splitContainer.Panel1MinSize = 125;
			// 
			// splitContainer.Panel2
			// 
			this.splitContainer.Panel2.Controls.Add(this.newsGroupBox);
			this.splitContainer.Panel2.Padding = new System.Windows.Forms.Padding(2, 5, 5, 5);
			this.splitContainer.Panel2MinSize = 125;
			this.splitContainer.Size = new System.Drawing.Size(594, 374);
			this.splitContainer.SplitterDistance = 375;
			this.splitContainer.SplitterWidth = 3;
			this.splitContainer.TabIndex = 1;
			// 
			// employeeGroupBox
			// 
			this.employeeGroupBox.Controls.Add(this.tableLayoutPanel1);
			this.employeeGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.employeeGroupBox.Location = new System.Drawing.Point(5, 5);
			this.employeeGroupBox.Margin = new System.Windows.Forms.Padding(2);
			this.employeeGroupBox.Name = "employeeGroupBox";
			this.employeeGroupBox.Padding = new System.Windows.Forms.Padding(2);
			this.employeeGroupBox.Size = new System.Drawing.Size(368, 364);
			this.employeeGroupBox.TabIndex = 0;
			this.employeeGroupBox.TabStop = false;
			this.employeeGroupBox.Text = "Employees";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.employeeDataGridView, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.addEmployeeButton, 1, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 15);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(364, 347);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// employeeDataGridView
			// 
			this.employeeDataGridView.AllowUserToAddRows = false;
			this.employeeDataGridView.AllowUserToDeleteRows = false;
			this.employeeDataGridView.AllowUserToResizeColumns = false;
			this.employeeDataGridView.AllowUserToResizeRows = false;
			this.employeeDataGridView.AutoGenerateColumns = false;
			this.employeeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.employeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loginDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
			this.tableLayoutPanel1.SetColumnSpan(this.employeeDataGridView, 2);
			this.employeeDataGridView.DataMember = "EmployeeDataTable";
			this.employeeDataGridView.DataSource = this.employeeDataSet;
			this.employeeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.employeeDataGridView.Location = new System.Drawing.Point(2, 2);
			this.employeeDataGridView.Margin = new System.Windows.Forms.Padding(2);
			this.employeeDataGridView.MultiSelect = false;
			this.employeeDataGridView.Name = "employeeDataGridView";
			this.employeeDataGridView.ReadOnly = true;
			this.employeeDataGridView.RowTemplate.Height = 24;
			this.employeeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.employeeDataGridView.Size = new System.Drawing.Size(360, 314);
			this.employeeDataGridView.TabIndex = 1;
			this.employeeDataGridView.SelectionChanged += new System.EventHandler(this.employeeDataGridView_SelectionChanged);
			// 
			// loginDataGridViewTextBoxColumn
			// 
			this.loginDataGridViewTextBoxColumn.DataPropertyName = "login";
			this.loginDataGridViewTextBoxColumn.HeaderText = "login";
			this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
			this.loginDataGridViewTextBoxColumn.ReadOnly = true;
			this.loginDataGridViewTextBoxColumn.Width = 54;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ReadOnly = true;
			this.nameDataGridViewTextBoxColumn.Width = 58;
			// 
			// addEmployeeButton
			// 
			this.addEmployeeButton.AutoSize = true;
			this.addEmployeeButton.Location = new System.Drawing.Point(255, 321);
			this.addEmployeeButton.Name = "addEmployeeButton";
			this.addEmployeeButton.Size = new System.Drawing.Size(106, 23);
			this.addEmployeeButton.TabIndex = 2;
			this.addEmployeeButton.Text = "add new employee";
			this.addEmployeeButton.UseVisualStyleBackColor = true;
			this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
			// 
			// newsGroupBox
			// 
			this.newsGroupBox.Controls.Add(this.newsTextBox);
			this.newsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.newsGroupBox.Location = new System.Drawing.Point(2, 5);
			this.newsGroupBox.Margin = new System.Windows.Forms.Padding(2);
			this.newsGroupBox.Name = "newsGroupBox";
			this.newsGroupBox.Padding = new System.Windows.Forms.Padding(2);
			this.newsGroupBox.Size = new System.Drawing.Size(209, 364);
			this.newsGroupBox.TabIndex = 0;
			this.newsGroupBox.TabStop = false;
			this.newsGroupBox.Text = "News";
			// 
			// newsTextBox
			// 
			this.newsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.newsTextBox.Location = new System.Drawing.Point(2, 15);
			this.newsTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.newsTextBox.Name = "newsTextBox";
			this.newsTextBox.ReadOnly = true;
			this.newsTextBox.Size = new System.Drawing.Size(205, 347);
			this.newsTextBox.TabIndex = 0;
			this.newsTextBox.Text = "";
			// 
			// hostLabel
			// 
			this.hostLabel.AutoSize = true;
			this.hostLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.hostLabel.Location = new System.Drawing.Point(3, 0);
			this.hostLabel.Name = "hostLabel";
			this.hostLabel.Size = new System.Drawing.Size(62, 29);
			this.hostLabel.TabIndex = 3;
			this.hostLabel.Text = "server host:";
			this.hostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// hostTextBox
			// 
			this.hostTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.hostTextBox.Location = new System.Drawing.Point(71, 3);
			this.hostTextBox.Name = "hostTextBox";
			this.hostTextBox.Size = new System.Drawing.Size(171, 20);
			this.hostTextBox.TabIndex = 4;
			this.hostTextBox.Text = "localhost";
			// 
			// connectButton
			// 
			this.connectButton.AutoSize = true;
			this.connectButton.Dock = System.Windows.Forms.DockStyle.Left;
			this.connectButton.Location = new System.Drawing.Point(248, 3);
			this.connectButton.Name = "connectButton";
			this.connectButton.Size = new System.Drawing.Size(100, 23);
			this.connectButton.TabIndex = 6;
			this.connectButton.Text = "connect to server";
			this.connectButton.UseVisualStyleBackColor = true;
			this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(594, 403);
			this.Controls.Add(this.rootTableLayoutPanel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "NetDS - Web Services - Terminal";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.employeeDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.employeeDataTable)).EndInit();
			this.rootTableLayoutPanel.ResumeLayout(false);
			this.rootTableLayoutPanel.PerformLayout();
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
			this.splitContainer.ResumeLayout(false);
			this.employeeGroupBox.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
			this.newsGroupBox.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Data.DataSet employeeDataSet;
		private System.Data.DataTable employeeDataTable;
		private System.Data.DataColumn employeeLoginColumn;
		private System.Data.DataColumn employeeNameColumn;
		private System.Windows.Forms.TableLayoutPanel rootTableLayoutPanel;
		private System.Windows.Forms.SplitContainer splitContainer;
		private System.Windows.Forms.GroupBox employeeGroupBox;
		private System.Windows.Forms.GroupBox newsGroupBox;
		private System.Windows.Forms.RichTextBox newsTextBox;
		private System.Windows.Forms.Label hostLabel;
		private System.Windows.Forms.TextBox hostTextBox;
		private System.Windows.Forms.Button connectButton;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.DataGridView employeeDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button addEmployeeButton;
	}
}