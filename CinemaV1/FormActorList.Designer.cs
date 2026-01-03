namespace CinemaV1
{
	partial class FormActorList
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
			panel2 = new Panel();
			textSearch1 = new TextBox();
			NAME = new Label();
			ListPanel = new FlowLayoutPanel();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
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
			panel1.Size = new Size(600, 48);
			panel1.TabIndex = 6;
			// 
			// label1
			// 
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.FromArgb(255, 193, 7);
			label1.Location = new Point(10, 5);
			label1.Name = "label1";
			label1.Size = new Size(321, 38);
			label1.TabIndex = 1;
			label1.Text = "Actor List Screen";
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
			button1.Location = new Point(582, 0);
			button1.Margin = new Padding(4, 5, 4, 5);
			button1.Name = "button1";
			button1.Size = new Size(58, 48);
			button1.TabIndex = 3;
			button1.Text = "X";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click_1;
			// 
			// panel2
			// 
			panel2.BackColor = Color.FromArgb(45, 45, 45);
			panel2.Controls.Add(textSearch1);
			panel2.Controls.Add(NAME);
			panel2.Dock = DockStyle.Top;
			panel2.ForeColor = Color.FromArgb(84, 110, 128);
			panel2.Location = new Point(0, 48);
			panel2.Margin = new Padding(4, 5, 4, 5);
			panel2.Name = "panel2";
			panel2.Size = new Size(600, 48);
			panel2.TabIndex = 7;
			// 
			// textSearch1
			// 
			textSearch1.BorderStyle = BorderStyle.None;
			textSearch1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
			textSearch1.ForeColor = Color.FromArgb(84, 110, 128);
			textSearch1.Location = new Point(414, 17);
			textSearch1.Name = "textSearch1";
			textSearch1.Size = new Size(212, 23);
			textSearch1.TabIndex = 1;
			textSearch1.TextAlign = HorizontalAlignment.Center;
			textSearch1.TextChanged += textSearch_TextChanged;
			// 
			// NAME
			// 
			NAME.AutoSize = true;
			NAME.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			NAME.ForeColor = Color.FromArgb(255, 193, 7);
			NAME.Location = new Point(324, 12);
			NAME.Name = "NAME";
			NAME.Size = new Size(90, 31);
			NAME.TabIndex = 0;
			NAME.Text = "NAME :";
			// 
			// ListPanel
			// 
			ListPanel.AutoScroll = true;
			ListPanel.BackColor = Color.FromArgb(24, 24, 24);
			ListPanel.Dock = DockStyle.Fill;
			ListPanel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
			ListPanel.Location = new Point(0, 96);
			ListPanel.Name = "ListPanel";
			ListPanel.Size = new Size(600, 654);
			ListPanel.TabIndex = 8;
			// 
			// FormActorList
			// 
			AutoScaleDimensions = new SizeF(9F, 20F);
			AutoScaleMode = AutoScaleMode.None;
			ClientSize = new Size(600, 750);
			Controls.Add(ListPanel);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
			FormBorderStyle = FormBorderStyle.None;
			Location = new Point(600, 110);
			Name = "FormActorList";
			StartPosition = FormStartPosition.Manual;
			Text = "FormActorList";
			Load += FormActorList_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Label label1;
		private Button button1;
		private Panel panel2;
		private TextBox textSearch1;
		private Label NAME;
		private FlowLayoutPanel ListPanel;
	}
}