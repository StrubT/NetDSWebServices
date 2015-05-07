namespace BFH.NetDS.WebServices.ControlStation {
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.tabControl = new System.Windows.Forms.TabControl();
			this.newsTab = new System.Windows.Forms.TabPage();
			this.newsSplitContainer = new System.Windows.Forms.SplitContainer();
			this.newsChangeGroup = new System.Windows.Forms.GroupBox();
			this.newsChangeLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.newsChangeTextBox = new System.Windows.Forms.RichTextBox();
			this.newsChangeButton = new System.Windows.Forms.Button();
			this.newsStatusGroup = new System.Windows.Forms.GroupBox();
			this.newsStatusGridView = new System.Windows.Forms.DataGridView();
			this.terminalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.newsStatusDataSet = new System.Data.DataSet();
			this.newsStatusDataTable = new System.Data.DataTable();
			this.newsStatusTerminalColumn = new System.Data.DataColumn();
			this.newsStatusStatusColumn = new System.Data.DataColumn();
			this.statisticsTab = new System.Windows.Forms.TabPage();
			this.statisticsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.statisticsDataSet = new System.Data.DataSet();
			this.statisticsDataTable = new System.Data.DataTable();
			this.statisticsTerminalNameColumn = new System.Data.DataColumn();
			this.statisticsUniqueUsersColumn = new System.Data.DataColumn();
			this.statisticsTimeStampsColumn = new System.Data.DataColumn();
			this.tabControl.SuspendLayout();
			this.newsTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.newsSplitContainer)).BeginInit();
			this.newsSplitContainer.Panel1.SuspendLayout();
			this.newsSplitContainer.Panel2.SuspendLayout();
			this.newsSplitContainer.SuspendLayout();
			this.newsChangeGroup.SuspendLayout();
			this.newsChangeLayoutPanel.SuspendLayout();
			this.newsStatusGroup.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.newsStatusGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.newsStatusDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.newsStatusDataTable)).BeginInit();
			this.statisticsTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.statisticsChart)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statisticsDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statisticsDataTable)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.newsTab);
			this.tabControl.Controls.Add(this.statisticsTab);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.Location = new System.Drawing.Point(0, 0);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(973, 565);
			this.tabControl.TabIndex = 0;
			this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
			// 
			// newsTab
			// 
			this.newsTab.Controls.Add(this.newsSplitContainer);
			this.newsTab.Location = new System.Drawing.Point(4, 22);
			this.newsTab.Name = "newsTab";
			this.newsTab.Padding = new System.Windows.Forms.Padding(3);
			this.newsTab.Size = new System.Drawing.Size(965, 539);
			this.newsTab.TabIndex = 0;
			this.newsTab.Text = "news";
			this.newsTab.UseVisualStyleBackColor = true;
			// 
			// newsSplitContainer
			// 
			this.newsSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.newsSplitContainer.Location = new System.Drawing.Point(3, 3);
			this.newsSplitContainer.Name = "newsSplitContainer";
			// 
			// newsSplitContainer.Panel1
			// 
			this.newsSplitContainer.Panel1.Controls.Add(this.newsChangeGroup);
			// 
			// newsSplitContainer.Panel2
			// 
			this.newsSplitContainer.Panel2.Controls.Add(this.newsStatusGroup);
			this.newsSplitContainer.Size = new System.Drawing.Size(959, 533);
			this.newsSplitContainer.SplitterDistance = 318;
			this.newsSplitContainer.TabIndex = 0;
			// 
			// newsChangeGroup
			// 
			this.newsChangeGroup.Controls.Add(this.newsChangeLayoutPanel);
			this.newsChangeGroup.Dock = System.Windows.Forms.DockStyle.Fill;
			this.newsChangeGroup.Location = new System.Drawing.Point(0, 0);
			this.newsChangeGroup.Name = "newsChangeGroup";
			this.newsChangeGroup.Size = new System.Drawing.Size(318, 533);
			this.newsChangeGroup.TabIndex = 0;
			this.newsChangeGroup.TabStop = false;
			this.newsChangeGroup.Text = "set new news text";
			// 
			// newsChangeLayoutPanel
			// 
			this.newsChangeLayoutPanel.ColumnCount = 1;
			this.newsChangeLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.newsChangeLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.newsChangeLayoutPanel.Controls.Add(this.newsChangeTextBox, 0, 0);
			this.newsChangeLayoutPanel.Controls.Add(this.newsChangeButton, 0, 1);
			this.newsChangeLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.newsChangeLayoutPanel.Location = new System.Drawing.Point(3, 16);
			this.newsChangeLayoutPanel.Name = "newsChangeLayoutPanel";
			this.newsChangeLayoutPanel.RowCount = 2;
			this.newsChangeLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.newsChangeLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.newsChangeLayoutPanel.Size = new System.Drawing.Size(312, 514);
			this.newsChangeLayoutPanel.TabIndex = 0;
			// 
			// newsChangeTextBox
			// 
			this.newsChangeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.newsChangeTextBox.Location = new System.Drawing.Point(3, 3);
			this.newsChangeTextBox.Name = "newsChangeTextBox";
			this.newsChangeTextBox.Size = new System.Drawing.Size(306, 475);
			this.newsChangeTextBox.TabIndex = 0;
			this.newsChangeTextBox.Text = "";
			// 
			// newsChangeButton
			// 
			this.newsChangeButton.AutoSize = true;
			this.newsChangeButton.Dock = System.Windows.Forms.DockStyle.Right;
			this.newsChangeButton.Location = new System.Drawing.Point(210, 484);
			this.newsChangeButton.Name = "newsChangeButton";
			this.newsChangeButton.Size = new System.Drawing.Size(99, 27);
			this.newsChangeButton.TabIndex = 1;
			this.newsChangeButton.Text = "set news text";
			this.newsChangeButton.UseVisualStyleBackColor = true;
			this.newsChangeButton.Click += new System.EventHandler(this.newsChangeButton_Click);
			// 
			// newsStatusGroup
			// 
			this.newsStatusGroup.Controls.Add(this.newsStatusGridView);
			this.newsStatusGroup.Dock = System.Windows.Forms.DockStyle.Fill;
			this.newsStatusGroup.Location = new System.Drawing.Point(0, 0);
			this.newsStatusGroup.Name = "newsStatusGroup";
			this.newsStatusGroup.Size = new System.Drawing.Size(637, 533);
			this.newsStatusGroup.TabIndex = 1;
			this.newsStatusGroup.TabStop = false;
			this.newsStatusGroup.Text = "news status";
			// 
			// newsStatusGridView
			// 
			this.newsStatusGridView.AllowUserToAddRows = false;
			this.newsStatusGridView.AllowUserToDeleteRows = false;
			this.newsStatusGridView.AllowUserToResizeColumns = false;
			this.newsStatusGridView.AllowUserToResizeRows = false;
			this.newsStatusGridView.AutoGenerateColumns = false;
			this.newsStatusGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.newsStatusGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.newsStatusGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.terminalDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
			this.newsStatusGridView.DataMember = "NewsStatusDataTable";
			this.newsStatusGridView.DataSource = this.newsStatusDataSet;
			this.newsStatusGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.newsStatusGridView.Location = new System.Drawing.Point(3, 16);
			this.newsStatusGridView.MultiSelect = false;
			this.newsStatusGridView.Name = "newsStatusGridView";
			this.newsStatusGridView.ReadOnly = true;
			this.newsStatusGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.newsStatusGridView.Size = new System.Drawing.Size(631, 514);
			this.newsStatusGridView.TabIndex = 0;
			// 
			// terminalDataGridViewTextBoxColumn
			// 
			this.terminalDataGridViewTextBoxColumn.DataPropertyName = "terminal";
			this.terminalDataGridViewTextBoxColumn.HeaderText = "terminal";
			this.terminalDataGridViewTextBoxColumn.Name = "terminalDataGridViewTextBoxColumn";
			this.terminalDataGridViewTextBoxColumn.ReadOnly = true;
			this.terminalDataGridViewTextBoxColumn.Width = 68;
			// 
			// statusDataGridViewTextBoxColumn
			// 
			this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
			this.statusDataGridViewTextBoxColumn.HeaderText = "status";
			this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
			this.statusDataGridViewTextBoxColumn.ReadOnly = true;
			this.statusDataGridViewTextBoxColumn.Width = 60;
			// 
			// newsStatusDataSet
			// 
			this.newsStatusDataSet.DataSetName = "NewsStatusDataSet";
			this.newsStatusDataSet.Tables.AddRange(new System.Data.DataTable[] {
            this.newsStatusDataTable});
			// 
			// newsStatusDataTable
			// 
			this.newsStatusDataTable.Columns.AddRange(new System.Data.DataColumn[] {
            this.newsStatusTerminalColumn,
            this.newsStatusStatusColumn});
			this.newsStatusDataTable.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "terminal"}, true)});
			this.newsStatusDataTable.PrimaryKey = new System.Data.DataColumn[] {
        this.newsStatusTerminalColumn};
			this.newsStatusDataTable.TableName = "NewsStatusDataTable";
			// 
			// newsStatusTerminalColumn
			// 
			this.newsStatusTerminalColumn.AllowDBNull = false;
			this.newsStatusTerminalColumn.ColumnName = "terminal";
			this.newsStatusTerminalColumn.DefaultValue = "";
			// 
			// newsStatusStatusColumn
			// 
			this.newsStatusStatusColumn.AllowDBNull = false;
			this.newsStatusStatusColumn.ColumnName = "status";
			this.newsStatusStatusColumn.DefaultValue = "";
			// 
			// statisticsTab
			// 
			this.statisticsTab.Controls.Add(this.statisticsChart);
			this.statisticsTab.Location = new System.Drawing.Point(4, 22);
			this.statisticsTab.Name = "statisticsTab";
			this.statisticsTab.Padding = new System.Windows.Forms.Padding(3);
			this.statisticsTab.Size = new System.Drawing.Size(965, 539);
			this.statisticsTab.TabIndex = 1;
			this.statisticsTab.Text = "terminal statistics";
			this.statisticsTab.UseVisualStyleBackColor = true;
			// 
			// statisticsChart
			// 
			chartArea1.AxisX.MajorGrid.Enabled = false;
			chartArea1.AxisX.Title = "terminals";
			chartArea1.AxisY.MajorGrid.Enabled = false;
			chartArea1.Name = "StatisticsChartArea";
			this.statisticsChart.ChartAreas.Add(chartArea1);
			this.statisticsChart.DataSource = this.statisticsDataSet;
			this.statisticsChart.Dock = System.Windows.Forms.DockStyle.Fill;
			legend1.Alignment = System.Drawing.StringAlignment.Center;
			legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
			legend1.Name = "StatisticsLegend";
			legend1.Title = "legend";
			this.statisticsChart.Legends.Add(legend1);
			this.statisticsChart.Location = new System.Drawing.Point(3, 3);
			this.statisticsChart.Margin = new System.Windows.Forms.Padding(2);
			this.statisticsChart.Name = "statisticsChart";
			series1.ChartArea = "StatisticsChartArea";
			series1.Label = "#VAL";
			series1.Legend = "StatisticsLegend";
			series1.Name = "# unique users";
			series1.XValueMember = "terminalName";
			series1.YValueMembers = "uniqueUsers";
			series2.ChartArea = "StatisticsChartArea";
			series2.Label = "#VAL";
			series2.Legend = "StatisticsLegend";
			series2.Name = "# time stamps";
			series2.XValueMember = "terminalName";
			series2.YValueMembers = "timeStamps";
			this.statisticsChart.Series.Add(series1);
			this.statisticsChart.Series.Add(series2);
			this.statisticsChart.Size = new System.Drawing.Size(959, 533);
			this.statisticsChart.TabIndex = 0;
			this.statisticsChart.Text = "Terminal Statistics";
			title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			title1.Name = "StatisticsChartTitle";
			title1.Text = "Terminal Statistics";
			this.statisticsChart.Titles.Add(title1);
			// 
			// statisticsDataSet
			// 
			this.statisticsDataSet.DataSetName = "NewDataSet";
			this.statisticsDataSet.Tables.AddRange(new System.Data.DataTable[] {
            this.statisticsDataTable});
			// 
			// statisticsDataTable
			// 
			this.statisticsDataTable.Columns.AddRange(new System.Data.DataColumn[] {
            this.statisticsTerminalNameColumn,
            this.statisticsUniqueUsersColumn,
            this.statisticsTimeStampsColumn});
			this.statisticsDataTable.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "terminalName"}, true)});
			this.statisticsDataTable.PrimaryKey = new System.Data.DataColumn[] {
        this.statisticsTerminalNameColumn};
			this.statisticsDataTable.TableName = "StatisticsDataTable";
			// 
			// statisticsTerminalNameColumn
			// 
			this.statisticsTerminalNameColumn.AllowDBNull = false;
			this.statisticsTerminalNameColumn.Caption = "terminal name";
			this.statisticsTerminalNameColumn.ColumnName = "terminalName";
			this.statisticsTerminalNameColumn.DefaultValue = "";
			// 
			// statisticsUniqueUsersColumn
			// 
			this.statisticsUniqueUsersColumn.AllowDBNull = false;
			this.statisticsUniqueUsersColumn.Caption = "# unique users";
			this.statisticsUniqueUsersColumn.ColumnName = "uniqueUsers";
			this.statisticsUniqueUsersColumn.DataType = typeof(int);
			this.statisticsUniqueUsersColumn.DefaultValue = 0;
			// 
			// statisticsTimeStampsColumn
			// 
			this.statisticsTimeStampsColumn.AllowDBNull = false;
			this.statisticsTimeStampsColumn.Caption = "# time stamps";
			this.statisticsTimeStampsColumn.ColumnName = "timeStamps";
			this.statisticsTimeStampsColumn.DataType = typeof(int);
			this.statisticsTimeStampsColumn.DefaultValue = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(973, 565);
			this.Controls.Add(this.tabControl);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "NetDS - Web Services - Control Station";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.tabControl.ResumeLayout(false);
			this.newsTab.ResumeLayout(false);
			this.newsSplitContainer.Panel1.ResumeLayout(false);
			this.newsSplitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.newsSplitContainer)).EndInit();
			this.newsSplitContainer.ResumeLayout(false);
			this.newsChangeGroup.ResumeLayout(false);
			this.newsChangeLayoutPanel.ResumeLayout(false);
			this.newsChangeLayoutPanel.PerformLayout();
			this.newsStatusGroup.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.newsStatusGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.newsStatusDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.newsStatusDataTable)).EndInit();
			this.statisticsTab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.statisticsChart)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statisticsDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statisticsDataTable)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage newsTab;
		private System.Windows.Forms.SplitContainer newsSplitContainer;
		private System.Windows.Forms.GroupBox newsChangeGroup;
		private System.Windows.Forms.TableLayoutPanel newsChangeLayoutPanel;
		private System.Windows.Forms.RichTextBox newsChangeTextBox;
		private System.Windows.Forms.Button newsChangeButton;
		private System.Windows.Forms.GroupBox newsStatusGroup;
		private System.Windows.Forms.DataGridView newsStatusGridView;
		private System.Windows.Forms.TabPage statisticsTab;
		private System.Data.DataSet newsStatusDataSet;
		private System.Data.DataTable newsStatusDataTable;
		private System.Data.DataColumn newsStatusTerminalColumn;
		private System.Data.DataColumn newsStatusStatusColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn terminalDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataVisualization.Charting.Chart statisticsChart;
		private System.Data.DataSet statisticsDataSet;
		private System.Data.DataTable statisticsDataTable;
		private System.Data.DataColumn statisticsTerminalNameColumn;
		private System.Data.DataColumn statisticsUniqueUsersColumn;
		private System.Data.DataColumn statisticsTimeStampsColumn;
	}
}