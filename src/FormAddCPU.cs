
namespace WarehouseManager {
	public partial class FormAddCPU: Form {

		public FormAddCPU() {
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
				string.IsNullOrWhiteSpace(tbxMicroarchitecture.Text) ||
				string.IsNullOrWhiteSpace(tbxNumberOfCores.Text) ||
				string.IsNullOrWhiteSpace(tbxNumberOfThreads.Text) ||
				string.IsNullOrWhiteSpace(tbxBaseClock.Text) ||
				string.IsNullOrWhiteSpace(tbxBoostClock.Text) ||
				string.IsNullOrWhiteSpace(tbxL3CacheSize.Text) ||
				string.IsNullOrWhiteSpace(tbxNumberOfMemoryChannels.Text) ||
				string.IsNullOrWhiteSpace(tbxMaximumSupportedMemoryCapacity.Text) ||
				string.IsNullOrWhiteSpace(tbxTDP.Text) ||
				cbOverclockingSupport.SelectedItem is null) {
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
			string microarchitecture = tbxMicroarchitecture.Text;
			int coreCount = int.Parse(tbxNumberOfCores.Text);
			int threadCount = int.Parse(tbxNumberOfThreads.Text);
			int baseClockMHz = int.Parse(tbxBaseClock.Text);
			int boostClockMHz = int.Parse(tbxBoostClock.Text);
			int l3CacheMB = int.Parse(tbxL3CacheSize.Text);
			int memoryChannelCount = int.Parse(tbxNumberOfMemoryChannels.Text);
			int maxSupportedMemoryGB = int.Parse(tbxMaximumSupportedMemoryCapacity.Text);
			int tdpWatts = int.Parse(tbxTDP.Text);
			bool supportsOverclocking = (string)cbOverclockingSupport.SelectedItem == "Yes";

			try {
				Products.AddCPU(name, manufacturer, price, stockQuantity, weight, benchmarkInfo, socket, microarchitecture, coreCount, threadCount,
				baseClockMHz, boostClockMHz, l3CacheMB, tdpWatts, memoryChannelCount, maxSupportedMemoryGB, supportsOverclocking);
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