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
	public partial class aListTool : UserControl
	{
		SqlConnection conn = new SqlConnection("Data Source=sudem\\SQLEXPRESS;Initial Catalog=SkyCinemaDb;Integrated Security=True");
		public aListTool()
		{
			InitializeComponent();
		}

		private void lblName_Click(object sender, EventArgs e)
		{

			if (lblName.ForeColor == Color.FromArgb(17, 28, 43))
			{
				lblName.ForeColor = Color.FromArgb(249, 164, 26);
				pictureBox1.Image = ImageHelper.LoadSafe(@"c:\Users\sudem\OneDrive\Masaüstü\CinemaV1\SkyCinemaMedia\plushover.png");
				conn.Open();
				SqlCommand command = new SqlCommand("insert into Table_Selected (PERSON,TYPE) VALUES (@p1 ,@p2) ",conn);
				command.Parameters.AddWithValue("@p1",lblName.Text);
				command.Parameters.AddWithValue("@p2", "ACTOR");
			    command.ExecuteNonQuery();
				conn.Close();


			}
			else
			{
				lblName.ForeColor = Color.FromArgb(17, 28, 43);
				pictureBox1.Image = ImageHelper.LoadSafe(@"c:\Users\sudem\OneDrive\Masaüstü\CinemaV1\SkyCinemaMedia\plus.png");
				conn.Open();
				SqlCommand command = new SqlCommand("DELETE FROM Table_Selected WHERE PERSON=@p1 AND TYPE=@p2 ", conn);
				command.Parameters.AddWithValue("@p1", lblName.Text);
				command.Parameters.AddWithValue("@p2", "ACTOR");
				command.ExecuteNonQuery();
				conn.Close();

			}
		}

		private void lblName_MouseMove(object sender, MouseEventArgs e)
		{
			lblName.Font = new Font(lblName.Font.Name, 10, FontStyle.Underline); //underline label
		}

		private void lblName_MouseLeave(object sender, EventArgs e)
		{
			lblName.Font = new Font(lblName.Font.Name, 10, FontStyle.Regular); //turns old version
		}

		private void aListTool_Load(object sender, EventArgs e)
		{
			conn.Open();
			SqlCommand command = new SqlCommand("select * from Table_Selected WHERE PERSON=@p1 AND TYPE=@p2",conn);
			command.Parameters.AddWithValue("@p1",lblName.Text);
			command.Parameters.AddWithValue("@p2", "ACTOR");
			command.ExecuteNonQuery();
			SqlDataReader reader = command.ExecuteReader();
			if (reader.Read())
			{
				lblName.ForeColor = Color.FromArgb(249, 164, 26);
				pictureBox1.Image = ImageHelper.LoadSafe(@"c:\Users\sudem\OneDrive\Masaüstü\CinemaV1\SkyCinemaMedia\plushover.png");

			}
			else
			{
				lblName.ForeColor = Color.FromArgb(17, 28, 43);
				pictureBox1.Image = ImageHelper.LoadSafe(@"c:\Users\sudem\OneDrive\Masaüstü\CinemaV1\SkyCinemaMedia\plus.png");
			}



			conn.Close();
			
		}
	}
}
