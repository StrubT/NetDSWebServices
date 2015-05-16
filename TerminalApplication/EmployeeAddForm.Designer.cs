namespace BFH.NetDS.WebServices.Terminal {
	partial class EmployeeAddForm {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeAddForm));
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.loginLabel = new System.Windows.Forms.Label();
			this.nameLabel = new System.Windows.Forms.Label();
			this.loginTextBox = new System.Windows.Forms.TextBox();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.addButton = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.loginLabel, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.nameLabel, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.loginTextBox, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.nameTextBox, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.addButton, 1, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 94);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// loginLabel
			// 
			this.loginLabel.AutoSize = true;
			this.loginLabel.Dock = System.Windows.Forms.DockStyle.Left;
			this.loginLabel.Location = new System.Drawing.Point(3, 0);
			this.loginLabel.Name = "loginLabel";
			this.loginLabel.Size = new System.Drawing.Size(32, 26);
			this.loginLabel.TabIndex = 0;
			this.loginLabel.Text = "login:";
			this.loginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Dock = System.Windows.Forms.DockStyle.Left;
			this.nameLabel.Location = new System.Drawing.Point(3, 26);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(36, 26);
			this.nameLabel.TabIndex = 1;
			this.nameLabel.Text = "name:";
			this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// loginTextBox
			// 
			this.loginTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.loginTextBox.Location = new System.Drawing.Point(45, 3);
			this.loginTextBox.Name = "loginTextBox";
			this.loginTextBox.Size = new System.Drawing.Size(236, 20);
			this.loginTextBox.TabIndex = 2;
			// 
			// nameTextBox
			// 
			this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.nameTextBox.Location = new System.Drawing.Point(45, 29);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(236, 20);
			this.nameTextBox.TabIndex = 3;
			// 
			// addButton
			// 
			this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.addButton.AutoSize = true;
			this.addButton.Location = new System.Drawing.Point(198, 55);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(83, 23);
			this.addButton.TabIndex = 4;
			this.addButton.Text = "add employee";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// EmployeeAddForm
			// 
			this.AcceptButton = this.addButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 94);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "EmployeeAddForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "NetDS - Web Services - Add Employee";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label loginLabel;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.TextBox loginTextBox;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.Button addButton;
	}
}