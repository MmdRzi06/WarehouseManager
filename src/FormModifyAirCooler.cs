
namespace WarehouseManager {
	public partial class FormModifyAirCooler: Form {

		private readonly long ProductID;

		public FormModifyAirCooler(long productID) {
			InitializeComponent();
			ProductID = productID;
		}

		private void btnConfirm_Click(object sender, EventArgs e) {
			int? minFanSpeedRpm = null;
			int? maxFanSpeedRpm = null;
			int? fanSizeMm = null;
			double? maxNoiseLevelDbA = null;
			int? coolerHeightMm = null;

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
			if (!string.IsNullOrWhiteSpace(tbxCoolerHeight.Text)) {
				coolerHeightMm = int.Parse(tbxCoolerHeight.Text);
				AllFieldsNull = false;
			}

			if (AllFieldsNull) {
				lblError.Text = FormSharedErrors.ModifyFormAllFieldsEmpty;
				return;
			}

			try {
				Products.ModifyAirCooler(ProductID, minFanSpeedRpm, maxFanSpeedRpm, fanSizeMm, maxNoiseLevelDbA, coolerHeightMm);
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
