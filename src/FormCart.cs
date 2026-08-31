namespace WarehouseManager {
	public partial class FormCart: Form {
		public FormCart() {
			InitializeComponent();
			Users.OrderAdded += OrderAddHandler;
			Cart.CartChanged += RefreshCart;

			dgvCart.AutoGenerateColumns = false;
			lblTotalDisplay.Text = $"{0:C2}";
			btnIncrementCartItemQuantity.Enabled = false;
			btnDecrementCartItemQuantity.Enabled = false;
			btnPlaceOrder.Enabled = false;

			RefreshCart();
		}

		private void RefreshCart() {
			int currentRowIndex = -1;
			if (dgvCart.SelectedRows.Count != 0) {
				currentRowIndex = dgvCart.SelectedRows[0].Index;
			}
			int currentRowCount = dgvCart.Rows.Count;

			CartItem[] cartItems = Cart.GetCartItems();
			dgvCart.DataSource = cartItems;

			decimal total = 0;
			foreach (CartItem item in cartItems) total += item.Price * item.Quantity;
			lblTotalDisplay.Text = $"{total:C2}";

			if (cartItems.Length > 0) {
				if (!btnPlaceOrder.Enabled) btnPlaceOrder.Enabled = true;
			} else {
				if (btnPlaceOrder.Enabled) btnPlaceOrder.Enabled = false;
			}

			bool NumberOfCartItemsUnChanged = currentRowCount == dgvCart.Rows.Count;

			if (currentRowIndex != -1 && NumberOfCartItemsUnChanged) {
				dgvCart.Rows[currentRowIndex].Selected = true;
				dgvCart.FirstDisplayedScrollingRowIndex = currentRowIndex;
			}
		}

		private void OrderAddHandler(Order order) {
			FormOrderSummary formOrderSummary = new FormOrderSummary(order);
			formOrderSummary.ShowDialog();
		}

		private CartItem? GetCartSelectedItem() {
			if (dgvCart.SelectedRows.Count == 0) return null;

			DataGridViewRow row = dgvCart.SelectedRows[0];
			if (row is null) return null;

			CartItem? cartItem = (CartItem?)row.DataBoundItem;
			return cartItem;
		}

		private void dgvCart_SelectionChanged(object sender, EventArgs e) {
			CartItem? item = GetCartSelectedItem();
			if (item is null) {
				btnIncrementCartItemQuantity.Enabled = false;
				btnDecrementCartItemQuantity.Enabled = false;
				return;
			}

			btnIncrementCartItemQuantity.Enabled = true;

			if (item.Quantity > 1) {
				btnDecrementCartItemQuantity.Enabled = true;
			} else {
				btnDecrementCartItemQuantity.Enabled = false;
			}
		}

		private void btnIncrementCartItemQuantity_Click(object sender, EventArgs e) {
			CartItem? item = GetCartSelectedItem();
			if (item is null) return;

			try {
				Cart.IncrementItemQuantity(item.Product);
				ActiveControl = null;
			} catch (CartValidationException ex) {
				lblCartError.Text = ex.Message;
				ActiveControl = lblCartError;
				btnIncrementCartItemQuantity.Enabled = false;
			}
		}

		private void btnDecrementCartItemQuantity_Click(object sender, EventArgs e) {
			CartItem? item = GetCartSelectedItem();
			if (item is null) return;

			try {
				Cart.DecrementItemQuanity(item.Product);
				ActiveControl = null;
			} catch (CartValidationException ex) {
				lblCartError.Text = ex.Message;
				ActiveControl = lblCartError;
				btnDecrementCartItemQuantity.Enabled = false;
			}
		}

		private void removeFromCartToolStripMenuItem_Click(object sender, EventArgs e) {
			CartItem? item = GetCartSelectedItem();
			if (item is null) return;

			Cart.RemoveFromCart(item.Product);
		}

		private void btnPlaceOrder_Click(object sender, EventArgs e) {
			lblCartError.Text = string.Empty;
			Cart.FinalizeOrder();
		}

		private void pbReturn_Click(object sender, EventArgs e) {
			FormMain formMain = new FormMain();
			formMain.Show();
			Close();
		}

		private void pbCrossCloseForm_Click(object sender, EventArgs e) {
			DialogResult choice = MessageBox.Show("Are you sure you want to quit?",
				null,
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning);

			if (choice == DialogResult.Yes) Application.Exit();
		}

		private void dgvCart_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e) {
			if (e.RowIndex >= 0) dgvCart.Rows[e.RowIndex].Selected = true;
		}

		private void removeFromCartToolStripMenuItem_Click_1(object sender, EventArgs e) {
			if (dgvCart.SelectedRows.Count == 0) return;

			CartItem? cartItem = (CartItem?)dgvCart.SelectedRows[0].DataBoundItem;
			if (cartItem == null) return;

			Cart.RemoveFromCart(cartItem.Product);
		}

		private void pbMinimize_Click(object sender, EventArgs e) {
			WindowState = FormWindowState.Minimized;
		}

		private void lblCartError_Leave(object sender, EventArgs e) {
			lblCart.Text = string.Empty;
		}
	}
}