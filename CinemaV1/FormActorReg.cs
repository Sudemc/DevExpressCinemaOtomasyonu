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
using System.Windows.Media.TextFormatting;
using YourNamespace;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CinemaV1
{
	public partial class FormActorReg : Form
	{


		SqlConnection conn = new SqlConnection("Data Source=sudem\\SQLEXPRESS;Initial Catalog=SkyCinemaDb;Integrated Security=True");
		public FormActorReg()
		{
			InitializeComponent();
			FormMover.Attach(panel1, this); // panel1 hareket ettirilebilir olacak
			
			// Siyah-Sarı-Beyaz tema uygula
			ThemeHelper.ApplyTheme(this);
			ThemeHelper.StylePrimaryButton(btnSubmit);
			ThemeHelper.StyleInfoButton(btnUploadPic);
			
			// Header panel - Modern Soft Dark
			panel1.BackColor = ThemeHelper.Graphite; // #2D2D2D
			label1.ForeColor = ThemeHelper.Gold; // Amber accent
			label1.BackColor = Color.Transparent;
			label1.Font = ThemeHelper.TitleFont; // 16pt Semibold
			label1.Tag = "title"; // StyleLabel'ın dokunmaması için
			
			// Cinsiyet ikonlarının arka planını siyah yap
			pictureBox2.BackColor = ThemeHelper.Black;
			pictureBox3.BackColor = ThemeHelper.Black;
		}

		private void label8_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		public string photoPath = ""; //for taking parameter
		private void btnUploadPic_Click(object sender, EventArgs e)
		{



			{
				OpenFileDialog dlg = new OpenFileDialog();
				dlg.Title = "Photo Choose Screen";
				dlg.Filter = "PNG | *.png | JPG | *.jpg | All Files | *.*";
				dlg.FilterIndex = 3;

				if (dlg.ShowDialog() == DialogResult.OK)
				{
					// selected pic file path dlg.filename
					string selectedFilePath = dlg.FileName;
					picBox.Image = new Bitmap(selectedFilePath);
					picBox.Image = Image.FromFile(selectedFilePath);
					photoPath = dlg.FileName.ToString();
				}
			}
		}

		private void rBio_TextChanged(object sender, EventArgs e)
		{
			int size = rBio.Text.Length;
			int minus = 300 - rBio.Text.Length;
			lblMaxBioSize.Text = size.ToString();

			if (size > 0)
			{
				lblMaxBioSize.ForeColor = Color.FromArgb(84, 110, 128);
			}
			if (size >= 270)
			{
				lblMaxBioSize.ForeColor = Color.Orange;
			}
			if (size >= 290)
			{
				lblMaxBioSize.ForeColor = ThemeHelper.Danger;
			}
		}

		private void btnSubmit_Click(object sender, EventArgs e)
		{
			try
			{
				string name = textName.Text.ToString().ToUpper() + " " + textSname.Text.ToString().ToUpper();
				conn.Open();
				//all neccesary input control
				if (!ValidateInputs())
				{

					return;
				}

				if (!ageCalculate())
				{

					return;
				}

				SqlCommand register = new SqlCommand("INSERT INTO Table_Actors (UNAMESNAME, GENDER, AGE, BIOGRAPHY, PHOTO) VALUES(@p1, @p2, @p3, @p4, @p5)", conn);
				register.Parameters.AddWithValue("@p1", name);
				register.Parameters.AddWithValue("@p2", gender);
				register.Parameters.AddWithValue("@p3", bAge);
				register.Parameters.AddWithValue("@p4", rBio.Text.ToString());
				register.Parameters.AddWithValue("@p5", photoPath);


				int rowsAffected = register.ExecuteNonQuery();
				if (rowsAffected > 0)
				{
					MessageBox.Show("Actors register succeeded");
					ResetForm();
				}
				else
				{
					MessageBox.Show("No rows inserted. Please check your input data.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
			finally
			{
				conn.Close();
			}

		}
		public String gender = "0";


		public string bAge = "00";


		public bool ageCalculate()
		{
			try
			{
				String birth = numDay.Value.ToString() + "-" + numMonth.Value.ToString() + "-" + numYear.Value.ToString();
				DateTime birthDate = Convert.ToDateTime(birth);
				DateTime today = DateTime.Today;
				int age = today.Year - birthDate.Year;


				if (birthDate > today.AddYears(-age))
				{
					age--;
				}

				if (age < 0)
				{
					MessageBox.Show("Age cannot be negative");
					return false;  // if age - will stop register
				}
				else if (age < 18)
				{
					MessageBox.Show("Age cannot be under 18");
					return false;  // if age <18 will stop register
				}
				else
				{
					bAge = age.ToString();
					return true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error in age calculation: " + ex.Message);
				return false;
			}




		}
		private bool ValidateInputs()
		{


			// name control
			if (string.IsNullOrWhiteSpace(textName.Text))
			{
				MessageBox.Show("Name cannot be empty.");
				return false;
			}

			// (Surname) kontrolü
			if (string.IsNullOrWhiteSpace(textSname.Text))
			{
				MessageBox.Show("Surname cannot be empty.");
				return false;
			}

			// bio control
			if (string.IsNullOrWhiteSpace(rBio.Text))
			{
				MessageBox.Show("Biography cannot be empty.");
				return false;
			}

			// photo control
			if (string.IsNullOrWhiteSpace(photoPath))
			{
				MessageBox.Show("Photo must be uploaded.");
				return false;
			}

			// if all controls passed return true
			return true;
		}


		private void ResetForm()
		{

			textName.Clear();
			textSname.Clear();
			rBio.Clear();


			rMale.Checked = false;
			rFemale.Checked = false;


			numDay.Value = 1;
			numMonth.Value = 1;
			numYear.Value = 2000;


			picBox.Image = null;

			photoPath = "";
			gender = "0";
		}

		private void rMale_CheckedChanged_1(object sender, EventArgs e)
		{
			gender = "0";
		}

		private void rFemale_CheckedChanged_1(object sender, EventArgs e)
		{
			gender = "1";
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
		  this.Close();
		}
	}
}