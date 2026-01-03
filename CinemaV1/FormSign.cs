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
	public partial class FormSign : Form
	{
		SqlConnection conn = new SqlConnection("Data Source=sudem\\SQLEXPRESS;Initial Catalog=SkyCinemaDb;Integrated Security=True");
		public FormSign()
		{
			InitializeComponent();
			FormMover.Attach(panel1, this); // panel1 hareket ettirilebilir olacak
			
			// DevExpress benzeri tema uygula
			ThemeHelper.ApplyTheme(this);
			ThemeHelper.StyleExitButton(button1);
			ThemeHelper.StylePrimaryButton(button2);
		}


		void save()
		{
			String query = "insert into Table_Users (UNAME,UPASSWORD,[NAME/SURNAME]) VALUES (@p1,@p2,@p3)";
			SqlCommand save = new SqlCommand(query, conn);
			conn.Open();
			save.Parameters.AddWithValue("@p1", textUsername.Text);
			save.Parameters.AddWithValue("@p2", textPassword.Text);
			save.Parameters.AddWithValue("@p3", txtName.Text.ToUpper());
			save.ExecuteNonQuery();
			conn.Close();
			MessageBox.Show("Saved Succesfully");
			this.Close();

		}
		private void button1_Click(object sender, EventArgs e)
		{

			this.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (textUsername.Text != "" && txtName.Text != "" && textPassword.Text !="") 
			{
			
			save();
			}
			else
			{
				MessageBox.Show("Please fill in the blanks properly");
			}
			
		}
	}
}
