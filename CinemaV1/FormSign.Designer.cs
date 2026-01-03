namespace CinemaV1
{
	partial class FormSign
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
		private void InitializeComponent()
		{
			panel1 = new Panel();
			label1 = new Label();
			button1 = new Button();
			textPassword = new TextBox();
			label3 = new Label();
			label2 = new Label();
			textUsername = new TextBox();
			label4 = new Label();
			txtName = new TextBox();
			button2 = new Button();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(45, 45, 45);
			panel1.Controls.Add(label1);
			panel1.Controls.Add(button1);
			panel1.Dock = DockStyle.Top;
			panel1.ForeColor = Color.White;
			panel1.Location = new Point(0, 0);
			panel1.Margin = new Padding(4, 5, 4, 5);
			panel1.Name = "panel1";
			panel1.Size = new Size(436, 66);
			panel1.TabIndex = 3;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.FromArgb(255, 193, 7);
			label1.Location = new Point(10, 5);
			label1.Name = "label1";
			label1.Size = new Size(161, 38);
			label1.TabIndex = 1;
			label1.Text = "Sign Screen";
			// 
			// button1
			// 
			button1.AutoSize = true;
			button1.BackColor = Color.FromArgb(229, 9, 20);
			button1.Cursor = Cursors.Hand;
			button1.Dock = DockStyle.Right;
			button1.FlatAppearance.BorderSize = 0;
			button1.FlatStyle = FlatStyle.Flat;
			button1.ForeColor = Color.White;
			button1.Location = new Point(378, 0);
			button1.Margin = new Padding(4, 5, 4, 5);
			button1.Name = "button1";
			button1.Size = new Size(58, 66);
			button1.TabIndex = 3;
			button1.Text = "X";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// textPassword
			// 
			textPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			textPassword.ForeColor = Color.FromArgb(84, 110, 128);
			textPassword.Location = new Point(144, 168);
			textPassword.Name = "textPassword";
			textPassword.Size = new Size(271, 30);
			textPassword.TabIndex = 10;
			textPassword.UseSystemPasswordChar = true;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
			label3.ForeColor = Color.FromArgb(84, 110, 128);
			label3.Location = new Point(3, 167);
			label3.Name = "label3";
			label3.Size = new Size(113, 25);
			label3.TabIndex = 9;
			label3.Text = " PASSWORD";
			// 
			// label2
			// 
			label2.FlatStyle = FlatStyle.Flat;
			label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
			label2.ForeColor = Color.FromArgb(84, 110, 128);
			label2.Location = new Point(8, 123);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(108, 35);
			label2.TabIndex = 7;
			label2.Text = "USERNAME";
			// 
			// textUsername
			// 
			textUsername.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			textUsername.ForeColor = Color.FromArgb(84, 110, 128);
			textUsername.Location = new Point(144, 123);
			textUsername.Margin = new Padding(4, 5, 4, 5);
			textUsername.Name = "textUsername";
			textUsername.Size = new Size(271, 30);
			textUsername.TabIndex = 8;
			// 
			// label4
			// 
			label4.FlatStyle = FlatStyle.Flat;
			label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
			label4.ForeColor = Color.FromArgb(84, 110, 128);
			label4.Location = new Point(8, 76);
			label4.Margin = new Padding(4, 0, 4, 0);
			label4.Name = "label4";
			label4.Size = new Size(91, 35);
			label4.TabIndex = 11;
			label4.Text = "NAME";
			// 
			// txtName
			// 
			txtName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			txtName.ForeColor = Color.FromArgb(84, 110, 128);
			txtName.Location = new Point(144, 76);
			txtName.Margin = new Padding(4, 5, 4, 5);
			txtName.Name = "txtName";
			txtName.Size = new Size(271, 30);
			txtName.TabIndex = 12;
			// 
			// button2
			// 
			button2.BackColor = Color.FromArgb(84, 110, 128);
			button2.Cursor = Cursors.Hand;
			button2.FlatAppearance.BorderSize = 0;
			button2.FlatStyle = FlatStyle.Flat;
			button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			button2.ForeColor = Color.White;
			button2.Location = new Point(144, 212);
			button2.Name = "button2";
			button2.Size = new Size(271, 52);
			button2.TabIndex = 13;
			button2.Text = "Sign In";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// FormSign
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(436, 299);
			Controls.Add(button2);
			Controls.Add(txtName);
			Controls.Add(label4);
			Controls.Add(textPassword);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(textUsername);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "FormSign";
			Text = "FormSign";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private Label label1;
		private Button button1;
		private TextBox textPassword;
		private Label label3;
		private Label label2;
		private TextBox textUsername;
		private Label label4;
		private TextBox txtName;
		private Button button2;
	}
}