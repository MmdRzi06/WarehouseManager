
namespace WarehouseManager {
	public partial class FormAddRAMKit: Form {
		public FormAddRAMKit() {
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
				string.IsNullOrWhiteSpace(tbxModuleCapacity.Text) ||
				string.IsNullOrWhiteSpace(tbxNumberOfModules.Text) ||
				string.IsNullOrWhiteSpace(tbxSpeed.Text) ||
				string.IsNullOrWhiteSpace(tbxCASLatency.Text) ||
				cbMemoryType.SelectedItem is null ||
				cbXMPSupport.SelectedItem is null ||
				cbEXPOSupport.SelectedItem is null) {
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

			int moduleCapacityGB = int.Parse(tbxModuleCapacity.Text);
			int moduleCount = int.Parse(tbxNumberOfModules.Text);
			MemoryType memoryType = (MemoryType)EnumUtils.DisplayStringToEnum((string)cbMemoryType.SelectedItem);
			int speedMTs = int.Parse(tbxSpeed.Text);
			int casLatency = int.Parse(tbxCASLatency.Text);
			bool xmpSupport = (string)cbXMPSupport.SelectedItem == "Yes";
			bool expoSupport = (string)cbEXPOSupport.SelectedItem == "Yes";

			try {
				Products.AddRAMKit(name, manufacturer, price, stockQuantity, weight, benchmarkInfo, moduleCapacityGB,
					moduleCount, memoryType, speedMTs, casLatency, xmpSupport, expoSupport);
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
