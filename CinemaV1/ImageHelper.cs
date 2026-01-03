using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CinemaV1
{
    public static class ImageHelper
    {
        public static Image LoadSafe(string path)
        {
            if (string.IsNullOrEmpty(path)) return null;

            // Try exact path
            if (File.Exists(path))
            {
                try
                {
                    return Image.FromFile(path);
                }
                catch
                {
                    // Ignore load error, proceed to fallback
                }
            }

            // Fallback: Try identifying filename and looking in common relative locations
            try {
                string fileName = Path.GetFileName(path);
                
                // 1. Try alongside the executable (bin/debug/...)
                string localPath = Path.Combine(Application.StartupPath, "SkyCinemaMedia", fileName);
                if (File.Exists(localPath)) return Image.FromFile(localPath);

                // 2. Try looking in the project folder (up 2-3 levels from bin)
                // This is a rough guess but helpful for dev environments
                string projectPath = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\.."));
                string projectMedia = Path.Combine(projectPath, "SkyCinemaMedia", fileName);
                 if (File.Exists(projectMedia)) return Image.FromFile(projectMedia);

            } catch { }

            // If completely failed, return null (PictureBox handles null gracefully usually)
            return null;
        }
    }
}
