namespace WarehouseManager {
    partial class FormChangePassword
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChangePassword));
			btnShowHidePassword = new Button();
			lblError = new Label();
			btnConfirm = new Button();
			btnCancel = new Button();
			lblPassword = new Label();
			tbxPassword = new TextBox();
			panel = new Panel();
			lblChangePassword = new Label();
			panel.SuspendLayout();
			SuspendLayout();
			// 
			// btnShowHidePassword
			// 
			btnShowHidePassword.BackColor = Color.Transparent;
			btnShowHidePassword.BackgroundImageLayout = ImageLayout.None;
			btnShowHidePassword.Cursor = Cursors.Hand;
			btnShowHidePassword.FlatAppearance.BorderSize = 0;
			btnShowHidePassword.FlatAppearance.MouseDownBackColor = Color.Transparent;
			btnShowHidePassword.FlatAppearance.MouseOverBackColor = Color.Transparent;
			btnShowHidePassword.FlatStyle = FlatStyle.Flat;
			btnShowHidePassword.Image = Properties.Resources.ClosedEye_Color;
			btnShowHidePassword.Location = new Point(280, 70);
			btnShowHidePassword.Name = "btnShowHidePassword";
			btnShowHidePassword.Size = new Size(24, 24);
			btnShowHidePassword.TabIndex = 7;
			btnShowHidePassword.UseVisualStyleBackColor = false;
			btnShowHidePassword.Click += btnShowHidePassword_Click;
			btnShowHidePassword.Enter += btnShowHidePassword_Enter;
			// 
			// lblError
			// 
			lblError.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblError.ForeColor = Color.FromArgb(244, 43, 50);
			lblError.Location = new Point(13, 151);
			lblError.Margin = new Padding(4, 0, 4, 0);
			lblError.Name = "lblError";
			lblError.Size = new Size(262, 44);
			lblError.TabIndex = 6;
			lblError.Text = "\r\n";
			// 
			// btnConfirm
			// 
			btnConfirm.BackColor = Color.FromArgb(4, 41, 58);
			btnConfirm.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 41, 58);
			btnConfirm.FlatAppearance.MouseOverBackColor = Color.FromArgb(6, 70, 99);
			btnConfirm.FlatStyle = FlatStyle.Flat;
			btnConfirm.ForeColor = Color.FromArgb(236, 179, 101);
			btnConfirm.Location = new Point(154, 107);
			btnConfirm.Margin = new Padding(4, 2, 4, 2);
			btnConfirm.Name = "btnConfirm";
			btnConfirm.Size = new Size(121, 27);
			btnConfirm.TabIndex = 5;
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
			btnCancel.Location = new Point(13, 107);
			btnCancel.Margin = new Padding(4, 2, 4, 2);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(123, 27);
			btnCancel.TabIndex = 4;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = false;
			btnCancel.Click += btnCancel_Click;
			// 
			// lblPassword
			// 
			lblPassword.AutoSize = true;
			lblPassword.ForeColor = Color.FromArgb(236, 179, 101);
			lblPassword.Location = new Point(13, 51);
			lblPassword.Margin = new Padding(4, 0, 4, 0);
			lblPassword.Name = "lblPassword";
			lblPassword.Size = new Size(84, 15);
			lblPassword.TabIndex = 2;
			lblPassword.Text = "New Password";
			// 
			// tbxPassword
			// 
			tbxPassword.BackColor = Color.FromArgb(4, 41, 58);
			tbxPassword.BorderStyle = BorderStyle.FixedSingle;
			tbxPassword.ForeColor = Color.FromArgb(236, 179, 101);
			tbxPassword.Location = new Point(13, 71);
			tbxPassword.Margin = new Padding(4, 2, 4, 2);
			tbxPassword.MaxLength = 32;
			tbxPassword.Name = "tbxPassword";
			tbxPassword.Size = new Size(262, 23);
			tbxPassword.TabIndex = 0;
			tbxPassword.UseSystemPasswordChar = true;
			// 
			// panel
			// 
			panel.BackColor = Color.Transparent;
			panel.BorderStyle = BorderStyle.FixedSingle;
			panel.Controls.Add(lblChangePassword);
			panel.Dock = DockStyle.Fill;
			panel.Location = new Point(0, 0);
			panel.Name = "panel";
			panel.Padding = new Padding(1);
			panel.Size = new Size(311, 208);
			panel.TabIndex = 90;
			// 
			// lblChangePassword
			// 
			lblChangePassword.AutoSize = true;
			lblChangePassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblChangePassword.ForeColor = Color.FromArgb(236, 179, 101);
			lblChangePassword.Location = new Point(11, 8);
			lblChangePassword.Name = "lblChangePassword";
			lblChangePassword.Size = new Size(144, 21);
			lblChangePassword.TabIndex = 96;
			lblChangePassword.Text = "Change Password";
			// 
			// FormChangePassword
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(4, 28, 50);
			ClientSize = new Size(311, 208);
			Controls.Add(btnShowHidePassword);
			Controls.Add(lblError);
			Controls.Add(btnConfirm);
			Controls.Add(tbxPassword);
			Controls.Add(btnCancel);
			Controls.Add(lblPassword);
			Controls.Add(panel);
			FormBorderStyle = FormBorderStyle.None;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(3, 2, 3, 2);
			MaximizeBox = false;
			Name = "FormChangePassword";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Change Password";
			panel.ResumeLayout(false);
			panel.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label lblError;
		private Button btnConfirm;
		private Button btnCancel;
		private Label lblPassword;
		private TextBox tbxPassword;
		private Button btnShowHidePassword;
		private Panel panel;
		private Label lblChangePassword;
	}
}