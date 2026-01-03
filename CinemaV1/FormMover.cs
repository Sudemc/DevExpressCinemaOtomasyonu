using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace YourNamespace
{
	public class FormMover
	{
		[DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
		private static extern void ReleaseCapture();

		[DllImport("user32.dll", EntryPoint = "SendMessage")]
		private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

		private const int WM_NCLBUTTONDOWN = 0xA1;
		private const int HTCAPTION = 0x2;

		public static void Attach(Control control, Form form)
		{
			control.MouseDown += (s, e) =>
			{
				if (e.Button == MouseButtons.Left)
				{
					ReleaseCapture();
					SendMessage(form.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
				}
			};
		}
	}
}
