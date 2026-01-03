namespace CinemaV1
{
	partial class FormLogin
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
			panel1 = new Panel();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			textPassword = new TextBox();
			buttonEnter = new Button();
			textUsername = new TextBox();
			button2 = new Button();
			pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
			pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
			simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureEdit2.Properties).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(45, 45, 45);
			panel1.Controls.Add(simpleButton1);
			panel1.Controls.Add(label1);
			panel1.Dock = DockStyle.Top;
			panel1.ForeColor = Color.FromArgb(224, 224, 224);
			panel1.Location = new Point(0, 0);
			panel1.Margin = new Padding(4, 5, 4, 5);
			panel1.Name = "panel1";
			panel1.Size = new Size(500, 62);
			panel1.TabIndex = 2;
			// 
			// label1 - Title (SDMCinema)
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.FromArgb(255, 193, 7);
			label1.Location = new Point(0, 10);
			label1.Name = "label1";
			label1.Size = new Size(157, 38);
			label1.TabIndex = 1;
			label1.Text = "SDMCinema";
			// 
			// label2 - USERNAME label
			// 
			label2.AutoSize = true;
			label2.ForeColor = Color.FromArgb(200, 200, 200);
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(50, 90);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(120, 28);
			label2.TabIndex = 3;
			label2.Text = "USERNAME";
			// 
			// label3 - PASSWORD label
			// 
			label3.AutoSize = true;
			label3.ForeColor = Color.FromArgb(200, 200, 200);
			label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(50, 150);
			label3.Name = "label3";
			label3.Size = new Size(120, 28);
			label3.TabIndex = 5;
			label3.Text = "PASSWORD";
			// 
			// textPassword - Input field
			// 
			textPassword.BackColor = Color.FromArgb(58, 58, 58);
			textPassword.ForeColor = Color.FromArgb(224, 224, 224);
			textPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			textPassword.BorderStyle = BorderStyle.FixedSingle;
			textPassword.Location = new Point(180, 145);
			textPassword.Name = "textPassword";
			textPassword.Size = new Size(270, 34);
			textPassword.TabIndex = 6;
			textPassword.UseSystemPasswordChar = true;
			// 
			// buttonEnter - Login button (Amber)
			// 
			buttonEnter.BackColor = Color.FromArgb(255, 193, 7);
			buttonEnter.Cursor = Cursors.Hand;
			buttonEnter.FlatAppearance.BorderSize = 0;
			buttonEnter.FlatStyle = FlatStyle.Flat;
			buttonEnter.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			buttonEnter.ForeColor = Color.FromArgb(24, 24, 24);
			buttonEnter.Location = new Point(50, 210);
			buttonEnter.Name = "buttonEnter";
			buttonEnter.Size = new Size(400, 50);
			buttonEnter.TabIndex = 7;
			buttonEnter.Text = "Login";
			buttonEnter.UseVisualStyleBackColor = false;
			buttonEnter.Click += buttonEnter_Click;
			// 
			// textUsername - Input field
			// 
			textUsername.BackColor = Color.FromArgb(58, 58, 58);
			textUsername.ForeColor = Color.FromArgb(224, 224, 224);
			textUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			textUsername.BorderStyle = BorderStyle.FixedSingle;
			textUsername.Location = new Point(180, 85);
			textUsername.Margin = new Padding(4, 5, 4, 5);
			textUsername.Name = "textUsername";
			textUsername.Size = new Size(270, 34);
			textUsername.TabIndex = 4;
			// 
			// button2 - Sign Up button (Secondary)
			// 
			button2.BackColor = Color.FromArgb(45, 45, 45);
			button2.Cursor = Cursors.Hand;
			button2.FlatAppearance.BorderSize = 1;
			button2.FlatAppearance.BorderColor = Color.FromArgb(255, 193, 7);
			button2.FlatStyle = FlatStyle.Flat;
			button2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
			button2.ForeColor = Color.FromArgb(255, 193, 7);
			button2.Location = new Point(50, 275);
			button2.Name = "button2";
			button2.Size = new Size(400, 45);
			button2.TabIndex = 8;
			button2.Text = "Sign Up";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// pictureEdit1 - User icon
			// 
			pictureEdit1.EditValue = resources.GetObject("pictureEdit1.EditValue");
			pictureEdit1.Location = new Point(10, 82);
			pictureEdit1.Name = "pictureEdit1";
			pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
			pictureEdit1.Size = new Size(35, 35);
			pictureEdit1.TabIndex = 9;
			// 
			// pictureEdit2 - Lock icon
			// 
			pictureEdit2.EditValue = resources.GetObject("pictureEdit2.EditValue");
			pictureEdit2.Location = new Point(10, 142);
			pictureEdit2.Name = "pictureEdit2";
			pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
			pictureEdit2.Size = new Size(35, 35);
			pictureEdit2.TabIndex = 10;
			// 
			// simpleButton1
			// 
			simpleButton1.Dock = DockStyle.Right;
			simpleButton1.ImageOptions.Image = (Image)resources.GetObject("simpleButton1.ImageOptions.Image");
			simpleButton1.Location = new Point(422, 0);
			simpleButton1.Name = "simpleButton1";
			simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
			simpleButton1.Size = new Size(41, 62);
			simpleButton1.TabIndex = 4;
			simpleButton1.Text = "simpleButton1";
			// 
			// FormLogin
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.None;
			ClientSize = new Size(500, 340);
			Controls.Add(pictureEdit2);
			Controls.Add(pictureEdit1);
			Controls.Add(button2);
			Controls.Add(buttonEnter);
			Controls.Add(textPassword);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(textUsername);
			Controls.Add(panel1);
			BackColor = Color.FromArgb(24, 24, 24);
			Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			ForeColor = Color.FromArgb(224, 224, 224);
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(4, 5, 4, 5);
			Name = "FormLogin";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "SDMCinema - Login";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureEdit2.Properties).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Panel panel1;
		private Label label1;
		private Label label2;
		private Label label3;
		private TextBox textPassword;
		private Button buttonEnter;
		private TextBox textUsername;
		private Button button2;
		private DevExpress.XtraEditors.PictureEdit pictureEdit1;
		private DevExpress.XtraEditors.PictureEdit pictureEdit2;
		private DevExpress.XtraEditors.SimpleButton simpleButton1;
	}
}
