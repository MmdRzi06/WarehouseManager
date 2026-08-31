namespace WarehouseManager {
    partial class FormChangeUsername
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChangeUsername));
			tbxUsername = new TextBox();
			lblUsername = new Label();
			btnCancel = new Button();
			btnConfirm = new Button();
			lblError = new Label();
			panel = new Panel();
			lblChangeUsername = new Label();
			panel.SuspendLayout();
			SuspendLayout();
			// 
			// tbxUsername
			// 
			tbxUsername.BackColor = Color.FromArgb(4, 41, 58);
			tbxUsername.BorderStyle = BorderStyle.FixedSingle;
			tbxUsername.ForeColor = Color.FromArgb(236, 179, 101);
			tbxUsername.Location = new Point(13, 78);
			tbxUsername.Margin = new Padding(4, 2, 4, 2);
			tbxUsername.MaxLength = 32;
			tbxUsername.Name = "tbxUsername";
			tbxUsername.Size = new Size(262, 23);
			tbxUsername.TabIndex = 0;
			tbxUsername.KeyPress += tbxUsername_KeyPress;
			// 
			// lblUsername
			// 
			lblUsername.AutoSize = true;
			lblUsername.ForeColor = Color.FromArgb(236, 179, 101);
			lblUsername.Location = new Point(13, 58);
			lblUsername.Margin = new Padding(4, 0, 4, 0);
			lblUsername.Name = "lblUsername";
			lblUsername.Size = new Size(87, 15);
			lblUsername.TabIndex = 2;
			lblUsername.Text = "New Username";
			// 
			// btnCancel
			// 
			btnCancel.BackColor = Color.FromArgb(4, 41, 58);
			btnCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 41, 58);
			btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(6, 70, 99);
			btnCancel.FlatStyle = FlatStyle.Flat;
			btnCancel.ForeColor = Color.FromArgb(236, 179, 101);
			btnCancel.Location = new Point(13, 114);
			btnCancel.Margin = new Padding(4, 2, 4, 2);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(123, 27);
			btnCancel.TabIndex = 4;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = false;
			btnCancel.Click += btnCancel_Click;
			// 
			// btnConfirm
			// 
			btnConfirm.BackColor = Color.FromArgb(4, 41, 58);
			btnConfirm.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 41, 58);
			btnConfirm.FlatAppearance.MouseOverBackColor = Color.FromArgb(6, 70, 99);
			btnConfirm.FlatStyle = FlatStyle.Flat;
			btnConfirm.ForeColor = Color.FromArgb(236, 179, 101);
			btnConfirm.Location = new Point(154, 114);
			btnConfirm.Margin = new Padding(4, 2, 4, 2);
			btnConfirm.Name = "btnConfirm";
			btnConfirm.Size = new Size(121, 27);
			btnConfirm.TabIndex = 5;
			btnConfirm.Text = "Confirm";
			btnConfirm.UseVisualStyleBackColor = false;
			btnConfirm.Click += btnConfirm_Click;
			// 
			// lblError
			// 
			lblError.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblError.ForeColor = Color.FromArgb(244, 43, 50);
			lblError.Location = new Point(13, 158);
			lblError.Margin = new Padding(4, 0, 4, 0);
			lblError.Name = "lblError";
			lblError.Size = new Size(262, 44);
			lblError.TabIndex = 6;
			lblError.Text = "\r\n";
			// 
			// panel
			// 
			panel.BackColor = Color.Transparent;
			panel.BorderStyle = BorderStyle.FixedSingle;
			panel.Controls.Add(lblChangeUsername);
			panel.Dock = DockStyle.Fill;
			panel.Location = new Point(0, 0);
			panel.Name = "panel";
			panel.Padding = new Padding(1);
			panel.Size = new Size(287, 215);
			panel.TabIndex = 90;
			// 
			// lblChangeUsername
			// 
			lblChangeUsername.AutoSize = true;
			lblChangeUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblChangeUsername.ForeColor = Color.FromArgb(236, 179, 101);
			lblChangeUsername.Location = new Point(11, 8);
			lblChangeUsername.Name = "lblChangeUsername";
			lblChangeUsername.Size = new Size(149, 21);
			lblChangeUsername.TabIndex = 98;
			lblChangeUsername.Text = "Change Username";
			// 
			// FormChangeUsername
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(4, 28, 50);
			ClientSize = new Size(287, 215);
			Controls.Add(lblError);
			Controls.Add(btnConfirm);
			Controls.Add(tbxUsername);
			Controls.Add(btnCancel);
			Controls.Add(lblUsername);
			Controls.Add(panel);
			FormBorderStyle = FormBorderStyle.None;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(3, 2, 3, 2);
			MaximizeBox = false;
			MdiChildrenMinimizedAnchorBottom = false;
			Name = "FormChangeUsername";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Change Username";
			panel.ResumeLayout(false);
			panel.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox tbxUsername;
		private Label lblUsername;
		private Button btnCancel;
		private Button btnConfirm;
		private Label lblError;
		private Panel panel;
		private Label lblChangeUsername;
	}
}