namespace WarehouseManager
{
	public partial class FormAddCase: Form {
		public FormAddCase() {
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
				cbFormFactor.SelectedItem is null ||
				cbLSMFF.SelectedItem is null ||
				string.IsNullOrWhiteSpace(tbxMaximumGPULength.Text) ||
				string.IsNullOrWhiteSpace(tbxMaximumCPUCoolerHeight.Text)) {
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

			CaseFormFactor formFactor = (CaseFormFactor)EnumUtils.DisplayStringToEnum((string)cbFormFactor.SelectedItem);
			MotherboardFormFactor largestSupportedMotherboardFormFactor;

			string largestSupportedMotherboardFormFactorStr = (string)cbLSMFF.SelectedItem;
			if (largestSupportedMotherboardFormFactorStr == "ATX") largestSupportedMotherboardFormFactor = MotherboardFormFactor.ATX;
			else if (largestSupportedMotherboardFormFactorStr == "Mini-ITX") largestSupportedMotherboardFormFactor = MotherboardFormFactor.MiniITX;
			else largestSupportedMotherboardFormFactor = (MotherboardFormFactor)EnumUtils.DisplayStringToEnum(largestSupportedMotherboardFormFactorStr);

			int maxGpuLengthMm = int.Parse(tbxMaximumGPULength.Text);
			int maxCpuCoolerHeightMm = int.Parse(tbxMaximumCPUCoolerHeight.Text);

			try {
				Products.AddCase(name, manufacturer, price, stockQuantity, weight, benchmarkInfo, formFactor,
					largestSupportedMotherboardFormFactor, maxGpuLengthMm, maxCpuCoolerHeightMm);
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
