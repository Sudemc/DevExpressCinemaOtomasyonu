using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.TextFormatting;

namespace CinemaV1
{
	public partial class FormShow_prologue_ : Form
	{
		public FormShow_prologue_()
		{
			InitializeComponent();
		}

		private void lblMovieename_Click(object sender, EventArgs e)
		{
			lblMovieename.Text = "FİLM VİZYONDA";
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
