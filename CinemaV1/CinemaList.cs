using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaV1
{
	public partial class CinemaList : UserControl
	{
		SqlConnection conn = new SqlConnection("Data Source=sudem\\SQLEXPRESS;Initial Catalog=SkyCinemaDb;Integrated Security=True");
		public CinemaList()
		{
			InitializeComponent();
			
			// Siyah-Sarı-Beyaz tema uygula
			this.BackColor = ThemeHelper.DarkGray;
			buttonDelete.BackColor = ThemeHelper.Danger;
			buttonDelete.ForeColor = ThemeHelper.White;
			buttonDelete.FlatStyle = FlatStyle.Flat;
			buttonDelete.FlatAppearance.BorderSize = 0;
			lblCinemaName.ForeColor = ThemeHelper.Gold;
			lblSeatNumber.ForeColor = ThemeHelper.White;
		}

	
		

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			// delete function 
			conn.Open();
			SqlCommand delete = new SqlCommand("DELETE FROM Table_Cinema WHERE ID=@p1", conn);
			delete.Parameters.AddWithValue("@p1", labelID.Text.ToString());

			int rowsAffected = delete.ExecuteNonQuery(); 
			conn.Close();

			if (rowsAffected > 0)
			{
				MessageBox.Show(lblCinemaName.Text + " deleted successfully.");
				this.Hide(); 
			}
			else
			{
				MessageBox.Show("No record found to delete.");
			}

			conn.Close();
		}

		
		private void leave(object sender, EventArgs e)
		{
			lblCinemaName.ForeColor = Color.FromArgb(255, 128, 0);
			this.BackColor = Color.Gainsboro;

		}

		private void move(object sender, MouseEventArgs e)
		{
			lblCinemaName.ForeColor = Color.White;
			this.BackColor = Color.DarkSlateGray;
		}
	}
}
