namespace WarehouseManager {
	partial class FormModifyRAMKit {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModifyRAMKit));
			lblError = new Label();
			btnCancel = new Button();
			btnConfirm = new Button();
			lblInstruction = new Label();
			cbMemoryType = new ComboBox();
			lblMemoryType = new Label();
			tbxNumberOfModules = new TextBox();
			lblNumberOfModules = new Label();
			tbxModuleCapacity = new TextBox();
			lblModuleCapacity = new Label();
			cbEXPOSupport = new ComboBox();
			lblEXPOSupport = new Label();
			cbXMPSupport = new ComboBox();
			lblXMPSupport = new Label();
			tbxCASLatency = new TextBox();
			lblCASLatency = new Label();
			tbxSpeed = new TextBox();
			lblSpeed = new Label();
			lblRAMKit = new Label();
			pbCrossClearXMPSupport = new PictureBox();
			pbCrossClearMemoryType = new PictureBox();
			pbCrossClearEXPOSupport = new PictureBox();
			panel = new Panel();
			lblCase = new Label();
			((System.ComponentModel.ISupportInitialize)pbCrossClearXMPSupport).BeginInit();
			((System.ComponentModel.ISupportInitialize)pbCrossClearMemoryType).BeginInit();
			((System.ComponentModel.ISupportInitialize)pbCrossClearEXPOSupport).BeginInit();
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
			// cbMemoryType
			// 
			cbMemoryType.BackColor = Color.FromArgb(4, 41, 58);
			cbMemoryType.DropDownStyle = ComboBoxStyle.DropDownList;
			cbMemoryType.ForeColor = Color.FromArgb(236, 179, 101);
			cbMemoryType.FormattingEnabled = true;
			cbMemoryType.Items.AddRange(new object[] { "DDR3", "DDR4", "DDR5" });
			cbMemoryType.Location = new Point(60, 233);
			cbMemoryType.Margin = new Padding(3, 2, 3, 2);
			cbMemoryType.Name = "cbMemoryType";
			cbMemoryType.Size = new Size(120, 23);
			cbMemoryType.TabIndex = 99;
			// 
			// lblMemoryType
			// 
			lblMemoryType.AutoSize = true;
			lblMemoryType.ForeColor = Color.FromArgb(236, 179, 101);
			lblMemoryType.Location = new Point(60, 207);
			lblMemoryType.Name = "lblMemoryType";
			lblMemoryType.Size = new Size(80, 15);
			lblMemoryType.TabIndex = 98;
			lblMemoryType.Text = "Memory Type";
			// 
			// tbxNumberOfModules
			// 
			tbxNumberOfModules.BackColor = Color.FromArgb(4, 41, 58);
			tbxNumberOfModules.BorderStyle = BorderStyle.FixedSingle;
			tbxNumberOfModules.ForeColor = Color.FromArgb(236, 179, 101);
			tbxNumberOfModules.Location = new Point(60, 158);
			tbxNumberOfModules.Margin = new Padding(3, 2, 3, 2);
			tbxNumberOfModules.MaxLength = 7;
			tbxNumberOfModules.Name = "tbxNumberOfModules";
			tbxNumberOfModules.Size = new Size(69, 23);
			tbxNumberOfModules.TabIndex = 97;
			tbxNumberOfModules.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblNumberOfModules
			// 
			lblNumberOfModules.AutoSize = true;
			lblNumberOfModules.ForeColor = Color.FromArgb(236, 179, 101);
			lblNumberOfModules.Location = new Point(60, 132);
			lblNumberOfModules.Name = "lblNumberOfModules";
			lblNumberOfModules.Size = new Size(116, 15);
			lblNumberOfModules.TabIndex = 96;
			lblNumberOfModules.Text = "Number Of Modules";
			// 
			// tbxModuleCapacity
			// 
			tbxModuleCapacity.BackColor = Color.FromArgb(4, 41, 58);
			tbxModuleCapacity.BorderStyle = BorderStyle.FixedSingle;
			tbxModuleCapacity.ForeColor = Color.FromArgb(236, 179, 101);
			tbxModuleCapacity.Location = new Point(60, 82);
			tbxModuleCapacity.Margin = new Padding(3, 2, 3, 2);
			tbxModuleCapacity.MaxLength = 7;
			tbxModuleCapacity.Name = "tbxModuleCapacity";
			tbxModuleCapacity.Size = new Size(69, 23);
			tbxModuleCapacity.TabIndex = 95;
			tbxModuleCapacity.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblModuleCapacity
			// 
			lblModuleCapacity.AutoSize = true;
			lblModuleCapacity.ForeColor = Color.FromArgb(236, 179, 101);
			lblModuleCapacity.Location = new Point(60, 56);
			lblModuleCapacity.Name = "lblModuleCapacity";
			lblModuleCapacity.Size = new Size(123, 15);
			lblModuleCapacity.TabIndex = 94;
			lblModuleCapacity.Text = "Module Capacity (GB)";
			// 
			// cbEXPOSupport
			// 
			cbEXPOSupport.BackColor = Color.FromArgb(4, 41, 58);
			cbEXPOSupport.DropDownStyle = ComboBoxStyle.DropDownList;
			cbEXPOSupport.ForeColor = Color.FromArgb(236, 179, 101);
			cbEXPOSupport.FormattingEnabled = true;
			cbEXPOSupport.Items.AddRange(new object[] { "Yes", "No" });
			cbEXPOSupport.Location = new Point(235, 157);
			cbEXPOSupport.Margin = new Padding(3, 2, 3, 2);
			cbEXPOSupport.Name = "cbEXPOSupport";
			cbEXPOSupport.Size = new Size(120, 23);
			cbEXPOSupport.TabIndex = 93;
			// 
			// lblEXPOSupport
			// 
			lblEXPOSupport.AutoSize = true;
			lblEXPOSupport.ForeColor = Color.FromArgb(236, 179, 101);
			lblEXPOSupport.Location = new Point(235, 131);
			lblEXPOSupport.Name = "lblEXPOSupport";
			lblEXPOSupport.Size = new Size(81, 15);
			lblEXPOSupport.TabIndex = 92;
			lblEXPOSupport.Text = "EXPO Support";
			// 
			// cbXMPSupport
			// 
			cbXMPSupport.BackColor = Color.FromArgb(4, 41, 58);
			cbXMPSupport.DropDownStyle = ComboBoxStyle.DropDownList;
			cbXMPSupport.ForeColor = Color.FromArgb(236, 179, 101);
			cbXMPSupport.FormattingEnabled = true;
			cbXMPSupport.Items.AddRange(new object[] { "Yes", "No" });
			cbXMPSupport.Location = new Point(235, 82);
			cbXMPSupport.Margin = new Padding(3, 2, 3, 2);
			cbXMPSupport.Name = "cbXMPSupport";
			cbXMPSupport.Size = new Size(120, 23);
			cbXMPSupport.TabIndex = 91;
			// 
			// lblXMPSupport
			// 
			lblXMPSupport.AutoSize = true;
			lblXMPSupport.ForeColor = Color.FromArgb(236, 179, 101);
			lblXMPSupport.Location = new Point(235, 56);
			lblXMPSupport.Name = "lblXMPSupport";
			lblXMPSupport.Size = new Size(77, 15);
			lblXMPSupport.TabIndex = 90;
			lblXMPSupport.Text = "XMP Support";
			// 
			// tbxCASLatency
			// 
			tbxCASLatency.BackColor = Color.FromArgb(4, 41, 58);
			tbxCASLatency.BorderStyle = BorderStyle.FixedSingle;
			tbxCASLatency.ForeColor = Color.FromArgb(236, 179, 101);
			tbxCASLatency.Location = new Point(60, 388);
			tbxCASLatency.Margin = new Padding(3, 2, 3, 2);
			tbxCASLatency.MaxLength = 7;
			tbxCASLatency.Name = "tbxCASLatency";
			tbxCASLatency.Size = new Size(69, 23);
			tbxCASLatency.TabIndex = 89;
			tbxCASLatency.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblCASLatency
			// 
			lblCASLatency.AutoSize = true;
			lblCASLatency.ForeColor = Color.FromArgb(236, 179, 101);
			lblCASLatency.Location = new Point(60, 362);
			lblCASLatency.Name = "lblCASLatency";
			lblCASLatency.Size = new Size(73, 15);
			lblCASLatency.TabIndex = 88;
			lblCASLatency.Text = "CAS Latency";
			// 
			// tbxSpeed
			// 
			tbxSpeed.BackColor = Color.FromArgb(4, 41, 58);
			tbxSpeed.BorderStyle = BorderStyle.FixedSingle;
			tbxSpeed.ForeColor = Color.FromArgb(236, 179, 101);
			tbxSpeed.Location = new Point(60, 309);
			tbxSpeed.Margin = new Padding(3, 2, 3, 2);
			tbxSpeed.MaxLength = 7;
			tbxSpeed.Name = "tbxSpeed";
			tbxSpeed.Size = new Size(69, 23);
			tbxSpeed.TabIndex = 87;
			tbxSpeed.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblSpeed
			// 
			lblSpeed.AutoSize = true;
			lblSpeed.ForeColor = Color.FromArgb(236, 179, 101);
			lblSpeed.Location = new Point(60, 283);
			lblSpeed.Name = "lblSpeed";
			lblSpeed.Size = new Size(78, 15);
			lblSpeed.TabIndex = 86;
			lblSpeed.Text = "Speed (MT/s)";
			// 
			// lblRAMKit
			// 
			lblRAMKit.AutoSize = true;
			lblRAMKit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblRAMKit.ForeColor = Color.FromArgb(236, 179, 101);
			lblRAMKit.Location = new Point(12, 9);
			lblRAMKit.Name = "lblRAMKit";
			lblRAMKit.Size = new Size(71, 21);
			lblRAMKit.TabIndex = 103;
			lblRAMKit.Text = "RAM Kit";
			// 
			// pbCrossClearXMPSupport
			// 
			pbCrossClearXMPSupport.BackColor = Color.Transparent;
			pbCrossClearXMPSupport.Cursor = Cursors.Hand;
			pbCrossClearXMPSupport.Image = Properties.Resources.Cross_Red;
			pbCrossClearXMPSupport.Location = new Point(206, 82);
			pbCrossClearXMPSupport.Name = "pbCrossClearXMPSupport";
			pbCrossClearXMPSupport.Size = new Size(23, 23);
			pbCrossClearXMPSupport.SizeMode = PictureBoxSizeMode.AutoSize;
			pbCrossClearXMPSupport.TabIndex = 104;
			pbCrossClearXMPSupport.TabStop = false;
			pbCrossClearXMPSupport.Click += pbCrossClearXMPSupport_Click;
			// 
			// pbCrossClearMemoryType
			// 
			pbCrossClearMemoryType.BackColor = Color.Transparent;
			pbCrossClearMemoryType.Cursor = Cursors.Hand;
			pbCrossClearMemoryType.Image = Properties.Resources.Cross_Red;
			pbCrossClearMemoryType.Location = new Point(31, 233);
			pbCrossClearMemoryType.Name = "pbCrossClearMemoryType";
			pbCrossClearMemoryType.Size = new Size(23, 23);
			pbCrossClearMemoryType.SizeMode = PictureBoxSizeMode.AutoSize;
			pbCrossClearMemoryType.TabIndex = 105;
			pbCrossClearMemoryType.TabStop = false;
			pbCrossClearMemoryType.Click += pbCrossClearMemoryType_Click;
			// 
			// pbCrossClearEXPOSupport
			// 
			pbCrossClearEXPOSupport.BackColor = Color.Transparent;
			pbCrossClearEXPOSupport.Cursor = Cursors.Hand;
			pbCrossClearEXPOSupport.Image = Properties.Resources.Cross_Red;
			pbCrossClearEXPOSupport.Location = new Point(206, 158);
			pbCrossClearEXPOSupport.Name = "pbCrossClearEXPOSupport";
			pbCrossClearEXPOSupport.Size = new Size(23, 23);
			pbCrossClearEXPOSupport.SizeMode = PictureBoxSizeMode.AutoSize;
			pbCrossClearEXPOSupport.TabIndex = 106;
			pbCrossClearEXPOSupport.TabStop = false;
			pbCrossClearEXPOSupport.Click += pbCrossClearEXPOSupport_Click;
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
			panel.TabIndex = 107;
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
			// FormModifyRAMKit
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(4, 28, 50);
			ClientSize = new Size(767, 492);
			Controls.Add(pbCrossClearEXPOSupport);
			Controls.Add(pbCrossClearMemoryType);
			Controls.Add(pbCrossClearXMPSupport);
			Controls.Add(lblRAMKit);
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
			Controls.Add(tbxCASLatency);
			Controls.Add(lblCASLatency);
			Controls.Add(tbxSpeed);
			Controls.Add(lblSpeed);
			Controls.Add(lblError);
			Controls.Add(btnCancel);
			Controls.Add(btnConfirm);
			Controls.Add(lblInstruction);
			Controls.Add(panel);
			FormBorderStyle = FormBorderStyle.None;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			Name = "FormModifyRAMKit";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Modify RAM Kit";
			((System.ComponentModel.ISupportInitialize)pbCrossClearXMPSupport).EndInit();
			((System.ComponentModel.ISupportInitialize)pbCrossClearMemoryType).EndInit();
			((System.ComponentModel.ISupportInitialize)pbCrossClearEXPOSupport).EndInit();
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
		private ComboBox cbMemoryType;
		private Label lblMemoryType;
		private TextBox tbxNumberOfModules;
		private Label lblNumberOfModules;
		private TextBox tbxModuleCapacity;
		private Label lblModuleCapacity;
		private ComboBox cbEXPOSupport;
		private Label lblEXPOSupport;
		private ComboBox cbXMPSupport;
		private Label lblXMPSupport;
		private TextBox tbxCASLatency;
		private Label lblCASLatency;
		private TextBox tbxSpeed;
		private Label lblSpeed;
		private Label lblRAMKit;
		private PictureBox pbCrossClearXMPSupport;
		private PictureBox pbCrossClearMemoryType;
		private PictureBox pbCrossClearEXPOSupport;
		private Panel panel;
		private Label lblCase;
	}
}