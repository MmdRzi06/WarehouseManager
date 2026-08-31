namespace WarehouseManager {
	public partial class FormModifyCPU: Form {

		private readonly long ProductID;

		public FormModifyCPU(long productID) {
			InitializeComponent();
			ProductID = productID;
		}

		private void btnConfirm_Click(object sender, EventArgs e) {
			string? socket = null;
			string? microarchitecture = null;
			int? coreCount = null;
			int? threadCount = null;
			int? baseClockMHz = null;
			int? boostClockMHz = null;
			int? l3CacheMB = null;
			int? memoryChannelCount = null;
			int? maxSupportedMemoryGB = null;
			int? tdpWatts = null;
			bool? supportsOverclocking = null;

			bool AllFieldsNull = true;

			if (!string.IsNullOrWhiteSpace(tbxSocketType.Text)) {
				socket = tbxSocketType.Text;
				AllFieldsNull = false;
			}
			if (!string.IsNullOrWhiteSpace(tbxMicroarchitecture.Text)) {
				microarchitecture = tbxMicroarchitecture.Text;
				AllFieldsNull = false;
			}
			if (!string.IsNullOrWhiteSpace(tbxNumberOfCores.Text)) {
				coreCount = int.Parse(tbxNumberOfCores.Text);
				AllFieldsNull = false;
			}
			if (!string.IsNullOrWhiteSpace(tbxNumberOfThreads.Text)) {
				threadCount = int.Parse(tbxNumberOfThreads.Text);
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
			if (!string.IsNullOrWhiteSpace(tbxL3CacheSize.Text)) {
				l3CacheMB = int.Parse(tbxL3CacheSize.Text);
				AllFieldsNull = false;
			}
			if (!string.IsNullOrWhiteSpace(tbxNumberOfMemoryChannels.Text)) {
				memoryChannelCount = int.Parse(tbxNumberOfMemoryChannels.Text);
				AllFieldsNull = false;
			}
			if (!string.IsNullOrWhiteSpace(tbxMaximumSupportedMemoryCapacity.Text)) {
				maxSupportedMemoryGB = int.Parse(tbxMaximumSupportedMemoryCapacity.Text);
				AllFieldsNull = false;
			}
			if (!string.IsNullOrWhiteSpace(tbxTDP.Text)) {
				tdpWatts = int.Parse(tbxTDP.Text);
				AllFieldsNull = false;
			}
			if (cbOverclockingSupport.SelectedItem is not null) {
				supportsOverclocking = (string)cbOverclockingSupport.SelectedItem == "Yes";
				AllFieldsNull = false;
			}

			if (AllFieldsNull) {
				lblError.Text = FormSharedErrors.ModifyFormAllFieldsEmpty;
				return;
			}

			try {
				Products.ModifyCPU(ProductID, socket, microarchitecture, coreCount, threadCount, baseClockMHz, boostClockMHz,
					l3CacheMB, tdpWatts, memoryChannelCount, maxSupportedMemoryGB, supportsOverclocking);
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

		private void pbCrossClearOverclockingSupport_Click(object sender, EventArgs e) {
			cbOverclockingSupport.SelectedItem = null;
		}
	}
}