namespace CinemaV1
{
	partial class FormMovieList
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
			textSearchMovie = new TextBox();
			NAME = new Label();
			ListPanelMovie = new FlowLayoutPanel();
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
			panel1.Size = new Size(1203, 48);
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
			label1.Text = "Movie List Screen";
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
			button1.Location = new Point(1145, 0);
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
			panel2.BackColor = Color.White;
			panel2.Controls.Add(textSearchMovie);
			panel2.Controls.Add(NAME);
			panel2.Dock = DockStyle.Top;
			panel2.ForeColor = Color.FromArgb(84, 110, 128);
			panel2.Location = new Point(0, 48);
			panel2.Margin = new Padding(4, 5, 4, 5);
			panel2.Name = "panel2";
			panel2.Size = new Size(1203, 48);
			panel2.TabIndex = 7;
			// 
			// textSearchMovie
			// 
			textSearchMovie.BorderStyle = BorderStyle.None;
			textSearchMovie.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
			textSearchMovie.ForeColor = Color.FromArgb(84, 110, 128);
			textSearchMovie.Location = new Point(983, 12);
			textSearchMovie.Name = "textSearchMovie";
			textSearchMovie.Size = new Size(212, 23);
			textSearchMovie.TabIndex = 1;
			textSearchMovie.TextAlign = HorizontalAlignment.Center;
			textSearchMovie.TextChanged += textSearchMovie_TextChanged;
			// 
			// NAME
			// 
			NAME.AutoSize = true;
			NAME.Location = new Point(881, 5);
			NAME.Name = "NAME";
			NAME.Size = new Size(96, 31);
			NAME.TabIndex = 0;
			NAME.Text = "Search :";
			NAME.Click += NAME_Click;
			// 
			// ListPanelMovie
			// 
			ListPanelMovie.AutoScroll = true;
			ListPanelMovie.BackColor = Color.FromArgb(24, 24, 24);
			ListPanelMovie.Dock = DockStyle.Fill;
			ListPanelMovie.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
			ListPanelMovie.Location = new Point(0, 96);
			ListPanelMovie.Name = "ListPanelMovie";
			ListPanelMovie.Size = new Size(1203, 654);
			ListPanelMovie.TabIndex = 8;
			// 
			// FormMovieList
			// 
			AutoScaleDimensions = new SizeF(13F, 31F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(24, 24, 24);
			ClientSize = new Size(1203, 750);
			Controls.Add(ListPanelMovie);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			FormBorderStyle = FormBorderStyle.None;
			Location = new Point(500, 110);
			Margin = new Padding(5);
			Name = "FormMovieList";
			StartPosition = FormStartPosition.Manual;
			Text = "MovieListcs";
			Load += FormMovieList_Load;
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
		private TextBox textSearchMovie;
		private Label NAME;
		private FlowLayoutPanel ListPanelMovie;
	}
}