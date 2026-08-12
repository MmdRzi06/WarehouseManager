namespace WarehouseManager {
	partial class FormModifyCase {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModifyCase));
			cbLSMFF = new ComboBox();
			cbFormFactor = new ComboBox();
			tbxMaximumCPUCoolerHeight = new TextBox();
			lblMaximumCPUCoolerHeight = new Label();
			tbxMaximumGPULength = new TextBox();
			lblMaximumGPULength = new Label();
			lblLSMFF = new Label();
			lblFormFactor = new Label();
			lblError = new Label();
			btnCancel = new Button();
			btnConfirm = new Button();
			lblInstruction = new Label();
			pbCrossClearFormFactor = new PictureBox();
			pbCrossClearLSMFF = new PictureBox();
			panel = new Panel();
			lblCase = new Label();
			((System.ComponentModel.ISupportInitialize)pbCrossClearFormFactor).BeginInit();
			((System.ComponentModel.ISupportInitialize)pbCrossClearLSMFF).BeginInit();
			panel.SuspendLayout();
			SuspendLayout();
			// 
			// cbLSMFF
			// 
			cbLSMFF.BackColor = Color.FromArgb(4, 41, 58);
			cbLSMFF.DropDownStyle = ComboBoxStyle.DropDownList;
			cbLSMFF.FlatStyle = FlatStyle.System;
			cbLSMFF.ForeColor = Color.FromArgb(236, 179, 101);
			cbLSMFF.FormattingEnabled = true;
			cbLSMFF.Items.AddRange(new object[] { "E-ATX", "ATX", "Micro-ATX", "Mini-ITX" });
			cbLSMFF.Location = new Point(60, 156);
			cbLSMFF.Margin = new Padding(3, 2, 3, 2);
			cbLSMFF.Name = "cbLSMFF";
			cbLSMFF.Size = new Size(120, 23);
			cbLSMFF.TabIndex = 27;
			// 
			// cbFormFactor
			// 
			cbFormFactor.BackColor = Color.FromArgb(4, 41, 58);
			cbFormFactor.DropDownStyle = ComboBoxStyle.DropDownList;
			cbFormFactor.ForeColor = Color.FromArgb(236, 179, 101);
			cbFormFactor.FormattingEnabled = true;
			cbFormFactor.Items.AddRange(new object[] { "Full Tower", "Mid Tower", "Mini Tower" });
			cbFormFactor.Location = new Point(60, 81);
			cbFormFactor.Margin = new Padding(3, 2, 3, 2);
			cbFormFactor.Name = "cbFormFactor";
			cbFormFactor.Size = new Size(120, 23);
			cbFormFactor.TabIndex = 26;
			// 
			// tbxMaximumCPUCoolerHeight
			// 
			tbxMaximumCPUCoolerHeight.BackColor = Color.FromArgb(4, 41, 58);
			tbxMaximumCPUCoolerHeight.BorderStyle = BorderStyle.FixedSingle;
			tbxMaximumCPUCoolerHeight.ForeColor = Color.FromArgb(236, 179, 101);
			tbxMaximumCPUCoolerHeight.Location = new Point(60, 309);
			tbxMaximumCPUCoolerHeight.Margin = new Padding(3, 2, 3, 2);
			tbxMaximumCPUCoolerHeight.MaxLength = 7;
			tbxMaximumCPUCoolerHeight.Name = "tbxMaximumCPUCoolerHeight";
			tbxMaximumCPUCoolerHeight.Size = new Size(69, 23);
			tbxMaximumCPUCoolerHeight.TabIndex = 25;
			tbxMaximumCPUCoolerHeight.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblMaximumCPUCoolerHeight
			// 
			lblMaximumCPUCoolerHeight.AutoSize = true;
			lblMaximumCPUCoolerHeight.ForeColor = Color.FromArgb(236, 179, 101);
			lblMaximumCPUCoolerHeight.Location = new Point(60, 283);
			lblMaximumCPUCoolerHeight.Name = "lblMaximumCPUCoolerHeight";
			lblMaximumCPUCoolerHeight.Size = new Size(197, 15);
			lblMaximumCPUCoolerHeight.TabIndex = 24;
			lblMaximumCPUCoolerHeight.Text = "Maximum CPU Cooler Height (mm)";
			// 
			// tbxMaximumGPULength
			// 
			tbxMaximumGPULength.BackColor = Color.FromArgb(4, 41, 58);
			tbxMaximumGPULength.BorderStyle = BorderStyle.FixedSingle;
			tbxMaximumGPULength.ForeColor = Color.FromArgb(236, 179, 101);
			tbxMaximumGPULength.Location = new Point(60, 233);
			tbxMaximumGPULength.Margin = new Padding(3, 2, 3, 2);
			tbxMaximumGPULength.MaxLength = 7;
			tbxMaximumGPULength.Name = "tbxMaximumGPULength";
			tbxMaximumGPULength.Size = new Size(69, 23);
			tbxMaximumGPULength.TabIndex = 23;
			tbxMaximumGPULength.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblMaximumGPULength
			// 
			lblMaximumGPULength.AutoSize = true;
			lblMaximumGPULength.ForeColor = Color.FromArgb(236, 179, 101);
			lblMaximumGPULength.Location = new Point(60, 207);
			lblMaximumGPULength.Name = "lblMaximumGPULength";
			lblMaximumGPULength.Size = new Size(160, 15);
			lblMaximumGPULength.TabIndex = 22;
			lblMaximumGPULength.Text = "Maximum GPU Length (mm)";
			// 
			// lblLSMFF
			// 
			lblLSMFF.AutoSize = true;
			lblLSMFF.ForeColor = Color.FromArgb(236, 179, 101);
			lblLSMFF.Location = new Point(60, 131);
			lblLSMFF.Name = "lblLSMFF";
			lblLSMFF.Size = new Size(243, 15);
			lblLSMFF.TabIndex = 21;
			lblLSMFF.Text = "Largest Supported Motherboard Form Factor";
			// 
			// lblFormFactor
			// 
			lblFormFactor.AutoSize = true;
			lblFormFactor.ForeColor = Color.FromArgb(236, 179, 101);
			lblFormFactor.Location = new Point(60, 56);
			lblFormFactor.Name = "lblFormFactor";
			lblFormFactor.Size = new Size(71, 15);
			lblFormFactor.TabIndex = 20;
			lblFormFactor.Text = "Form Factor";
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
			// pbCrossClearFormFactor
			// 
			pbCrossClearFormFactor.BackColor = Color.Transparent;
			pbCrossClearFormFactor.Cursor = Cursors.Hand;
			pbCrossClearFormFactor.Image = Properties.Resources.Cross_Red;
			pbCrossClearFormFactor.Location = new Point(31, 81);
			pbCrossClearFormFactor.Name = "pbCrossClearFormFactor";
			pbCrossClearFormFactor.Size = new Size(23, 23);
			pbCrossClearFormFactor.SizeMode = PictureBoxSizeMode.AutoSize;
			pbCrossClearFormFactor.TabIndex = 79;
			pbCrossClearFormFactor.TabStop = false;
			pbCrossClearFormFactor.Click += pbCrossClearFormFactor_Click;
			// 
			// pbCrossClearLSMFF
			// 
			pbCrossClearLSMFF.BackColor = Color.Transparent;
			pbCrossClearLSMFF.Cursor = Cursors.Hand;
			pbCrossClearLSMFF.Image = Properties.Resources.Cross_Red;
			pbCrossClearLSMFF.Location = new Point(31, 156);
			pbCrossClearLSMFF.Name = "pbCrossClearLSMFF";
			pbCrossClearLSMFF.Size = new Size(23, 23);
			pbCrossClearLSMFF.SizeMode = PictureBoxSizeMode.AutoSize;
			pbCrossClearLSMFF.TabIndex = 80;
			pbCrossClearLSMFF.TabStop = false;
			pbCrossClearLSMFF.Click += pbCrossClearLSMFF_Click;
			// 
			// panel
			// 
			panel.BackColor = Color.Transparent;
			panel.BorderStyle = BorderStyle.FixedSingle;
			panel.Controls.Add(lblCase);
			panel.Dock = DockStyle.Fill;
			panel.Location = new Point(0, 0);
			panel.Name = "panel";
			panel.Padding = new Padding(1);
			panel.Size = new Size(767, 492);
			panel.TabIndex = 90;
			// 
			// lblCase
			// 
			lblCase.AutoSize = true;
			lblCase.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblCase.ForeColor = Color.FromArgb(236, 179, 101);
			lblCase.Location = new Point(11, 8);
			lblCase.Name = "lblCase";
			lblCase.Size = new Size(45, 21);
			lblCase.TabIndex = 93;
			lblCase.Text = "Case";
			// 
			// FormModifyCase
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(4, 28, 50);
			ClientSize = new Size(767, 492);
			Controls.Add(pbCrossClearLSMFF);
			Controls.Add(pbCrossClearFormFactor);
			Controls.Add(lblError);
			Controls.Add(btnCancel);
			Controls.Add(btnConfirm);
			Controls.Add(lblInstruction);
			Controls.Add(cbLSMFF);
			Controls.Add(cbFormFactor);
			Controls.Add(tbxMaximumCPUCoolerHeight);
			Controls.Add(lblMaximumCPUCoolerHeight);
			Controls.Add(tbxMaximumGPULength);
			Controls.Add(lblMaximumGPULength);
			Controls.Add(lblLSMFF);
			Controls.Add(lblFormFactor);
			Controls.Add(panel);
			FormBorderStyle = FormBorderStyle.None;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			Name = "FormModifyCase";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Modify Case";
			((System.ComponentModel.ISupportInitialize)pbCrossClearFormFactor).EndInit();
			((System.ComponentModel.ISupportInitialize)pbCrossClearLSMFF).EndInit();
			panel.ResumeLayout(false);
			panel.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ComboBox cbLSMFF;
		private ComboBox cbFormFactor;
		private TextBox tbxMaximumCPUCoolerHeight;
		private Label lblMaximumCPUCoolerHeight;
		private TextBox tbxMaximumGPULength;
		private Label lblMaximumGPULength;
		private Label lblLSMFF;
		private Label lblFormFactor;
		private Label lblError;
		private Button btnCancel;
		private Button btnConfirm;
		private Label lblInstruction;
		private PictureBox pbCrossClearFormFactor;
		private PictureBox pbCrossClearLSMFF;
		private Panel panel;
		private Label lblCase;
	}
}