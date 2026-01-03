namespace CinemaV1
{
	partial class FormTrailer
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTrailer));
			panel1 = new Panel();
			btnExit = new DevExpress.XtraEditors.SimpleButton();
			webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
			lblCheck = new Label();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Controls.Add(btnExit);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(1365, 46);
			panel1.TabIndex = 5;
			// 
			// btnExit
			// 
			btnExit.Dock = DockStyle.Right;
			//btnExit.ImageOptions.Image = (Image)resources.GetObject("btnExit.ImageOptions.Image");
			btnExit.Location = new Point(1329, 0);
			btnExit.Name = "btnExit";
			btnExit.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
			btnExit.Size = new Size(36, 46);
			btnExit.TabIndex = 5;
			btnExit.Text = "X";
			btnExit.Click += btnExit_Click;
			// 
			// webView21
			// 
			webView21.AllowExternalDrop = true;
			webView21.CreationProperties = null;
			webView21.DefaultBackgroundColor = Color.Black;
			webView21.Dock = DockStyle.Fill;
			webView21.Location = new Point(0, 46);
			webView21.Name = "webView21";
			webView21.Size = new Size(1365, 636);
			webView21.TabIndex = 6;
			webView21.ZoomFactor = 1D;
			// 
			// lblCheck
			// 
			lblCheck.AutoSize = true;
			lblCheck.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
			lblCheck.Location = new Point(100, 100);
			lblCheck.Name = "lblCheck";
			lblCheck.Size = new Size(400, 54);
			lblCheck.TabIndex = 1;
			lblCheck.Text = "Loading video...";
			lblCheck.Visible = false;
			// 
			// FormTrailer
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1365, 682);
			Controls.Add(webView21);
			Controls.Add(panel1);
			Controls.Add(lblCheck);
			FormBorderStyle = FormBorderStyle.None;
			Name = "FormTrailer";
			Text = "trailer";
			Load += Trailer_Load;
			panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)webView21).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private DevExpress.XtraEditors.SimpleButton btnExit;
		private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
		private Label lblCheck;
	}
}