namespace WarehouseManager {
	partial class FormAddMotherboard {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddMotherboard));
			lblError = new Label();
			btnCancel = new Button();
			btnConfirm = new Button();
			panelBenchMarkInfo = new Panel();
			tbxMaximumScore = new TextBox();
			lblMaximumScore = new Label();
			tbxAverageScore = new TextBox();
			lblAverageScore = new Label();
			tbxSource = new TextBox();
			lblSource = new Label();
			chbBenchMarkInfo = new CheckBox();
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
			tbxWeight = new TextBox();
			lblWeight = new Label();
			tbxStockQuantity = new TextBox();
			lblStockQuantity = new Label();
			tbxPrice = new TextBox();
			lblPrice = new Label();
			tbxManufacturer = new TextBox();
			lblManufacturer = new Label();
			tbxName = new TextBox();
			lblName = new Label();
			cbFormFactor = new ComboBox();
			lblFormFactor = new Label();
			cbMemoryType = new ComboBox();
			lblMemoryType = new Label();
			tbxNumberOfM2Slots = new TextBox();
			lblNumberOfM2Slots = new Label();
			cbWiFi = new ComboBox();
			lblMotherboard = new Label();
			panel = new Panel();
			lblCase = new Label();
			panelBenchMarkInfo.SuspendLayout();
			panel.SuspendLayout();
			SuspendLayout();
			// 
			// lblError
			// 
			lblError.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblError.ForeColor = Color.FromArgb(244, 43, 50);
			lblError.Location = new Point(716, 428);
			lblError.Name = "lblError";
			lblError.Size = new Size(406, 36);
			lblError.TabIndex = 83;
			lblError.Text = "\r\n";
			// 
			// btnCancel
			// 
			btnCancel.BackColor = Color.FromArgb(4, 41, 58);
			btnCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 41, 58);
			btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(6, 70, 99);
			btnCancel.FlatStyle = FlatStyle.Flat;
			btnCancel.ForeColor = Color.FromArgb(236, 179, 101);
			btnCancel.Location = new Point(1128, 428);
			btnCancel.Margin = new Padding(3, 2, 3, 2);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(115, 38);
			btnCancel.TabIndex = 82;
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
			btnConfirm.Location = new Point(1249, 428);
			btnConfirm.Margin = new Padding(3, 2, 3, 2);
			btnConfirm.Name = "btnConfirm";
			btnConfirm.Size = new Size(115, 38);
			btnConfirm.TabIndex = 81;
			btnConfirm.Text = "Confirm";
			btnConfirm.UseVisualStyleBackColor = false;
			btnConfirm.Click += btnConfirm_Click;
			// 
			// panelBenchMarkInfo
			// 
			panelBenchMarkInfo.Controls.Add(tbxMaximumScore);
			panelBenchMarkInfo.Controls.Add(lblMaximumScore);
			panelBenchMarkInfo.Controls.Add(tbxAverageScore);
			panelBenchMarkInfo.Controls.Add(lblAverageScore);
			panelBenchMarkInfo.Controls.Add(tbxSource);
			panelBenchMarkInfo.Controls.Add(lblSource);
			panelBenchMarkInfo.ForeColor = Color.FromArgb(236, 179, 101);
			panelBenchMarkInfo.Location = new Point(1014, 83);
			panelBenchMarkInfo.Name = "panelBenchMarkInfo";
			panelBenchMarkInfo.Size = new Size(267, 278);
			panelBenchMarkInfo.TabIndex = 80;
			// 
			// tbxMaximumScore
			// 
			tbxMaximumScore.BackColor = Color.FromArgb(4, 41, 58);
			tbxMaximumScore.BorderStyle = BorderStyle.FixedSingle;
			tbxMaximumScore.ForeColor = Color.FromArgb(236, 179, 101);
			tbxMaximumScore.Location = new Point(56, 204);
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
			lblMaximumScore.Location = new Point(56, 178);
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
			tbxAverageScore.Location = new Point(56, 128);
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
			lblAverageScore.Location = new Point(56, 102);
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
			tbxSource.Location = new Point(56, 50);
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
			lblSource.Location = new Point(56, 24);
			lblSource.Name = "lblSource";
			lblSource.Size = new Size(43, 15);
			lblSource.TabIndex = 25;
			lblSource.Text = "Source";
			// 
			// chbBenchMarkInfo
			// 
			chbBenchMarkInfo.AutoSize = true;
			chbBenchMarkInfo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			chbBenchMarkInfo.ForeColor = Color.FromArgb(236, 179, 101);
			chbBenchMarkInfo.Location = new Point(1047, 45);
			chbBenchMarkInfo.Name = "chbBenchMarkInfo";
			chbBenchMarkInfo.Size = new Size(196, 24);
			chbBenchMarkInfo.TabIndex = 79;
			chbBenchMarkInfo.Text = "Benchmark Information";
			chbBenchMarkInfo.UseVisualStyleBackColor = true;
			chbBenchMarkInfo.CheckedChanged += chbBenchMarkInfo_CheckedChanged;
			// 
			// cbCPUOverclocking
			// 
			cbCPUOverclocking.BackColor = Color.FromArgb(4, 41, 58);
			cbCPUOverclocking.DropDownStyle = ComboBoxStyle.DropDownList;
			cbCPUOverclocking.ForeColor = Color.FromArgb(236, 179, 101);
			cbCPUOverclocking.FormattingEnabled = true;
			cbCPUOverclocking.Items.AddRange(new object[] { "Yes", "No" });
			cbCPUOverclocking.Location = new Point(778, 71);
			cbCPUOverclocking.Margin = new Padding(3, 2, 3, 2);
			cbCPUOverclocking.Name = "cbCPUOverclocking";
			cbCPUOverclocking.Size = new Size(120, 23);
			cbCPUOverclocking.TabIndex = 78;
			// 
			// tbxMaximumSupportedMemoryCapacity
			// 
			tbxMaximumSupportedMemoryCapacity.BackColor = Color.FromArgb(4, 41, 58);
			tbxMaximumSupportedMemoryCapacity.BorderStyle = BorderStyle.FixedSingle;
			tbxMaximumSupportedMemoryCapacity.ForeColor = Color.FromArgb(236, 179, 101);
			tbxMaximumSupportedMemoryCapacity.Location = new Point(616, 222);
			tbxMaximumSupportedMemoryCapacity.Margin = new Padding(3, 2, 3, 2);
			tbxMaximumSupportedMemoryCapacity.MaxLength = 7;
			tbxMaximumSupportedMemoryCapacity.Name = "tbxMaximumSupportedMemoryCapacity";
			tbxMaximumSupportedMemoryCapacity.Size = new Size(69, 23);
			tbxMaximumSupportedMemoryCapacity.TabIndex = 76;
			tbxMaximumSupportedMemoryCapacity.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblMaximumSupportedMemoryCapacity
			// 
			lblMaximumSupportedMemoryCapacity.AutoSize = true;
			lblMaximumSupportedMemoryCapacity.ForeColor = Color.FromArgb(236, 179, 101);
			lblMaximumSupportedMemoryCapacity.Location = new Point(616, 196);
			lblMaximumSupportedMemoryCapacity.Name = "lblMaximumSupportedMemoryCapacity";
			lblMaximumSupportedMemoryCapacity.Size = new Size(242, 15);
			lblMaximumSupportedMemoryCapacity.TabIndex = 75;
			lblMaximumSupportedMemoryCapacity.Text = "Maximum Supported Memory Capacity (GB)";
			// 
			// tbxNumberOfSataPorts
			// 
			tbxNumberOfSataPorts.BackColor = Color.FromArgb(4, 41, 58);
			tbxNumberOfSataPorts.BorderStyle = BorderStyle.FixedSingle;
			tbxNumberOfSataPorts.ForeColor = Color.FromArgb(236, 179, 101);
			tbxNumberOfSataPorts.Location = new Point(616, 298);
			tbxNumberOfSataPorts.Margin = new Padding(3, 2, 3, 2);
			tbxNumberOfSataPorts.MaxLength = 7;
			tbxNumberOfSataPorts.Name = "tbxNumberOfSataPorts";
			tbxNumberOfSataPorts.Size = new Size(69, 23);
			tbxNumberOfSataPorts.TabIndex = 74;
			tbxNumberOfSataPorts.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblNumberOfSataPorts
			// 
			lblNumberOfSataPorts.AutoSize = true;
			lblNumberOfSataPorts.ForeColor = Color.FromArgb(236, 179, 101);
			lblNumberOfSataPorts.Location = new Point(616, 272);
			lblNumberOfSataPorts.Name = "lblNumberOfSataPorts";
			lblNumberOfSataPorts.Size = new Size(122, 15);
			lblNumberOfSataPorts.TabIndex = 73;
			lblNumberOfSataPorts.Text = "Number Of Sata Ports";
			// 
			// lblCPUOverclocking
			// 
			lblCPUOverclocking.AutoSize = true;
			lblCPUOverclocking.ForeColor = Color.FromArgb(236, 179, 101);
			lblCPUOverclocking.Location = new Point(778, 45);
			lblCPUOverclocking.Name = "lblCPUOverclocking";
			lblCPUOverclocking.Size = new Size(141, 15);
			lblCPUOverclocking.TabIndex = 77;
			lblCPUOverclocking.Text = "Allows CPU Overclocking";
			// 
			// lblWiFi
			// 
			lblWiFi.AutoSize = true;
			lblWiFi.ForeColor = Color.FromArgb(236, 179, 101);
			lblWiFi.Location = new Point(616, 351);
			lblWiFi.Name = "lblWiFi";
			lblWiFi.Size = new Size(82, 15);
			lblWiFi.TabIndex = 71;
			lblWiFi.Text = "Includes Wi-Fi";
			// 
			// tbxNumberOfPCIeSlots
			// 
			tbxNumberOfPCIeSlots.BackColor = Color.FromArgb(4, 41, 58);
			tbxNumberOfPCIeSlots.BorderStyle = BorderStyle.FixedSingle;
			tbxNumberOfPCIeSlots.ForeColor = Color.FromArgb(236, 179, 101);
			tbxNumberOfPCIeSlots.Location = new Point(338, 377);
			tbxNumberOfPCIeSlots.Margin = new Padding(3, 2, 3, 2);
			tbxNumberOfPCIeSlots.MaxLength = 7;
			tbxNumberOfPCIeSlots.Name = "tbxNumberOfPCIeSlots";
			tbxNumberOfPCIeSlots.Size = new Size(69, 23);
			tbxNumberOfPCIeSlots.TabIndex = 68;
			tbxNumberOfPCIeSlots.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblNumberOfPCIeSlots
			// 
			lblNumberOfPCIeSlots.AutoSize = true;
			lblNumberOfPCIeSlots.ForeColor = Color.FromArgb(236, 179, 101);
			lblNumberOfPCIeSlots.Location = new Point(338, 351);
			lblNumberOfPCIeSlots.Name = "lblNumberOfPCIeSlots";
			lblNumberOfPCIeSlots.Size = new Size(122, 15);
			lblNumberOfPCIeSlots.TabIndex = 67;
			lblNumberOfPCIeSlots.Text = "Number Of PCIe Slots";
			// 
			// lblNumberOfMemorySlots
			// 
			lblNumberOfMemorySlots.AutoSize = true;
			lblNumberOfMemorySlots.ForeColor = Color.FromArgb(236, 179, 101);
			lblNumberOfMemorySlots.Location = new Point(616, 120);
			lblNumberOfMemorySlots.Name = "lblNumberOfMemorySlots";
			lblNumberOfMemorySlots.Size = new Size(143, 15);
			lblNumberOfMemorySlots.TabIndex = 65;
			lblNumberOfMemorySlots.Text = "Number Of Memory Slots";
			// 
			// tbxNumberOfMemorySlots
			// 
			tbxNumberOfMemorySlots.BackColor = Color.FromArgb(4, 41, 58);
			tbxNumberOfMemorySlots.BorderStyle = BorderStyle.FixedSingle;
			tbxNumberOfMemorySlots.ForeColor = Color.FromArgb(236, 179, 101);
			tbxNumberOfMemorySlots.Location = new Point(616, 146);
			tbxNumberOfMemorySlots.Margin = new Padding(3, 2, 3, 2);
			tbxNumberOfMemorySlots.MaxLength = 7;
			tbxNumberOfMemorySlots.Name = "tbxNumberOfMemorySlots";
			tbxNumberOfMemorySlots.Size = new Size(69, 23);
			tbxNumberOfMemorySlots.TabIndex = 66;
			tbxNumberOfMemorySlots.KeyPress += IntTextBoxes_KeyPress;
			// 
			// tbxChipset
			// 
			tbxChipset.BackColor = Color.FromArgb(4, 41, 58);
			tbxChipset.BorderStyle = BorderStyle.FixedSingle;
			tbxChipset.ForeColor = Color.FromArgb(236, 179, 101);
			tbxChipset.Location = new Point(338, 146);
			tbxChipset.Margin = new Padding(3, 2, 3, 2);
			tbxChipset.MaxLength = 20;
			tbxChipset.Name = "tbxChipset";
			tbxChipset.Size = new Size(214, 23);
			tbxChipset.TabIndex = 60;
			tbxChipset.KeyPress += StringTextBoxes_KeyPress;
			// 
			// lblChipset
			// 
			lblChipset.AutoSize = true;
			lblChipset.ForeColor = Color.FromArgb(236, 179, 101);
			lblChipset.Location = new Point(338, 120);
			lblChipset.Name = "lblChipset";
			lblChipset.Size = new Size(47, 15);
			lblChipset.TabIndex = 59;
			lblChipset.Text = "Chipset";
			// 
			// tbxSocketType
			// 
			tbxSocketType.BackColor = Color.FromArgb(4, 41, 58);
			tbxSocketType.BorderStyle = BorderStyle.FixedSingle;
			tbxSocketType.ForeColor = Color.FromArgb(236, 179, 101);
			tbxSocketType.Location = new Point(338, 71);
			tbxSocketType.Margin = new Padding(3, 2, 3, 2);
			tbxSocketType.MaxLength = 20;
			tbxSocketType.Name = "tbxSocketType";
			tbxSocketType.Size = new Size(214, 23);
			tbxSocketType.TabIndex = 58;
			tbxSocketType.KeyPress += StringTextBoxes_KeyPress;
			// 
			// lblSocketType
			// 
			lblSocketType.AutoSize = true;
			lblSocketType.ForeColor = Color.FromArgb(236, 179, 101);
			lblSocketType.Location = new Point(338, 45);
			lblSocketType.Name = "lblSocketType";
			lblSocketType.Size = new Size(70, 15);
			lblSocketType.TabIndex = 57;
			lblSocketType.Text = "Socket Type";
			// 
			// tbxWeight
			// 
			tbxWeight.BackColor = Color.FromArgb(4, 41, 58);
			tbxWeight.BorderStyle = BorderStyle.FixedSingle;
			tbxWeight.ForeColor = Color.FromArgb(236, 179, 101);
			tbxWeight.Location = new Point(60, 377);
			tbxWeight.Margin = new Padding(3, 2, 3, 2);
			tbxWeight.MaxLength = 7;
			tbxWeight.Name = "tbxWeight";
			tbxWeight.Size = new Size(69, 23);
			tbxWeight.TabIndex = 56;
			tbxWeight.KeyPress += DoubleTextBoxes_KeyPress;
			// 
			// lblWeight
			// 
			lblWeight.AutoSize = true;
			lblWeight.ForeColor = Color.FromArgb(236, 179, 101);
			lblWeight.Location = new Point(60, 351);
			lblWeight.Name = "lblWeight";
			lblWeight.Size = new Size(70, 15);
			lblWeight.TabIndex = 55;
			lblWeight.Text = "Weight (Kg)";
			// 
			// tbxStockQuantity
			// 
			tbxStockQuantity.BackColor = Color.FromArgb(4, 41, 58);
			tbxStockQuantity.BorderStyle = BorderStyle.FixedSingle;
			tbxStockQuantity.ForeColor = Color.FromArgb(236, 179, 101);
			tbxStockQuantity.Location = new Point(60, 298);
			tbxStockQuantity.Margin = new Padding(3, 2, 3, 2);
			tbxStockQuantity.MaxLength = 7;
			tbxStockQuantity.Name = "tbxStockQuantity";
			tbxStockQuantity.Size = new Size(69, 23);
			tbxStockQuantity.TabIndex = 54;
			tbxStockQuantity.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblStockQuantity
			// 
			lblStockQuantity.AutoSize = true;
			lblStockQuantity.ForeColor = Color.FromArgb(236, 179, 101);
			lblStockQuantity.Location = new Point(60, 272);
			lblStockQuantity.Name = "lblStockQuantity";
			lblStockQuantity.Size = new Size(85, 15);
			lblStockQuantity.TabIndex = 53;
			lblStockQuantity.Text = "Stock Quantity";
			// 
			// tbxPrice
			// 
			tbxPrice.BackColor = Color.FromArgb(4, 41, 58);
			tbxPrice.BorderStyle = BorderStyle.FixedSingle;
			tbxPrice.ForeColor = Color.FromArgb(236, 179, 101);
			tbxPrice.Location = new Point(60, 222);
			tbxPrice.Margin = new Padding(3, 2, 3, 2);
			tbxPrice.MaxLength = 7;
			tbxPrice.Name = "tbxPrice";
			tbxPrice.Size = new Size(69, 23);
			tbxPrice.TabIndex = 52;
			tbxPrice.KeyPress += DoubleTextBoxes_KeyPress;
			// 
			// lblPrice
			// 
			lblPrice.AutoSize = true;
			lblPrice.ForeColor = Color.FromArgb(236, 179, 101);
			lblPrice.Location = new Point(60, 196);
			lblPrice.Name = "lblPrice";
			lblPrice.Size = new Size(33, 15);
			lblPrice.TabIndex = 51;
			lblPrice.Text = "Price";
			// 
			// tbxManufacturer
			// 
			tbxManufacturer.BackColor = Color.FromArgb(4, 41, 58);
			tbxManufacturer.BorderStyle = BorderStyle.FixedSingle;
			tbxManufacturer.ForeColor = Color.FromArgb(236, 179, 101);
			tbxManufacturer.Location = new Point(60, 146);
			tbxManufacturer.Margin = new Padding(3, 2, 3, 2);
			tbxManufacturer.MaxLength = 15;
			tbxManufacturer.Name = "tbxManufacturer";
			tbxManufacturer.Size = new Size(214, 23);
			tbxManufacturer.TabIndex = 50;
			tbxManufacturer.KeyPress += StringTextBoxes_KeyPress;
			// 
			// lblManufacturer
			// 
			lblManufacturer.AutoSize = true;
			lblManufacturer.ForeColor = Color.FromArgb(236, 179, 101);
			lblManufacturer.Location = new Point(60, 120);
			lblManufacturer.Name = "lblManufacturer";
			lblManufacturer.Size = new Size(79, 15);
			lblManufacturer.TabIndex = 49;
			lblManufacturer.Text = "Manufacturer";
			// 
			// tbxName
			// 
			tbxName.BackColor = Color.FromArgb(4, 41, 58);
			tbxName.BorderStyle = BorderStyle.FixedSingle;
			tbxName.ForeColor = Color.FromArgb(236, 179, 101);
			tbxName.Location = new Point(60, 71);
			tbxName.Margin = new Padding(3, 2, 3, 2);
			tbxName.MaxLength = 40;
			tbxName.Name = "tbxName";
			tbxName.Size = new Size(214, 23);
			tbxName.TabIndex = 48;
			tbxName.KeyPress += StringTextBoxes_KeyPress;
			// 
			// lblName
			// 
			lblName.AutoSize = true;
			lblName.ForeColor = Color.FromArgb(236, 179, 101);
			lblName.Location = new Point(60, 45);
			lblName.Name = "lblName";
			lblName.Size = new Size(39, 15);
			lblName.TabIndex = 47;
			lblName.Text = "Name";
			// 
			// cbFormFactor
			// 
			cbFormFactor.BackColor = Color.FromArgb(4, 41, 58);
			cbFormFactor.DropDownStyle = ComboBoxStyle.DropDownList;
			cbFormFactor.ForeColor = Color.FromArgb(236, 179, 101);
			cbFormFactor.FormattingEnabled = true;
			cbFormFactor.Items.AddRange(new object[] { "E-ATX", "ATX", "Micro-ATX", "Mini-ITX" });
			cbFormFactor.Location = new Point(338, 222);
			cbFormFactor.Margin = new Padding(3, 2, 3, 2);
			cbFormFactor.Name = "cbFormFactor";
			cbFormFactor.Size = new Size(120, 23);
			cbFormFactor.TabIndex = 85;
			// 
			// lblFormFactor
			// 
			lblFormFactor.AutoSize = true;
			lblFormFactor.ForeColor = Color.FromArgb(236, 179, 101);
			lblFormFactor.Location = new Point(338, 196);
			lblFormFactor.Name = "lblFormFactor";
			lblFormFactor.Size = new Size(71, 15);
			lblFormFactor.TabIndex = 84;
			lblFormFactor.Text = "Form Factor";
			// 
			// cbMemoryType
			// 
			cbMemoryType.BackColor = Color.FromArgb(4, 41, 58);
			cbMemoryType.DropDownStyle = ComboBoxStyle.DropDownList;
			cbMemoryType.ForeColor = Color.FromArgb(236, 179, 101);
			cbMemoryType.FormattingEnabled = true;
			cbMemoryType.Items.AddRange(new object[] { "DDR3", "DDR4", "DDR5" });
			cbMemoryType.Location = new Point(338, 298);
			cbMemoryType.Margin = new Padding(3, 2, 3, 2);
			cbMemoryType.Name = "cbMemoryType";
			cbMemoryType.Size = new Size(120, 23);
			cbMemoryType.TabIndex = 87;
			// 
			// lblMemoryType
			// 
			lblMemoryType.AutoSize = true;
			lblMemoryType.ForeColor = Color.FromArgb(236, 179, 101);
			lblMemoryType.Location = new Point(338, 272);
			lblMemoryType.Name = "lblMemoryType";
			lblMemoryType.Size = new Size(80, 15);
			lblMemoryType.TabIndex = 86;
			lblMemoryType.Text = "Memory Type";
			// 
			// tbxNumberOfM2Slots
			// 
			tbxNumberOfM2Slots.BackColor = Color.FromArgb(4, 41, 58);
			tbxNumberOfM2Slots.BorderStyle = BorderStyle.FixedSingle;
			tbxNumberOfM2Slots.ForeColor = Color.FromArgb(236, 179, 101);
			tbxNumberOfM2Slots.Location = new Point(616, 71);
			tbxNumberOfM2Slots.Margin = new Padding(3, 2, 3, 2);
			tbxNumberOfM2Slots.MaxLength = 7;
			tbxNumberOfM2Slots.Name = "tbxNumberOfM2Slots";
			tbxNumberOfM2Slots.Size = new Size(69, 23);
			tbxNumberOfM2Slots.TabIndex = 89;
			tbxNumberOfM2Slots.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblNumberOfM2Slots
			// 
			lblNumberOfM2Slots.AutoSize = true;
			lblNumberOfM2Slots.ForeColor = Color.FromArgb(236, 179, 101);
			lblNumberOfM2Slots.Location = new Point(616, 45);
			lblNumberOfM2Slots.Name = "lblNumberOfM2Slots";
			lblNumberOfM2Slots.Size = new Size(118, 15);
			lblNumberOfM2Slots.TabIndex = 88;
			lblNumberOfM2Slots.Text = "Number Of M.2 Slots";
			// 
			// cbWiFi
			// 
			cbWiFi.BackColor = Color.FromArgb(4, 41, 58);
			cbWiFi.DropDownStyle = ComboBoxStyle.DropDownList;
			cbWiFi.ForeColor = Color.FromArgb(236, 179, 101);
			cbWiFi.FormattingEnabled = true;
			cbWiFi.Items.AddRange(new object[] { "Yes", "No" });
			cbWiFi.Location = new Point(616, 377);
			cbWiFi.Margin = new Padding(3, 2, 3, 2);
			cbWiFi.Name = "cbWiFi";
			cbWiFi.Size = new Size(120, 23);
			cbWiFi.TabIndex = 90;
			// 
			// lblMotherboard
			// 
			lblMotherboard.AutoSize = true;
			lblMotherboard.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblMotherboard.ForeColor = Color.FromArgb(236, 179, 101);
			lblMotherboard.Location = new Point(12, 9);
			lblMotherboard.Name = "lblMotherboard";
			lblMotherboard.Size = new Size(111, 21);
			lblMotherboard.TabIndex = 95;
			lblMotherboard.Text = "Motherboard";
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
			panel.Size = new Size(1376, 477);
			panel.TabIndex = 96;
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
			// FormAddMotherboard
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(4, 28, 50);
			ClientSize = new Size(1376, 477);
			Controls.Add(lblMotherboard);
			Controls.Add(cbWiFi);
			Controls.Add(tbxNumberOfM2Slots);
			Controls.Add(lblNumberOfM2Slots);
			Controls.Add(cbMemoryType);
			Controls.Add(lblMemoryType);
			Controls.Add(cbFormFactor);
			Controls.Add(lblFormFactor);
			Controls.Add(lblError);
			Controls.Add(btnCancel);
			Controls.Add(btnConfirm);
			Controls.Add(panelBenchMarkInfo);
			Controls.Add(chbBenchMarkInfo);
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
			Controls.Add(tbxWeight);
			Controls.Add(lblWeight);
			Controls.Add(tbxStockQuantity);
			Controls.Add(lblStockQuantity);
			Controls.Add(tbxPrice);
			Controls.Add(lblPrice);
			Controls.Add(tbxManufacturer);
			Controls.Add(lblManufacturer);
			Controls.Add(tbxName);
			Controls.Add(lblName);
			Controls.Add(panel);
			FormBorderStyle = FormBorderStyle.None;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			Name = "FormAddMotherboard";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Add Motherboard";
			panelBenchMarkInfo.ResumeLayout(false);
			panelBenchMarkInfo.PerformLayout();
			panel.ResumeLayout(false);
			panel.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblError;
		private Button btnCancel;
		private Button btnConfirm;
		private Panel panelBenchMarkInfo;
		private TextBox tbxMaximumScore;
		private Label lblMaximumScore;
		private TextBox tbxAverageScore;
		private Label lblAverageScore;
		private TextBox tbxSource;
		private Label lblSource;
		private CheckBox chbBenchMarkInfo;
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
		private TextBox tbxWeight;
		private Label lblWeight;
		private TextBox tbxStockQuantity;
		private Label lblStockQuantity;
		private TextBox tbxPrice;
		private Label lblPrice;
		private TextBox tbxManufacturer;
		private Label lblManufacturer;
		private TextBox tbxName;
		private Label lblName;
		private ComboBox cbFormFactor;
		private Label lblFormFactor;
		private ComboBox cbMemoryType;
		private Label lblMemoryType;
		private TextBox tbxNumberOfM2Slots;
		private Label lblNumberOfM2Slots;
		private ComboBox cbWiFi;
		private Label lblMotherboard;
		private Panel panel;
		private Label lblCase;
	}
}