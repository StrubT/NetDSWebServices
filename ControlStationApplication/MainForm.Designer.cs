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
			this.newsStatusDataSet = new System.Data.DataSet();
			this.newsStatusDataTable = new System.Data.DataTable();
			this.newsStatusTerminalColumn = new System.Data.DataColumn();
			this.newsStatusStatusColumn = new System.Data.DataColumn();
			this.statisticsTab = new System.Windows.Forms.TabPage();
			this.terminalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
			this.newsSplitContainer.SplitterDistance = 319;
			this.newsSplitContainer.TabIndex = 0;
			// 
			// newsChangeGroup
			// 
			this.newsChangeGroup.Controls.Add(this.newsChangeLayoutPanel);
			this.newsChangeGroup.Dock = System.Windows.Forms.DockStyle.Fill;
			this.newsChangeGroup.Location = new System.Drawing.Point(0, 0);
			this.newsChangeGroup.Name = "newsChangeGroup";
			this.newsChangeGroup.Size = new System.Drawing.Size(319, 533);
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
			this.newsChangeLayoutPanel.Size = new System.Drawing.Size(313, 514);
			this.newsChangeLayoutPanel.TabIndex = 0;
			// 
			// newsChangeTextBox
			// 
			this.newsChangeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.newsChangeTextBox.Location = new System.Drawing.Point(3, 3);
			this.newsChangeTextBox.Name = "newsChangeTextBox";
			this.newsChangeTextBox.Size = new System.Drawing.Size(307, 479);
			this.newsChangeTextBox.TabIndex = 0;
			this.newsChangeTextBox.Text = "";
			// 
			// newsChangeButton
			// 
			this.newsChangeButton.AutoSize = true;
			this.newsChangeButton.Dock = System.Windows.Forms.DockStyle.Right;
			this.newsChangeButton.Location = new System.Drawing.Point(231, 488);
			this.newsChangeButton.Name = "newsChangeButton";
			this.newsChangeButton.Size = new System.Drawing.Size(79, 23);
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
			this.newsStatusGroup.Size = new System.Drawing.Size(636, 533);
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
			this.newsStatusGridView.Name = "newsStatusGridView";
			this.newsStatusGridView.ReadOnly = true;
			this.newsStatusGridView.Size = new System.Drawing.Size(630, 514);
			this.newsStatusGridView.TabIndex = 0;
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
			this.statisticsTab.Location = new System.Drawing.Point(4, 22);
			this.statisticsTab.Name = "statisticsTab";
			this.statisticsTab.Padding = new System.Windows.Forms.Padding(3);
			this.statisticsTab.Size = new System.Drawing.Size(965, 539);
			this.statisticsTab.TabIndex = 1;
			this.statisticsTab.Text = "terminal statistics";
			this.statisticsTab.UseVisualStyleBackColor = true;
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
	}
}