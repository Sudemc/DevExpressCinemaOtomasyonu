namespace CinemaV1
{
	partial class FormTicketQuery
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTicketQuery));
			panel1 = new Panel();
			label1 = new Label();
			button1 = new Button();
			txtTicketNoQuery = new TextBox();
			label2 = new Label();
			button2 = new Button();
			pictureBox1 = new PictureBox();
			gridControl1 = new DevExpress.XtraGrid.GridControl();
			gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
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
			panel1.Size = new Size(530, 48);
			panel1.TabIndex = 9;
			// 
			// label1
			// 
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.FromArgb(255, 193, 7);
			label1.Location = new Point(10, 5);
			label1.Name = "label1";
			label1.Size = new Size(279, 38);
			label1.TabIndex = 1;
			label1.Text = "Ticket Query Screen";
			// 
			// button1 - Exit button
			// 
			button1.AutoSize = true;
			button1.BackColor = Color.FromArgb(229, 9, 20);
			button1.Cursor = Cursors.Hand;
			button1.Dock = DockStyle.Right;
			button1.FlatAppearance.BorderSize = 0;
			button1.FlatStyle = FlatStyle.Flat;
			button1.ForeColor = Color.White;
			button1.Location = new Point(472, 0);
			button1.Margin = new Padding(4, 5, 4, 5);
			button1.Name = "button1";
			button1.Size = new Size(58, 48);
			button1.TabIndex = 3;
			button1.Text = "X";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// txtTicketNoQuery - Input field
			// 
			txtTicketNoQuery.BackColor = Color.FromArgb(58, 58, 58);
			txtTicketNoQuery.BorderStyle = BorderStyle.FixedSingle;
			txtTicketNoQuery.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtTicketNoQuery.ForeColor = Color.FromArgb(224, 224, 224);
			txtTicketNoQuery.Location = new Point(160, 88);
			txtTicketNoQuery.Name = "txtTicketNoQuery";
			txtTicketNoQuery.Size = new Size(232, 34);
			txtTicketNoQuery.TabIndex = 12;
			txtTicketNoQuery.TextChanged += txtTicketNoQuery_TextChanged;
			// 
			// label2 - Ticket No label
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.FromArgb(24, 24, 24);
			label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label2.ForeColor = Color.FromArgb(255, 193, 7);
			label2.Location = new Point(29, 91);
			label2.Name = "label2";
			label2.Size = new Size(107, 28);
			label2.TabIndex = 11;
			label2.Text = "Ticket No :";
			// 
			// button2 - Query button (Amber)
			// 
			button2.BackColor = Color.FromArgb(255, 193, 7);
			button2.Cursor = Cursors.Hand;
			button2.FlatAppearance.BorderSize = 0;
			button2.FlatStyle = FlatStyle.Flat;
			button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			button2.ForeColor = Color.FromArgb(24, 24, 24);
			button2.Location = new Point(160, 137);
			button2.Margin = new Padding(4, 5, 4, 5);
			button2.Name = "button2";
			button2.Size = new Size(232, 48);
			button2.TabIndex = 12;
			button2.Text = "Query";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// pictureBox1 - solid background (no animation)
			// 
			pictureBox1.Dock = DockStyle.Fill;
			pictureBox1.BackColor = Color.FromArgb(24, 24, 24);
			pictureBox1.Location = new Point(0, 0);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(530, 267);
			pictureBox1.TabIndex = 13;
			pictureBox1.TabStop = false;
			// 
			// gridControl1
			// 
			gridControl1.BackgroundImage = (Image)resources.GetObject("gridControl1.BackgroundImage");
			gridControl1.Location = new Point(408, 56);
			gridControl1.MainView = gridView1;
			gridControl1.Name = "gridControl1";
			gridControl1.Size = new Size(114, 185);
			gridControl1.TabIndex = 14;
			gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
			// 
			// gridView1
			// 
			gridView1.Appearance.ColumnFilterButton.BackColor = Color.FromArgb(24, 24, 24);
			gridView1.Appearance.ColumnFilterButton.BorderColor = Color.Black;
			gridView1.Appearance.ColumnFilterButton.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
			gridView1.Appearance.ColumnFilterButton.ForeColor = Color.Blue;
			gridView1.Appearance.ColumnFilterButton.Options.UseBackColor = true;
			gridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
			gridView1.Appearance.ColumnFilterButton.Options.UseFont = true;
			gridView1.Appearance.ColumnFilterButton.Options.UseForeColor = true;
			gridView1.Appearance.ColumnFilterButtonActive.BackColor = Color.FromArgb(24, 24, 24);
			gridView1.Appearance.ColumnFilterButtonActive.BorderColor = Color.Black;
			gridView1.Appearance.ColumnFilterButtonActive.ForeColor = Color.Cyan;
			gridView1.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
			gridView1.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
			gridView1.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
			gridView1.Appearance.Empty.BackColor = Color.FromArgb(24, 24, 24);
			gridView1.Appearance.Empty.BorderColor = Color.Black;
			gridView1.Appearance.Empty.ForeColor = Color.Aqua;
			gridView1.Appearance.Empty.Options.UseBackColor = true;
			gridView1.Appearance.Empty.Options.UseBorderColor = true;
			gridView1.Appearance.Empty.Options.UseForeColor = true;
			gridView1.Appearance.EvenRow.BackColor = Color.FromArgb(24, 24, 24);
			gridView1.Appearance.EvenRow.BorderColor = Color.Black;
			gridView1.Appearance.EvenRow.ForeColor = Color.Aqua;
			gridView1.Appearance.EvenRow.Options.UseBackColor = true;
			gridView1.Appearance.EvenRow.Options.UseBorderColor = true;
			gridView1.Appearance.EvenRow.Options.UseForeColor = true;
			gridView1.Appearance.FilterPanel.BackColor = Color.FromArgb(24, 24, 24);
			gridView1.Appearance.FilterPanel.BorderColor = Color.Black;
			gridView1.Appearance.FilterPanel.ForeColor = Color.Aqua;
			gridView1.Appearance.FilterPanel.Options.UseBackColor = true;
			gridView1.Appearance.FilterPanel.Options.UseBorderColor = true;
			gridView1.Appearance.FilterPanel.Options.UseForeColor = true;
			gridView1.Appearance.FixedLine.BackColor = Color.FromArgb(24, 24, 24);
			gridView1.Appearance.FixedLine.BorderColor = Color.Black;
			gridView1.Appearance.FixedLine.ForeColor = Color.Cyan;
			gridView1.Appearance.FixedLine.Options.UseBackColor = true;
			gridView1.Appearance.FixedLine.Options.UseBorderColor = true;
			gridView1.Appearance.FixedLine.Options.UseForeColor = true;
			gridView1.Appearance.FocusedRow.BackColor = Color.FromArgb(24, 24, 24);
			gridView1.Appearance.FocusedRow.BorderColor = Color.Black;
			gridView1.Appearance.FocusedRow.ForeColor = Color.Cyan;
			gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
			gridView1.Appearance.FocusedRow.Options.UseBorderColor = true;
			gridView1.Appearance.FocusedRow.Options.UseForeColor = true;
			gridView1.Appearance.FooterPanel.BackColor = Color.FromArgb(24, 24, 24);
			gridView1.Appearance.FooterPanel.BorderColor = Color.Black;
			gridView1.Appearance.FooterPanel.ForeColor = Color.Cyan;
			gridView1.Appearance.FooterPanel.Options.UseBackColor = true;
			gridView1.Appearance.FooterPanel.Options.UseBorderColor = true;
			gridView1.Appearance.FooterPanel.Options.UseForeColor = true;
			gridView1.Appearance.GroupFooter.BackColor = Color.FromArgb(24, 24, 24);
			gridView1.Appearance.GroupFooter.BorderColor = Color.Black;
			gridView1.Appearance.GroupFooter.ForeColor = Color.Blue;
			gridView1.Appearance.GroupFooter.Options.UseBackColor = true;
			gridView1.Appearance.GroupFooter.Options.UseBorderColor = true;
			gridView1.Appearance.GroupFooter.Options.UseForeColor = true;
			gridView1.Appearance.GroupPanel.BackColor = Color.FromArgb(24, 24, 24);
			gridView1.Appearance.GroupPanel.BorderColor = Color.Black;
			gridView1.Appearance.GroupPanel.Options.UseBackColor = true;
			gridView1.Appearance.GroupPanel.Options.UseBorderColor = true;
			gridView1.Appearance.GroupRow.BackColor = Color.FromArgb(24, 24, 24);
			gridView1.Appearance.GroupRow.BorderColor = Color.Black;
			gridView1.Appearance.GroupRow.ForeColor = Color.Blue;
			gridView1.Appearance.GroupRow.Options.UseBackColor = true;
			gridView1.Appearance.GroupRow.Options.UseBorderColor = true;
			gridView1.Appearance.GroupRow.Options.UseForeColor = true;
			gridView1.Appearance.HeaderPanel.BackColor = Color.FromArgb(24, 24, 24);
			gridView1.Appearance.HeaderPanel.BorderColor = Color.Black;
			gridView1.Appearance.HeaderPanel.ForeColor = Color.Cyan;
			gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
			gridView1.Appearance.HeaderPanel.Options.UseBorderColor = true;
			gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
			gridView1.Appearance.HorzLine.BackColor = Color.FromArgb(24, 24, 24);
			gridView1.Appearance.HorzLine.BorderColor = Color.Black;
			gridView1.Appearance.HorzLine.ForeColor = Color.Aqua;
			gridView1.Appearance.HorzLine.Options.UseBackColor = true;
			gridView1.Appearance.HorzLine.Options.UseBorderColor = true;
			gridView1.Appearance.HorzLine.Options.UseForeColor = true;
			gridView1.Appearance.Preview.BackColor = Color.FromArgb(24, 24, 24);
			gridView1.Appearance.Preview.BorderColor = Color.Black;
			gridView1.Appearance.Preview.ForeColor = Color.Aqua;
			gridView1.Appearance.Preview.Options.UseBackColor = true;
			gridView1.Appearance.Preview.Options.UseBorderColor = true;
			gridView1.Appearance.Preview.Options.UseForeColor = true;
			gridView1.Appearance.Row.BackColor = Color.FromArgb(24, 24, 24);
			gridView1.Appearance.Row.BorderColor = Color.Black;
			gridView1.Appearance.Row.ForeColor = Color.Aqua;
			gridView1.Appearance.Row.Options.UseBackColor = true;
			gridView1.Appearance.Row.Options.UseBorderColor = true;
			gridView1.Appearance.Row.Options.UseForeColor = true;
			gridView1.Appearance.ViewCaption.BackColor = Color.FromArgb(24, 24, 24);
			gridView1.Appearance.ViewCaption.BorderColor = Color.Black;
			gridView1.Appearance.ViewCaption.ForeColor = Color.Cyan;
			gridView1.Appearance.ViewCaption.Options.UseBackColor = true;
			gridView1.Appearance.ViewCaption.Options.UseBorderColor = true;
			gridView1.Appearance.ViewCaption.Options.UseForeColor = true;
			gridView1.AppearancePrint.EvenRow.BackColor = Color.FromArgb(24, 24, 24);
			gridView1.AppearancePrint.EvenRow.BorderColor = Color.Black;
			gridView1.AppearancePrint.EvenRow.ForeColor = Color.Aqua;
			gridView1.AppearancePrint.EvenRow.Options.UseBackColor = true;
			gridView1.AppearancePrint.EvenRow.Options.UseBorderColor = true;
			gridView1.AppearancePrint.EvenRow.Options.UseForeColor = true;
			gridView1.GridControl = gridControl1;
			gridView1.Name = "gridView1";
			gridView1.OptionsPrint.EnableAppearanceEvenRow = true;
			gridView1.OptionsView.ShowGroupPanel = false;
			// 
			// FormTicketQuery
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(530, 267);
			Controls.Add(gridControl1);
			Controls.Add(button2);
			Controls.Add(label2);
			Controls.Add(txtTicketNoQuery);
			Controls.Add(panel1);
			Controls.Add(pictureBox1);
			FormBorderStyle = FormBorderStyle.None;
			Location = new Point(730, 350);
			Name = "FormTicketQuery";
			StartPosition = FormStartPosition.Manual;
			Text = "FormTicketQuery";
			Load += FormTicketQuery_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private Label label1;
		private Button button1;
		private TextBox txtTicketNoQuery;
		private Label label2;
		private Button button2;
		private PictureBox pictureBox1;
		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
	}
}