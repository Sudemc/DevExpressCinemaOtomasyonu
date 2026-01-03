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
	public partial class FormTicketQuery : Form
	{
		SqlConnection conn = new SqlConnection("Data Source=sudem\\SQLEXPRESS;Initial Catalog=SkyCinemaDb;Integrated Security=True");

		public FormTicketQuery()
		{
			InitializeComponent();
			FormMover.Attach(panel1, this); // panel1 hareket ettirilebilir olacak
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			FormTicketDetail formTicketDetail = new FormTicketDetail();
			formTicketDetail.ticketNo = txtTicketNoQuery.Text.ToString();
			txtTicketNoQuery.Text = "";

			formTicketDetail.ShowDialog();
		}

		private void txtTicketNoQuery_TextChanged(object sender, EventArgs e)
		{
		}

		private void LoadTicketData()
		{
			try
			{
				// SQL sorgusu
				string query = "SELECT TCODE  FROM Table_Tickets"; // Tickets tablo adını kendi tablo adınıza göre değiştirin.

				// Bağlantıyı aç
				conn.Open();

				// DataAdapter ve DataTable oluştur
				SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
				DataTable dataTable = new DataTable();
				dataAdapter.Fill(dataTable);

				// GridControl'e bağla
				gridControl1.DataSource = dataTable;

				// GridView ayarları (isteğe bağlı)
				gridView1.OptionsView.ShowGroupPanel = false; // Grup panelini gizle
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Hata: {ex.Message}", "Veri Bağlama Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				// Bağlantıyı kapat
				if (conn.State == ConnectionState.Open)
				{
					conn.Close();
				}
			}
		}

		private void FormTicketQuery_Load(object sender, EventArgs e)
		{
			LoadTicketData(); // Form yüklendiğinde verileri yükle
		}
	}
}
