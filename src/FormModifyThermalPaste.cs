
namespace WarehouseManager {
	public partial class FormModifyThermalPaste: Form {

		private readonly long ProductID;

		public FormModifyThermalPaste(long productID) {
			InitializeComponent();
			ProductID = productID;
		}

		private void btnConfirm_Click(object sender, EventArgs e) {
			int? volumeGrams = null;

			bool AllFieldsNull = true;

			if (!string.IsNullOrWhiteSpace(tbxVolume.Text)) {
				volumeGrams = int.Parse(tbxVolume.Text);
				AllFieldsNull = false;
			}

			if (AllFieldsNull) {
				lblError.Text = FormSharedErrors.ModifyFormAllFieldsEmpty;
				return;
			}

			try {
				Products.ModifyThermalPaste(ProductID, volumeGrams);
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
