namespace WarehouseManager {
	partial class FormModifyCPU {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModifyCPU));
			lblInstruction = new Label();
			cbOverclockingSupport = new ComboBox();
			lblOverclockingSupport = new Label();
			tbxMaximumSupportedMemoryCapacity = new TextBox();
			lblMaximumSupportedMemoryCapacity = new Label();
			tbxNumberOfMemoryChannels = new TextBox();
			lblNumberOfMemoryChannels = new Label();
			tbxTDP = new TextBox();
			lblTDP = new Label();
			tbxL3CacheSize = new TextBox();
			lblL3CacheSize = new Label();
			tbxBoostClock = new TextBox();
			lblBoostClock = new Label();
			tbxBaseClock = new TextBox();
			lblBaseClock = new Label();
			tbxNumberOfThreads = new TextBox();
			lblNumberOfThreads = new Label();
			tbxNumberOfCores = new TextBox();
			lblNumberOfCores = new Label();
			tbxMicroarchitecture = new TextBox();
			lblMicroarchitecture = new Label();
			tbxSocketType = new TextBox();
			lblSocketType = new Label();
			lblError = new Label();
			btnCancel = new Button();
			btnConfirm = new Button();
			lblCPU = new Label();
			pbCrossClearOverclockingSupport = new PictureBox();
			panel = new Panel();
			lblCase = new Label();
			((System.ComponentModel.ISupportInitialize)pbCrossClearOverclockingSupport).BeginInit();
			panel.SuspendLayout();
			SuspendLayout();
			// 
			// lblInstruction
			// 
			lblInstruction.AutoSize = true;
			lblInstruction.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblInstruction.ForeColor = Color.FromArgb(236, 179, 101);
			lblInstruction.Location = new Point(229, 9);
			lblInstruction.Name = "lblInstruction";
			lblInstruction.Size = new Size(308, 20);
			lblInstruction.TabIndex = 46;
			lblInstruction.Text = "Fill out the fields you would like to change.";
			// 
			// cbOverclockingSupport
			// 
			cbOverclockingSupport.BackColor = Color.FromArgb(4, 41, 58);
			cbOverclockingSupport.DropDownStyle = ComboBoxStyle.DropDownList;
			cbOverclockingSupport.ForeColor = Color.FromArgb(236, 179, 101);
			cbOverclockingSupport.FormattingEnabled = true;
			cbOverclockingSupport.Items.AddRange(new object[] { "Yes", "No" });
			cbOverclockingSupport.Location = new Point(500, 82);
			cbOverclockingSupport.Margin = new Padding(3, 2, 3, 2);
			cbOverclockingSupport.Name = "cbOverclockingSupport";
			cbOverclockingSupport.Size = new Size(120, 23);
			cbOverclockingSupport.TabIndex = 68;
			// 
			// lblOverclockingSupport
			// 
			lblOverclockingSupport.AutoSize = true;
			lblOverclockingSupport.ForeColor = Color.FromArgb(236, 179, 101);
			lblOverclockingSupport.Location = new Point(500, 56);
			lblOverclockingSupport.Name = "lblOverclockingSupport";
			lblOverclockingSupport.Size = new Size(122, 15);
			lblOverclockingSupport.TabIndex = 67;
			lblOverclockingSupport.Text = "Overclocking Support";
			// 
			// tbxMaximumSupportedMemoryCapacity
			// 
			tbxMaximumSupportedMemoryCapacity.BackColor = Color.FromArgb(4, 41, 58);
			tbxMaximumSupportedMemoryCapacity.BorderStyle = BorderStyle.FixedSingle;
			tbxMaximumSupportedMemoryCapacity.ForeColor = Color.FromArgb(236, 179, 101);
			tbxMaximumSupportedMemoryCapacity.Location = new Point(338, 233);
			tbxMaximumSupportedMemoryCapacity.Margin = new Padding(3, 2, 3, 2);
			tbxMaximumSupportedMemoryCapacity.MaxLength = 7;
			tbxMaximumSupportedMemoryCapacity.Name = "tbxMaximumSupportedMemoryCapacity";
			tbxMaximumSupportedMemoryCapacity.Size = new Size(69, 23);
			tbxMaximumSupportedMemoryCapacity.TabIndex = 66;
			tbxMaximumSupportedMemoryCapacity.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblMaximumSupportedMemoryCapacity
			// 
			lblMaximumSupportedMemoryCapacity.AutoSize = true;
			lblMaximumSupportedMemoryCapacity.ForeColor = Color.FromArgb(236, 179, 101);
			lblMaximumSupportedMemoryCapacity.Location = new Point(338, 207);
			lblMaximumSupportedMemoryCapacity.Name = "lblMaximumSupportedMemoryCapacity";
			lblMaximumSupportedMemoryCapacity.Size = new Size(242, 15);
			lblMaximumSupportedMemoryCapacity.TabIndex = 65;
			lblMaximumSupportedMemoryCapacity.Text = "Maximum Supported Memory Capacity (GB)";
			// 
			// tbxNumberOfMemoryChannels
			// 
			tbxNumberOfMemoryChannels.BackColor = Color.FromArgb(4, 41, 58);
			tbxNumberOfMemoryChannels.BorderStyle = BorderStyle.FixedSingle;
			tbxNumberOfMemoryChannels.ForeColor = Color.FromArgb(236, 179, 101);
			tbxNumberOfMemoryChannels.Location = new Point(338, 309);
			tbxNumberOfMemoryChannels.Margin = new Padding(3, 2, 3, 2);
			tbxNumberOfMemoryChannels.MaxLength = 7;
			tbxNumberOfMemoryChannels.Name = "tbxNumberOfMemoryChannels";
			tbxNumberOfMemoryChannels.Size = new Size(69, 23);
			tbxNumberOfMemoryChannels.TabIndex = 64;
			tbxNumberOfMemoryChannels.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblNumberOfMemoryChannels
			// 
			lblNumberOfMemoryChannels.AutoSize = true;
			lblNumberOfMemoryChannels.ForeColor = Color.FromArgb(236, 179, 101);
			lblNumberOfMemoryChannels.Location = new Point(338, 283);
			lblNumberOfMemoryChannels.Name = "lblNumberOfMemoryChannels";
			lblNumberOfMemoryChannels.Size = new Size(167, 15);
			lblNumberOfMemoryChannels.TabIndex = 63;
			lblNumberOfMemoryChannels.Text = "Number Of Memory Channels";
			// 
			// tbxTDP
			// 
			tbxTDP.BackColor = Color.FromArgb(4, 41, 58);
			tbxTDP.BorderStyle = BorderStyle.FixedSingle;
			tbxTDP.ForeColor = Color.FromArgb(236, 179, 101);
			tbxTDP.Location = new Point(338, 388);
			tbxTDP.Margin = new Padding(3, 2, 3, 2);
			tbxTDP.MaxLength = 7;
			tbxTDP.Name = "tbxTDP";
			tbxTDP.Size = new Size(69, 23);
			tbxTDP.TabIndex = 62;
			tbxTDP.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblTDP
			// 
			lblTDP.AutoSize = true;
			lblTDP.ForeColor = Color.FromArgb(236, 179, 101);
			lblTDP.Location = new Point(338, 362);
			lblTDP.Name = "lblTDP";
			lblTDP.Size = new Size(51, 15);
			lblTDP.TabIndex = 61;
			lblTDP.Text = "TDP (W)";
			// 
			// tbxL3CacheSize
			// 
			tbxL3CacheSize.BackColor = Color.FromArgb(4, 41, 58);
			tbxL3CacheSize.BorderStyle = BorderStyle.FixedSingle;
			tbxL3CacheSize.ForeColor = Color.FromArgb(236, 179, 101);
			tbxL3CacheSize.Location = new Point(338, 157);
			tbxL3CacheSize.Margin = new Padding(3, 2, 3, 2);
			tbxL3CacheSize.MaxLength = 7;
			tbxL3CacheSize.Name = "tbxL3CacheSize";
			tbxL3CacheSize.Size = new Size(69, 23);
			tbxL3CacheSize.TabIndex = 60;
			tbxL3CacheSize.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblL3CacheSize
			// 
			lblL3CacheSize.AutoSize = true;
			lblL3CacheSize.ForeColor = Color.FromArgb(236, 179, 101);
			lblL3CacheSize.Location = new Point(338, 131);
			lblL3CacheSize.Name = "lblL3CacheSize";
			lblL3CacheSize.Size = new Size(107, 15);
			lblL3CacheSize.TabIndex = 59;
			lblL3CacheSize.Text = "L3 Cache Size (MB)";
			// 
			// tbxBoostClock
			// 
			tbxBoostClock.BackColor = Color.FromArgb(4, 41, 58);
			tbxBoostClock.BorderStyle = BorderStyle.FixedSingle;
			tbxBoostClock.ForeColor = Color.FromArgb(236, 179, 101);
			tbxBoostClock.Location = new Point(338, 82);
			tbxBoostClock.Margin = new Padding(3, 2, 3, 2);
			tbxBoostClock.MaxLength = 7;
			tbxBoostClock.Name = "tbxBoostClock";
			tbxBoostClock.Size = new Size(69, 23);
			tbxBoostClock.TabIndex = 58;
			tbxBoostClock.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblBoostClock
			// 
			lblBoostClock.AutoSize = true;
			lblBoostClock.ForeColor = Color.FromArgb(236, 179, 101);
			lblBoostClock.Location = new Point(338, 56);
			lblBoostClock.Name = "lblBoostClock";
			lblBoostClock.Size = new Size(106, 15);
			lblBoostClock.TabIndex = 57;
			lblBoostClock.Text = "Boost Clock (MHz)";
			// 
			// tbxBaseClock
			// 
			tbxBaseClock.BackColor = Color.FromArgb(4, 41, 58);
			tbxBaseClock.BorderStyle = BorderStyle.FixedSingle;
			tbxBaseClock.ForeColor = Color.FromArgb(236, 179, 101);
			tbxBaseClock.Location = new Point(61, 388);
			tbxBaseClock.Margin = new Padding(3, 2, 3, 2);
			tbxBaseClock.MaxLength = 7;
			tbxBaseClock.Name = "tbxBaseClock";
			tbxBaseClock.Size = new Size(69, 23);
			tbxBaseClock.TabIndex = 56;
			tbxBaseClock.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblBaseClock
			// 
			lblBaseClock.AutoSize = true;
			lblBaseClock.ForeColor = Color.FromArgb(236, 179, 101);
			lblBaseClock.Location = new Point(61, 362);
			lblBaseClock.Name = "lblBaseClock";
			lblBaseClock.Size = new Size(100, 15);
			lblBaseClock.TabIndex = 55;
			lblBaseClock.Text = "Base Clock (MHz)";
			// 
			// tbxNumberOfThreads
			// 
			tbxNumberOfThreads.BackColor = Color.FromArgb(4, 41, 58);
			tbxNumberOfThreads.BorderStyle = BorderStyle.FixedSingle;
			tbxNumberOfThreads.ForeColor = Color.FromArgb(236, 179, 101);
			tbxNumberOfThreads.Location = new Point(61, 309);
			tbxNumberOfThreads.Margin = new Padding(3, 2, 3, 2);
			tbxNumberOfThreads.MaxLength = 7;
			tbxNumberOfThreads.Name = "tbxNumberOfThreads";
			tbxNumberOfThreads.Size = new Size(69, 23);
			tbxNumberOfThreads.TabIndex = 54;
			tbxNumberOfThreads.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblNumberOfThreads
			// 
			lblNumberOfThreads.AutoSize = true;
			lblNumberOfThreads.ForeColor = Color.FromArgb(236, 179, 101);
			lblNumberOfThreads.Location = new Point(61, 283);
			lblNumberOfThreads.Name = "lblNumberOfThreads";
			lblNumberOfThreads.Size = new Size(112, 15);
			lblNumberOfThreads.TabIndex = 53;
			lblNumberOfThreads.Text = "Number Of Threads";
			// 
			// tbxNumberOfCores
			// 
			tbxNumberOfCores.BackColor = Color.FromArgb(4, 41, 58);
			tbxNumberOfCores.BorderStyle = BorderStyle.FixedSingle;
			tbxNumberOfCores.ForeColor = Color.FromArgb(236, 179, 101);
			tbxNumberOfCores.Location = new Point(61, 233);
			tbxNumberOfCores.Margin = new Padding(3, 2, 3, 2);
			tbxNumberOfCores.MaxLength = 7;
			tbxNumberOfCores.Name = "tbxNumberOfCores";
			tbxNumberOfCores.Size = new Size(69, 23);
			tbxNumberOfCores.TabIndex = 52;
			tbxNumberOfCores.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblNumberOfCores
			// 
			lblNumberOfCores.AutoSize = true;
			lblNumberOfCores.ForeColor = Color.FromArgb(236, 179, 101);
			lblNumberOfCores.Location = new Point(61, 207);
			lblNumberOfCores.Name = "lblNumberOfCores";
			lblNumberOfCores.Size = new Size(100, 15);
			lblNumberOfCores.TabIndex = 51;
			lblNumberOfCores.Text = "Number Of Cores";
			// 
			// tbxMicroarchitecture
			// 
			tbxMicroarchitecture.BackColor = Color.FromArgb(4, 41, 58);
			tbxMicroarchitecture.BorderStyle = BorderStyle.FixedSingle;
			tbxMicroarchitecture.ForeColor = Color.FromArgb(236, 179, 101);
			tbxMicroarchitecture.Location = new Point(60, 157);
			tbxMicroarchitecture.Margin = new Padding(3, 2, 3, 2);
			tbxMicroarchitecture.MaxLength = 20;
			tbxMicroarchitecture.Name = "tbxMicroarchitecture";
			tbxMicroarchitecture.Size = new Size(214, 23);
			tbxMicroarchitecture.TabIndex = 50;
			tbxMicroarchitecture.KeyPress += StringTextBoxes_KeyPress;
			// 
			// lblMicroarchitecture
			// 
			lblMicroarchitecture.AutoSize = true;
			lblMicroarchitecture.ForeColor = Color.FromArgb(236, 179, 101);
			lblMicroarchitecture.Location = new Point(60, 131);
			lblMicroarchitecture.Name = "lblMicroarchitecture";
			lblMicroarchitecture.Size = new Size(101, 15);
			lblMicroarchitecture.TabIndex = 49;
			lblMicroarchitecture.Text = "Microarchitecture";
			// 
			// tbxSocketType
			// 
			tbxSocketType.BackColor = Color.FromArgb(4, 41, 58);
			tbxSocketType.BorderStyle = BorderStyle.FixedSingle;
			tbxSocketType.ForeColor = Color.FromArgb(236, 179, 101);
			tbxSocketType.Location = new Point(60, 82);
			tbxSocketType.Margin = new Padding(3, 2, 3, 2);
			tbxSocketType.MaxLength = 20;
			tbxSocketType.Name = "tbxSocketType";
			tbxSocketType.Size = new Size(214, 23);
			tbxSocketType.TabIndex = 48;
			tbxSocketType.KeyPress += StringTextBoxes_KeyPress;
			// 
			// lblSocketType
			// 
			lblSocketType.AutoSize = true;
			lblSocketType.ForeColor = Color.FromArgb(236, 179, 101);
			lblSocketType.Location = new Point(60, 56);
			lblSocketType.Name = "lblSocketType";
			lblSocketType.Size = new Size(70, 15);
			lblSocketType.TabIndex = 47;
			lblSocketType.Text = "Socket Type";
			// 
			// lblError
			// 
			lblError.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblError.ForeColor = Color.FromArgb(244, 43, 50);
			lblError.Location = new Point(107, 443);
			lblError.Name = "lblError";
			lblError.Size = new Size(406, 36);
			lblError.TabIndex = 71;
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
			btnCancel.TabIndex = 70;
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
			btnConfirm.TabIndex = 69;
			btnConfirm.Text = "Confirm";
			btnConfirm.UseVisualStyleBackColor = false;
			btnConfirm.Click += btnConfirm_Click;
			// 
			// lblCPU
			// 
			lblCPU.AutoSize = true;
			lblCPU.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblCPU.ForeColor = Color.FromArgb(236, 179, 101);
			lblCPU.Location = new Point(12, 9);
			lblCPU.Name = "lblCPU";
			lblCPU.Size = new Size(42, 21);
			lblCPU.TabIndex = 95;
			lblCPU.Text = "CPU";
			// 
			// pbCrossClearOverclockingSupport
			// 
			pbCrossClearOverclockingSupport.BackColor = Color.Transparent;
			pbCrossClearOverclockingSupport.Cursor = Cursors.Hand;
			pbCrossClearOverclockingSupport.Image = Properties.Resources.Cross_Red;
			pbCrossClearOverclockingSupport.Location = new Point(471, 82);
			pbCrossClearOverclockingSupport.Name = "pbCrossClearOverclockingSupport";
			pbCrossClearOverclockingSupport.Size = new Size(23, 23);
			pbCrossClearOverclockingSupport.SizeMode = PictureBoxSizeMode.AutoSize;
			pbCrossClearOverclockingSupport.TabIndex = 96;
			pbCrossClearOverclockingSupport.TabStop = false;
			pbCrossClearOverclockingSupport.Click += pbCrossClearOverclockingSupport_Click;
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
			// FormModifyCPU
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(4, 28, 50);
			ClientSize = new Size(767, 492);
			Controls.Add(pbCrossClearOverclockingSupport);
			Controls.Add(lblCPU);
			Controls.Add(lblError);
			Controls.Add(btnCancel);
			Controls.Add(btnConfirm);
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
			Controls.Add(lblInstruction);
			Controls.Add(panel);
			FormBorderStyle = FormBorderStyle.None;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			Name = "FormModifyCPU";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Modify CPU";
			((System.ComponentModel.ISupportInitialize)pbCrossClearOverclockingSupport).EndInit();
			panel.ResumeLayout(false);
			panel.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblInstruction;
		private ComboBox cbOverclockingSupport;
		private Label lblOverclockingSupport;
		private TextBox tbxMaximumSupportedMemoryCapacity;
		private Label lblMaximumSupportedMemoryCapacity;
		private TextBox tbxNumberOfMemoryChannels;
		private Label lblNumberOfMemoryChannels;
		private TextBox tbxTDP;
		private Label lblTDP;
		private TextBox tbxL3CacheSize;
		private Label lblL3CacheSize;
		private TextBox tbxBoostClock;
		private Label lblBoostClock;
		private TextBox tbxBaseClock;
		private Label lblBaseClock;
		private TextBox tbxNumberOfThreads;
		private Label lblNumberOfThreads;
		private TextBox tbxNumberOfCores;
		private Label lblNumberOfCores;
		private TextBox tbxMicroarchitecture;
		private Label lblMicroarchitecture;
		private TextBox tbxSocketType;
		private Label lblSocketType;
		private Label lblError;
		private Button btnCancel;
		private Button btnConfirm;
		private Label lblCPU;
		private PictureBox pbCrossClearOverclockingSupport;
		private Panel panel;
		private Label lblCase;
	}
}