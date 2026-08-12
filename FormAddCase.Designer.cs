namespace WarehouseManager {
    partial class FormAddCase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddCase));
			lblName = new Label();
			tbxName = new TextBox();
			tbxManufacturer = new TextBox();
			lblManufacturer = new Label();
			tbxStockQuantity = new TextBox();
			lblStockQuantity = new Label();
			tbxPrice = new TextBox();
			lblPrice = new Label();
			tbxWeight = new TextBox();
			lblWeight = new Label();
			tbxMaximumCPUCoolerHeight = new TextBox();
			lblMaximumCPUCoolerHeight = new Label();
			tbxMaximumGPULength = new TextBox();
			lblMaximumGPULength = new Label();
			lblLSMFF = new Label();
			lblFormFactor = new Label();
			cbFormFactor = new ComboBox();
			cbLSMFF = new ComboBox();
			btnConfirm = new Button();
			btnCancel = new Button();
			chbBenchMarkInfo = new CheckBox();
			tbxSource = new TextBox();
			lblSource = new Label();
			tbxMaximumScore = new TextBox();
			lblMaximumScore = new Label();
			tbxAverageScore = new TextBox();
			lblAverageScore = new Label();
			panelBenchMarkInfo = new Panel();
			lblError = new Label();
			lblCase = new Label();
			panel = new Panel();
			label1 = new Label();
			panelBenchMarkInfo.SuspendLayout();
			panel.SuspendLayout();
			SuspendLayout();
			// 
			// lblName
			// 
			lblName.AutoSize = true;
			lblName.ForeColor = Color.FromArgb(236, 179, 101);
			lblName.Location = new Point(60, 45);
			lblName.Name = "lblName";
			lblName.Size = new Size(39, 15);
			lblName.TabIndex = 0;
			lblName.Text = "Name";
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
			tbxName.TabIndex = 1;
			tbxName.KeyPress += StringTextBoxes_KeyPress;
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
			tbxManufacturer.TabIndex = 3;
			tbxManufacturer.KeyPress += StringTextBoxes_KeyPress;
			// 
			// lblManufacturer
			// 
			lblManufacturer.AutoSize = true;
			lblManufacturer.ForeColor = Color.FromArgb(236, 179, 101);
			lblManufacturer.Location = new Point(60, 120);
			lblManufacturer.Name = "lblManufacturer";
			lblManufacturer.Size = new Size(79, 15);
			lblManufacturer.TabIndex = 2;
			lblManufacturer.Text = "Manufacturer";
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
			tbxStockQuantity.TabIndex = 7;
			tbxStockQuantity.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblStockQuantity
			// 
			lblStockQuantity.AutoSize = true;
			lblStockQuantity.ForeColor = Color.FromArgb(236, 179, 101);
			lblStockQuantity.Location = new Point(60, 272);
			lblStockQuantity.Name = "lblStockQuantity";
			lblStockQuantity.Size = new Size(85, 15);
			lblStockQuantity.TabIndex = 6;
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
			tbxPrice.TabIndex = 5;
			tbxPrice.KeyPress += DoubleTextBoxes_KeyPress;
			// 
			// lblPrice
			// 
			lblPrice.AutoSize = true;
			lblPrice.ForeColor = Color.FromArgb(236, 179, 101);
			lblPrice.Location = new Point(60, 196);
			lblPrice.Name = "lblPrice";
			lblPrice.Size = new Size(33, 15);
			lblPrice.TabIndex = 4;
			lblPrice.Text = "Price";
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
			tbxWeight.TabIndex = 9;
			tbxWeight.KeyPress += DoubleTextBoxes_KeyPress;
			// 
			// lblWeight
			// 
			lblWeight.AutoSize = true;
			lblWeight.ForeColor = Color.FromArgb(236, 179, 101);
			lblWeight.Location = new Point(60, 351);
			lblWeight.Name = "lblWeight";
			lblWeight.Size = new Size(70, 15);
			lblWeight.TabIndex = 8;
			lblWeight.Text = "Weight (Kg)";
			// 
			// tbxMaximumCPUCoolerHeight
			// 
			tbxMaximumCPUCoolerHeight.BackColor = Color.FromArgb(4, 41, 58);
			tbxMaximumCPUCoolerHeight.BorderStyle = BorderStyle.FixedSingle;
			tbxMaximumCPUCoolerHeight.ForeColor = Color.FromArgb(236, 179, 101);
			tbxMaximumCPUCoolerHeight.Location = new Point(339, 298);
			tbxMaximumCPUCoolerHeight.Margin = new Padding(3, 2, 3, 2);
			tbxMaximumCPUCoolerHeight.MaxLength = 7;
			tbxMaximumCPUCoolerHeight.Name = "tbxMaximumCPUCoolerHeight";
			tbxMaximumCPUCoolerHeight.Size = new Size(69, 23);
			tbxMaximumCPUCoolerHeight.TabIndex = 17;
			tbxMaximumCPUCoolerHeight.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblMaximumCPUCoolerHeight
			// 
			lblMaximumCPUCoolerHeight.AutoSize = true;
			lblMaximumCPUCoolerHeight.ForeColor = Color.FromArgb(236, 179, 101);
			lblMaximumCPUCoolerHeight.Location = new Point(339, 272);
			lblMaximumCPUCoolerHeight.Name = "lblMaximumCPUCoolerHeight";
			lblMaximumCPUCoolerHeight.Size = new Size(197, 15);
			lblMaximumCPUCoolerHeight.TabIndex = 16;
			lblMaximumCPUCoolerHeight.Text = "Maximum CPU Cooler Height (mm)";
			// 
			// tbxMaximumGPULength
			// 
			tbxMaximumGPULength.BackColor = Color.FromArgb(4, 41, 58);
			tbxMaximumGPULength.BorderStyle = BorderStyle.FixedSingle;
			tbxMaximumGPULength.ForeColor = Color.FromArgb(236, 179, 101);
			tbxMaximumGPULength.Location = new Point(339, 222);
			tbxMaximumGPULength.Margin = new Padding(3, 2, 3, 2);
			tbxMaximumGPULength.MaxLength = 7;
			tbxMaximumGPULength.Name = "tbxMaximumGPULength";
			tbxMaximumGPULength.Size = new Size(69, 23);
			tbxMaximumGPULength.TabIndex = 15;
			tbxMaximumGPULength.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblMaximumGPULength
			// 
			lblMaximumGPULength.AutoSize = true;
			lblMaximumGPULength.ForeColor = Color.FromArgb(236, 179, 101);
			lblMaximumGPULength.Location = new Point(339, 196);
			lblMaximumGPULength.Name = "lblMaximumGPULength";
			lblMaximumGPULength.Size = new Size(160, 15);
			lblMaximumGPULength.TabIndex = 14;
			lblMaximumGPULength.Text = "Maximum GPU Length (mm)";
			// 
			// lblLSMFF
			// 
			lblLSMFF.AutoSize = true;
			lblLSMFF.ForeColor = Color.FromArgb(236, 179, 101);
			lblLSMFF.Location = new Point(339, 120);
			lblLSMFF.Name = "lblLSMFF";
			lblLSMFF.Size = new Size(243, 15);
			lblLSMFF.TabIndex = 12;
			lblLSMFF.Text = "Largest Supported Motherboard Form Factor";
			// 
			// lblFormFactor
			// 
			lblFormFactor.AutoSize = true;
			lblFormFactor.ForeColor = Color.FromArgb(236, 179, 101);
			lblFormFactor.Location = new Point(339, 45);
			lblFormFactor.Name = "lblFormFactor";
			lblFormFactor.Size = new Size(71, 15);
			lblFormFactor.TabIndex = 10;
			lblFormFactor.Text = "Form Factor";
			// 
			// cbFormFactor
			// 
			cbFormFactor.BackColor = Color.FromArgb(4, 41, 58);
			cbFormFactor.DropDownStyle = ComboBoxStyle.DropDownList;
			cbFormFactor.ForeColor = Color.FromArgb(236, 179, 101);
			cbFormFactor.FormattingEnabled = true;
			cbFormFactor.Items.AddRange(new object[] { "Full Tower", "Mid Tower", "Mini Tower" });
			cbFormFactor.Location = new Point(339, 71);
			cbFormFactor.Margin = new Padding(3, 2, 3, 2);
			cbFormFactor.Name = "cbFormFactor";
			cbFormFactor.Size = new Size(120, 23);
			cbFormFactor.TabIndex = 18;
			// 
			// cbLSMFF
			// 
			cbLSMFF.BackColor = Color.FromArgb(4, 41, 58);
			cbLSMFF.DropDownStyle = ComboBoxStyle.DropDownList;
			cbLSMFF.ForeColor = Color.FromArgb(236, 179, 101);
			cbLSMFF.FormattingEnabled = true;
			cbLSMFF.Items.AddRange(new object[] { "E-ATX", "ATX", "Micro-ATX", "Mini-ITX" });
			cbLSMFF.Location = new Point(339, 145);
			cbLSMFF.Margin = new Padding(3, 2, 3, 2);
			cbLSMFF.Name = "cbLSMFF";
			cbLSMFF.Size = new Size(120, 23);
			cbLSMFF.TabIndex = 19;
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
			btnConfirm.TabIndex = 22;
			btnConfirm.Text = "Confirm";
			btnConfirm.UseVisualStyleBackColor = false;
			btnConfirm.Click += btnConfirm_Click;
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
			btnCancel.TabIndex = 23;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = false;
			btnCancel.Click += btnCancel_Click;
			// 
			// chbBenchMarkInfo
			// 
			chbBenchMarkInfo.AutoSize = true;
			chbBenchMarkInfo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			chbBenchMarkInfo.ForeColor = Color.FromArgb(236, 179, 101);
			chbBenchMarkInfo.Location = new Point(658, 45);
			chbBenchMarkInfo.Name = "chbBenchMarkInfo";
			chbBenchMarkInfo.Size = new Size(196, 24);
			chbBenchMarkInfo.TabIndex = 24;
			chbBenchMarkInfo.Text = "Benchmark Information";
			chbBenchMarkInfo.UseVisualStyleBackColor = false;
			chbBenchMarkInfo.CheckedChanged += chbBenchMarkInfo_CheckedChanged;
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
			panelBenchMarkInfo.TabIndex = 31;
			// 
			// lblError
			// 
			lblError.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblError.ForeColor = Color.FromArgb(244, 43, 50);
			lblError.Location = new Point(327, 428);
			lblError.Name = "lblError";
			lblError.Size = new Size(406, 36);
			lblError.TabIndex = 31;
			lblError.Text = "\r\n";
			// 
			// lblCase
			// 
			lblCase.AutoSize = true;
			lblCase.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblCase.ForeColor = Color.FromArgb(236, 179, 101);
			lblCase.Location = new Point(12, 9);
			lblCase.Name = "lblCase";
			lblCase.Size = new Size(45, 21);
			lblCase.TabIndex = 94;
			lblCase.Text = "Case";
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
			panel.TabIndex = 95;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.FromArgb(236, 179, 101);
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(45, 21);
			label1.TabIndex = 93;
			label1.Text = "Case";
			// 
			// FormAddCase
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(4, 28, 50);
			ClientSize = new Size(987, 477);
			Controls.Add(lblCase);
			Controls.Add(lblError);
			Controls.Add(panelBenchMarkInfo);
			Controls.Add(chbBenchMarkInfo);
			Controls.Add(btnCancel);
			Controls.Add(btnConfirm);
			Controls.Add(cbLSMFF);
			Controls.Add(cbFormFactor);
			Controls.Add(tbxMaximumCPUCoolerHeight);
			Controls.Add(lblMaximumCPUCoolerHeight);
			Controls.Add(tbxMaximumGPULength);
			Controls.Add(lblMaximumGPULength);
			Controls.Add(lblLSMFF);
			Controls.Add(lblFormFactor);
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
			Margin = new Padding(3, 2, 3, 2);
			MaximizeBox = false;
			Name = "FormAddCase";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Add Case";
			KeyPress += DoubleTextBoxes_KeyPress;
			panelBenchMarkInfo.ResumeLayout(false);
			panelBenchMarkInfo.PerformLayout();
			panel.ResumeLayout(false);
			panel.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblName;
        private TextBox tbxName;
        private TextBox tbxManufacturer;
        private Label lblManufacturer;
        private TextBox tbxStockQuantity;
        private Label lblStockQuantity;
        private TextBox tbxPrice;
        private Label lblPrice;
        private TextBox tbxWeight;
        private Label lblWeight;
        private TextBox tbxMaximumCPUCoolerHeight;
        private Label lblMaximumCPUCoolerHeight;
        private TextBox tbxMaximumGPULength;
        private Label lblMaximumGPULength;
        private Label lblLSMFF;
        private Label lblFormFactor;
        private ComboBox cbFormFactor;
        private ComboBox cbLSMFF;
        private Button btnConfirm;
        private Button btnCancel;
		private CheckBox chbBenchMarkInfo;
		private TextBox tbxSource;
		private Label lblSource;
		private TextBox tbxMaximumScore;
		private Label lblMaximumScore;
		private TextBox tbxAverageScore;
		private Label lblAverageScore;
		private Panel panelBenchMarkInfo;
		private Label lblError;
		private Label lblCase;
		private Panel panel;
		private Label label1;
	}
}