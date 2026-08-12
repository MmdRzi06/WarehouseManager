namespace WarehouseManager {
	partial class FormModifyMotherboard {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModifyMotherboard));
			cbWiFi = new ComboBox();
			tbxNumberOfM2Slots = new TextBox();
			lblNumberOfM2Slots = new Label();
			cbMemoryType = new ComboBox();
			lblMemoryType = new Label();
			cbFormFactor = new ComboBox();
			lblFormFactor = new Label();
			cbCPUOverclocking = new ComboBox();
			tbxMaximumSupportedMemoryCapacity = new TextBox();
			lblMaximumSupportedMemoryCapacity = new Label();
			tbxNumberOfSataPorts = new TextBox();
			lblNumberOfSataPorts = new Label();
			lblCPUOverclocking = new Label();
			lblWiFi = new Label();
			tbxNumberOfPCIeSlots = new TextBox();
			lblNumberOfPCIeSlots = new Label();
			lblNumberOfMemorySlots = new Label();
			tbxNumberOfMemorySlots = new TextBox();
			tbxChipset = new TextBox();
			lblChipset = new Label();
			tbxSocketType = new TextBox();
			lblSocketType = new Label();
			lblError = new Label();
			btnCancel = new Button();
			btnConfirm = new Button();
			lblInstruction = new Label();
			lblMotherboard = new Label();
			pbCrossClearFormFactor = new PictureBox();
			pbCrossClearMemoryType = new PictureBox();
			pbCrossClearWiFi = new PictureBox();
			pbCrossClearAllowsCPUOverclocking = new PictureBox();
			panel = new Panel();
			lblCase = new Label();
			((System.ComponentModel.ISupportInitialize)pbCrossClearFormFactor).BeginInit();
			((System.ComponentModel.ISupportInitialize)pbCrossClearMemoryType).BeginInit();
			((System.ComponentModel.ISupportInitialize)pbCrossClearWiFi).BeginInit();
			((System.ComponentModel.ISupportInitialize)pbCrossClearAllowsCPUOverclocking).BeginInit();
			panel.SuspendLayout();
			SuspendLayout();
			// 
			// cbWiFi
			// 
			cbWiFi.BackColor = Color.FromArgb(4, 41, 58);
			cbWiFi.DropDownStyle = ComboBoxStyle.DropDownList;
			cbWiFi.ForeColor = Color.FromArgb(236, 179, 101);
			cbWiFi.FormattingEnabled = true;
			cbWiFi.Items.AddRange(new object[] { "Yes", "No" });
			cbWiFi.Location = new Point(338, 388);
			cbWiFi.Margin = new Padding(3, 2, 3, 2);
			cbWiFi.Name = "cbWiFi";
			cbWiFi.Size = new Size(120, 23);
			cbWiFi.TabIndex = 112;
			// 
			// tbxNumberOfM2Slots
			// 
			tbxNumberOfM2Slots.BackColor = Color.FromArgb(4, 41, 58);
			tbxNumberOfM2Slots.BorderStyle = BorderStyle.FixedSingle;
			tbxNumberOfM2Slots.ForeColor = Color.FromArgb(236, 179, 101);
			tbxNumberOfM2Slots.Location = new Point(338, 82);
			tbxNumberOfM2Slots.Margin = new Padding(3, 2, 3, 2);
			tbxNumberOfM2Slots.MaxLength = 7;
			tbxNumberOfM2Slots.Name = "tbxNumberOfM2Slots";
			tbxNumberOfM2Slots.Size = new Size(69, 23);
			tbxNumberOfM2Slots.TabIndex = 111;
			tbxNumberOfM2Slots.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblNumberOfM2Slots
			// 
			lblNumberOfM2Slots.AutoSize = true;
			lblNumberOfM2Slots.ForeColor = Color.FromArgb(236, 179, 101);
			lblNumberOfM2Slots.Location = new Point(338, 56);
			lblNumberOfM2Slots.Name = "lblNumberOfM2Slots";
			lblNumberOfM2Slots.Size = new Size(118, 15);
			lblNumberOfM2Slots.TabIndex = 110;
			lblNumberOfM2Slots.Text = "Number Of M.2 Slots";
			// 
			// cbMemoryType
			// 
			cbMemoryType.BackColor = Color.FromArgb(4, 41, 58);
			cbMemoryType.DropDownStyle = ComboBoxStyle.DropDownList;
			cbMemoryType.ForeColor = Color.FromArgb(236, 179, 101);
			cbMemoryType.FormattingEnabled = true;
			cbMemoryType.Items.AddRange(new object[] { "DDR3", "DDR4", "DDR5" });
			cbMemoryType.Location = new Point(60, 309);
			cbMemoryType.Margin = new Padding(3, 2, 3, 2);
			cbMemoryType.Name = "cbMemoryType";
			cbMemoryType.Size = new Size(120, 23);
			cbMemoryType.TabIndex = 109;
			// 
			// lblMemoryType
			// 
			lblMemoryType.AutoSize = true;
			lblMemoryType.ForeColor = Color.FromArgb(236, 179, 101);
			lblMemoryType.Location = new Point(60, 283);
			lblMemoryType.Name = "lblMemoryType";
			lblMemoryType.Size = new Size(80, 15);
			lblMemoryType.TabIndex = 108;
			lblMemoryType.Text = "Memory Type";
			// 
			// cbFormFactor
			// 
			cbFormFactor.BackColor = Color.FromArgb(4, 41, 58);
			cbFormFactor.DropDownStyle = ComboBoxStyle.DropDownList;
			cbFormFactor.ForeColor = Color.FromArgb(236, 179, 101);
			cbFormFactor.FormattingEnabled = true;
			cbFormFactor.Items.AddRange(new object[] { "E-ATX", "ATX", "Micro-ATX", "Mini-ITX" });
			cbFormFactor.Location = new Point(60, 233);
			cbFormFactor.Margin = new Padding(3, 2, 3, 2);
			cbFormFactor.Name = "cbFormFactor";
			cbFormFactor.Size = new Size(120, 23);
			cbFormFactor.TabIndex = 107;
			// 
			// lblFormFactor
			// 
			lblFormFactor.AutoSize = true;
			lblFormFactor.ForeColor = Color.FromArgb(236, 179, 101);
			lblFormFactor.Location = new Point(60, 207);
			lblFormFactor.Name = "lblFormFactor";
			lblFormFactor.Size = new Size(71, 15);
			lblFormFactor.TabIndex = 106;
			lblFormFactor.Text = "Form Factor";
			// 
			// cbCPUOverclocking
			// 
			cbCPUOverclocking.BackColor = Color.FromArgb(4, 41, 58);
			cbCPUOverclocking.DropDownStyle = ComboBoxStyle.DropDownList;
			cbCPUOverclocking.ForeColor = Color.FromArgb(236, 179, 101);
			cbCPUOverclocking.FormattingEnabled = true;
			cbCPUOverclocking.Items.AddRange(new object[] { "Yes", "No" });
			cbCPUOverclocking.Location = new Point(500, 82);
			cbCPUOverclocking.Margin = new Padding(3, 2, 3, 2);
			cbCPUOverclocking.Name = "cbCPUOverclocking";
			cbCPUOverclocking.Size = new Size(120, 23);
			cbCPUOverclocking.TabIndex = 105;
			// 
			// tbxMaximumSupportedMemoryCapacity
			// 
			tbxMaximumSupportedMemoryCapacity.BackColor = Color.FromArgb(4, 41, 58);
			tbxMaximumSupportedMemoryCapacity.BorderStyle = BorderStyle.FixedSingle;
			tbxMaximumSupportedMemoryCapacity.ForeColor = Color.FromArgb(236, 179, 101);
			tbxMaximumSupportedMemoryCapacity.Location = new Point(338, 233);
			tbxMaximumSupportedMemoryCapacity.Margin = new Padding(3, 2, 3, 2);
			tbxMaximumSupportedMemoryCapacity.MaxLength = 7;
			tbxMaximumSupportedMemoryCapacity.Name = "tbxMaximumSupportedMemoryCapacity";
			tbxMaximumSupportedMemoryCapacity.Size = new Size(69, 23);
			tbxMaximumSupportedMemoryCapacity.TabIndex = 103;
			tbxMaximumSupportedMemoryCapacity.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblMaximumSupportedMemoryCapacity
			// 
			lblMaximumSupportedMemoryCapacity.AutoSize = true;
			lblMaximumSupportedMemoryCapacity.ForeColor = Color.FromArgb(236, 179, 101);
			lblMaximumSupportedMemoryCapacity.Location = new Point(338, 207);
			lblMaximumSupportedMemoryCapacity.Name = "lblMaximumSupportedMemoryCapacity";
			lblMaximumSupportedMemoryCapacity.Size = new Size(242, 15);
			lblMaximumSupportedMemoryCapacity.TabIndex = 102;
			lblMaximumSupportedMemoryCapacity.Text = "Maximum Supported Memory Capacity (GB)";
			// 
			// tbxNumberOfSataPorts
			// 
			tbxNumberOfSataPorts.BackColor = Color.FromArgb(4, 41, 58);
			tbxNumberOfSataPorts.BorderStyle = BorderStyle.FixedSingle;
			tbxNumberOfSataPorts.ForeColor = Color.FromArgb(236, 179, 101);
			tbxNumberOfSataPorts.Location = new Point(338, 309);
			tbxNumberOfSataPorts.Margin = new Padding(3, 2, 3, 2);
			tbxNumberOfSataPorts.MaxLength = 7;
			tbxNumberOfSataPorts.Name = "tbxNumberOfSataPorts";
			tbxNumberOfSataPorts.Size = new Size(69, 23);
			tbxNumberOfSataPorts.TabIndex = 101;
			tbxNumberOfSataPorts.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblNumberOfSataPorts
			// 
			lblNumberOfSataPorts.AutoSize = true;
			lblNumberOfSataPorts.ForeColor = Color.FromArgb(236, 179, 101);
			lblNumberOfSataPorts.Location = new Point(338, 283);
			lblNumberOfSataPorts.Name = "lblNumberOfSataPorts";
			lblNumberOfSataPorts.Size = new Size(122, 15);
			lblNumberOfSataPorts.TabIndex = 100;
			lblNumberOfSataPorts.Text = "Number Of Sata Ports";
			// 
			// lblCPUOverclocking
			// 
			lblCPUOverclocking.AutoSize = true;
			lblCPUOverclocking.ForeColor = Color.FromArgb(236, 179, 101);
			lblCPUOverclocking.Location = new Point(500, 56);
			lblCPUOverclocking.Name = "lblCPUOverclocking";
			lblCPUOverclocking.Size = new Size(141, 15);
			lblCPUOverclocking.TabIndex = 104;
			lblCPUOverclocking.Text = "Allows CPU Overclocking";
			// 
			// lblWiFi
			// 
			lblWiFi.AutoSize = true;
			lblWiFi.ForeColor = Color.FromArgb(236, 179, 101);
			lblWiFi.Location = new Point(338, 362);
			lblWiFi.Name = "lblWiFi";
			lblWiFi.Size = new Size(82, 15);
			lblWiFi.TabIndex = 99;
			lblWiFi.Text = "Includes Wi-Fi";
			// 
			// tbxNumberOfPCIeSlots
			// 
			tbxNumberOfPCIeSlots.BackColor = Color.FromArgb(4, 41, 58);
			tbxNumberOfPCIeSlots.BorderStyle = BorderStyle.FixedSingle;
			tbxNumberOfPCIeSlots.ForeColor = Color.FromArgb(236, 179, 101);
			tbxNumberOfPCIeSlots.Location = new Point(60, 388);
			tbxNumberOfPCIeSlots.Margin = new Padding(3, 2, 3, 2);
			tbxNumberOfPCIeSlots.MaxLength = 7;
			tbxNumberOfPCIeSlots.Name = "tbxNumberOfPCIeSlots";
			tbxNumberOfPCIeSlots.Size = new Size(69, 23);
			tbxNumberOfPCIeSlots.TabIndex = 98;
			tbxNumberOfPCIeSlots.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblNumberOfPCIeSlots
			// 
			lblNumberOfPCIeSlots.AutoSize = true;
			lblNumberOfPCIeSlots.ForeColor = Color.FromArgb(236, 179, 101);
			lblNumberOfPCIeSlots.Location = new Point(60, 362);
			lblNumberOfPCIeSlots.Name = "lblNumberOfPCIeSlots";
			lblNumberOfPCIeSlots.Size = new Size(122, 15);
			lblNumberOfPCIeSlots.TabIndex = 97;
			lblNumberOfPCIeSlots.Text = "Number Of PCIe Slots";
			// 
			// lblNumberOfMemorySlots
			// 
			lblNumberOfMemorySlots.AutoSize = true;
			lblNumberOfMemorySlots.ForeColor = Color.FromArgb(236, 179, 101);
			lblNumberOfMemorySlots.Location = new Point(338, 131);
			lblNumberOfMemorySlots.Name = "lblNumberOfMemorySlots";
			lblNumberOfMemorySlots.Size = new Size(143, 15);
			lblNumberOfMemorySlots.TabIndex = 95;
			lblNumberOfMemorySlots.Text = "Number Of Memory Slots";
			// 
			// tbxNumberOfMemorySlots
			// 
			tbxNumberOfMemorySlots.BackColor = Color.FromArgb(4, 41, 58);
			tbxNumberOfMemorySlots.BorderStyle = BorderStyle.FixedSingle;
			tbxNumberOfMemorySlots.ForeColor = Color.FromArgb(236, 179, 101);
			tbxNumberOfMemorySlots.Location = new Point(338, 157);
			tbxNumberOfMemorySlots.Margin = new Padding(3, 2, 3, 2);
			tbxNumberOfMemorySlots.MaxLength = 7;
			tbxNumberOfMemorySlots.Name = "tbxNumberOfMemorySlots";
			tbxNumberOfMemorySlots.Size = new Size(69, 23);
			tbxNumberOfMemorySlots.TabIndex = 96;
			tbxNumberOfMemorySlots.KeyPress += IntTextBoxes_KeyPress;
			// 
			// tbxChipset
			// 
			tbxChipset.BackColor = Color.FromArgb(4, 41, 58);
			tbxChipset.BorderStyle = BorderStyle.FixedSingle;
			tbxChipset.ForeColor = Color.FromArgb(236, 179, 101);
			tbxChipset.Location = new Point(60, 157);
			tbxChipset.Margin = new Padding(3, 2, 3, 2);
			tbxChipset.MaxLength = 20;
			tbxChipset.Name = "tbxChipset";
			tbxChipset.Size = new Size(214, 23);
			tbxChipset.TabIndex = 94;
			tbxChipset.KeyPress += StringTextBoxes_KeyPress;
			// 
			// lblChipset
			// 
			lblChipset.AutoSize = true;
			lblChipset.ForeColor = Color.FromArgb(236, 179, 101);
			lblChipset.Location = new Point(60, 131);
			lblChipset.Name = "lblChipset";
			lblChipset.Size = new Size(47, 15);
			lblChipset.TabIndex = 93;
			lblChipset.Text = "Chipset";
			// 
			// tbxSocketType
			// 
			tbxSocketType.BackColor = Color.FromArgb(4, 41, 58);
			tbxSocketType.BorderStyle = BorderStyle.FixedSingle;
			tbxSocketType.ForeColor = Color.FromArgb(236, 179, 101);
			tbxSocketType.Location = new Point(60, 82);
			tbxSocketType.Margin = new Padding(3, 2, 3, 2);
			tbxSocketType.MaxLength = 20;
			tbxSocketType.Name = "tbxSocketType";
			tbxSocketType.Size = new Size(214, 23);
			tbxSocketType.TabIndex = 92;
			tbxSocketType.KeyPress += StringTextBoxes_KeyPress;
			// 
			// lblSocketType
			// 
			lblSocketType.AutoSize = true;
			lblSocketType.ForeColor = Color.FromArgb(236, 179, 101);
			lblSocketType.Location = new Point(60, 56);
			lblSocketType.Name = "lblSocketType";
			lblSocketType.Size = new Size(70, 15);
			lblSocketType.TabIndex = 91;
			lblSocketType.Text = "Socket Type";
			// 
			// lblError
			// 
			lblError.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblError.ForeColor = Color.FromArgb(244, 43, 50);
			lblError.Location = new Point(107, 443);
			lblError.Name = "lblError";
			lblError.Size = new Size(406, 36);
			lblError.TabIndex = 116;
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
			btnCancel.TabIndex = 115;
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
			btnConfirm.TabIndex = 114;
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
			lblInstruction.TabIndex = 113;
			lblInstruction.Text = "Fill out the fields you would like to change.";
			// 
			// lblMotherboard
			// 
			lblMotherboard.AutoSize = true;
			lblMotherboard.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblMotherboard.ForeColor = Color.FromArgb(236, 179, 101);
			lblMotherboard.Location = new Point(12, 9);
			lblMotherboard.Name = "lblMotherboard";
			lblMotherboard.Size = new Size(111, 21);
			lblMotherboard.TabIndex = 121;
			lblMotherboard.Text = "Motherboard";
			// 
			// pbCrossClearFormFactor
			// 
			pbCrossClearFormFactor.BackColor = Color.Transparent;
			pbCrossClearFormFactor.Cursor = Cursors.Hand;
			pbCrossClearFormFactor.Image = Properties.Resources.Cross_Red;
			pbCrossClearFormFactor.Location = new Point(31, 233);
			pbCrossClearFormFactor.Name = "pbCrossClearFormFactor";
			pbCrossClearFormFactor.Size = new Size(23, 23);
			pbCrossClearFormFactor.SizeMode = PictureBoxSizeMode.AutoSize;
			pbCrossClearFormFactor.TabIndex = 122;
			pbCrossClearFormFactor.TabStop = false;
			pbCrossClearFormFactor.Click += pbCrossClearFormFactor_Click;
			// 
			// pbCrossClearMemoryType
			// 
			pbCrossClearMemoryType.BackColor = Color.Transparent;
			pbCrossClearMemoryType.Cursor = Cursors.Hand;
			pbCrossClearMemoryType.Image = Properties.Resources.Cross_Red;
			pbCrossClearMemoryType.Location = new Point(31, 309);
			pbCrossClearMemoryType.Name = "pbCrossClearMemoryType";
			pbCrossClearMemoryType.Size = new Size(23, 23);
			pbCrossClearMemoryType.SizeMode = PictureBoxSizeMode.AutoSize;
			pbCrossClearMemoryType.TabIndex = 123;
			pbCrossClearMemoryType.TabStop = false;
			pbCrossClearMemoryType.Click += pbCrossClearMemoryType_Click;
			// 
			// pbCrossClearWiFi
			// 
			pbCrossClearWiFi.BackColor = Color.Transparent;
			pbCrossClearWiFi.Cursor = Cursors.Hand;
			pbCrossClearWiFi.Image = Properties.Resources.Cross_Red;
			pbCrossClearWiFi.Location = new Point(309, 388);
			pbCrossClearWiFi.Name = "pbCrossClearWiFi";
			pbCrossClearWiFi.Size = new Size(23, 23);
			pbCrossClearWiFi.SizeMode = PictureBoxSizeMode.AutoSize;
			pbCrossClearWiFi.TabIndex = 124;
			pbCrossClearWiFi.TabStop = false;
			pbCrossClearWiFi.Click += pbCrossClearWiFi_Click;
			// 
			// pbCrossClearAllowsCPUOverclocking
			// 
			pbCrossClearAllowsCPUOverclocking.BackColor = Color.Transparent;
			pbCrossClearAllowsCPUOverclocking.Cursor = Cursors.Hand;
			pbCrossClearAllowsCPUOverclocking.Image = Properties.Resources.Cross_Red;
			pbCrossClearAllowsCPUOverclocking.Location = new Point(471, 82);
			pbCrossClearAllowsCPUOverclocking.Name = "pbCrossClearAllowsCPUOverclocking";
			pbCrossClearAllowsCPUOverclocking.Size = new Size(23, 23);
			pbCrossClearAllowsCPUOverclocking.SizeMode = PictureBoxSizeMode.AutoSize;
			pbCrossClearAllowsCPUOverclocking.TabIndex = 125;
			pbCrossClearAllowsCPUOverclocking.TabStop = false;
			pbCrossClearAllowsCPUOverclocking.Click += pbCrossClearAllowsCPUOverclocking_Click;
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
			panel.TabIndex = 126;
			// 
			// lblCase
			// 
			lblCase.AutoSize = true;
			lblCase.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblCase.ForeColor = Color.FromArgb(236, 179, 101);
			lblCase.Location = new Point(12, 9);
			lblCase.Name = "lblCase";
			lblCase.Size = new Size(45, 21);
			lblCase.TabIndex = 93;
			lblCase.Text = "Case";
			// 
			// FormModifyMotherboard
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(4, 28, 50);
			ClientSize = new Size(767, 492);
			Controls.Add(pbCrossClearAllowsCPUOverclocking);
			Controls.Add(pbCrossClearWiFi);
			Controls.Add(pbCrossClearMemoryType);
			Controls.Add(pbCrossClearFormFactor);
			Controls.Add(lblMotherboard);
			Controls.Add(lblError);
			Controls.Add(btnCancel);
			Controls.Add(btnConfirm);
			Controls.Add(lblInstruction);
			Controls.Add(cbWiFi);
			Controls.Add(tbxNumberOfM2Slots);
			Controls.Add(lblNumberOfM2Slots);
			Controls.Add(cbMemoryType);
			Controls.Add(lblMemoryType);
			Controls.Add(cbFormFactor);
			Controls.Add(lblFormFactor);
			Controls.Add(cbCPUOverclocking);
			Controls.Add(tbxMaximumSupportedMemoryCapacity);
			Controls.Add(lblMaximumSupportedMemoryCapacity);
			Controls.Add(tbxNumberOfSataPorts);
			Controls.Add(lblNumberOfSataPorts);
			Controls.Add(lblCPUOverclocking);
			Controls.Add(lblWiFi);
			Controls.Add(tbxNumberOfPCIeSlots);
			Controls.Add(lblNumberOfPCIeSlots);
			Controls.Add(lblNumberOfMemorySlots);
			Controls.Add(tbxNumberOfMemorySlots);
			Controls.Add(tbxChipset);
			Controls.Add(lblChipset);
			Controls.Add(tbxSocketType);
			Controls.Add(lblSocketType);
			Controls.Add(panel);
			FormBorderStyle = FormBorderStyle.None;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			Name = "FormModifyMotherboard";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Modify Motherboard";
			((System.ComponentModel.ISupportInitialize)pbCrossClearFormFactor).EndInit();
			((System.ComponentModel.ISupportInitialize)pbCrossClearMemoryType).EndInit();
			((System.ComponentModel.ISupportInitialize)pbCrossClearWiFi).EndInit();
			((System.ComponentModel.ISupportInitialize)pbCrossClearAllowsCPUOverclocking).EndInit();
			panel.ResumeLayout(false);
			panel.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ComboBox cbWiFi;
		private TextBox tbxNumberOfM2Slots;
		private Label lblNumberOfM2Slots;
		private ComboBox cbMemoryType;
		private Label lblMemoryType;
		private ComboBox cbFormFactor;
		private Label lblFormFactor;
		private ComboBox cbCPUOverclocking;
		private TextBox tbxMaximumSupportedMemoryCapacity;
		private Label lblMaximumSupportedMemoryCapacity;
		private TextBox tbxNumberOfSataPorts;
		private Label lblNumberOfSataPorts;
		private Label lblCPUOverclocking;
		private Label lblWiFi;
		private TextBox tbxNumberOfPCIeSlots;
		private Label lblNumberOfPCIeSlots;
		private Label lblNumberOfMemorySlots;
		private TextBox tbxNumberOfMemorySlots;
		private TextBox tbxChipset;
		private Label lblChipset;
		private TextBox tbxSocketType;
		private Label lblSocketType;
		private Label lblError;
		private Button btnCancel;
		private Button btnConfirm;
		private Label lblInstruction;
		private Label lblMotherboard;
		private PictureBox pbCrossClearFormFactor;
		private PictureBox pbCrossClearMemoryType;
		private PictureBox pbCrossClearWiFi;
		private PictureBox pbCrossClearAllowsCPUOverclocking;
		private Panel panel;
		private Label lblCase;
	}
}