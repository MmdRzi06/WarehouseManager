namespace WarehouseManager {
	partial class FormAddCaseFan {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddCaseFan));
			lblError = new Label();
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
			lblPWMSupport = new Label();
			tbxMinimumFanSpeed = new TextBox();
			lblMinimumFanSpeed = new Label();
			lblMaximumFanSpeed = new Label();
			lblSize = new Label();
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
			tbxSize = new TextBox();
			tbxMaximumFanSpeed = new TextBox();
			cbPWMSupport = new ComboBox();
			lblCaseFan = new Label();
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
			lblError.Location = new Point(327, 428);
			lblError.Name = "lblError";
			lblError.Size = new Size(406, 36);
			lblError.TabIndex = 54;
			lblError.Text = "\r\n";
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
			panelBenchMarkInfo.Location = new Point(625, 83);
			panelBenchMarkInfo.Name = "panelBenchMarkInfo";
			panelBenchMarkInfo.Size = new Size(267, 278);
			panelBenchMarkInfo.TabIndex = 53;
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
			chbBenchMarkInfo.Location = new Point(658, 45);
			chbBenchMarkInfo.Name = "chbBenchMarkInfo";
			chbBenchMarkInfo.Size = new Size(196, 24);
			chbBenchMarkInfo.TabIndex = 52;
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
			btnCancel.Location = new Point(739, 428);
			btnCancel.Margin = new Padding(3, 2, 3, 2);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(115, 38);
			btnCancel.TabIndex = 51;
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
			btnConfirm.Location = new Point(860, 428);
			btnConfirm.Margin = new Padding(3, 2, 3, 2);
			btnConfirm.Name = "btnConfirm";
			btnConfirm.Size = new Size(115, 38);
			btnConfirm.TabIndex = 50;
			btnConfirm.Text = "Confirm";
			btnConfirm.UseVisualStyleBackColor = false;
			btnConfirm.Click += btnConfirm_Click;
			// 
			// lblPWMSupport
			// 
			lblPWMSupport.AutoSize = true;
			lblPWMSupport.ForeColor = Color.FromArgb(236, 179, 101);
			lblPWMSupport.Location = new Point(339, 272);
			lblPWMSupport.Name = "lblPWMSupport";
			lblPWMSupport.Size = new Size(81, 15);
			lblPWMSupport.TabIndex = 46;
			lblPWMSupport.Text = "PWM Support";
			// 
			// tbxMinimumFanSpeed
			// 
			tbxMinimumFanSpeed.BackColor = Color.FromArgb(4, 41, 58);
			tbxMinimumFanSpeed.BorderStyle = BorderStyle.FixedSingle;
			tbxMinimumFanSpeed.ForeColor = Color.FromArgb(236, 179, 101);
			tbxMinimumFanSpeed.Location = new Point(339, 222);
			tbxMinimumFanSpeed.Margin = new Padding(3, 2, 3, 2);
			tbxMinimumFanSpeed.MaxLength = 7;
			tbxMinimumFanSpeed.Name = "tbxMinimumFanSpeed";
			tbxMinimumFanSpeed.Size = new Size(69, 23);
			tbxMinimumFanSpeed.TabIndex = 45;
			tbxMinimumFanSpeed.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblMinimumFanSpeed
			// 
			lblMinimumFanSpeed.AutoSize = true;
			lblMinimumFanSpeed.ForeColor = Color.FromArgb(236, 179, 101);
			lblMinimumFanSpeed.Location = new Point(339, 196);
			lblMinimumFanSpeed.Name = "lblMinimumFanSpeed";
			lblMinimumFanSpeed.Size = new Size(153, 15);
			lblMinimumFanSpeed.TabIndex = 44;
			lblMinimumFanSpeed.Text = "Minimum Fan Speed (RPM)";
			// 
			// lblMaximumFanSpeed
			// 
			lblMaximumFanSpeed.AutoSize = true;
			lblMaximumFanSpeed.ForeColor = Color.FromArgb(236, 179, 101);
			lblMaximumFanSpeed.Location = new Point(339, 120);
			lblMaximumFanSpeed.Name = "lblMaximumFanSpeed";
			lblMaximumFanSpeed.Size = new Size(154, 15);
			lblMaximumFanSpeed.TabIndex = 43;
			lblMaximumFanSpeed.Text = "Maximum Fan Speed (RPM)";
			// 
			// lblSize
			// 
			lblSize.AutoSize = true;
			lblSize.ForeColor = Color.FromArgb(236, 179, 101);
			lblSize.Location = new Point(339, 45);
			lblSize.Name = "lblSize";
			lblSize.Size = new Size(60, 15);
			lblSize.TabIndex = 42;
			lblSize.Text = "Size (mm)";
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
			tbxWeight.TabIndex = 41;
			tbxWeight.KeyPress += DoubleTextBoxes_KeyPress;
			// 
			// lblWeight
			// 
			lblWeight.AutoSize = true;
			lblWeight.ForeColor = Color.FromArgb(236, 179, 101);
			lblWeight.Location = new Point(60, 351);
			lblWeight.Name = "lblWeight";
			lblWeight.Size = new Size(70, 15);
			lblWeight.TabIndex = 40;
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
			tbxStockQuantity.TabIndex = 39;
			tbxStockQuantity.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblStockQuantity
			// 
			lblStockQuantity.AutoSize = true;
			lblStockQuantity.ForeColor = Color.FromArgb(236, 179, 101);
			lblStockQuantity.Location = new Point(60, 272);
			lblStockQuantity.Name = "lblStockQuantity";
			lblStockQuantity.Size = new Size(85, 15);
			lblStockQuantity.TabIndex = 38;
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
			tbxPrice.TabIndex = 37;
			tbxPrice.KeyPress += DoubleTextBoxes_KeyPress;
			// 
			// lblPrice
			// 
			lblPrice.AutoSize = true;
			lblPrice.ForeColor = Color.FromArgb(236, 179, 101);
			lblPrice.Location = new Point(60, 196);
			lblPrice.Name = "lblPrice";
			lblPrice.Size = new Size(33, 15);
			lblPrice.TabIndex = 36;
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
			tbxManufacturer.TabIndex = 35;
			tbxManufacturer.KeyPress += StringTextBoxes_KeyPress;
			// 
			// lblManufacturer
			// 
			lblManufacturer.AutoSize = true;
			lblManufacturer.ForeColor = Color.FromArgb(236, 179, 101);
			lblManufacturer.Location = new Point(60, 120);
			lblManufacturer.Name = "lblManufacturer";
			lblManufacturer.Size = new Size(79, 15);
			lblManufacturer.TabIndex = 34;
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
			tbxName.TabIndex = 33;
			tbxName.KeyPress += StringTextBoxes_KeyPress;
			// 
			// lblName
			// 
			lblName.AutoSize = true;
			lblName.ForeColor = Color.FromArgb(236, 179, 101);
			lblName.Location = new Point(60, 45);
			lblName.Name = "lblName";
			lblName.Size = new Size(39, 15);
			lblName.TabIndex = 32;
			lblName.Text = "Name";
			// 
			// tbxSize
			// 
			tbxSize.BackColor = Color.FromArgb(4, 41, 58);
			tbxSize.BorderStyle = BorderStyle.FixedSingle;
			tbxSize.ForeColor = Color.FromArgb(236, 179, 101);
			tbxSize.Location = new Point(339, 71);
			tbxSize.Margin = new Padding(3, 2, 3, 2);
			tbxSize.MaxLength = 7;
			tbxSize.Name = "tbxSize";
			tbxSize.Size = new Size(69, 23);
			tbxSize.TabIndex = 55;
			tbxSize.KeyPress += IntTextBoxes_KeyPress;
			// 
			// tbxMaximumFanSpeed
			// 
			tbxMaximumFanSpeed.BackColor = Color.FromArgb(4, 41, 58);
			tbxMaximumFanSpeed.BorderStyle = BorderStyle.FixedSingle;
			tbxMaximumFanSpeed.ForeColor = Color.FromArgb(236, 179, 101);
			tbxMaximumFanSpeed.Location = new Point(339, 146);
			tbxMaximumFanSpeed.Margin = new Padding(3, 2, 3, 2);
			tbxMaximumFanSpeed.MaxLength = 7;
			tbxMaximumFanSpeed.Name = "tbxMaximumFanSpeed";
			tbxMaximumFanSpeed.Size = new Size(69, 23);
			tbxMaximumFanSpeed.TabIndex = 56;
			tbxMaximumFanSpeed.KeyPress += IntTextBoxes_KeyPress;
			// 
			// cbPWMSupport
			// 
			cbPWMSupport.BackColor = Color.FromArgb(4, 41, 58);
			cbPWMSupport.DropDownStyle = ComboBoxStyle.DropDownList;
			cbPWMSupport.ForeColor = Color.FromArgb(236, 179, 101);
			cbPWMSupport.FormattingEnabled = true;
			cbPWMSupport.Items.AddRange(new object[] { "Full Tower", "Mid Tower", "Mini Tower" });
			cbPWMSupport.Location = new Point(339, 298);
			cbPWMSupport.Margin = new Padding(3, 2, 3, 2);
			cbPWMSupport.Name = "cbPWMSupport";
			cbPWMSupport.Size = new Size(120, 23);
			cbPWMSupport.TabIndex = 57;
			// 
			// lblCaseFan
			// 
			lblCaseFan.AutoSize = true;
			lblCaseFan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblCaseFan.ForeColor = Color.FromArgb(236, 179, 101);
			lblCaseFan.Location = new Point(12, 9);
			lblCaseFan.Name = "lblCaseFan";
			lblCaseFan.Size = new Size(76, 21);
			lblCaseFan.TabIndex = 94;
			lblCaseFan.Text = "Case Fan";
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
			panel.Size = new Size(987, 477);
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
			// FormAddCaseFan
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(4, 28, 50);
			ClientSize = new Size(987, 477);
			Controls.Add(lblCaseFan);
			Controls.Add(cbPWMSupport);
			Controls.Add(tbxMaximumFanSpeed);
			Controls.Add(tbxSize);
			Controls.Add(lblError);
			Controls.Add(panelBenchMarkInfo);
			Controls.Add(chbBenchMarkInfo);
			Controls.Add(btnCancel);
			Controls.Add(btnConfirm);
			Controls.Add(lblPWMSupport);
			Controls.Add(tbxMinimumFanSpeed);
			Controls.Add(lblMinimumFanSpeed);
			Controls.Add(lblMaximumFanSpeed);
			Controls.Add(lblSize);
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
			Name = "FormAddCaseFan";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Add Case Fan";
			KeyPress += StringTextBoxes_KeyPress;
			panelBenchMarkInfo.ResumeLayout(false);
			panelBenchMarkInfo.PerformLayout();
			panel.ResumeLayout(false);
			panel.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblError;
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
		private Label lblPWMSupport;
		private TextBox tbxMinimumFanSpeed;
		private Label lblMinimumFanSpeed;
		private Label lblMaximumFanSpeed;
		private Label lblSize;
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
		private TextBox tbxSize;
		private TextBox tbxMaximumFanSpeed;
		private ComboBox cbPWMSupport;
		private Label lblCaseFan;
		private Panel panel;
		private Label lblCase;
	}
}