
namespace WarehouseManager {
	public partial class FormModifyCaseFan: Form {

		private readonly long ProductID;

		public FormModifyCaseFan(long productID) {
			InitializeComponent();
			ProductID = productID;
		}

		private void btnConfirm_Click(object sender, EventArgs e) {
			int? sizeMm = null;
			int? maxFanSpeedRpm = null;
			int? minFanSpeedRpm = null;
			bool? pwmSupport = null;

			bool AllFieldsNull = true;

			if (!string.IsNullOrWhiteSpace(tbxSize.Text)) {
				sizeMm = int.Parse(tbxSize.Text);
				AllFieldsNull = false;
			}
			if (!string.IsNullOrWhiteSpace(tbxMaximumFanSpeed.Text)) {
				maxFanSpeedRpm = int.Parse(tbxMaximumFanSpeed.Text);
				AllFieldsNull = false;
			}
			if (!string.IsNullOrWhiteSpace(tbxMinimumFanSpeed.Text)) {
				minFanSpeedRpm = int.Parse(tbxMinimumFanSpeed.Text);
				AllFieldsNull = false;
			}
			if (cbPWMSupport.SelectedItem is not null) {
				pwmSupport = (string)cbPWMSupport.SelectedItem == "Yes";
				AllFieldsNull = false;
			}

			if (AllFieldsNull) {
				lblError.Text = FormSharedErrors.ModifyFormAllFieldsEmpty;
				return;
			}

			try {
				Products.ModifyCaseFan(ProductID, sizeMm, maxFanSpeedRpm, minFanSpeedRpm, pwmSupport);
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

		private void pbCrossClearPWMSupport_Click(object sender, EventArgs e) {
			cbPWMSupport.SelectedItem = null;
		}
	}
}
