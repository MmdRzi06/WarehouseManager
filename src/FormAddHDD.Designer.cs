namespace WarehouseManager {
	partial class FormAddHDD {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddHDD));
			tbxAverageScore = new TextBox();
			lblAverageScore = new Label();
			tbxSource = new TextBox();
			lblSource = new Label();
			lblError = new Label();
			btnCancel = new Button();
			btnConfirm = new Button();
			panelBenchMarkInfo = new Panel();
			tbxMaximumScore = new TextBox();
			lblMaximumScore = new Label();
			chbBenchMarkInfo = new CheckBox();
			tbxWriteSpeed = new TextBox();
			lblWriteSpeed = new Label();
			tbxReadSpeed = new TextBox();
			lblReadSpeed = new Label();
			tbxCapacity = new TextBox();
			lblCapacity = new Label();
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
			tbxRPM = new TextBox();
			lblRPM = new Label();
			lblHDD = new Label();
			panel = new Panel();
			label1 = new Label();
			panelBenchMarkInfo.SuspendLayout();
			panel.SuspendLayout();
			SuspendLayout();
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
			// lblError
			// 
			lblError.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblError.ForeColor = Color.FromArgb(244, 43, 50);
			lblError.Location = new Point(327, 428);
			lblError.Name = "lblError";
			lblError.Size = new Size(406, 36);
			lblError.TabIndex = 156;
			lblError.Text = "\r\n";
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
			btnCancel.TabIndex = 155;
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
			btnConfirm.TabIndex = 154;
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
			panelBenchMarkInfo.Location = new Point(625, 83);
			panelBenchMarkInfo.Name = "panelBenchMarkInfo";
			panelBenchMarkInfo.Size = new Size(267, 278);
			panelBenchMarkInfo.TabIndex = 153;
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
			// chbBenchMarkInfo
			// 
			chbBenchMarkInfo.AutoSize = true;
			chbBenchMarkInfo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			chbBenchMarkInfo.ForeColor = Color.FromArgb(236, 179, 101);
			chbBenchMarkInfo.Location = new Point(658, 45);
			chbBenchMarkInfo.Name = "chbBenchMarkInfo";
			chbBenchMarkInfo.Size = new Size(196, 24);
			chbBenchMarkInfo.TabIndex = 152;
			chbBenchMarkInfo.Text = "Benchmark Information";
			chbBenchMarkInfo.UseVisualStyleBackColor = true;
			chbBenchMarkInfo.CheckedChanged += chbBenchMarkInfo_CheckedChanged;
			// 
			// tbxWriteSpeed
			// 
			tbxWriteSpeed.BackColor = Color.FromArgb(4, 41, 58);
			tbxWriteSpeed.BorderStyle = BorderStyle.FixedSingle;
			tbxWriteSpeed.ForeColor = Color.FromArgb(236, 179, 101);
			tbxWriteSpeed.Location = new Point(339, 226);
			tbxWriteSpeed.Margin = new Padding(3, 2, 3, 2);
			tbxWriteSpeed.MaxLength = 7;
			tbxWriteSpeed.Name = "tbxWriteSpeed";
			tbxWriteSpeed.Size = new Size(69, 23);
			tbxWriteSpeed.TabIndex = 151;
			tbxWriteSpeed.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblWriteSpeed
			// 
			lblWriteSpeed.AutoSize = true;
			lblWriteSpeed.ForeColor = Color.FromArgb(236, 179, 101);
			lblWriteSpeed.Location = new Point(339, 200);
			lblWriteSpeed.Name = "lblWriteSpeed";
			lblWriteSpeed.Size = new Size(109, 15);
			lblWriteSpeed.TabIndex = 150;
			lblWriteSpeed.Text = "Write Speed (MB/s)";
			// 
			// tbxReadSpeed
			// 
			tbxReadSpeed.BackColor = Color.FromArgb(4, 41, 58);
			tbxReadSpeed.BorderStyle = BorderStyle.FixedSingle;
			tbxReadSpeed.ForeColor = Color.FromArgb(236, 179, 101);
			tbxReadSpeed.Location = new Point(339, 147);
			tbxReadSpeed.Margin = new Padding(3, 2, 3, 2);
			tbxReadSpeed.MaxLength = 7;
			tbxReadSpeed.Name = "tbxReadSpeed";
			tbxReadSpeed.Size = new Size(69, 23);
			tbxReadSpeed.TabIndex = 149;
			tbxReadSpeed.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblReadSpeed
			// 
			lblReadSpeed.AutoSize = true;
			lblReadSpeed.ForeColor = Color.FromArgb(236, 179, 101);
			lblReadSpeed.Location = new Point(339, 121);
			lblReadSpeed.Name = "lblReadSpeed";
			lblReadSpeed.Size = new Size(107, 15);
			lblReadSpeed.TabIndex = 148;
			lblReadSpeed.Text = "Read Speed (MB/s)";
			// 
			// tbxCapacity
			// 
			tbxCapacity.BackColor = Color.FromArgb(4, 41, 58);
			tbxCapacity.BorderStyle = BorderStyle.FixedSingle;
			tbxCapacity.ForeColor = Color.FromArgb(236, 179, 101);
			tbxCapacity.Location = new Point(339, 71);
			tbxCapacity.Margin = new Padding(3, 2, 3, 2);
			tbxCapacity.MaxLength = 7;
			tbxCapacity.Name = "tbxCapacity";
			tbxCapacity.Size = new Size(69, 23);
			tbxCapacity.TabIndex = 147;
			tbxCapacity.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblCapacity
			// 
			lblCapacity.AutoSize = true;
			lblCapacity.ForeColor = Color.FromArgb(236, 179, 101);
			lblCapacity.Location = new Point(339, 45);
			lblCapacity.Name = "lblCapacity";
			lblCapacity.Size = new Size(79, 15);
			lblCapacity.TabIndex = 146;
			lblCapacity.Text = "Capacity (GB)";
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
			tbxWeight.TabIndex = 145;
			tbxWeight.KeyPress += DoubleTextBoxes_KeyPress;
			// 
			// lblWeight
			// 
			lblWeight.AutoSize = true;
			lblWeight.ForeColor = Color.FromArgb(236, 179, 101);
			lblWeight.Location = new Point(60, 351);
			lblWeight.Name = "lblWeight";
			lblWeight.Size = new Size(70, 15);
			lblWeight.TabIndex = 144;
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
			tbxStockQuantity.TabIndex = 143;
			tbxStockQuantity.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblStockQuantity
			// 
			lblStockQuantity.AutoSize = true;
			lblStockQuantity.ForeColor = Color.FromArgb(236, 179, 101);
			lblStockQuantity.Location = new Point(60, 272);
			lblStockQuantity.Name = "lblStockQuantity";
			lblStockQuantity.Size = new Size(85, 15);
			lblStockQuantity.TabIndex = 142;
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
			tbxPrice.TabIndex = 141;
			tbxPrice.KeyPress += DoubleTextBoxes_KeyPress;
			// 
			// lblPrice
			// 
			lblPrice.AutoSize = true;
			lblPrice.ForeColor = Color.FromArgb(236, 179, 101);
			lblPrice.Location = new Point(60, 196);
			lblPrice.Name = "lblPrice";
			lblPrice.Size = new Size(33, 15);
			lblPrice.TabIndex = 140;
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
			tbxManufacturer.TabIndex = 139;
			tbxManufacturer.KeyPress += StringTextBoxes_KeyPress;
			// 
			// lblManufacturer
			// 
			lblManufacturer.AutoSize = true;
			lblManufacturer.ForeColor = Color.FromArgb(236, 179, 101);
			lblManufacturer.Location = new Point(60, 120);
			lblManufacturer.Name = "lblManufacturer";
			lblManufacturer.Size = new Size(79, 15);
			lblManufacturer.TabIndex = 138;
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
			tbxName.TabIndex = 137;
			tbxName.KeyPress += StringTextBoxes_KeyPress;
			// 
			// lblName
			// 
			lblName.AutoSize = true;
			lblName.ForeColor = Color.FromArgb(236, 179, 101);
			lblName.Location = new Point(60, 45);
			lblName.Name = "lblName";
			lblName.Size = new Size(39, 15);
			lblName.TabIndex = 136;
			lblName.Text = "Name";
			// 
			// tbxRPM
			// 
			tbxRPM.BackColor = Color.FromArgb(4, 41, 58);
			tbxRPM.BorderStyle = BorderStyle.FixedSingle;
			tbxRPM.ForeColor = Color.FromArgb(236, 179, 101);
			tbxRPM.Location = new Point(339, 298);
			tbxRPM.Margin = new Padding(3, 2, 3, 2);
			tbxRPM.MaxLength = 7;
			tbxRPM.Name = "tbxRPM";
			tbxRPM.Size = new Size(69, 23);
			tbxRPM.TabIndex = 158;
			tbxRPM.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblRPM
			// 
			lblRPM.AutoSize = true;
			lblRPM.ForeColor = Color.FromArgb(236, 179, 101);
			lblRPM.Location = new Point(339, 272);
			lblRPM.Name = "lblRPM";
			lblRPM.Size = new Size(32, 15);
			lblRPM.TabIndex = 157;
			lblRPM.Text = "RPM";
			// 
			// lblHDD
			// 
			lblHDD.AutoSize = true;
			lblHDD.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblHDD.ForeColor = Color.FromArgb(236, 179, 101);
			lblHDD.Location = new Point(12, 9);
			lblHDD.Name = "lblHDD";
			lblHDD.Size = new Size(46, 21);
			lblHDD.TabIndex = 159;
			lblHDD.Text = "HDD";
			// 
			// panel
			// 
			panel.BackColor = Color.Transparent;
			panel.BorderStyle = BorderStyle.FixedSingle;
			panel.Controls.Add(label1);
			panel.Dock = DockStyle.Fill;
			panel.Location = new Point(0, 0);
			panel.Name = "panel";
			panel.Padding = new Padding(1);
			panel.Size = new Size(987, 477);
			panel.TabIndex = 160;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.FromArgb(236, 179, 101);
			label1.Location = new Point(13, 10);
			label1.Name = "label1";
			label1.Size = new Size(45, 21);
			label1.TabIndex = 93;
			label1.Text = "Case";
			// 
			// FormAddHDD
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(4, 28, 50);
			ClientSize = new Size(987, 477);
			Controls.Add(lblHDD);
			Controls.Add(tbxRPM);
			Controls.Add(lblRPM);
			Controls.Add(lblError);
			Controls.Add(btnCancel);
			Controls.Add(btnConfirm);
			Controls.Add(panelBenchMarkInfo);
			Controls.Add(chbBenchMarkInfo);
			Controls.Add(tbxWriteSpeed);
			Controls.Add(lblWriteSpeed);
			Controls.Add(tbxReadSpeed);
			Controls.Add(lblReadSpeed);
			Controls.Add(tbxCapacity);
			Controls.Add(lblCapacity);
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
			ForeColor = SystemColors.ControlText;
			FormBorderStyle = FormBorderStyle.None;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			Name = "FormAddHDD";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Add HDD";
			panelBenchMarkInfo.ResumeLayout(false);
			panelBenchMarkInfo.PerformLayout();
			panel.ResumeLayout(false);
			panel.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox tbxAverageScore;
		private Label lblAverageScore;
		private TextBox tbxSource;
		private Label lblSource;
		private Label lblError;
		private Button btnCancel;
		private Button btnConfirm;
		private Panel panelBenchMarkInfo;
		private TextBox tbxMaximumScore;
		private Label lblMaximumScore;
		private CheckBox chbBenchMarkInfo;
		private TextBox tbxWriteSpeed;
		private Label lblWriteSpeed;
		private TextBox tbxReadSpeed;
		private Label lblReadSpeed;
		private TextBox tbxCapacity;
		private Label lblCapacity;
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
		private TextBox tbxRPM;
		private Label lblRPM;
		private Label lblHDD;
		private Panel panel;
		private Label label1;
	}
}