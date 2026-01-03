using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.XtraEditors;

namespace CinemaV1
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// SDMCinema Premium Dark Mode Tema Ayarları
			// DevExpress "The Bezier" teması - Netflix/Spotify tarzı modern koyu tema
			WindowsFormsSettings.DefaultLookAndFeel.SetSkinStyle(SkinStyle.Bezier);
			
			// Alternatif tema seçenekleri:
			// SkinStyle.WXICompact - Windows 11 tarzı
			// "VS2019 Dark" - Visual Studio koyu tema
			// "Office 2019 Black" - Office tarzı koyu tema
			
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
			Application.Run(new FormLogin());
			
		}
	}
}