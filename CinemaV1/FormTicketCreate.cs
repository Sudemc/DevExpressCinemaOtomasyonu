using System;
using System.CodeDom;
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
	public partial class FormTicketCreate : Form
	{
		SqlConnection conn = new SqlConnection("Data Source=sudem\\SQLEXPRESS;Initial Catalog=SkyCinemaDb;Integrated Security=True");
		public FormTicketCreate()
		{
			InitializeComponent();
			FormMover.Attach(panel1, this); // panel1 hareket ettirilebilir olacak
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void FormTicketCreate_Load(object sender, EventArgs e)
		{
			// DevExpress benzeri tema uygula
			ThemeHelper.ApplyTheme(this);
			ThemeHelper.StyleExitButton(button1);
			ThemeHelper.StyleSuccessButton(btnUploadPic);

			cbMovieTheater.Items.Clear();
			comboBoxDate.Items.Clear();
			comboBoxMovieName.Items.Clear();
			TicketCreateRandom();
			MovieName();
		}



		void TicketCreateRandom()
		{
			//random ticket no

			Random rnd = new Random();
			string chars = "123456789456789456789456789456789456789456789";
			string code = "";
			for (int i = 0; i < 10; i++)
			{
				code += chars[rnd.Next(chars.Length)];

			}
			txtTicketNumber.Text = code.ToString();
		}

		void MovieName()
		{
			try
			{
				conn.Open();
				string query = "SELECT DISTINCT MOVIENAME, DATE FROM Table_Control ORDER BY MOVIENAME ASC";
				SqlCommand sqlCommand = new SqlCommand(query, conn);
				SqlDataReader reader = sqlCommand.ExecuteReader();
				HashSet<string> addedMovies = new HashSet<string>(); // Unique movie names

				while (reader.Read())
				{
					string movieName = reader["MOVIENAME"].ToString();
					string dbDate = reader["DATE"].ToString();
					DateTime rDate = Convert.ToDateTime(dbDate);
					DateTime today = DateTime.Today;

					TimeSpan ts = rDate - today;

					if (ts.TotalDays <= 0 && !addedMovies.Contains(movieName)) // already in theaters and not added
					{
						comboBoxMovieName.Items.Add(movieName);
						addedMovies.Add(movieName); // Add to HashSet to keep track
					}
				}
			}
			finally
			{
				conn.Close();
			}
		}


	


		private void comboBoxMovieName_SelectedIndexChanged(object sender, EventArgs e)
		{
			//DISTINCT it will bring just one value of same infos at database , doesnt delete any data , just showing one of them
			conn.Open();
			string query = "SELECT DISTINCT DATE FROM Table_Control WHERE MOVIENAME=@p1";
			SqlCommand cmd = new SqlCommand(query, conn);
			cmd.Parameters.AddWithValue("@p1", comboBoxMovieName.Text.ToString());
			SqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				comboBoxDate.Items.Add(reader["DATE"].ToString());
			}
			conn.Close();
		}
		void saveTicket()
		{



			string query = "insert  into Table_Tickets (TCODE ,UNAMESNAME,PHONENUM,SEATNUMBER,MOVIE,DATE,SESSION,CINEMA,TYPE,FUNCTIONHOUR)  VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)";

			conn.Open();
			SqlCommand save = new SqlCommand(query, conn);
			save.Parameters.AddWithValue("@p1", txtTicketNumber.Text.ToString());
			save.Parameters.AddWithValue("@p2", textNameSname.Text.ToString().ToUpper());
			save.Parameters.AddWithValue("@p3", textBoxPhoneNumber.Text.ToString());
			save.Parameters.AddWithValue("@p4", txtSeatShow.Text.ToString());
			save.Parameters.AddWithValue("@p5", comboBoxMovieName.Text.ToString());
			save.Parameters.AddWithValue("@p6", comboBoxDate.Text.ToString());
			save.Parameters.AddWithValue("@p7", lblSession.Text.ToString());
			save.Parameters.AddWithValue("@p8", cbMovieTheater.Text.ToString());
			save.Parameters.AddWithValue("@p9", cbTicketType.Text.ToString());
			save.Parameters.AddWithValue("@p10", DateTime.Now.ToString());
			save.ExecuteNonQuery();
			conn.Close();


			//UPDATE
			String query2 = "UPDATE Table_Control SET SEATS =@no  WHERE MOVIENAME=@moviename AND DATE=@date AND TIME=@time AND THEATER=@t1";
			conn.Open();
			SqlCommand update = new SqlCommand(query2, conn);
			update.Parameters.AddWithValue("@no", lblBSeat.Text.ToString() + "," + txtSeatShow.Text.ToString());
			update.Parameters.AddWithValue("@moviename", comboBoxMovieName.Text.ToString());
			update.Parameters.AddWithValue("@date", comboBoxDate.Text.ToString());
			update.Parameters.AddWithValue("@time", lblSession.Text.ToString());
			update.Parameters.AddWithValue("@t1", cbMovieTheater.Text.ToString());
			update.ExecuteNonQuery();

			conn.Close();
			MessageBox.Show("Ticket created succesfully");


			ClearFields();
			
			

		}

		void ClearFields()
		{
			txtTicketNumber.Clear();
			textNameSname.Clear();
			textBoxPhoneNumber.Clear();
			txtSeatShow.Clear();
			comboBoxDate.Items.Clear();
			comboBoxMovieName.Items.Clear();
			cbMovieTheater.SelectedIndex = -1;
			cbTicketType.SelectedIndex = -1;
			flowPanelSession.Controls.Clear(); // Remove session selections
			listBoxSelectedSeat.Items.Clear();
			lblSession.Text = string.Empty; // Clear session label
			TicketCreateRandom();
			MovieName();
			
		}

		void ticketNoQuery()
		{
			string query = "SELECT * FROM Table_Tickets WHERE TCODE=@no ";

			SqlCommand cmd = new SqlCommand(query, conn);
			cmd.Parameters.AddWithValue("@no", txtTicketNumber.Text.ToString());
			SqlDataReader reader = cmd.ExecuteReader();
			if (!reader.Read())
			{
				//MessageBox.Show("none");
			}
			else
			{
				TicketCreateRandom();
				ticketNoQuery();

			}

			conn.Close();
		}


		private void btnUploadPic_Click(object sender, EventArgs e)
		{
			if (conn.State != ConnectionState.Closed)
			{
				conn.Close();
			}
			conn.Open();

			if (textNameSname.Text != "" && textBoxPhoneNumber.Text != "" && comboBoxDate.Text != "" && cbMovieTheater.Text != "" && cbTicketType.Text != "" && txtSeatShow.Text != "" && flowPanelSession.Contains != null)
			{
				// saving functions will be here



				ticketNoQuery();//after query if that ticket doesnt exist that would be save function
				saveTicket();


			}
			else
			{
				MessageBox.Show("Please fill in the blanks!!");
			}

			conn.Close();



		}


		void selectedSeat()
		{
			txtSeatShow.Text = "";
			foreach (string item in listBoxSelectedSeat.Items)
			{
				txtSeatShow.Text += "," + item;


			}
			if (txtSeatShow.Text.Length > 2)
			{

				txtSeatShow.Text = txtSeatShow.Text.Substring(1);
			}
		}


		//BUTTON (SEAT) CLICK
		private void btn_Click(object sender, EventArgs e)
		{
			//click action
			Button btn = (Button)sender;
			if (btn.ForeColor == ThemeHelper.Danger)
			{
				//FUll
				MessageBox.Show("This seat is already taken!");
			}
			else
			{
				if (btn.ForeColor == Color.White)
				{
					btn.BackgroundImage = Properties.Resources.seat_yellow;
					btn.ForeColor = Color.Blue;
					listBoxSelectedSeat.Items.Add(btn.Text.ToString());
					selectedSeat();

				}
				else
				{
					btn.BackgroundImage = Properties.Resources.seatblue;
					btn.ForeColor = Color.White;
					listBoxSelectedSeat.Items.Remove(btn.Text.ToString());
					selectedSeat();
				}

			}

		}
		private void comboBoxDate_SelectedIndexChanged(object sender, EventArgs e)
		{
			flowPanelSession.Controls.Clear();
			string sessions = "";
			conn.Open();

			//SELECT DATE
			string query = "SELECT DISTINCT TIME  FROM Table_Control WHERE MOVIENAME=@p1 AND DATE=@p2 ";
			SqlCommand cmd = new SqlCommand(query, conn);
			cmd.Parameters.AddWithValue("@p1", comboBoxMovieName.Text.ToString());
			cmd.Parameters.AddWithValue("@p2", comboBoxDate.Text.ToString());

			SqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				sessions = reader["TIME"].ToString();
				RadioButton rnd = new RadioButton();
				rnd.ForeColor = ThemeHelper.Gold;
				rnd.BackColor = Color.Transparent;
				rnd.FlatStyle = FlatStyle.Flat;
				rnd.CheckedChanged += new EventHandler(SessionTime);
				flowPanelSession.Controls.Add(rnd);
				rnd.Text = sessions;

			}
			conn.Close();
		}

		private void SessionTime(object sender, EventArgs e)
		{
			foreach (RadioButton item in flowPanelSession.Controls)
			{
				if (item.Checked)
				{
					lblSession.Text = item.Text;
					cbMovieTheater.Items.Clear();


					conn.Open();
					//MAKING SESSION
					string query = "SELECT DISTINCT *  FROM Table_Control WHERE MOVIENAME=@p1 AND DATE=@p2 AND TIME=@p3";
					SqlCommand cmd = new SqlCommand(query, conn);
					cmd.Parameters.AddWithValue("@p1", comboBoxMovieName.Text.ToString());
					cmd.Parameters.AddWithValue("@p2", comboBoxDate.Text.ToString());
					cmd.Parameters.AddWithValue("@p3", lblSession.Text.ToString());

					SqlDataReader reader = cmd.ExecuteReader();
					while (reader.Read())
					{
						cbMovieTheater.Items.Add(reader["THEATER"].ToString());
					}
					conn.Close();

				}

			}

		}

		private void cbMovieTheater_SelectedIndexChanged(object sender, EventArgs e)
		{
			//theater select

			conn.Open();
			string query = "SELECT DISTINCT *  FROM Table_Cinema WHERE SNAME=@p1 ";
			SqlCommand cmd = new SqlCommand(query, conn);
			cmd.Parameters.AddWithValue("@p1", cbMovieTheater.Text.ToString());

			SqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				cbMovieTheater.Items.Add(reader["SEATNUMBER"].ToString());
				//MessageBox.Show((reader["SEATNUMBER"].ToString()));
				lblSeat.Text = reader["SEATNUMBER"].ToString();


			}
			conn.Close();
			//selected seats call

			bringSeat();
			reserveSeat();
			bringTheatherSeats();


		}


		void bringTheatherSeats()
		{

			Button btn;

			flSeatPanel.Controls.Clear();
			int number = Convert.ToInt32(lblSeat.Text);
			int seatsPerRow = 12;
			char rowLetter = 'A';

			for (int i = 0; i < number; i++)
			{
				btn = new Button();
				btn.Click += new EventHandler(btn_Click);
				btn.Width = 50;
				btn.Height = 50;
				btn.FlatStyle = FlatStyle.Flat;
				btn.FlatAppearance.BorderSize = 0;
				btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9);
				btn.BackgroundImageLayout = ImageLayout.Stretch; // Stretch mode active
				int seatNumber = (i % seatsPerRow) + 1;
				btn.Text = rowLetter + seatNumber.ToString();
				btn.Name = rowLetter + seatNumber.ToString();

				if (seatNumber == seatsPerRow)
				{
					rowLetter++;
				}


				if (listBoxSeats.Items.Contains(btn.Text))
				{
					//if seat is full
					btn.BackgroundImage = Properties.Resources.seatred;
					btn.ForeColor = ThemeHelper.Danger;

				}
				else
				{
					//if seat is empty
					btn.ForeColor = Color.White;
					btn.BackgroundImage = Properties.Resources.seatblue;

				}


				flSeatPanel.Controls.Add(btn);
			}
		}
		void bringSeat()
		{
			lblBSeat.Text = "";

			conn.Open();
			string query = "SELECT * FROM Table_Control WHERE MOVIENAME=@p1 AND DATE=@p2 AND TIME=@p3 AND THEATER=@p4";
			SqlCommand cmd = new SqlCommand(query, conn);
			cmd.Parameters.AddWithValue("@p1", comboBoxMovieName.Text.ToString());
			cmd.Parameters.AddWithValue("@p2", comboBoxDate.Text.ToString());
			cmd.Parameters.AddWithValue("@p3", lblSession.Text.ToString());
			cmd.Parameters.AddWithValue("@p4", cbMovieTheater.Text.ToString());
			SqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{

				lblBSeat.Text += " ," + reader["SEATS"].ToString();
				if (lblBSeat.Text.Length > 2)
				{
					lblBSeat.Text = lblBSeat.Text.Substring(2);
				}
			}
			conn.Close();

		}
		void reserveSeat()
		{
			listBoxSeats.Items.Clear();
			string no = "";
			string[] select;
			no = lblBSeat.Text.ToString();
			select = no.Split(",");
			foreach (string item in select)
			{

				listBoxSeats.Items.Add(item);
			}
			{

			}
		}
		private void flSeatPanel_Paint(object sender, PaintEventArgs e)
		{

		}

		private void textBoxPhoneNumber_TextChanged(object sender, EventArgs e)
		{

			if (textBoxPhoneNumber.Text.Length > 10)
			{

				textBoxPhoneNumber.Text = textBoxPhoneNumber.Text.Substring(0, 10);


				textBoxPhoneNumber.SelectionStart = textBoxPhoneNumber.Text.Length;
			}
		}

		private void txtTicketNumber_TextChanged(object sender, EventArgs e)
		{

		}

		private void flowPanelSession_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
