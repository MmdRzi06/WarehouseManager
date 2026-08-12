
namespace WarehouseManager {
	public partial class FormAccount: Form {
		public FormAccount() {
			InitializeComponent();
			Users.UserActed += UserChangeHandler;
			lblUsername.Text = Users.GetCurrentUsername();
			lblPassword.Text = new string('*', Users.GetCurrentPassword().Length);
			if (Users.CurrentIsAdmin) btnDeleteAccount.Hide();
		}

		private void pbCrossCloseForm_Click(object sender, EventArgs e) {
			DialogResult choice = MessageBox.Show("Are you sure you want to quit?",
				null,
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning);

			if (choice == DialogResult.Yes) Application.Exit();
		}

		private void pbReturn_Click(object sender, EventArgs e) {
			FormMain formMain = new FormMain();
			formMain.Show();
			Close();
		}

		private void UserChangeHandler(UserAction userAction, IReadOnlyUser? user) {
			switch (userAction) {
				case UserAction.LoggedOut: Close(); break;
				case UserAction.UsernameChanged when user is not null: lblUsername.Text = user.Username; break;
				case UserAction.PasswordChanged when user is not null: lblPassword.Text = new string('*', user.Password.Length); break;
			}
		}

		private void btnLogout_Click(object sender, EventArgs e) {
			Users.LogOut();
		}

		private void btnDeleteAccount_Click(object sender, EventArgs e) {
			DialogResult choice = MessageBox.Show("Are you sure you want to delete your account?", "Account Deletion",
				MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

			if (choice == DialogResult.Yes) {
				Users.DeleteCurrentCustomer();
			}
		}

		private void btnChangeUsername_Click(object sender, EventArgs e) {
			FormChangeUsername formChangeUsername = new FormChangeUsername();
			formChangeUsername.ShowDialog();
		}

		private void btnChangePassword_Click(object sender, EventArgs e) {
			FormChangePassword formChangePassword = new FormChangePassword();
			formChangePassword.ShowDialog();
		}

		private void panel_Paint(object sender, PaintEventArgs e) {

		}

		private void pbMinimize_Click(object sender, EventArgs e) {
			WindowState = FormWindowState.Minimized;
		}
	}
}
