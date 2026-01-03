namespace CinemaV1
{
	partial class CinemaList
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
			panel1 = new Panel();
			pictureBox1 = new PictureBox();
			lblCinemaName = new Label();
			lblSeatNumber = new Label();
			buttonDelete = new Button();
			labelID = new Label();
			label1 = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(192, 255, 192);
			panel1.Dock = DockStyle.Left;
			panel1.ForeColor = Color.FromArgb(84, 110, 128);
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(11, 104);
			panel1.TabIndex = 0;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.pngtree_beautiful_cinema_hall_line_vector_icon_png_image_1990506;
			pictureBox1.Location = new Point(12, 3);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(106, 101);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 1;
			pictureBox1.TabStop = false;
			// 
			// lblCinemaName
			// 
			lblCinemaName.AutoSize = true;
			lblCinemaName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lblCinemaName.ForeColor = Color.FromArgb(255, 128, 0);
			lblCinemaName.Location = new Point(143, 3);
			lblCinemaName.Name = "lblCinemaName";
			lblCinemaName.Size = new Size(64, 28);
			lblCinemaName.TabIndex = 2;
			lblCinemaName.Text = "label1";
			// 
			// lblSeatNumber
			// 
			lblSeatNumber.AutoSize = true;
			lblSeatNumber.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lblSeatNumber.ForeColor = Color.FromArgb(255, 128, 0);
			lblSeatNumber.Location = new Point(213, 66);
			lblSeatNumber.Name = "lblSeatNumber";
			lblSeatNumber.Size = new Size(66, 28);
			lblSeatNumber.TabIndex = 3;
			lblSeatNumber.Text = "label2";
			// 
			// buttonDelete
			// 
			buttonDelete.BackColor = Color.FromArgb(84, 110, 128);
			buttonDelete.Cursor = Cursors.Hand;
			buttonDelete.FlatAppearance.BorderSize = 0;
			buttonDelete.FlatStyle = FlatStyle.Flat;
			buttonDelete.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.World);
			buttonDelete.ForeColor = Color.White;
			buttonDelete.Location = new Point(247, 6);
			buttonDelete.Margin = new Padding(4, 5, 4, 5);
			buttonDelete.Name = "buttonDelete";
			buttonDelete.Size = new Size(34, 29);
			buttonDelete.TabIndex = 13;
			buttonDelete.Text = "DELETE(calýsmýyor)";
			buttonDelete.UseVisualStyleBackColor = false;
			buttonDelete.Visible = false;
			buttonDelete.Click += buttonDelete_Click;
			// 
			// labelID
			// 
			labelID.AutoSize = true;
			labelID.Location = new Point(288, 10);
			labelID.Name = "labelID";
			labelID.Size = new Size(22, 20);
			labelID.TabIndex = 14;
			labelID.Text = "ýd";
			labelID.Visible = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.FromArgb(255, 128, 0);
			label1.Location = new Point(145, 66);
			label1.Name = "label1";
			label1.Size = new Size(62, 28);
			label1.TabIndex = 15;
			label1.Text = "Size : ";
			// 
			// CinemaList
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Gainsboro;
			Controls.Add(label1);
			Controls.Add(labelID);
			Controls.Add(buttonDelete);
			Controls.Add(lblSeatNumber);
			Controls.Add(lblCinemaName);
			Controls.Add(pictureBox1);
			Controls.Add(panel1);
			Name = "CinemaList";
			Size = new Size(336, 104);
			MouseLeave += leave;
			MouseMove += move;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private PictureBox pictureBox1;
		public Label lblCinemaName;
		public Label lblSeatNumber;
		private Button buttonDelete;
		public Label labelID;
		public Label label1;
	}
}
