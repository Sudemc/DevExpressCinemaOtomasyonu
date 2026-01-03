namespace CinemaV1
{
	partial class FormCinemaReg
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
			groupBox1 = new GroupBox();
			btnAd = new Button();
			comboBoxSeat = new ComboBox();
			label4 = new Label();
			textCinemaName = new TextBox();
			label2 = new Label();
			groupBox2 = new GroupBox();
			flowLayoutCinemaPanel = new FlowLayoutPanel();
			panel1.SuspendLayout();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
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
			panel1.Margin = new Padding(6, 8, 6, 8);
			panel1.Name = "panel1";
			panel1.Size = new Size(638, 52);
			panel1.TabIndex = 6;
			// 
			// label1
			// 
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.FromArgb(255, 193, 7);
			label1.Location = new Point(10, 5);
			label1.Margin = new Padding(5, 0, 5, 0);
			label1.Name = "label1";
			label1.Size = new Size(323, 59);
			label1.TabIndex = 1;
			label1.Text = "Cinema Register Screen";
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
			button1.Location = new Point(570, 0);
			button1.Margin = new Padding(6, 8, 6, 8);
			button1.Name = "button1";
			button1.Size = new Size(68, 52);
			button1.TabIndex = 3;
			button1.Text = "X";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// groupBox1
			// 
			groupBox1.BackColor = Color.White;
			groupBox1.Controls.Add(btnAd);
			groupBox1.Controls.Add(comboBoxSeat);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(textCinemaName);
			groupBox1.Controls.Add(label2);
			groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			groupBox1.ForeColor = Color.FromArgb(84, 110, 128);
			groupBox1.Location = new Point(12, 63);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(614, 106);
			groupBox1.TabIndex = 7;
			groupBox1.TabStop = false;
			// 
			// btnAd
			// 
			btnAd.AutoSize = true;
			btnAd.BackColor = Color.Coral;
			btnAd.Cursor = Cursors.Hand;
			btnAd.FlatAppearance.BorderSize = 0;
			btnAd.FlatStyle = FlatStyle.Flat;
			btnAd.ForeColor = Color.White;
			btnAd.Location = new Point(435, 35);
			btnAd.Margin = new Padding(4, 5, 4, 5);
			btnAd.Name = "btnAd";
			btnAd.Size = new Size(159, 48);
			btnAd.TabIndex = 13;
			btnAd.Text = "ADD";
			btnAd.UseVisualStyleBackColor = false;
			btnAd.Click += btnAd_Click;
			// 
			// comboBoxSeat
			// 
			comboBoxSeat.ForeColor = Color.FromArgb(84, 110, 128);
			comboBoxSeat.FormattingEnabled = true;
			comboBoxSeat.Location = new Point(252, 45);
			comboBoxSeat.Name = "comboBoxSeat";
			comboBoxSeat.Size = new Size(155, 36);
			comboBoxSeat.TabIndex = 12;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(230, 16);
			label4.Name = "label4";
			label4.Size = new Size(129, 28);
			label4.TabIndex = 11;
			label4.Text = "Seat Number";
			// 
			// textCinemaName
			// 
			textCinemaName.BackColor = Color.White;
			textCinemaName.ForeColor = Color.FromArgb(84, 110, 128);
			textCinemaName.Location = new Point(24, 45);
			textCinemaName.Name = "textCinemaName";
			textCinemaName.Size = new Size(198, 34);
			textCinemaName.TabIndex = 7;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(15, 16);
			label2.Name = "label2";
			label2.Size = new Size(141, 28);
			label2.TabIndex = 7;
			label2.Text = "Cinema Name";
			// 
			// groupBox2
			// 
			groupBox2.BackColor = Color.White;
			groupBox2.Controls.Add(flowLayoutCinemaPanel);
			groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			groupBox2.ForeColor = Color.FromArgb(84, 110, 128);
			groupBox2.Location = new Point(12, 175);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(614, 521);
			groupBox2.TabIndex = 8;
			groupBox2.TabStop = false;
			// 
			// flowLayoutCinemaPanel
			// 
			flowLayoutCinemaPanel.Dock = DockStyle.Fill;
			flowLayoutCinemaPanel.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
			flowLayoutCinemaPanel.Location = new Point(3, 30);
			flowLayoutCinemaPanel.Name = "flowLayoutCinemaPanel";
			flowLayoutCinemaPanel.Size = new Size(608, 488);
			flowLayoutCinemaPanel.TabIndex = 0;
			// 
			// FormCinemaReg
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(638, 750);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Location = new Point(600, 110);
			Name = "FormCinemaReg";
			StartPosition = FormStartPosition.Manual;
			Text = "CinemaReg";
			Load += FormCinemaReg_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Label label1;
		private Button button1;
		private GroupBox groupBox1;
		private ComboBox comboBoxSeat;
		private Label label4;
		private TextBox textCinemaName;
		private Label label2;
		private Button btnAdd;
		private GroupBox groupBox2;
		private Button btnAd;
		private FlowLayoutPanel flowLayoutCinemaPanel;
	}
}