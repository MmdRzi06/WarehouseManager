
namespace WarehouseManager {
	public partial class FormOrders: Form {
		public FormOrders() {
			InitializeComponent();
			dgvOrders.AutoGenerateColumns = false;
			if (Users.CurrentIsCustomer)
				dgvOrders.DataSource = Users.GetOrders();
			else if (Users.CurrentIsAdmin)
				dgvOrders.DataSource = Users.GetAllOrders();
		}

		private void pbCrossCloseForm_Click(object sender, EventArgs e) {
			DialogResult choice = MessageBox.Show("Are you sure you want to quit?",
				null,
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning);

			if (choice == DialogResult.Yes) Application.Exit();
		}

		private void pbReturn_Click(object sender, EventArgs e) {
			FormMain formMain = new FormMain();
			formMain.Show();
			Close();
		}

		private void dgvOrders_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e) {
			if (e.RowIndex >= 0) dgvOrders.Rows[e.RowIndex].Selected = true;
		}

		private void showOrderSummaryToolStripMenuItem_Click(object sender, EventArgs e) {
			if (dgvOrders.SelectedRows.Count == 0) return;

			DataGridViewRow row = dgvOrders.SelectedRows[0];
			if (row is null) return;

			Order? order = (Order?)row.DataBoundItem;
			if (order is not null) {
				FormOrderSummary formOrderSummary = new FormOrderSummary(order);
				formOrderSummary.ShowDialog();
			}
		}

		private void pbMinimize_Click(object sender, EventArgs e) {
			WindowState = FormWindowState.Minimized;
		}
	}
}
