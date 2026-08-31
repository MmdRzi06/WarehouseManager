
using WarehouseManager.Properties;

namespace WarehouseManager {
	public partial class FormChangePassword: Form {
		public FormChangePassword() {
			InitializeComponent();
		}

		private void btnConfirm_Click(object sender, EventArgs e) {
			if (!string.IsNullOrWhiteSpace(tbxPassword.Text)) {
				try {
					Users.ChangeCurrentPassword(tbxPassword.Text);
					Close();
				} catch (UserValidationException ex) {
					lblError.Text = ex.Message;
				}
			} else {
				lblError.Text = "Password cannot be empty or consist only of spaces.";
			}
		}

		private void btnCancel_Click(object sender, EventArgs e) {
			Close();
		}

		private void btnShowHidePassword_Click(object sender, EventArgs e) {
			if (tbxPassword.UseSystemPasswordChar) {
				tbxPassword.UseSystemPasswordChar = false;
				btnShowHidePassword.Image = Resources.OpenEye_Color;
			} else {
				tbxPassword.UseSystemPasswordChar = true;
				btnShowHidePassword.Image = Resources.ClosedEye_Color;
			}
		}

		private void btnShowHidePassword_Enter(object sender, EventArgs e) {
			ActiveControl = null;
		}
	}
}
