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
			this.rootSplitContainer = new System.Windows.Forms.SplitContainer();
			this.employeeGroupBox = new System.Windows.Forms.GroupBox();
			this.employeeDataGridView = new System.Windows.Forms.DataGridView();
			this.employeeLoginColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.employeeNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.newsGroupBox = new System.Windows.Forms.GroupBox();
			this.newsTextBox = new System.Windows.Forms.RichTextBox();
			((System.ComponentModel.ISupportInitialize)(this.rootSplitContainer)).BeginInit();
			this.rootSplitContainer.Panel1.SuspendLayout();
			this.rootSplitContainer.Panel2.SuspendLayout();
			this.rootSplitContainer.SuspendLayout();
			this.employeeGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
			this.newsGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// rootSplitContainer
			// 
			this.rootSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rootSplitContainer.Location = new System.Drawing.Point(0, 0);
			this.rootSplitContainer.Name = "rootSplitContainer";
			// 
			// rootSplitContainer.Panel1
			// 
			this.rootSplitContainer.Panel1.Controls.Add(this.employeeGroupBox);
			// 
			// rootSplitContainer.Panel2
			// 
			this.rootSplitContainer.Panel2.Controls.Add(this.newsGroupBox);
			this.rootSplitContainer.Size = new System.Drawing.Size(792, 496);
			this.rootSplitContainer.SplitterDistance = 476;
			this.rootSplitContainer.TabIndex = 0;
			// 
			// employeeGroupBox
			// 
			this.employeeGroupBox.Controls.Add(this.employeeDataGridView);
			this.employeeGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.employeeGroupBox.Location = new System.Drawing.Point(0, 0);
			this.employeeGroupBox.Name = "employeeGroupBox";
			this.employeeGroupBox.Size = new System.Drawing.Size(476, 496);
			this.employeeGroupBox.TabIndex = 0;
			this.employeeGroupBox.TabStop = false;
			this.employeeGroupBox.Text = "Employees";
			// 
			// employeeDataGridView
			// 
			this.employeeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.employeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeLoginColumn,
            this.employeeNameColumn});
			this.employeeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.employeeDataGridView.Location = new System.Drawing.Point(3, 18);
			this.employeeDataGridView.Name = "employeeDataGridView";
			this.employeeDataGridView.ReadOnly = true;
			this.employeeDataGridView.RowTemplate.Height = 24;
			this.employeeDataGridView.Size = new System.Drawing.Size(470, 475);
			this.employeeDataGridView.TabIndex = 0;
			// 
			// employeeLoginColumn
			// 
			this.employeeLoginColumn.HeaderText = "login";
			this.employeeLoginColumn.Name = "employeeLoginColumn";
			this.employeeLoginColumn.ReadOnly = true;
			this.employeeLoginColumn.Width = 63;
			// 
			// employeeNameColumn
			// 
			this.employeeNameColumn.HeaderText = "name";
			this.employeeNameColumn.Name = "employeeNameColumn";
			this.employeeNameColumn.ReadOnly = true;
			this.employeeNameColumn.Width = 68;
			// 
			// newsGroupBox
			// 
			this.newsGroupBox.Controls.Add(this.newsTextBox);
			this.newsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.newsGroupBox.Location = new System.Drawing.Point(0, 0);
			this.newsGroupBox.Name = "newsGroupBox";
			this.newsGroupBox.Size = new System.Drawing.Size(312, 496);
			this.newsGroupBox.TabIndex = 0;
			this.newsGroupBox.TabStop = false;
			this.newsGroupBox.Text = "News";
			// 
			// newsTextBox
			// 
			this.newsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.newsTextBox.Location = new System.Drawing.Point(3, 18);
			this.newsTextBox.Name = "newsTextBox";
			this.newsTextBox.ReadOnly = true;
			this.newsTextBox.Size = new System.Drawing.Size(306, 475);
			this.newsTextBox.TabIndex = 0;
			this.newsTextBox.Text = "";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(792, 496);
			this.Controls.Add(this.rootSplitContainer);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "NetDS - Web Services - Terminal";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.rootSplitContainer.Panel1.ResumeLayout(false);
			this.rootSplitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.rootSplitContainer)).EndInit();
			this.rootSplitContainer.ResumeLayout(false);
			this.employeeGroupBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
			this.newsGroupBox.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer rootSplitContainer;
		private System.Windows.Forms.GroupBox employeeGroupBox;
		private System.Windows.Forms.DataGridView employeeDataGridView;
		private System.Windows.Forms.GroupBox newsGroupBox;
		private System.Windows.Forms.RichTextBox newsTextBox;
		private System.Windows.Forms.DataGridViewTextBoxColumn employeeLoginColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn employeeNameColumn;
	}
}