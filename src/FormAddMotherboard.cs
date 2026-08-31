namespace WarehouseManager {
	public partial class FormAddMotherboard: Form {
		public FormAddMotherboard() {
			InitializeComponent();
			chbBenchMarkInfo.Checked = false;
			panelBenchMarkInfo.Enabled = false;
		}

		private void btnConfirm_Click(object sender, EventArgs e) {
			if (string.IsNullOrWhiteSpace(tbxName.Text) ||
				string.IsNullOrWhiteSpace(tbxManufacturer.Text) ||
				string.IsNullOrWhiteSpace(tbxPrice.Text) ||
				string.IsNullOrWhiteSpace(tbxStockQuantity.Text) ||
				string.IsNullOrWhiteSpace(tbxWeight.Text) ||
				string.IsNullOrWhiteSpace(tbxSocketType.Text) ||
				string.IsNullOrWhiteSpace(tbxNumberOfPCIeSlots.Text) ||
				string.IsNullOrWhiteSpace(tbxNumberOfM2Slots.Text) ||
				string.IsNullOrWhiteSpace(tbxNumberOfMemorySlots.Text) ||
				string.IsNullOrWhiteSpace(tbxMaximumSupportedMemoryCapacity.Text) ||
				string.IsNullOrWhiteSpace(tbxNumberOfSataPorts.Text) ||
				cbFormFactor.SelectedItem is null ||
				cbMemoryType.SelectedItem is null ||
				cbWiFi.SelectedItem is null ||
				cbCPUOverclocking.SelectedItem is null) {
				lblError.Text = FormSharedErrors.AddFormEmptyFields;
				return;
			}

			BenchmarkInformation? benchmarkInfo = null;

			if (chbBenchMarkInfo.Checked) {
				if (string.IsNullOrWhiteSpace(tbxSource.Text) ||
					string.IsNullOrWhiteSpace(tbxAverageScore.Text) ||
					string.IsNullOrWhiteSpace(tbxMaximumScore.Text)) {
					lblError.Text = FormSharedErrors.AddFormEmptyFields;
					return;
				} else {
					string source = tbxSource.Text;
					int averageScore = int.Parse(tbxAverageScore.Text);
					int maxScore = int.Parse(tbxMaximumScore.Text);
					try {
						benchmarkInfo = new BenchmarkInformation(averageScore, maxScore, source);

					} catch (BenchmarkInformationValidationException ex) {
						lblError.Text = ex.Message;
						return;
					}
				}
			}

			string name = tbxName.Text;
			string manufacturer = tbxManufacturer.Text;
			decimal.TryParse(tbxPrice.Text, out decimal rPrice);
			decimal price = rPrice;
			int stockQuantity = int.Parse(tbxStockQuantity.Text);
			double.TryParse(tbxWeight.Text, out double rWeight);
			double weight = rWeight;

			string socket = tbxSocketType.Text;
			string chipset = tbxChipset.Text;
			MemoryType memoryType = (MemoryType)EnumUtils.DisplayStringToEnum((string)cbMemoryType.SelectedItem);
			int memorySlotCount = int.Parse(tbxNumberOfMemorySlots.Text);
			int maxSupportedMemoryGB = int.Parse(tbxMaximumSupportedMemoryCapacity.Text);
			int pcieSlotCount = int.Parse(tbxNumberOfPCIeSlots.Text);
			int m2SlotCount = int.Parse(tbxNumberOfM2Slots.Text);
			int sataPortCount = int.Parse(tbxNumberOfSataPorts.Text);
			bool hasWifi = (string)cbWiFi.SelectedItem == "Yes";
			bool allowsCpuOverclocking = (string)cbCPUOverclocking.SelectedItem == "Yes";

			MotherboardFormFactor formFactor;
			string selectedFormFactor = (string)cbFormFactor.SelectedItem;
			if (selectedFormFactor == "ATX") {
				formFactor = MotherboardFormFactor.ATX;
			} else if (selectedFormFactor == "Mini-ITX") {
				formFactor = MotherboardFormFactor.MiniITX;
			} else {
				formFactor = (MotherboardFormFactor)EnumUtils.DisplayStringToEnum(selectedFormFactor);
			}

			try {
				Products.AddMotherboard(name, manufacturer, price, stockQuantity, weight, benchmarkInfo, socket, chipset, formFactor,
					memoryType, memorySlotCount, maxSupportedMemoryGB, pcieSlotCount, m2SlotCount, sataPortCount, hasWifi,
					allowsCpuOverclocking);
				Close();
			} catch (ProductValidationException ex) {
				lblError.Text = ex.Message;
			}
		}

		private void btnCancel_Click(object sender, EventArgs e) {
			Close();
		}

		private void chbBenchMarkInfo_CheckedChanged(object sender, EventArgs e) {
			panelBenchMarkInfo.Enabled = chbBenchMarkInfo.Checked;
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