namespace CinemaV1
{
	partial class FormDirectorList
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
			textSearch = new TextBox();
			NAME = new Label();
			panel3 = new Panel();
			ListPanel = new FlowLayoutPanel();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			panel3.SuspendLayout();
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
			panel1.TabIndex = 5;
			panel1.Paint += panel1_Paint;
			// 
			// label1
			// 
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.FromArgb(255, 193, 7);
			label1.Location = new Point(10, 5);
			label1.Name = "label1";
			label1.Size = new Size(281, 38);
			label1.TabIndex = 1;
			label1.Text = "Director List Screen";
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
			button1.Location = new Point(580, 0);
			button1.Margin = new Padding(4, 5, 4, 5);
			button1.Name = "button1";
			button1.Size = new Size(58, 48);
			button1.TabIndex = 3;
			button1.Text = "X";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// panel2
			// 
			panel2.BackColor = Color.FromArgb(45, 45, 45);
			panel2.Controls.Add(textSearch);
			panel2.Controls.Add(NAME);
			panel2.Dock = DockStyle.Top;
			panel2.ForeColor = Color.FromArgb(200, 200, 200);
			panel2.Location = new Point(0, 48);
			panel2.Margin = new Padding(4, 5, 4, 5);
			panel2.Name = "panel2";
			panel2.Size = new Size(600, 48);
			panel2.TabIndex = 6;
			// 
			// textSearch
			// 
			textSearch.BorderStyle = BorderStyle.None;
			textSearch.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
			textSearch.ForeColor = Color.FromArgb(84, 110, 128);
			textSearch.Location = new Point(414, 17);
			textSearch.Name = "textSearch";
			textSearch.Size = new Size(212, 23);
			textSearch.TabIndex = 1;
			textSearch.TextAlign = HorizontalAlignment.Center;
			textSearch.TextChanged += textSearch_TextChanged;
			// 
			// NAME
			// 
			NAME.AutoSize = true;
			NAME.ForeColor = Color.FromArgb(255, 193, 7);
			NAME.Location = new Point(324, 12);
			NAME.Name = "NAME";
			NAME.Size = new Size(90, 31);
			NAME.TabIndex = 0;
			NAME.Text = "NAME :";
			// 
			// panel3
			// 
			panel3.BackColor = Color.FromArgb(24, 24, 24);
			panel3.Controls.Add(ListPanel);
			panel3.Dock = DockStyle.Fill;
			panel3.ForeColor = Color.FromArgb(200, 200, 200);
			panel3.Location = new Point(0, 96);
			panel3.Margin = new Padding(4, 5, 4, 5);
			panel3.Name = "panel3";
			panel3.Size = new Size(600, 504);
			panel3.TabIndex = 7;
			// 
			// ListPanel
			// 
			ListPanel.AutoScroll = false;
			ListPanel.BackColor = Color.FromArgb(24, 24, 24);
			ListPanel.Dock = DockStyle.Fill;
			ListPanel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
			ListPanel.Location = new Point(0, 0);
			ListPanel.Name = "ListPanel";
			ListPanel.Size = new Size(600, 504);
			ListPanel.TabIndex = 0;
			// 
			// FormDirectorList
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.None;
			BackColor = Color.FromArgb(24, 24, 24);
			ClientSize = new Size(600, 600);
			Controls.Add(panel3);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
			FormBorderStyle = FormBorderStyle.None;
			Location = new Point(600, 110);
			Margin = new Padding(5);
			Name = "FormDirectorList";
			StartPosition = FormStartPosition.Manual;
			Text = "FormDirectorList";
			Load += FormDirectorList_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			panel3.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Label label1;
		private Button button1;
		private Panel panel2;
		private Panel panel3;
		private FlowLayoutPanel ListPanel;
		private Label NAME;
		private TextBox textSearch;
	}
}