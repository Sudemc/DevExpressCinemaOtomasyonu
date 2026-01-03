using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using System.Drawing;

namespace CinemaV1
{
	public partial class FormTrailer : Form
	{
		public FormTrailer()
		{
			InitializeComponent();
		}

		public string mp4 = "";

		private async void Trailer_Load(object sender, EventArgs e)
		{
			// 1. Önce dosya kontrolü
			if (string.IsNullOrEmpty(mp4) || !File.Exists(mp4))
			{
				lblCheck.Text = "Video file not found:\n" + mp4;
				lblCheck.Visible = true;
				webView21.Visible = false;
				return;
			}

			lblCheck.Visible = false;
			webView21.Visible = true;

			try
			{
				// 2. WebView2 Başlatma
				await webView21.EnsureCoreWebView2Async();

				// 3. Virtual Host Eşleştirmesi (Yerel klasöre "sanal" bir domain ile erişim)
				// Dosyanın bulunduğu klasörü alıyoruz
				string videoFolder = Path.GetDirectoryName(mp4);
				string videoFileName = Path.GetFileName(mp4);

				// "cinemavideo" adında sanal bir domain oluşturup bunu fiziksel klasöre eşle
				webView21.CoreWebView2.SetVirtualHostNameToFolderMapping(
					"cinemamedia.local", 
					videoFolder, 
					CoreWebView2HostResourceAccessKind.Allow);

				// 4. Sanal URL oluştur (https://cinemamedia.local/dosyaadi.mp4)
				// Boşlukları ve özel karakterleri URL uyumlu hale getir
				string videoUrl = $"https://cinemamedia.local/{Uri.EscapeDataString(videoFileName)}";

				// 5. HTML İçeriği
				string htmlContent = $@"
<!DOCTYPE html>
<html>
<head>
    <meta charset='utf-8'>
    <style>
        body {{ margin: 0; background-color: black; overflow: hidden; display: flex; justify-content: center; align-items: center; height: 100vh; }}
        video {{ width: 100%; height: 100%; object-fit: contain; }}
    </style>
</head>
<body>
    <video controls autoplay name='media'>
        <source src='{videoUrl}' type='video/mp4'>
        Your browser does not support the video tag.
    </video>
</body>
</html>";
				
				// 6. İçeriği Yükle
				webView21.NavigateToString(htmlContent);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading video player: " + ex.Message);
			}
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			try {
				webView21.Dispose();
			} catch {}
			this.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
