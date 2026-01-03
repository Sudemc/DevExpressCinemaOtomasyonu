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
	public partial class MovieList : UserControl
	{
		SqlConnection conn = new SqlConnection("Data Source=sudem\\SQLEXPRESS;Initial Catalog=SkyCinemaDb;Integrated Security=True");
		public MovieList()
		{
			InitializeComponent();
			
			// Siyah-Sarı-Beyaz tema uygula
			this.BackColor = ThemeHelper.DarkGray;
			btnUploadPic.BackColor = ThemeHelper.Gold;
			btnUploadPic.ForeColor = ThemeHelper.Black;
			btnUploadPic.FlatStyle = FlatStyle.Flat;
			btnUploadPic.FlatAppearance.BorderSize = 0;
			labelMovieName.ForeColor = ThemeHelper.Gold;
		}

		private void btnUploadPic_Click(object sender, EventArgs e)
		{
			FormMovieDetail frm = new FormMovieDetail();
			frm.IDno=labelIDMovie.Text;
			frm.ShowDialog();	
		}

	
	}
}
