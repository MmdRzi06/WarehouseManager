
namespace WarehouseManager {
	public partial class FormOrderSummary: Form {

		public FormOrderSummary(Order order) {
			InitializeComponent();
			lblOrderIDDisplay.Text = order.ID;
			lblTotalDisplay.Text = $"{order.Total:C2}";
			dgvOrderItems.DataSource = order.GetOrderItems();
		}

		private void btnClose_Click(object sender, EventArgs e) {
			Close();
		}
	}
}
