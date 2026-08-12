
namespace WarehouseManager {
	public partial class FormModifyRAMKit: Form {

		private readonly long ProductID;

		public FormModifyRAMKit(long productID) {
			InitializeComponent();
			ProductID = productID;
		}

		private void btnConfirm_Click(object sender, EventArgs e) {
			int? moduleCapacityGB = null;
			int? moduleCount = null;
			MemoryType? memoryType = null;
			int? speedMTs = null;
			int? casLatency = null;
			bool? xmpSupport = null;
			bool? expoSupport = null;

			bool AllFieldsNull = true;

			if (!string.IsNullOrWhiteSpace(tbxModuleCapacity.Text)) {
				moduleCapacityGB = int.Parse(tbxModuleCapacity.Text);
				AllFieldsNull = false;
			}
			if (!string.IsNullOrWhiteSpace(tbxNumberOfModules.Text)) {
				moduleCount = int.Parse(tbxNumberOfModules.Text);
				AllFieldsNull = false;
			}
			if (cbMemoryType.SelectedItem is not null) {
				memoryType = (MemoryType)EnumUtils.DisplayStringToEnum((string)cbMemoryType.SelectedItem);
				AllFieldsNull = false;
			}
			if (!string.IsNullOrWhiteSpace(tbxSpeed.Text)) {
				speedMTs = int.Parse(tbxSpeed.Text);
				AllFieldsNull = false;
			}
			if (!string.IsNullOrWhiteSpace(tbxCASLatency.Text)) {
				casLatency = int.Parse(tbxCASLatency.Text);
				AllFieldsNull = false;
			}
			if (cbXMPSupport.SelectedItem is not null) {
				xmpSupport = (string)cbXMPSupport.SelectedItem == "Yes";
				AllFieldsNull = false;
			}
			if (cbEXPOSupport.SelectedItem is not null) {
				expoSupport = (string)cbEXPOSupport.SelectedItem == "Yes";
				AllFieldsNull = false;
			}

			if (AllFieldsNull) {
				lblError.Text = FormSharedErrors.ModifyFormAllFieldsEmpty;
				return;
			}

			try {
				Products.ModifyRAMKit(ProductID, moduleCapacityGB, moduleCount, memoryType, speedMTs, casLatency, xmpSupport, expoSupport);
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

		private void pbCrossClearXMPSupport_Click(object sender, EventArgs e) {
			cbMemoryType.SelectedItem = null;
		}

		private void pbCrossClearEXPOSupport_Click(object sender, EventArgs e) {
			cbXMPSupport.SelectedItem = null;
		}

		private void pbCrossClearMemoryType_Click(object sender, EventArgs e) {
			cbXMPSupport.SelectedItem = null;
		}
	}
}
