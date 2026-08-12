
namespace WarehouseManager {
	public partial class FormModifyCase: Form {

		private readonly long ProductID;

		public FormModifyCase(long productID) {
			InitializeComponent();
			ProductID = productID;
		}

		private void btnConfirm_Click(object sender, EventArgs e) {
			CaseFormFactor? formFactor = null;
			MotherboardFormFactor? largestSupportedMotherboardFormFactor = null;
			int? maxGpuLengthMm = null;
			int? maxCpuCoolerHeightMm = null;

			bool AllFieldsNull = true;

			if (cbFormFactor.SelectedItem is not null) {
				formFactor = (CaseFormFactor)EnumUtils.DisplayStringToEnum((string)cbFormFactor.SelectedItem);
				AllFieldsNull = false;
			}
			if (cbLSMFF.SelectedItem is not null) {
				string largestSupportedMotherboardFormFactorStr = (string)cbLSMFF.SelectedItem;
				if (largestSupportedMotherboardFormFactorStr == "ATX") largestSupportedMotherboardFormFactor = MotherboardFormFactor.ATX;
				else if (largestSupportedMotherboardFormFactorStr == "Mini-ITX") largestSupportedMotherboardFormFactor = MotherboardFormFactor.MiniITX;
				else largestSupportedMotherboardFormFactor = (MotherboardFormFactor)EnumUtils.DisplayStringToEnum(largestSupportedMotherboardFormFactorStr);
				AllFieldsNull = false;
			}
			if (!string.IsNullOrWhiteSpace(tbxMaximumGPULength.Text)) {
				maxGpuLengthMm = int.Parse(tbxMaximumGPULength.Text);
				AllFieldsNull = false;
			}
			if (!string.IsNullOrWhiteSpace(tbxMaximumCPUCoolerHeight.Text)) {
				maxCpuCoolerHeightMm = int.Parse(tbxMaximumCPUCoolerHeight.Text);
				AllFieldsNull = false;
			}

			if (AllFieldsNull) {
				lblError.Text = FormSharedErrors.ModifyFormAllFieldsEmpty;
				return;
			}

			try {
				Products.ModifyCase(ProductID, formFactor, largestSupportedMotherboardFormFactor, maxGpuLengthMm, maxCpuCoolerHeightMm);
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

		private void pbCrossClearFormFactor_Click(object sender, EventArgs e) {
			cbFormFactor.SelectedItem = null;
		}

		private void pbCrossClearLSMFF_Click(object sender, EventArgs e) {
			cbLSMFF.SelectedItem = null;
		}
	}
}
