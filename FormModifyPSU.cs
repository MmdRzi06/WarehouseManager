
namespace WarehouseManager {
	public partial class FormModifyPSU: Form {

		private readonly long ProductID;

		public FormModifyPSU(long productID) {
			InitializeComponent();
			ProductID = productID;
		}

		private void btnConfirm_Click(object sender, EventArgs e) {
			int? wattage = null;
			PSUEfficiencyRating? efficiencyRating = null;
			PSUModularity? modularity = null;
			PSUFormFactor? formFactor = null;

			bool AllFieldsNull = true;

			if (!string.IsNullOrWhiteSpace(tbxWattage.Text)) {
				wattage = int.Parse(tbxWattage.Text);
				AllFieldsNull = false;
			}
			if (cbEfficiencyRating.SelectedItem is not null) {
				efficiencyRating = (PSUEfficiencyRating)EnumUtils.DisplayStringToEnum((string)cbEfficiencyRating.SelectedItem);
				AllFieldsNull = false;
			}
			if (cbModularity.SelectedItem is not null) {
				modularity = (PSUModularity)EnumUtils.DisplayStringToEnum((string)cbModularity.SelectedItem);
				AllFieldsNull = false;
			}
			if (cbFormFactor.SelectedItem is not null) {
				string selectedItem = (string)cbFormFactor.SelectedItem;
				if (selectedItem == "ATX") formFactor = PSUFormFactor.ATX;
				else formFactor = (PSUFormFactor)EnumUtils.DisplayStringToEnum((string)cbFormFactor.SelectedItem);
				AllFieldsNull = false;
			}

			if (AllFieldsNull) {
				lblError.Text = FormSharedErrors.ModifyFormAllFieldsEmpty;
				return;
			}

			try {
				Products.ModifyPSU(ProductID, wattage, efficiencyRating, modularity, formFactor);
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

		private void pbCrossClearEfficiencyRating_Click(object sender, EventArgs e) {
			cbEfficiencyRating.SelectedItem = null;
		}

		private void pbCrossClearModularity_Click(object sender, EventArgs e) {
			cbModularity.SelectedItem = null;
		}

		private void pbCrossClearFormFactor_Click(object sender, EventArgs e) {
			cbEfficiencyRating.SelectedItem = null;
		}
	}
}
