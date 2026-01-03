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
	public partial class ActorList : UserControl
	{
		SqlConnection conn = new SqlConnection("Data Source=sudem\\SQLEXPRESS;Initial Catalog=SkyCinemaDb;Integrated Security=True");
		public ActorList()
		{
			InitializeComponent();
		}

		private void ActorList_Load(object sender, EventArgs e)
		{
			// Modern Soft Dark tema
			ThemeHelper.ApplyUserControlTheme(this);
			ThemeHelper.StyleInfoButton(btnDetail);
			ThemeHelper.StyleExitButton(buttonDelete);
			lblName.ForeColor = ThemeHelper.Gold; // Amber accent
			lblName.Tag = "title";
			panel1.BackColor = ThemeHelper.Graphite; // #2D2D2D
			
			// Şimşek animasyonunu kaldır
			pictureBox1.Visible = false;
			
			conn.Open();
			string query = "select * from Table_Actors WHERE ID=@p1";
			SqlCommand command = new SqlCommand(query, conn);
			command.Parameters.AddWithValue("@p1", labelID.Text);
			SqlDataReader reader = command.ExecuteReader();
			if (reader.Read())
			{
				lblGenderInt.Text = reader["GENDER"].ToString();
			}


			conn.Close();

			if (lblGenderInt.Text == "0")
			{
				//man
				pictureGenderBox.Image = ImageHelper.LoadSafe(@"c:\Users\sudem\OneDrive\Masaüstü\CinemaV1\SkyCinemaMedia\man.jpg");

			}
			else
			{
				//woman
				pictureGenderBox.ImageLocation = @"C:\Users\skyks\Desktop\homework\cinemaprojectre\woman.jpg";
			}
		}

		private void btnDetail_Click(object sender, EventArgs e)
		{
			conn.Open();
			string query = "select * from Table_Actors WHERE ID=@p1";
			SqlCommand command = new SqlCommand(query, conn);
			command.Parameters.AddWithValue("@p1", labelID.Text);
			SqlDataReader reader = command.ExecuteReader();
			if (reader.Read())
			{
				MessageBox.Show("BIO : " + reader["BIOGRAPHY"].ToString(), reader["UNAMESNAME"].ToString());
			}


			conn.Close();
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			conn.Open();
			SqlCommand delete = new SqlCommand("delete  from Table_Directors WHERE ID=@p1", conn);

			delete.Parameters.AddWithValue("@p1", labelID.Text);
			delete.ExecuteNonQuery();
			conn.Close();

			MessageBox.Show(lblName.Text + "Deleted succesfully");
			this.Hide(); // refresh list screen

		}

		private void lblGenderInt_Click(object sender, EventArgs e)
		{

		}

		private void labelID_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}
	}
}
