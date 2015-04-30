namespace BFH.NetDS.WebServices.Terminal {
	partial class EmployeeDetailsForm {
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
			this.rootLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.timeStampsDataGridView = new System.Windows.Forms.DataGridView();
			this.timeStampButton = new System.Windows.Forms.Button();
			this.closeButton = new System.Windows.Forms.Button();
			this.timeStampsDataSet = new System.Data.DataSet();
			this.timeStampsDataTable = new System.Data.DataTable();
			this.timeStampsTimeStampColumn = new System.Data.DataColumn();
			this.timeStampCumulatedTimeColumn = new System.Data.DataColumn();
			this.timestampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cumulatedTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rootLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.timeStampsDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.timeStampsDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.timeStampsDataTable)).BeginInit();
			this.SuspendLayout();
			// 
			// rootLayoutPanel
			// 
			this.rootLayoutPanel.ColumnCount = 2;
			this.rootLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.rootLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.rootLayoutPanel.Controls.Add(this.timeStampsDataGridView, 0, 0);
			this.rootLayoutPanel.Controls.Add(this.timeStampButton, 0, 1);
			this.rootLayoutPanel.Controls.Add(this.closeButton, 1, 1);
			this.rootLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rootLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.rootLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
			this.rootLayoutPanel.Name = "rootLayoutPanel";
			this.rootLayoutPanel.RowCount = 2;
			this.rootLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.rootLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.rootLayoutPanel.Size = new System.Drawing.Size(392, 310);
			this.rootLayoutPanel.TabIndex = 0;
			// 
			// timeStampsDataGridView
			// 
			this.timeStampsDataGridView.AllowUserToAddRows = false;
			this.timeStampsDataGridView.AllowUserToDeleteRows = false;
			this.timeStampsDataGridView.AllowUserToResizeColumns = false;
			this.timeStampsDataGridView.AllowUserToResizeRows = false;
			this.timeStampsDataGridView.AutoGenerateColumns = false;
			this.timeStampsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.timeStampsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.timeStampsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.timestampDataGridViewTextBoxColumn,
            this.cumulatedTimeDataGridViewTextBoxColumn});
			this.rootLayoutPanel.SetColumnSpan(this.timeStampsDataGridView, 2);
			this.timeStampsDataGridView.DataMember = "TimeStampsDataTable";
			this.timeStampsDataGridView.DataSource = this.timeStampsDataSet;
			this.timeStampsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.timeStampsDataGridView.Location = new System.Drawing.Point(2, 2);
			this.timeStampsDataGridView.Margin = new System.Windows.Forms.Padding(2);
			this.timeStampsDataGridView.MultiSelect = false;
			this.timeStampsDataGridView.Name = "timeStampsDataGridView";
			this.timeStampsDataGridView.ReadOnly = true;
			this.timeStampsDataGridView.RowTemplate.Height = 24;
			this.timeStampsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.timeStampsDataGridView.Size = new System.Drawing.Size(388, 283);
			this.timeStampsDataGridView.TabIndex = 0;
			// 
			// timeStampButton
			// 
			this.timeStampButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.timeStampButton.Location = new System.Drawing.Point(2, 289);
			this.timeStampButton.Margin = new System.Windows.Forms.Padding(2);
			this.timeStampButton.Name = "timeStampButton";
			this.timeStampButton.Size = new System.Drawing.Size(192, 19);
			this.timeStampButton.TabIndex = 1;
			this.timeStampButton.Text = "add timestamp";
			this.timeStampButton.UseVisualStyleBackColor = true;
			this.timeStampButton.Click += new System.EventHandler(this.timeStampButton_Click);
			// 
			// closeButton
			// 
			this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.closeButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.closeButton.Location = new System.Drawing.Point(198, 289);
			this.closeButton.Margin = new System.Windows.Forms.Padding(2);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(192, 19);
			this.closeButton.TabIndex = 2;
			this.closeButton.Text = "close dialog";
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
			// 
			// timeStampsDataSet
			// 
			this.timeStampsDataSet.DataSetName = "TimeStampsDataSet";
			this.timeStampsDataSet.Tables.AddRange(new System.Data.DataTable[] {
            this.timeStampsDataTable});
			// 
			// timeStampsDataTable
			// 
			this.timeStampsDataTable.Columns.AddRange(new System.Data.DataColumn[] {
            this.timeStampsTimeStampColumn,
            this.timeStampCumulatedTimeColumn});
			this.timeStampsDataTable.TableName = "TimeStampsDataTable";
			// 
			// timeStampsTimeStampColumn
			// 
			this.timeStampsTimeStampColumn.AllowDBNull = false;
			this.timeStampsTimeStampColumn.ColumnName = "timestamp";
			this.timeStampsTimeStampColumn.DefaultValue = "";
			// 
			// timeStampCumulatedTimeColumn
			// 
			this.timeStampCumulatedTimeColumn.AllowDBNull = false;
			this.timeStampCumulatedTimeColumn.ColumnName = "cumulated time";
			this.timeStampCumulatedTimeColumn.DefaultValue = "";
			// 
			// timestampDataGridViewTextBoxColumn
			// 
			this.timestampDataGridViewTextBoxColumn.DataPropertyName = "timestamp";
			this.timestampDataGridViewTextBoxColumn.HeaderText = "timestamp";
			this.timestampDataGridViewTextBoxColumn.Name = "timestampDataGridViewTextBoxColumn";
			this.timestampDataGridViewTextBoxColumn.ReadOnly = true;
			this.timestampDataGridViewTextBoxColumn.Width = 79;
			// 
			// cumulatedTimeDataGridViewTextBoxColumn
			// 
			this.cumulatedTimeDataGridViewTextBoxColumn.DataPropertyName = "cumulated time";
			this.cumulatedTimeDataGridViewTextBoxColumn.HeaderText = "cumulated time";
			this.cumulatedTimeDataGridViewTextBoxColumn.Name = "cumulatedTimeDataGridViewTextBoxColumn";
			this.cumulatedTimeDataGridViewTextBoxColumn.ReadOnly = true;
			this.cumulatedTimeDataGridViewTextBoxColumn.Width = 95;
			// 
			// EmployeeDetailsForm
			// 
			this.AcceptButton = this.timeStampButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.closeButton;
			this.ClientSize = new System.Drawing.Size(392, 310);
			this.Controls.Add(this.rootLayoutPanel);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "EmployeeDetailsForm";
			this.ShowIcon = false;
			this.Text = "EmployeeDetailsForm";
			this.Load += new System.EventHandler(this.EmployeeDetailsForm_Load);
			this.rootLayoutPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.timeStampsDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.timeStampsDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.timeStampsDataTable)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel rootLayoutPanel;
		private System.Windows.Forms.DataGridView timeStampsDataGridView;
		private System.Windows.Forms.Button timeStampButton;
		private System.Windows.Forms.DataGridViewTextBoxColumn timestampDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn cumulatedTimeDataGridViewTextBoxColumn;
		private System.Data.DataSet timeStampsDataSet;
		private System.Data.DataTable timeStampsDataTable;
		private System.Data.DataColumn timeStampsTimeStampColumn;
		private System.Data.DataColumn timeStampCumulatedTimeColumn;
		private System.Windows.Forms.Button closeButton;
	}
}