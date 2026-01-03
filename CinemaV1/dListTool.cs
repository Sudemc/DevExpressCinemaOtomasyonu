using Microsoft.VisualBasic.ApplicationServices;
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

namespace CinemaV1
{
	public partial class dListTool : UserControl
	{
		SqlConnection conn = new SqlConnection("Data Source=sudem\\SQLEXPRESS;Initial Catalog=SkyCinemaDb;Integrated Security=True");
		public dListTool()
		{
			InitializeComponent();
		}

		private void lblName_Click(object sender, EventArgs e)
		{
			if (lblDirectorName.ForeColor == Color.FromArgb(17, 28, 43))
			{
				lblDirectorName.ForeColor = Color.FromArgb(249, 164, 26);
				pictureBoxDirector.Image = ImageHelper.LoadSafe(@"c:\Users\sudem\OneDrive\Masaüstü\CinemaV1\SkyCinemaMedia\plushover.png");

				conn.Open();
				SqlCommand command = new SqlCommand("insert  into Table_Selected (PERSON,TYPE) VALUES (@p1,@p2)", conn);
				command.Parameters.AddWithValue("@p1", lblDirectorName.Text);
				command.Parameters.AddWithValue("@p2", "DIRECTOR");
				command.ExecuteNonQuery();

				conn.Close();
			}
			else
			{
				lblDirectorName.ForeColor = Color.FromArgb(17, 28, 43);
				pictureBoxDirector.Image = ImageHelper.LoadSafe(@"c:\Users\sudem\OneDrive\Masaüstü\CinemaV1\SkyCinemaMedia\plus.png");
				conn.Open();
				SqlCommand command = new SqlCommand("DELETE FROM Table_Selected where PERSON=@p1 AND TYPE=@p2", conn);
				command.Parameters.AddWithValue("@p1", lblDirectorName.Text);
				command.Parameters.AddWithValue("@p2", "DIRECTOR");
				command.ExecuteNonQuery();

				conn.Close();
			}
		}

		private void lblName_MouseMove(object sender, MouseEventArgs e)
		{
			lblDirectorName.Font = new Font(lblDirectorName.Font.Name, 10, FontStyle.Underline); //underline label

		}


		private void lblName_MouseLeave(object sender, EventArgs e)
		{
			lblDirectorName.Font = new Font(lblDirectorName.Font.Name, 10, FontStyle.Regular); //turns old version
		}

		private void dListTool_Load(object sender, EventArgs e)
		{
			conn.Open();

			SqlCommand command = new SqlCommand("select * from Table_Selected WHERE PERSON=@p1 AND TYPE=@p2",conn);
			command.Parameters.AddWithValue("@p1",lblDirectorName.Text);
			command.Parameters.AddWithValue("@p2", "DIRECTOR");
			SqlDataReader reader = command.ExecuteReader();	
			if (reader.Read() ) 
			{
				//yellow color
				lblDirectorName.ForeColor = Color.FromArgb(249, 164, 26);
				pictureBoxDirector.Image = ImageHelper.LoadSafe(@"c:\Users\sudem\OneDrive\Masaüstü\CinemaV1\SkyCinemaMedia\plushover.png");

			}
			else
			{
				//black color 
				lblDirectorName.ForeColor = Color.FromArgb(17, 28, 43);
				pictureBoxDirector.Image = ImageHelper.LoadSafe(@"c:\Users\sudem\OneDrive\Masaüstü\CinemaV1\SkyCinemaMedia\plus.png");
			}


			conn.Close();
		}
	}
}
