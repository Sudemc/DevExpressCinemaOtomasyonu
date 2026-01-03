namespace CinemaV1
{
	partial class aListTool
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
			lblName = new Label();
			pictureBox1 = new PictureBox();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// lblName
			// 
			lblName.AutoSize = true;
			lblName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
			lblName.ForeColor = Color.FromArgb(17, 28, 43);
			lblName.Location = new Point(42, 1);
			lblName.Name = "lblName";
			lblName.Size = new Size(56, 23);
			lblName.TabIndex = 3;
			lblName.Text = "label1";
			lblName.Click += lblName_Click;
			lblName.MouseLeave += lblName_MouseLeave;
			lblName.MouseMove += lblName_MouseMove;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.plus1;
			pictureBox1.Location = new Point(0, 1);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(36, 32);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 2;
			pictureBox1.TabStop = false;
			// 
			// aListTool
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(lblName);
			Controls.Add(pictureBox1);
			Name = "aListTool";
			Size = new Size(204, 33);
			Load += aListTool_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private PictureBox pictureBox1;
		public Label lblName;
	}
}
