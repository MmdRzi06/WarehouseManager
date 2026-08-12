
namespace WarehouseManager {
	public partial class FormAddThermalPad: Form {
		public FormAddThermalPad() {
			InitializeComponent();

		}

		private void btnConfirm_Click(object sender, EventArgs e) {
			if (string.IsNullOrWhiteSpace(tbxName.Text) ||
				string.IsNullOrWhiteSpace(tbxManufacturer.Text) ||
				string.IsNullOrWhiteSpace(tbxPrice.Text) ||
				string.IsNullOrWhiteSpace(tbxStockQuantity.Text) ||
				string.IsNullOrWhiteSpace(tbxWeight.Text) ||
				string.IsNullOrWhiteSpace(tbxThickness.Text) ||
				string.IsNullOrWhiteSpace(tbxLength.Text) ||
				string.IsNullOrWhiteSpace(tbxWidth.Text)) {
				lblError.Text = FormSharedErrors.AddFormEmptyFields;
				return;
			}

			string name = tbxName.Text;
			string manufacturer = tbxManufacturer.Text;
			decimal.TryParse(tbxPrice.Text, out decimal rPrice);
			decimal price = rPrice;
			int stockQuantity = int.Parse(tbxStockQuantity.Text);
			double.TryParse(tbxWeight.Text, out double rWeight);
			double weight = rWeight;

			int thicknessMm = int.Parse(tbxThickness.Text);
			int lengthMm = int.Parse(tbxLength.Text);
			int widthMm = int.Parse(tbxWidth.Text);

			try {
				Products.AddThermalPad(name, manufacturer, price, stockQuantity, weight, thicknessMm, lengthMm, widthMm);
				Close();
			} catch (ProductValidationException ex) {
				lblError.Text = ex.Message;
			}

		}

		private void btnCancel_Click(object sender, EventArgs e) {
			Close();
		}

		private void StringTextBoxes_KeyPress(object sender, KeyPressEventArgs e) {
			FormSharedEventHandlers.StringTextBoxes_KeyPress(sender, e);
		}

		private void IntTextBoxes_KeyPress(object sender, KeyPressEventArgs e) {
			FormSharedEventHandlers.IntTextBoxes_KeyPress(sender, e);
		}

		private void DoubleTextBoxes_KeyPress(object sender, KeyPressEventArgs e) {
			FormSharedEventHandlers.DoubleTextBoxes_KeyPress(sender, e);
		}
	}
}
