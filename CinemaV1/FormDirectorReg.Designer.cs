namespace CinemaV1
{
	partial class FormDirectorReg
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDirectorReg));
			panel1 = new Panel();
			btnExit = new DevExpress.XtraEditors.SimpleButton();
			label1 = new Label();
			groupBox1 = new GroupBox();
			numYear = new NumericUpDown();
			numMonth = new NumericUpDown();
			numDay = new NumericUpDown();
			pictureBox3 = new PictureBox();
			pictureBox2 = new PictureBox();
			rFemale = new RadioButton();
			rMale = new RadioButton();
			label5 = new Label();
			label3 = new Label();
			textSname = new TextBox();
			label4 = new Label();
			textName = new TextBox();
			label2 = new Label();
			groupBox2 = new GroupBox();
			btnUploadPic = new Button();
			picBox = new PictureBox();
			label6 = new Label();
			label8 = new Label();
			btnSubmit = new Button();
			lblMaxBioSize = new Label();
			label9 = new Label();
			rBio = new RichTextBox();
			panel1.SuspendLayout();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)numYear).BeginInit();
			((System.ComponentModel.ISupportInitialize)numMonth).BeginInit();
			((System.ComponentModel.ISupportInitialize)numDay).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)picBox).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(45, 45, 45);
			panel1.Controls.Add(btnExit);
			panel1.Controls.Add(label1);
			panel1.Dock = DockStyle.Top;
			panel1.ForeColor = Color.White;
			panel1.Location = new Point(0, 0);
			panel1.Margin = new Padding(4, 5, 4, 5);
			panel1.Name = "panel1";
			panel1.Size = new Size(638, 48);
			panel1.TabIndex = 4;
			// 
			// btnExit
			// 
			btnExit.Dock = DockStyle.Right;
			btnExit.ImageOptions.Image = (Image)resources.GetObject("btnExit.ImageOptions.Image");
			btnExit.Location = new Point(602, 0);
			btnExit.Name = "btnExit";
			btnExit.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
			btnExit.Size = new Size(36, 48);
			btnExit.TabIndex = 6;
			btnExit.Click += btnExit_Click;
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
			label1.Text = "Director Register Screen";
			// 
			// groupBox1
			// 
			groupBox1.BackColor = Color.White;
			groupBox1.Controls.Add(numYear);
			groupBox1.Controls.Add(numMonth);
			groupBox1.Controls.Add(numDay);
			groupBox1.Controls.Add(pictureBox3);
			groupBox1.Controls.Add(pictureBox2);
			groupBox1.Controls.Add(rFemale);
			groupBox1.Controls.Add(rMale);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(textSname);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(textName);
			groupBox1.Controls.Add(label2);
			groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			groupBox1.ForeColor = Color.FromArgb(84, 110, 128);
			groupBox1.Location = new Point(12, 67);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(329, 325);
			groupBox1.TabIndex = 5;
			groupBox1.TabStop = false;
			// 
			// numYear
			// 
			numYear.ForeColor = Color.FromArgb(84, 110, 128);
			numYear.ImeMode = ImeMode.Disable;
			numYear.Location = new Point(213, 209);
			numYear.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
			numYear.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
			numYear.Name = "numYear";
			numYear.Size = new Size(96, 34);
			numYear.TabIndex = 22;
			numYear.Value = new decimal(new int[] { 2024, 0, 0, 0 });
			// 
			// numMonth
			// 
			numMonth.ForeColor = Color.FromArgb(84, 110, 128);
			numMonth.Location = new Point(114, 209);
			numMonth.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
			numMonth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			numMonth.Name = "numMonth";
			numMonth.Size = new Size(77, 34);
			numMonth.TabIndex = 21;
			numMonth.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// numDay
			// 
			numDay.ForeColor = Color.FromArgb(84, 110, 128);
			numDay.Location = new Point(15, 209);
			numDay.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
			numDay.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			numDay.Name = "numDay";
			numDay.Size = new Size(77, 34);
			numDay.TabIndex = 20;
			numDay.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// pictureBox3
			// 
			pictureBox3.Image = Properties.Resources.woman;
			pictureBox3.Location = new Point(264, 287);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(45, 38);
			pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox3.TabIndex = 19;
			pictureBox3.TabStop = false;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(114, 290);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(41, 29);
			pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox2.TabIndex = 7;
			pictureBox2.TabStop = false;
			// 
			// rFemale
			// 
			rFemale.AutoSize = true;
			rFemale.FlatStyle = FlatStyle.Flat;
			rFemale.Location = new Point(161, 287);
			rFemale.Name = "rFemale";
			rFemale.Size = new Size(97, 32);
			rFemale.TabIndex = 18;
			rFemale.TabStop = true;
			rFemale.Text = "Female";
			rFemale.UseVisualStyleBackColor = true;
			rFemale.CheckedChanged += rFemale_CheckedChanged;
			// 
			// rMale
			// 
			rMale.AutoSize = true;
			rMale.Checked = true;
			rMale.FlatStyle = FlatStyle.Flat;
			rMale.Location = new Point(32, 287);
			rMale.Name = "rMale";
			rMale.Size = new Size(76, 32);
			rMale.TabIndex = 17;
			rMale.TabStop = true;
			rMale.Text = "Male";
			rMale.UseVisualStyleBackColor = true;
			rMale.CheckedChanged += rMale_CheckedChanged;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(15, 246);
			label5.Name = "label5";
			label5.Size = new Size(77, 28);
			label5.TabIndex = 16;
			label5.Text = "Gender";
			label5.TextAlign = ContentAlignment.TopCenter;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(15, 171);
			label3.Name = "label3";
			label3.Size = new Size(55, 28);
			label3.TabIndex = 13;
			label3.Text = "Date";
			// 
			// textSname
			// 
			textSname.BackColor = Color.White;
			textSname.ForeColor = Color.FromArgb(84, 110, 128);
			textSname.Location = new Point(45, 124);
			textSname.Name = "textSname";
			textSname.Size = new Size(269, 34);
			textSname.TabIndex = 10;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(15, 93);
			label4.Name = "label4";
			label4.Size = new Size(93, 28);
			label4.TabIndex = 11;
			label4.Text = "Surname";
			// 
			// textName
			// 
			textName.BackColor = Color.White;
			textName.ForeColor = Color.FromArgb(84, 110, 128);
			textName.Location = new Point(45, 47);
			textName.Name = "textName";
			textName.Size = new Size(269, 34);
			textName.TabIndex = 7;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(15, 16);
			label2.Name = "label2";
			label2.Size = new Size(66, 28);
			label2.TabIndex = 7;
			label2.Text = "Name";
			// 
			// groupBox2
			// 
			groupBox2.BackColor = Color.White;
			groupBox2.Controls.Add(btnUploadPic);
			groupBox2.Controls.Add(picBox);
			groupBox2.Controls.Add(label6);
			groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			groupBox2.ForeColor = Color.FromArgb(84, 110, 128);
			groupBox2.Location = new Point(367, 67);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(256, 325);
			groupBox2.TabIndex = 6;
			groupBox2.TabStop = false;
			// 
			// btnUploadPic
			// 
			btnUploadPic.AutoSize = true;
			btnUploadPic.BackColor = Color.Turquoise;
			btnUploadPic.Cursor = Cursors.Hand;
			btnUploadPic.FlatAppearance.BorderSize = 0;
			btnUploadPic.FlatStyle = FlatStyle.Flat;
			btnUploadPic.ForeColor = Color.White;
			btnUploadPic.Location = new Point(15, 271);
			btnUploadPic.Margin = new Padding(4, 5, 4, 5);
			btnUploadPic.Name = "btnUploadPic";
			btnUploadPic.Size = new Size(218, 48);
			btnUploadPic.TabIndex = 7;
			btnUploadPic.Text = "UPLOAD";
			btnUploadPic.UseVisualStyleBackColor = false;
			btnUploadPic.Click += btnUploadPic_Click;
			// 
			// picBox
			// 
			picBox.Image = (Image)resources.GetObject("picBox.Image");
			picBox.Location = new Point(15, 68);
			picBox.Name = "picBox";
			picBox.Size = new Size(218, 189);
			picBox.SizeMode = PictureBoxSizeMode.Zoom;
			picBox.TabIndex = 10;
			picBox.TabStop = false;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(15, 16);
			label6.Name = "label6";
			label6.Size = new Size(65, 28);
			label6.TabIndex = 9;
			label6.Text = "Photo";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
			label8.Location = new Point(443, 403);
			label8.Name = "label8";
			label8.Size = new Size(157, 23);
			label8.TabIndex = 9;
			label8.Text = "Max 300 Character";
			// 
			// btnSubmit
			// 
			btnSubmit.AutoSize = true;
			btnSubmit.BackColor = Color.Turquoise;
			btnSubmit.Cursor = Cursors.Hand;
			btnSubmit.Dock = DockStyle.Bottom;
			btnSubmit.FlatAppearance.BorderSize = 0;
			btnSubmit.FlatStyle = FlatStyle.Flat;
			btnSubmit.ForeColor = Color.White;
			btnSubmit.Location = new Point(0, 702);
			btnSubmit.Margin = new Padding(4, 5, 4, 5);
			btnSubmit.Name = "btnSubmit";
			btnSubmit.Size = new Size(638, 48);
			btnSubmit.TabIndex = 8;
			btnSubmit.Text = "SUBMIT";
			btnSubmit.UseVisualStyleBackColor = false;
			btnSubmit.Click += btnSubmit_Click;
			// 
			// lblMaxBioSize
			// 
			lblMaxBioSize.AutoSize = true;
			lblMaxBioSize.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
			lblMaxBioSize.Location = new Point(585, 671);
			lblMaxBioSize.Name = "lblMaxBioSize";
			lblMaxBioSize.RightToLeft = RightToLeft.Yes;
			lblMaxBioSize.Size = new Size(38, 23);
			lblMaxBioSize.TabIndex = 11;
			lblMaxBioSize.Text = "300";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(12, 395);
			label9.Name = "label9";
			label9.Size = new Size(121, 31);
			label9.TabIndex = 10;
			label9.Text = "Biography";
			// 
			// rBio
			// 
			rBio.ForeColor = Color.FromArgb(84, 110, 128);
			rBio.Location = new Point(12, 429);
			rBio.MaxLength = 300;
			rBio.Name = "rBio";
			rBio.Size = new Size(623, 265);
			rBio.TabIndex = 11;
			rBio.Text = "";
			rBio.TextChanged += rBio_TextChanged;
			// 
			// FormDirectorReg
			// 
			AutoScaleDimensions = new SizeF(13F, 31F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(638, 750);
			Controls.Add(lblMaxBioSize);
			Controls.Add(rBio);
			Controls.Add(label8);
			Controls.Add(label9);
			Controls.Add(btnSubmit);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Controls.Add(panel1);
			Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			ForeColor = Color.FromArgb(84, 110, 128);
			FormBorderStyle = FormBorderStyle.None;
			Location = new Point(600, 110);
			Margin = new Padding(5);
			Name = "FormDirectorReg";
			StartPosition = FormStartPosition.Manual;
			Text = "FormDirectorReg";
			panel1.ResumeLayout(false);
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)numYear).EndInit();
			((System.ComponentModel.ISupportInitialize)numMonth).EndInit();
			((System.ComponentModel.ISupportInitialize)numDay).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)picBox).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private Label label1;
		private GroupBox groupBox1;
		private GroupBox groupBox2;
		private Label label2;
		private TextBox textSname;
		private Label label4;
		private TextBox textName;
		private Label label3;
		private Label label5;
		private RadioButton rFemale;
		private RadioButton rMale;
		private PictureBox picBox;
		private Label label6;
		private PictureBox pictureBox3;
		private PictureBox pictureBox2;
		private Button btnUploadPic;
		private Label label8;
		private Button btnSubmit;
		private NumericUpDown numYear;
		private NumericUpDown numMonth;
		private NumericUpDown numDay;
		private Label lblMaxBioSize;
		private Label label9;
		private RichTextBox rBio;
		private DevExpress.XtraEditors.SimpleButton btnExit;
	}
}