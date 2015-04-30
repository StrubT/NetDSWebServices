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
			this.timeStampColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.timeStampSpanColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rootLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.timeStampsDataGridView)).BeginInit();
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
			this.rootLayoutPanel.Name = "rootLayoutPanel";
			this.rootLayoutPanel.RowCount = 2;
			this.rootLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.rootLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.rootLayoutPanel.Size = new System.Drawing.Size(523, 381);
			this.rootLayoutPanel.TabIndex = 0;
			// 
			// timeStampsDataGridView
			// 
			this.timeStampsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.timeStampsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.timeStampsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.timeStampColumn,
            this.timeStampSpanColumn});
			this.rootLayoutPanel.SetColumnSpan(this.timeStampsDataGridView, 2);
			this.timeStampsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.timeStampsDataGridView.Location = new System.Drawing.Point(3, 3);
			this.timeStampsDataGridView.Name = "timeStampsDataGridView";
			this.timeStampsDataGridView.ReadOnly = true;
			this.timeStampsDataGridView.RowTemplate.Height = 24;
			this.timeStampsDataGridView.Size = new System.Drawing.Size(517, 346);
			this.timeStampsDataGridView.TabIndex = 0;
			// 
			// timeStampButton
			// 
			this.timeStampButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.timeStampButton.Location = new System.Drawing.Point(3, 355);
			this.timeStampButton.Name = "timeStampButton";
			this.timeStampButton.Size = new System.Drawing.Size(255, 23);
			this.timeStampButton.TabIndex = 1;
			this.timeStampButton.Text = "add timestamp";
			this.timeStampButton.UseVisualStyleBackColor = true;
			this.timeStampButton.Click += new System.EventHandler(this.timeStampButton_Click);
			// 
			// closeButton
			// 
			this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.closeButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.closeButton.Location = new System.Drawing.Point(264, 355);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(256, 23);
			this.closeButton.TabIndex = 2;
			this.closeButton.Text = "close dialog";
			this.closeButton.UseVisualStyleBackColor = true;
			// 
			// timeStampColumn
			// 
			this.timeStampColumn.HeaderText = "timestamp";
			this.timeStampColumn.Name = "timeStampColumn";
			this.timeStampColumn.ReadOnly = true;
			this.timeStampColumn.Width = 97;
			// 
			// timeStampSpanColumn
			// 
			this.timeStampSpanColumn.HeaderText = "cumulated time";
			this.timeStampSpanColumn.Name = "timeStampSpanColumn";
			this.timeStampSpanColumn.ReadOnly = true;
			this.timeStampSpanColumn.Width = 117;
			// 
			// EmployeeDetailsForm
			// 
			this.AcceptButton = this.timeStampButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.closeButton;
			this.ClientSize = new System.Drawing.Size(523, 381);
			this.Controls.Add(this.rootLayoutPanel);
			this.Name = "EmployeeDetailsForm";
			this.ShowIcon = false;
			this.Text = "EmployeeDetailsForm";
			this.Load += new System.EventHandler(this.EmployeeDetailsForm_Load);
			this.rootLayoutPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.timeStampsDataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel rootLayoutPanel;
		private System.Windows.Forms.DataGridView timeStampsDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn timeStampColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn timeStampSpanColumn;
		private System.Windows.Forms.Button timeStampButton;
		private System.Windows.Forms.Button closeButton;
	}
}