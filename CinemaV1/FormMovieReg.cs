using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
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
	public partial class FormMovieReg : Form
	{

		SqlConnection conn = new SqlConnection("Data Source=sudem\\SQLEXPRESS;Initial Catalog=SkyCinemaDb;Integrated Security=True");
		public FormMovieReg()
		{
			InitializeComponent();
			FormMover.Attach(panel1, this); // panel1 hareket ettirilebilir olacak
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
			conn.Open();
			SqlCommand command = new SqlCommand("DELETE FROM Table_Selected ", conn);
			command.ExecuteNonQuery();
			conn.Close();
		}



		private void rb1_CheckedChanged(object sender, EventArgs e)
		{
			labelRate.Text = "1";
		}

		private void rb2_CheckedChanged(object sender, EventArgs e)
		{
			labelRate.Text = "2";
		}

		private void rb3_CheckedChanged(object sender, EventArgs e)
		{
			labelRate.Text = "3";
		}

		private void rb4_CheckedChanged(object sender, EventArgs e)
		{
			labelRate.Text = "4";
		}

		private void rb5_CheckedChanged(object sender, EventArgs e)
		{
			labelRate.Text = "5";
		}

		private void rb6_CheckedChanged(object sender, EventArgs e)
		{
			labelRate.Text = "6";
		}

		private void rb7_CheckedChanged(object sender, EventArgs e)
		{
			labelRate.Text = "7";
		}

		private void rb8_CheckedChanged(object sender, EventArgs e)
		{
			labelRate.Text = "8";
		}

		private void rb9_CheckedChanged(object sender, EventArgs e)
		{
			labelRate.Text = "9";
		}

		private void rb10_CheckedChanged(object sender, EventArgs e)
		{
			labelRate.Text = "10";
		}

		string photoPath = "";
		private void btnUploadPic_Click(object sender, EventArgs e)
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
				picBox.Image = ImageHelper.LoadSafe(selectedFilePath);
				photoPath = dlg.FileName.ToString();
			}
		}


		private void textboxMovieD_TextChanged(object sender, EventArgs e)
		{
			int size = textboxMovieD.Text.Length;
			int minus = 300 - textboxMovieD.Text.Length;
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
				lblMaxBioSize.ForeColor = Color.Red;
			}
		}

		private void FormMovieReg_Load(object sender, EventArgs e)
		{

			dBringList();
			aBringList();
			todayDate();
		}

		void todayDate()
		{
			nDay.Value = DateTime.Today.Day;
			nMonth.Value = DateTime.Today.Month;
			nYear.Value = DateTime.Today.Year;
		}
		//actor list
		void aBringList()
		{
			string query = "select * from Table_Actors ORDER BY UNAMESNAME ASC";
			flowActorPanel.Controls.Clear();
			conn.Open();
			SqlCommand command = new SqlCommand(query, conn);
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				aListTool tool = new aListTool();
				tool.lblName.Text = reader["UNAMESNAME"].ToString();
				flowActorPanel.Controls.Add(tool);
			}
			conn.Close();
		}
		//director list
		void dBringList()
		{
			string query = "select * from Table_Directors ORDER BY UNAMESNAME ASC";
			flowDirectorPanel.Controls.Clear();
			conn.Open();
			SqlCommand command = new SqlCommand(query, conn);
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				dListTool tool = new dListTool();
				tool.lblDirectorName.Text = reader["UNAMESNAME"].ToString();
				flowDirectorPanel.Controls.Add(tool);
			}
			conn.Close();
		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{
			// Mevcut imleç pozisyonunu kaydet
			int cursorPosition = txtboxSDirector.SelectionStart;

			txtboxSDirector.Text = txtboxSDirector.Text.ToUpper();

			// İmleci önceki pozisyonuna geri getir
			txtboxSDirector.SelectionStart = cursorPosition;

			txtboxSDirector.SelectionLength = 0;

			flowDirectorPanel.Controls.Clear();
			conn.Open();

			SqlCommand search = new SqlCommand("SELECT * FROM Table_Directors WHERE UNAMESNAME LIKE @searchText ORDER BY UNAMESNAME ASC", conn);


			search.Parameters.AddWithValue("@searchText", "%" + txtboxSDirector.Text + "%");

			SqlDataReader reader = search.ExecuteReader();
			while (reader.Read())
			{
				dListTool tool = new dListTool();
				tool.lblDirectorName.Text = reader["UNAMESNAME"].ToString();
				flowDirectorPanel.Controls.Add(tool);
			}
			conn.Close();




		}

		private void txtBoxSActor_TextChanged(object sender, EventArgs e)
		{

			// Mevcut imleç pozisyonunu kaydet
			int cursorPosition = txtBoxSActor.SelectionStart;

			txtBoxSActor.Text = txtBoxSActor.Text.ToUpper();

			// İmleci önceki pozisyonuna geri getir
			txtBoxSActor.SelectionStart = cursorPosition;

			txtBoxSActor.SelectionLength = 0;


			flowActorPanel.Controls.Clear();
			conn.Open();
			SqlCommand command = new SqlCommand("SELECT * FROM Table_Actors WHERE UNAMESNAME LIKE @searchText1 ORDER BY UNAMESNAME ASC", conn);

			command.Parameters.AddWithValue("@searchText1", "%" + txtBoxSActor.Text + "%");
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				aListTool tool = new aListTool();
				tool.lblName.Text = reader["UNAMESNAME"].ToString();
				flowActorPanel.Controls.Add(tool);
			}


			conn.Close();
		}

		private void lblActon_Click(object sender, EventArgs e)
		{
			if (lblAction.ForeColor == Color.FromArgb(84, 110, 128))
			{
				lblAction.ForeColor = Color.Crimson;

			}
			else
			{
				lblAction.ForeColor = Color.FromArgb(84, 110, 128);
			}
		}

		private void lblComedy_Click(object sender, EventArgs e)
		{
			if (lblComedy.ForeColor == Color.FromArgb(84, 110, 128))
			{
				lblComedy.ForeColor = Color.Crimson;

			}
			else
			{
				lblComedy.ForeColor = Color.FromArgb(84, 110, 128);
			}
		}

		private void lblHorror_Click(object sender, EventArgs e)
		{
			if (lblHorror.ForeColor == Color.FromArgb(84, 110, 128))
			{
				lblHorror.ForeColor = Color.Crimson;

			}
			else
			{
				lblHorror.ForeColor = Color.FromArgb(84, 110, 128);
			}
		}

		private void lblLove_Click(object sender, EventArgs e)
		{
			if (lblLove.ForeColor == Color.FromArgb(84, 110, 128))
			{
				lblLove.ForeColor = Color.Crimson;

			}
			else
			{
				lblLove.ForeColor = Color.FromArgb(84, 110, 128);
			}
		}

		private void lblSciFiction_Click(object sender, EventArgs e)
		{
			if (lblSciFiction.ForeColor == Color.FromArgb(84, 110, 128))
			{
				lblSciFiction.ForeColor = Color.Crimson;

			}
			else
			{
				lblSciFiction.ForeColor = Color.FromArgb(84, 110, 128);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			string selectedType = "";
			foreach (Control tool in gPmovieCategory.Controls)
			{
				if (tool is Label)
				{
					if (tool.ForeColor == Color.FromArgb(84, 110, 128))
					{

					}
					else
					{
						//if selected
						selectedType += " ," + tool.Text.ToString();
					}
				}
			}
			if (selectedType.Length > 2)
			{
				MessageBox.Show("Selected : " + selectedType.Substring(2));
			}
			else
			{
				MessageBox.Show("Empty");
			}



		}

		private void lblTr_Click(object sender, EventArgs e)
		{

			if (lblTr.ForeColor == Color.FromArgb(84, 110, 128))
			{
				lblTr.ForeColor = Color.Crimson;

			}
			else
			{
				lblTr.ForeColor = Color.FromArgb(84, 110, 128);
			}
		}

		private void lblEng_Click(object sender, EventArgs e)
		{
			if (lblEng.ForeColor == Color.FromArgb(84, 110, 128))
			{
				lblEng.ForeColor = Color.Crimson;

			}
			else
			{
				lblEng.ForeColor = Color.FromArgb(84, 110, 128);
			}
		}

		private void lblCC_Click(object sender, EventArgs e)
		{
			if (lblCC.ForeColor == Color.FromArgb(84, 110, 128))
			{
				lblCC.ForeColor = Color.Crimson;

			}
			else
			{
				lblCC.ForeColor = Color.FromArgb(84, 110, 128);
			}
		}

		private void lblViolance_Click(object sender, EventArgs e)
		{
			if (lblViolance.ForeColor == Color.FromArgb(84, 110, 128))
			{
				lblViolance.ForeColor = Color.Crimson;
				pictureBoxViolance.Image = ImageHelper.LoadSafe(@"c:\Users\sudem\OneDrive\Masaüstü\CinemaV1\SkyCinemaMedia\open.png");

			}
			else
			{
				lblViolance.ForeColor = Color.FromArgb(84, 110, 128);
				pictureBoxViolance.Image = ImageHelper.LoadSafe(@"c:\Users\sudem\OneDrive\Masaüstü\CinemaV1\SkyCinemaMedia\close.png");
			}
		}

		private void lbl13_Click(object sender, EventArgs e)
		{
			if (lbl13.ForeColor == Color.FromArgb(84, 110, 128))
			{
				pictureBoxo13.Image = ImageHelper.LoadSafe(@"c:\Users\sudem\OneDrive\Masaüstü\CinemaV1\SkyCinemaMedia\open.png");

				lbl13.ForeColor = Color.Crimson;

			}
			else
			{
				pictureBoxo13.Image = ImageHelper.LoadSafe(@"c:\Users\sudem\OneDrive\Masaüstü\CinemaV1\SkyCinemaMedia\close.png");

				lbl13.ForeColor = Color.FromArgb(84, 110, 128);
			}
		}

		private void lblNegativeContent_Click(object sender, EventArgs e)
		{
			if (lblNegativeContent.ForeColor == Color.FromArgb(84, 110, 128))
			{
				pictureBoxNegative.Image = ImageHelper.LoadSafe(@"c:\Users\sudem\OneDrive\Masaüstü\CinemaV1\SkyCinemaMedia\open.png");
				lblNegativeContent.ForeColor = Color.Crimson;

			}
			else
			{
				pictureBoxNegative.Image = ImageHelper.LoadSafe(@"c:\Users\sudem\OneDrive\Masaüstü\CinemaV1\SkyCinemaMedia\close.png");
				lblNegativeContent.ForeColor = Color.FromArgb(84, 110, 128);
			}
		}

		private void lbl18_Click(object sender, EventArgs e)
		{
			if (lbl18.ForeColor == Color.FromArgb(84, 110, 128))
			{
				pictureBoxa18.Image = ImageHelper.LoadSafe(@"c:\Users\sudem\OneDrive\Masaüstü\CinemaV1\SkyCinemaMedia\open.png");
				lbl18.ForeColor = Color.Crimson;

			}
			else
			{
				pictureBoxa18.Image = ImageHelper.LoadSafe(@"c:\Users\sudem\OneDrive\Masaüstü\CinemaV1\SkyCinemaMedia\close.png");
				lbl18.ForeColor = Color.FromArgb(84, 110, 128);
			}
		}

		private void lblGeneral_Click(object sender, EventArgs e)
		{
			if (lblGeneral.ForeColor == Color.FromArgb(84, 110, 128))
			{
				pictureBoxGeneral.Image = ImageHelper.LoadSafe(@"c:\Users\sudem\OneDrive\Masaüstü\CinemaV1\SkyCinemaMedia\open.png");
				lblGeneral.ForeColor = Color.Crimson;

			}
			else
			{
				pictureBoxGeneral.Image = ImageHelper.LoadSafe(@"c:\Users\sudem\OneDrive\Masaüstü\CinemaV1\SkyCinemaMedia\close.png");
				lblGeneral.ForeColor = Color.FromArgb(84, 110, 128);
			}
		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			releaseDateCalculate();
		}

		void TodayDate()
		{
			nDay.Value = DateTime.Today.Day;
			nMonth.Value = DateTime.Today.Month;
			nYear.Value = DateTime.Today.Year;
		}
		string vDate = " ";
		string situation = "0";
		void releaseDateCalculate()
		{
			vDate = nDay.Value + "-" + nMonth.Value + "-" + nYear.Value;
			DateTime dVDate = Convert.ToDateTime(vDate);
			DateTime todayDate = DateTime.Today;

			//timeSpan --> specification of  between day,month,year 
			TimeSpan tSpan = dVDate - todayDate;

			if (tSpan.TotalDays < 0)
			{
				MessageBox.Show("Movies cannot be added to past history.");
				TodayDate();
			}
			else if (tSpan.TotalDays == 0)
			{
				//FormShow_prologue_ gifform = new FormShow_prologue_();
				//gifform.ShowDialog();
				MessageBox.Show(txtMovieName.Text.ToUpper() + " The movie is in theaters today!! ");
				situation = "1";
			}
			else
			{
				MessageBox.Show(txtMovieName.Text.ToUpper() + " " + "After " + tSpan.TotalDays.ToString() + " day will be in theaters");
				situation = "0";
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			lblDate.Text = DateTime.Now.ToShortDateString();
			lblHour.Text = DateTime.Now.ToShortTimeString();
		}


		string director = "";
		string actor = "";

		void selectedDırector()
		{
			director = "";
			string query = "select * from Table_Selected Where TYPE='DIRECTOR'";
			conn.Open();
			SqlCommand command = new SqlCommand(query, conn);
			//command.Parameters.AddWithValue("@p1", "DIRECTOR");
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				director += "," + reader["PERSON"].ToString();
			}

			conn.Close();
		}

		void selectedActor()
		{
			actor = "";
			string query = "select * from Table_Selected Where TYPE=@p1";
			conn.Open();
			SqlCommand command = new SqlCommand(query, conn);
			command.Parameters.AddWithValue("@p1", "ACTOR");
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				actor += "," + reader["PERSON"].ToString();
			}

			conn.Close();
		}


		void infoClear()
		{//olmadı
		 // Tüm kontrolleri temizlemek yerine form alanlarını sıfırla
			txtMovieName.Clear();
			textboxMovieD.Clear();
			labelRate.Text = "";
			photoPath = ""; // Eğer photoPath bir string ise bu şekilde temizleyebilirsin
			vDate = "";
			situation = "";


			dBringList();
			aBringList();
			//todayDate();
			TodayDate();
			txtMovieName.Focus();
		}
		private void btnSubmit_Click(object sender, EventArgs e)
		{
			// check string null
			if (string.IsNullOrWhiteSpace(txtMovieName.Text) ||
				string.IsNullOrWhiteSpace(textboxMovieD.Text) ||
				string.IsNullOrWhiteSpace(labelRate.Text) ||
				string.IsNullOrWhiteSpace(photoPath) ||
				string.IsNullOrWhiteSpace(vDate) ||
				string.IsNullOrWhiteSpace(situation))
			{
				MessageBox.Show("Please fill in the blanks", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}


			selectedActor();
			selectedDırector();
			Type();
			Properties();
			Style();

			//saving data to database



			string query = "insert into Table_Movies (NAME,TYPE,PROPERTIES,STYLE,DIRECTOR,ACTOR,DETAIL,POINT,BANNER,DATE,SITUATION) VALUES(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)";
			conn.Open();

			SqlCommand command = new SqlCommand(query, conn);
			//type @p2
			if (selectedType.Length > 2)
			{
				command.Parameters.AddWithValue("@p2", selectedType.Substring(2));

			}
			else
			{
				command.Parameters.AddWithValue("@p2", selectedType);
			}

			//properties @p3
			if (selectedProperties.Length > 2)
			{
				command.Parameters.AddWithValue("@p3", selectedProperties.Substring(2));

			}
			else
			{
				command.Parameters.AddWithValue("@p3", selectedProperties);
			}

			//style @p4
			if (selectedStyle.Length > 1)
			{
				command.Parameters.AddWithValue("@p4", selectedStyle.Substring(2));

			}
			else
			{
				command.Parameters.AddWithValue("@p4", selectedStyle);
			}

			//director @p5
			if (director.Length > 2)
			{
				command.Parameters.AddWithValue("@p5", director.Substring(1));

			}
			else
			{
				command.Parameters.AddWithValue("@p5", director);
			}

			//actor @p6
			if (actor.Length > 2)
			{
				command.Parameters.AddWithValue("@p6", actor.Substring(1));

			}
			else
			{
				command.Parameters.AddWithValue("@p6", actor);
			}
			command.Parameters.AddWithValue("@p1", txtMovieName.Text.ToUpper());

			command.Parameters.AddWithValue("@p7", textboxMovieD.Text.ToUpper());
			command.Parameters.AddWithValue("@p8", labelRate.Text);
			command.Parameters.AddWithValue("@p9", photoPath);
			command.Parameters.AddWithValue("@p10", vDate);
			command.Parameters.AddWithValue("@p11", situation);

			command.ExecuteNonQuery();
			MessageBox.Show("Movie added succesfully");
			//infoClear();
			conn.Close();

			// Clear form fields after saving data
			infoClear();



		}
		string selectedType = "";
		string selectedProperties = "";
		string selectedStyle = "";


		void Style()
		{
			foreach (Control tool in gpStyle.Controls)
			{
				if (tool is Label)
				{
					if (tool.ForeColor == Color.FromArgb(84, 110, 128))
					{

					}
					else
					{
						//if selected
						selectedStyle += " ," + tool.Text.ToString();
					}
				}
			}

		}
		void Properties()
		{

			foreach (Control tool in gbProperites.Controls)
			{
				if (tool is Label)
				{
					if (tool.ForeColor == Color.FromArgb(84, 110, 128))
					{

					}
					else
					{
						//if selected
						selectedProperties += " ," + tool.Text.ToString();
					}
				}
			}
		}

		void Type()
		{


			foreach (Control tool in gPmovieCategory.Controls)
			{
				if (tool is Label)
				{
					if (tool.ForeColor == Color.FromArgb(84, 110, 128))
					{

					}
					else
					{
						//if selected
						selectedType += " ," + tool.Text.ToString();
					}
				}
			}

		}

	
		
	}
}

