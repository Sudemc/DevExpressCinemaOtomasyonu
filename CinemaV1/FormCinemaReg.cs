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
using YourNamespace;

namespace CinemaV1
{
	public partial class FormCinemaReg : Form
	{
		public FormCinemaReg()
		{
			InitializeComponent();
			FormMover.Attach(panel1, this); // panel1 hareket ettirilebilir olacak
		}
		SqlConnection conn = new SqlConnection("Data Source=sudem\\SQLEXPRESS;Initial Catalog=SkyCinemaDb;Integrated Security=True");
		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}




		private void btnAd_Click(object sender, EventArgs e)
		{
			if (textCinemaName.Text != "" & comboBoxSeat.Text != "")

			{
				conn.Open();
				
				// Önce en büyük ID'yi bul ve 1 ekle
				SqlCommand getMaxId = new SqlCommand("SELECT ISNULL(MAX(ID), 0) + 1 FROM Table_Cinema", conn);
				int newId = Convert.ToInt32(getMaxId.ExecuteScalar());
				
				SqlCommand save = new SqlCommand("insert into Table_Cinema (ID,SNAME,SEATNUMBER) Values (@p1,@p2,@p3)", conn);
				save.Parameters.AddWithValue("@p1", newId);
				save.Parameters.AddWithValue("@p2", textCinemaName.Text.ToUpper());
				save.Parameters.AddWithValue("@p3", comboBoxSeat.Text);
				save.ExecuteNonQuery();


				conn.Close();
				MessageBox.Show("Cinema save added succesfully!");
				textCinemaName.Text = "";
				comboBoxSeat.Text = "";
				textCinemaName.Focus();
				List();
			}
			else
			{
				MessageBox.Show("Please Enter Value");
			}

			conn.Close();
		}	

		private void FormCinemaReg_Load(object sender, EventArgs e)
		{
			// DevExpress benzeri tema uygula
			ThemeHelper.ApplyTheme(this);
			ThemeHelper.StyleExitButton(button1);
			ThemeHelper.StyleSuccessButton(btnAd);
			
			List();
			sCreate();


		}

		void sCreate()
		{
			for (int i = 1; i <= 200; i++)
			{

				comboBoxSeat.Items.Add(i);
			}
		}
		void List()
		{
			flowLayoutCinemaPanel.Controls.Clear();
			conn.Open();
			SqlCommand command = new SqlCommand("Select * from Table_Cinema ", conn);
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				CinemaList tool = new CinemaList();
				tool.lblCinemaName.Text = reader["SNAME"].ToString();
				tool.lblSeatNumber.Text = reader["SEATNUMBER"].ToString();
				flowLayoutCinemaPanel.Controls.Add(tool);

			}
			conn.Close();



		}
	}

}
