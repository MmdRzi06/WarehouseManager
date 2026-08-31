namespace WarehouseManager {
	partial class FormAddGraphicsCard {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddGraphicsCard));
			lblError = new Label();
			btnCancel = new Button();
			tbxMaximumScore = new TextBox();
			lblMaximumScore = new Label();
			tbxAverageScore = new TextBox();
			btnConfirm = new Button();
			tbxSource = new TextBox();
			lblSource = new Label();
			panelBenchMarkInfo = new Panel();
			lblAverageScore = new Label();
			chbBenchMarkInfo = new CheckBox();
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
			tbxArchitecture = new TextBox();
			lblArchitecture = new Label();
			cbMemoryType = new ComboBox();
			lblMemoryType = new Label();
			cbPCIeGeneration = new ComboBox();
			lvlPCIeGeneration = new Label();
			tbxNumberOfDisplayPorts = new TextBox();
			lblNumberOfDisplayPorts = new Label();
			tbxNumberOfHDMIPorts = new TextBox();
			lblNumberOfHDMIPorts = new Label();
			tbxTDP = new TextBox();
			lblTDP = new Label();
			lblGraphicsCard = new Label();
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
			// tbxNumberOfPCIeLanes
			// 
			tbxNumberOfPCIeLanes.BackColor = Color.FromArgb(4, 41, 58);
			tbxNumberOfPCIeLanes.BorderStyle = BorderStyle.FixedSingle;
			tbxNumberOfPCIeLanes.ForeColor = Color.FromArgb(236, 179, 101);
			tbxNumberOfPCIeLanes.Location = new Point(616, 377);
			tbxNumberOfPCIeLanes.Margin = new Padding(3, 2, 3, 2);
			tbxNumberOfPCIeLanes.MaxLength = 7;
			tbxNumberOfPCIeLanes.Name = "tbxNumberOfPCIeLanes";
			tbxNumberOfPCIeLanes.Size = new Size(69, 23);
			tbxNumberOfPCIeLanes.TabIndex = 72;
			tbxNumberOfPCIeLanes.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblNumberOfPCIeLanes
			// 
			lblNumberOfPCIeLanes.AutoSize = true;
			lblNumberOfPCIeLanes.ForeColor = Color.FromArgb(236, 179, 101);
			lblNumberOfPCIeLanes.Location = new Point(616, 351);
			lblNumberOfPCIeLanes.Name = "lblNumberOfPCIeLanes";
			lblNumberOfPCIeLanes.Size = new Size(127, 15);
			lblNumberOfPCIeLanes.TabIndex = 71;
			lblNumberOfPCIeLanes.Text = "Number Of PCIe Lanes";
			// 
			// tbxMemoryCapacity
			// 
			tbxMemoryCapacity.BackColor = Color.FromArgb(4, 41, 58);
			tbxMemoryCapacity.BorderStyle = BorderStyle.FixedSingle;
			tbxMemoryCapacity.ForeColor = Color.FromArgb(236, 179, 101);
			tbxMemoryCapacity.Location = new Point(616, 146);
			tbxMemoryCapacity.Margin = new Padding(3, 2, 3, 2);
			tbxMemoryCapacity.MaxLength = 7;
			tbxMemoryCapacity.Name = "tbxMemoryCapacity";
			tbxMemoryCapacity.Size = new Size(69, 23);
			tbxMemoryCapacity.TabIndex = 70;
			tbxMemoryCapacity.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblMemoryCapacity
			// 
			lblMemoryCapacity.AutoSize = true;
			lblMemoryCapacity.ForeColor = Color.FromArgb(236, 179, 101);
			lblMemoryCapacity.Location = new Point(616, 120);
			lblMemoryCapacity.Name = "lblMemoryCapacity";
			lblMemoryCapacity.Size = new Size(127, 15);
			lblMemoryCapacity.TabIndex = 69;
			lblMemoryCapacity.Text = "Memory Capacity (GB)";
			// 
			// tbxBoostClock
			// 
			tbxBoostClock.BackColor = Color.FromArgb(4, 41, 58);
			tbxBoostClock.BorderStyle = BorderStyle.FixedSingle;
			tbxBoostClock.ForeColor = Color.FromArgb(236, 179, 101);
			tbxBoostClock.Location = new Point(616, 71);
			tbxBoostClock.Margin = new Padding(3, 2, 3, 2);
			tbxBoostClock.MaxLength = 7;
			tbxBoostClock.Name = "tbxBoostClock";
			tbxBoostClock.Size = new Size(69, 23);
			tbxBoostClock.TabIndex = 68;
			tbxBoostClock.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblBoostClock
			// 
			lblBoostClock.AutoSize = true;
			lblBoostClock.ForeColor = Color.FromArgb(236, 179, 101);
			lblBoostClock.Location = new Point(616, 45);
			lblBoostClock.Name = "lblBoostClock";
			lblBoostClock.Size = new Size(106, 15);
			lblBoostClock.TabIndex = 67;
			lblBoostClock.Text = "Boost Clock (MHz)";
			// 
			// tbxBaseClock
			// 
			tbxBaseClock.BackColor = Color.FromArgb(4, 41, 58);
			tbxBaseClock.BorderStyle = BorderStyle.FixedSingle;
			tbxBaseClock.ForeColor = Color.FromArgb(236, 179, 101);
			tbxBaseClock.Location = new Point(339, 377);
			tbxBaseClock.Margin = new Padding(3, 2, 3, 2);
			tbxBaseClock.MaxLength = 7;
			tbxBaseClock.Name = "tbxBaseClock";
			tbxBaseClock.Size = new Size(69, 23);
			tbxBaseClock.TabIndex = 66;
			tbxBaseClock.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblBaseClock
			// 
			lblBaseClock.AutoSize = true;
			lblBaseClock.ForeColor = Color.FromArgb(236, 179, 101);
			lblBaseClock.Location = new Point(339, 351);
			lblBaseClock.Name = "lblBaseClock";
			lblBaseClock.Size = new Size(100, 15);
			lblBaseClock.TabIndex = 65;
			lblBaseClock.Text = "Base Clock (MHz)";
			// 
			// tbxNumberOfCores
			// 
			tbxNumberOfCores.BackColor = Color.FromArgb(4, 41, 58);
			tbxNumberOfCores.BorderStyle = BorderStyle.FixedSingle;
			tbxNumberOfCores.ForeColor = Color.FromArgb(236, 179, 101);
			tbxNumberOfCores.Location = new Point(339, 298);
			tbxNumberOfCores.Margin = new Padding(3, 2, 3, 2);
			tbxNumberOfCores.MaxLength = 7;
			tbxNumberOfCores.Name = "tbxNumberOfCores";
			tbxNumberOfCores.Size = new Size(69, 23);
			tbxNumberOfCores.TabIndex = 64;
			tbxNumberOfCores.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblNumberOfCores
			// 
			lblNumberOfCores.AutoSize = true;
			lblNumberOfCores.ForeColor = Color.FromArgb(236, 179, 101);
			lblNumberOfCores.Location = new Point(339, 272);
			lblNumberOfCores.Name = "lblNumberOfCores";
			lblNumberOfCores.Size = new Size(100, 15);
			lblNumberOfCores.TabIndex = 63;
			lblNumberOfCores.Text = "Number Of Cores";
			// 
			// tbxChipModel
			// 
			tbxChipModel.BackColor = Color.FromArgb(4, 41, 58);
			tbxChipModel.BorderStyle = BorderStyle.FixedSingle;
			tbxChipModel.ForeColor = Color.FromArgb(236, 179, 101);
			tbxChipModel.Location = new Point(338, 146);
			tbxChipModel.Margin = new Padding(3, 2, 3, 2);
			tbxChipModel.MaxLength = 20;
			tbxChipModel.Name = "tbxChipModel";
			tbxChipModel.Size = new Size(214, 23);
			tbxChipModel.TabIndex = 60;
			tbxChipModel.KeyPress += StringTextBoxes_KeyPress;
			// 
			// lblChipModel
			// 
			lblChipModel.AutoSize = true;
			lblChipModel.ForeColor = Color.FromArgb(236, 179, 101);
			lblChipModel.Location = new Point(338, 120);
			lblChipModel.Name = "lblChipModel";
			lblChipModel.Size = new Size(69, 15);
			lblChipModel.TabIndex = 59;
			lblChipModel.Text = "Chip Model";
			// 
			// tbxGPUManufacturer
			// 
			tbxGPUManufacturer.BackColor = Color.FromArgb(4, 41, 58);
			tbxGPUManufacturer.BorderStyle = BorderStyle.FixedSingle;
			tbxGPUManufacturer.ForeColor = Color.FromArgb(236, 179, 101);
			tbxGPUManufacturer.Location = new Point(338, 71);
			tbxGPUManufacturer.Margin = new Padding(3, 2, 3, 2);
			tbxGPUManufacturer.MaxLength = 20;
			tbxGPUManufacturer.Name = "tbxGPUManufacturer";
			tbxGPUManufacturer.Size = new Size(214, 23);
			tbxGPUManufacturer.TabIndex = 58;
			tbxGPUManufacturer.KeyPress += StringTextBoxes_KeyPress;
			// 
			// lblGPUManufacturer
			// 
			lblGPUManufacturer.AutoSize = true;
			lblGPUManufacturer.ForeColor = Color.FromArgb(236, 179, 101);
			lblGPUManufacturer.Location = new Point(338, 45);
			lblGPUManufacturer.Name = "lblGPUManufacturer";
			lblGPUManufacturer.Size = new Size(105, 15);
			lblGPUManufacturer.TabIndex = 57;
			lblGPUManufacturer.Text = "GPU Manufacturer";
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
			// tbxArchitecture
			// 
			tbxArchitecture.BackColor = Color.FromArgb(4, 41, 58);
			tbxArchitecture.BorderStyle = BorderStyle.FixedSingle;
			tbxArchitecture.ForeColor = Color.FromArgb(236, 179, 101);
			tbxArchitecture.Location = new Point(338, 222);
			tbxArchitecture.Margin = new Padding(3, 2, 3, 2);
			tbxArchitecture.MaxLength = 20;
			tbxArchitecture.Name = "tbxArchitecture";
			tbxArchitecture.Size = new Size(214, 23);
			tbxArchitecture.TabIndex = 85;
			tbxArchitecture.KeyPress += StringTextBoxes_KeyPress;
			// 
			// lblArchitecture
			// 
			lblArchitecture.AutoSize = true;
			lblArchitecture.ForeColor = Color.FromArgb(236, 179, 101);
			lblArchitecture.Location = new Point(338, 196);
			lblArchitecture.Name = "lblArchitecture";
			lblArchitecture.Size = new Size(72, 15);
			lblArchitecture.TabIndex = 84;
			lblArchitecture.Text = "Architecture";
			// 
			// cbMemoryType
			// 
			cbMemoryType.BackColor = Color.FromArgb(4, 41, 58);
			cbMemoryType.DropDownStyle = ComboBoxStyle.DropDownList;
			cbMemoryType.ForeColor = Color.FromArgb(236, 179, 101);
			cbMemoryType.FormattingEnabled = true;
			cbMemoryType.Items.AddRange(new object[] { "GDDR6", "GDDR6X", "GDDR7" });
			cbMemoryType.Location = new Point(616, 222);
			cbMemoryType.Margin = new Padding(3, 2, 3, 2);
			cbMemoryType.Name = "cbMemoryType";
			cbMemoryType.Size = new Size(120, 23);
			cbMemoryType.TabIndex = 87;
			// 
			// lblMemoryType
			// 
			lblMemoryType.AutoSize = true;
			lblMemoryType.ForeColor = Color.FromArgb(236, 179, 101);
			lblMemoryType.Location = new Point(616, 196);
			lblMemoryType.Name = "lblMemoryType";
			lblMemoryType.Size = new Size(80, 15);
			lblMemoryType.TabIndex = 86;
			lblMemoryType.Text = "Memory Type";
			// 
			// cbPCIeGeneration
			// 
			cbPCIeGeneration.BackColor = Color.FromArgb(4, 41, 58);
			cbPCIeGeneration.DropDownStyle = ComboBoxStyle.DropDownList;
			cbPCIeGeneration.ForeColor = Color.FromArgb(236, 179, 101);
			cbPCIeGeneration.FormattingEnabled = true;
			cbPCIeGeneration.Items.AddRange(new object[] { "PCIe 3.0", "PCIe 4.0", "PCIe 5.0", "PCIe 6.0" });
			cbPCIeGeneration.Location = new Point(616, 298);
			cbPCIeGeneration.Margin = new Padding(3, 2, 3, 2);
			cbPCIeGeneration.Name = "cbPCIeGeneration";
			cbPCIeGeneration.Size = new Size(120, 23);
			cbPCIeGeneration.TabIndex = 89;
			// 
			// lvlPCIeGeneration
			// 
			lvlPCIeGeneration.AutoSize = true;
			lvlPCIeGeneration.ForeColor = Color.FromArgb(236, 179, 101);
			lvlPCIeGeneration.Location = new Point(616, 272);
			lvlPCIeGeneration.Name = "lvlPCIeGeneration";
			lvlPCIeGeneration.Size = new Size(92, 15);
			lvlPCIeGeneration.TabIndex = 88;
			lvlPCIeGeneration.Text = "PCIe Generation";
			// 
			// tbxNumberOfDisplayPorts
			// 
			tbxNumberOfDisplayPorts.BackColor = Color.FromArgb(4, 41, 58);
			tbxNumberOfDisplayPorts.BorderStyle = BorderStyle.FixedSingle;
			tbxNumberOfDisplayPorts.ForeColor = Color.FromArgb(236, 179, 101);
			tbxNumberOfDisplayPorts.Location = new Point(778, 146);
			tbxNumberOfDisplayPorts.Margin = new Padding(3, 2, 3, 2);
			tbxNumberOfDisplayPorts.MaxLength = 7;
			tbxNumberOfDisplayPorts.Name = "tbxNumberOfDisplayPorts";
			tbxNumberOfDisplayPorts.Size = new Size(69, 23);
			tbxNumberOfDisplayPorts.TabIndex = 91;
			tbxNumberOfDisplayPorts.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblNumberOfDisplayPorts
			// 
			lblNumberOfDisplayPorts.AutoSize = true;
			lblNumberOfDisplayPorts.ForeColor = Color.FromArgb(236, 179, 101);
			lblNumberOfDisplayPorts.Location = new Point(778, 120);
			lblNumberOfDisplayPorts.Name = "lblNumberOfDisplayPorts";
			lblNumberOfDisplayPorts.Size = new Size(135, 15);
			lblNumberOfDisplayPorts.TabIndex = 90;
			lblNumberOfDisplayPorts.Text = "Number Of DisplayPorts";
			// 
			// tbxNumberOfHDMIPorts
			// 
			tbxNumberOfHDMIPorts.BackColor = Color.FromArgb(4, 41, 58);
			tbxNumberOfHDMIPorts.BorderStyle = BorderStyle.FixedSingle;
			tbxNumberOfHDMIPorts.ForeColor = Color.FromArgb(236, 179, 101);
			tbxNumberOfHDMIPorts.Location = new Point(778, 222);
			tbxNumberOfHDMIPorts.Margin = new Padding(3, 2, 3, 2);
			tbxNumberOfHDMIPorts.MaxLength = 7;
			tbxNumberOfHDMIPorts.Name = "tbxNumberOfHDMIPorts";
			tbxNumberOfHDMIPorts.Size = new Size(69, 23);
			tbxNumberOfHDMIPorts.TabIndex = 93;
			tbxNumberOfHDMIPorts.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblNumberOfHDMIPorts
			// 
			lblNumberOfHDMIPorts.AutoSize = true;
			lblNumberOfHDMIPorts.ForeColor = Color.FromArgb(236, 179, 101);
			lblNumberOfHDMIPorts.Location = new Point(778, 196);
			lblNumberOfHDMIPorts.Name = "lblNumberOfHDMIPorts";
			lblNumberOfHDMIPorts.Size = new Size(131, 15);
			lblNumberOfHDMIPorts.TabIndex = 92;
			lblNumberOfHDMIPorts.Text = "Number Of HDMI Ports";
			// 
			// tbxTDP
			// 
			tbxTDP.BackColor = Color.FromArgb(4, 41, 58);
			tbxTDP.BorderStyle = BorderStyle.FixedSingle;
			tbxTDP.ForeColor = Color.FromArgb(236, 179, 101);
			tbxTDP.Location = new Point(778, 71);
			tbxTDP.Margin = new Padding(3, 2, 3, 2);
			tbxTDP.MaxLength = 7;
			tbxTDP.Name = "tbxTDP";
			tbxTDP.Size = new Size(69, 23);
			tbxTDP.TabIndex = 95;
			tbxTDP.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblTDP
			// 
			lblTDP.AutoSize = true;
			lblTDP.ForeColor = Color.FromArgb(236, 179, 101);
			lblTDP.Location = new Point(778, 45);
			lblTDP.Name = "lblTDP";
			lblTDP.Size = new Size(51, 15);
			lblTDP.TabIndex = 94;
			lblTDP.Text = "TDP (W)";
			// 
			// lblGraphicsCard
			// 
			lblGraphicsCard.AutoSize = true;
			lblGraphicsCard.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblGraphicsCard.ForeColor = Color.FromArgb(236, 179, 101);
			lblGraphicsCard.Location = new Point(12, 9);
			lblGraphicsCard.Name = "lblGraphicsCard";
			lblGraphicsCard.Size = new Size(115, 21);
			lblGraphicsCard.TabIndex = 96;
			lblGraphicsCard.Text = "Graphics Card";
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
			panel.TabIndex = 97;
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
			// FormAddGraphicsCard
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(4, 28, 50);
			ClientSize = new Size(1376, 477);
			Controls.Add(lblGraphicsCard);
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
			Controls.Add(lblError);
			Controls.Add(btnCancel);
			Controls.Add(btnConfirm);
			Controls.Add(panelBenchMarkInfo);
			Controls.Add(chbBenchMarkInfo);
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
			Name = "FormAddGraphicsCard";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Add Graphics Card";
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
		private TextBox tbxMaximumScore;
		private Label lblMaximumScore;
		private TextBox tbxAverageScore;
		private Button btnConfirm;
		private TextBox tbxSource;
		private Label lblSource;
		private Panel panelBenchMarkInfo;
		private Label lblAverageScore;
		private CheckBox chbBenchMarkInfo;
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
		private TextBox tbxArchitecture;
		private Label lblArchitecture;
		private ComboBox cbMemoryType;
		private Label lblMemoryType;
		private ComboBox cbPCIeGeneration;
		private Label lvlPCIeGeneration;
		private TextBox tbxNumberOfDisplayPorts;
		private Label lblNumberOfDisplayPorts;
		private TextBox tbxNumberOfHDMIPorts;
		private Label lblNumberOfHDMIPorts;
		private TextBox tbxTDP;
		private Label lblTDP;
		private Label lblGraphicsCard;
		private Panel panel;
		private Label lblCase;
	}
}