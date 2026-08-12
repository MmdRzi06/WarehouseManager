namespace WarehouseManager {
	partial class FormModifyThermalPad {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModifyThermalPad));
			lblError = new Label();
			btnCancel = new Button();
			btnConfirm = new Button();
			lblInstruction = new Label();
			tbxWidth = new TextBox();
			lblWidth = new Label();
			tbxLength = new TextBox();
			lblLength = new Label();
			tbxThickness = new TextBox();
			lblThickness = new Label();
			lblThermalPad = new Label();
			panel = new Panel();
			SuspendLayout();
			// 
			// lblError
			// 
			lblError.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblError.ForeColor = Color.FromArgb(244, 43, 50);
			lblError.Location = new Point(107, 443);
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
			btnCancel.Location = new Point(519, 443);
			btnCancel.Margin = new Padding(3, 2, 3, 2);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(115, 38);
			btnCancel.TabIndex = 74;
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
			btnConfirm.TabIndex = 73;
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
			lblInstruction.TabIndex = 72;
			lblInstruction.Text = "Fill out the fields you would like to change.";
			// 
			// tbxWidth
			// 
			tbxWidth.BackColor = Color.FromArgb(4, 41, 58);
			tbxWidth.BorderStyle = BorderStyle.FixedSingle;
			tbxWidth.ForeColor = Color.FromArgb(236, 179, 101);
			tbxWidth.Location = new Point(60, 233);
			tbxWidth.Margin = new Padding(3, 2, 3, 2);
			tbxWidth.MaxLength = 7;
			tbxWidth.Name = "tbxWidth";
			tbxWidth.Size = new Size(69, 23);
			tbxWidth.TabIndex = 81;
			tbxWidth.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblWidth
			// 
			lblWidth.AutoSize = true;
			lblWidth.ForeColor = Color.FromArgb(236, 179, 101);
			lblWidth.Location = new Point(60, 207);
			lblWidth.Name = "lblWidth";
			lblWidth.Size = new Size(72, 15);
			lblWidth.TabIndex = 80;
			lblWidth.Text = "Width (mm)";
			// 
			// tbxLength
			// 
			tbxLength.BackColor = Color.FromArgb(4, 41, 58);
			tbxLength.BorderStyle = BorderStyle.FixedSingle;
			tbxLength.ForeColor = Color.FromArgb(236, 179, 101);
			tbxLength.Location = new Point(60, 157);
			tbxLength.Margin = new Padding(3, 2, 3, 2);
			tbxLength.MaxLength = 7;
			tbxLength.Name = "tbxLength";
			tbxLength.Size = new Size(69, 23);
			tbxLength.TabIndex = 79;
			tbxLength.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblLength
			// 
			lblLength.AutoSize = true;
			lblLength.ForeColor = Color.FromArgb(236, 179, 101);
			lblLength.Location = new Point(60, 131);
			lblLength.Name = "lblLength";
			lblLength.Size = new Size(77, 15);
			lblLength.TabIndex = 78;
			lblLength.Text = "Length (mm)";
			// 
			// tbxThickness
			// 
			tbxThickness.BackColor = Color.FromArgb(4, 41, 58);
			tbxThickness.BorderStyle = BorderStyle.FixedSingle;
			tbxThickness.ForeColor = Color.FromArgb(236, 179, 101);
			tbxThickness.Location = new Point(60, 82);
			tbxThickness.Margin = new Padding(3, 2, 3, 2);
			tbxThickness.MaxLength = 7;
			tbxThickness.Name = "tbxThickness";
			tbxThickness.Size = new Size(69, 23);
			tbxThickness.TabIndex = 77;
			tbxThickness.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblThickness
			// 
			lblThickness.AutoSize = true;
			lblThickness.ForeColor = Color.FromArgb(236, 179, 101);
			lblThickness.Location = new Point(60, 56);
			lblThickness.Name = "lblThickness";
			lblThickness.Size = new Size(92, 15);
			lblThickness.TabIndex = 76;
			lblThickness.Text = "Thickness (mm)";
			// 
			// lblThermalPad
			// 
			lblThermalPad.AutoSize = true;
			lblThermalPad.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblThermalPad.ForeColor = Color.FromArgb(236, 179, 101);
			lblThermalPad.Location = new Point(12, 9);
			lblThermalPad.Name = "lblThermalPad";
			lblThermalPad.Size = new Size(106, 21);
			lblThermalPad.TabIndex = 94;
			lblThermalPad.Text = "Thermal Pad";
			// 
			// panel
			// 
			panel.BackColor = Color.Transparent;
			panel.BorderStyle = BorderStyle.FixedSingle;
			panel.Dock = DockStyle.Fill;
			panel.Location = new Point(0, 0);
			panel.Name = "panel";
			panel.Padding = new Padding(1);
			panel.Size = new Size(767, 492);
			panel.TabIndex = 95;
			// 
			// FormModifyThermalPad
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(4, 28, 50);
			ClientSize = new Size(767, 492);
			Controls.Add(lblThermalPad);
			Controls.Add(tbxWidth);
			Controls.Add(lblWidth);
			Controls.Add(tbxLength);
			Controls.Add(lblLength);
			Controls.Add(tbxThickness);
			Controls.Add(lblThickness);
			Controls.Add(lblError);
			Controls.Add(btnCancel);
			Controls.Add(btnConfirm);
			Controls.Add(lblInstruction);
			Controls.Add(panel);
			FormBorderStyle = FormBorderStyle.None;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			Name = "FormModifyThermalPad";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Modify Thermal Pad";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblError;
		private Button btnCancel;
		private Button btnConfirm;
		private Label lblInstruction;
		private TextBox tbxWidth;
		private Label lblWidth;
		private TextBox tbxLength;
		private Label lblLength;
		private TextBox tbxThickness;
		private Label lblThickness;
		private Label lblThermalPad;
		private Panel panel;
	}
}