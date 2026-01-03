namespace CinemaV1
{
	partial class MovieList
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieList));
			groupBox9 = new GroupBox();
			labelIDMovie = new Label();
			labelMovieName = new Label();
			btnUploadPic = new Button();
			picBoxMovieList = new PictureBox();
			groupBox9.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)picBoxMovieList).BeginInit();
			SuspendLayout();
			// 
			// groupBox9
			// 
			groupBox9.BackColor = Color.FromArgb(24, 24, 24);
			groupBox9.Controls.Add(labelIDMovie);
			groupBox9.Controls.Add(labelMovieName);
			groupBox9.Controls.Add(btnUploadPic);
			groupBox9.Controls.Add(picBoxMovieList);
			groupBox9.Cursor = Cursors.Hand;
			groupBox9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			groupBox9.ForeColor = Color.FromArgb(84, 110, 128);
			groupBox9.Location = new Point(3, 3);
			groupBox9.Name = "groupBox9";
			groupBox9.Size = new Size(217, 326);
			groupBox9.TabIndex = 15;
			groupBox9.TabStop = false;
			// 
			// labelIDMovie
			// 
			labelIDMovie.AutoSize = true;
			labelIDMovie.Location = new Point(91, 247);
			labelIDMovie.Name = "labelIDMovie";
			labelIDMovie.Size = new Size(129, 28);
			labelIDMovie.TabIndex = 14;
			labelIDMovie.Text = "labelIdMovie";
			labelIDMovie.Visible = false;
			// 
			// labelMovieName
			// 
			labelMovieName.AutoSize = true;
			labelMovieName.Location = new Point(7, 2);
			labelMovieName.Name = "labelMovieName";
			labelMovieName.Size = new Size(73, 28);
			labelMovieName.TabIndex = 13;
			labelMovieName.Text = "labelM";
			// 
			// btnUploadPic
			// 
			btnUploadPic.AutoSize = true;
			btnUploadPic.BackColor = Color.FromArgb(255, 193, 7);
			btnUploadPic.Cursor = Cursors.Hand;
			btnUploadPic.FlatAppearance.BorderSize = 0;
			btnUploadPic.FlatStyle = FlatStyle.Flat;
			btnUploadPic.ForeColor = Color.White;
			btnUploadPic.Location = new Point(7, 280);
			btnUploadPic.Margin = new Padding(4, 5, 4, 5);
			btnUploadPic.Name = "btnUploadPic";
			btnUploadPic.Size = new Size(201, 38);
			btnUploadPic.TabIndex = 12;
			btnUploadPic.Text = "DETAIL";
			btnUploadPic.UseVisualStyleBackColor = false;
			btnUploadPic.Click += btnUploadPic_Click;
			// 
			// picBoxMovieList
			// 
			picBoxMovieList.Image = (Image)resources.GetObject("picBoxMovieList.Image");
			picBoxMovieList.Location = new Point(7, 33);
			picBoxMovieList.Name = "picBoxMovieList";
			picBoxMovieList.Size = new Size(201, 239);
			picBoxMovieList.SizeMode = PictureBoxSizeMode.Zoom;
			picBoxMovieList.TabIndex = 11;
			picBoxMovieList.TabStop = false;
			// 
			// MovieList
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(groupBox9);
			Name = "MovieList";
			Size = new Size(223, 329);
			groupBox9.ResumeLayout(false);
			groupBox9.PerformLayout();
			((System.ComponentModel.ISupportInitialize)picBoxMovieList).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox groupBox9;
		private Button btnUploadPic;
		public PictureBox picBoxMovieList;
		public Label labelMovieName;
		public Label labelIDMovie;
	}
}
