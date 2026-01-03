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
	public partial class FormMovieList : Form
	{
		//database connection
		SqlConnection conn = new SqlConnection("Data Source=sudem\\SQLEXPRESS;Initial Catalog=SkyCinemaDb;Integrated Security=True");
		public FormMovieList()
		{
			InitializeComponent();
			FormMover.Attach(panel1, this); // panel1 hareket ettirilebilir olacak
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void NAME_Click(object sender, EventArgs e)
		{

		}

		private void FormMovieList_Load(object sender, EventArgs e)
		{
			// DevExpress benzeri tema uygula
			ThemeHelper.ApplyTheme(this);
			ThemeHelper.StyleExitButton(button1);

			conn.Open();
			string query = "select * from Table_Movies ORDER BY NAME";
			SqlCommand command = new SqlCommand(query, conn);
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				MovieList tool = new MovieList();
				tool.labelMovieName.Text = reader["NAME"].ToString();
				tool.picBoxMovieList.ImageLocation = reader["BANNER"].ToString();
				tool.labelIDMovie.Text = reader["ID"].ToString();
				ListPanelMovie.Controls.Add(tool);

			}




			conn.Close();



		}

		private void textSearchMovie_TextChanged(object sender, EventArgs e)
		{

			// Mevcut imleç pozisyonunu kaydet
			int cursorPosition = textSearchMovie.SelectionStart;

			textSearchMovie.Text = textSearchMovie.Text.ToUpper();

			// İmleci önceki pozisyonuna geri getir
			textSearchMovie.SelectionStart = cursorPosition;

			textSearchMovie.SelectionLength = 0;

			ListPanelMovie.Controls.Clear();
			conn.Open();
			SqlCommand search = new SqlCommand("select * from Table_Movies Where NAME LIKE '%" + textSearchMovie.Text + "%' ORDER BY NAME ASC", conn);
			SqlDataReader reader = search.ExecuteReader();
			while (reader.Read())
			{
				MovieList tool = new MovieList();
				tool.labelMovieName.Text = reader["NAME"].ToString();
				tool.picBoxMovieList.ImageLocation = reader["BANNER"].ToString();
				tool.labelIDMovie.Text= reader["ID"].ToString();
			
				ListPanelMovie.Controls.Add(tool);
			}

			conn.Close();

		}
	}
}
