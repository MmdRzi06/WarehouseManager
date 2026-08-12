namespace WarehouseManager
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
			tbxUsername = new TextBox();
			tbxPassword = new TextBox();
			lblUsername = new Label();
			lblPassword = new Label();
			pbShowHidePassword = new PictureBox();
			lblError = new Label();
			btnLogin = new Button();
			btnCreateAccount = new Button();
			pbCrossCloseForm = new PictureBox();
			panel = new Panel();
			pbMinimize = new PictureBox();
			((System.ComponentModel.ISupportInitialize)pbShowHidePassword).BeginInit();
			((System.ComponentModel.ISupportInitialize)pbCrossCloseForm).BeginInit();
			panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbMinimize).BeginInit();
			SuspendLayout();
			// 
			// tbxUsername
			// 
			tbxUsername.BackColor = Color.FromArgb(4, 41, 58);
			tbxUsername.BorderStyle = BorderStyle.FixedSingle;
			tbxUsername.ForeColor = Color.FromArgb(236, 179, 101);
			tbxUsername.Location = new Point(11, 67);
			tbxUsername.Margin = new Padding(3, 2, 3, 2);
			tbxUsername.MaxLength = 32;
			tbxUsername.Name = "tbxUsername";
			tbxUsername.Size = new Size(240, 23);
			tbxUsername.TabIndex = 0;
			tbxUsername.KeyPress += tbxUsername_KeyPress;
			// 
			// tbxPassword
			// 
			tbxPassword.BackColor = Color.FromArgb(4, 41, 58);
			tbxPassword.BorderStyle = BorderStyle.FixedSingle;
			tbxPassword.ForeColor = Color.FromArgb(236, 179, 101);
			tbxPassword.Location = new Point(11, 124);
			tbxPassword.Margin = new Padding(3, 2, 3, 2);
			tbxPassword.MaxLength = 32;
			tbxPassword.Name = "tbxPassword";
			tbxPassword.Size = new Size(240, 23);
			tbxPassword.TabIndex = 1;
			tbxPassword.UseSystemPasswordChar = true;
			// 
			// lblUsername
			// 
			lblUsername.AutoSize = true;
			lblUsername.ForeColor = Color.FromArgb(236, 179, 101);
			lblUsername.Location = new Point(11, 45);
			lblUsername.Name = "lblUsername";
			lblUsername.Size = new Size(60, 15);
			lblUsername.TabIndex = 2;
			lblUsername.Text = "Username";
			// 
			// lblPassword
			// 
			lblPassword.AutoSize = true;
			lblPassword.ForeColor = Color.FromArgb(236, 179, 101);
			lblPassword.Location = new Point(11, 102);
			lblPassword.Name = "lblPassword";
			lblPassword.Size = new Size(57, 15);
			lblPassword.TabIndex = 3;
			lblPassword.Text = "Password";
			// 
			// pbShowHidePassword
			// 
			pbShowHidePassword.Cursor = Cursors.Hand;
			pbShowHidePassword.Image = Properties.Resources.ClosedEye_Color;
			pbShowHidePassword.Location = new Point(257, 128);
			pbShowHidePassword.Name = "pbShowHidePassword";
			pbShowHidePassword.Size = new Size(24, 16);
			pbShowHidePassword.SizeMode = PictureBoxSizeMode.AutoSize;
			pbShowHidePassword.TabIndex = 83;
			pbShowHidePassword.TabStop = false;
			pbShowHidePassword.Click += pbShowHidePassword_Click;
			// 
			// lblError
			// 
			lblError.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblError.ForeColor = Color.FromArgb(244, 43, 50);
			lblError.Location = new Point(11, 221);
			lblError.Name = "lblError";
			lblError.Size = new Size(240, 47);
			lblError.TabIndex = 6;
			// 
			// btnLogin
			// 
			btnLogin.BackColor = Color.FromArgb(4, 41, 58);
			btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 41, 58);
			btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(6, 70, 99);
			btnLogin.FlatStyle = FlatStyle.Flat;
			btnLogin.ForeColor = Color.FromArgb(236, 179, 101);
			btnLogin.Location = new Point(140, 171);
			btnLogin.Margin = new Padding(3, 2, 3, 2);
			btnLogin.Name = "btnLogin";
			btnLogin.Size = new Size(110, 29);
			btnLogin.TabIndex = 5;
			btnLogin.Text = "Login";
			btnLogin.UseVisualStyleBackColor = false;
			btnLogin.Click += btnLogin_Click;
			// 
			// btnCreateAccount
			// 
			btnCreateAccount.BackColor = Color.FromArgb(4, 41, 58);
			btnCreateAccount.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 41, 58);
			btnCreateAccount.FlatAppearance.MouseOverBackColor = Color.FromArgb(6, 70, 99);
			btnCreateAccount.FlatStyle = FlatStyle.Flat;
			btnCreateAccount.ForeColor = Color.FromArgb(236, 179, 101);
			btnCreateAccount.Location = new Point(11, 171);
			btnCreateAccount.Margin = new Padding(3, 2, 3, 2);
			btnCreateAccount.Name = "btnCreateAccount";
			btnCreateAccount.Size = new Size(113, 29);
			btnCreateAccount.TabIndex = 4;
			btnCreateAccount.Text = "Create Account";
			btnCreateAccount.UseVisualStyleBackColor = false;
			btnCreateAccount.Click += btnCreateAccount_Click;
			// 
			// pbCrossCloseForm
			// 
			pbCrossCloseForm.Cursor = Cursors.Hand;
			pbCrossCloseForm.Image = Properties.Resources.Cross_Color;
			pbCrossCloseForm.Location = new Point(255, 9);
			pbCrossCloseForm.Margin = new Padding(1);
			pbCrossCloseForm.Name = "pbCrossCloseForm";
			pbCrossCloseForm.Size = new Size(24, 24);
			pbCrossCloseForm.SizeMode = PictureBoxSizeMode.AutoSize;
			pbCrossCloseForm.TabIndex = 82;
			pbCrossCloseForm.TabStop = false;
			pbCrossCloseForm.Click += pbCrossCloseForm_Click;
			// 
			// panel
			// 
			panel.BackColor = Color.Transparent;
			panel.BorderStyle = BorderStyle.FixedSingle;
			panel.Controls.Add(pbMinimize);
			panel.Controls.Add(pbCrossCloseForm);
			panel.Controls.Add(pbShowHidePassword);
			panel.Controls.Add(lblUsername);
			panel.Controls.Add(lblError);
			panel.Controls.Add(lblPassword);
			panel.Controls.Add(tbxPassword);
			panel.Controls.Add(btnLogin);
			panel.Controls.Add(btnCreateAccount);
			panel.Controls.Add(tbxUsername);
			panel.Dock = DockStyle.Fill;
			panel.Location = new Point(0, 0);
			panel.Name = "panel";
			panel.Padding = new Padding(1);
			panel.Size = new Size(290, 287);
			panel.TabIndex = 89;
			// 
			// pbMinimize
			// 
			pbMinimize.Cursor = Cursors.Hand;
			pbMinimize.Image = Properties.Resources.Minimize_Color;
			pbMinimize.Location = new Point(220, 9);
			pbMinimize.Margin = new Padding(1, 1, 10, 1);
			pbMinimize.Name = "pbMinimize";
			pbMinimize.Size = new Size(24, 24);
			pbMinimize.SizeMode = PictureBoxSizeMode.AutoSize;
			pbMinimize.TabIndex = 93;
			pbMinimize.TabStop = false;
			pbMinimize.Click += pbMinimize_Click;
			// 
			// FormLogin
			// 
			AutoScaleDimensions = new SizeF(96F, 96F);
			AutoScaleMode = AutoScaleMode.Dpi;
			BackColor = Color.FromArgb(4, 28, 50);
			ClientSize = new Size(290, 287);
			ControlBox = false;
			Controls.Add(panel);
			FormBorderStyle = FormBorderStyle.None;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(3, 2, 3, 2);
			MaximizeBox = false;
			Name = "FormLogin";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Login";
			((System.ComponentModel.ISupportInitialize)pbShowHidePassword).EndInit();
			((System.ComponentModel.ISupportInitialize)pbCrossCloseForm).EndInit();
			panel.ResumeLayout(false);
			panel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pbMinimize).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private TextBox tbxUsername;
        private TextBox tbxPassword;
        private Label lblUsername;
        private Label lblPassword;
        private Button btnLogin;
        private Button btnCreateAccount;
        private Label lblError;
		private PictureBox pbCrossCloseForm;
		private PictureBox pbShowHidePassword;
		private Panel panel;
		private PictureBox pbMinimize;
	}
}
