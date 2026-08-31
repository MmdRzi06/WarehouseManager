namespace WarehouseManager {
	partial class FormAddCPU {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddCPU));
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
			tbxNumberOfCores = new TextBox();
			lblNumberOfCores = new Label();
			tbxNumberOfThreads = new TextBox();
			lblNumberOfThreads = new Label();
			tbxBaseClock = new TextBox();
			lblBaseClock = new Label();
			tbxBoostClock = new TextBox();
			lblBoostClock = new Label();
			tbxL3CacheSize = new TextBox();
			lblL3CacheSize = new Label();
			tbxTDP = new TextBox();
			lblTDP = new Label();
			tbxNumberOfMemoryChannels = new TextBox();
			lblNumberOfMemoryChannels = new Label();
			tbxMaximumSupportedMemoryCapacity = new TextBox();
			lblMaximumSupportedMemoryCapacity = new Label();
			cbOverclockingSupport = new ComboBox();
			lblOverclockingSupport = new Label();
			panelBenchMarkInfo = new Panel();
			tbxMaximumScore = new TextBox();
			lblMaximumScore = new Label();
			tbxAverageScore = new TextBox();
			lblAverageScore = new Label();
			tbxSource = new TextBox();
			lblSource = new Label();
			chbBenchMarkInfo = new CheckBox();
			btnCancel = new Button();
			btnConfirm = new Button();
			lblError = new Label();
			lblSocketType = new Label();
			tbxSocketType = new TextBox();
			lblMicroarchitecture = new Label();
			tbxMicroarchitecture = new TextBox();
			lblCPU = new Label();
			panel = new Panel();
			lblCase = new Label();
			panelBenchMarkInfo.SuspendLayout();
			panel.SuspendLayout();
			SuspendLayout();
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
			tbxWeight.TabIndex = 19;
			tbxWeight.KeyPress += DoubleTextBoxes_KeyPress;
			// 
			// lblWeight
			// 
			lblWeight.AutoSize = true;
			lblWeight.ForeColor = Color.FromArgb(236, 179, 101);
			lblWeight.Location = new Point(60, 351);
			lblWeight.Name = "lblWeight";
			lblWeight.Size = new Size(70, 15);
			lblWeight.TabIndex = 18;
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
			tbxStockQuantity.TabIndex = 17;
			tbxStockQuantity.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblStockQuantity
			// 
			lblStockQuantity.AutoSize = true;
			lblStockQuantity.ForeColor = Color.FromArgb(236, 179, 101);
			lblStockQuantity.Location = new Point(60, 272);
			lblStockQuantity.Name = "lblStockQuantity";
			lblStockQuantity.Size = new Size(85, 15);
			lblStockQuantity.TabIndex = 16;
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
			tbxPrice.TabIndex = 15;
			tbxPrice.KeyPress += DoubleTextBoxes_KeyPress;
			// 
			// lblPrice
			// 
			lblPrice.AutoSize = true;
			lblPrice.ForeColor = Color.FromArgb(236, 179, 101);
			lblPrice.Location = new Point(60, 196);
			lblPrice.Name = "lblPrice";
			lblPrice.Size = new Size(33, 15);
			lblPrice.TabIndex = 14;
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
			tbxManufacturer.TabIndex = 13;
			tbxManufacturer.KeyPress += StringTextBoxes_KeyPress;
			// 
			// lblManufacturer
			// 
			lblManufacturer.AutoSize = true;
			lblManufacturer.ForeColor = Color.FromArgb(236, 179, 101);
			lblManufacturer.Location = new Point(60, 120);
			lblManufacturer.Name = "lblManufacturer";
			lblManufacturer.Size = new Size(79, 15);
			lblManufacturer.TabIndex = 12;
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
			tbxName.TabIndex = 11;
			tbxName.KeyPress += StringTextBoxes_KeyPress;
			// 
			// lblName
			// 
			lblName.AutoSize = true;
			lblName.ForeColor = Color.FromArgb(236, 179, 101);
			lblName.Location = new Point(60, 45);
			lblName.Name = "lblName";
			lblName.Size = new Size(39, 15);
			lblName.TabIndex = 10;
			lblName.Text = "Name";
			// 
			// tbxNumberOfCores
			// 
			tbxNumberOfCores.BackColor = Color.FromArgb(4, 41, 58);
			tbxNumberOfCores.BorderStyle = BorderStyle.FixedSingle;
			tbxNumberOfCores.ForeColor = Color.FromArgb(236, 179, 101);
			tbxNumberOfCores.Location = new Point(339, 222);
			tbxNumberOfCores.Margin = new Padding(3, 2, 3, 2);
			tbxNumberOfCores.MaxLength = 7;
			tbxNumberOfCores.Name = "tbxNumberOfCores";
			tbxNumberOfCores.Size = new Size(69, 23);
			tbxNumberOfCores.TabIndex = 25;
			tbxNumberOfCores.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblNumberOfCores
			// 
			lblNumberOfCores.AutoSize = true;
			lblNumberOfCores.ForeColor = Color.FromArgb(236, 179, 101);
			lblNumberOfCores.Location = new Point(339, 196);
			lblNumberOfCores.Name = "lblNumberOfCores";
			lblNumberOfCores.Size = new Size(100, 15);
			lblNumberOfCores.TabIndex = 24;
			lblNumberOfCores.Text = "Number Of Cores";
			// 
			// tbxNumberOfThreads
			// 
			tbxNumberOfThreads.BackColor = Color.FromArgb(4, 41, 58);
			tbxNumberOfThreads.BorderStyle = BorderStyle.FixedSingle;
			tbxNumberOfThreads.ForeColor = Color.FromArgb(236, 179, 101);
			tbxNumberOfThreads.Location = new Point(339, 298);
			tbxNumberOfThreads.Margin = new Padding(3, 2, 3, 2);
			tbxNumberOfThreads.MaxLength = 7;
			tbxNumberOfThreads.Name = "tbxNumberOfThreads";
			tbxNumberOfThreads.Size = new Size(69, 23);
			tbxNumberOfThreads.TabIndex = 27;
			tbxNumberOfThreads.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblNumberOfThreads
			// 
			lblNumberOfThreads.AutoSize = true;
			lblNumberOfThreads.ForeColor = Color.FromArgb(236, 179, 101);
			lblNumberOfThreads.Location = new Point(339, 272);
			lblNumberOfThreads.Name = "lblNumberOfThreads";
			lblNumberOfThreads.Size = new Size(112, 15);
			lblNumberOfThreads.TabIndex = 26;
			lblNumberOfThreads.Text = "Number Of Threads";
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
			tbxBaseClock.TabIndex = 29;
			tbxBaseClock.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblBaseClock
			// 
			lblBaseClock.AutoSize = true;
			lblBaseClock.ForeColor = Color.FromArgb(236, 179, 101);
			lblBaseClock.Location = new Point(339, 351);
			lblBaseClock.Name = "lblBaseClock";
			lblBaseClock.Size = new Size(100, 15);
			lblBaseClock.TabIndex = 28;
			lblBaseClock.Text = "Base Clock (MHz)";
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
			tbxBoostClock.TabIndex = 31;
			tbxBoostClock.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblBoostClock
			// 
			lblBoostClock.AutoSize = true;
			lblBoostClock.ForeColor = Color.FromArgb(236, 179, 101);
			lblBoostClock.Location = new Point(616, 45);
			lblBoostClock.Name = "lblBoostClock";
			lblBoostClock.Size = new Size(106, 15);
			lblBoostClock.TabIndex = 30;
			lblBoostClock.Text = "Boost Clock (MHz)";
			// 
			// tbxL3CacheSize
			// 
			tbxL3CacheSize.BackColor = Color.FromArgb(4, 41, 58);
			tbxL3CacheSize.BorderStyle = BorderStyle.FixedSingle;
			tbxL3CacheSize.ForeColor = Color.FromArgb(236, 179, 101);
			tbxL3CacheSize.Location = new Point(616, 146);
			tbxL3CacheSize.Margin = new Padding(3, 2, 3, 2);
			tbxL3CacheSize.MaxLength = 7;
			tbxL3CacheSize.Name = "tbxL3CacheSize";
			tbxL3CacheSize.Size = new Size(69, 23);
			tbxL3CacheSize.TabIndex = 33;
			tbxL3CacheSize.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblL3CacheSize
			// 
			lblL3CacheSize.AutoSize = true;
			lblL3CacheSize.ForeColor = Color.FromArgb(236, 179, 101);
			lblL3CacheSize.Location = new Point(616, 120);
			lblL3CacheSize.Name = "lblL3CacheSize";
			lblL3CacheSize.Size = new Size(107, 15);
			lblL3CacheSize.TabIndex = 32;
			lblL3CacheSize.Text = "L3 Cache Size (MB)";
			// 
			// tbxTDP
			// 
			tbxTDP.BackColor = Color.FromArgb(4, 41, 58);
			tbxTDP.BorderStyle = BorderStyle.FixedSingle;
			tbxTDP.ForeColor = Color.FromArgb(236, 179, 101);
			tbxTDP.Location = new Point(616, 377);
			tbxTDP.Margin = new Padding(3, 2, 3, 2);
			tbxTDP.MaxLength = 7;
			tbxTDP.Name = "tbxTDP";
			tbxTDP.Size = new Size(69, 23);
			tbxTDP.TabIndex = 35;
			tbxTDP.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblTDP
			// 
			lblTDP.AutoSize = true;
			lblTDP.ForeColor = Color.FromArgb(236, 179, 101);
			lblTDP.Location = new Point(616, 351);
			lblTDP.Name = "lblTDP";
			lblTDP.Size = new Size(51, 15);
			lblTDP.TabIndex = 34;
			lblTDP.Text = "TDP (W)";
			// 
			// tbxNumberOfMemoryChannels
			// 
			tbxNumberOfMemoryChannels.BackColor = Color.FromArgb(4, 41, 58);
			tbxNumberOfMemoryChannels.BorderStyle = BorderStyle.FixedSingle;
			tbxNumberOfMemoryChannels.ForeColor = Color.FromArgb(236, 179, 101);
			tbxNumberOfMemoryChannels.Location = new Point(616, 298);
			tbxNumberOfMemoryChannels.Margin = new Padding(3, 2, 3, 2);
			tbxNumberOfMemoryChannels.MaxLength = 7;
			tbxNumberOfMemoryChannels.Name = "tbxNumberOfMemoryChannels";
			tbxNumberOfMemoryChannels.Size = new Size(69, 23);
			tbxNumberOfMemoryChannels.TabIndex = 37;
			tbxNumberOfMemoryChannels.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblNumberOfMemoryChannels
			// 
			lblNumberOfMemoryChannels.AutoSize = true;
			lblNumberOfMemoryChannels.ForeColor = Color.FromArgb(236, 179, 101);
			lblNumberOfMemoryChannels.Location = new Point(616, 272);
			lblNumberOfMemoryChannels.Name = "lblNumberOfMemoryChannels";
			lblNumberOfMemoryChannels.Size = new Size(167, 15);
			lblNumberOfMemoryChannels.TabIndex = 36;
			lblNumberOfMemoryChannels.Text = "Number Of Memory Channels";
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
			tbxMaximumSupportedMemoryCapacity.TabIndex = 39;
			tbxMaximumSupportedMemoryCapacity.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblMaximumSupportedMemoryCapacity
			// 
			lblMaximumSupportedMemoryCapacity.AutoSize = true;
			lblMaximumSupportedMemoryCapacity.ForeColor = Color.FromArgb(236, 179, 101);
			lblMaximumSupportedMemoryCapacity.Location = new Point(616, 196);
			lblMaximumSupportedMemoryCapacity.Name = "lblMaximumSupportedMemoryCapacity";
			lblMaximumSupportedMemoryCapacity.Size = new Size(242, 15);
			lblMaximumSupportedMemoryCapacity.TabIndex = 38;
			lblMaximumSupportedMemoryCapacity.Text = "Maximum Supported Memory Capacity (GB)";
			// 
			// cbOverclockingSupport
			// 
			cbOverclockingSupport.BackColor = Color.FromArgb(4, 41, 58);
			cbOverclockingSupport.DropDownStyle = ComboBoxStyle.DropDownList;
			cbOverclockingSupport.ForeColor = Color.FromArgb(236, 179, 101);
			cbOverclockingSupport.FormattingEnabled = true;
			cbOverclockingSupport.Items.AddRange(new object[] { "Yes", "No" });
			cbOverclockingSupport.Location = new Point(778, 71);
			cbOverclockingSupport.Margin = new Padding(3, 2, 3, 2);
			cbOverclockingSupport.Name = "cbOverclockingSupport";
			cbOverclockingSupport.Size = new Size(120, 23);
			cbOverclockingSupport.TabIndex = 41;
			// 
			// lblOverclockingSupport
			// 
			lblOverclockingSupport.AutoSize = true;
			lblOverclockingSupport.ForeColor = Color.FromArgb(236, 179, 101);
			lblOverclockingSupport.Location = new Point(778, 45);
			lblOverclockingSupport.Name = "lblOverclockingSupport";
			lblOverclockingSupport.Size = new Size(122, 15);
			lblOverclockingSupport.TabIndex = 40;
			lblOverclockingSupport.Text = "Overclocking Support";
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
			panelBenchMarkInfo.TabIndex = 43;
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
			chbBenchMarkInfo.TabIndex = 42;
			chbBenchMarkInfo.Text = "Benchmark Information";
			chbBenchMarkInfo.UseVisualStyleBackColor = true;
			chbBenchMarkInfo.CheckedChanged += chbBenchMarkInfo_CheckedChanged;
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
			btnCancel.TabIndex = 45;
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
			btnConfirm.TabIndex = 44;
			btnConfirm.Text = "Confirm";
			btnConfirm.UseVisualStyleBackColor = false;
			btnConfirm.Click += btnConfirm_Click;
			// 
			// lblError
			// 
			lblError.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblError.ForeColor = Color.FromArgb(244, 43, 50);
			lblError.Location = new Point(716, 428);
			lblError.Name = "lblError";
			lblError.Size = new Size(406, 36);
			lblError.TabIndex = 46;
			lblError.Text = "\r\n";
			// 
			// lblSocketType
			// 
			lblSocketType.AutoSize = true;
			lblSocketType.ForeColor = Color.FromArgb(236, 179, 101);
			lblSocketType.Location = new Point(338, 45);
			lblSocketType.Name = "lblSocketType";
			lblSocketType.Size = new Size(70, 15);
			lblSocketType.TabIndex = 20;
			lblSocketType.Text = "Socket Type";
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
			tbxSocketType.TabIndex = 21;
			tbxSocketType.KeyPress += StringTextBoxes_KeyPress;
			// 
			// lblMicroarchitecture
			// 
			lblMicroarchitecture.AutoSize = true;
			lblMicroarchitecture.ForeColor = Color.FromArgb(236, 179, 101);
			lblMicroarchitecture.Location = new Point(338, 120);
			lblMicroarchitecture.Name = "lblMicroarchitecture";
			lblMicroarchitecture.Size = new Size(101, 15);
			lblMicroarchitecture.TabIndex = 22;
			lblMicroarchitecture.Text = "Microarchitecture";
			// 
			// tbxMicroarchitecture
			// 
			tbxMicroarchitecture.BackColor = Color.FromArgb(4, 41, 58);
			tbxMicroarchitecture.BorderStyle = BorderStyle.FixedSingle;
			tbxMicroarchitecture.ForeColor = Color.FromArgb(236, 179, 101);
			tbxMicroarchitecture.Location = new Point(338, 146);
			tbxMicroarchitecture.Margin = new Padding(3, 2, 3, 2);
			tbxMicroarchitecture.MaxLength = 20;
			tbxMicroarchitecture.Name = "tbxMicroarchitecture";
			tbxMicroarchitecture.Size = new Size(214, 23);
			tbxMicroarchitecture.TabIndex = 23;
			tbxMicroarchitecture.KeyPress += StringTextBoxes_KeyPress;
			// 
			// lblCPU
			// 
			lblCPU.AutoSize = true;
			lblCPU.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblCPU.ForeColor = Color.FromArgb(236, 179, 101);
			lblCPU.Location = new Point(12, 9);
			lblCPU.Name = "lblCPU";
			lblCPU.Size = new Size(42, 21);
			lblCPU.TabIndex = 94;
			lblCPU.Text = "CPU";
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
			panel.TabIndex = 95;
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
			// FormAddCPU
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(4, 28, 50);
			ClientSize = new Size(1376, 477);
			Controls.Add(lblCPU);
			Controls.Add(lblError);
			Controls.Add(btnCancel);
			Controls.Add(btnConfirm);
			Controls.Add(panelBenchMarkInfo);
			Controls.Add(chbBenchMarkInfo);
			Controls.Add(cbOverclockingSupport);
			Controls.Add(lblOverclockingSupport);
			Controls.Add(tbxMaximumSupportedMemoryCapacity);
			Controls.Add(lblMaximumSupportedMemoryCapacity);
			Controls.Add(tbxNumberOfMemoryChannels);
			Controls.Add(lblNumberOfMemoryChannels);
			Controls.Add(tbxTDP);
			Controls.Add(lblTDP);
			Controls.Add(tbxL3CacheSize);
			Controls.Add(lblL3CacheSize);
			Controls.Add(tbxBoostClock);
			Controls.Add(lblBoostClock);
			Controls.Add(tbxBaseClock);
			Controls.Add(lblBaseClock);
			Controls.Add(tbxNumberOfThreads);
			Controls.Add(lblNumberOfThreads);
			Controls.Add(tbxNumberOfCores);
			Controls.Add(lblNumberOfCores);
			Controls.Add(tbxMicroarchitecture);
			Controls.Add(lblMicroarchitecture);
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
			Name = "FormAddCPU";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Add CPU";
			panelBenchMarkInfo.ResumeLayout(false);
			panelBenchMarkInfo.PerformLayout();
			panel.ResumeLayout(false);
			panel.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

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
		private TextBox tbxNumberOfCores;
		private Label lblNumberOfCores;
		private TextBox tbxNumberOfThreads;
		private Label lblNumberOfThreads;
		private TextBox tbxBaseClock;
		private Label lblBaseClock;
		private TextBox tbxBoostClock;
		private Label lblBoostClock;
		private TextBox tbxL3CacheSize;
		private Label lblL3CacheSize;
		private TextBox tbxTDP;
		private Label lblTDP;
		private TextBox tbxNumberOfMemoryChannels;
		private Label lblNumberOfMemoryChannels;
		private TextBox tbxMaximumSupportedMemoryCapacity;
		private Label lblMaximumSupportedMemoryCapacity;
		private ComboBox cbOverclockingSupport;
		private Label lblOverclockingSupport;
		private Panel panelBenchMarkInfo;
		private TextBox tbxMaximumScore;
		private Label lblMaximumScore;
		private TextBox tbxAverageScore;
		private Label lblAverageScore;
		private TextBox tbxSource;
		private Label lblSource;
		private CheckBox chbBenchMarkInfo;
		private Button btnCancel;
		private Button btnConfirm;
		private Label lblError;
		private Label lblSocketType;
		private TextBox tbxSocketType;
		private Label lblMicroarchitecture;
		private TextBox tbxMicroarchitecture;
		private Label lblCPU;
		private Panel panel;
		private Label lblCase;
	}
}