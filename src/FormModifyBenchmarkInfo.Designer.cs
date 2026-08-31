namespace WarehouseManager {
	partial class FormModifyBenchmarkInfo {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModifyBenchmarkInfo));
			tbxMaximumScore = new TextBox();
			lblMaximumScore = new Label();
			tbxAverageScore = new TextBox();
			lblAverageScore = new Label();
			tbxSource = new TextBox();
			lblSource = new Label();
			lblError = new Label();
			btnCancel = new Button();
			btnConfirm = new Button();
			lblInstruction = new Label();
			btnRemoveInfo = new Button();
			panel = new Panel();
			lblBenchmarkInfo = new Label();
			panel.SuspendLayout();
			SuspendLayout();
			// 
			// tbxMaximumScore
			// 
			tbxMaximumScore.BackColor = Color.FromArgb(4, 41, 58);
			tbxMaximumScore.BorderStyle = BorderStyle.FixedSingle;
			tbxMaximumScore.ForeColor = Color.FromArgb(236, 179, 101);
			tbxMaximumScore.Location = new Point(60, 257);
			tbxMaximumScore.Margin = new Padding(3, 2, 3, 2);
			tbxMaximumScore.MaxLength = 7;
			tbxMaximumScore.Name = "tbxMaximumScore";
			tbxMaximumScore.Size = new Size(69, 23);
			tbxMaximumScore.TabIndex = 30;
			tbxMaximumScore.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblMaximumScore
			// 
			lblMaximumScore.AutoSize = true;
			lblMaximumScore.ForeColor = Color.FromArgb(236, 179, 101);
			lblMaximumScore.Location = new Point(60, 231);
			lblMaximumScore.Name = "lblMaximumScore";
			lblMaximumScore.Size = new Size(93, 15);
			lblMaximumScore.TabIndex = 29;
			lblMaximumScore.Text = "Maximum Score";
			// 
			// tbxAverageScore
			// 
			tbxAverageScore.BackColor = Color.FromArgb(4, 41, 58);
			tbxAverageScore.BorderStyle = BorderStyle.FixedSingle;
			tbxAverageScore.ForeColor = Color.FromArgb(236, 179, 101);
			tbxAverageScore.Location = new Point(60, 181);
			tbxAverageScore.Margin = new Padding(3, 2, 3, 2);
			tbxAverageScore.MaxLength = 7;
			tbxAverageScore.Name = "tbxAverageScore";
			tbxAverageScore.Size = new Size(69, 23);
			tbxAverageScore.TabIndex = 28;
			tbxAverageScore.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblAverageScore
			// 
			lblAverageScore.AutoSize = true;
			lblAverageScore.ForeColor = Color.FromArgb(236, 179, 101);
			lblAverageScore.Location = new Point(60, 155);
			lblAverageScore.Name = "lblAverageScore";
			lblAverageScore.Size = new Size(36, 15);
			lblAverageScore.TabIndex = 27;
			lblAverageScore.Text = "Score";
			// 
			// tbxSource
			// 
			tbxSource.BackColor = Color.FromArgb(4, 41, 58);
			tbxSource.BorderStyle = BorderStyle.FixedSingle;
			tbxSource.ForeColor = Color.FromArgb(236, 179, 101);
			tbxSource.Location = new Point(60, 103);
			tbxSource.Margin = new Padding(3, 2, 3, 2);
			tbxSource.MaxLength = 32;
			tbxSource.Name = "tbxSource";
			tbxSource.Size = new Size(192, 23);
			tbxSource.TabIndex = 26;
			tbxSource.KeyPress += StringTextBoxes_KeyPress;
			// 
			// lblSource
			// 
			lblSource.AutoSize = true;
			lblSource.ForeColor = Color.FromArgb(236, 179, 101);
			lblSource.Location = new Point(60, 77);
			lblSource.Name = "lblSource";
			lblSource.Size = new Size(43, 15);
			lblSource.TabIndex = 25;
			lblSource.Text = "Source";
			// 
			// lblError
			// 
			lblError.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblError.ForeColor = Color.FromArgb(244, 43, 50);
			lblError.Location = new Point(25, 401);
			lblError.Name = "lblError";
			lblError.Size = new Size(406, 36);
			lblError.TabIndex = 57;
			lblError.Text = "\r\n";
			// 
			// btnCancel
			// 
			btnCancel.BackColor = Color.FromArgb(4, 41, 58);
			btnCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 41, 58);
			btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(6, 70, 99);
			btnCancel.FlatStyle = FlatStyle.Flat;
			btnCancel.ForeColor = Color.FromArgb(236, 179, 101);
			btnCancel.Location = new Point(437, 401);
			btnCancel.Margin = new Padding(3, 2, 3, 2);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(115, 38);
			btnCancel.TabIndex = 56;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = false;
			btnCancel.Click += btnCancel_Click;
			// 
			// btnConfirm
			// 
			btnConfirm.BackColor = Color.FromArgb(4, 41, 58);
			btnConfirm.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 41, 58);
			btnConfirm.FlatAppearance.MouseOverBackColor = Color.FromArgb(6, 70, 99);
			btnConfirm.FlatStyle = FlatStyle.Flat;
			btnConfirm.ForeColor = Color.FromArgb(236, 179, 101);
			btnConfirm.Location = new Point(558, 401);
			btnConfirm.Margin = new Padding(3, 2, 3, 2);
			btnConfirm.Name = "btnConfirm";
			btnConfirm.Size = new Size(115, 38);
			btnConfirm.TabIndex = 55;
			btnConfirm.Text = "Confirm";
			btnConfirm.UseVisualStyleBackColor = false;
			btnConfirm.Click += btnConfirm_Click;
			// 
			// lblInstruction
			// 
			lblInstruction.AutoSize = true;
			lblInstruction.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblInstruction.ForeColor = Color.FromArgb(236, 179, 101);
			lblInstruction.Location = new Point(188, 9);
			lblInstruction.Name = "lblInstruction";
			lblInstruction.Size = new Size(308, 20);
			lblInstruction.TabIndex = 59;
			lblInstruction.Text = "Fill out the fields you would like to change.";
			// 
			// btnRemoveInfo
			// 
			btnRemoveInfo.BackColor = Color.FromArgb(244, 43, 50);
			btnRemoveInfo.FlatAppearance.MouseDownBackColor = Color.FromArgb(244, 43, 50);
			btnRemoveInfo.FlatStyle = FlatStyle.Flat;
			btnRemoveInfo.ForeColor = Color.FromArgb(236, 179, 101);
			btnRemoveInfo.Location = new Point(60, 326);
			btnRemoveInfo.Margin = new Padding(3, 2, 3, 2);
			btnRemoveInfo.Name = "btnRemoveInfo";
			btnRemoveInfo.Size = new Size(115, 38);
			btnRemoveInfo.TabIndex = 60;
			btnRemoveInfo.Text = "Remove Info";
			btnRemoveInfo.UseVisualStyleBackColor = false;
			btnRemoveInfo.Click += btnRemoveInfo_Click;
			// 
			// panel
			// 
			panel.BackColor = Color.Transparent;
			panel.BorderStyle = BorderStyle.FixedSingle;
			panel.Controls.Add(lblBenchmarkInfo);
			panel.Dock = DockStyle.Fill;
			panel.Location = new Point(0, 0);
			panel.Name = "panel";
			panel.Padding = new Padding(1);
			panel.Size = new Size(685, 450);
			panel.TabIndex = 100;
			// 
			// lblBenchmarkInfo
			// 
			lblBenchmarkInfo.AutoSize = true;
			lblBenchmarkInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblBenchmarkInfo.ForeColor = Color.FromArgb(236, 179, 101);
			lblBenchmarkInfo.Location = new Point(11, 8);
			lblBenchmarkInfo.Name = "lblBenchmarkInfo";
			lblBenchmarkInfo.Size = new Size(131, 21);
			lblBenchmarkInfo.TabIndex = 102;
			lblBenchmarkInfo.Text = "Benchmark Info";
			// 
			// FormModifyBenchmarkInfo
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(4, 28, 50);
			ClientSize = new Size(685, 450);
			Controls.Add(btnRemoveInfo);
			Controls.Add(lblInstruction);
			Controls.Add(tbxMaximumScore);
			Controls.Add(lblError);
			Controls.Add(lblMaximumScore);
			Controls.Add(btnCancel);
			Controls.Add(tbxAverageScore);
			Controls.Add(btnConfirm);
			Controls.Add(lblAverageScore);
			Controls.Add(tbxSource);
			Controls.Add(lblSource);
			Controls.Add(panel);
			FormBorderStyle = FormBorderStyle.None;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			Name = "FormModifyBenchmarkInfo";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Modify Benchmark Info";
			panel.ResumeLayout(false);
			panel.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private TextBox tbxMaximumScore;
		private Label lblMaximumScore;
		private TextBox tbxAverageScore;
		private Label lblAverageScore;
		private TextBox tbxSource;
		private Label lblSource;
		private Label lblError;
		private Button btnCancel;
		private Button btnConfirm;
		private Label lblInstruction;
		private Button btnRemoveInfo;
		private Panel panel;
		private Label lblBenchmarkInfo;
	}
}