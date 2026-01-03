namespace CinemaV1
{
	partial class FormMovieDetail
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMovieDetail));
			panel1 = new Panel();
			label1 = new Label();
			button1 = new Button();
			groupBox9 = new GroupBox();
			picBoxMovieDetail = new PictureBox();
			groupBox1 = new GroupBox();
			labelMNAME = new Label();
			groupBox2 = new GroupBox();
			labelType = new Label();
			groupBox3 = new GroupBox();
			pictureBox13 = new PictureBox();
			pictureBox12 = new PictureBox();
			pictureBox14 = new PictureBox();
			labelStyle = new Label();
			groupBox4 = new GroupBox();
			labelProperties = new Label();
			groupBox5 = new GroupBox();
			labelActors = new Label();
			groupBox6 = new GroupBox();
			labelDýrector = new Label();
			groupBox7 = new GroupBox();
			labelSitutation = new Label();
			groupBox8 = new GroupBox();
			labelDate = new Label();
			groupBox10 = new GroupBox();
			labelPoint = new Label();
			groupBox11 = new GroupBox();
			lblMaxBioSize = new Label();
			label11 = new Label();
			textboxMovieD = new TextBox();
			pro = new Button();
			lblfragman = new Label();
			panel2 = new Panel();
			pictureBox1 = new PictureBox();
			panel1.SuspendLayout();
			groupBox9.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)picBoxMovieDetail).BeginInit();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
			groupBox4.SuspendLayout();
			groupBox5.SuspendLayout();
			groupBox6.SuspendLayout();
			groupBox7.SuspendLayout();
			groupBox8.SuspendLayout();
			groupBox10.SuspendLayout();
			groupBox11.SuspendLayout();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
			panel1.Size = new Size(1300, 60);
			panel1.TabIndex = 7;
			// 
			// label1
			// 
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.FromArgb(255, 193, 7);
			label1.Location = new Point(10, 10);
			label1.Name = "label1";
			label1.Size = new Size(321, 38);
			label1.TabIndex = 1;
			label1.Text = "Movie Detail Screen";
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
			button1.Location = new Point(1042, 0);
			button1.Margin = new Padding(4, 5, 4, 5);
			button1.Name = "button1";
			button1.Size = new Size(58, 48);
			button1.TabIndex = 3;
			button1.Text = "X";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// groupBox9
			// 
			groupBox9.BackColor = Color.White;
			groupBox9.Controls.Add(picBoxMovieDetail);
			groupBox9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			groupBox9.ForeColor = Color.FromArgb(84, 110, 128);
			groupBox9.Location = new Point(0, 75);
			groupBox9.Name = "groupBox9";
			groupBox9.Size = new Size(222, 326);
			groupBox9.TabIndex = 15;
			groupBox9.TabStop = false;
			groupBox9.Text = "MOVIE POSTER";
			// 
			// picBoxMovieDetail
			// 
			picBoxMovieDetail.Image = (Image)resources.GetObject("picBoxMovieDetail.Image");
			picBoxMovieDetail.Location = new Point(6, 33);
			picBoxMovieDetail.Name = "picBoxMovieDetail";
			picBoxMovieDetail.Size = new Size(201, 287);
			picBoxMovieDetail.SizeMode = PictureBoxSizeMode.StretchImage;
			picBoxMovieDetail.TabIndex = 11;
			picBoxMovieDetail.TabStop = false;
			// 
			// groupBox1
			// 
			groupBox1.BackColor = Color.White;
			groupBox1.Controls.Add(labelMNAME);
			groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			groupBox1.ForeColor = Color.FromArgb(84, 110, 128);
			groupBox1.Location = new Point(240, 75);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(320, 100);
			groupBox1.TabIndex = 16;
			groupBox1.TabStop = false;
			groupBox1.Text = "MOVIE NAME";
			// 
			// labelMNAME
			// 
			labelMNAME.AutoSize = true;
			labelMNAME.ForeColor = Color.FromArgb(255, 193, 7);
			labelMNAME.Location = new Point(11, 50);
			labelMNAME.Name = "labelMNAME";
			labelMNAME.Size = new Size(66, 28);
			labelMNAME.TabIndex = 17;
			labelMNAME.Text = "label2";
			// 
			// groupBox2
			// 
			groupBox2.BackColor = Color.White;
			groupBox2.Controls.Add(labelType);
			groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			groupBox2.ForeColor = Color.FromArgb(84, 110, 128);
			groupBox2.Location = new Point(580, 75);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(320, 100);
			groupBox2.TabIndex = 17;
			groupBox2.TabStop = false;
			groupBox2.Text = "MOVIE TYPE";
			// 
			// labelType
			// 
			labelType.AutoSize = true;
			labelType.ForeColor = Color.FromArgb(90, 190, 240);
			labelType.Location = new Point(11, 50);
			labelType.Name = "labelType";
			labelType.Size = new Size(66, 28);
			labelType.TabIndex = 17;
			labelType.Text = "label3";
			// 
			// groupBox3
			// 
			groupBox3.BackColor = Color.White;
			groupBox3.Controls.Add(pictureBox13);
			groupBox3.Controls.Add(pictureBox12);
			groupBox3.Controls.Add(pictureBox14);
			groupBox3.Controls.Add(labelStyle);
			groupBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			groupBox3.ForeColor = Color.FromArgb(84, 110, 128);
			groupBox3.Location = new Point(920, 75);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new Size(320, 100);
			groupBox3.TabIndex = 18;
			groupBox3.TabStop = false;
			groupBox3.Text = "MOVIE STYLE";
			// 
			// pictureBox13
			// 
			pictureBox13.Cursor = Cursors.Hand;
			pictureBox13.BackColor = Color.FromArgb(45, 45, 45);
			pictureBox13.Location = new Point(213, 3);
			pictureBox13.Name = "pictureBox13";
			pictureBox13.Size = new Size(27, 30);
			// pictureBox13 solid background
			pictureBox13.TabIndex = 34;
			pictureBox13.TabStop = false;
			// 
			// pictureBox12
			// 
			pictureBox12.Cursor = Cursors.Hand;
			pictureBox12.Image = Properties.Resources.abdflah;
			pictureBox12.Location = new Point(180, 3);
			pictureBox12.Name = "pictureBox12";
			pictureBox12.Size = new Size(27, 28);
			pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox12.TabIndex = 36;
			pictureBox12.TabStop = false;
			// 
			// pictureBox14
			// 
			pictureBox14.Cursor = Cursors.Hand;
			pictureBox14.Image = Properties.Resources.trbayrak;
			pictureBox14.Location = new Point(147, 3);
			pictureBox14.Name = "pictureBox14";
			pictureBox14.Size = new Size(27, 28);
			pictureBox14.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox14.TabIndex = 33;
			pictureBox14.TabStop = false;
			// 
			// labelStyle
			// 
			labelStyle.AutoSize = true;
			labelStyle.ForeColor = Color.FromArgb(90, 190, 240);
			labelStyle.Location = new Point(11, 50);
			labelStyle.Name = "labelStyle";
			labelStyle.Size = new Size(67, 28);
			labelStyle.TabIndex = 17;
			labelStyle.Text = "label4";
			// 
			// groupBox4
			// 
			groupBox4.BackColor = Color.White;
			groupBox4.Controls.Add(labelProperties);
			groupBox4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			groupBox4.ForeColor = Color.FromArgb(84, 110, 128);
			groupBox4.Location = new Point(920, 190);
			groupBox4.Name = "groupBox4";
			groupBox4.Size = new Size(320, 100);
			groupBox4.TabIndex = 21;
			groupBox4.TabStop = false;
			groupBox4.Text = "MOVIE PROPERTIES";
			// 
			// labelProperties
			// 
			labelProperties.AutoSize = true;
			labelProperties.ForeColor = Color.FromArgb(90, 190, 240);
			labelProperties.Location = new Point(11, 50);
			labelProperties.Name = "labelProperties";
			labelProperties.Size = new Size(66, 28);
			labelProperties.TabIndex = 17;
			labelProperties.Text = "label5";
			// 
			// groupBox5
			// 
			groupBox5.BackColor = Color.White;
			groupBox5.Controls.Add(labelActors);
			groupBox5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			groupBox5.ForeColor = Color.FromArgb(84, 110, 128);
			groupBox5.Location = new Point(580, 190);
			groupBox5.Name = "groupBox5";
			groupBox5.Size = new Size(320, 100);
			groupBox5.TabIndex = 20;
			groupBox5.TabStop = false;
			groupBox5.Text = "MOVIE ACTORS";
			// 
			// labelActors
			// 
			labelActors.AutoSize = true;
			labelActors.ForeColor = Color.FromArgb(90, 190, 240);
			labelActors.Location = new Point(11, 50);
			labelActors.Name = "labelActors";
			labelActors.Size = new Size(66, 28);
			labelActors.TabIndex = 17;
			labelActors.Text = "label6";
			// 
			// groupBox6
			// 
			groupBox6.BackColor = Color.White;
			groupBox6.Controls.Add(labelDýrector);
			groupBox6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			groupBox6.ForeColor = Color.FromArgb(84, 110, 128);
			groupBox6.Location = new Point(240, 190);
			groupBox6.Name = "groupBox6";
			groupBox6.Size = new Size(320, 100);
			groupBox6.TabIndex = 19;
			groupBox6.TabStop = false;
			groupBox6.Text = "MOVIE DIRECTOR";
			// 
			// labelDýrector
			// 
			labelDýrector.AutoSize = true;
			labelDýrector.ForeColor = Color.FromArgb(90, 190, 240);
			labelDýrector.Location = new Point(11, 27);
			labelDýrector.Name = "labelDýrector";
			labelDýrector.Size = new Size(66, 28);
			labelDýrector.TabIndex = 17;
			labelDýrector.Text = "label7";
			// 
			// groupBox7
			// 
			groupBox7.BackColor = Color.White;
			groupBox7.Controls.Add(labelSitutation);
			groupBox7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			groupBox7.ForeColor = Color.FromArgb(84, 110, 128);
			groupBox7.Location = new Point(920, 305);
			groupBox7.Name = "groupBox7";
			groupBox7.Size = new Size(320, 100);
			groupBox7.TabIndex = 24;
			groupBox7.TabStop = false;
			groupBox7.Text = "MOVIE SITUATION";
			// 
			// labelSitutation
			// 
			labelSitutation.AutoSize = true;
			labelSitutation.ForeColor = Color.FromArgb(255, 193, 7);
			labelSitutation.Location = new Point(11, 50);
			labelSitutation.Name = "labelSitutation";
			labelSitutation.Size = new Size(66, 28);
			labelSitutation.TabIndex = 17;
			labelSitutation.Text = "label8";
			// 
			// groupBox8
			// 
			groupBox8.BackColor = Color.White;
			groupBox8.Controls.Add(labelDate);
			groupBox8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			groupBox8.ForeColor = Color.FromArgb(84, 110, 128);
			groupBox8.Location = new Point(580, 305);
			groupBox8.Name = "groupBox8";
			groupBox8.Size = new Size(320, 100);
			groupBox8.TabIndex = 23;
			groupBox8.TabStop = false;
			groupBox8.Text = "MOVIE RELEASE DATE";
			// 
			// labelDate
			// 
			labelDate.AutoSize = true;
			labelDate.ForeColor = Color.FromArgb(90, 190, 240);
			labelDate.Location = new Point(11, 50);
			labelDate.Name = "labelDate";
			labelDate.Size = new Size(66, 28);
			labelDate.TabIndex = 17;
			labelDate.Text = "label9";
			// 
			// groupBox10
			// 
			groupBox10.BackColor = Color.White;
			groupBox10.Controls.Add(labelPoint);
			groupBox10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			groupBox10.ForeColor = Color.FromArgb(84, 110, 128);
			groupBox10.Location = new Point(240, 305);
			groupBox10.Name = "groupBox10";
			groupBox10.Size = new Size(320, 100);
			groupBox10.TabIndex = 22;
			groupBox10.TabStop = false;
			groupBox10.Text = "MOVIE IMDB POINT";
			// 
			// labelPoint
			// 
			labelPoint.AutoSize = true;
			labelPoint.ForeColor = Color.Goldenrod;
			labelPoint.Location = new Point(11, 50);
			labelPoint.Name = "labelPoint";
			labelPoint.Size = new Size(74, 28);
			labelPoint.TabIndex = 17;
			labelPoint.Text = "label10";
			// 
			// groupBox11
			// 
			groupBox11.BackColor = Color.White;
			groupBox11.Controls.Add(lblMaxBioSize);
			groupBox11.Controls.Add(label11);
			groupBox11.Controls.Add(textboxMovieD);
			groupBox11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			groupBox11.ForeColor = Color.FromArgb(84, 110, 128);
			groupBox11.Location = new Point(240, 420);
			groupBox11.Name = "groupBox11";
			groupBox11.Size = new Size(845, 117);
			groupBox11.TabIndex = 25;
			groupBox11.TabStop = false;
			groupBox11.Text = "MOVIE DETAIL";
			// 
			// lblMaxBioSize
			// 
			lblMaxBioSize.AutoSize = true;
			lblMaxBioSize.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
			lblMaxBioSize.Location = new Point(965, 160);
			lblMaxBioSize.Name = "lblMaxBioSize";
			lblMaxBioSize.RightToLeft = RightToLeft.Yes;
			lblMaxBioSize.Size = new Size(38, 23);
			lblMaxBioSize.TabIndex = 12;
			lblMaxBioSize.Text = "300";
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
			label11.Location = new Point(855, 0);
			label11.Name = "label11";
			label11.Size = new Size(157, 23);
			label11.TabIndex = 10;
			label11.Text = "Max 300 Character";
			// 
			// textboxMovieD
			// 
			textboxMovieD.BorderStyle = BorderStyle.None;
			textboxMovieD.Dock = DockStyle.Bottom;
			textboxMovieD.ForeColor = Color.FromArgb(84, 110, 128);
			textboxMovieD.Location = new Point(3, 35);
			textboxMovieD.MaxLength = 300;
			textboxMovieD.Multiline = true;
			textboxMovieD.Name = "textboxMovieD";
			textboxMovieD.Size = new Size(839, 79);
			textboxMovieD.TabIndex = 0;
			// 
			// pro
			// 
			pro.BackColor = SystemColors.ActiveCaptionText;
			pro.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
			pro.FlatStyle = FlatStyle.Flat;
			pro.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
			pro.ForeColor = Color.Snow;
			pro.Location = new Point(425, 476);
			pro.Name = "pro";
			pro.Size = new Size(400, 70);
			pro.TabIndex = 26;
			pro.Text = "WATCH TRAILER";
			pro.UseVisualStyleBackColor = false;
			pro.Click += pro_Click;
			// 
			// lblfragman
			// 
			lblfragman.AutoSize = true;
			lblfragman.Location = new Point(37, 431);
			lblfragman.Name = "lblfragman";
			lblfragman.Size = new Size(66, 28);
			lblfragman.TabIndex = 27;
			lblfragman.Text = "label2";
			lblfragman.Visible = false;
			// 
			// panel2
			// 
			panel2.Controls.Add(pro);
			panel2.Controls.Add(pictureBox1);
			panel2.Dock = DockStyle.Bottom;
			panel2.Location = new Point(0, 53);
			panel2.Name = "panel2";
			panel2.Size = new Size(1100, 577);
			panel2.TabIndex = 29;
			// 
			// pictureBox1
			// 
			pictureBox1.Dock = DockStyle.Fill;
			pictureBox1.BackColor = Color.FromArgb(24, 24, 24);
			pictureBox1.Location = new Point(0, 0);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(1100, 577);
			// pictureBox1 solid background
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// FormMovieDetail
			// 
			AutoScaleDimensions = new SizeF(11F, 28F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1300, 750);
			Controls.Add(lblfragman);
			Controls.Add(groupBox11);
			Controls.Add(groupBox7);
			Controls.Add(groupBox8);
			Controls.Add(groupBox10);
			Controls.Add(groupBox4);
			Controls.Add(groupBox5);
			Controls.Add(groupBox6);
			Controls.Add(groupBox3);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Controls.Add(groupBox9);
			Controls.Add(panel1);
			Controls.Add(panel2);
			Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(4);
			Name = "FormMovieDetail";
			Text = "FormMovieDetail";
			Load += FormMovieDetail_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			groupBox9.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)picBoxMovieDetail).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			groupBox3.ResumeLayout(false);
			groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
			groupBox4.ResumeLayout(false);
			groupBox4.PerformLayout();
			groupBox5.ResumeLayout(false);
			groupBox5.PerformLayout();
			groupBox6.ResumeLayout(false);
			groupBox6.PerformLayout();
			groupBox7.ResumeLayout(false);
			groupBox7.PerformLayout();
			groupBox8.ResumeLayout(false);
			groupBox8.PerformLayout();
			groupBox10.ResumeLayout(false);
			groupBox10.PerformLayout();
			groupBox11.ResumeLayout(false);
			groupBox11.PerformLayout();
			panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private Label label1;
		private Button button1;
		private GroupBox groupBox9;
		private PictureBox picBoxMovieDetail;
		private GroupBox groupBox1;
		private Label labelMNAME;
		private GroupBox groupBox2;
		private Label labelType;
		private GroupBox groupBox3;
		private Label labelStyle;
		private GroupBox groupBox4;
		private Label labelProperties;
		private GroupBox groupBox5;
		private Label labelActors;
		private GroupBox groupBox6;
		private Label labelDýrector;
		private GroupBox groupBox7;
		private Label labelSitutation;
		private GroupBox groupBox8;
		private Label labelDate;
		private GroupBox groupBox10;
		private Label labelPoint;
		private GroupBox groupBox11;
		private Label lblMaxBioSize;
		private Label label11;
		private TextBox textboxMovieD;
		private PictureBox pictureBox14;
		private PictureBox pictureBox12;
		private PictureBox pictureBox13;
		private Button pro;
		private Label lblfragman;
		private Panel panel2;
		private PictureBox pictureBox1;
	}
}



