namespace WarehouseManager {
	partial class FormOrders {
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
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrders));
			dgvOrders = new DataGridView();
			contextMenuOrderList = new ContextMenuStrip(components);
			showOrderSummaryToolStripMenuItem = new ToolStripMenuItem();
			pbCrossCloseForm = new PictureBox();
			pbReturn = new PictureBox();
			lblOrders = new Label();
			panel = new Panel();
			pbMinimize = new PictureBox();
			dgvOrdersColumnOrderID = new DataGridViewTextBoxColumn();
			dgvOrdersColumnTotal = new DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
			contextMenuOrderList.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbCrossCloseForm).BeginInit();
			((System.ComponentModel.ISupportInitialize)pbReturn).BeginInit();
			panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbMinimize).BeginInit();
			SuspendLayout();
			// 
			// dgvOrders
			// 
			dgvOrders.AllowUserToAddRows = false;
			dgvOrders.AllowUserToDeleteRows = false;
			dgvOrders.AllowUserToResizeColumns = false;
			dgvOrders.AllowUserToResizeRows = false;
			dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvOrders.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
			dgvOrders.BackgroundColor = Color.FromArgb(4, 41, 58);
			dgvOrders.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = Color.FromArgb(4, 41, 58);
			dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
			dataGridViewCellStyle1.ForeColor = Color.FromArgb(236, 179, 101);
			dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(4, 41, 58);
			dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(236, 179, 101);
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			dgvOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			dgvOrders.ColumnHeadersHeight = 35;
			dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dgvOrders.Columns.AddRange(new DataGridViewColumn[] { dgvOrdersColumnOrderID, dgvOrdersColumnTotal });
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = Color.FromArgb(4, 41, 58);
			dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
			dataGridViewCellStyle3.ForeColor = Color.FromArgb(236, 179, 101);
			dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(6, 70, 99);
			dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(236, 179, 101);
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
			dgvOrders.DefaultCellStyle = dataGridViewCellStyle3;
			dgvOrders.EnableHeadersVisualStyles = false;
			dgvOrders.GridColor = Color.FromArgb(4, 28, 50);
			dgvOrders.Location = new Point(12, 63);
			dgvOrders.Margin = new Padding(3, 2, 3, 2);
			dgvOrders.MultiSelect = false;
			dgvOrders.Name = "dgvOrders";
			dgvOrders.RowHeadersVisible = false;
			dgvOrders.RowHeadersWidth = 51;
			dgvOrders.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dgvOrders.RowTemplate.ContextMenuStrip = contextMenuOrderList;
			dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvOrders.ShowCellErrors = false;
			dgvOrders.ShowCellToolTips = false;
			dgvOrders.ShowEditingIcon = false;
			dgvOrders.ShowRowErrors = false;
			dgvOrders.Size = new Size(400, 313);
			dgvOrders.TabIndex = 3;
			dgvOrders.CellMouseDown += dgvOrders_CellMouseDown;
			// 
			// contextMenuOrderList
			// 
			contextMenuOrderList.Items.AddRange(new ToolStripItem[] { showOrderSummaryToolStripMenuItem });
			contextMenuOrderList.Name = "contextMenuOrderList";
			contextMenuOrderList.Size = new Size(191, 26);
			// 
			// showOrderSummaryToolStripMenuItem
			// 
			showOrderSummaryToolStripMenuItem.Name = "showOrderSummaryToolStripMenuItem";
			showOrderSummaryToolStripMenuItem.Size = new Size(190, 22);
			showOrderSummaryToolStripMenuItem.Text = "Show Order Summary";
			showOrderSummaryToolStripMenuItem.Click += showOrderSummaryToolStripMenuItem_Click;
			// 
			// pbCrossCloseForm
			// 
			pbCrossCloseForm.Cursor = Cursors.Hand;
			pbCrossCloseForm.Image = Properties.Resources.Cross_Color;
			pbCrossCloseForm.Location = new Point(390, 10);
			pbCrossCloseForm.Margin = new Padding(1);
			pbCrossCloseForm.Name = "pbCrossCloseForm";
			pbCrossCloseForm.Size = new Size(24, 24);
			pbCrossCloseForm.SizeMode = PictureBoxSizeMode.AutoSize;
			pbCrossCloseForm.TabIndex = 86;
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
			pbReturn.TabIndex = 87;
			pbReturn.TabStop = false;
			pbReturn.Click += pbReturn_Click;
			// 
			// lblOrders
			// 
			lblOrders.AutoSize = true;
			lblOrders.BackColor = Color.Transparent;
			lblOrders.FlatStyle = FlatStyle.Flat;
			lblOrders.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblOrders.ForeColor = Color.FromArgb(236, 179, 101);
			lblOrders.Location = new Point(38, 9);
			lblOrders.Name = "lblOrders";
			lblOrders.Size = new Size(72, 25);
			lblOrders.TabIndex = 88;
			lblOrders.Text = "Orders";
			lblOrders.TextAlign = ContentAlignment.MiddleCenter;
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
			panel.Size = new Size(424, 387);
			panel.TabIndex = 89;
			// 
			// pbMinimize
			// 
			pbMinimize.Cursor = Cursors.Hand;
			pbMinimize.Image = Properties.Resources.Minimize_Color;
			pbMinimize.Location = new Point(354, 9);
			pbMinimize.Margin = new Padding(1, 1, 10, 1);
			pbMinimize.Name = "pbMinimize";
			pbMinimize.Size = new Size(24, 24);
			pbMinimize.SizeMode = PictureBoxSizeMode.AutoSize;
			pbMinimize.TabIndex = 93;
			pbMinimize.TabStop = false;
			pbMinimize.Click += pbMinimize_Click;
			// 
			// dgvOrdersColumnOrderID
			// 
			dgvOrdersColumnOrderID.DataPropertyName = "ID";
			dgvOrdersColumnOrderID.FillWeight = 60F;
			dgvOrdersColumnOrderID.HeaderText = "Order ID";
			dgvOrdersColumnOrderID.Name = "dgvOrdersColumnOrderID";
			dgvOrdersColumnOrderID.ReadOnly = true;
			// 
			// dgvOrdersColumnTotal
			// 
			dgvOrdersColumnTotal.DataPropertyName = "Total";
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.Format = "C2";
			dataGridViewCellStyle2.NullValue = null;
			dgvOrdersColumnTotal.DefaultCellStyle = dataGridViewCellStyle2;
			dgvOrdersColumnTotal.FillWeight = 40F;
			dgvOrdersColumnTotal.HeaderText = "Total";
			dgvOrdersColumnTotal.Name = "dgvOrdersColumnTotal";
			dgvOrdersColumnTotal.ReadOnly = true;
			// 
			// FormOrders
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(4, 28, 50);
			ClientSize = new Size(424, 387);
			Controls.Add(lblOrders);
			Controls.Add(pbReturn);
			Controls.Add(pbCrossCloseForm);
			Controls.Add(dgvOrders);
			Controls.Add(panel);
			FormBorderStyle = FormBorderStyle.None;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "FormOrders";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "FormOrders";
			((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
			contextMenuOrderList.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pbCrossCloseForm).EndInit();
			((System.ComponentModel.ISupportInitialize)pbReturn).EndInit();
			panel.ResumeLayout(false);
			panel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pbMinimize).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dgvOrders;
		private PictureBox pbCrossCloseForm;
		private PictureBox pbReturn;
		private Label lblOrders;
		private ContextMenuStrip contextMenuOrderList;
		private ToolStripMenuItem showOrderSummaryToolStripMenuItem;
		private Panel panel;
		private PictureBox pbMinimize;
		private DataGridViewTextBoxColumn dgvOrdersColumnOrderID;
		private DataGridViewTextBoxColumn dgvOrdersColumnTotal;
	}
}