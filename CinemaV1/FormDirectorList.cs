using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YourNamespace;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CinemaV1
{
	public partial class FormDirectorList : Form
	{
		public FormDirectorList()
		{
			InitializeComponent();

			// Panel'i hareket ettirmek için FormMover'ı kullan
			FormMover.Attach(panel1, this); // panel1 hareket ettirilebilir olacak
		}
		SqlConnection conn = new SqlConnection("Data Source=sudem\\SQLEXPRESS;Initial Catalog=SkyCinemaDb;Integrated Security=True");
		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void FormDirectorList_Load(Object sender, EventArgs e)
		{
			// DevExpress benzeri tema uygula
			ThemeHelper.ApplyTheme(this);
			ThemeHelper.StyleExitButton(button1);
			
			ListPanel.Controls.Clear();
			conn.Open();
			string query = "select * from Table_Directors ORDER BY UNAMESNAME ASC";
			SqlCommand command = new SqlCommand(query, conn);
			SqlDataReader read = command.ExecuteReader();
			while (read.Read())
			{
				//fanctions

				DirectorList tool = new DirectorList();
				tool.lblName.Text = read["UNAMESNAME"].ToString();
				tool.labelID.Text = read["ID"].ToString();
				tool.pictureBoxList.ImageLocation = read["PHOTO"].ToString();

				ListPanel.Controls.Add(tool);


			}




			conn.Close();
		}



		private void textSearch_TextChanged(object sender, EventArgs e)
		{

			// Mevcut imleç pozisyonunu kaydet
			int cursorPosition = textSearch.SelectionStart;

			textSearch.Text = textSearch.Text.ToUpper();

			// İmleci önceki pozisyonuna geri getir
			textSearch.SelectionStart = cursorPosition;

			textSearch.SelectionLength = 0;



			ListPanel.Controls.Clear();
			conn.Open();
			SqlCommand search = new SqlCommand("select * from Table_Directors Where UNAMESNAME LIKE '%" + textSearch.Text + "%' ORDER BY UNAMESNAME ASC", conn);
			SqlDataReader read = search.ExecuteReader();
			while (read.Read())
			{

				DirectorList tool = new DirectorList();
				tool.lblName.Text = read["UNAMESNAME"].ToString();
				tool.labelID.Text = read["ID"].ToString();
				tool.pictureBoxList.ImageLocation = read["PHOTO"].ToString();

				ListPanel.Controls.Add(tool);
			}

			conn.Close();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
