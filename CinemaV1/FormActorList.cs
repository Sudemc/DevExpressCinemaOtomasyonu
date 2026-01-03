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

namespace CinemaV1
{



	public partial class FormActorList : Form
	{
		SqlConnection conn = new SqlConnection("Data Source=sudem\\SQLEXPRESS;Initial Catalog=SkyCinemaDb;Integrated Security=True");
		public FormActorList()
		{
			InitializeComponent();

			FormMover.Attach(panel1, this); // panel1 hareket ettirilebilir olacak
		}



		private void button1_Click_1(object sender, EventArgs e)
		{
			this.Close();
		}

		private void FormActorList_Load(object sender, EventArgs e)
		{
			// DevExpress benzeri tema uygula
			ThemeHelper.ApplyTheme(this);
			ThemeHelper.StyleExitButton(button1);
			
			ListPanel.Controls.Clear();
			conn.Open();
			string query = "select * from Table_Actors ORDER BY UNAMESNAME ASC";
			SqlCommand command = new SqlCommand(query, conn);
			SqlDataReader read = command.ExecuteReader();
			while (read.Read())
			{
				//fanctions

				ActorList tool = new ActorList();
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
			int cursorPosition = textSearch1.SelectionStart;

			textSearch1.Text = textSearch1.Text.ToUpper();

			// İmleci önceki pozisyonuna geri getir
			textSearch1.SelectionStart = cursorPosition;

			textSearch1.SelectionLength = 0;



			ListPanel.Controls.Clear();
			conn.Open();
			SqlCommand search = new SqlCommand("select * from Table_Actors Where UNAMESNAME LIKE '%" + textSearch1.Text + "%' ORDER BY UNAMESNAME ASC", conn);
			SqlDataReader read = search.ExecuteReader();
			while (read.Read())
			{

				ActorList tool = new ActorList();
				tool.lblName.Text = read["UNAMESNAME"].ToString();
				tool.labelID.Text = read["ID"].ToString();
				tool.pictureBoxList.ImageLocation = read["PHOTO"].ToString();

				ListPanel.Controls.Add(tool);
			}	

			conn.Close();
		}
	}
}
