namespace CinemaV1
{
	partial class ActorList
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActorList));
			buttonDelete = new Button();
			pictureGenderBox = new PictureBox();
			lblGenderInt = new Label();
			btnDetail = new Button();
			labelID = new Label();
			pictureBoxList = new PictureBox();
			lblName = new Label();
			panel1 = new Panel();
			pictureBox1 = new PictureBox();
			((System.ComponentModel.ISupportInitialize)pictureGenderBox).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxList).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
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
			buttonDelete.TabIndex = 20;
			buttonDelete.Text = "DELETE";
			buttonDelete.UseVisualStyleBackColor = false;
			buttonDelete.Click += buttonDelete_Click;
			// 
			// pictureGenderBox
			// 
			pictureGenderBox.BackColor = Color.FromArgb(24, 24, 24);
			pictureGenderBox.Image = (Image)resources.GetObject("pictureGenderBox.Image");
			pictureGenderBox.Location = new Point(134, 7);
			pictureGenderBox.Name = "pictureGenderBox";
			pictureGenderBox.Size = new Size(37, 24);
			pictureGenderBox.SizeMode = PictureBoxSizeMode.Zoom;
			pictureGenderBox.TabIndex = 19;
			pictureGenderBox.TabStop = false;
			// 
			// lblGenderInt
			// 
			lblGenderInt.AutoSize = true;
			lblGenderInt.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			lblGenderInt.ForeColor = Color.FromArgb(84, 110, 128);
			lblGenderInt.Location = new Point(293, 7);
			lblGenderInt.Name = "lblGenderInt";
			lblGenderInt.Size = new Size(66, 31);
			lblGenderInt.TabIndex = 18;
			lblGenderInt.Text = "label";
			lblGenderInt.Visible = false;
			lblGenderInt.Click += lblGenderInt_Click;
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
			btnDetail.TabIndex = 17;
			btnDetail.Text = "DETAIL";
			btnDetail.UseVisualStyleBackColor = false;
			btnDetail.Click += btnDetail_Click;
			// 
			// labelID
			// 
			labelID.AutoSize = true;
			labelID.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			labelID.ForeColor = Color.FromArgb(84, 110, 128);
			labelID.Location = new Point(123, 75);
			labelID.Name = "labelID";
			labelID.Size = new Size(66, 31);
			labelID.TabIndex = 16;
			labelID.Text = "label";
			labelID.Visible = false;
			labelID.Click += labelID_Click;
			// 
			// pictureBoxList
			// 
			pictureBoxList.Image = (Image)resources.GetObject("pictureBoxList.Image");
			pictureBoxList.Location = new Point(16, 3);
			pictureBoxList.Name = "pictureBoxList";
			pictureBoxList.Size = new Size(101, 103);
			pictureBoxList.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBoxList.TabIndex = 15;
			pictureBoxList.TabStop = false;
			// 
			// lblName
			// 
			lblName.AutoSize = true;
			lblName.BackColor = Color.FromArgb(24, 24, 24);
			lblName.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			lblName.ForeColor = Color.FromArgb(84, 110, 128);
			lblName.Location = new Point(177, 3);
			lblName.Name = "lblName";
			lblName.Size = new Size(66, 31);
			lblName.TabIndex = 14;
			lblName.Text = "label";
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(45, 45, 45);
			panel1.Dock = DockStyle.Left;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(10, 110);
			panel1.TabIndex = 13;
			// 
			// pictureBox1
			// 
			pictureBox1.Dock = DockStyle.Fill;
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(0, 0);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(560, 110);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 21;
			pictureBox1.TabStop = false;
			pictureBox1.Click += pictureBox1_Click;
			// 
			// ActorList
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(24, 24, 24);
			Controls.Add(buttonDelete);
			Controls.Add(pictureGenderBox);
			Controls.Add(btnDetail);
			Controls.Add(labelID);
			Controls.Add(pictureBoxList);
			Controls.Add(lblName);
			Controls.Add(panel1);
			Controls.Add(pictureBox1);
			Controls.Add(lblGenderInt);
			Name = "ActorList";
			Size = new Size(560, 110);
			Load += ActorList_Load;
			((System.ComponentModel.ISupportInitialize)pictureGenderBox).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxList).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button buttonDelete;
		private PictureBox pictureGenderBox;
		public Label lblGenderInt;
		private Button btnDetail;
		public Label labelID;
		public PictureBox pictureBoxList;
		public Label lblName;
		private Panel panel1;
		private PictureBox pictureBox1;
	}
}
