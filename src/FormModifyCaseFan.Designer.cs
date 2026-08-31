namespace WarehouseManager {
	partial class FormModifyCaseFan {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModifyCaseFan));
			cbPWMSupport = new ComboBox();
			tbxMaximumFanSpeed = new TextBox();
			tbxSize = new TextBox();
			lblPWMSupport = new Label();
			tbxMinimumFanSpeed = new TextBox();
			lblMinimumFanSpeed = new Label();
			lblMaximumFanSpeed = new Label();
			lblSize = new Label();
			lblError = new Label();
			btnCancel = new Button();
			btnConfirm = new Button();
			lblInstruction = new Label();
			lblCaseFan = new Label();
			pbCrossClearPWMSupport = new PictureBox();
			panel = new Panel();
			lblCase = new Label();
			((System.ComponentModel.ISupportInitialize)pbCrossClearPWMSupport).BeginInit();
			panel.SuspendLayout();
			SuspendLayout();
			// 
			// cbPWMSupport
			// 
			cbPWMSupport.BackColor = Color.FromArgb(4, 41, 58);
			cbPWMSupport.DropDownStyle = ComboBoxStyle.DropDownList;
			cbPWMSupport.ForeColor = Color.FromArgb(236, 179, 101);
			cbPWMSupport.FormattingEnabled = true;
			cbPWMSupport.Items.AddRange(new object[] { "Full Tower", "Mid Tower", "Mini Tower" });
			cbPWMSupport.Location = new Point(60, 309);
			cbPWMSupport.Margin = new Padding(3, 2, 3, 2);
			cbPWMSupport.Name = "cbPWMSupport";
			cbPWMSupport.Size = new Size(120, 23);
			cbPWMSupport.TabIndex = 65;
			// 
			// tbxMaximumFanSpeed
			// 
			tbxMaximumFanSpeed.BackColor = Color.FromArgb(4, 41, 58);
			tbxMaximumFanSpeed.BorderStyle = BorderStyle.FixedSingle;
			tbxMaximumFanSpeed.ForeColor = Color.FromArgb(236, 179, 101);
			tbxMaximumFanSpeed.Location = new Point(60, 157);
			tbxMaximumFanSpeed.Margin = new Padding(3, 2, 3, 2);
			tbxMaximumFanSpeed.MaxLength = 7;
			tbxMaximumFanSpeed.Name = "tbxMaximumFanSpeed";
			tbxMaximumFanSpeed.Size = new Size(69, 23);
			tbxMaximumFanSpeed.TabIndex = 64;
			tbxMaximumFanSpeed.KeyPress += IntTextBoxes_KeyPress;
			// 
			// tbxSize
			// 
			tbxSize.BackColor = Color.FromArgb(4, 41, 58);
			tbxSize.BorderStyle = BorderStyle.FixedSingle;
			tbxSize.ForeColor = Color.FromArgb(236, 179, 101);
			tbxSize.Location = new Point(60, 82);
			tbxSize.Margin = new Padding(3, 2, 3, 2);
			tbxSize.MaxLength = 7;
			tbxSize.Name = "tbxSize";
			tbxSize.Size = new Size(69, 23);
			tbxSize.TabIndex = 63;
			tbxSize.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblPWMSupport
			// 
			lblPWMSupport.AutoSize = true;
			lblPWMSupport.ForeColor = Color.FromArgb(236, 179, 101);
			lblPWMSupport.Location = new Point(60, 283);
			lblPWMSupport.Name = "lblPWMSupport";
			lblPWMSupport.Size = new Size(81, 15);
			lblPWMSupport.TabIndex = 62;
			lblPWMSupport.Text = "PWM Support";
			// 
			// tbxMinimumFanSpeed
			// 
			tbxMinimumFanSpeed.BackColor = Color.FromArgb(4, 41, 58);
			tbxMinimumFanSpeed.BorderStyle = BorderStyle.FixedSingle;
			tbxMinimumFanSpeed.ForeColor = Color.FromArgb(236, 179, 101);
			tbxMinimumFanSpeed.Location = new Point(60, 233);
			tbxMinimumFanSpeed.Margin = new Padding(3, 2, 3, 2);
			tbxMinimumFanSpeed.MaxLength = 7;
			tbxMinimumFanSpeed.Name = "tbxMinimumFanSpeed";
			tbxMinimumFanSpeed.Size = new Size(69, 23);
			tbxMinimumFanSpeed.TabIndex = 61;
			tbxMinimumFanSpeed.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblMinimumFanSpeed
			// 
			lblMinimumFanSpeed.AutoSize = true;
			lblMinimumFanSpeed.ForeColor = Color.FromArgb(236, 179, 101);
			lblMinimumFanSpeed.Location = new Point(60, 207);
			lblMinimumFanSpeed.Name = "lblMinimumFanSpeed";
			lblMinimumFanSpeed.Size = new Size(153, 15);
			lblMinimumFanSpeed.TabIndex = 60;
			lblMinimumFanSpeed.Text = "Minimum Fan Speed (RPM)";
			// 
			// lblMaximumFanSpeed
			// 
			lblMaximumFanSpeed.AutoSize = true;
			lblMaximumFanSpeed.ForeColor = Color.FromArgb(236, 179, 101);
			lblMaximumFanSpeed.Location = new Point(60, 131);
			lblMaximumFanSpeed.Name = "lblMaximumFanSpeed";
			lblMaximumFanSpeed.Size = new Size(154, 15);
			lblMaximumFanSpeed.TabIndex = 59;
			lblMaximumFanSpeed.Text = "Maximum Fan Speed (RPM)";
			// 
			// lblSize
			// 
			lblSize.AutoSize = true;
			lblSize.ForeColor = Color.FromArgb(236, 179, 101);
			lblSize.Location = new Point(60, 56);
			lblSize.Name = "lblSize";
			lblSize.Size = new Size(60, 15);
			lblSize.TabIndex = 58;
			lblSize.Text = "Size (mm)";
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
			// lblCaseFan
			// 
			lblCaseFan.AutoSize = true;
			lblCaseFan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblCaseFan.ForeColor = Color.FromArgb(236, 179, 101);
			lblCaseFan.Location = new Point(12, 9);
			lblCaseFan.Name = "lblCaseFan";
			lblCaseFan.Size = new Size(76, 21);
			lblCaseFan.TabIndex = 95;
			lblCaseFan.Text = "Case Fan";
			// 
			// pbCrossClearPWMSupport
			// 
			pbCrossClearPWMSupport.BackColor = Color.Transparent;
			pbCrossClearPWMSupport.Cursor = Cursors.Hand;
			pbCrossClearPWMSupport.Image = Properties.Resources.Cross_Red;
			pbCrossClearPWMSupport.Location = new Point(31, 309);
			pbCrossClearPWMSupport.Name = "pbCrossClearPWMSupport";
			pbCrossClearPWMSupport.Size = new Size(23, 23);
			pbCrossClearPWMSupport.SizeMode = PictureBoxSizeMode.AutoSize;
			pbCrossClearPWMSupport.TabIndex = 96;
			pbCrossClearPWMSupport.TabStop = false;
			pbCrossClearPWMSupport.Click += pbCrossClearPWMSupport_Click;
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
			// FormModifyCaseFan
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(4, 28, 50);
			ClientSize = new Size(767, 492);
			Controls.Add(pbCrossClearPWMSupport);
			Controls.Add(lblCaseFan);
			Controls.Add(lblError);
			Controls.Add(btnCancel);
			Controls.Add(btnConfirm);
			Controls.Add(lblInstruction);
			Controls.Add(cbPWMSupport);
			Controls.Add(tbxMaximumFanSpeed);
			Controls.Add(tbxSize);
			Controls.Add(lblPWMSupport);
			Controls.Add(tbxMinimumFanSpeed);
			Controls.Add(lblMinimumFanSpeed);
			Controls.Add(lblMaximumFanSpeed);
			Controls.Add(lblSize);
			Controls.Add(panel);
			FormBorderStyle = FormBorderStyle.None;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			Name = "FormModifyCaseFan";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Modify Case Fan";
			((System.ComponentModel.ISupportInitialize)pbCrossClearPWMSupport).EndInit();
			panel.ResumeLayout(false);
			panel.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ComboBox cbPWMSupport;
		private TextBox tbxMaximumFanSpeed;
		private TextBox tbxSize;
		private Label lblPWMSupport;
		private TextBox tbxMinimumFanSpeed;
		private Label lblMinimumFanSpeed;
		private Label lblMaximumFanSpeed;
		private Label lblSize;
		private Label lblError;
		private Button btnCancel;
		private Button btnConfirm;
		private Label lblInstruction;
		private Label lblCaseFan;
		private PictureBox pbCrossClearPWMSupport;
		private Panel panel;
		private Label lblCase;
	}
}