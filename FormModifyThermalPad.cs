
namespace WarehouseManager {
	public partial class FormModifyThermalPad: Form {

		private readonly long ProductID;

		public FormModifyThermalPad(long productID) {
			InitializeComponent();
			ProductID = productID;
		}

		private void btnConfirm_Click(object sender, EventArgs e) {
			int? thicknessMm = null;
			int? lengthMm = null;
			int? widthMm = null;

			bool AllFieldsNull = true;

			if (!string.IsNullOrWhiteSpace(tbxThickness.Text)) {
				thicknessMm = int.Parse(tbxThickness.Text);
				AllFieldsNull = false;
			}
			if (!string.IsNullOrWhiteSpace(tbxLength.Text)) {
				lengthMm = int.Parse(tbxLength.Text);
				AllFieldsNull = false;
			}
			if (!string.IsNullOrWhiteSpace(tbxWidth.Text)) {
				widthMm = int.Parse(tbxWidth.Text);
				AllFieldsNull = false;
			}

			if (AllFieldsNull) {
				lblError.Text = FormSharedErrors.ModifyFormAllFieldsEmpty;
				return;
			}

			try {
				Products.ModifyThermalPad(ProductID, thicknessMm, lengthMm, widthMm);
				Close();
			} catch (ProductValidationException ex) {
				lblError.Text = ex.Message;
				return;
			}
		}

		private void btnCancel_Click(object sender, EventArgs e) {
			Close();
		}

		private void IntTextBoxes_KeyPress(object sender, KeyPressEventArgs e) {
			FormSharedEventHandlers.IntTextBoxes_KeyPress(sender, e);
		}
	}
}
