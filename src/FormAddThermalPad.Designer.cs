namespace WarehouseManager {
	partial class FormAddThermalPad {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddThermalPad));
			btnCancel = new Button();
			btnConfirm = new Button();
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
			tbxThickness = new TextBox();
			lblThickness = new Label();
			tbxLength = new TextBox();
			lblLength = new Label();
			tbxWidth = new TextBox();
			lblWidth = new Label();
			lblError = new Label();
			lblThermalPad = new Label();
			panel = new Panel();
			lblCase = new Label();
			panel.SuspendLayout();
			SuspendLayout();
			// 
			// btnCancel
			// 
			btnCancel.BackColor = Color.FromArgb(4, 41, 58);
			btnCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 41, 58);
			btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(6, 70, 99);
			btnCancel.FlatStyle = FlatStyle.Flat;
			btnCancel.ForeColor = Color.FromArgb(236, 179, 101);
			btnCancel.Location = new Point(552, 428);
			btnCancel.Margin = new Padding(3, 2, 3, 2);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(115, 38);
			btnCancel.TabIndex = 25;
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
			btnConfirm.Location = new Point(673, 428);
			btnConfirm.Margin = new Padding(3, 2, 3, 2);
			btnConfirm.Name = "btnConfirm";
			btnConfirm.Size = new Size(115, 38);
			btnConfirm.TabIndex = 24;
			btnConfirm.Text = "Confirm";
			btnConfirm.UseVisualStyleBackColor = false;
			btnConfirm.Click += btnConfirm_Click;
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
			tbxWeight.TabIndex = 35;
			tbxWeight.KeyPress += DoubleTextBoxes_KeyPress;
			// 
			// lblWeight
			// 
			lblWeight.AutoSize = true;
			lblWeight.ForeColor = Color.FromArgb(236, 179, 101);
			lblWeight.Location = new Point(60, 351);
			lblWeight.Name = "lblWeight";
			lblWeight.Size = new Size(70, 15);
			lblWeight.TabIndex = 34;
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
			tbxStockQuantity.TabIndex = 33;
			tbxStockQuantity.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblStockQuantity
			// 
			lblStockQuantity.AutoSize = true;
			lblStockQuantity.ForeColor = Color.FromArgb(236, 179, 101);
			lblStockQuantity.Location = new Point(60, 272);
			lblStockQuantity.Name = "lblStockQuantity";
			lblStockQuantity.Size = new Size(85, 15);
			lblStockQuantity.TabIndex = 32;
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
			tbxPrice.TabIndex = 31;
			tbxPrice.KeyPress += DoubleTextBoxes_KeyPress;
			// 
			// lblPrice
			// 
			lblPrice.AutoSize = true;
			lblPrice.ForeColor = Color.FromArgb(236, 179, 101);
			lblPrice.Location = new Point(60, 196);
			lblPrice.Name = "lblPrice";
			lblPrice.Size = new Size(33, 15);
			lblPrice.TabIndex = 30;
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
			tbxManufacturer.TabIndex = 29;
			tbxManufacturer.KeyPress += StringTextBoxes_KeyPress;
			// 
			// lblManufacturer
			// 
			lblManufacturer.AutoSize = true;
			lblManufacturer.ForeColor = Color.FromArgb(236, 179, 101);
			lblManufacturer.Location = new Point(60, 120);
			lblManufacturer.Name = "lblManufacturer";
			lblManufacturer.Size = new Size(79, 15);
			lblManufacturer.TabIndex = 28;
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
			tbxName.TabIndex = 27;
			tbxName.KeyPress += StringTextBoxes_KeyPress;
			// 
			// lblName
			// 
			lblName.AutoSize = true;
			lblName.ForeColor = Color.FromArgb(236, 179, 101);
			lblName.Location = new Point(60, 45);
			lblName.Name = "lblName";
			lblName.Size = new Size(39, 15);
			lblName.TabIndex = 26;
			lblName.Text = "Name";
			// 
			// tbxThickness
			// 
			tbxThickness.BackColor = Color.FromArgb(4, 41, 58);
			tbxThickness.BorderStyle = BorderStyle.FixedSingle;
			tbxThickness.ForeColor = Color.FromArgb(236, 179, 101);
			tbxThickness.Location = new Point(388, 71);
			tbxThickness.Margin = new Padding(3, 2, 3, 2);
			tbxThickness.MaxLength = 7;
			tbxThickness.Name = "tbxThickness";
			tbxThickness.Size = new Size(69, 23);
			tbxThickness.TabIndex = 37;
			tbxThickness.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblThickness
			// 
			lblThickness.AutoSize = true;
			lblThickness.ForeColor = Color.FromArgb(236, 179, 101);
			lblThickness.Location = new Point(388, 45);
			lblThickness.Name = "lblThickness";
			lblThickness.Size = new Size(92, 15);
			lblThickness.TabIndex = 36;
			lblThickness.Text = "Thickness (mm)";
			// 
			// tbxLength
			// 
			tbxLength.BackColor = Color.FromArgb(4, 41, 58);
			tbxLength.BorderStyle = BorderStyle.FixedSingle;
			tbxLength.ForeColor = Color.FromArgb(236, 179, 101);
			tbxLength.Location = new Point(388, 146);
			tbxLength.Margin = new Padding(3, 2, 3, 2);
			tbxLength.MaxLength = 7;
			tbxLength.Name = "tbxLength";
			tbxLength.Size = new Size(69, 23);
			tbxLength.TabIndex = 39;
			tbxLength.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblLength
			// 
			lblLength.AutoSize = true;
			lblLength.ForeColor = Color.FromArgb(236, 179, 101);
			lblLength.Location = new Point(388, 120);
			lblLength.Name = "lblLength";
			lblLength.Size = new Size(77, 15);
			lblLength.TabIndex = 38;
			lblLength.Text = "Length (mm)";
			// 
			// tbxWidth
			// 
			tbxWidth.BackColor = Color.FromArgb(4, 41, 58);
			tbxWidth.BorderStyle = BorderStyle.FixedSingle;
			tbxWidth.ForeColor = Color.FromArgb(236, 179, 101);
			tbxWidth.Location = new Point(388, 222);
			tbxWidth.Margin = new Padding(3, 2, 3, 2);
			tbxWidth.MaxLength = 7;
			tbxWidth.Name = "tbxWidth";
			tbxWidth.Size = new Size(69, 23);
			tbxWidth.TabIndex = 41;
			tbxWidth.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblWidth
			// 
			lblWidth.AutoSize = true;
			lblWidth.ForeColor = Color.FromArgb(236, 179, 101);
			lblWidth.Location = new Point(388, 196);
			lblWidth.Name = "lblWidth";
			lblWidth.Size = new Size(72, 15);
			lblWidth.TabIndex = 40;
			lblWidth.Text = "Width (mm)";
			// 
			// lblError
			// 
			lblError.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblError.ForeColor = Color.FromArgb(244, 43, 50);
			lblError.Location = new Point(140, 428);
			lblError.Name = "lblError";
			lblError.Size = new Size(406, 36);
			lblError.TabIndex = 42;
			lblError.Text = "\r\n";
			// 
			// lblThermalPad
			// 
			lblThermalPad.AutoSize = true;
			lblThermalPad.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblThermalPad.ForeColor = Color.FromArgb(236, 179, 101);
			lblThermalPad.Location = new Point(12, 9);
			lblThermalPad.Name = "lblThermalPad";
			lblThermalPad.Size = new Size(106, 21);
			lblThermalPad.TabIndex = 95;
			lblThermalPad.Text = "Thermal Pad";
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
			panel.Size = new Size(800, 477);
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
			// FormAddThermalPad
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(4, 28, 50);
			ClientSize = new Size(800, 477);
			Controls.Add(lblThermalPad);
			Controls.Add(lblError);
			Controls.Add(tbxWidth);
			Controls.Add(lblWidth);
			Controls.Add(tbxLength);
			Controls.Add(lblLength);
			Controls.Add(tbxThickness);
			Controls.Add(lblThickness);
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
			Controls.Add(btnCancel);
			Controls.Add(btnConfirm);
			Controls.Add(panel);
			FormBorderStyle = FormBorderStyle.None;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			Name = "FormAddThermalPad";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Add Thermal Pad";
			panel.ResumeLayout(false);
			panel.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Button btnCancel;
		private Button btnConfirm;
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
		private TextBox tbxThickness;
		private Label lblThickness;
		private TextBox tbxLength;
		private Label lblLength;
		private TextBox tbxWidth;
		private Label lblWidth;
		private Label lblError;
		private Label lblThermalPad;
		private Panel panel;
		private Label lblCase;
	}
}