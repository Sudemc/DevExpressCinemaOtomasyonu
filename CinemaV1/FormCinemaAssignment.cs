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
	public partial class FormCinemaAssignment : Form
	{
		public FormCinemaAssignment()
		{
			InitializeComponent();

			FormMover.Attach(panel1, this); // panel1 hareket ettirilebilir olacak
		}
		SqlConnection conn = new SqlConnection("Data Source=sudem\\SQLEXPRESS;Initial Catalog=SkyCinemaDb;Integrated Security=True");
		private void FormCinemaAssignment_Load(object sender, EventArgs e)
		{
			// SDMCinema Premium Dark Theme
			ThemeHelper.ApplyTheme(this);
			ThemeHelper.StyleSimpleButton(btnExit); // Exit button styling
			ThemeHelper.StylePrimaryButton(btnUploadPic);
			
			todayDate();
			MovieName();
			BringCinema();
		}

		void todayDate()
		{
			nDay.Value = DateTime.Today.Day;
			nMonth.Value = DateTime.Today.Month;
			nYear.Value = DateTime.Today.Year;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		void MovieName()
		{
			try
			{
				conn.Open();
				string query = "SELECT DISTINCT NAME, DATE FROM Table_Movies ORDER BY NAME ASC";
				SqlCommand sqlCommand = new SqlCommand(query, conn);
				SqlDataReader reader = sqlCommand.ExecuteReader();
				HashSet<string> addedMovies = new HashSet<string>();

				while (reader.Read())
				{
					string movieName = reader["NAME"].ToString().Trim();
					string dbDate = reader["DATE"].ToString();



					if (string.IsNullOrWhiteSpace(movieName) || string.IsNullOrWhiteSpace(dbDate))
					{

						continue;
					}

					DateTime rDate;
					if (!DateTime.TryParse(dbDate, out rDate))
					{

						continue;
					}

					DateTime today = DateTime.Today;
					TimeSpan ts = rDate - today;


					if (ts.TotalDays <= 0 && !addedMovies.Contains(movieName))
					{
						// HashSet'e eklemeden önce kontrol

						addedMovies.Add(movieName);

						// ComboBox'a ekleme
						comboBoxMovieName.Invoke(new Action(() =>
						{
							comboBoxMovieName.Items.Add(movieName);

						}));
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Hata: {ex.Message}");
			}
			finally
			{
				conn.Close();
			}
		}




		void BringCinema()
		{
			try
			{
				conn.Open();
				string query = "SELECT * FROM Table_Cinema ORDER BY SNAME ASC";
				SqlCommand sqlCommand = new SqlCommand(query, conn);
				SqlDataReader reader = sqlCommand.ExecuteReader();


				while (reader.Read())
				{

					cbMovieTheater.Items.Add(reader["SNAME"].ToString());

				}

			}
			finally
			{
				conn.Close();
			}
		}
		void Save()
		{
			string query = "insert into Table_Control (MOVIENAME,DATE,TIME,THEATER) VALUES (@p1,@p2,@p3,@p4	)";
			string date = nDay.Value + "-" + nMonth.Value + "-" + nYear.Value;
			conn.Open();
			SqlCommand save = new SqlCommand(query, conn);

			save.Parameters.AddWithValue("@p1", comboBoxMovieName.Text);
			save.Parameters.AddWithValue("@p2", date);
			save.Parameters.AddWithValue("@p3", lblSelected.Text);
			save.Parameters.AddWithValue("@p4", cbMovieTheater.Text);
			save.ExecuteNonQuery();
			conn.Close();
			MessageBox.Show("succes");


			comboBoxMovieName.SelectedIndex = -1;
			cbMovieTheater.SelectedIndex = -1;
			lblSelected.Text = string.Empty;
			nDay.Value = DateTime.Today.Day;
			nMonth.Value = DateTime.Today.Month;
			nYear.Value = DateTime.Today.Year;
			cbFullSession.Items.Clear();
			flowPanelSession.Controls.Clear();
		}
		private void btnUploadPic_Click(object sender, EventArgs e)
		{
			if (btnUploadPic.Text == "COMPLETE")
			{

				string query = "SELECT DISTINCT TIME FROM Table_Control WHERE DATE=@date AND THEATER=@theater";
				string date = nDay.Value + "-" + nMonth.Value + "-" + nYear.Value;
				conn.Open();
				SqlCommand cmd = new SqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@date", date);
				cmd.Parameters.AddWithValue("@theater", cbMovieTheater.Text.ToString());
				SqlDataReader reader = cmd.ExecuteReader();
				cbFullSession.Items.Clear();
				while (reader.Read())
				{
					cbFullSession.Items.Add(reader["TIME"].ToString());


				}


				conn.Close();
				sessionControl();


				btnUploadPic.Text = "CREATE";
				btnUploadPic.BackColor = ThemeHelper.Success;

			}
			else
			{
				Save();
				cbFullSession.Items.Clear();
				btnUploadPic.Text = "COMPLETE";
				btnUploadPic.BackColor = ThemeHelper.Gold;
			}
		}

		void sessionTime(object sender, EventArgs e)
		{
			//foreach

			foreach (RadioButton item in flowPanelSession.Controls)
			{
				if (item.Checked)
				{
					lblSelected.Text = item.Text.ToString();
				}
			}
		}
		void sessionControl()
		{


			flowPanelSession.Controls.Clear();
			for (int i = 10; i <= 22; i++) //hour 10:00
			{
				for (int j = 0; j <= 30; j += 30) //min 10:30  
				{
					RadioButton radioButton = new RadioButton();
					radioButton.ForeColor = ThemeHelper.Gold;
					radioButton.BackColor = Color.Transparent;
					radioButton.FlatStyle = FlatStyle.Flat;
					radioButton.Font = ThemeHelper.ContentFont;

					string timeText = i.ToString() + ":" + (j == 0 ? "00" : j.ToString());
					radioButton.Text = timeText;
					flowPanelSession.Controls.Add(radioButton);

					radioButton.CheckedChanged += new EventHandler(sessionTime);
					if (cbFullSession.Items.Contains(timeText))
					{
						radioButton.BackColor = ThemeHelper.Danger;
						radioButton.Visible = false;
					}
				}
			}



		}
	

		private void groupBox6_Enter(object sender, EventArgs e)
		{
			// Tema renkleri ile uyumlu
			BackColor = ThemeHelper.RichBlack;
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
