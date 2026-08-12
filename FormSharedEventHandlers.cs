namespace WarehouseManager {
	public class FormSharedEventHandlers {
		public static void IntTextBoxes_KeyPress(object sender, KeyPressEventArgs e) {
			char c = e.KeyChar;
			if (!char.IsDigit(c) && !char.IsControl(c)) e.Handled = true;
		}

		public static void StringTextBoxes_KeyPress(object sender, KeyPressEventArgs e) {
			char c = e.KeyChar;
			if (!char.IsLetterOrDigit(c) && c != '_' && c != '-' && !char.IsControl(c) && c != ' ') e.Handled = true;
		}

		public static void DoubleTextBoxes_KeyPress(object sender, KeyPressEventArgs e) {
			char c = e.KeyChar;
			if (!char.IsDigit(c) && !char.IsControl(c) && c != '.') { 
				e.Handled = true;
				return;
			}
			string tbx = ((TextBox)sender).Text;
			if (c == '.' && (tbx.Contains('.') || tbx == string.Empty)) e.Handled = true;
		}
	}
}
