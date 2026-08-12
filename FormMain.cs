using MyCollections;

namespace WarehouseManager {
	public partial class FormMain: Form {
		public FormMain() {
			InitializeComponent();
			if (Users.CurrentIsCustomer) {
				chbAlmostOutOfStock.Hide();
				chbOutOfStock.Hide();
				btnAddProduct.Hide();
				cbProductToAdd.Hide();
				lblAddError.Hide();
				lblAddCategory.Hide();
				contextMenuProductList.Items.Remove(removeToolStripMenuItem);
				contextMenuProductList.Items.Remove(modifyToolStripMenuItem);

				Cart.CartChanged += UpdateCartCount;
				UpdateCartCount();
			} else if (Users.CurrentIsAdmin) {
				contextMenuProductList.Items.Remove(addToCartToolStripMenuItem);
				pbCart.Hide();
				lblCartCountNotif.Hide();
			}
			dgvProductList.AutoGenerateColumns = false;
			Products.ProductsChanged += RefreshProductList;
			RefreshProductList();

			rbtAll.Checked = true;

			chbOutOfStock.Checked = false;
			chbAlmostOutOfStock.Checked = false;
			Products.ShowOutOfStock = false;
			Products.ShowAlmostOutOfStock = false;

			Products.SearchTerm = string.Empty;
		}

		private void UpdateCartCount() {
			int cartCount = Cart.ProductCount;
			lblCartCountNotif.Text = cartCount > 0 ? cartCount.ToString() : string.Empty;
		}

		private void RefreshProductList() {
			int currentRowIndex = -1;
			if (dgvProductList.SelectedRows.Count != 0) {
				currentRowIndex = dgvProductList.SelectedRows[0].Index;
			}
			int currentRowCount = dgvProductList.Rows.Count;

			dgvProductList.DataSource = Products.GetProducts();

			bool NumberOfProductsUnChanged = currentRowCount == dgvProductList.Rows.Count;

			if (Users.CurrentIsAdmin) {
				if (currentRowIndex != -1 && NumberOfProductsUnChanged) {
					dgvProductList.Rows[currentRowIndex].Selected = true;
					dgvProductList.FirstDisplayedScrollingRowIndex = currentRowIndex;
				}
			}
		}

		private void rbtAll_CheckedChanged(object sender, EventArgs e) {
			if (rbtAll.Checked) Products.SetFilterToType<Product>();
			else if (rbtComponent.Checked) Products.SetFilterToType<ComputerComponent>();
			else if (rbtThermalPad.Checked) Products.SetFilterToType<ThermalPad>();
			else if (rbtThermalPaste.Checked) Products.SetFilterToType<ThermalPaste>();
			else if (rbtCPU.Checked) Products.SetFilterToType<CPU>();
			else if (rbtGraphicsCard.Checked) Products.SetFilterToType<GraphicsCard>();
			else if (rbtMotherboard.Checked) Products.SetFilterToType<Motherboard>();
			else if (rbtRAMKit.Checked) Products.SetFilterToType<RAMKit>();
			else if (rbtCPUCooler.Checked) Products.SetFilterToType<CPUCooler>();
			else if (rbtAirCooler.Checked) Products.SetFilterToType<AirCooler>();
			else if (rbtAIOCooler.Checked) Products.SetFilterToType<AIOCooler>();
			else if (rbtStorageDevice.Checked) Products.SetFilterToType<StorageDevice>();
			else if (rbtSataSSD.Checked) Products.SetFilterToType<SataSSD>();
			else if (rbtNVMeSSD.Checked) Products.SetFilterToType<NVMeSSD>();
			else if (rbtHDD.Checked) Products.SetFilterToType<HDD>();
			else if (rbtCase.Checked) Products.SetFilterToType<Case>();
			else if (rbtCaseFan.Checked) Products.SetFilterToType<CaseFan>();
			else if (rbtPSU.Checked) Products.SetFilterToType<PSU>();
		}

		private void chbOutOfStock_CheckedChanged(object sender, EventArgs e) {
			Products.ShowOutOfStock = chbOutOfStock.Checked;
		}

		private void chbAlmostOutOfStock_CheckedChanged(object sender, EventArgs e) {
			Products.ShowAlmostOutOfStock = chbAlmostOutOfStock.Checked;
		}

		private IReadOnlyProduct? GetSelectedRowProduct() {
			if (dgvProductList.SelectedRows.Count == 0) return null;

			IReadOnlyProduct? product = (IReadOnlyProduct?)dgvProductList.SelectedRows[0].DataBoundItem;
			return product;
		}

		private void dgvProductList_SelectionChanged(object sender, EventArgs e) {
			lblAddError.Text = string.Empty;
			lblAddToCartStatus.Text = string.Empty;
			IReadOnlyProduct? product = GetSelectedRowProduct();
			if (product is null) return;

			HashMap<string, string> specs = product.GetSpecifications();
			tbxSpecifications.Text = string.Empty;
			foreach (MyKeyValuePair<string, string> pair in specs) {
				tbxSpecifications.Text += $"{pair.Key}:\r\n{pair.Value}\r\n_________________________\r\n\r\n";
			}
		}

		private void btnAddProduct_Click(object sender, EventArgs e) {
			string? selection = cbProductToAdd!.SelectedItem?.ToString();
			if (selection is null) {
				lblAddError.Text = "You must choose a category.";
				ActiveControl = lblAddError;
			}
			switch (selection) {
				case "CPU":
					FormAddCPU formAddCPU = new FormAddCPU();
					formAddCPU.ShowDialog();
					break;
				case "Graphics Card":
					FormAddGraphicsCard formAddGraphicsCard = new FormAddGraphicsCard();
					formAddGraphicsCard.ShowDialog();
					break;
				case "AIO Cooler":
					FormAddAIOCooler formAddAIOCooler = new FormAddAIOCooler();
					formAddAIOCooler.ShowDialog();
					break;
				case "Air Cooler":
					FormAddAirCooler formAddAirCooler = new FormAddAirCooler();
					formAddAirCooler.ShowDialog();
					break;
				case "Case":
					FormAddCase formAddCase = new FormAddCase();
					formAddCase.ShowDialog();
					break;
				case "Thermal Pad":
					FormAddThermalPad formAddThermalPad = new FormAddThermalPad();
					formAddThermalPad.ShowDialog();
					break;
				case "Thermal Paste":
					FormAddThermalPaste formAddThermalPaste = new FormAddThermalPaste();
					formAddThermalPaste.ShowDialog();
					break;
				case "NVMe SSD":
					FormAddNVMeSSD formAddNVMeSSD = new FormAddNVMeSSD();
					formAddNVMeSSD.ShowDialog();
					break;
				case "HDD":
					FormAddHDD formAddHDD = new FormAddHDD();
					formAddHDD.ShowDialog();
					break;
				case "Sata SSD":
					FormAddSataSSD formAddSataSSD = new FormAddSataSSD();
					formAddSataSSD.ShowDialog();
					break;
				case "PSU":
					FormAddPSU formAddPSU = new FormAddPSU();
					formAddPSU.ShowDialog();
					break;
				case "RAM Kit":
					FormAddRAMKit formAddRAMKit = new FormAddRAMKit();
					formAddRAMKit.ShowDialog();
					break;
				case "Case Fan":
					FormAddCaseFan formAddCaseFan = new FormAddCaseFan();
					formAddCaseFan.ShowDialog();
					break;
				case "Motherboard":
					FormAddMotherboard formAddMotherboard = new FormAddMotherboard();
					formAddMotherboard.ShowDialog();
					break;
			}
		}

		private void dgvProductList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e) {
			if (e.Button == MouseButtons.Right && e.RowIndex >= 0) {
				DataGridViewRow row = dgvProductList.Rows[e.RowIndex];
				row.Selected = true;

				if (Users.CurrentIsAdmin) {
					IReadOnlyProduct? product = (IReadOnlyProduct?)row.DataBoundItem;
					modifyToolStripMenuItem.DropDownItems.Add(benchmarkInfoToolStripMenuItem);
					if (product is not ComputerComponent)
						modifyToolStripMenuItem.DropDownItems.Remove(benchmarkInfoToolStripMenuItem);
				}

				contextMenuProductList.Show(Cursor.Position);
			}
		}

		private void removeToolStripMenuItem_Click(object sender, EventArgs e) {
			IReadOnlyProduct? product = GetSelectedRowProduct();
			if (product is null) return;

			DialogResult choice = MessageBox.Show("Remove selected product?", "Product Removal", MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

			if (choice == DialogResult.Yes) {
				Products.RemoveProduct(product.ID);
			}
		}

		private void generalInfoToolStripMenuItem_Click(object sender, EventArgs e) {
			IReadOnlyProduct? product = GetSelectedRowProduct();
			if (product is null) return;

			FormModifyGeneralInfo formModifyGeneralInfo = new FormModifyGeneralInfo(product.ID, product.Name);
			formModifyGeneralInfo.ShowDialog();
		}

		private void benchmarkInfoToolStripMenuItem_Click(object sender, EventArgs e) {
			IReadOnlyProduct? product = GetSelectedRowProduct();
			if (product is not ComputerComponent) return;

			FormModifyBenchmarkInfo formModifyBenchmarkInfo = new FormModifyBenchmarkInfo(product.ID);
			formModifyBenchmarkInfo.ShowDialog();
		}

		private void tbxSearchBox_KeyPress(object sender, KeyPressEventArgs e) {
			FormSharedEventHandlers.StringTextBoxes_KeyPress(sender, e);
		}

		private void tbxSearchBox_TextChanged(object sender, EventArgs e) {
			string searchTerm = tbxSearchBox.Text;
			if (!string.IsNullOrWhiteSpace(searchTerm) || searchTerm == string.Empty) {
				if (Products.SearchTerm != searchTerm) {
					Products.SearchTerm = searchTerm;
				}
			}
		}

		private void specificationsToolStripMenuItem_Click(object sender, EventArgs e) {
			IReadOnlyProduct? product = GetSelectedRowProduct();
			if (product is null) return;

			switch (product) {
				case CPU:
					FormModifyCPU formModifyCPU = new FormModifyCPU(product.ID);
					formModifyCPU.ShowDialog();
					break;
				case GraphicsCard:
					FormModifyGraphicsCard formModifyGraphicsCard = new FormModifyGraphicsCard(product.ID);
					formModifyGraphicsCard.ShowDialog();
					break;
				case AIOCooler:
					FormModifyAIOCooler formModifyAIOCooler = new FormModifyAIOCooler(product.ID);
					formModifyAIOCooler.ShowDialog();
					break;
				case AirCooler:
					FormModifyAirCooler formModifyAirCooler = new FormModifyAirCooler(product.ID);
					formModifyAirCooler.ShowDialog();
					break;
				case Case:
					FormModifyCase formModifyCase = new FormModifyCase(product.ID);
					formModifyCase.ShowDialog();
					break;
				case ThermalPad:
					FormModifyThermalPad formModifyThermalPad = new FormModifyThermalPad(product.ID);
					formModifyThermalPad.ShowDialog();
					break;
				case ThermalPaste:
					FormModifyThermalPaste formModifyThermalPaste = new FormModifyThermalPaste(product.ID);
					formModifyThermalPaste.ShowDialog();
					break;
				case NVMeSSD:
					FormModifyNVMeSSD formModifyNVMeSSD = new FormModifyNVMeSSD(product.ID);
					formModifyNVMeSSD.ShowDialog();
					break;
				case HDD:
					FormModifyHDD formModifyHDD = new FormModifyHDD(product.ID);
					formModifyHDD.ShowDialog();
					break;
				case SataSSD:
					FormModifySataSSD formModifySataSSD = new FormModifySataSSD(product.ID);
					formModifySataSSD.ShowDialog();
					break;
				case PSU:
					FormModifyPSU formModifyPSU = new FormModifyPSU(product.ID);
					formModifyPSU.ShowDialog();
					break;
				case RAMKit:
					FormModifyRAMKit formModifyRAMKit = new FormModifyRAMKit(product.ID);
					formModifyRAMKit.ShowDialog();
					break;
				case CaseFan:
					FormModifyCaseFan formModifyCaseFan = new FormModifyCaseFan(product.ID);
					formModifyCaseFan.ShowDialog();
					break;
				case Motherboard:
					FormModifyMotherboard formModifyMotherboard = new FormModifyMotherboard(product.ID);
					formModifyMotherboard.ShowDialog();
					break;
			}
		}

		private void addToCartToolStripMenuItem_Click(object sender, EventArgs e) {
			IReadOnlyProduct? product = GetSelectedRowProduct();
			if (product is null) return;

			try {
				Cart.AddToCart(product);
				lblAddToCartStatus.ForeColor = Color.FromArgb(46, 184, 126);
				lblAddToCartStatus.Text = "Added to cart.";
			} catch (CartValidationException ex) {
				lblAddToCartStatus.ForeColor = Color.Red;
				lblAddToCartStatus.Text = ex.Message;
				ActiveControl = lblAddToCartStatus;
			}
		}

		private void ErrorLabels_Leave(object sender, EventArgs e) {
			((Label)sender).Text = string.Empty;
		}

		private void pbCrossCloseForm_Click(object sender, EventArgs e) {
			DialogResult choice = MessageBox.Show("Are you sure you want to quit?",
				null,
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning);

			if (choice == DialogResult.Yes) Application.Exit();
		}

		private void pbOrders_Click(object sender, EventArgs e) {
			FormOrders formOrders = new FormOrders();
			formOrders.Show();
			Close();
		}

		private void pbCart_Click(object sender, EventArgs e) {
			FormCart formCart = new FormCart();
			formCart.Show();
			Close();
		}

		private void pbAccount_Click(object sender, EventArgs e) {
			FormAccount formAccount = new FormAccount();
			formAccount.Show();
			Close();
		}

		private void pbMinimize_Click(object sender, EventArgs e) {
			WindowState = FormWindowState.Minimized;
		}
	}

}