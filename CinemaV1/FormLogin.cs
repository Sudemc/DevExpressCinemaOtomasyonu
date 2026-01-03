


using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using YourNamespace;



namespace CinemaV1
{
	public partial class FormLogin : Form

	{


		public FormLogin()
		{
			InitializeComponent();

			FormMover.Attach(panel1, this); // panel1 hareket ettirilebilir olacak
		}

		//database connection
		SqlConnection conn = new SqlConnection("Data Source =sudem\\SQLEXPRESS;Initial Catalog=SkyCinemaDb; Integrated Security=True ");
		//SqlConnection conn = new SqlConnection("Data Source " =database_path;Initial Catalog=database_name; Integrated Security=True ");


		private void button1_Click_2(object sender, EventArgs e)
		{
			Application.Exit();

		}

		private void buttonEnter_Click(object sender, EventArgs e)
		{
			//user login operations

			conn.Open();

			SqlCommand value = new SqlCommand("select * from Table_Users WHERE UNAME=@username AND UPASSWORD=@password; ", conn);
			value.Parameters.AddWithValue("@username", textUsername.Text);
			value.Parameters.AddWithValue("@password", textPassword.Text);
			SqlDataReader reader = value.ExecuteReader();
			if (reader.Read())
			{
				//MessageBox.Show("succes");
				FormMain form = new FormMain();
				//form.userName = reader["NAME/SURNAME"].ToString();

				form.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("USER NOT FOUND! username or passsword wrong ");
			}

			textUsername.Text = "";
			textPassword.Text = "";
			textUsername.Focus();



			conn.Close();




			//try
			//{
			//	conn.Open();
			//	if (conn.State == ConnectionState.Open)
			//	{
			//		MessageBox.Show("Connection successful!");
			//	}
			//}
			//catch (Exception ex)
			//{
			//	// Hata mesajýný göster
			//	MessageBox.Show("Connection failed: " + ex.Message);
			//}
			//finally
			//{
			//	conn.Close();
			//}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			FormSign frm = new FormSign();
			frm.Show();
		}
	}
}
