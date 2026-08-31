using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WarehouseManager {
	public partial class FormAddAirCooler: Form {
		public FormAddAirCooler() {
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
				string.IsNullOrWhiteSpace(tbxMinimumFanSpeed.Text) ||
				string.IsNullOrWhiteSpace(tbxMaximumFanSpeed.Text) ||
				string.IsNullOrWhiteSpace(tbxFanSize.Text) ||
				string.IsNullOrWhiteSpace(tbxMaxNoiseLevel.Text) ||
				string.IsNullOrWhiteSpace(tbxCoolerHeight.Text)) {
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

			int minFanSpeedRpm = int.Parse(tbxMinimumFanSpeed.Text);
			int maxFanSpeedRpm = int.Parse(tbxMaximumFanSpeed.Text);
			int fanSizeMm = int.Parse(tbxFanSize.Text);
			double.TryParse(tbxMaxNoiseLevel.Text, out double rMaxNoiseLevel);
			double maxNoiseLevelDbA = rMaxNoiseLevel;
			int coolerHeightMm = int.Parse(tbxCoolerHeight.Text);

			try {
				Products.AddAirCooler(name, manufacturer, price, stockQuantity, weight, benchmarkInfo, minFanSpeedRpm, maxFanSpeedRpm,
					fanSizeMm, maxNoiseLevelDbA, coolerHeightMm);
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
