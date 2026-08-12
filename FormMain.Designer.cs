namespace WarehouseManager {
	partial class FormMain {
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
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			lblAddToCartStatus = new Label();
			label1 = new Label();
			tbxSearchBox = new TextBox();
			lblAddCategory = new Label();
			lblAddError = new Label();
			tbxSpecifications = new TextBox();
			cbProductToAdd = new ComboBox();
			btnAddProduct = new Button();
			lblSpecifications = new Label();
			rbtPSU = new RadioButton();
			rbtCaseFan = new RadioButton();
			rbtCase = new RadioButton();
			rbtHDD = new RadioButton();
			rbtNVMeSSD = new RadioButton();
			rbtSataSSD = new RadioButton();
			rbtStorageDevice = new RadioButton();
			rbtAIOCooler = new RadioButton();
			rbtAirCooler = new RadioButton();
			rbtCPUCooler = new RadioButton();
			rbtRAMKit = new RadioButton();
			rbtMotherboard = new RadioButton();
			rbtGraphicsCard = new RadioButton();
			rbtCPU = new RadioButton();
			rbtComponent = new RadioButton();
			rbtAll = new RadioButton();
			dgvProductList = new DataGridView();
			dgvProductListColumnName = new DataGridViewTextBoxColumn();
			dgvProductListColumnCategory = new DataGridViewTextBoxColumn();
			dgvProductListColumnManufacturer = new DataGridViewTextBoxColumn();
			dgvProductListColumnWeight = new DataGridViewTextBoxColumn();
			dgvProductListColumnStockQuantity = new DataGridViewTextBoxColumn();
			dgvProductListColumnPrice = new DataGridViewTextBoxColumn();
			contextMenuProductList = new ContextMenuStrip(components);
			removeToolStripMenuItem = new ToolStripMenuItem();
			modifyToolStripMenuItem = new ToolStripMenuItem();
			generalInfoToolStripMenuItem = new ToolStripMenuItem();
			specificationsToolStripMenuItem = new ToolStripMenuItem();
			benchmarkInfoToolStripMenuItem = new ToolStripMenuItem();
			addToCartToolStripMenuItem = new ToolStripMenuItem();
			pbCart = new PictureBox();
			pbOrders = new PictureBox();
			pbCrossCloseForm = new PictureBox();
			pbAccount = new PictureBox();
			panel = new Panel();
			rbtThermalPaste = new RadioButton();
			lblCartCountNotif = new Label();
			pbMinimize = new PictureBox();
			chbAlmostOutOfStock = new CheckBox();
			chbOutOfStock = new CheckBox();
			rbtThermalPad = new RadioButton();
			((System.ComponentModel.ISupportInitialize)dgvProductList).BeginInit();
			contextMenuProductList.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbCart).BeginInit();
			((System.ComponentModel.ISupportInitialize)pbOrders).BeginInit();
			((System.ComponentModel.ISupportInitialize)pbCrossCloseForm).BeginInit();
			((System.ComponentModel.ISupportInitialize)pbAccount).BeginInit();
			((System.ComponentModel.ISupportInitialize)pbMinimize).BeginInit();
			SuspendLayout();
			// 
			// lblAddToCartStatus
			// 
			lblAddToCartStatus.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblAddToCartStatus.ForeColor = Color.FromArgb(244, 43, 50);
			lblAddToCartStatus.Location = new Point(313, 201);
			lblAddToCartStatus.Name = "lblAddToCartStatus";
			lblAddToCartStatus.Size = new Size(332, 23);
			lblAddToCartStatus.TabIndex = 32;
			lblAddToCartStatus.TextAlign = ContentAlignment.TopCenter;
			lblAddToCartStatus.Leave += ErrorLabels_Leave;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.FromArgb(236, 179, 101);
			label1.Location = new Point(12, 181);
			label1.Name = "label1";
			label1.Size = new Size(48, 17);
			label1.TabIndex = 31;
			label1.Text = "Search";
			// 
			// tbxSearchBox
			// 
			tbxSearchBox.BackColor = Color.FromArgb(4, 41, 58);
			tbxSearchBox.BorderStyle = BorderStyle.FixedSingle;
			tbxSearchBox.ForeColor = Color.FromArgb(236, 179, 101);
			tbxSearchBox.Location = new Point(12, 201);
			tbxSearchBox.MaxLength = 32;
			tbxSearchBox.Name = "tbxSearchBox";
			tbxSearchBox.Size = new Size(236, 23);
			tbxSearchBox.TabIndex = 30;
			tbxSearchBox.TextChanged += tbxSearchBox_TextChanged;
			tbxSearchBox.KeyPress += tbxSearchBox_KeyPress;
			// 
			// lblAddCategory
			// 
			lblAddCategory.AutoSize = true;
			lblAddCategory.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblAddCategory.ForeColor = Color.FromArgb(236, 179, 101);
			lblAddCategory.Location = new Point(839, 50);
			lblAddCategory.Name = "lblAddCategory";
			lblAddCategory.Size = new Size(64, 17);
			lblAddCategory.TabIndex = 29;
			lblAddCategory.Text = "Category";
			// 
			// lblAddError
			// 
			lblAddError.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblAddError.ForeColor = Color.FromArgb(244, 43, 50);
			lblAddError.Location = new Point(839, 108);
			lblAddError.Name = "lblAddError";
			lblAddError.Size = new Size(221, 45);
			lblAddError.TabIndex = 28;
			lblAddError.Leave += ErrorLabels_Leave;
			// 
			// tbxSpecifications
			// 
			tbxSpecifications.BackColor = Color.FromArgb(4, 41, 58);
			tbxSpecifications.BorderStyle = BorderStyle.FixedSingle;
			tbxSpecifications.ForeColor = Color.FromArgb(236, 179, 101);
			tbxSpecifications.Location = new Point(823, 229);
			tbxSpecifications.Multiline = true;
			tbxSpecifications.Name = "tbxSpecifications";
			tbxSpecifications.ReadOnly = true;
			tbxSpecifications.ScrollBars = ScrollBars.Vertical;
			tbxSpecifications.Size = new Size(261, 313);
			tbxSpecifications.TabIndex = 27;
			// 
			// cbProductToAdd
			// 
			cbProductToAdd.BackColor = Color.FromArgb(4, 41, 58);
			cbProductToAdd.DropDownStyle = ComboBoxStyle.DropDownList;
			cbProductToAdd.ForeColor = Color.FromArgb(236, 179, 101);
			cbProductToAdd.FormattingEnabled = true;
			cbProductToAdd.Items.AddRange(new object[] { "Motherboard", "CPU", "Graphics Card", "RAM Kit", "NVMe SSD", "Sata SSD", "HDD", "AIO Cooler", "Air Cooler", "Case", "Case Fan", "PSU", "Thermal Pad", "Thermal Paste" });
			cbProductToAdd.Location = new Point(839, 73);
			cbProductToAdd.Margin = new Padding(3, 2, 3, 2);
			cbProductToAdd.MaxDropDownItems = 14;
			cbProductToAdd.Name = "cbProductToAdd";
			cbProductToAdd.Size = new Size(133, 23);
			cbProductToAdd.TabIndex = 26;
			// 
			// btnAddProduct
			// 
			btnAddProduct.BackColor = Color.FromArgb(4, 41, 58);
			btnAddProduct.FlatStyle = FlatStyle.Flat;
			btnAddProduct.ForeColor = Color.FromArgb(236, 179, 101);
			btnAddProduct.Location = new Point(978, 73);
			btnAddProduct.Margin = new Padding(3, 2, 3, 2);
			btnAddProduct.Name = "btnAddProduct";
			btnAddProduct.Size = new Size(82, 23);
			btnAddProduct.TabIndex = 25;
			btnAddProduct.Text = "Add";
			btnAddProduct.UseVisualStyleBackColor = false;
			btnAddProduct.Click += btnAddProduct_Click;
			// 
			// lblSpecifications
			// 
			lblSpecifications.AutoSize = true;
			lblSpecifications.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblSpecifications.ForeColor = Color.FromArgb(236, 179, 101);
			lblSpecifications.Location = new Point(898, 206);
			lblSpecifications.Name = "lblSpecifications";
			lblSpecifications.Size = new Size(105, 20);
			lblSpecifications.TabIndex = 21;
			lblSpecifications.Text = "Specifications";
			// 
			// rbtPSU
			// 
			rbtPSU.Appearance = Appearance.Button;
			rbtPSU.BackColor = Color.FromArgb(4, 41, 58);
			rbtPSU.FlatAppearance.CheckedBackColor = Color.FromArgb(6, 70, 99);
			rbtPSU.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 41, 58);
			rbtPSU.FlatAppearance.MouseOverBackColor = Color.FromArgb(6, 70, 99);
			rbtPSU.FlatStyle = FlatStyle.Flat;
			rbtPSU.ForeColor = Color.FromArgb(236, 179, 101);
			rbtPSU.Location = new Point(198, 104);
			rbtPSU.Margin = new Padding(3, 2, 3, 2);
			rbtPSU.Name = "rbtPSU";
			rbtPSU.Size = new Size(95, 27);
			rbtPSU.TabIndex = 18;
			rbtPSU.TabStop = true;
			rbtPSU.Text = "PSU";
			rbtPSU.TextAlign = ContentAlignment.MiddleCenter;
			rbtPSU.UseVisualStyleBackColor = false;
			rbtPSU.CheckedChanged += rbtAll_CheckedChanged;
			// 
			// rbtCaseFan
			// 
			rbtCaseFan.Appearance = Appearance.Button;
			rbtCaseFan.BackColor = Color.FromArgb(4, 41, 58);
			rbtCaseFan.FlatAppearance.CheckedBackColor = Color.FromArgb(6, 70, 99);
			rbtCaseFan.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 41, 58);
			rbtCaseFan.FlatAppearance.MouseOverBackColor = Color.FromArgb(6, 70, 99);
			rbtCaseFan.FlatStyle = FlatStyle.Flat;
			rbtCaseFan.ForeColor = Color.FromArgb(236, 179, 101);
			rbtCaseFan.Location = new Point(198, 73);
			rbtCaseFan.Margin = new Padding(3, 2, 3, 2);
			rbtCaseFan.Name = "rbtCaseFan";
			rbtCaseFan.Size = new Size(95, 27);
			rbtCaseFan.TabIndex = 17;
			rbtCaseFan.TabStop = true;
			rbtCaseFan.Text = "Case Fan";
			rbtCaseFan.TextAlign = ContentAlignment.MiddleCenter;
			rbtCaseFan.UseVisualStyleBackColor = false;
			rbtCaseFan.CheckedChanged += rbtAll_CheckedChanged;
			// 
			// rbtCase
			// 
			rbtCase.Appearance = Appearance.Button;
			rbtCase.BackColor = Color.FromArgb(4, 41, 58);
			rbtCase.FlatAppearance.CheckedBackColor = Color.FromArgb(6, 70, 99);
			rbtCase.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 41, 58);
			rbtCase.FlatAppearance.MouseOverBackColor = Color.FromArgb(6, 70, 99);
			rbtCase.FlatStyle = FlatStyle.Flat;
			rbtCase.ForeColor = Color.FromArgb(236, 179, 101);
			rbtCase.Location = new Point(198, 42);
			rbtCase.Margin = new Padding(3, 2, 3, 2);
			rbtCase.Name = "rbtCase";
			rbtCase.Size = new Size(95, 27);
			rbtCase.TabIndex = 16;
			rbtCase.TabStop = true;
			rbtCase.Text = "Case";
			rbtCase.TextAlign = ContentAlignment.MiddleCenter;
			rbtCase.UseVisualStyleBackColor = false;
			rbtCase.CheckedChanged += rbtAll_CheckedChanged;
			// 
			// rbtHDD
			// 
			rbtHDD.Appearance = Appearance.Button;
			rbtHDD.BackColor = Color.FromArgb(4, 41, 58);
			rbtHDD.FlatAppearance.CheckedBackColor = Color.FromArgb(6, 70, 99);
			rbtHDD.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 41, 58);
			rbtHDD.FlatAppearance.MouseOverBackColor = Color.FromArgb(6, 70, 99);
			rbtHDD.FlatStyle = FlatStyle.Flat;
			rbtHDD.ForeColor = Color.FromArgb(236, 179, 101);
			rbtHDD.Location = new Point(299, 104);
			rbtHDD.Margin = new Padding(3, 2, 3, 2);
			rbtHDD.Name = "rbtHDD";
			rbtHDD.Size = new Size(95, 27);
			rbtHDD.TabIndex = 15;
			rbtHDD.TabStop = true;
			rbtHDD.Text = "HDD";
			rbtHDD.TextAlign = ContentAlignment.MiddleCenter;
			rbtHDD.UseVisualStyleBackColor = false;
			rbtHDD.CheckedChanged += rbtAll_CheckedChanged;
			// 
			// rbtNVMeSSD
			// 
			rbtNVMeSSD.Appearance = Appearance.Button;
			rbtNVMeSSD.BackColor = Color.FromArgb(4, 41, 58);
			rbtNVMeSSD.FlatAppearance.CheckedBackColor = Color.FromArgb(6, 70, 99);
			rbtNVMeSSD.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 41, 58);
			rbtNVMeSSD.FlatAppearance.MouseOverBackColor = Color.FromArgb(6, 70, 99);
			rbtNVMeSSD.FlatStyle = FlatStyle.Flat;
			rbtNVMeSSD.ForeColor = Color.FromArgb(236, 179, 101);
			rbtNVMeSSD.Location = new Point(299, 42);
			rbtNVMeSSD.Margin = new Padding(3, 2, 3, 2);
			rbtNVMeSSD.Name = "rbtNVMeSSD";
			rbtNVMeSSD.Size = new Size(95, 27);
			rbtNVMeSSD.TabIndex = 14;
			rbtNVMeSSD.TabStop = true;
			rbtNVMeSSD.Text = "NVMe SSD";
			rbtNVMeSSD.TextAlign = ContentAlignment.MiddleCenter;
			rbtNVMeSSD.UseVisualStyleBackColor = false;
			rbtNVMeSSD.CheckedChanged += rbtAll_CheckedChanged;
			// 
			// rbtSataSSD
			// 
			rbtSataSSD.Appearance = Appearance.Button;
			rbtSataSSD.BackColor = Color.FromArgb(4, 41, 58);
			rbtSataSSD.FlatAppearance.CheckedBackColor = Color.FromArgb(6, 70, 99);
			rbtSataSSD.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 41, 58);
			rbtSataSSD.FlatAppearance.MouseOverBackColor = Color.FromArgb(6, 70, 99);
			rbtSataSSD.FlatStyle = FlatStyle.Flat;
			rbtSataSSD.ForeColor = Color.FromArgb(236, 179, 101);
			rbtSataSSD.Location = new Point(299, 73);
			rbtSataSSD.Margin = new Padding(3, 2, 3, 2);
			rbtSataSSD.Name = "rbtSataSSD";
			rbtSataSSD.Size = new Size(95, 27);
			rbtSataSSD.TabIndex = 13;
			rbtSataSSD.TabStop = true;
			rbtSataSSD.Text = "Sata SSD";
			rbtSataSSD.TextAlign = ContentAlignment.MiddleCenter;
			rbtSataSSD.UseVisualStyleBackColor = false;
			rbtSataSSD.CheckedChanged += rbtAll_CheckedChanged;
			// 
			// rbtStorageDevice
			// 
			rbtStorageDevice.Appearance = Appearance.Button;
			rbtStorageDevice.BackColor = Color.FromArgb(4, 41, 58);
			rbtStorageDevice.FlatAppearance.CheckedBackColor = Color.FromArgb(6, 70, 99);
			rbtStorageDevice.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 41, 58);
			rbtStorageDevice.FlatAppearance.MouseOverBackColor = Color.FromArgb(6, 70, 99);
			rbtStorageDevice.FlatStyle = FlatStyle.Flat;
			rbtStorageDevice.ForeColor = Color.FromArgb(236, 179, 101);
			rbtStorageDevice.Location = new Point(299, 11);
			rbtStorageDevice.Margin = new Padding(3, 2, 3, 2);
			rbtStorageDevice.Name = "rbtStorageDevice";
			rbtStorageDevice.Size = new Size(95, 27);
			rbtStorageDevice.TabIndex = 12;
			rbtStorageDevice.TabStop = true;
			rbtStorageDevice.Text = "Storage Device";
			rbtStorageDevice.TextAlign = ContentAlignment.MiddleCenter;
			rbtStorageDevice.UseVisualStyleBackColor = false;
			rbtStorageDevice.CheckedChanged += rbtAll_CheckedChanged;
			// 
			// rbtAIOCooler
			// 
			rbtAIOCooler.Appearance = Appearance.Button;
			rbtAIOCooler.BackColor = Color.FromArgb(4, 41, 58);
			rbtAIOCooler.FlatAppearance.CheckedBackColor = Color.FromArgb(6, 70, 99);
			rbtAIOCooler.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 41, 58);
			rbtAIOCooler.FlatAppearance.MouseOverBackColor = Color.FromArgb(6, 70, 99);
			rbtAIOCooler.FlatStyle = FlatStyle.Flat;
			rbtAIOCooler.ForeColor = Color.FromArgb(236, 179, 101);
			rbtAIOCooler.Location = new Point(400, 73);
			rbtAIOCooler.Margin = new Padding(3, 2, 3, 2);
			rbtAIOCooler.Name = "rbtAIOCooler";
			rbtAIOCooler.Size = new Size(95, 27);
			rbtAIOCooler.TabIndex = 11;
			rbtAIOCooler.TabStop = true;
			rbtAIOCooler.Text = "AIO Cooler";
			rbtAIOCooler.TextAlign = ContentAlignment.MiddleCenter;
			rbtAIOCooler.UseVisualStyleBackColor = false;
			rbtAIOCooler.CheckedChanged += rbtAll_CheckedChanged;
			// 
			// rbtAirCooler
			// 
			rbtAirCooler.Appearance = Appearance.Button;
			rbtAirCooler.BackColor = Color.FromArgb(4, 41, 58);
			rbtAirCooler.FlatAppearance.CheckedBackColor = Color.FromArgb(6, 70, 99);
			rbtAirCooler.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 41, 58);
			rbtAirCooler.FlatAppearance.MouseOverBackColor = Color.FromArgb(6, 70, 99);
			rbtAirCooler.FlatStyle = FlatStyle.Flat;
			rbtAirCooler.ForeColor = Color.FromArgb(236, 179, 101);
			rbtAirCooler.Location = new Point(400, 42);
			rbtAirCooler.Margin = new Padding(3, 2, 3, 2);
			rbtAirCooler.Name = "rbtAirCooler";
			rbtAirCooler.Size = new Size(95, 27);
			rbtAirCooler.TabIndex = 10;
			rbtAirCooler.TabStop = true;
			rbtAirCooler.Text = "Air Cooler";
			rbtAirCooler.TextAlign = ContentAlignment.MiddleCenter;
			rbtAirCooler.UseVisualStyleBackColor = false;
			rbtAirCooler.CheckedChanged += rbtAll_CheckedChanged;
			// 
			// rbtCPUCooler
			// 
			rbtCPUCooler.Appearance = Appearance.Button;
			rbtCPUCooler.BackColor = Color.FromArgb(4, 41, 58);
			rbtCPUCooler.FlatAppearance.CheckedBackColor = Color.FromArgb(6, 70, 99);
			rbtCPUCooler.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 41, 58);
			rbtCPUCooler.FlatAppearance.MouseOverBackColor = Color.FromArgb(6, 70, 99);
			rbtCPUCooler.FlatStyle = FlatStyle.Flat;
			rbtCPUCooler.ForeColor = Color.FromArgb(236, 179, 101);
			rbtCPUCooler.Location = new Point(400, 11);
			rbtCPUCooler.Margin = new Padding(3, 2, 3, 2);
			rbtCPUCooler.Name = "rbtCPUCooler";
			rbtCPUCooler.Size = new Size(95, 27);
			rbtCPUCooler.TabIndex = 9;
			rbtCPUCooler.TabStop = true;
			rbtCPUCooler.Text = "CPU Cooler";
			rbtCPUCooler.TextAlign = ContentAlignment.MiddleCenter;
			rbtCPUCooler.UseVisualStyleBackColor = false;
			rbtCPUCooler.CheckedChanged += rbtAll_CheckedChanged;
			// 
			// rbtRAMKit
			// 
			rbtRAMKit.Appearance = Appearance.Button;
			rbtRAMKit.BackColor = Color.FromArgb(4, 41, 58);
			rbtRAMKit.FlatAppearance.CheckedBackColor = Color.FromArgb(6, 70, 99);
			rbtRAMKit.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 41, 58);
			rbtRAMKit.FlatAppearance.MouseOverBackColor = Color.FromArgb(6, 70, 99);
			rbtRAMKit.FlatStyle = FlatStyle.Flat;
			rbtRAMKit.ForeColor = Color.FromArgb(236, 179, 101);
			rbtRAMKit.Location = new Point(198, 11);
			rbtRAMKit.Margin = new Padding(3, 2, 3, 2);
			rbtRAMKit.Name = "rbtRAMKit";
			rbtRAMKit.Size = new Size(95, 27);
			rbtRAMKit.TabIndex = 8;
			rbtRAMKit.TabStop = true;
			rbtRAMKit.Text = "RAM Kit";
			rbtRAMKit.TextAlign = ContentAlignment.MiddleCenter;
			rbtRAMKit.UseVisualStyleBackColor = false;
			rbtRAMKit.CheckedChanged += rbtAll_CheckedChanged;
			// 
			// rbtMotherboard
			// 
			rbtMotherboard.Appearance = Appearance.Button;
			rbtMotherboard.BackColor = Color.FromArgb(4, 41, 58);
			rbtMotherboard.FlatAppearance.CheckedBackColor = Color.FromArgb(6, 70, 99);
			rbtMotherboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 41, 58);
			rbtMotherboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(6, 70, 99);
			rbtMotherboard.FlatStyle = FlatStyle.Flat;
			rbtMotherboard.ForeColor = Color.FromArgb(236, 179, 101);
			rbtMotherboard.Location = new Point(97, 104);
			rbtMotherboard.Margin = new Padding(3, 2, 3, 2);
			rbtMotherboard.Name = "rbtMotherboard";
			rbtMotherboard.Size = new Size(95, 27);
			rbtMotherboard.TabIndex = 7;
			rbtMotherboard.TabStop = true;
			rbtMotherboard.Text = "Motherboard";
			rbtMotherboard.TextAlign = ContentAlignment.MiddleCenter;
			rbtMotherboard.UseVisualStyleBackColor = false;
			rbtMotherboard.CheckedChanged += rbtAll_CheckedChanged;
			// 
			// rbtGraphicsCard
			// 
			rbtGraphicsCard.Appearance = Appearance.Button;
			rbtGraphicsCard.BackColor = Color.FromArgb(4, 41, 58);
			rbtGraphicsCard.FlatAppearance.CheckedBackColor = Color.FromArgb(6, 70, 99);
			rbtGraphicsCard.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 41, 58);
			rbtGraphicsCard.FlatAppearance.MouseOverBackColor = Color.FromArgb(6, 70, 99);
			rbtGraphicsCard.FlatStyle = FlatStyle.Flat;
			rbtGraphicsCard.ForeColor = Color.FromArgb(236, 179, 101);
			rbtGraphicsCard.Location = new Point(97, 135);
			rbtGraphicsCard.Margin = new Padding(3, 2, 3, 2);
			rbtGraphicsCard.Name = "rbtGraphicsCard";
			rbtGraphicsCard.Size = new Size(95, 27);
			rbtGraphicsCard.TabIndex = 6;
			rbtGraphicsCard.TabStop = true;
			rbtGraphicsCard.Text = "Graphics Card";
			rbtGraphicsCard.TextAlign = ContentAlignment.MiddleCenter;
			rbtGraphicsCard.UseVisualStyleBackColor = false;
			rbtGraphicsCard.CheckedChanged += rbtAll_CheckedChanged;
			// 
			// rbtCPU
			// 
			rbtCPU.Appearance = Appearance.Button;
			rbtCPU.BackColor = Color.FromArgb(4, 41, 58);
			rbtCPU.FlatAppearance.CheckedBackColor = Color.FromArgb(6, 70, 99);
			rbtCPU.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 41, 58);
			rbtCPU.FlatAppearance.MouseOverBackColor = Color.FromArgb(6, 70, 99);
			rbtCPU.FlatStyle = FlatStyle.Flat;
			rbtCPU.ForeColor = Color.FromArgb(236, 179, 101);
			rbtCPU.Location = new Point(97, 73);
			rbtCPU.Margin = new Padding(3, 2, 3, 2);
			rbtCPU.Name = "rbtCPU";
			rbtCPU.Size = new Size(95, 27);
			rbtCPU.TabIndex = 5;
			rbtCPU.TabStop = true;
			rbtCPU.Text = "CPU";
			rbtCPU.TextAlign = ContentAlignment.MiddleCenter;
			rbtCPU.UseVisualStyleBackColor = false;
			rbtCPU.CheckedChanged += rbtAll_CheckedChanged;
			// 
			// rbtComponent
			// 
			rbtComponent.Appearance = Appearance.Button;
			rbtComponent.BackColor = Color.FromArgb(4, 41, 58);
			rbtComponent.FlatAppearance.CheckedBackColor = Color.FromArgb(6, 70, 99);
			rbtComponent.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 41, 58);
			rbtComponent.FlatAppearance.MouseOverBackColor = Color.FromArgb(6, 70, 99);
			rbtComponent.FlatStyle = FlatStyle.Flat;
			rbtComponent.ForeColor = Color.FromArgb(236, 179, 101);
			rbtComponent.Location = new Point(97, 42);
			rbtComponent.Margin = new Padding(3, 2, 3, 2);
			rbtComponent.Name = "rbtComponent";
			rbtComponent.Size = new Size(95, 27);
			rbtComponent.TabIndex = 2;
			rbtComponent.TabStop = true;
			rbtComponent.Text = "Component";
			rbtComponent.TextAlign = ContentAlignment.MiddleCenter;
			rbtComponent.UseVisualStyleBackColor = false;
			rbtComponent.CheckedChanged += rbtAll_CheckedChanged;
			// 
			// rbtAll
			// 
			rbtAll.Appearance = Appearance.Button;
			rbtAll.BackColor = Color.FromArgb(4, 41, 58);
			rbtAll.FlatAppearance.CheckedBackColor = Color.FromArgb(6, 70, 99);
			rbtAll.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 41, 58);
			rbtAll.FlatAppearance.MouseOverBackColor = Color.FromArgb(6, 70, 99);
			rbtAll.FlatStyle = FlatStyle.Flat;
			rbtAll.ForeColor = Color.FromArgb(236, 179, 101);
			rbtAll.Location = new Point(97, 11);
			rbtAll.Margin = new Padding(3, 2, 3, 2);
			rbtAll.Name = "rbtAll";
			rbtAll.Size = new Size(95, 27);
			rbtAll.TabIndex = 1;
			rbtAll.TabStop = true;
			rbtAll.Text = "All";
			rbtAll.TextAlign = ContentAlignment.MiddleCenter;
			rbtAll.UseVisualStyleBackColor = false;
			rbtAll.CheckedChanged += rbtAll_CheckedChanged;
			// 
			// dgvProductList
			// 
			dgvProductList.AllowUserToAddRows = false;
			dgvProductList.AllowUserToDeleteRows = false;
			dgvProductList.AllowUserToResizeColumns = false;
			dgvProductList.AllowUserToResizeRows = false;
			dgvProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvProductList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
			dgvProductList.BackgroundColor = Color.FromArgb(4, 41, 58);
			dgvProductList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = Color.FromArgb(4, 41, 58);
			dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			dataGridViewCellStyle1.ForeColor = Color.FromArgb(236, 179, 101);
			dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(4, 41, 58);
			dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(236, 179, 101);
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			dgvProductList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			dgvProductList.ColumnHeadersHeight = 35;
			dgvProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dgvProductList.Columns.AddRange(new DataGridViewColumn[] { dgvProductListColumnName, dgvProductListColumnCategory, dgvProductListColumnManufacturer, dgvProductListColumnWeight, dgvProductListColumnStockQuantity, dgvProductListColumnPrice });
			dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = Color.FromArgb(4, 41, 58);
			dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
			dataGridViewCellStyle5.ForeColor = Color.FromArgb(236, 179, 101);
			dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(6, 70, 99);
			dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(236, 179, 101);
			dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
			dgvProductList.DefaultCellStyle = dataGridViewCellStyle5;
			dgvProductList.EnableHeadersVisualStyles = false;
			dgvProductList.GridColor = Color.FromArgb(4, 28, 50);
			dgvProductList.Location = new Point(12, 229);
			dgvProductList.Margin = new Padding(3, 2, 3, 2);
			dgvProductList.MultiSelect = false;
			dgvProductList.Name = "dgvProductList";
			dgvProductList.RowHeadersVisible = false;
			dgvProductList.RowHeadersWidth = 51;
			dgvProductList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dgvProductList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvProductList.ShowCellErrors = false;
			dgvProductList.ShowCellToolTips = false;
			dgvProductList.ShowEditingIcon = false;
			dgvProductList.ShowRowErrors = false;
			dgvProductList.Size = new Size(805, 313);
			dgvProductList.TabIndex = 0;
			dgvProductList.CellMouseDown += dgvProductList_CellMouseDown;
			dgvProductList.SelectionChanged += dgvProductList_SelectionChanged;
			// 
			// dgvProductListColumnName
			// 
			dgvProductListColumnName.DataPropertyName = "Name";
			dgvProductListColumnName.FillWeight = 30F;
			dgvProductListColumnName.HeaderText = "Name";
			dgvProductListColumnName.Name = "dgvProductListColumnName";
			dgvProductListColumnName.ReadOnly = true;
			// 
			// dgvProductListColumnCategory
			// 
			dgvProductListColumnCategory.DataPropertyName = "Category";
			dgvProductListColumnCategory.FillWeight = 10F;
			dgvProductListColumnCategory.HeaderText = "Category";
			dgvProductListColumnCategory.Name = "dgvProductListColumnCategory";
			dgvProductListColumnCategory.ReadOnly = true;
			// 
			// dgvProductListColumnManufacturer
			// 
			dgvProductListColumnManufacturer.DataPropertyName = "Manufacturer";
			dgvProductListColumnManufacturer.FillWeight = 14F;
			dgvProductListColumnManufacturer.HeaderText = "Manufacturer";
			dgvProductListColumnManufacturer.Name = "dgvProductListColumnManufacturer";
			dgvProductListColumnManufacturer.ReadOnly = true;
			// 
			// dgvProductListColumnWeight
			// 
			dgvProductListColumnWeight.DataPropertyName = "WeightKg";
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.Format = "0.00 Kg";
			dataGridViewCellStyle2.NullValue = null;
			dgvProductListColumnWeight.DefaultCellStyle = dataGridViewCellStyle2;
			dgvProductListColumnWeight.FillWeight = 10F;
			dgvProductListColumnWeight.HeaderText = "Weight";
			dgvProductListColumnWeight.Name = "dgvProductListColumnWeight";
			dgvProductListColumnWeight.ReadOnly = true;
			// 
			// dgvProductListColumnStockQuantity
			// 
			dgvProductListColumnStockQuantity.DataPropertyName = "StockQuantity";
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dgvProductListColumnStockQuantity.DefaultCellStyle = dataGridViewCellStyle3;
			dgvProductListColumnStockQuantity.FillWeight = 15F;
			dgvProductListColumnStockQuantity.HeaderText = "Stock Quantity";
			dgvProductListColumnStockQuantity.Name = "dgvProductListColumnStockQuantity";
			dgvProductListColumnStockQuantity.ReadOnly = true;
			// 
			// dgvProductListColumnPrice
			// 
			dgvProductListColumnPrice.DataPropertyName = "Price";
			dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.Format = "C2";
			dataGridViewCellStyle4.NullValue = null;
			dgvProductListColumnPrice.DefaultCellStyle = dataGridViewCellStyle4;
			dgvProductListColumnPrice.FillWeight = 11F;
			dgvProductListColumnPrice.HeaderText = "Price";
			dgvProductListColumnPrice.Name = "dgvProductListColumnPrice";
			dgvProductListColumnPrice.ReadOnly = true;
			// 
			// contextMenuProductList
			// 
			contextMenuProductList.Items.AddRange(new ToolStripItem[] { removeToolStripMenuItem, modifyToolStripMenuItem, addToCartToolStripMenuItem });
			contextMenuProductList.Name = "contextMenuStrip1";
			contextMenuProductList.Size = new Size(181, 92);
			// 
			// removeToolStripMenuItem
			// 
			removeToolStripMenuItem.Name = "removeToolStripMenuItem";
			removeToolStripMenuItem.Size = new Size(180, 22);
			removeToolStripMenuItem.Text = "Remove";
			removeToolStripMenuItem.Click += removeToolStripMenuItem_Click;
			// 
			// modifyToolStripMenuItem
			// 
			modifyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { generalInfoToolStripMenuItem, specificationsToolStripMenuItem, benchmarkInfoToolStripMenuItem });
			modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
			modifyToolStripMenuItem.Size = new Size(180, 22);
			modifyToolStripMenuItem.Text = "Modify";
			// 
			// generalInfoToolStripMenuItem
			// 
			generalInfoToolStripMenuItem.Name = "generalInfoToolStripMenuItem";
			generalInfoToolStripMenuItem.Size = new Size(180, 22);
			generalInfoToolStripMenuItem.Text = "General Info";
			generalInfoToolStripMenuItem.Click += generalInfoToolStripMenuItem_Click;
			// 
			// specificationsToolStripMenuItem
			// 
			specificationsToolStripMenuItem.Name = "specificationsToolStripMenuItem";
			specificationsToolStripMenuItem.Size = new Size(180, 22);
			specificationsToolStripMenuItem.Text = "Specifications";
			specificationsToolStripMenuItem.Click += specificationsToolStripMenuItem_Click;
			// 
			// benchmarkInfoToolStripMenuItem
			// 
			benchmarkInfoToolStripMenuItem.Name = "benchmarkInfoToolStripMenuItem";
			benchmarkInfoToolStripMenuItem.Size = new Size(180, 22);
			benchmarkInfoToolStripMenuItem.Text = "Benchmark Info";
			benchmarkInfoToolStripMenuItem.Click += benchmarkInfoToolStripMenuItem_Click;
			// 
			// addToCartToolStripMenuItem
			// 
			addToCartToolStripMenuItem.Name = "addToCartToolStripMenuItem";
			addToCartToolStripMenuItem.Size = new Size(180, 22);
			addToCartToolStripMenuItem.Text = "Add To Cart";
			addToCartToolStripMenuItem.Click += addToCartToolStripMenuItem_Click;
			// 
			// pbCart
			// 
			pbCart.Cursor = Cursors.Hand;
			pbCart.Image = Properties.Resources.Cart_Color;
			pbCart.Location = new Point(12, 84);
			pbCart.Name = "pbCart";
			pbCart.Size = new Size(30, 30);
			pbCart.SizeMode = PictureBoxSizeMode.AutoSize;
			pbCart.TabIndex = 84;
			pbCart.TabStop = false;
			pbCart.Click += pbCart_Click;
			// 
			// pbOrders
			// 
			pbOrders.Cursor = Cursors.Hand;
			pbOrders.Image = Properties.Resources.Orders_Color;
			pbOrders.Location = new Point(12, 48);
			pbOrders.Name = "pbOrders";
			pbOrders.Size = new Size(30, 30);
			pbOrders.SizeMode = PictureBoxSizeMode.AutoSize;
			pbOrders.TabIndex = 85;
			pbOrders.TabStop = false;
			pbOrders.Click += pbOrders_Click;
			// 
			// pbCrossCloseForm
			// 
			pbCrossCloseForm.Cursor = Cursors.Hand;
			pbCrossCloseForm.Image = Properties.Resources.Cross_Color;
			pbCrossCloseForm.Location = new Point(1061, 10);
			pbCrossCloseForm.Margin = new Padding(1);
			pbCrossCloseForm.Name = "pbCrossCloseForm";
			pbCrossCloseForm.Size = new Size(24, 24);
			pbCrossCloseForm.SizeMode = PictureBoxSizeMode.AutoSize;
			pbCrossCloseForm.TabIndex = 88;
			pbCrossCloseForm.TabStop = false;
			pbCrossCloseForm.Click += pbCrossCloseForm_Click;
			// 
			// pbAccount
			// 
			pbAccount.Cursor = Cursors.Hand;
			pbAccount.Image = Properties.Resources.Account_Color;
			pbAccount.Location = new Point(12, 12);
			pbAccount.Name = "pbAccount";
			pbAccount.Size = new Size(30, 30);
			pbAccount.SizeMode = PictureBoxSizeMode.AutoSize;
			pbAccount.TabIndex = 89;
			pbAccount.TabStop = false;
			pbAccount.Click += pbAccount_Click;
			// 
			// panel
			// 
			panel.BackColor = Color.Transparent;
			panel.BorderStyle = BorderStyle.FixedSingle;
			panel.Dock = DockStyle.Fill;
			panel.Location = new Point(0, 0);
			panel.Name = "panel";
			panel.Padding = new Padding(1);
			panel.Size = new Size(1095, 553);
			panel.TabIndex = 90;
			// 
			// rbtThermalPaste
			// 
			rbtThermalPaste.Appearance = Appearance.Button;
			rbtThermalPaste.BackColor = Color.FromArgb(4, 41, 58);
			rbtThermalPaste.FlatAppearance.CheckedBackColor = Color.FromArgb(6, 70, 99);
			rbtThermalPaste.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 41, 58);
			rbtThermalPaste.FlatAppearance.MouseOverBackColor = Color.FromArgb(6, 70, 99);
			rbtThermalPaste.FlatStyle = FlatStyle.Flat;
			rbtThermalPaste.ForeColor = Color.FromArgb(236, 179, 101);
			rbtThermalPaste.Location = new Point(500, 41);
			rbtThermalPaste.Margin = new Padding(3, 2, 3, 2);
			rbtThermalPaste.Name = "rbtThermalPaste";
			rbtThermalPaste.Size = new Size(95, 27);
			rbtThermalPaste.TabIndex = 94;
			rbtThermalPaste.TabStop = true;
			rbtThermalPaste.Text = "Thermal Paste";
			rbtThermalPaste.TextAlign = ContentAlignment.MiddleCenter;
			rbtThermalPaste.UseVisualStyleBackColor = false;
			rbtThermalPaste.CheckedChanged += rbtAll_CheckedChanged;
			// 
			// lblCartCountNotif
			// 
			lblCartCountNotif.AutoSize = true;
			lblCartCountNotif.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblCartCountNotif.ForeColor = Color.FromArgb(46, 184, 126);
			lblCartCountNotif.Location = new Point(41, 78);
			lblCartCountNotif.Name = "lblCartCountNotif";
			lblCartCountNotif.Size = new Size(0, 17);
			lblCartCountNotif.TabIndex = 98;
			// 
			// pbMinimize
			// 
			pbMinimize.Cursor = Cursors.Hand;
			pbMinimize.Image = Properties.Resources.Minimize_Color;
			pbMinimize.Location = new Point(1025, 9);
			pbMinimize.Margin = new Padding(1, 1, 10, 1);
			pbMinimize.Name = "pbMinimize";
			pbMinimize.Size = new Size(24, 24);
			pbMinimize.SizeMode = PictureBoxSizeMode.AutoSize;
			pbMinimize.TabIndex = 97;
			pbMinimize.TabStop = false;
			pbMinimize.Click += pbMinimize_Click;
			// 
			// chbAlmostOutOfStock
			// 
			chbAlmostOutOfStock.AutoSize = true;
			chbAlmostOutOfStock.ForeColor = Color.FromArgb(236, 179, 101);
			chbAlmostOutOfStock.Location = new Point(681, 200);
			chbAlmostOutOfStock.Margin = new Padding(3, 2, 3, 2);
			chbAlmostOutOfStock.Name = "chbAlmostOutOfStock";
			chbAlmostOutOfStock.Size = new Size(135, 19);
			chbAlmostOutOfStock.TabIndex = 96;
			chbAlmostOutOfStock.Text = "Almost Out Of Stock";
			chbAlmostOutOfStock.TextAlign = ContentAlignment.MiddleCenter;
			chbAlmostOutOfStock.UseVisualStyleBackColor = false;
			chbAlmostOutOfStock.CheckedChanged += chbAlmostOutOfStock_CheckedChanged;
			// 
			// chbOutOfStock
			// 
			chbOutOfStock.AutoSize = true;
			chbOutOfStock.ForeColor = Color.FromArgb(236, 179, 101);
			chbOutOfStock.Location = new Point(681, 171);
			chbOutOfStock.Margin = new Padding(3, 2, 3, 2);
			chbOutOfStock.Name = "chbOutOfStock";
			chbOutOfStock.Size = new Size(94, 19);
			chbOutOfStock.TabIndex = 95;
			chbOutOfStock.Text = "Out Of Stock";
			chbOutOfStock.TextAlign = ContentAlignment.MiddleCenter;
			chbOutOfStock.UseVisualStyleBackColor = false;
			chbOutOfStock.CheckedChanged += chbOutOfStock_CheckedChanged;
			// 
			// rbtThermalPad
			// 
			rbtThermalPad.Appearance = Appearance.Button;
			rbtThermalPad.BackColor = Color.FromArgb(4, 41, 58);
			rbtThermalPad.FlatAppearance.CheckedBackColor = Color.FromArgb(6, 70, 99);
			rbtThermalPad.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 41, 58);
			rbtThermalPad.FlatAppearance.MouseOverBackColor = Color.FromArgb(6, 70, 99);
			rbtThermalPad.FlatStyle = FlatStyle.Flat;
			rbtThermalPad.ForeColor = Color.FromArgb(236, 179, 101);
			rbtThermalPad.Location = new Point(500, 10);
			rbtThermalPad.Margin = new Padding(3, 2, 3, 2);
			rbtThermalPad.Name = "rbtThermalPad";
			rbtThermalPad.Size = new Size(95, 27);
			rbtThermalPad.TabIndex = 93;
			rbtThermalPad.TabStop = true;
			rbtThermalPad.Text = "Thermal Pad";
			rbtThermalPad.TextAlign = ContentAlignment.MiddleCenter;
			rbtThermalPad.UseVisualStyleBackColor = false;
			rbtThermalPad.CheckedChanged += rbtAll_CheckedChanged;
			// 
			// FormMain
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(4, 28, 50);
			ClientSize = new Size(1095, 553);
			Controls.Add(rbtCPUCooler);
			Controls.Add(rbtAll);
			Controls.Add(rbtComponent);
			Controls.Add(rbtPSU);
			Controls.Add(rbtCPU);
			Controls.Add(rbtCaseFan);
			Controls.Add(rbtGraphicsCard);
			Controls.Add(rbtCase);
			Controls.Add(rbtMotherboard);
			Controls.Add(rbtHDD);
			Controls.Add(rbtRAMKit);
			Controls.Add(chbOutOfStock);
			Controls.Add(rbtNVMeSSD);
			Controls.Add(rbtSataSSD);
			Controls.Add(chbAlmostOutOfStock);
			Controls.Add(rbtThermalPaste);
			Controls.Add(rbtAirCooler);
			Controls.Add(rbtStorageDevice);
			Controls.Add(rbtThermalPad);
			Controls.Add(lblCartCountNotif);
			Controls.Add(pbMinimize);
			Controls.Add(rbtAIOCooler);
			Controls.Add(pbAccount);
			Controls.Add(pbCrossCloseForm);
			Controls.Add(lblAddToCartStatus);
			Controls.Add(lblAddCategory);
			Controls.Add(label1);
			Controls.Add(tbxSearchBox);
			Controls.Add(pbOrders);
			Controls.Add(lblAddError);
			Controls.Add(pbCart);
			Controls.Add(tbxSpecifications);
			Controls.Add(cbProductToAdd);
			Controls.Add(dgvProductList);
			Controls.Add(btnAddProduct);
			Controls.Add(lblSpecifications);
			Controls.Add(panel);
			FormBorderStyle = FormBorderStyle.None;
			HelpButton = true;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			Name = "FormMain";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Main";
			((System.ComponentModel.ISupportInitialize)dgvProductList).EndInit();
			contextMenuProductList.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pbCart).EndInit();
			((System.ComponentModel.ISupportInitialize)pbOrders).EndInit();
			((System.ComponentModel.ISupportInitialize)pbCrossCloseForm).EndInit();
			((System.ComponentModel.ISupportInitialize)pbAccount).EndInit();
			((System.ComponentModel.ISupportInitialize)pbMinimize).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private DataGridView dgvProductList;
        private RadioButton rbtAll;
        private RadioButton rbtPSU;
        private RadioButton rbtCaseFan;
        private RadioButton rbtCase;
        private RadioButton rbtHDD;
        private RadioButton rbtNVMeSSD;
        private RadioButton rbtSataSSD;
        private RadioButton rbtStorageDevice;
        private RadioButton rbtAIOCooler;
        private RadioButton rbtAirCooler;
        private RadioButton rbtCPUCooler;
        private RadioButton rbtRAMKit;
        private RadioButton rbtMotherboard;
        private RadioButton rbtGraphicsCard;
        private RadioButton rbtCPU;
        private RadioButton rbtComponent;
        private Label lblSpecifications;
        private Button btnAddProduct;
        private ComboBox cbProductToAdd;
		private TextBox tbxSpecifications;
		private Label lblAddError;
		private Label lblAddCategory;
		private ContextMenuStrip contextMenuProductList;
		private ToolStripMenuItem removeToolStripMenuItem;
		private ToolStripMenuItem modifyToolStripMenuItem;
		private ToolStripMenuItem generalInfoToolStripMenuItem;
		private ToolStripMenuItem specificationsToolStripMenuItem;
		private ToolStripMenuItem addToCartToolStripMenuItem;
		private ToolStripMenuItem benchmarkInfoToolStripMenuItem;
		private TextBox tbxSearchBox;
		private Label label1;
		private Label lblAddToCartStatus;
		private PictureBox pbCart;
		private PictureBox pbOrders;
		private PictureBox pbCrossCloseForm;
		private PictureBox pbAccount;
		private Panel panel;
		private RadioButton rbtThermalPaste;
		private RadioButton rbtThermalPad;
		private Label lblCartCountNotif;
		private CheckBox chbOutOfStock;
		private PictureBox pbMinimize;
		private CheckBox chbAlmostOutOfStock;
		private DataGridViewTextBoxColumn dgvProductListColumnName;
		private DataGridViewTextBoxColumn dgvProductListColumnCategory;
		private DataGridViewTextBoxColumn dgvProductListColumnManufacturer;
		private DataGridViewTextBoxColumn dgvProductListColumnWeight;
		private DataGridViewTextBoxColumn dgvProductListColumnStockQuantity;
		private DataGridViewTextBoxColumn dgvProductListColumnPrice;
	}
}