namespace CinemaV1
{
	partial class DirectorList
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectorList));
			panel1 = new Panel();
			lblName = new Label();
			pictureBoxList = new PictureBox();
			labelID = new Label();
			btnDetail = new Button();
			lblGenderInt = new Label();
			pictureGenderBox = new PictureBox();
			buttonDelete = new Button();
			pictureBox1 = new PictureBox();
			((System.ComponentModel.ISupportInitialize)pictureBoxList).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureGenderBox).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(45, 45, 45);
			panel1.Dock = DockStyle.Left;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(10, 110);
			panel1.TabIndex = 0;
			// 
			// lblName
			// 
			lblName.AutoSize = true;
			lblName.BackColor = Color.Transparent;
			lblName.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			lblName.ForeColor = Color.FromArgb(200, 200, 200);
			lblName.Location = new Point(166, 3);
			lblName.Name = "lblName";
			lblName.Size = new Size(66, 31);
			lblName.TabIndex = 1;
			lblName.Text = "label";
			// 
			// pictureBoxList
			// 
			pictureBoxList.Image = (Image)resources.GetObject("pictureBoxList.Image");
			pictureBoxList.Location = new Point(16, 3);
			pictureBoxList.Name = "pictureBoxList";
			pictureBoxList.Size = new Size(101, 103);
			pictureBoxList.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBoxList.TabIndex = 2;
			pictureBoxList.TabStop = false;
			// 
			// labelID
			// 
			labelID.AutoSize = true;
			labelID.BackColor = Color.Transparent;
			labelID.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			labelID.ForeColor = Color.FromArgb(160, 160, 160);
			labelID.Location = new Point(166, 75);
			labelID.Name = "labelID";
			labelID.Size = new Size(66, 31);
			labelID.TabIndex = 3;
			labelID.Text = "label";
			labelID.Visible = false;
			labelID.Click += labelID_Click;
			// 
			// btnDetail
			// 
			btnDetail.BackColor = Color.FromArgb(255, 193, 7);
			btnDetail.Cursor = Cursors.Hand;
			btnDetail.FlatAppearance.BorderSize = 0;
			btnDetail.FlatStyle = FlatStyle.Flat;
			btnDetail.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
			btnDetail.ForeColor = Color.FromArgb(24, 24, 24);
			btnDetail.Location = new Point(340, 60);
			btnDetail.Margin = new Padding(4, 5, 4, 5);
			btnDetail.Name = "btnDetail";
			btnDetail.Size = new Size(95, 40);
			btnDetail.TabIndex = 8;
			btnDetail.Text = "DETAIL";
			btnDetail.UseVisualStyleBackColor = false;
			btnDetail.Click += btnDetail_Click;
			// 
			// lblGenderInt
			// 
			lblGenderInt.AutoSize = true;
			lblGenderInt.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			lblGenderInt.ForeColor = Color.FromArgb(84, 110, 128);
			lblGenderInt.Location = new Point(432, 0);
			lblGenderInt.Name = "lblGenderInt";
			lblGenderInt.Size = new Size(66, 31);
			lblGenderInt.TabIndex = 10;
			lblGenderInt.Text = "label";
			lblGenderInt.Visible = false;
			lblGenderInt.Click += lblGenderInt_Click;
			// 
			// pictureGenderBox
			// 
			pictureGenderBox.BackColor = Color.FromArgb(24, 24, 24);
			pictureGenderBox.Image = (Image)resources.GetObject("pictureGenderBox.Image");
			pictureGenderBox.Location = new Point(123, 7);
			pictureGenderBox.Name = "pictureGenderBox";
			pictureGenderBox.Size = new Size(37, 24);
			pictureGenderBox.SizeMode = PictureBoxSizeMode.Zoom;
			pictureGenderBox.TabIndex = 11;
			pictureGenderBox.TabStop = false;
			// 
			// buttonDelete
			// 
			buttonDelete.BackColor = Color.FromArgb(229, 9, 20);
			buttonDelete.Cursor = Cursors.Hand;
			buttonDelete.FlatAppearance.BorderSize = 0;
			buttonDelete.FlatStyle = FlatStyle.Flat;
			buttonDelete.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
			buttonDelete.ForeColor = Color.White;
			buttonDelete.Location = new Point(445, 60);
			buttonDelete.Margin = new Padding(4, 5, 4, 5);
			buttonDelete.Name = "buttonDelete";
			buttonDelete.Size = new Size(100, 40);
			buttonDelete.TabIndex = 12;
			buttonDelete.Text = "DELETE";
			buttonDelete.UseVisualStyleBackColor = false;
			buttonDelete.Click += buttonDelete_Click;
			// 
			// pictureBox1 - solid background (no animation)
			// 
			pictureBox1.Dock = DockStyle.Fill;
			pictureBox1.BackColor = Color.FromArgb(35, 35, 35);
			pictureBox1.Location = new Point(0, 0);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(560, 110);
			pictureBox1.TabIndex = 13;
			pictureBox1.TabStop = false;
			// 
			// DirectorList
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(24, 24, 24);
			Controls.Add(buttonDelete);
			Controls.Add(pictureGenderBox);
			Controls.Add(lblGenderInt);
			Controls.Add(btnDetail);
			Controls.Add(labelID);
			Controls.Add(pictureBoxList);
			Controls.Add(lblName);
			Controls.Add(panel1);
			Controls.Add(pictureBox1);
			Name = "DirectorList";
			Size = new Size(560, 110);
			Load += DirectorRegister_Load;
			((System.ComponentModel.ISupportInitialize)pictureBoxList).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureGenderBox).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		public Label lblName;
		public Label labelID;
		public PictureBox pictureBoxList;
		private Button btnDetail;
		public Label lblGenderInt;
		private PictureBox pictureGenderBox;
		private Button buttonDelete;
		private PictureBox pictureBox1;
	}
}
