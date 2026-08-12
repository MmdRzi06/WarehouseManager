
namespace WarehouseManager
{
	public partial class FormChangeUsername: Form {
		public FormChangeUsername() {
			InitializeComponent();
		}

		private void tbxUsername_KeyPress(object sender, KeyPressEventArgs e) {
			char c = e.KeyChar;
			if (!char.IsControl(c) && (c == ' ' || !char.IsLetterOrDigit(c))) {
				e.Handled = true;
			}
		}

		private void btnConfirm_Click(object sender, EventArgs e) {
			if (!string.IsNullOrWhiteSpace(tbxUsername.Text)) {
				try {
					Users.ChangeCurrentUsername(tbxUsername.Text);
					Close();
				} catch (UserValidationException ex) {
					lblError.Text = ex.Message;
				}
			} else {
				lblError.Text = "Username cannot be empty.";
			}
		}

		private void btnCancel_Click(object sender, EventArgs e) {
			Close();
		}
	}
}
