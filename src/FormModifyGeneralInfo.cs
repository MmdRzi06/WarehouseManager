
namespace WarehouseManager {
	public partial class FormModifyGeneralInfo: Form {

		private readonly long ProductID;
		private new readonly string ProductName;

		public FormModifyGeneralInfo(long productID, string productName) {
			InitializeComponent();
			ProductID = productID;
			ProductName = productName;
		}

		private void btnConfirm_Click(object sender, EventArgs e) {
			string? name = null;
			string? manufacturer = null;
			decimal? price = null;
			int? stockQuantity = null;
			double? weight = null;

			bool AllFieldsNull = true;

			if (!string.IsNullOrWhiteSpace(tbxName.Text)) {
				name = tbxName.Text;
				if (name == ProductName) {
					lblError.Text = "New name must be different form the product's current name.";
					return;
				}
				AllFieldsNull = false;
			}
			if (!string.IsNullOrWhiteSpace(tbxManufacturer.Text)) {
				manufacturer = tbxManufacturer.Text;
				AllFieldsNull = false;
			}
			if (!string.IsNullOrWhiteSpace(tbxPrice.Text)) {
				decimal.TryParse(tbxPrice.Text, out decimal rPrice);
				price = rPrice;
				AllFieldsNull = false;
			}
			if (!string.IsNullOrWhiteSpace(tbxStockQuantity.Text)) {
				stockQuantity = int.Parse(tbxStockQuantity.Text);
				AllFieldsNull = false;
			}
			if (!string.IsNullOrWhiteSpace(tbxWeight.Text)) {
				double.TryParse(tbxWeight.Text, out double rWeight);
				weight = rWeight;
				AllFieldsNull = false;
			}

			if (AllFieldsNull) {
				lblError.Text = FormSharedErrors.ModifyFormAllFieldsEmpty;
				return;
			}

			try {
				Products.ModifyProduct(ProductID, name, manufacturer, price, stockQuantity, weight);
				Close();
			} catch (ProductValidationException ex) {
				lblError.Text = ex.Message;
				return;
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
