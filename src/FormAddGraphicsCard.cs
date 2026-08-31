
namespace WarehouseManager {
	public partial class FormAddGraphicsCard: Form {
		public FormAddGraphicsCard() {
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
				string.IsNullOrWhiteSpace(tbxGPUManufacturer.Text) ||
				string.IsNullOrWhiteSpace(tbxChipModel.Text) ||
				string.IsNullOrWhiteSpace(tbxArchitecture.Text) ||
				string.IsNullOrWhiteSpace(tbxNumberOfCores.Text) ||
				string.IsNullOrWhiteSpace(tbxBaseClock.Text) ||
				string.IsNullOrWhiteSpace(tbxBoostClock.Text) ||
				string.IsNullOrWhiteSpace(tbxMemoryCapacity.Text) ||
				cbMemoryType.SelectedItem is null ||
				cbPCIeGeneration.SelectedItem is null ||
				string.IsNullOrWhiteSpace(tbxNumberOfPCIeLanes.Text) ||
				string.IsNullOrWhiteSpace(tbxTDP.Text) ||
				string.IsNullOrWhiteSpace(tbxNumberOfDisplayPorts.Text) ||
				string.IsNullOrWhiteSpace(tbxNumberOfHDMIPorts.Text)) {
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

			string gpuManufacturer = tbxGPUManufacturer.Text;
			string chipModel = tbxChipModel.Text;
			string architecture = tbxArchitecture.Text;
			int coreCount = int.Parse(tbxNumberOfCores.Text);
			int baseClockMHz = int.Parse(tbxBaseClock.Text);
			int boostClockMHz = int.Parse(tbxBoostClock.Text);
			int memoryCapacityGB = int.Parse(tbxMemoryCapacity.Text);
			GpuMemoryType memoryType = (GpuMemoryType)EnumUtils.DisplayStringToEnum((string)cbMemoryType.SelectedItem);
			PcieGeneration pcieGeneration = (PcieGeneration)EnumUtils.DisplayStringToEnum((string)cbPCIeGeneration.SelectedItem);
			int pcieLaneCount = int.Parse(tbxNumberOfPCIeLanes.Text);
			int tdpWatts = int.Parse(tbxTDP.Text);
			int displayPortCount = int.Parse(tbxNumberOfDisplayPorts.Text);
			int hdmiPortCount = int.Parse(tbxNumberOfHDMIPorts.Text);

			try {
				Products.AddGraphicsCard(name, manufacturer, price, stockQuantity, weight, benchmarkInfo, gpuManufacturer, chipModel,
					architecture, coreCount, baseClockMHz, boostClockMHz, memoryCapacityGB, memoryType, pcieGeneration, pcieLaneCount,
					tdpWatts, displayPortCount, hdmiPortCount);
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
