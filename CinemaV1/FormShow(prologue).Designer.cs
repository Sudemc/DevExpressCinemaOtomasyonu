namespace CinemaV1
{
	partial class FormShow_prologue_
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShow_prologue_));
			lblMovieename = new Label();
			svgImageBox1 = new DevExpress.XtraEditors.SvgImageBox();
			simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)svgImageBox1).BeginInit();
			SuspendLayout();
			// 
			// lblMovieename
			// 
			lblMovieename.AutoSize = true;
			lblMovieename.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
			lblMovieename.ForeColor = Color.White;
			lblMovieename.Location = new Point(-3, 220);
			lblMovieename.Name = "lblMovieename";
			lblMovieename.Size = new Size(406, 30);
			lblMovieename.TabIndex = 1;
			lblMovieename.Text = "The movie is in theaters today";
			lblMovieename.Click += lblMovieename_Click;
			// 
			// svgImageBox1
			// 
			svgImageBox1.Location = new Point(49, 12);
			svgImageBox1.Name = "svgImageBox1";
			svgImageBox1.Size = new Size(282, 190);
			svgImageBox1.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("svgImageBox1.SvgImage");
			svgImageBox1.TabIndex = 2;
			svgImageBox1.Text = "svgImageBox1";
			// 
			// simpleButton1
			// 
			simpleButton1.ImageOptions.Image = (Image)resources.GetObject("simpleButton1.ImageOptions.Image");
			simpleButton1.Location = new Point(146, 265);
			simpleButton1.Name = "simpleButton1";
			simpleButton1.Size = new Size(87, 36);
			simpleButton1.TabIndex = 3;
			simpleButton1.Text = "Okey";
			simpleButton1.Click += simpleButton1_Click;
			// 
			// FormShow_prologue_
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(24, 24, 24);
			ClientSize = new Size(392, 330);
			Controls.Add(simpleButton1);
			Controls.Add(svgImageBox1);
			Controls.Add(lblMovieename);
			FormBorderStyle = FormBorderStyle.None;
			Name = "FormShow_prologue_";
			Text = "FormShow_prologue_";
			((System.ComponentModel.ISupportInitialize)svgImageBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label lblMovieename;
		private DevExpress.XtraEditors.SvgImageBox svgImageBox1;
		private DevExpress.XtraEditors.SimpleButton simpleButton1;
	}
}