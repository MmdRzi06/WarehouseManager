
namespace WarehouseManager {
	public partial class FormModifySataSSD: Form {

		private readonly long ProductID;

		public FormModifySataSSD(long productID) {
			InitializeComponent();
			ProductID = productID;
		}

		private void btnConfirm_Click(object sender, EventArgs e) {
			int? capacityGB = null;
			int? readSpeedMBs = null;
			int? writeSpeedMBs = null;

			bool AllFieldsNull = true;

			if (!string.IsNullOrWhiteSpace(tbxCapacity.Text)) {
				capacityGB = int.Parse(tbxCapacity.Text);
				AllFieldsNull = false;
			}
			if (!string.IsNullOrWhiteSpace(tbxReadSpeed.Text)) {
				readSpeedMBs = int.Parse(tbxReadSpeed.Text);
				AllFieldsNull = false;
			}
			if (!string.IsNullOrWhiteSpace(tbxWriteSpeed.Text)) {
				writeSpeedMBs = int.Parse(tbxWriteSpeed.Text);
				AllFieldsNull = false;
			}

			if (AllFieldsNull) {
				lblError.Text = FormSharedErrors.ModifyFormAllFieldsEmpty;
				return;
			}

			try {
				Products.ModifySataSSD(ProductID, capacityGB, readSpeedMBs, writeSpeedMBs);
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
