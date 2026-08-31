
namespace WarehouseManager {
	public partial class FormModifyMotherboard: Form {

		private readonly long ProductID;

		public FormModifyMotherboard(long productID) {
			InitializeComponent();
			ProductID = productID;
		}

		private void btnConfirm_Click(object sender, EventArgs e) {
			string? socket = null;
			string? chipset = null;
			MotherboardFormFactor? formFactor = null;
			MemoryType? memoryType = null;
			int? memorySlotCount = null;
			int? maxSupportedMemoryGB = null;
			int? pcieSlotCount = null;
			int? m2SlotCount = null;
			int? sataPortCount = null;
			bool? hasWifi = null;
			bool? allowsCpuOverclocking = null;

			bool AllFieldsNull = true;

			if (!string.IsNullOrWhiteSpace(tbxSocketType.Text)) {
				socket = tbxSocketType.Text;
				AllFieldsNull = false;
			}
			if (!string.IsNullOrWhiteSpace(tbxChipset.Text)) {
				chipset = tbxChipset.Text;
				AllFieldsNull = false;
			}
			if (cbFormFactor.SelectedItem is not null) {
				string selectedFormFactor = (string)cbFormFactor.SelectedItem;
				if (selectedFormFactor == "ATX") {
					formFactor = MotherboardFormFactor.ATX;
				} else if (selectedFormFactor == "Mini-ITX") {
					formFactor = MotherboardFormFactor.MiniITX;
				} else {
					formFactor = (MotherboardFormFactor)EnumUtils.DisplayStringToEnum(selectedFormFactor);
				}
				AllFieldsNull = false;
			}
			if (cbMemoryType.SelectedItem is not null) {
				memoryType = (MemoryType)EnumUtils.DisplayStringToEnum((string)cbMemoryType.SelectedItem);
				AllFieldsNull = false;
			}
			if (!string.IsNullOrWhiteSpace(tbxNumberOfMemorySlots.Text)) {
				memorySlotCount = int.Parse(tbxNumberOfMemorySlots.Text);
				AllFieldsNull = false;
			}
			if (!string.IsNullOrWhiteSpace(tbxMaximumSupportedMemoryCapacity.Text)) {
				maxSupportedMemoryGB = int.Parse(tbxMaximumSupportedMemoryCapacity.Text);
				AllFieldsNull = false;
			}
			if (!string.IsNullOrWhiteSpace(tbxNumberOfPCIeSlots.Text)) {
				pcieSlotCount = int.Parse(tbxNumberOfPCIeSlots.Text);
				AllFieldsNull = false;
			}
			if (!string.IsNullOrWhiteSpace(tbxNumberOfM2Slots.Text)) {
				m2SlotCount = int.Parse(tbxNumberOfM2Slots.Text);
				AllFieldsNull = false;
			}
			if (!string.IsNullOrWhiteSpace(tbxNumberOfSataPorts.Text)) {
				sataPortCount = int.Parse(tbxNumberOfSataPorts.Text);
				AllFieldsNull = false;
			}
			if (cbWiFi.SelectedItem is not null) {
				hasWifi = (string)cbWiFi.SelectedItem == "Yes";
				AllFieldsNull = false;
			}
			if (cbCPUOverclocking.SelectedItem is not null) {
				hasWifi = (string)cbCPUOverclocking.SelectedItem == "Yes";
				AllFieldsNull = false;
			}

			if (AllFieldsNull) {
				lblError.Text = FormSharedErrors.ModifyFormAllFieldsEmpty;
				return;
			}

			try {
				Products.ModifyMotherboard(ProductID, socket, chipset, formFactor, memoryType, memorySlotCount, maxSupportedMemoryGB,
					pcieSlotCount, m2SlotCount, sataPortCount, hasWifi, allowsCpuOverclocking);
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

		private void pbCrossClearFormFactor_Click(object sender, EventArgs e) {
			cbFormFactor.SelectedItem = null;
		}

		private void pbCrossClearMemoryType_Click(object sender, EventArgs e) {
			cbMemoryType.SelectedItem = null;
		}

		private void pbCrossClearWiFi_Click(object sender, EventArgs e) {
			cbWiFi.SelectedItem = null;
		}

		private void pbCrossClearAllowsCPUOverclocking_Click(object sender, EventArgs e) {
			cbCPUOverclocking.SelectedItem = null;
		}
	}
}
