namespace WarehouseManager {
	partial class FormCart {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			components = new System.ComponentModel.Container();
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCart));
			lblTotalDisplay = new Label();
			lblTotal = new Label();
			btnPlaceOrder = new Button();
			btnDecrementCartItemQuantity = new Button();
			btnIncrementCartItemQuantity = new Button();
			lblCartError = new Label();
			dgvCart = new DataGridView();
			dgvCartColumnName = new DataGridViewTextBoxColumn();
			dgvCartColumnPrice = new DataGridViewTextBoxColumn();
			dgvCartColumnQuantity = new DataGridViewTextBoxColumn();
			contextMenuCart = new ContextMenuStrip(components);
			removeFromCartToolStripMenuItem = new ToolStripMenuItem();
			lblCart = new Label();
			pbCrossCloseForm = new PictureBox();
			pbReturn = new PictureBox();
			panel = new Panel();
			pbMinimize = new PictureBox();
			((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
			contextMenuCart.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbCrossCloseForm).BeginInit();
			((System.ComponentModel.ISupportInitialize)pbReturn).BeginInit();
			panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbMinimize).BeginInit();
			SuspendLayout();
			// 
			// lblTotalDisplay
			// 
			lblTotalDisplay.BackColor = Color.Transparent;
			lblTotalDisplay.Font = new Font("Segoe UI", 10F);
			lblTotalDisplay.ForeColor = Color.FromArgb(236, 179, 101);
			lblTotalDisplay.Location = new Point(68, 380);
			lblTotalDisplay.Margin = new Padding(3);
			lblTotalDisplay.Name = "lblTotalDisplay";
			lblTotalDisplay.Size = new Size(161, 19);
			lblTotalDisplay.TabIndex = 53;
			// 
			// lblTotal
			// 
			lblTotal.AutoSize = true;
			lblTotal.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
			lblTotal.ForeColor = Color.FromArgb(236, 179, 101);
			lblTotal.Location = new Point(19, 380);
			lblTotal.Margin = new Padding(3);
			lblTotal.Name = "lblTotal";
			lblTotal.Size = new Size(43, 19);
			lblTotal.TabIndex = 52;
			lblTotal.Text = "Total:";
			lblTotal.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// btnPlaceOrder
			// 
			btnPlaceOrder.BackColor = Color.FromArgb(4, 41, 58);
			btnPlaceOrder.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 41, 58);
			btnPlaceOrder.FlatAppearance.MouseOverBackColor = Color.FromArgb(6, 70, 99);
			btnPlaceOrder.FlatStyle = FlatStyle.Flat;
			btnPlaceOrder.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnPlaceOrder.ForeColor = Color.FromArgb(236, 179, 101);
			btnPlaceOrder.Location = new Point(352, 380);
			btnPlaceOrder.Name = "btnPlaceOrder";
			btnPlaceOrder.Size = new Size(123, 33);
			btnPlaceOrder.TabIndex = 51;
			btnPlaceOrder.Text = "Place Order";
			btnPlaceOrder.UseVisualStyleBackColor = false;
			btnPlaceOrder.Click += btnPlaceOrder_Click;
			// 
			// btnDecrementCartItemQuantity
			// 
			btnDecrementCartItemQuantity.BackColor = Color.FromArgb(4, 41, 58);
			btnDecrementCartItemQuantity.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 41, 58);
			btnDecrementCartItemQuantity.FlatAppearance.MouseOverBackColor = Color.FromArgb(6, 70, 99);
			btnDecrementCartItemQuantity.FlatStyle = FlatStyle.Flat;
			btnDecrementCartItemQuantity.ForeColor = Color.FromArgb(236, 179, 101);
			btnDecrementCartItemQuantity.Image = Properties.Resources.DownArrow_Color;
			btnDecrementCartItemQuantity.Location = new Point(478, 78);
			btnDecrementCartItemQuantity.Margin = new Padding(0);
			btnDecrementCartItemQuantity.Name = "btnDecrementCartItemQuantity";
			btnDecrementCartItemQuantity.Size = new Size(26, 16);
			btnDecrementCartItemQuantity.TabIndex = 49;
			btnDecrementCartItemQuantity.UseVisualStyleBackColor = false;
			btnDecrementCartItemQuantity.Click += btnDecrementCartItemQuantity_Click;
			// 
			// btnIncrementCartItemQuantity
			// 
			btnIncrementCartItemQuantity.BackColor = Color.FromArgb(4, 41, 58);
			btnIncrementCartItemQuantity.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 41, 58);
			btnIncrementCartItemQuantity.FlatAppearance.MouseOverBackColor = Color.FromArgb(6, 70, 99);
			btnIncrementCartItemQuantity.FlatStyle = FlatStyle.Flat;
			btnIncrementCartItemQuantity.ForeColor = Color.FromArgb(236, 179, 101);
			btnIncrementCartItemQuantity.Image = Properties.Resources.UpArrow_Color;
			btnIncrementCartItemQuantity.Location = new Point(478, 62);
			btnIncrementCartItemQuantity.Margin = new Padding(0);
			btnIncrementCartItemQuantity.Name = "btnIncrementCartItemQuantity";
			btnIncrementCartItemQuantity.Size = new Size(26, 16);
			btnIncrementCartItemQuantity.TabIndex = 48;
			btnIncrementCartItemQuantity.UseVisualStyleBackColor = false;
			btnIncrementCartItemQuantity.Click += btnIncrementCartItemQuantity_Click;
			// 
			// lblCartError
			// 
			lblCartError.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblCartError.ForeColor = Color.FromArgb(244, 43, 50);
			lblCartError.Location = new Point(108, 37);
			lblCartError.Name = "lblCartError";
			lblCartError.Size = new Size(283, 23);
			lblCartError.TabIndex = 47;
			lblCartError.Text = "\r\n";
			lblCartError.TextAlign = ContentAlignment.MiddleCenter;
			lblCartError.Leave += lblCartError_Leave;
			// 
			// dgvCart
			// 
			dgvCart.AllowUserToAddRows = false;
			dgvCart.AllowUserToDeleteRows = false;
			dgvCart.AllowUserToResizeColumns = false;
			dgvCart.AllowUserToResizeRows = false;
			dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvCart.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
			dgvCart.BackgroundColor = Color.FromArgb(4, 41, 58);
			dgvCart.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = Color.FromArgb(4, 41, 58);
			dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			dataGridViewCellStyle1.ForeColor = Color.FromArgb(236, 179, 101);
			dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(4, 41, 58);
			dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(236, 179, 101);
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			dgvCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			dgvCart.ColumnHeadersHeight = 35;
			dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dgvCart.Columns.AddRange(new DataGridViewColumn[] { dgvCartColumnName, dgvCartColumnPrice, dgvCartColumnQuantity });
			dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = Color.FromArgb(4, 41, 58);
			dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
			dataGridViewCellStyle4.ForeColor = Color.FromArgb(236, 179, 101);
			dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(6, 70, 99);
			dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(236, 179, 101);
			dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
			dgvCart.DefaultCellStyle = dataGridViewCellStyle4;
			dgvCart.EnableHeadersVisualStyles = false;
			dgvCart.GridColor = Color.FromArgb(4, 28, 50);
			dgvCart.Location = new Point(19, 62);
			dgvCart.Margin = new Padding(3, 2, 3, 2);
			dgvCart.MultiSelect = false;
			dgvCart.Name = "dgvCart";
			dgvCart.RowHeadersVisible = false;
			dgvCart.RowHeadersWidth = 51;
			dgvCart.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dgvCart.RowTemplate.ContextMenuStrip = contextMenuCart;
			dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvCart.ShowCellErrors = false;
			dgvCart.ShowCellToolTips = false;
			dgvCart.ShowEditingIcon = false;
			dgvCart.ShowRowErrors = false;
			dgvCart.Size = new Size(456, 313);
			dgvCart.TabIndex = 46;
			dgvCart.CellMouseDown += dgvCart_CellMouseDown;
			dgvCart.SelectionChanged += dgvCart_SelectionChanged;
			// 
			// dgvCartColumnName
			// 
			dgvCartColumnName.DataPropertyName = "Name";
			dgvCartColumnName.FillWeight = 60F;
			dgvCartColumnName.HeaderText = "Name";
			dgvCartColumnName.Name = "dgvCartColumnName";
			dgvCartColumnName.ReadOnly = true;
			// 
			// dgvCartColumnPrice
			// 
			dgvCartColumnPrice.DataPropertyName = "Price";
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.Format = "C2";
			dataGridViewCellStyle2.NullValue = null;
			dgvCartColumnPrice.DefaultCellStyle = dataGridViewCellStyle2;
			dgvCartColumnPrice.FillWeight = 20F;
			dgvCartColumnPrice.HeaderText = "Price";
			dgvCartColumnPrice.Name = "dgvCartColumnPrice";
			dgvCartColumnPrice.ReadOnly = true;
			// 
			// dgvCartColumnQuantity
			// 
			dgvCartColumnQuantity.DataPropertyName = "Quantity";
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dgvCartColumnQuantity.DefaultCellStyle = dataGridViewCellStyle3;
			dgvCartColumnQuantity.FillWeight = 20F;
			dgvCartColumnQuantity.HeaderText = "Quantity";
			dgvCartColumnQuantity.Name = "dgvCartColumnQuantity";
			dgvCartColumnQuantity.ReadOnly = true;
			// 
			// contextMenuCart
			// 
			contextMenuCart.BackColor = Color.White;
			contextMenuCart.Items.AddRange(new ToolStripItem[] { removeFromCartToolStripMenuItem });
			contextMenuCart.Name = "contextMenuCart";
			contextMenuCart.Size = new Size(174, 26);
			// 
			// removeFromCartToolStripMenuItem
			// 
			removeFromCartToolStripMenuItem.ForeColor = Color.Black;
			removeFromCartToolStripMenuItem.Name = "removeFromCartToolStripMenuItem";
			removeFromCartToolStripMenuItem.Size = new Size(173, 22);
			removeFromCartToolStripMenuItem.Text = "Remove From Cart";
			removeFromCartToolStripMenuItem.Click += removeFromCartToolStripMenuItem_Click_1;
			// 
			// lblCart
			// 
			lblCart.AutoSize = true;
			lblCart.BackColor = Color.Transparent;
			lblCart.FlatStyle = FlatStyle.Flat;
			lblCart.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblCart.ForeColor = Color.FromArgb(236, 179, 101);
			lblCart.Location = new Point(38, 9);
			lblCart.Name = "lblCart";
			lblCart.Size = new Size(50, 25);
			lblCart.TabIndex = 54;
			lblCart.Text = "Cart";
			lblCart.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// pbCrossCloseForm
			// 
			pbCrossCloseForm.Cursor = Cursors.Hand;
			pbCrossCloseForm.Image = Properties.Resources.Cross_Color;
			pbCrossCloseForm.Location = new Point(483, 10);
			pbCrossCloseForm.Margin = new Padding(1);
			pbCrossCloseForm.Name = "pbCrossCloseForm";
			pbCrossCloseForm.Size = new Size(24, 24);
			pbCrossCloseForm.SizeMode = PictureBoxSizeMode.AutoSize;
			pbCrossCloseForm.TabIndex = 83;
			pbCrossCloseForm.TabStop = false;
			pbCrossCloseForm.Click += pbCrossCloseForm_Click;
			// 
			// pbReturn
			// 
			pbReturn.Cursor = Cursors.Hand;
			pbReturn.Image = Properties.Resources.Return_Color;
			pbReturn.Location = new Point(10, 10);
			pbReturn.Margin = new Padding(1);
			pbReturn.Name = "pbReturn";
			pbReturn.Size = new Size(24, 24);
			pbReturn.SizeMode = PictureBoxSizeMode.AutoSize;
			pbReturn.TabIndex = 84;
			pbReturn.TabStop = false;
			pbReturn.Click += pbReturn_Click;
			// 
			// panel
			// 
			panel.BackColor = Color.Transparent;
			panel.BorderStyle = BorderStyle.FixedSingle;
			panel.Controls.Add(pbMinimize);
			panel.Dock = DockStyle.Fill;
			panel.Location = new Point(0, 0);
			panel.Name = "panel";
			panel.Padding = new Padding(1);
			panel.Size = new Size(517, 424);
			panel.TabIndex = 89;
			// 
			// pbMinimize
			// 
			pbMinimize.Cursor = Cursors.Hand;
			pbMinimize.Image = Properties.Resources.Minimize_Color;
			pbMinimize.Location = new Point(447, 9);
			pbMinimize.Margin = new Padding(1, 1, 10, 1);
			pbMinimize.Name = "pbMinimize";
			pbMinimize.Size = new Size(24, 24);
			pbMinimize.SizeMode = PictureBoxSizeMode.AutoSize;
			pbMinimize.TabIndex = 93;
			pbMinimize.TabStop = false;
			pbMinimize.Click += pbMinimize_Click;
			// 
			// FormCart
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(4, 28, 50);
			ClientSize = new Size(517, 424);
			Controls.Add(pbReturn);
			Controls.Add(pbCrossCloseForm);
			Controls.Add(lblCart);
			Controls.Add(lblTotalDisplay);
			Controls.Add(lblTotal);
			Controls.Add(btnPlaceOrder);
			Controls.Add(btnDecrementCartItemQuantity);
			Controls.Add(btnIncrementCartItemQuantity);
			Controls.Add(lblCartError);
			Controls.Add(dgvCart);
			Controls.Add(panel);
			FormBorderStyle = FormBorderStyle.None;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "FormCart";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "FormCart";
			((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
			contextMenuCart.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pbCrossCloseForm).EndInit();
			((System.ComponentModel.ISupportInitialize)pbReturn).EndInit();
			panel.ResumeLayout(false);
			panel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pbMinimize).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblTotalDisplay;
		private Label lblTotal;
		private Button btnPlaceOrder;
		private Button btnDecrementCartItemQuantity;
		private Button btnIncrementCartItemQuantity;
		private Label lblCartError;
		private DataGridView dgvCart;
		private DataGridViewTextBoxColumn dgvCartColumnName;
		private DataGridViewTextBoxColumn dgvCartColumnPrice;
		private DataGridViewTextBoxColumn dgvCartColumnQuantity;
		private ContextMenuStrip contextMenuCart;
		private ToolStripMenuItem removeFromCartToolStripMenuItem;
		private Label lblCart;
		private PictureBox pbCrossCloseForm;
		private PictureBox pbReturn;
		private Panel panel;
		private PictureBox pbMinimize;
	}
}