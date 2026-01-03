using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YourNamespace;

namespace CinemaV1
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
			FormMover.Attach(panel1, this); // panel1 hareket ettirilebilir olacak
			
			// SDMCinema Premium Dark Theme
			ThemeHelper.ApplyTheme(this);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void panel4_Paint(object sender, PaintEventArgs e)
		{

		}

		private void FormMain_Load(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			FormDirectorReg frm = new FormDirectorReg();
			frm.ShowDialog(); //show
		}

		private void button4_Click(object sender, EventArgs e)
		{
			FormDirectorList frm = new FormDirectorList();
			frm.ShowDialog();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			FormActorReg formActorReg = new FormActorReg();
			formActorReg.ShowDialog();
		}

		private void button9_Click(object sender, EventArgs e)
		{

		}

		private void button6_Click(object sender, EventArgs e)
		{
			FormActorList frm = new FormActorList();
			frm.ShowDialog();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			FormCinemaReg formCinemaReg = new FormCinemaReg();
			formCinemaReg.ShowDialog();
		}

		private void button11_Click(object sender, EventArgs e)
		{
			FormMovieReg formMovieReg = new FormMovieReg();
			formMovieReg.ShowDialog();
		}

		private void button12_Click(object sender, EventArgs e)
		{
			FormMovieList frm = new FormMovieList();
			frm.ShowDialog();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			FormTicketCreate frm = new FormTicketCreate();
			frm.ShowDialog();

		}

		private void button7_Click(object sender, EventArgs e)
		{
			FormTicketQuery frm = new FormTicketQuery();
			frm.ShowDialog();
		}



		private void button14_Click(object sender, EventArgs e)
		{
			FormCinemaAssignment frm = new FormCinemaAssignment();
			frm.ShowDialog();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// public String userName = "";


	}
}
