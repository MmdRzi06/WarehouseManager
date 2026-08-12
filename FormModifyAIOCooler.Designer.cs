namespace WarehouseManager {
	partial class FormModifyAIOCooler {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModifyAIOCooler));
			lblError = new Label();
			btnCancel = new Button();
			btnConfirm = new Button();
			lblInstruction = new Label();
			tbxRadiatorSize = new TextBox();
			lblRadiatorSize = new Label();
			tbxMaxNoiseLevel = new TextBox();
			label1 = new Label();
			tbxFanSize = new TextBox();
			lblFanSize = new Label();
			tbxMaximumFanSpeed = new TextBox();
			lblMaximumFanSpeed = new Label();
			tbxMinimumFanSpeed = new TextBox();
			lblMinimumFanSpeed = new Label();
			lblAIOCooler = new Label();
			panel = new Panel();
			label3 = new Label();
			panel.SuspendLayout();
			SuspendLayout();
			// 
			// lblError
			// 
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
			// tbxRadiatorSize
			// 
			tbxRadiatorSize.BackColor = Color.FromArgb(4, 41, 58);
			tbxRadiatorSize.BorderStyle = BorderStyle.FixedSingle;
			tbxRadiatorSize.ForeColor = Color.FromArgb(236, 179, 101);
			tbxRadiatorSize.Location = new Point(60, 388);
			tbxRadiatorSize.Margin = new Padding(3, 2, 3, 2);
			tbxRadiatorSize.MaxLength = 7;
			tbxRadiatorSize.Name = "tbxRadiatorSize";
			tbxRadiatorSize.Size = new Size(69, 23);
			tbxRadiatorSize.TabIndex = 97;
			tbxRadiatorSize.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblRadiatorSize
			// 
			lblRadiatorSize.AutoSize = true;
			lblRadiatorSize.ForeColor = Color.FromArgb(236, 179, 101);
			lblRadiatorSize.Location = new Point(60, 362);
			lblRadiatorSize.Name = "lblRadiatorSize";
			lblRadiatorSize.Size = new Size(107, 15);
			lblRadiatorSize.TabIndex = 96;
			lblRadiatorSize.Text = "Radiator Size (mm)";
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
			tbxMaxNoiseLevel.TabIndex = 95;
			tbxMaxNoiseLevel.KeyPress += DoubleTextBoxes_KeyPress;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.ForeColor = Color.FromArgb(236, 179, 101);
			label1.Location = new Point(60, 283);
			label1.Name = "label1";
			label1.Size = new Size(125, 15);
			label1.TabIndex = 94;
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
			tbxFanSize.TabIndex = 93;
			tbxFanSize.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblFanSize
			// 
			lblFanSize.AutoSize = true;
			lblFanSize.ForeColor = Color.FromArgb(236, 179, 101);
			lblFanSize.Location = new Point(60, 211);
			lblFanSize.Name = "lblFanSize";
			lblFanSize.Size = new Size(82, 15);
			lblFanSize.TabIndex = 92;
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
			tbxMaximumFanSpeed.TabIndex = 91;
			tbxMaximumFanSpeed.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblMaximumFanSpeed
			// 
			lblMaximumFanSpeed.AutoSize = true;
			lblMaximumFanSpeed.ForeColor = Color.FromArgb(236, 179, 101);
			lblMaximumFanSpeed.Location = new Point(60, 132);
			lblMaximumFanSpeed.Name = "lblMaximumFanSpeed";
			lblMaximumFanSpeed.Size = new Size(154, 15);
			lblMaximumFanSpeed.TabIndex = 90;
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
			tbxMinimumFanSpeed.TabIndex = 89;
			tbxMinimumFanSpeed.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblMinimumFanSpeed
			// 
			lblMinimumFanSpeed.AutoSize = true;
			lblMinimumFanSpeed.ForeColor = Color.FromArgb(236, 179, 101);
			lblMinimumFanSpeed.Location = new Point(60, 56);
			lblMinimumFanSpeed.Name = "lblMinimumFanSpeed";
			lblMinimumFanSpeed.Size = new Size(153, 15);
			lblMinimumFanSpeed.TabIndex = 88;
			lblMinimumFanSpeed.Text = "Minimum Fan Speed (RPM)";
			// 
			// lblAIOCooler
			// 
			lblAIOCooler.AutoSize = true;
			lblAIOCooler.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblAIOCooler.ForeColor = Color.FromArgb(236, 179, 101);
			lblAIOCooler.Location = new Point(12, 9);
			lblAIOCooler.Name = "lblAIOCooler";
			lblAIOCooler.Size = new Size(92, 21);
			lblAIOCooler.TabIndex = 98;
			lblAIOCooler.Text = "AIO Cooler";
			// 
			// panel
			// 
			panel.BackColor = Color.Transparent;
			panel.BorderStyle = BorderStyle.FixedSingle;
			panel.Controls.Add(label3);
			panel.Dock = DockStyle.Fill;
			panel.Location = new Point(0, 0);
			panel.Name = "panel";
			panel.Padding = new Padding(1);
			panel.Size = new Size(767, 492);
			panel.TabIndex = 99;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.ForeColor = Color.FromArgb(236, 179, 101);
			label3.Location = new Point(12, 9);
			label3.Name = "label3";
			label3.Size = new Size(92, 21);
			label3.TabIndex = 92;
			label3.Text = "AIO Cooler";
			// 
			// FormModifyAIOCooler
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(4, 28, 50);
			ClientSize = new Size(767, 492);
			Controls.Add(lblAIOCooler);
			Controls.Add(tbxRadiatorSize);
			Controls.Add(lblRadiatorSize);
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
			Name = "FormModifyAIOCooler";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Modify AIO Cooler";
			panel.ResumeLayout(false);
			panel.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblError;
		private Button btnCancel;
		private Button btnConfirm;
		private Label lblInstruction;
		private TextBox tbxRadiatorSize;
		private Label lblRadiatorSize;
		private TextBox tbxMaxNoiseLevel;
		private Label label1;
		private TextBox tbxFanSize;
		private Label lblFanSize;
		private TextBox tbxMaximumFanSpeed;
		private Label lblMaximumFanSpeed;
		private TextBox tbxMinimumFanSpeed;
		private Label lblMinimumFanSpeed;
		private Label lblAIOCooler;
		private Panel panel;
		private Label label3;
	}
}