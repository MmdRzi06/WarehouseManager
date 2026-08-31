
namespace WarehouseManager {
	public partial class FormModifyNVMeSSD: Form {

		private readonly long ProductID;

		public FormModifyNVMeSSD(long productID) {
			InitializeComponent();
			ProductID = productID;
		}

		private void btnConfirm_Click(object sender, EventArgs e) {
			int? capacityGB = null;
			int? readSpeedMBs = null;
			int? writeSpeedMBs = null;
			PcieGeneration? pcieGeneration = null;

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
			if (cbPCIeGeneration.SelectedItem is not null) {
				pcieGeneration = (PcieGeneration)EnumUtils.DisplayStringToEnum((string)cbPCIeGeneration.SelectedItem);
				AllFieldsNull = false;
			}

			if (AllFieldsNull) {
				lblError.Text = FormSharedErrors.ModifyFormAllFieldsEmpty;
				return;
			}

			try {
				Products.ModifyNVMeSSD(ProductID, capacityGB, readSpeedMBs, writeSpeedMBs, pcieGeneration);
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

		private void pbCrossClearPCIeGeneration_Click(object sender, EventArgs e) {
			cbPCIeGeneration.SelectedItem = null;
		}
	}
}
