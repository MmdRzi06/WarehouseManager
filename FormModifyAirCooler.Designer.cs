namespace WarehouseManager {
	partial class FormModifyAirCooler {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModifyAirCooler));
			lblError = new Label();
			btnCancel = new Button();
			btnConfirm = new Button();
			lblInstruction = new Label();
			tbxCoolerHeight = new TextBox();
			lblCoolerHeight = new Label();
			tbxMaxNoiseLevel = new TextBox();
			label1 = new Label();
			tbxFanSize = new TextBox();
			lblFanSize = new Label();
			tbxMaximumFanSpeed = new TextBox();
			lblMaximumFanSpeed = new Label();
			tbxMinimumFanSpeed = new TextBox();
			lblMinimumFanSpeed = new Label();
			lblAirCooler = new Label();
			panel = new Panel();
			SuspendLayout();
			// 
			// lblError
			// 
			lblError.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblError.ForeColor = Color.FromArgb(244, 43, 50);
			lblError.Location = new Point(107, 443);
			lblError.Name = "lblError";
			lblError.Size = new Size(406, 36);
			lblError.TabIndex = 75;
			lblError.Text = "\r\n";
			// 
			// btnCancel
			// 
			btnCancel.BackColor = Color.FromArgb(4, 41, 58);
			btnCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 41, 58);
			btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(6, 70, 99);
			btnCancel.FlatStyle = FlatStyle.Flat;
			btnCancel.ForeColor = Color.FromArgb(236, 179, 101);
			btnCancel.Location = new Point(519, 443);
			btnCancel.Margin = new Padding(3, 2, 3, 2);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(115, 38);
			btnCancel.TabIndex = 74;
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
			btnConfirm.Location = new Point(640, 443);
			btnConfirm.Margin = new Padding(3, 2, 3, 2);
			btnConfirm.Name = "btnConfirm";
			btnConfirm.Size = new Size(115, 38);
			btnConfirm.TabIndex = 73;
			btnConfirm.Text = "Confirm";
			btnConfirm.UseVisualStyleBackColor = false;
			btnConfirm.Click += btnConfirm_Click;
			// 
			// lblInstruction
			// 
			lblInstruction.AutoSize = true;
			lblInstruction.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblInstruction.ForeColor = Color.FromArgb(236, 179, 101);
			lblInstruction.Location = new Point(229, 9);
			lblInstruction.Name = "lblInstruction";
			lblInstruction.Size = new Size(308, 20);
			lblInstruction.TabIndex = 72;
			lblInstruction.Text = "Fill out the fields you would like to change.";
			// 
			// tbxCoolerHeight
			// 
			tbxCoolerHeight.BackColor = Color.FromArgb(4, 41, 58);
			tbxCoolerHeight.BorderStyle = BorderStyle.FixedSingle;
			tbxCoolerHeight.ForeColor = Color.FromArgb(236, 179, 101);
			tbxCoolerHeight.Location = new Point(60, 388);
			tbxCoolerHeight.Margin = new Padding(3, 2, 3, 2);
			tbxCoolerHeight.MaxLength = 7;
			tbxCoolerHeight.Name = "tbxCoolerHeight";
			tbxCoolerHeight.Size = new Size(69, 23);
			tbxCoolerHeight.TabIndex = 122;
			tbxCoolerHeight.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblCoolerHeight
			// 
			lblCoolerHeight.AutoSize = true;
			lblCoolerHeight.ForeColor = Color.FromArgb(236, 179, 101);
			lblCoolerHeight.Location = new Point(60, 362);
			lblCoolerHeight.Name = "lblCoolerHeight";
			lblCoolerHeight.Size = new Size(114, 15);
			lblCoolerHeight.TabIndex = 121;
			lblCoolerHeight.Text = "Cooler Height (mm)";
			// 
			// tbxMaxNoiseLevel
			// 
			tbxMaxNoiseLevel.BackColor = Color.FromArgb(4, 41, 58);
			tbxMaxNoiseLevel.BorderStyle = BorderStyle.FixedSingle;
			tbxMaxNoiseLevel.ForeColor = Color.FromArgb(236, 179, 101);
			tbxMaxNoiseLevel.Location = new Point(60, 309);
			tbxMaxNoiseLevel.Margin = new Padding(3, 2, 3, 2);
			tbxMaxNoiseLevel.MaxLength = 7;
			tbxMaxNoiseLevel.Name = "tbxMaxNoiseLevel";
			tbxMaxNoiseLevel.Size = new Size(69, 23);
			tbxMaxNoiseLevel.TabIndex = 120;
			tbxMaxNoiseLevel.KeyPress += DoubleTextBoxes_KeyPress;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.ForeColor = Color.FromArgb(236, 179, 101);
			label1.Location = new Point(60, 283);
			label1.Name = "label1";
			label1.Size = new Size(125, 15);
			label1.TabIndex = 119;
			label1.Text = "Max Noise Level (dBA)";
			// 
			// tbxFanSize
			// 
			tbxFanSize.BackColor = Color.FromArgb(4, 41, 58);
			tbxFanSize.BorderStyle = BorderStyle.FixedSingle;
			tbxFanSize.ForeColor = Color.FromArgb(236, 179, 101);
			tbxFanSize.Location = new Point(60, 237);
			tbxFanSize.Margin = new Padding(3, 2, 3, 2);
			tbxFanSize.MaxLength = 7;
			tbxFanSize.Name = "tbxFanSize";
			tbxFanSize.Size = new Size(69, 23);
			tbxFanSize.TabIndex = 118;
			tbxFanSize.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblFanSize
			// 
			lblFanSize.AutoSize = true;
			lblFanSize.ForeColor = Color.FromArgb(236, 179, 101);
			lblFanSize.Location = new Point(60, 211);
			lblFanSize.Name = "lblFanSize";
			lblFanSize.Size = new Size(82, 15);
			lblFanSize.TabIndex = 117;
			lblFanSize.Text = "Fan Size (mm)";
			// 
			// tbxMaximumFanSpeed
			// 
			tbxMaximumFanSpeed.BackColor = Color.FromArgb(4, 41, 58);
			tbxMaximumFanSpeed.BorderStyle = BorderStyle.FixedSingle;
			tbxMaximumFanSpeed.ForeColor = Color.FromArgb(236, 179, 101);
			tbxMaximumFanSpeed.Location = new Point(60, 158);
			tbxMaximumFanSpeed.Margin = new Padding(3, 2, 3, 2);
			tbxMaximumFanSpeed.MaxLength = 7;
			tbxMaximumFanSpeed.Name = "tbxMaximumFanSpeed";
			tbxMaximumFanSpeed.Size = new Size(69, 23);
			tbxMaximumFanSpeed.TabIndex = 116;
			tbxMaximumFanSpeed.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblMaximumFanSpeed
			// 
			lblMaximumFanSpeed.AutoSize = true;
			lblMaximumFanSpeed.ForeColor = Color.FromArgb(236, 179, 101);
			lblMaximumFanSpeed.Location = new Point(60, 132);
			lblMaximumFanSpeed.Name = "lblMaximumFanSpeed";
			lblMaximumFanSpeed.Size = new Size(154, 15);
			lblMaximumFanSpeed.TabIndex = 115;
			lblMaximumFanSpeed.Text = "Maximum Fan Speed (RPM)";
			// 
			// tbxMinimumFanSpeed
			// 
			tbxMinimumFanSpeed.BackColor = Color.FromArgb(4, 41, 58);
			tbxMinimumFanSpeed.BorderStyle = BorderStyle.FixedSingle;
			tbxMinimumFanSpeed.ForeColor = Color.FromArgb(236, 179, 101);
			tbxMinimumFanSpeed.Location = new Point(60, 82);
			tbxMinimumFanSpeed.Margin = new Padding(3, 2, 3, 2);
			tbxMinimumFanSpeed.MaxLength = 7;
			tbxMinimumFanSpeed.Name = "tbxMinimumFanSpeed";
			tbxMinimumFanSpeed.Size = new Size(69, 23);
			tbxMinimumFanSpeed.TabIndex = 114;
			tbxMinimumFanSpeed.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblMinimumFanSpeed
			// 
			lblMinimumFanSpeed.AutoSize = true;
			lblMinimumFanSpeed.ForeColor = Color.FromArgb(236, 179, 101);
			lblMinimumFanSpeed.Location = new Point(60, 56);
			lblMinimumFanSpeed.Name = "lblMinimumFanSpeed";
			lblMinimumFanSpeed.Size = new Size(153, 15);
			lblMinimumFanSpeed.TabIndex = 113;
			lblMinimumFanSpeed.Text = "Minimum Fan Speed (RPM)";
			// 
			// lblAirCooler
			// 
			lblAirCooler.AutoSize = true;
			lblAirCooler.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblAirCooler.ForeColor = Color.FromArgb(236, 179, 101);
			lblAirCooler.Location = new Point(12, 9);
			lblAirCooler.Name = "lblAirCooler";
			lblAirCooler.Size = new Size(86, 21);
			lblAirCooler.TabIndex = 123;
			lblAirCooler.Text = "Air Cooler";
			// 
			// panel
			// 
			panel.BackColor = Color.Transparent;
			panel.BorderStyle = BorderStyle.FixedSingle;
			panel.Dock = DockStyle.Fill;
			panel.Location = new Point(0, 0);
			panel.Name = "panel";
			panel.Padding = new Padding(1);
			panel.Size = new Size(767, 492);
			panel.TabIndex = 124;
			// 
			// FormModifyAirCooler
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(4, 28, 50);
			ClientSize = new Size(767, 492);
			Controls.Add(lblAirCooler);
			Controls.Add(tbxCoolerHeight);
			Controls.Add(lblCoolerHeight);
			Controls.Add(tbxMaxNoiseLevel);
			Controls.Add(label1);
			Controls.Add(tbxFanSize);
			Controls.Add(lblFanSize);
			Controls.Add(tbxMaximumFanSpeed);
			Controls.Add(lblMaximumFanSpeed);
			Controls.Add(tbxMinimumFanSpeed);
			Controls.Add(lblMinimumFanSpeed);
			Controls.Add(lblError);
			Controls.Add(btnCancel);
			Controls.Add(btnConfirm);
			Controls.Add(lblInstruction);
			Controls.Add(panel);
			FormBorderStyle = FormBorderStyle.None;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			Name = "FormModifyAirCooler";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Modify Air Cooler";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblError;
		private Button btnCancel;
		private Button btnConfirm;
		private Label lblInstruction;
		private TextBox tbxCoolerHeight;
		private Label lblCoolerHeight;
		private TextBox tbxMaxNoiseLevel;
		private Label label1;
		private TextBox tbxFanSize;
		private Label lblFanSize;
		private TextBox tbxMaximumFanSpeed;
		private Label lblMaximumFanSpeed;
		private TextBox tbxMinimumFanSpeed;
		private Label lblMinimumFanSpeed;
		private Label lblAirCooler;
		private Panel panel;
	}
}