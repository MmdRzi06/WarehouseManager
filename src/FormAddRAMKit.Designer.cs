namespace WarehouseManager {
	partial class FormAddRAMKit {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddRAMKit));
			btnConfirm = new Button();
			tbxCASLatency = new TextBox();
			lblCASLatency = new Label();
			lblError = new Label();
			btnCancel = new Button();
			chbBenchMarkInfo = new CheckBox();
			tbxSpeed = new TextBox();
			lblSpeed = new Label();
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
			cbXMPSupport = new ComboBox();
			lblXMPSupport = new Label();
			cbEXPOSupport = new ComboBox();
			lblEXPOSupport = new Label();
			tbxNumberOfModules = new TextBox();
			lblNumberOfModules = new Label();
			tbxModuleCapacity = new TextBox();
			lblModuleCapacity = new Label();
			cbMemoryType = new ComboBox();
			lblMemoryType = new Label();
			panelBenchMarkInfo = new Panel();
			tbxMaximumScore = new TextBox();
			lblMaximumScore = new Label();
			tbxAverageScore = new TextBox();
			lblAverageScore = new Label();
			tbxSource = new TextBox();
			lblSource = new Label();
			lblRAMKit = new Label();
			panel = new Panel();
			lblCase = new Label();
			panelBenchMarkInfo.SuspendLayout();
			panel.SuspendLayout();
			SuspendLayout();
			// 
			// btnConfirm
			// 
			btnConfirm.BackColor = Color.FromArgb(4, 41, 58);
			btnConfirm.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 41, 58);
			btnConfirm.FlatAppearance.MouseOverBackColor = Color.FromArgb(6, 70, 99);
			btnConfirm.FlatStyle = FlatStyle.Flat;
			btnConfirm.ForeColor = Color.FromArgb(236, 179, 101);
			btnConfirm.Location = new Point(985, 428);
			btnConfirm.Margin = new Padding(3, 2, 3, 2);
			btnConfirm.Name = "btnConfirm";
			btnConfirm.Size = new Size(115, 38);
			btnConfirm.TabIndex = 73;
			btnConfirm.Text = "Confirm";
			btnConfirm.UseVisualStyleBackColor = false;
			btnConfirm.Click += btnConfirm_Click;
			// 
			// tbxCASLatency
			// 
			tbxCASLatency.BackColor = Color.FromArgb(4, 41, 58);
			tbxCASLatency.BorderStyle = BorderStyle.FixedSingle;
			tbxCASLatency.ForeColor = Color.FromArgb(236, 179, 101);
			tbxCASLatency.Location = new Point(339, 377);
			tbxCASLatency.Margin = new Padding(3, 2, 3, 2);
			tbxCASLatency.MaxLength = 7;
			tbxCASLatency.Name = "tbxCASLatency";
			tbxCASLatency.Size = new Size(69, 23);
			tbxCASLatency.TabIndex = 66;
			tbxCASLatency.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblCASLatency
			// 
			lblCASLatency.AutoSize = true;
			lblCASLatency.ForeColor = Color.FromArgb(236, 179, 101);
			lblCASLatency.Location = new Point(339, 351);
			lblCASLatency.Name = "lblCASLatency";
			lblCASLatency.Size = new Size(73, 15);
			lblCASLatency.TabIndex = 65;
			lblCASLatency.Text = "CAS Latency";
			// 
			// lblError
			// 
			lblError.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblError.ForeColor = Color.FromArgb(244, 43, 50);
			lblError.Location = new Point(452, 428);
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
			btnCancel.Location = new Point(864, 428);
			btnCancel.Margin = new Padding(3, 2, 3, 2);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(115, 38);
			btnCancel.TabIndex = 74;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = false;
			btnCancel.Click += btnCancel_Click;
			// 
			// chbBenchMarkInfo
			// 
			chbBenchMarkInfo.AutoSize = true;
			chbBenchMarkInfo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			chbBenchMarkInfo.ForeColor = Color.FromArgb(236, 179, 101);
			chbBenchMarkInfo.Location = new Point(783, 45);
			chbBenchMarkInfo.Name = "chbBenchMarkInfo";
			chbBenchMarkInfo.Size = new Size(196, 24);
			chbBenchMarkInfo.TabIndex = 71;
			chbBenchMarkInfo.Text = "Benchmark Information";
			chbBenchMarkInfo.UseVisualStyleBackColor = true;
			chbBenchMarkInfo.CheckedChanged += chbBenchMarkInfo_CheckedChanged;
			// 
			// tbxSpeed
			// 
			tbxSpeed.BackColor = Color.FromArgb(4, 41, 58);
			tbxSpeed.BorderStyle = BorderStyle.FixedSingle;
			tbxSpeed.ForeColor = Color.FromArgb(236, 179, 101);
			tbxSpeed.Location = new Point(339, 298);
			tbxSpeed.Margin = new Padding(3, 2, 3, 2);
			tbxSpeed.MaxLength = 7;
			tbxSpeed.Name = "tbxSpeed";
			tbxSpeed.Size = new Size(69, 23);
			tbxSpeed.TabIndex = 64;
			tbxSpeed.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblSpeed
			// 
			lblSpeed.AutoSize = true;
			lblSpeed.ForeColor = Color.FromArgb(236, 179, 101);
			lblSpeed.Location = new Point(339, 272);
			lblSpeed.Name = "lblSpeed";
			lblSpeed.Size = new Size(78, 15);
			lblSpeed.TabIndex = 63;
			lblSpeed.Text = "Speed (MT/s)";
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
			// cbXMPSupport
			// 
			cbXMPSupport.BackColor = Color.FromArgb(4, 41, 58);
			cbXMPSupport.DropDownStyle = ComboBoxStyle.DropDownList;
			cbXMPSupport.ForeColor = Color.FromArgb(236, 179, 101);
			cbXMPSupport.FormattingEnabled = true;
			cbXMPSupport.Items.AddRange(new object[] { "Yes", "No" });
			cbXMPSupport.Location = new Point(514, 71);
			cbXMPSupport.Margin = new Padding(3, 2, 3, 2);
			cbXMPSupport.Name = "cbXMPSupport";
			cbXMPSupport.Size = new Size(120, 23);
			cbXMPSupport.TabIndex = 77;
			// 
			// lblXMPSupport
			// 
			lblXMPSupport.AutoSize = true;
			lblXMPSupport.ForeColor = Color.FromArgb(236, 179, 101);
			lblXMPSupport.Location = new Point(514, 45);
			lblXMPSupport.Name = "lblXMPSupport";
			lblXMPSupport.Size = new Size(77, 15);
			lblXMPSupport.TabIndex = 76;
			lblXMPSupport.Text = "XMP Support";
			// 
			// cbEXPOSupport
			// 
			cbEXPOSupport.BackColor = Color.FromArgb(4, 41, 58);
			cbEXPOSupport.DropDownStyle = ComboBoxStyle.DropDownList;
			cbEXPOSupport.ForeColor = Color.FromArgb(236, 179, 101);
			cbEXPOSupport.FormattingEnabled = true;
			cbEXPOSupport.Items.AddRange(new object[] { "Yes", "No" });
			cbEXPOSupport.Location = new Point(514, 146);
			cbEXPOSupport.Margin = new Padding(3, 2, 3, 2);
			cbEXPOSupport.Name = "cbEXPOSupport";
			cbEXPOSupport.Size = new Size(120, 23);
			cbEXPOSupport.TabIndex = 79;
			// 
			// lblEXPOSupport
			// 
			lblEXPOSupport.AutoSize = true;
			lblEXPOSupport.ForeColor = Color.FromArgb(236, 179, 101);
			lblEXPOSupport.Location = new Point(514, 120);
			lblEXPOSupport.Name = "lblEXPOSupport";
			lblEXPOSupport.Size = new Size(81, 15);
			lblEXPOSupport.TabIndex = 78;
			lblEXPOSupport.Text = "EXPO Support";
			// 
			// tbxNumberOfModules
			// 
			tbxNumberOfModules.BackColor = Color.FromArgb(4, 41, 58);
			tbxNumberOfModules.BorderStyle = BorderStyle.FixedSingle;
			tbxNumberOfModules.ForeColor = Color.FromArgb(236, 179, 101);
			tbxNumberOfModules.Location = new Point(339, 147);
			tbxNumberOfModules.Margin = new Padding(3, 2, 3, 2);
			tbxNumberOfModules.MaxLength = 7;
			tbxNumberOfModules.Name = "tbxNumberOfModules";
			tbxNumberOfModules.Size = new Size(69, 23);
			tbxNumberOfModules.TabIndex = 83;
			tbxNumberOfModules.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblNumberOfModules
			// 
			lblNumberOfModules.AutoSize = true;
			lblNumberOfModules.ForeColor = Color.FromArgb(236, 179, 101);
			lblNumberOfModules.Location = new Point(339, 121);
			lblNumberOfModules.Name = "lblNumberOfModules";
			lblNumberOfModules.Size = new Size(116, 15);
			lblNumberOfModules.TabIndex = 82;
			lblNumberOfModules.Text = "Number Of Modules";
			// 
			// tbxModuleCapacity
			// 
			tbxModuleCapacity.BackColor = Color.FromArgb(4, 41, 58);
			tbxModuleCapacity.BorderStyle = BorderStyle.FixedSingle;
			tbxModuleCapacity.ForeColor = Color.FromArgb(236, 179, 101);
			tbxModuleCapacity.Location = new Point(339, 71);
			tbxModuleCapacity.Margin = new Padding(3, 2, 3, 2);
			tbxModuleCapacity.MaxLength = 7;
			tbxModuleCapacity.Name = "tbxModuleCapacity";
			tbxModuleCapacity.Size = new Size(69, 23);
			tbxModuleCapacity.TabIndex = 81;
			tbxModuleCapacity.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblModuleCapacity
			// 
			lblModuleCapacity.AutoSize = true;
			lblModuleCapacity.ForeColor = Color.FromArgb(236, 179, 101);
			lblModuleCapacity.Location = new Point(339, 45);
			lblModuleCapacity.Name = "lblModuleCapacity";
			lblModuleCapacity.Size = new Size(123, 15);
			lblModuleCapacity.TabIndex = 80;
			lblModuleCapacity.Text = "Module Capacity (GB)";
			// 
			// cbMemoryType
			// 
			cbMemoryType.BackColor = Color.FromArgb(4, 41, 58);
			cbMemoryType.DropDownStyle = ComboBoxStyle.DropDownList;
			cbMemoryType.ForeColor = Color.FromArgb(236, 179, 101);
			cbMemoryType.FormattingEnabled = true;
			cbMemoryType.Items.AddRange(new object[] { "DDR3", "DDR4", "DDR5" });
			cbMemoryType.Location = new Point(339, 222);
			cbMemoryType.Margin = new Padding(3, 2, 3, 2);
			cbMemoryType.Name = "cbMemoryType";
			cbMemoryType.Size = new Size(120, 23);
			cbMemoryType.TabIndex = 85;
			// 
			// lblMemoryType
			// 
			lblMemoryType.AutoSize = true;
			lblMemoryType.ForeColor = Color.FromArgb(236, 179, 101);
			lblMemoryType.Location = new Point(339, 196);
			lblMemoryType.Name = "lblMemoryType";
			lblMemoryType.Size = new Size(80, 15);
			lblMemoryType.TabIndex = 84;
			lblMemoryType.Text = "Memory Type";
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
			panelBenchMarkInfo.Location = new Point(750, 83);
			panelBenchMarkInfo.Name = "panelBenchMarkInfo";
			panelBenchMarkInfo.Size = new Size(267, 278);
			panelBenchMarkInfo.TabIndex = 86;
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
			// lblRAMKit
			// 
			lblRAMKit.AutoSize = true;
			lblRAMKit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblRAMKit.ForeColor = Color.FromArgb(236, 179, 101);
			lblRAMKit.Location = new Point(12, 9);
			lblRAMKit.Name = "lblRAMKit";
			lblRAMKit.Size = new Size(71, 21);
			lblRAMKit.TabIndex = 94;
			lblRAMKit.Text = "RAM Kit";
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
			panel.Size = new Size(1112, 477);
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
			// FormAddRAMKit
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(4, 28, 50);
			ClientSize = new Size(1112, 477);
			Controls.Add(lblRAMKit);
			Controls.Add(panelBenchMarkInfo);
			Controls.Add(cbMemoryType);
			Controls.Add(lblMemoryType);
			Controls.Add(tbxNumberOfModules);
			Controls.Add(lblNumberOfModules);
			Controls.Add(tbxModuleCapacity);
			Controls.Add(lblModuleCapacity);
			Controls.Add(cbEXPOSupport);
			Controls.Add(lblEXPOSupport);
			Controls.Add(cbXMPSupport);
			Controls.Add(lblXMPSupport);
			Controls.Add(btnConfirm);
			Controls.Add(tbxCASLatency);
			Controls.Add(lblCASLatency);
			Controls.Add(lblError);
			Controls.Add(btnCancel);
			Controls.Add(chbBenchMarkInfo);
			Controls.Add(tbxSpeed);
			Controls.Add(lblSpeed);
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
			Name = "FormAddRAMKit";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Add RAM Kit";
			panelBenchMarkInfo.ResumeLayout(false);
			panelBenchMarkInfo.PerformLayout();
			panel.ResumeLayout(false);
			panel.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnConfirm;
		private TextBox tbxCASLatency;
		private Label lblCASLatency;
		private Label lblError;
		private Button btnCancel;
		private CheckBox chbBenchMarkInfo;
		private TextBox tbxSpeed;
		private Label lblSpeed;
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
		private ComboBox cbXMPSupport;
		private Label lblXMPSupport;
		private ComboBox cbEXPOSupport;
		private Label lblEXPOSupport;
		private TextBox tbxNumberOfModules;
		private Label lblNumberOfModules;
		private TextBox tbxModuleCapacity;
		private Label lblModuleCapacity;
		private ComboBox cbMemoryType;
		private Label lblMemoryType;
		private Panel panelBenchMarkInfo;
		private TextBox tbxMaximumScore;
		private Label lblMaximumScore;
		private TextBox tbxAverageScore;
		private Label lblAverageScore;
		private TextBox tbxSource;
		private Label lblSource;
		private Label lblRAMKit;
		private Panel panel;
		private Label lblCase;
	}
}