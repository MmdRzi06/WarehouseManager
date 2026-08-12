namespace WarehouseManager {
	partial class FormModifyPSU {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModifyPSU));
			lblInstruction = new Label();
			lblError = new Label();
			btnCancel = new Button();
			btnConfirm = new Button();
			cbFormFactor = new ComboBox();
			lblFormFactor = new Label();
			cbModularity = new ComboBox();
			lblModularity = new Label();
			tbxWattage = new TextBox();
			lblWattage = new Label();
			cbEfficiencyRating = new ComboBox();
			lblEfficiencyRating = new Label();
			pbCrossClearEfficiencyRating = new PictureBox();
			pbCrossClearModularity = new PictureBox();
			pbCrossClearFormFactor = new PictureBox();
			lblPSU = new Label();
			panel = new Panel();
			lblCase = new Label();
			((System.ComponentModel.ISupportInitialize)pbCrossClearEfficiencyRating).BeginInit();
			((System.ComponentModel.ISupportInitialize)pbCrossClearModularity).BeginInit();
			((System.ComponentModel.ISupportInitialize)pbCrossClearFormFactor).BeginInit();
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
			lblInstruction.TabIndex = 49;
			lblInstruction.Text = "Fill out the fields you would like to change.";
			// 
			// lblError
			// 
			lblError.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblError.ForeColor = Color.FromArgb(244, 43, 50);
			lblError.Location = new Point(107, 443);
			lblError.Name = "lblError";
			lblError.Size = new Size(406, 36);
			lblError.TabIndex = 48;
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
			btnCancel.TabIndex = 47;
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
			btnConfirm.TabIndex = 46;
			btnConfirm.Text = "Confirm";
			btnConfirm.UseVisualStyleBackColor = false;
			btnConfirm.Click += btnConfirm_Click;
			// 
			// cbFormFactor
			// 
			cbFormFactor.BackColor = Color.FromArgb(4, 41, 58);
			cbFormFactor.DropDownStyle = ComboBoxStyle.DropDownList;
			cbFormFactor.ForeColor = Color.FromArgb(236, 179, 101);
			cbFormFactor.FormattingEnabled = true;
			cbFormFactor.Items.AddRange(new object[] { "SFX", "SFX-L", "ATX" });
			cbFormFactor.Location = new Point(60, 309);
			cbFormFactor.Margin = new Padding(3, 2, 3, 2);
			cbFormFactor.Name = "cbFormFactor";
			cbFormFactor.Size = new Size(120, 23);
			cbFormFactor.TabIndex = 62;
			// 
			// lblFormFactor
			// 
			lblFormFactor.AutoSize = true;
			lblFormFactor.ForeColor = Color.FromArgb(236, 179, 101);
			lblFormFactor.Location = new Point(60, 283);
			lblFormFactor.Name = "lblFormFactor";
			lblFormFactor.Size = new Size(71, 15);
			lblFormFactor.TabIndex = 61;
			lblFormFactor.Text = "Form Factor";
			// 
			// cbModularity
			// 
			cbModularity.BackColor = Color.FromArgb(4, 41, 58);
			cbModularity.DropDownStyle = ComboBoxStyle.DropDownList;
			cbModularity.ForeColor = Color.FromArgb(236, 179, 101);
			cbModularity.FormattingEnabled = true;
			cbModularity.Items.AddRange(new object[] { "Non-Modular", "Semi-Modular", "Fully Modular" });
			cbModularity.Location = new Point(60, 233);
			cbModularity.Margin = new Padding(3, 2, 3, 2);
			cbModularity.Name = "cbModularity";
			cbModularity.Size = new Size(120, 23);
			cbModularity.TabIndex = 60;
			// 
			// lblModularity
			// 
			lblModularity.AutoSize = true;
			lblModularity.ForeColor = Color.FromArgb(236, 179, 101);
			lblModularity.Location = new Point(60, 207);
			lblModularity.Name = "lblModularity";
			lblModularity.Size = new Size(65, 15);
			lblModularity.TabIndex = 59;
			lblModularity.Text = "Modularity";
			// 
			// tbxWattage
			// 
			tbxWattage.BackColor = Color.FromArgb(4, 41, 58);
			tbxWattage.BorderStyle = BorderStyle.FixedSingle;
			tbxWattage.ForeColor = Color.FromArgb(236, 179, 101);
			tbxWattage.Location = new Point(60, 82);
			tbxWattage.Margin = new Padding(3, 2, 3, 2);
			tbxWattage.MaxLength = 7;
			tbxWattage.Name = "tbxWattage";
			tbxWattage.Size = new Size(69, 23);
			tbxWattage.TabIndex = 58;
			tbxWattage.KeyPress += IntTextBoxes_KeyPress;
			// 
			// lblWattage
			// 
			lblWattage.AutoSize = true;
			lblWattage.ForeColor = Color.FromArgb(236, 179, 101);
			lblWattage.Location = new Point(60, 56);
			lblWattage.Name = "lblWattage";
			lblWattage.Size = new Size(51, 15);
			lblWattage.TabIndex = 57;
			lblWattage.Text = "Wattage";
			// 
			// cbEfficiencyRating
			// 
			cbEfficiencyRating.BackColor = Color.FromArgb(4, 41, 58);
			cbEfficiencyRating.DropDownStyle = ComboBoxStyle.DropDownList;
			cbEfficiencyRating.ForeColor = Color.FromArgb(236, 179, 101);
			cbEfficiencyRating.FormattingEnabled = true;
			cbEfficiencyRating.Items.AddRange(new object[] { "80+", "80+ Bronze", "80+ Silver", "80+ Gold", "80+ Platinum", "80+ Titanium" });
			cbEfficiencyRating.Location = new Point(60, 157);
			cbEfficiencyRating.Margin = new Padding(3, 2, 3, 2);
			cbEfficiencyRating.Name = "cbEfficiencyRating";
			cbEfficiencyRating.Size = new Size(120, 23);
			cbEfficiencyRating.TabIndex = 56;
			// 
			// lblEfficiencyRating
			// 
			lblEfficiencyRating.AutoSize = true;
			lblEfficiencyRating.ForeColor = Color.FromArgb(236, 179, 101);
			lblEfficiencyRating.Location = new Point(60, 131);
			lblEfficiencyRating.Name = "lblEfficiencyRating";
			lblEfficiencyRating.Size = new Size(95, 15);
			lblEfficiencyRating.TabIndex = 55;
			lblEfficiencyRating.Text = "Efficiency Rating";
			// 
			// pbCrossClearEfficiencyRating
			// 
			pbCrossClearEfficiencyRating.BackColor = Color.Transparent;
			pbCrossClearEfficiencyRating.Cursor = Cursors.Hand;
			pbCrossClearEfficiencyRating.Image = Properties.Resources.Cross_Red;
			pbCrossClearEfficiencyRating.Location = new Point(31, 157);
			pbCrossClearEfficiencyRating.Name = "pbCrossClearEfficiencyRating";
			pbCrossClearEfficiencyRating.Size = new Size(23, 23);
			pbCrossClearEfficiencyRating.SizeMode = PictureBoxSizeMode.AutoSize;
			pbCrossClearEfficiencyRating.TabIndex = 80;
			pbCrossClearEfficiencyRating.TabStop = false;
			pbCrossClearEfficiencyRating.Click += pbCrossClearEfficiencyRating_Click;
			// 
			// pbCrossClearModularity
			// 
			pbCrossClearModularity.BackColor = Color.Transparent;
			pbCrossClearModularity.Cursor = Cursors.Hand;
			pbCrossClearModularity.Image = Properties.Resources.Cross_Red;
			pbCrossClearModularity.Location = new Point(31, 233);
			pbCrossClearModularity.Name = "pbCrossClearModularity";
			pbCrossClearModularity.Size = new Size(23, 23);
			pbCrossClearModularity.SizeMode = PictureBoxSizeMode.AutoSize;
			pbCrossClearModularity.TabIndex = 81;
			pbCrossClearModularity.TabStop = false;
			pbCrossClearModularity.Click += pbCrossClearModularity_Click;
			// 
			// pbCrossClearFormFactor
			// 
			pbCrossClearFormFactor.BackColor = Color.Transparent;
			pbCrossClearFormFactor.Cursor = Cursors.Hand;
			pbCrossClearFormFactor.Image = Properties.Resources.Cross_Red;
			pbCrossClearFormFactor.Location = new Point(31, 309);
			pbCrossClearFormFactor.Name = "pbCrossClearFormFactor";
			pbCrossClearFormFactor.Size = new Size(23, 23);
			pbCrossClearFormFactor.SizeMode = PictureBoxSizeMode.AutoSize;
			pbCrossClearFormFactor.TabIndex = 82;
			pbCrossClearFormFactor.TabStop = false;
			pbCrossClearFormFactor.Click += pbCrossClearFormFactor_Click;
			// 
			// lblPSU
			// 
			lblPSU.AutoSize = true;
			lblPSU.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblPSU.ForeColor = Color.FromArgb(236, 179, 101);
			lblPSU.Location = new Point(12, 9);
			lblPSU.Name = "lblPSU";
			lblPSU.Size = new Size(41, 21);
			lblPSU.TabIndex = 94;
			lblPSU.Text = "PSU";
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
			// FormModifyPSU
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(4, 28, 50);
			ClientSize = new Size(767, 492);
			Controls.Add(lblPSU);
			Controls.Add(pbCrossClearFormFactor);
			Controls.Add(pbCrossClearModularity);
			Controls.Add(pbCrossClearEfficiencyRating);
			Controls.Add(cbFormFactor);
			Controls.Add(lblFormFactor);
			Controls.Add(cbModularity);
			Controls.Add(lblModularity);
			Controls.Add(tbxWattage);
			Controls.Add(lblWattage);
			Controls.Add(cbEfficiencyRating);
			Controls.Add(lblEfficiencyRating);
			Controls.Add(lblInstruction);
			Controls.Add(lblError);
			Controls.Add(btnCancel);
			Controls.Add(btnConfirm);
			Controls.Add(panel);
			FormBorderStyle = FormBorderStyle.None;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			Name = "FormModifyPSU";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Modify PSU";
			((System.ComponentModel.ISupportInitialize)pbCrossClearEfficiencyRating).EndInit();
			((System.ComponentModel.ISupportInitialize)pbCrossClearModularity).EndInit();
			((System.ComponentModel.ISupportInitialize)pbCrossClearFormFactor).EndInit();
			panel.ResumeLayout(false);
			panel.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblInstruction;
		private Label lblError;
		private Button btnCancel;
		private Button btnConfirm;
		private ComboBox cbFormFactor;
		private Label lblFormFactor;
		private ComboBox cbModularity;
		private Label lblModularity;
		private TextBox tbxWattage;
		private Label lblWattage;
		private ComboBox cbEfficiencyRating;
		private Label lblEfficiencyRating;
		private PictureBox pbCrossClearEfficiencyRating;
		private PictureBox pbCrossClearModularity;
		private PictureBox pbCrossClearFormFactor;
		private Label lblPSU;
		private Panel panel;
		private Label lblCase;
	}
}