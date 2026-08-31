
namespace WarehouseManager {
	public partial class FormModifyAIOCooler: Form {

		private readonly long ProductID;

		public FormModifyAIOCooler(long productID) {
			InitializeComponent();
			ProductID = productID;
		}

		private void btnConfirm_Click(object sender, EventArgs e) {
			int? minFanSpeedRpm = null;
			int? maxFanSpeedRpm = null;
			int? fanSizeMm = null;
			double? maxNoiseLevelDbA = null;
			int? radiatorSizeMm = null;

			bool AllFieldsNull = true;

			if (!string.IsNullOrWhiteSpace(tbxMinimumFanSpeed.Text)) {
				minFanSpeedRpm = int.Parse(tbxMinimumFanSpeed.Text);
				AllFieldsNull = false;
			}
			if (!string.IsNullOrWhiteSpace(tbxMaximumFanSpeed.Text)) {
				maxFanSpeedRpm = int.Parse(tbxMaximumFanSpeed.Text);
				AllFieldsNull = false;
			}
			if (!string.IsNullOrWhiteSpace(tbxFanSize.Text)) {
				fanSizeMm = int.Parse(tbxFanSize.Text);
				AllFieldsNull = false;
			}
			if (!string.IsNullOrWhiteSpace(tbxMaxNoiseLevel.Text)) {
				Double.TryParse(tbxMaxNoiseLevel.Text, out double rMaxNoiseLevel);
				maxNoiseLevelDbA = rMaxNoiseLevel;
				AllFieldsNull = false;
			}
			if (!string.IsNullOrWhiteSpace(tbxRadiatorSize.Text)) {
				radiatorSizeMm = int.Parse(tbxRadiatorSize.Text);
				AllFieldsNull = false;
			}

			if (AllFieldsNull) {
				lblError.Text = FormSharedErrors.ModifyFormAllFieldsEmpty;
				return;
			}

			try {
				Products.ModifyAIOCooler(ProductID, minFanSpeedRpm, maxFanSpeedRpm, fanSizeMm, maxNoiseLevelDbA, radiatorSizeMm);
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

		private void DoubleTextBoxes_KeyPress(object sender, KeyPressEventArgs e) {
			FormSharedEventHandlers.DoubleTextBoxes_KeyPress(sender, e);
		}
	}
}
