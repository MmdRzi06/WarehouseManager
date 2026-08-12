namespace WarehouseManager {
	partial class FormModifyGraphicsCard {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModifyGraphicsCard));
			tbxTDP = new TextBox();
			lblTDP = new Label();
			tbxNumberOfHDMIPorts = new TextBox();
			lblNumberOfHDMIPorts = new Label();
			tbxNumberOfDisplayPorts = new TextBox();
			lblNumberOfDisplayPorts = new Label();
			cbPCIeGeneration = new ComboBox();
			lvlPCIeGeneration = new Label();
			cbMemoryType = new ComboBox();
			lblMemoryType = new Label();
			tbxArchitecture = new TextBox();
			lblArchitecture = new Label();
			tbxNumberOfPCIeLanes = new TextBox();
			lblNumberOfPCIeLanes = new Label();
			tbxMemoryCapacity = new TextBox();
			lblMemoryCapacity = new Label();
			tbxBoostClock = new TextBox();
			lblBoostClock = new Label();
			tbxBaseClock = new TextBox();
			lblBaseClock = new Label();
			tbxNumberOfCores = new TextBox();
			lblNumberOfCores = new Label();
			tbxChipModel = new TextBox();
			lblChipModel = new Label();
			tbxGPUManufacturer = new TextBox();
			lblGPUManufacturer = new Label();
			lblInstruction = new Label();
			lblError = new Label();
			btnCancel = new Button();
			btnConfirm = new Button();
			lblGraphicsCard = new Label();
			pbCrossClearMemoryType = new PictureBox();
			pbCrossClearPCIeGeneration = new PictureBox();
			panel = new Panel();
			lblCase = new Label();
			((System.ComponentModel.ISupportInitialize)pbCrossClearMemoryType).BeginInit();
			((System.ComponentModel.ISupportInitialize)pbCrossClearPCIeGeneration).BeginInit();
			panel.SuspendLayout();
			SuspendLayout();
			// 
			// tbxTDP
			// 
			tbxTDP.BackColor = Color.FromArgb(4, 41, 58);
			tbxTDP.BorderStyle = BorderStyle.FixedSingle;
			tbxTDP.ForeColor = Color.FromArgb(236, 179, 101);
			tbxTDP.Location = new Point(501, 82);
			tbxTDP.Margin = new Padding(3, 2, 3, 2);
			tbxTDP.MaxLength = 7;
			tbxTDP.Name = "tbxTDP";
			tbxTDP.Size = new Size(69, 23);
			tbxTDP.TabIndex = 121;
			tbxTDP.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblTDP
			// 
			lblTDP.AutoSize = true;
			lblTDP.ForeColor = Color.FromArgb(236, 179, 101);
			lblTDP.Location = new Point(501, 56);
			lblTDP.Name = "lblTDP";
			lblTDP.Size = new Size(51, 15);
			lblTDP.TabIndex = 120;
			lblTDP.Text = "TDP (W)";
			// 
			// tbxNumberOfHDMIPorts
			// 
			tbxNumberOfHDMIPorts.BackColor = Color.FromArgb(4, 41, 58);
			tbxNumberOfHDMIPorts.BorderStyle = BorderStyle.FixedSingle;
			tbxNumberOfHDMIPorts.ForeColor = Color.FromArgb(236, 179, 101);
			tbxNumberOfHDMIPorts.Location = new Point(501, 233);
			tbxNumberOfHDMIPorts.Margin = new Padding(3, 2, 3, 2);
			tbxNumberOfHDMIPorts.MaxLength = 7;
			tbxNumberOfHDMIPorts.Name = "tbxNumberOfHDMIPorts";
			tbxNumberOfHDMIPorts.Size = new Size(69, 23);
			tbxNumberOfHDMIPorts.TabIndex = 119;
			tbxNumberOfHDMIPorts.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblNumberOfHDMIPorts
			// 
			lblNumberOfHDMIPorts.AutoSize = true;
			lblNumberOfHDMIPorts.ForeColor = Color.FromArgb(236, 179, 101);
			lblNumberOfHDMIPorts.Location = new Point(501, 207);
			lblNumberOfHDMIPorts.Name = "lblNumberOfHDMIPorts";
			lblNumberOfHDMIPorts.Size = new Size(131, 15);
			lblNumberOfHDMIPorts.TabIndex = 118;
			lblNumberOfHDMIPorts.Text = "Number Of HDMI Ports";
			// 
			// tbxNumberOfDisplayPorts
			// 
			tbxNumberOfDisplayPorts.BackColor = Color.FromArgb(4, 41, 58);
			tbxNumberOfDisplayPorts.BorderStyle = BorderStyle.FixedSingle;
			tbxNumberOfDisplayPorts.ForeColor = Color.FromArgb(236, 179, 101);
			tbxNumberOfDisplayPorts.Location = new Point(501, 157);
			tbxNumberOfDisplayPorts.Margin = new Padding(3, 2, 3, 2);
			tbxNumberOfDisplayPorts.MaxLength = 7;
			tbxNumberOfDisplayPorts.Name = "tbxNumberOfDisplayPorts";
			tbxNumberOfDisplayPorts.Size = new Size(69, 23);
			tbxNumberOfDisplayPorts.TabIndex = 117;
			tbxNumberOfDisplayPorts.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblNumberOfDisplayPorts
			// 
			lblNumberOfDisplayPorts.AutoSize = true;
			lblNumberOfDisplayPorts.ForeColor = Color.FromArgb(236, 179, 101);
			lblNumberOfDisplayPorts.Location = new Point(501, 131);
			lblNumberOfDisplayPorts.Name = "lblNumberOfDisplayPorts";
			lblNumberOfDisplayPorts.Size = new Size(135, 15);
			lblNumberOfDisplayPorts.TabIndex = 116;
			lblNumberOfDisplayPorts.Text = "Number Of DisplayPorts";
			// 
			// cbPCIeGeneration
			// 
			cbPCIeGeneration.BackColor = Color.FromArgb(4, 41, 58);
			cbPCIeGeneration.DropDownStyle = ComboBoxStyle.DropDownList;
			cbPCIeGeneration.ForeColor = Color.FromArgb(236, 179, 101);
			cbPCIeGeneration.FormattingEnabled = true;
			cbPCIeGeneration.Items.AddRange(new object[] { "PCIe 3.0", "PCIe 4.0", "PCIe 5.0", "PCIe 6.0" });
			cbPCIeGeneration.Location = new Point(339, 309);
			cbPCIeGeneration.Margin = new Padding(3, 2, 3, 2);
			cbPCIeGeneration.Name = "cbPCIeGeneration";
			cbPCIeGeneration.Size = new Size(120, 23);
			cbPCIeGeneration.TabIndex = 115;
			// 
			// lvlPCIeGeneration
			// 
			lvlPCIeGeneration.AutoSize = true;
			lvlPCIeGeneration.ForeColor = Color.FromArgb(236, 179, 101);
			lvlPCIeGeneration.Location = new Point(339, 283);
			lvlPCIeGeneration.Name = "lvlPCIeGeneration";
			lvlPCIeGeneration.Size = new Size(92, 15);
			lvlPCIeGeneration.TabIndex = 114;
			lvlPCIeGeneration.Text = "PCIe Generation";
			// 
			// cbMemoryType
			// 
			cbMemoryType.BackColor = Color.FromArgb(4, 41, 58);
			cbMemoryType.DropDownStyle = ComboBoxStyle.DropDownList;
			cbMemoryType.ForeColor = Color.FromArgb(236, 179, 101);
			cbMemoryType.FormattingEnabled = true;
			cbMemoryType.Items.AddRange(new object[] { "GDDR6", "GDDR6X", "GDDR7" });
			cbMemoryType.Location = new Point(339, 233);
			cbMemoryType.Margin = new Padding(3, 2, 3, 2);
			cbMemoryType.Name = "cbMemoryType";
			cbMemoryType.Size = new Size(120, 23);
			cbMemoryType.TabIndex = 113;
			// 
			// lblMemoryType
			// 
			lblMemoryType.AutoSize = true;
			lblMemoryType.ForeColor = Color.FromArgb(236, 179, 101);
			lblMemoryType.Location = new Point(339, 207);
			lblMemoryType.Name = "lblMemoryType";
			lblMemoryType.Size = new Size(80, 15);
			lblMemoryType.TabIndex = 112;
			lblMemoryType.Text = "Memory Type";
			// 
			// tbxArchitecture
			// 
			tbxArchitecture.BackColor = Color.FromArgb(4, 41, 58);
			tbxArchitecture.BorderStyle = BorderStyle.FixedSingle;
			tbxArchitecture.ForeColor = Color.FromArgb(236, 179, 101);
			tbxArchitecture.Location = new Point(61, 233);
			tbxArchitecture.Margin = new Padding(3, 2, 3, 2);
			tbxArchitecture.MaxLength = 20;
			tbxArchitecture.Name = "tbxArchitecture";
			tbxArchitecture.Size = new Size(214, 23);
			tbxArchitecture.TabIndex = 111;
			tbxArchitecture.KeyPress += StringTextBoxes_KeyPress;
			// 
			// lblArchitecture
			// 
			lblArchitecture.AutoSize = true;
			lblArchitecture.ForeColor = Color.FromArgb(236, 179, 101);
			lblArchitecture.Location = new Point(61, 207);
			lblArchitecture.Name = "lblArchitecture";
			lblArchitecture.Size = new Size(72, 15);
			lblArchitecture.TabIndex = 110;
			lblArchitecture.Text = "Architecture";
			// 
			// tbxNumberOfPCIeLanes
			// 
			tbxNumberOfPCIeLanes.BackColor = Color.FromArgb(4, 41, 58);
			tbxNumberOfPCIeLanes.BorderStyle = BorderStyle.FixedSingle;
			tbxNumberOfPCIeLanes.ForeColor = Color.FromArgb(236, 179, 101);
			tbxNumberOfPCIeLanes.Location = new Point(339, 388);
			tbxNumberOfPCIeLanes.Margin = new Padding(3, 2, 3, 2);
			tbxNumberOfPCIeLanes.MaxLength = 7;
			tbxNumberOfPCIeLanes.Name = "tbxNumberOfPCIeLanes";
			tbxNumberOfPCIeLanes.Size = new Size(69, 23);
			tbxNumberOfPCIeLanes.TabIndex = 109;
			tbxNumberOfPCIeLanes.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblNumberOfPCIeLanes
			// 
			lblNumberOfPCIeLanes.AutoSize = true;
			lblNumberOfPCIeLanes.ForeColor = Color.FromArgb(236, 179, 101);
			lblNumberOfPCIeLanes.Location = new Point(339, 362);
			lblNumberOfPCIeLanes.Name = "lblNumberOfPCIeLanes";
			lblNumberOfPCIeLanes.Size = new Size(127, 15);
			lblNumberOfPCIeLanes.TabIndex = 108;
			lblNumberOfPCIeLanes.Text = "Number Of PCIe Lanes";
			// 
			// tbxMemoryCapacity
			// 
			tbxMemoryCapacity.BackColor = Color.FromArgb(4, 41, 58);
			tbxMemoryCapacity.BorderStyle = BorderStyle.FixedSingle;
			tbxMemoryCapacity.ForeColor = Color.FromArgb(236, 179, 101);
			tbxMemoryCapacity.Location = new Point(339, 157);
			tbxMemoryCapacity.Margin = new Padding(3, 2, 3, 2);
			tbxMemoryCapacity.MaxLength = 7;
			tbxMemoryCapacity.Name = "tbxMemoryCapacity";
			tbxMemoryCapacity.Size = new Size(69, 23);
			tbxMemoryCapacity.TabIndex = 107;
			tbxMemoryCapacity.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblMemoryCapacity
			// 
			lblMemoryCapacity.AutoSize = true;
			lblMemoryCapacity.ForeColor = Color.FromArgb(236, 179, 101);
			lblMemoryCapacity.Location = new Point(339, 131);
			lblMemoryCapacity.Name = "lblMemoryCapacity";
			lblMemoryCapacity.Size = new Size(127, 15);
			lblMemoryCapacity.TabIndex = 106;
			lblMemoryCapacity.Text = "Memory Capacity (GB)";
			// 
			// tbxBoostClock
			// 
			tbxBoostClock.BackColor = Color.FromArgb(4, 41, 58);
			tbxBoostClock.BorderStyle = BorderStyle.FixedSingle;
			tbxBoostClock.ForeColor = Color.FromArgb(236, 179, 101);
			tbxBoostClock.Location = new Point(339, 82);
			tbxBoostClock.Margin = new Padding(3, 2, 3, 2);
			tbxBoostClock.MaxLength = 7;
			tbxBoostClock.Name = "tbxBoostClock";
			tbxBoostClock.Size = new Size(69, 23);
			tbxBoostClock.TabIndex = 105;
			tbxBoostClock.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblBoostClock
			// 
			lblBoostClock.AutoSize = true;
			lblBoostClock.ForeColor = Color.FromArgb(236, 179, 101);
			lblBoostClock.Location = new Point(339, 56);
			lblBoostClock.Name = "lblBoostClock";
			lblBoostClock.Size = new Size(106, 15);
			lblBoostClock.TabIndex = 104;
			lblBoostClock.Text = "Boost Clock (MHz)";
			// 
			// tbxBaseClock
			// 
			tbxBaseClock.BackColor = Color.FromArgb(4, 41, 58);
			tbxBaseClock.BorderStyle = BorderStyle.FixedSingle;
			tbxBaseClock.ForeColor = Color.FromArgb(236, 179, 101);
			tbxBaseClock.Location = new Point(62, 388);
			tbxBaseClock.Margin = new Padding(3, 2, 3, 2);
			tbxBaseClock.MaxLength = 7;
			tbxBaseClock.Name = "tbxBaseClock";
			tbxBaseClock.Size = new Size(69, 23);
			tbxBaseClock.TabIndex = 103;
			tbxBaseClock.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblBaseClock
			// 
			lblBaseClock.AutoSize = true;
			lblBaseClock.ForeColor = Color.FromArgb(236, 179, 101);
			lblBaseClock.Location = new Point(62, 362);
			lblBaseClock.Name = "lblBaseClock";
			lblBaseClock.Size = new Size(100, 15);
			lblBaseClock.TabIndex = 102;
			lblBaseClock.Text = "Base Clock (MHz)";
			// 
			// tbxNumberOfCores
			// 
			tbxNumberOfCores.BackColor = Color.FromArgb(4, 41, 58);
			tbxNumberOfCores.BorderStyle = BorderStyle.FixedSingle;
			tbxNumberOfCores.ForeColor = Color.FromArgb(236, 179, 101);
			tbxNumberOfCores.Location = new Point(62, 309);
			tbxNumberOfCores.Margin = new Padding(3, 2, 3, 2);
			tbxNumberOfCores.MaxLength = 7;
			tbxNumberOfCores.Name = "tbxNumberOfCores";
			tbxNumberOfCores.Size = new Size(69, 23);
			tbxNumberOfCores.TabIndex = 101;
			tbxNumberOfCores.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblNumberOfCores
			// 
			lblNumberOfCores.AutoSize = true;
			lblNumberOfCores.ForeColor = Color.FromArgb(236, 179, 101);
			lblNumberOfCores.Location = new Point(62, 283);
			lblNumberOfCores.Name = "lblNumberOfCores";
			lblNumberOfCores.Size = new Size(100, 15);
			lblNumberOfCores.TabIndex = 100;
			lblNumberOfCores.Text = "Number Of Cores";
			// 
			// tbxChipModel
			// 
			tbxChipModel.BackColor = Color.FromArgb(4, 41, 58);
			tbxChipModel.BorderStyle = BorderStyle.FixedSingle;
			tbxChipModel.ForeColor = Color.FromArgb(236, 179, 101);
			tbxChipModel.Location = new Point(61, 157);
			tbxChipModel.Margin = new Padding(3, 2, 3, 2);
			tbxChipModel.MaxLength = 20;
			tbxChipModel.Name = "tbxChipModel";
			tbxChipModel.Size = new Size(214, 23);
			tbxChipModel.TabIndex = 99;
			tbxChipModel.KeyPress += StringTextBoxes_KeyPress;
			// 
			// lblChipModel
			// 
			lblChipModel.AutoSize = true;
			lblChipModel.ForeColor = Color.FromArgb(236, 179, 101);
			lblChipModel.Location = new Point(61, 131);
			lblChipModel.Name = "lblChipModel";
			lblChipModel.Size = new Size(69, 15);
			lblChipModel.TabIndex = 98;
			lblChipModel.Text = "Chip Model";
			// 
			// tbxGPUManufacturer
			// 
			tbxGPUManufacturer.BackColor = Color.FromArgb(4, 41, 58);
			tbxGPUManufacturer.BorderStyle = BorderStyle.FixedSingle;
			tbxGPUManufacturer.ForeColor = Color.FromArgb(236, 179, 101);
			tbxGPUManufacturer.Location = new Point(61, 82);
			tbxGPUManufacturer.Margin = new Padding(3, 2, 3, 2);
			tbxGPUManufacturer.MaxLength = 20;
			tbxGPUManufacturer.Name = "tbxGPUManufacturer";
			tbxGPUManufacturer.Size = new Size(214, 23);
			tbxGPUManufacturer.TabIndex = 97;
			tbxGPUManufacturer.KeyPress += StringTextBoxes_KeyPress;
			// 
			// lblGPUManufacturer
			// 
			lblGPUManufacturer.AutoSize = true;
			lblGPUManufacturer.ForeColor = Color.FromArgb(236, 179, 101);
			lblGPUManufacturer.Location = new Point(61, 56);
			lblGPUManufacturer.Name = "lblGPUManufacturer";
			lblGPUManufacturer.Size = new Size(105, 15);
			lblGPUManufacturer.TabIndex = 96;
			lblGPUManufacturer.Text = "GPU Manufacturer";
			// 
			// lblInstruction
			// 
			lblInstruction.AutoSize = true;
			lblInstruction.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblInstruction.ForeColor = Color.FromArgb(236, 179, 101);
			lblInstruction.Location = new Point(229, 9);
			lblInstruction.Name = "lblInstruction";
			lblInstruction.Size = new Size(308, 20);
			lblInstruction.TabIndex = 124;
			lblInstruction.Text = "Fill out the fields you would like to change.";
			// 
			// lblError
			// 
			lblError.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblError.ForeColor = Color.FromArgb(244, 43, 50);
			lblError.Location = new Point(107, 443);
			lblError.Name = "lblError";
			lblError.Size = new Size(406, 36);
			lblError.TabIndex = 127;
			lblError.Text = "\r\n";
			// 
			// btnCancel
			// 
			btnCancel.BackColor = Color.FromArgb(4, 41, 58);
			btnCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 41, 58);
			btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(6, 70, 99);
			btnCancel.FlatStyle = FlatStyle.Popup;
			btnCancel.ForeColor = Color.FromArgb(236, 179, 101);
			btnCancel.Location = new Point(519, 443);
			btnCancel.Margin = new Padding(3, 2, 3, 2);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(115, 38);
			btnCancel.TabIndex = 126;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = false;
			btnCancel.Click += btnCancel_Click;
			// 
			// btnConfirm
			// 
			btnConfirm.BackColor = Color.FromArgb(4, 41, 58);
			btnConfirm.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 41, 58);
			btnConfirm.FlatAppearance.MouseOverBackColor = Color.FromArgb(6, 70, 99);
			btnConfirm.FlatStyle = FlatStyle.Popup;
			btnConfirm.ForeColor = Color.FromArgb(236, 179, 101);
			btnConfirm.Location = new Point(640, 443);
			btnConfirm.Margin = new Padding(3, 2, 3, 2);
			btnConfirm.Name = "btnConfirm";
			btnConfirm.Size = new Size(115, 38);
			btnConfirm.TabIndex = 125;
			btnConfirm.Text = "Confirm";
			btnConfirm.UseVisualStyleBackColor = false;
			btnConfirm.Click += btnConfirm_Click;
			// 
			// lblGraphicsCard
			// 
			lblGraphicsCard.AutoSize = true;
			lblGraphicsCard.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblGraphicsCard.ForeColor = Color.FromArgb(236, 179, 101);
			lblGraphicsCard.Location = new Point(12, 9);
			lblGraphicsCard.Name = "lblGraphicsCard";
			lblGraphicsCard.Size = new Size(115, 21);
			lblGraphicsCard.TabIndex = 128;
			lblGraphicsCard.Text = "Graphics Card";
			// 
			// pbCrossClearMemoryType
			// 
			pbCrossClearMemoryType.BackColor = Color.Transparent;
			pbCrossClearMemoryType.Cursor = Cursors.Hand;
			pbCrossClearMemoryType.Image = Properties.Resources.Cross_Red;
			pbCrossClearMemoryType.Location = new Point(310, 233);
			pbCrossClearMemoryType.Name = "pbCrossClearMemoryType";
			pbCrossClearMemoryType.Size = new Size(23, 23);
			pbCrossClearMemoryType.SizeMode = PictureBoxSizeMode.AutoSize;
			pbCrossClearMemoryType.TabIndex = 129;
			pbCrossClearMemoryType.TabStop = false;
			pbCrossClearMemoryType.Click += pbCrossClearMemoryType_Click;
			// 
			// pbCrossClearPCIeGeneration
			// 
			pbCrossClearPCIeGeneration.BackColor = Color.Transparent;
			pbCrossClearPCIeGeneration.Cursor = Cursors.Hand;
			pbCrossClearPCIeGeneration.Image = Properties.Resources.Cross_Red;
			pbCrossClearPCIeGeneration.Location = new Point(310, 309);
			pbCrossClearPCIeGeneration.Name = "pbCrossClearPCIeGeneration";
			pbCrossClearPCIeGeneration.Size = new Size(23, 23);
			pbCrossClearPCIeGeneration.SizeMode = PictureBoxSizeMode.AutoSize;
			pbCrossClearPCIeGeneration.TabIndex = 130;
			pbCrossClearPCIeGeneration.TabStop = false;
			pbCrossClearPCIeGeneration.Click += pbCrossClearPCIeGeneration_Click;
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
			panel.TabIndex = 131;
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
			// FormModifyGraphicsCard
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(4, 28, 50);
			ClientSize = new Size(767, 492);
			Controls.Add(pbCrossClearPCIeGeneration);
			Controls.Add(pbCrossClearMemoryType);
			Controls.Add(lblGraphicsCard);
			Controls.Add(lblError);
			Controls.Add(btnCancel);
			Controls.Add(btnConfirm);
			Controls.Add(lblInstruction);
			Controls.Add(tbxTDP);
			Controls.Add(lblTDP);
			Controls.Add(tbxNumberOfHDMIPorts);
			Controls.Add(lblNumberOfHDMIPorts);
			Controls.Add(tbxNumberOfDisplayPorts);
			Controls.Add(lblNumberOfDisplayPorts);
			Controls.Add(cbPCIeGeneration);
			Controls.Add(lvlPCIeGeneration);
			Controls.Add(cbMemoryType);
			Controls.Add(lblMemoryType);
			Controls.Add(tbxArchitecture);
			Controls.Add(lblArchitecture);
			Controls.Add(tbxNumberOfPCIeLanes);
			Controls.Add(lblNumberOfPCIeLanes);
			Controls.Add(tbxMemoryCapacity);
			Controls.Add(lblMemoryCapacity);
			Controls.Add(tbxBoostClock);
			Controls.Add(lblBoostClock);
			Controls.Add(tbxBaseClock);
			Controls.Add(lblBaseClock);
			Controls.Add(tbxNumberOfCores);
			Controls.Add(lblNumberOfCores);
			Controls.Add(tbxChipModel);
			Controls.Add(lblChipModel);
			Controls.Add(tbxGPUManufacturer);
			Controls.Add(lblGPUManufacturer);
			Controls.Add(panel);
			FormBorderStyle = FormBorderStyle.None;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			Name = "FormModifyGraphicsCard";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Modify Graphics Card";
			((System.ComponentModel.ISupportInitialize)pbCrossClearMemoryType).EndInit();
			((System.ComponentModel.ISupportInitialize)pbCrossClearPCIeGeneration).EndInit();
			panel.ResumeLayout(false);
			panel.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox tbxTDP;
		private Label lblTDP;
		private TextBox tbxNumberOfHDMIPorts;
		private Label lblNumberOfHDMIPorts;
		private TextBox tbxNumberOfDisplayPorts;
		private Label lblNumberOfDisplayPorts;
		private ComboBox cbPCIeGeneration;
		private Label lvlPCIeGeneration;
		private ComboBox cbMemoryType;
		private Label lblMemoryType;
		private TextBox tbxArchitecture;
		private Label lblArchitecture;
		private TextBox tbxNumberOfPCIeLanes;
		private Label lblNumberOfPCIeLanes;
		private TextBox tbxMemoryCapacity;
		private Label lblMemoryCapacity;
		private TextBox tbxBoostClock;
		private Label lblBoostClock;
		private TextBox tbxBaseClock;
		private Label lblBaseClock;
		private TextBox tbxNumberOfCores;
		private Label lblNumberOfCores;
		private TextBox tbxChipModel;
		private Label lblChipModel;
		private TextBox tbxGPUManufacturer;
		private Label lblGPUManufacturer;
		private Label lblInstruction;
		private Label lblError;
		private Button btnCancel;
		private Button btnConfirm;
		private Label lblGraphicsCard;
		private PictureBox pbCrossClearMemoryType;
		private PictureBox pbCrossClearPCIeGeneration;
		private Panel panel;
		private Label lblCase;
	}
}