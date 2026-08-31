namespace WarehouseManager {
	partial class FormModifyHDD {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModifyHDD));
			lblError = new Label();
			btnCancel = new Button();
			btnConfirm = new Button();
			lblInstruction = new Label();
			tbxRPM = new TextBox();
			lblRPM = new Label();
			tbxWriteSpeed = new TextBox();
			lblWriteSpeed = new Label();
			tbxReadSpeed = new TextBox();
			lblReadSpeed = new Label();
			tbxCapacity = new TextBox();
			lblCapacity = new Label();
			lblHDD = new Label();
			panel = new Panel();
			label1 = new Label();
			panel.SuspendLayout();
			SuspendLayout();
			// 
			// lblError
			// 
			lblError.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblError.ForeColor = Color.FromArgb(244, 43, 50);
			lblError.Location = new Point(107, 443);
			lblError.Name = "lblError";
			lblError.Size = new Size(406, 36);
			lblError.TabIndex = 151;
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
			btnCancel.TabIndex = 150;
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
			btnConfirm.TabIndex = 149;
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
			lblInstruction.TabIndex = 148;
			lblInstruction.Text = "Fill out the fields you would like to change.";
			// 
			// tbxRPM
			// 
			tbxRPM.BackColor = Color.FromArgb(4, 41, 58);
			tbxRPM.BorderStyle = BorderStyle.FixedSingle;
			tbxRPM.ForeColor = Color.FromArgb(236, 179, 101);
			tbxRPM.Location = new Point(60, 309);
			tbxRPM.Margin = new Padding(3, 2, 3, 2);
			tbxRPM.MaxLength = 7;
			tbxRPM.Name = "tbxRPM";
			tbxRPM.Size = new Size(69, 23);
			tbxRPM.TabIndex = 166;
			tbxRPM.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblRPM
			// 
			lblRPM.AutoSize = true;
			lblRPM.ForeColor = Color.FromArgb(236, 179, 101);
			lblRPM.Location = new Point(60, 283);
			lblRPM.Name = "lblRPM";
			lblRPM.Size = new Size(32, 15);
			lblRPM.TabIndex = 165;
			lblRPM.Text = "RPM";
			// 
			// tbxWriteSpeed
			// 
			tbxWriteSpeed.BackColor = Color.FromArgb(4, 41, 58);
			tbxWriteSpeed.BorderStyle = BorderStyle.FixedSingle;
			tbxWriteSpeed.ForeColor = Color.FromArgb(236, 179, 101);
			tbxWriteSpeed.Location = new Point(60, 237);
			tbxWriteSpeed.Margin = new Padding(3, 2, 3, 2);
			tbxWriteSpeed.MaxLength = 7;
			tbxWriteSpeed.Name = "tbxWriteSpeed";
			tbxWriteSpeed.Size = new Size(69, 23);
			tbxWriteSpeed.TabIndex = 164;
			tbxWriteSpeed.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblWriteSpeed
			// 
			lblWriteSpeed.AutoSize = true;
			lblWriteSpeed.ForeColor = Color.FromArgb(236, 179, 101);
			lblWriteSpeed.Location = new Point(60, 211);
			lblWriteSpeed.Name = "lblWriteSpeed";
			lblWriteSpeed.Size = new Size(109, 15);
			lblWriteSpeed.TabIndex = 163;
			lblWriteSpeed.Text = "Write Speed (MB/s)";
			// 
			// tbxReadSpeed
			// 
			tbxReadSpeed.BackColor = Color.FromArgb(4, 41, 58);
			tbxReadSpeed.BorderStyle = BorderStyle.FixedSingle;
			tbxReadSpeed.ForeColor = Color.FromArgb(236, 179, 101);
			tbxReadSpeed.Location = new Point(60, 158);
			tbxReadSpeed.Margin = new Padding(3, 2, 3, 2);
			tbxReadSpeed.MaxLength = 7;
			tbxReadSpeed.Name = "tbxReadSpeed";
			tbxReadSpeed.Size = new Size(69, 23);
			tbxReadSpeed.TabIndex = 162;
			tbxReadSpeed.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblReadSpeed
			// 
			lblReadSpeed.AutoSize = true;
			lblReadSpeed.ForeColor = Color.FromArgb(236, 179, 101);
			lblReadSpeed.Location = new Point(60, 132);
			lblReadSpeed.Name = "lblReadSpeed";
			lblReadSpeed.Size = new Size(107, 15);
			lblReadSpeed.TabIndex = 161;
			lblReadSpeed.Text = "Read Speed (MB/s)";
			// 
			// tbxCapacity
			// 
			tbxCapacity.BackColor = Color.FromArgb(4, 41, 58);
			tbxCapacity.BorderStyle = BorderStyle.FixedSingle;
			tbxCapacity.ForeColor = Color.FromArgb(236, 179, 101);
			tbxCapacity.Location = new Point(60, 82);
			tbxCapacity.Margin = new Padding(3, 2, 3, 2);
			tbxCapacity.MaxLength = 7;
			tbxCapacity.Name = "tbxCapacity";
			tbxCapacity.Size = new Size(69, 23);
			tbxCapacity.TabIndex = 160;
			tbxCapacity.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblCapacity
			// 
			lblCapacity.AutoSize = true;
			lblCapacity.ForeColor = Color.FromArgb(236, 179, 101);
			lblCapacity.Location = new Point(60, 56);
			lblCapacity.Name = "lblCapacity";
			lblCapacity.Size = new Size(79, 15);
			lblCapacity.TabIndex = 159;
			lblCapacity.Text = "Capacity (GB)";
			// 
			// lblHDD
			// 
			lblHDD.AutoSize = true;
			lblHDD.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblHDD.ForeColor = Color.FromArgb(236, 179, 101);
			lblHDD.Location = new Point(12, 9);
			lblHDD.Name = "lblHDD";
			lblHDD.Size = new Size(46, 21);
			lblHDD.TabIndex = 167;
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
			panel.Size = new Size(767, 492);
			panel.TabIndex = 168;
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
			// FormModifyHDD
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(4, 28, 50);
			ClientSize = new Size(767, 492);
			Controls.Add(lblHDD);
			Controls.Add(tbxRPM);
			Controls.Add(lblRPM);
			Controls.Add(tbxWriteSpeed);
			Controls.Add(lblWriteSpeed);
			Controls.Add(tbxReadSpeed);
			Controls.Add(lblReadSpeed);
			Controls.Add(tbxCapacity);
			Controls.Add(lblCapacity);
			Controls.Add(lblError);
			Controls.Add(btnCancel);
			Controls.Add(btnConfirm);
			Controls.Add(lblInstruction);
			Controls.Add(panel);
			FormBorderStyle = FormBorderStyle.None;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MinimizeBox = false;
			Name = "FormModifyHDD";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Modify HDD";
			panel.ResumeLayout(false);
			panel.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblError;
		private Button btnCancel;
		private Button btnConfirm;
		private Label lblInstruction;
		private TextBox tbxRPM;
		private Label lblRPM;
		private TextBox tbxWriteSpeed;
		private Label lblWriteSpeed;
		private TextBox tbxReadSpeed;
		private Label lblReadSpeed;
		private TextBox tbxCapacity;
		private Label lblCapacity;
		private Label lblHDD;
		private Panel panel;
		private Label label1;
	}
}