using System.Drawing.Drawing2D;
using WarehouseManager.Properties;

namespace WarehouseManager {
	public partial class FormLogin: Form {
		public FormLogin() {
			InitializeComponent();
			Users.UserActed += UserChangeHandler;
		}

		private void UserChangeHandler(UserAction userAction, IReadOnlyUser? user) {
			switch (userAction) {
				case UserAction.LoggedIn:
					Hide();
					FormMain formMain = new FormMain();
					formMain.Show();
					break;
				case UserAction.LoggedOut:
					CenterToScreen();
					tbxUsername.Clear();
					tbxPassword.Clear();
					lblError.Text = string.Empty;
					tbxPassword.UseSystemPasswordChar = true;
					pbShowHidePassword.Image = Resources.ClosedEye_Color;
					Show();
					break;
			}
		}

		private bool UserAndPassAreNotEmpty() {
			if (!string.IsNullOrWhiteSpace(tbxUsername.Text) && !string.IsNullOrWhiteSpace(tbxPassword.Text)) return true;
			return false;
		}

		private void btnLogin_Click(object sender, EventArgs e) {
			if (UserAndPassAreNotEmpty()) {
				try {
					Users.LogIn(tbxUsername.Text, tbxPassword.Text);
				} catch (UserValidationException ex) {
					lblError.Text = ex.Message;
				}
			} else {
				lblError.Text = FormSharedErrors.LoginFormEmptyUserOrPass;
			}
		}

		private void btnCreateAccount_Click(object sender, EventArgs e) {
			if (UserAndPassAreNotEmpty()) {
				try {
					Users.CreateCustomer(tbxUsername.Text, tbxPassword.Text);
					Users.LogIn(tbxUsername.Text, tbxPassword.Text);
				} catch (UserValidationException ex) {
					lblError.Text = ex.Message;
				}
			} else {
				lblError.Text = FormSharedErrors.LoginFormEmptyUserOrPass;
			}
		}

		private void tbxUsername_KeyPress(object sender, KeyPressEventArgs e) {
			char c = e.KeyChar;
			if (!char.IsControl(c) && (c == ' ' || !char.IsLetterOrDigit(c))) {
				e.Handled = true;
			}
		}

		private void pbCrossCloseForm_Click(object sender, EventArgs e) {
			DialogResult choice = MessageBox.Show("Are you sure you want to quit?",
				null,
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning);

			if (choice == DialogResult.Yes) Application.Exit();
		}

		private void pbShowHidePassword_Click(object sender, EventArgs e) {
			if (tbxPassword.UseSystemPasswordChar) {
				tbxPassword.UseSystemPasswordChar = false;
				pbShowHidePassword.Image = Resources.OpenEye_Color;
			} else {
				tbxPassword.UseSystemPasswordChar = true;
				pbShowHidePassword.Image = Resources.ClosedEye_Color;
			}
		}

		private void pbMinimize_Click(object sender, EventArgs e) {
			WindowState = FormWindowState.Minimized;
		}
	}
}