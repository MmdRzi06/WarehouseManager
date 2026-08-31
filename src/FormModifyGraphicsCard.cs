
using System.Net.Sockets;

namespace WarehouseManager {
	public partial class FormModifyGraphicsCard: Form {

		private readonly long ProductID;

		public FormModifyGraphicsCard(long productID) {
			InitializeComponent();
			ProductID = productID;
		}

		private void btnConfirm_Click(object sender, EventArgs e) {
			string? gpuManufacturer = null;
			string? chipModel = null;
			string? architecture = null;
			int? coreCount = null;
			int? baseClockMHz = null;
			int? boostClockMHz = null;
			int? memoryCapacityGB = null;
			GpuMemoryType? memoryType = null;
			PcieGeneration? pcieGeneration = null;
			int? pcieLaneCount = null;
			int? tdpWatts = null;
			int? displayPortCount = null;
			int? hdmiPortCount = null;

			bool AllFieldsNull = true;

			if (!string.IsNullOrWhiteSpace(tbxGPUManufacturer.Text)) {
				gpuManufacturer = tbxGPUManufacturer.Text;
				AllFieldsNull = false;
			}
			if (!string.IsNullOrWhiteSpace(tbxChipModel.Text)) {
				chipModel = tbxChipModel.Text;
				AllFieldsNull = false;
			}
			if (!string.IsNullOrWhiteSpace(tbxArchitecture.Text)) {
				architecture = tbxArchitecture.Text;
				AllFieldsNull = false;
			}
			if (!string.IsNullOrWhiteSpace(tbxNumberOfCores.Text)) {
				coreCount = int.Parse(tbxNumberOfCores.Text);
				AllFieldsNull = false;
			}
			if (!string.IsNullOrWhiteSpace(tbxBaseClock.Text)) {
				baseClockMHz = int.Parse(tbxBaseClock.Text);
				AllFieldsNull = false;
			}
			if (!string.IsNullOrWhiteSpace(tbxBoostClock.Text)) {
				boostClockMHz = int.Parse(tbxBoostClock.Text);
				AllFieldsNull = false;
			}
			if (!string.IsNullOrWhiteSpace(tbxMemoryCapacity.Text)) {
				memoryCapacityGB = int.Parse(tbxMemoryCapacity.Text);
				AllFieldsNull = false;
			}
			if (cbMemoryType.SelectedItem is not null) {
				memoryType = (GpuMemoryType)EnumUtils.DisplayStringToEnum((string)cbMemoryType.SelectedItem);
				AllFieldsNull = false;
			}
			if (cbPCIeGeneration.SelectedItem is not null) {
				pcieGeneration = (PcieGeneration)EnumUtils.DisplayStringToEnum((string)cbPCIeGeneration.SelectedItem);
				AllFieldsNull = false;
			}
			if (!string.IsNullOrWhiteSpace(tbxTDP.Text)) {
				tdpWatts = int.Parse(tbxTDP.Text);
				AllFieldsNull = false;
			}
			if (!string.IsNullOrWhiteSpace(tbxNumberOfDisplayPorts.Text)) {
				displayPortCount = int.Parse(tbxNumberOfDisplayPorts.Text);
				AllFieldsNull = false;
			}
			if (!string.IsNullOrWhiteSpace(tbxNumberOfHDMIPorts.Text)) {
				hdmiPortCount = int.Parse(tbxNumberOfHDMIPorts.Text);
				AllFieldsNull = false;
			}

			if (!string.IsNullOrWhiteSpace(tbxMemoryCapacity.Text)) {
				memoryCapacityGB = int.Parse(tbxMemoryCapacity.Text);
				AllFieldsNull = false;
			}

			if (AllFieldsNull) {
				lblError.Text = FormSharedErrors.ModifyFormAllFieldsEmpty;
				return;
			}

			try {
				Products.ModifyGraphicsCard(ProductID, gpuManufacturer, chipModel, architecture, coreCount, baseClockMHz, boostClockMHz,
					memoryCapacityGB, memoryType, pcieGeneration, pcieLaneCount, tdpWatts, displayPortCount, hdmiPortCount);
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

		private void pbCrossClearMemoryType_Click(object sender, EventArgs e) {
			cbMemoryType.SelectedItem = null;
		}

		private void pbCrossClearPCIeGeneration_Click(object sender, EventArgs e) {
			cbPCIeGeneration.SelectedItem = null;
		}
	}
}