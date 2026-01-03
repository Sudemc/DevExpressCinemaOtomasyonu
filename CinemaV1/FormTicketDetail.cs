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
	public partial class FormTicketDetail : Form
	{
		public FormTicketDetail()
		{
			InitializeComponent();
			FormMover.Attach(panel1, this); // panel1 hareket ettirilebilir olacak

		}
		SqlConnection conn = new SqlConnection("Data Source=sudem\\SQLEXPRESS;Initial Catalog=SkyCinemaDb;Integrated Security=True"); 
		
		private void FormTicketDetail_Load(object sender, EventArgs e)
		{
			
			
			lblTicketNo.Text = ticketNo;
			lblTicketNo2.Text = ticketNo;
			BarcodeCreateRandom();
			bringInfo();
			if (lblName.Text == "null")
			{
				MessageBox.Show("Ticket is unvalid please close the screen and try again");
			}
			lblTodayDate.Text = currentDate.ToString("dd/MM/yyyy HH:mm");

		}
		void BarcodeCreateRandom()
		{
			//random ticket no

			Random rnd = new Random();
			string chars = "123456789456789456789456789456789456789456789";
			string code = "";
			for (int i = 0; i < 10; i++)
			{
				code += chars[rnd.Next(chars.Length)];

			}
			lblBarcode.Text = code.ToString();
			barcode2.Text = code.ToString();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		public string ticketNo = "";

		DateTime currentDate = DateTime.Now;

		
		void bringInfo()
		{
			string query = "select * from Table_Tickets WHERE TCODE=@code";
			conn.Open();


			SqlCommand bring = new SqlCommand(query, conn);
			bring.Parameters.AddWithValue("@code", ticketNo);
			SqlDataReader reader = bring.ExecuteReader();
			if (reader.Read())
			{
				lblMovieName.Text = reader["MOVIE"].ToString();
				lblMovieName2.Text = reader["MOVIE"].ToString();
				lblTheater.Text = reader["CINEMA"].ToString();
				lblSeat.Text = reader["SEATNUMBER"].ToString();
				lblName.Text = reader["UNAMESNAME"].ToString();
				lblPhone.Text = reader["PHONENUM"].ToString();
				lblDate.Text = reader["DATE"].ToString();
				lblDate2.Text = reader["DATE"].ToString();
				lblSession.Text = reader["SESSION"].ToString() ;
				lblFunction.Text = reader["FUNCTIONHOUR"].ToString();
				lblType.Text = reader["TYPE"].ToString();
				if(lblType.Text == "Student")
				{
					lblCost.Text = "$10";
				}
				else
				{
					lblCost.Text = "$15";
				}

			}


			conn.Close();
		}


		private void panel7_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
