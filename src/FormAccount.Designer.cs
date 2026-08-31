namespace WarehouseManager {
	partial class FormAccount {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccount));
			btnDeleteAccount = new Button();
			btnLogout = new Button();
			btnChangePassword = new Button();
			btnChangeUsername = new Button();
			lblPassword = new Label();
			lblPasswordText = new Label();
			lblUsername = new Label();
			lblUsernameText = new Label();
			pbReturn = new PictureBox();
			lblAccount = new Label();
			pbCrossCloseForm = new PictureBox();
			panel = new Panel();
			pbMinimize = new PictureBox();
			((System.ComponentModel.ISupportInitialize)pbReturn).BeginInit();
			((System.ComponentModel.ISupportInitialize)pbCrossCloseForm).BeginInit();
			panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbMinimize).BeginInit();
			SuspendLayout();
			// 
			// btnDeleteAccount
			// 
			btnDeleteAccount.BackColor = Color.FromArgb(244, 43, 50);
			btnDeleteAccount.FlatAppearance.MouseDownBackColor = Color.FromArgb(244, 43, 50);
			btnDeleteAccount.FlatStyle = FlatStyle.Flat;
			btnDeleteAccount.ForeColor = Color.FromArgb(236, 179, 101);
			btnDeleteAccount.Location = new Point(100, 158);
			btnDeleteAccount.Margin = new Padding(3, 2, 3, 2);
			btnDeleteAccount.Name = "btnDeleteAccount";
			btnDeleteAccount.Size = new Size(150, 33);
			btnDeleteAccount.TabIndex = 15;
			btnDeleteAccount.Text = "Delete Account";
			btnDeleteAccount.UseVisualStyleBackColor = false;
			btnDeleteAccount.Click += btnDeleteAccount_Click;
			// 
			// btnLogout
			// 
			btnLogout.BackColor = Color.FromArgb(4, 41, 58);
			btnLogout.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 41, 58);
			btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(6, 70, 99);
			btnLogout.FlatStyle = FlatStyle.Flat;
			btnLogout.ForeColor = Color.FromArgb(236, 179, 101);
			btnLogout.Location = new Point(12, 158);
			btnLogout.Margin = new Padding(3, 2, 3, 2);
			btnLogout.Name = "btnLogout";
			btnLogout.Size = new Size(82, 33);
			btnLogout.TabIndex = 14;
			btnLogout.Text = "Logout";
			btnLogout.UseVisualStyleBackColor = false;
			btnLogout.Click += btnLogout_Click;
			// 
			// btnChangePassword
			// 
			btnChangePassword.BackColor = Color.FromArgb(4, 41, 58);
			btnChangePassword.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 41, 58);
			btnChangePassword.FlatAppearance.MouseOverBackColor = Color.FromArgb(6, 70, 99);
			btnChangePassword.FlatStyle = FlatStyle.Flat;
			btnChangePassword.ForeColor = Color.FromArgb(236, 179, 101);
			btnChangePassword.Location = new Point(224, 93);
			btnChangePassword.Margin = new Padding(3, 2, 3, 2);
			btnChangePassword.Name = "btnChangePassword";
			btnChangePassword.Size = new Size(123, 33);
			btnChangePassword.TabIndex = 13;
			btnChangePassword.Text = "Change Password";
			btnChangePassword.UseVisualStyleBackColor = false;
			btnChangePassword.Click += btnChangePassword_Click;
			// 
			// btnChangeUsername
			// 
			btnChangeUsername.BackColor = Color.FromArgb(4, 41, 58);
			btnChangeUsername.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 41, 58);
			btnChangeUsername.FlatAppearance.MouseOverBackColor = Color.FromArgb(6, 70, 99);
			btnChangeUsername.FlatStyle = FlatStyle.Flat;
			btnChangeUsername.ForeColor = Color.FromArgb(236, 179, 101);
			btnChangeUsername.Location = new Point(224, 57);
			btnChangeUsername.Margin = new Padding(3, 2, 3, 2);
			btnChangeUsername.Name = "btnChangeUsername";
			btnChangeUsername.Size = new Size(123, 33);
			btnChangeUsername.TabIndex = 12;
			btnChangeUsername.Text = "Change Username";
			btnChangeUsername.UseVisualStyleBackColor = false;
			btnChangeUsername.Click += btnChangeUsername_Click;
			// 
			// lblPassword
			// 
			lblPassword.AutoSize = true;
			lblPassword.ForeColor = Color.FromArgb(236, 179, 101);
			lblPassword.Location = new Point(85, 102);
			lblPassword.Name = "lblPassword";
			lblPassword.Size = new Size(0, 15);
			lblPassword.TabIndex = 11;
			// 
			// lblPasswordText
			// 
			lblPasswordText.AutoSize = true;
			lblPasswordText.BackColor = Color.FromArgb(4, 28, 50);
			lblPasswordText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblPasswordText.ForeColor = Color.FromArgb(236, 179, 101);
			lblPasswordText.Location = new Point(12, 102);
			lblPasswordText.Name = "lblPasswordText";
			lblPasswordText.Size = new Size(62, 15);
			lblPasswordText.TabIndex = 10;
			lblPasswordText.Text = "Password:";
			// 
			// lblUsername
			// 
			lblUsername.AutoSize = true;
			lblUsername.ForeColor = Color.FromArgb(236, 179, 101);
			lblUsername.Location = new Point(85, 66);
			lblUsername.Name = "lblUsername";
			lblUsername.Size = new Size(0, 15);
			lblUsername.TabIndex = 9;
			// 
			// lblUsernameText
			// 
			lblUsernameText.AutoSize = true;
			lblUsernameText.BackColor = Color.FromArgb(4, 28, 50);
			lblUsernameText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblUsernameText.ForeColor = Color.FromArgb(236, 179, 101);
			lblUsernameText.Location = new Point(12, 66);
			lblUsernameText.Name = "lblUsernameText";
			lblUsernameText.Size = new Size(67, 15);
			lblUsernameText.TabIndex = 8;
			lblUsernameText.Text = "Username:";
			// 
			// pbReturn
			// 
			pbReturn.BackColor = Color.FromArgb(4, 28, 50);
			pbReturn.Cursor = Cursors.Hand;
			pbReturn.Image = Properties.Resources.Return_Color;
			pbReturn.Location = new Point(10, 10);
			pbReturn.Margin = new Padding(1);
			pbReturn.Name = "pbReturn";
			pbReturn.Size = new Size(24, 24);
			pbReturn.SizeMode = PictureBoxSizeMode.AutoSize;
			pbReturn.TabIndex = 86;
			pbReturn.TabStop = false;
			pbReturn.Click += pbReturn_Click;
			// 
			// lblAccount
			// 
			lblAccount.AutoSize = true;
			lblAccount.BackColor = Color.FromArgb(4, 28, 50);
			lblAccount.FlatStyle = FlatStyle.Flat;
			lblAccount.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblAccount.ForeColor = Color.FromArgb(236, 179, 101);
			lblAccount.Location = new Point(38, 9);
			lblAccount.Name = "lblAccount";
			lblAccount.Size = new Size(86, 25);
			lblAccount.TabIndex = 85;
			lblAccount.Text = "Account";
			lblAccount.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// pbCrossCloseForm
			// 
			pbCrossCloseForm.BackColor = Color.FromArgb(4, 28, 50);
			pbCrossCloseForm.Cursor = Cursors.Hand;
			pbCrossCloseForm.Image = Properties.Resources.Cross_Color;
			pbCrossCloseForm.Location = new Point(325, 10);
			pbCrossCloseForm.Margin = new Padding(1);
			pbCrossCloseForm.Name = "pbCrossCloseForm";
			pbCrossCloseForm.Size = new Size(24, 24);
			pbCrossCloseForm.SizeMode = PictureBoxSizeMode.AutoSize;
			pbCrossCloseForm.TabIndex = 87;
			pbCrossCloseForm.TabStop = false;
			pbCrossCloseForm.Click += pbCrossCloseForm_Click;
			// 
			// panel
			// 
			panel.BackColor = Color.Transparent;
			panel.BorderStyle = BorderStyle.FixedSingle;
			panel.Controls.Add(pbMinimize);
			panel.Dock = DockStyle.Fill;
			panel.Location = new Point(0, 0);
			panel.Name = "panel";
			panel.Padding = new Padding(1);
			panel.Size = new Size(359, 227);
			panel.TabIndex = 88;
			panel.Paint += panel_Paint;
			// 
			// pbMinimize
			// 
			pbMinimize.Cursor = Cursors.Hand;
			pbMinimize.Image = Properties.Resources.Minimize_Color;
			pbMinimize.Location = new Point(289, 9);
			pbMinimize.Margin = new Padding(1, 1, 10, 1);
			pbMinimize.Name = "pbMinimize";
			pbMinimize.Size = new Size(24, 24);
			pbMinimize.SizeMode = PictureBoxSizeMode.AutoSize;
			pbMinimize.TabIndex = 92;
			pbMinimize.TabStop = false;
			pbMinimize.Click += pbMinimize_Click;
			// 
			// FormAccount
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(4, 28, 50);
			ClientSize = new Size(359, 227);
			Controls.Add(pbCrossCloseForm);
			Controls.Add(pbReturn);
			Controls.Add(lblAccount);
			Controls.Add(btnDeleteAccount);
			Controls.Add(btnLogout);
			Controls.Add(btnChangePassword);
			Controls.Add(btnChangeUsername);
			Controls.Add(lblPassword);
			Controls.Add(lblPasswordText);
			Controls.Add(lblUsername);
			Controls.Add(lblUsernameText);
			Controls.Add(panel);
			FormBorderStyle = FormBorderStyle.None;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "FormAccount";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "FormAccount";
			((System.ComponentModel.ISupportInitialize)pbReturn).EndInit();
			((System.ComponentModel.ISupportInitialize)pbCrossCloseForm).EndInit();
			panel.ResumeLayout(false);
			panel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pbMinimize).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnDeleteAccount;
		private Button btnLogout;
		private Button btnChangePassword;
		private Button btnChangeUsername;
		private Label lblPassword;
		private Label lblPasswordText;
		private Label lblUsername;
		private Label lblUsernameText;
		private PictureBox pbReturn;
		private Label lblAccount;
		private PictureBox pbCrossCloseForm;
		private Panel panel;
		private PictureBox pbMinimize;
	}
}