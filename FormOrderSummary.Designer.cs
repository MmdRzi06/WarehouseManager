namespace WarehouseManager {
	partial class FormOrderSummary {
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
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrderSummary));
			dgvOrderItems = new DataGridView();
			dgvOrderItemsColumnName = new DataGridViewTextBoxColumn();
			dgvOrderItemsColumnPrice = new DataGridViewTextBoxColumn();
			dgvOrderItemsColumnQuantity = new DataGridViewTextBoxColumn();
			lblTotalDisplay = new Label();
			lblTotal = new Label();
			lblOrderID = new Label();
			lblOrderIDDisplay = new Label();
			panel = new Panel();
			lblOrderSummary = new Label();
			btnClose = new Button();
			((System.ComponentModel.ISupportInitialize)dgvOrderItems).BeginInit();
			panel.SuspendLayout();
			SuspendLayout();
			// 
			// dgvOrderItems
			// 
			dgvOrderItems.AllowUserToAddRows = false;
			dgvOrderItems.AllowUserToDeleteRows = false;
			dgvOrderItems.AllowUserToResizeColumns = false;
			dgvOrderItems.AllowUserToResizeRows = false;
			dgvOrderItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvOrderItems.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
			dgvOrderItems.BackgroundColor = Color.FromArgb(4, 41, 58);
			dgvOrderItems.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = Color.FromArgb(4, 41, 58);
			dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			dataGridViewCellStyle1.ForeColor = Color.FromArgb(236, 179, 101);
			dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(4, 41, 58);
			dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(236, 179, 101);
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			dgvOrderItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			dgvOrderItems.ColumnHeadersHeight = 35;
			dgvOrderItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dgvOrderItems.Columns.AddRange(new DataGridViewColumn[] { dgvOrderItemsColumnName, dgvOrderItemsColumnPrice, dgvOrderItemsColumnQuantity });
			dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = Color.FromArgb(4, 41, 58);
			dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
			dataGridViewCellStyle4.ForeColor = Color.FromArgb(236, 179, 101);
			dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(4, 41, 58);
			dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(236, 179, 101);
			dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
			dgvOrderItems.DefaultCellStyle = dataGridViewCellStyle4;
			dgvOrderItems.EnableHeadersVisualStyles = false;
			dgvOrderItems.GridColor = Color.FromArgb(4, 28, 50);
			dgvOrderItems.Location = new Point(12, 61);
			dgvOrderItems.Margin = new Padding(3, 2, 3, 2);
			dgvOrderItems.MultiSelect = false;
			dgvOrderItems.Name = "dgvOrderItems";
			dgvOrderItems.ReadOnly = true;
			dgvOrderItems.RowHeadersVisible = false;
			dgvOrderItems.RowHeadersWidth = 51;
			dgvOrderItems.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dgvOrderItems.ShowCellErrors = false;
			dgvOrderItems.ShowCellToolTips = false;
			dgvOrderItems.ShowEditingIcon = false;
			dgvOrderItems.ShowRowErrors = false;
			dgvOrderItems.Size = new Size(456, 313);
			dgvOrderItems.TabIndex = 40;
			// 
			// dgvOrderItemsColumnName
			// 
			dgvOrderItemsColumnName.DataPropertyName = "Name";
			dgvOrderItemsColumnName.FillWeight = 60F;
			dgvOrderItemsColumnName.HeaderText = "Name";
			dgvOrderItemsColumnName.Name = "dgvOrderItemsColumnName";
			dgvOrderItemsColumnName.ReadOnly = true;
			// 
			// dgvOrderItemsColumnPrice
			// 
			dgvOrderItemsColumnPrice.DataPropertyName = "UnitPrice";
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.Format = "C2";
			dataGridViewCellStyle2.NullValue = null;
			dgvOrderItemsColumnPrice.DefaultCellStyle = dataGridViewCellStyle2;
			dgvOrderItemsColumnPrice.FillWeight = 20F;
			dgvOrderItemsColumnPrice.HeaderText = "Unit Price";
			dgvOrderItemsColumnPrice.Name = "dgvOrderItemsColumnPrice";
			dgvOrderItemsColumnPrice.ReadOnly = true;
			// 
			// dgvOrderItemsColumnQuantity
			// 
			dgvOrderItemsColumnQuantity.DataPropertyName = "Quantity";
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dgvOrderItemsColumnQuantity.DefaultCellStyle = dataGridViewCellStyle3;
			dgvOrderItemsColumnQuantity.FillWeight = 20F;
			dgvOrderItemsColumnQuantity.HeaderText = "Quantity";
			dgvOrderItemsColumnQuantity.Name = "dgvOrderItemsColumnQuantity";
			dgvOrderItemsColumnQuantity.ReadOnly = true;
			// 
			// lblTotalDisplay
			// 
			lblTotalDisplay.BackColor = Color.Transparent;
			lblTotalDisplay.Font = new Font("Segoe UI", 10F);
			lblTotalDisplay.ForeColor = Color.FromArgb(236, 179, 101);
			lblTotalDisplay.Location = new Point(61, 379);
			lblTotalDisplay.Margin = new Padding(3);
			lblTotalDisplay.Name = "lblTotalDisplay";
			lblTotalDisplay.Size = new Size(407, 19);
			lblTotalDisplay.TabIndex = 152;
			// 
			// lblTotal
			// 
			lblTotal.AutoSize = true;
			lblTotal.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
			lblTotal.ForeColor = Color.FromArgb(236, 179, 101);
			lblTotal.Location = new Point(12, 379);
			lblTotal.Margin = new Padding(3);
			lblTotal.Name = "lblTotal";
			lblTotal.Size = new Size(43, 19);
			lblTotal.TabIndex = 151;
			lblTotal.Text = "Total:";
			// 
			// lblOrderID
			// 
			lblOrderID.AutoSize = true;
			lblOrderID.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
			lblOrderID.ForeColor = Color.FromArgb(236, 179, 101);
			lblOrderID.Location = new Point(12, 37);
			lblOrderID.Margin = new Padding(3);
			lblOrderID.Name = "lblOrderID";
			lblOrderID.Size = new Size(66, 19);
			lblOrderID.TabIndex = 153;
			lblOrderID.Text = "Order ID:";
			// 
			// lblOrderIDDisplay
			// 
			lblOrderIDDisplay.Font = new Font("Segoe UI", 10F);
			lblOrderIDDisplay.ForeColor = Color.FromArgb(236, 179, 101);
			lblOrderIDDisplay.Location = new Point(84, 37);
			lblOrderIDDisplay.Margin = new Padding(3);
			lblOrderIDDisplay.Name = "lblOrderIDDisplay";
			lblOrderIDDisplay.Size = new Size(173, 19);
			lblOrderIDDisplay.TabIndex = 154;
			// 
			// panel
			// 
			panel.BackColor = Color.Transparent;
			panel.BorderStyle = BorderStyle.FixedSingle;
			panel.Controls.Add(lblOrderSummary);
			panel.Controls.Add(btnClose);
			panel.Dock = DockStyle.Fill;
			panel.Location = new Point(0, 0);
			panel.Name = "panel";
			panel.Padding = new Padding(1);
			panel.Size = new Size(482, 452);
			panel.TabIndex = 155;
			// 
			// lblOrderSummary
			// 
			lblOrderSummary.AutoSize = true;
			lblOrderSummary.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblOrderSummary.ForeColor = Color.FromArgb(236, 179, 101);
			lblOrderSummary.Location = new Point(11, 8);
			lblOrderSummary.Name = "lblOrderSummary";
			lblOrderSummary.Size = new Size(131, 21);
			lblOrderSummary.TabIndex = 129;
			lblOrderSummary.Text = "Order Summary";
			// 
			// btnClose
			// 
			btnClose.BackColor = Color.FromArgb(4, 41, 58);
			btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 41, 58);
			btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(6, 70, 99);
			btnClose.FlatStyle = FlatStyle.Flat;
			btnClose.ForeColor = Color.FromArgb(236, 179, 101);
			btnClose.Location = new Point(354, 402);
			btnClose.Margin = new Padding(3, 2, 3, 2);
			btnClose.Name = "btnClose";
			btnClose.Size = new Size(115, 38);
			btnClose.TabIndex = 115;
			btnClose.Text = "Close";
			btnClose.UseVisualStyleBackColor = false;
			btnClose.Click += btnClose_Click;
			// 
			// FormOrderSummary
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(4, 28, 50);
			ClientSize = new Size(482, 452);
			Controls.Add(lblOrderIDDisplay);
			Controls.Add(lblOrderID);
			Controls.Add(lblTotalDisplay);
			Controls.Add(lblTotal);
			Controls.Add(dgvOrderItems);
			Controls.Add(panel);
			FormBorderStyle = FormBorderStyle.None;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			Name = "FormOrderSummary";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Order Summary";
			((System.ComponentModel.ISupportInitialize)dgvOrderItems).EndInit();
			panel.ResumeLayout(false);
			panel.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private DataGridView dgvOrderItems;
		private Label lblTotalDisplay;
		private Label lblTotal;
		private Label lblOrderID;
		private Label lblOrderIDDisplay;
		private Panel panel;
		private DataGridViewTextBoxColumn dgvOrderItemsColumnName;
		private DataGridViewTextBoxColumn dgvOrderItemsColumnPrice;
		private DataGridViewTextBoxColumn dgvOrderItemsColumnQuantity;
		private Button btnClose;
		private Label lblOrderSummary;
	}
}