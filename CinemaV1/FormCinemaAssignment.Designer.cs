namespace CinemaV1
{
	partial class FormCinemaAssignment
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCinemaAssignment));
			panel1 = new Panel();
			btnExit = new DevExpress.XtraEditors.SimpleButton();
			label1 = new Label();
			comboBoxMovieName = new ComboBox();
			btnUploadPic = new Button();
			groupBox7 = new GroupBox();
			cbMovieTheater = new ComboBox();
			lblSelected = new Label();
			groupBox6 = new GroupBox();
			lblSession = new Label();
			flowPanelSession = new FlowLayoutPanel();
			groupBox5 = new GroupBox();
			nYear = new NumericUpDown();
			nMonth = new NumericUpDown();
			nDay = new NumericUpDown();
			label2 = new Label();
			groupBox4 = new GroupBox();
			groupBox1 = new GroupBox();
			cbFullSession = new ComboBox();
			textBox1 = new TextBox();
			pictureBox1 = new PictureBox();
			panel1.SuspendLayout();
			groupBox7.SuspendLayout();
			groupBox6.SuspendLayout();
			groupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)nYear).BeginInit();
			((System.ComponentModel.ISupportInitialize)nMonth).BeginInit();
			((System.ComponentModel.ISupportInitialize)nDay).BeginInit();
			groupBox4.SuspendLayout();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
			panel1.Size = new Size(677, 48);
			panel1.TabIndex = 7;
			// 
			// btnExit
			// 
			btnExit.Dock = DockStyle.Right;
			btnExit.ImageOptions.Image = (Image)resources.GetObject("btnExit.ImageOptions.Image");
			btnExit.Location = new Point(641, 0);
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
			label1.Text = "Cinema Assignment";
			// 
			// comboBoxMovieName
			// 
			comboBoxMovieName.BackColor = Color.FromArgb(24, 24, 24);
			comboBoxMovieName.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBoxMovieName.FlatStyle = FlatStyle.Flat;
			comboBoxMovieName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
			comboBoxMovieName.ForeColor = Color.White;
			comboBoxMovieName.FormattingEnabled = true;
			comboBoxMovieName.Location = new Point(3, 24);
			comboBoxMovieName.Name = "comboBoxMovieName";
			comboBoxMovieName.Size = new Size(304, 28);
			comboBoxMovieName.TabIndex = 1;
			// 
			// btnUploadPic
			// 
			btnUploadPic.AutoSize = true;
			btnUploadPic.BackColor = Color.FromArgb(90, 190, 240);
			btnUploadPic.Cursor = Cursors.Hand;
			btnUploadPic.FlatAppearance.BorderSize = 0;
			btnUploadPic.FlatStyle = FlatStyle.Flat;
			btnUploadPic.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btnUploadPic.ForeColor = Color.White;
			btnUploadPic.Location = new Point(13, 280);
			btnUploadPic.Margin = new Padding(4, 5, 4, 5);
			btnUploadPic.Name = "btnUploadPic";
			btnUploadPic.Size = new Size(313, 55);
			btnUploadPic.TabIndex = 23;
			btnUploadPic.Text = "COMPLETE";
			btnUploadPic.UseVisualStyleBackColor = false;
			btnUploadPic.Click += btnUploadPic_Click;
			// 
			// groupBox7
			// 
			groupBox7.BackColor = Color.FromArgb(24, 24, 24);
			groupBox7.Controls.Add(cbMovieTheater);
			groupBox7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			groupBox7.ForeColor = Color.White;
			groupBox7.Location = new Point(12, 135);
			groupBox7.Name = "groupBox7";
			groupBox7.Size = new Size(313, 58);
			groupBox7.TabIndex = 22;
			groupBox7.TabStop = false;
			groupBox7.Text = "Movie Theater";
			// 
			// cbMovieTheater
			// 
			cbMovieTheater.BackColor = Color.FromArgb(24, 24, 24);
			cbMovieTheater.DropDownStyle = ComboBoxStyle.DropDownList;
			cbMovieTheater.FlatStyle = FlatStyle.Flat;
			cbMovieTheater.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
			cbMovieTheater.ForeColor = Color.White;
			cbMovieTheater.FormattingEnabled = true;
			cbMovieTheater.Items.AddRange(new object[] { "" });
			cbMovieTheater.Location = new Point(6, 24);
			cbMovieTheater.Name = "cbMovieTheater";
			cbMovieTheater.Size = new Size(296, 28);
			cbMovieTheater.TabIndex = 20;
			// 
			// lblSelected
			// 
			lblSelected.AutoSize = true;
			lblSelected.Location = new Point(549, 358);
			lblSelected.Name = "lblSelected";
			lblSelected.Size = new Size(50, 20);
			lblSelected.TabIndex = 21;
			lblSelected.Text = "label3";
			lblSelected.Visible = false;
			// 
			// groupBox6
			// 
			groupBox6.BackColor = Color.FromArgb(24, 24, 24);
			groupBox6.Controls.Add(lblSession);
			groupBox6.Controls.Add(flowPanelSession);
			groupBox6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			groupBox6.ForeColor = Color.White;
			groupBox6.Location = new Point(334, 71);
			groupBox6.Name = "groupBox6";
			groupBox6.Size = new Size(337, 264);
			groupBox6.TabIndex = 21;
			groupBox6.TabStop = false;
			groupBox6.Text = "Session ";
			groupBox6.Enter += groupBox6_Enter;
			// 
			// lblSession
			// 
			lblSession.AutoSize = true;
			lblSession.Location = new Point(241, 0);
			lblSession.Name = "lblSession";
			lblSession.Size = new Size(66, 28);
			lblSession.TabIndex = 1;
			lblSession.Text = "label3";
			lblSession.Visible = false;
			// 
			// flowPanelSession
			// 
			flowPanelSession.AutoScroll = true;
			flowPanelSession.Dock = DockStyle.Fill;
			flowPanelSession.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
			flowPanelSession.Location = new Point(3, 30);
			flowPanelSession.Name = "flowPanelSession";
			flowPanelSession.Size = new Size(331, 231);
			flowPanelSession.TabIndex = 19;
			// 
			// groupBox5
			// 
			groupBox5.BackColor = Color.FromArgb(24, 24, 24);
			groupBox5.Controls.Add(nYear);
			groupBox5.Controls.Add(nMonth);
			groupBox5.Controls.Add(nDay);
			groupBox5.Controls.Add(label2);
			groupBox5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			groupBox5.ForeColor = Color.White;
			groupBox5.Location = new Point(12, 199);
			groupBox5.Name = "groupBox5";
			groupBox5.Size = new Size(316, 70);
			groupBox5.TabIndex = 20;
			groupBox5.TabStop = false;
			groupBox5.Text = "Date";
			// 
			// nYear
			// 
			nYear.BackColor = Color.FromArgb(24, 24, 24);
			nYear.BorderStyle = BorderStyle.None;
			nYear.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
			nYear.ForeColor = Color.White;
			nYear.ImeMode = ImeMode.Disable;
			nYear.Location = new Point(192, 33);
			nYear.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
			nYear.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
			nYear.Name = "nYear";
			nYear.Size = new Size(109, 26);
			nYear.TabIndex = 29;
			nYear.TextAlign = HorizontalAlignment.Center;
			nYear.Value = new decimal(new int[] { 2024, 0, 0, 0 });
			// 
			// nMonth
			// 
			nMonth.BackColor = Color.FromArgb(24, 24, 24);
			nMonth.BorderStyle = BorderStyle.None;
			nMonth.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
			nMonth.ForeColor = Color.White;
			nMonth.Location = new Point(94, 33);
			nMonth.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
			nMonth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			nMonth.Name = "nMonth";
			nMonth.Size = new Size(92, 26);
			nMonth.TabIndex = 28;
			nMonth.TextAlign = HorizontalAlignment.Center;
			nMonth.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// nDay
			// 
			nDay.BackColor = Color.FromArgb(24, 24, 24);
			nDay.BorderStyle = BorderStyle.None;
			nDay.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
			nDay.ForeColor = Color.White;
			nDay.Location = new Point(11, 33);
			nDay.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
			nDay.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			nDay.Name = "nDay";
			nDay.Size = new Size(77, 26);
			nDay.TabIndex = 27;
			nDay.TextAlign = HorizontalAlignment.Center;
			nDay.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
			label2.Location = new Point(227, 0);
			label2.Name = "label2";
			label2.Size = new Size(75, 19);
			label2.TabIndex = 18;
			label2.Text = "dd/mm/yy";
			// 
			// groupBox4
			// 
			groupBox4.BackColor = Color.FromArgb(24, 24, 24);
			groupBox4.Controls.Add(comboBoxMovieName);
			groupBox4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			groupBox4.ForeColor = Color.White;
			groupBox4.Location = new Point(9, 71);
			groupBox4.Name = "groupBox4";
			groupBox4.Size = new Size(316, 58);
			groupBox4.TabIndex = 19;
			groupBox4.TabStop = false;
			groupBox4.Text = "Movie Name";
			// 
			// groupBox1
			// 
			groupBox1.BackColor = Color.White;
			groupBox1.Controls.Add(cbFullSession);
			groupBox1.Controls.Add(textBox1);
			groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			groupBox1.ForeColor = Color.FromArgb(84, 110, 128);
			groupBox1.Location = new Point(23, 354);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(316, 61);
			groupBox1.TabIndex = 24;
			groupBox1.TabStop = false;
			groupBox1.Text = "Full Sessions";
			groupBox1.Visible = false;
			// 
			// cbFullSession
			// 
			cbFullSession.DropDownStyle = ComboBoxStyle.DropDownList;
			cbFullSession.FlatStyle = FlatStyle.Flat;
			cbFullSession.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
			cbFullSession.ForeColor = SystemColors.HotTrack;
			cbFullSession.FormattingEnabled = true;
			cbFullSession.Location = new Point(6, 24);
			cbFullSession.Name = "cbFullSession";
			cbFullSession.Size = new Size(304, 28);
			cbFullSession.TabIndex = 1;
			// 
			// textBox1
			// 
			textBox1.BorderStyle = BorderStyle.None;
			textBox1.Dock = DockStyle.Bottom;
			textBox1.ForeColor = Color.FromArgb(84, 110, 128);
			textBox1.Location = new Point(3, 31);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(310, 27);
			textBox1.TabIndex = 0;
			// 
			// pictureBox1
			// 
			pictureBox1.Dock = DockStyle.Fill;
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(0, 0);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(677, 344);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 26;
			pictureBox1.TabStop = false;
			// 
			// FormCinemaAssignment
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(677, 344);
			Controls.Add(lblSelected);
			Controls.Add(groupBox4);
			Controls.Add(groupBox1);
			Controls.Add(btnUploadPic);
			Controls.Add(groupBox7);
			Controls.Add(groupBox6);
			Controls.Add(groupBox5);
			Controls.Add(panel1);
			Controls.Add(pictureBox1);
			FormBorderStyle = FormBorderStyle.None;
			Location = new Point(730, 350);
			Name = "FormCinemaAssignment";
			StartPosition = FormStartPosition.Manual;
			Text = "FormCinemaAssignment";
			Load += FormCinemaAssignment_Load;
			panel1.ResumeLayout(false);
			groupBox7.ResumeLayout(false);
			groupBox6.ResumeLayout(false);
			groupBox6.PerformLayout();
			groupBox5.ResumeLayout(false);
			groupBox5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)nYear).EndInit();
			((System.ComponentModel.ISupportInitialize)nMonth).EndInit();
			((System.ComponentModel.ISupportInitialize)nDay).EndInit();
			groupBox4.ResumeLayout(false);
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private Label label1;
		private ComboBox comboBoxMovieName;
		private Button btnUploadPic;
		private GroupBox groupBox7;
		private Label lblSelected;
		private ComboBox cbMovieTheater;
		private GroupBox groupBox6;
		private Label lblSession;
		private FlowLayoutPanel flowPanelSession;
		private GroupBox groupBox5;
		private Label label2;
		private GroupBox groupBox4;
		private NumericUpDown nYear;
		private NumericUpDown nMonth;
		private NumericUpDown nDay;
		private GroupBox groupBox1;
		private ComboBox cbFullSession;
		public TextBox textBox1;
		private PictureBox pictureBox1;
		private DevExpress.XtraEditors.SimpleButton btnExit;
	}
}