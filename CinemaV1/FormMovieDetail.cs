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
	public partial class FormMovieDetail : Form
	{
		SqlConnection conn = new SqlConnection("Data Source=sudem\\SQLEXPRESS;Initial Catalog=SkyCinemaDb;Integrated Security=True");
		public FormMovieDetail()
		{
			InitializeComponent();
			FormMover.Attach(panel1, this); // panel1 hareket ettirilebilir olacak
		}
		public string IDno = "";
		private void FormMovieDetail_Load(object sender, EventArgs e)
		{

			string query = "select * from Table_Movies WHERE ID=@p1";
			conn.Open();
			SqlCommand command = new SqlCommand(query, conn);
			command.Parameters.AddWithValue("@p1", IDno);
			SqlDataReader reader = command.ExecuteReader();
			if (reader.Read())
			{

				picBoxMovieDetail.ImageLocation = reader["BANNER"].ToString();
				labelMNAME.Text = reader["NAME"].ToString();
				labelStyle.Text = reader["STYLE"].ToString();
				labelType.Text = reader["TYPE"].ToString();
				labelActors.Text = reader["ACTOR"].ToString();
				labelDırector.Text = reader["DIRECTOR"].ToString();
				labelPoint.Text = reader["POINT"].ToString();
				labelProperties.Text = reader["PROPERTIES"].ToString();
				labelSitutation.Text = reader["SITUATION"].ToString();
				lblfragman.Text = reader["Prolouge"].ToString();

				labelDate.Text = reader["DATE"].ToString();
				textboxMovieD.Text = reader["DETAIL"].ToString();

				if (labelSitutation.Text == "0")
				{
					labelSitutation.Text = "MOVIE ON THEATERS!!!";
				}
				else
				{
					labelSitutation.Text = "The Movie Is Not In Theaters ";
				}



			}
			conn.Close();

		}

		private void button1_Click(object sender, EventArgs e)
		{

			this.Close();
		}

		private void pro_Click(object sender, EventArgs e)
		{
			
			FormTrailer frm = new FormTrailer();
			frm.mp4 = lblfragman.Text.ToString();
			
			frm.ShowDialog();
		}
	}
}
