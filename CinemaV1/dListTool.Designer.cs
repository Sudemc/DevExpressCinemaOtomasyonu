namespace CinemaV1
{
	partial class dListTool
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
			pictureBoxDirector = new PictureBox();
			lblDirectorName = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBoxDirector).BeginInit();
			SuspendLayout();
			// 
			// pictureBoxDirector
			// 
			pictureBoxDirector.Image = Properties.Resources.plus;
			pictureBoxDirector.Location = new Point(0, 1);
			pictureBoxDirector.Name = "pictureBoxDirector";
			pictureBoxDirector.Size = new Size(36, 32);
			pictureBoxDirector.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBoxDirector.TabIndex = 0;
			pictureBoxDirector.TabStop = false;
			// 
			// lblDirectorName
			// 
			lblDirectorName.AutoSize = true;
			lblDirectorName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
			lblDirectorName.ForeColor = Color.FromArgb(17, 28, 43);
			lblDirectorName.Location = new Point(42, 1);
			lblDirectorName.Name = "lblDirectorName";
			lblDirectorName.Size = new Size(110, 23);
			lblDirectorName.TabIndex = 1;
			lblDirectorName.Text = "labelDirector";
			lblDirectorName.Click += lblName_Click;
			lblDirectorName.MouseLeave += lblName_MouseLeave;
			lblDirectorName.MouseMove += lblName_MouseMove;
			// 
			// dListTool
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(lblDirectorName);
			Controls.Add(pictureBoxDirector);
			Name = "dListTool";
			Size = new Size(204, 33);
			Load += dListTool_Load;
			((System.ComponentModel.ISupportInitialize)pictureBoxDirector).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		public Label lblDirectorName;
		public PictureBox pictureBoxDirector;
	}
}
