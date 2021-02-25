using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SirKato.XrmToolBox.IconGallery
{
    public partial class SettingsForm : Form
    {
        private bool saved = false;
        public SettingsForm()
        {
            InitializeComponent();
        }

        public Settings EditSettings(Settings currentSettings)
        {
            numImageSize.Value = currentSettings.ImageSize;
            pbCurrentError.Image = GetImage(currentSettings.ErrorImage);
            pbDefaultError.Image = GetImage(Settings.DEFAULT_ERROR_IMAGE_BASE64);
            pbCurrentToBig.Image = GetImage(currentSettings.FileToBigImage);
            pbDefaultToBig.Image = GetImage(Settings.DEFAULT_TO_BIG_IMAGE_BASE64);

            ShowDialog();

            if (saved)
            {
                var newSettings = new Settings();

                newSettings.ImageSize = (int)numImageSize.Value;
                newSettings.ErrorImage = ToBase64(pbCurrentError.Image);
                newSettings.FileToBigImage = ToBase64(pbCurrentToBig.Image);
                newSettings.LastUsedOrganizationWebappUrl = currentSettings.LastUsedOrganizationWebappUrl;

                return newSettings;
            }
            else
            {
                return null;
            }
        }

        private string ToBase64(Image image)
        {
            using (MemoryStream m = new MemoryStream())
            {
                image.Save(m, image.RawFormat);
                byte[] imageBytes = m.ToArray();

                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }

        private Image GetImage(string base64)
        {
            byte[] bytes = Convert.FromBase64String(base64);

            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saved = true;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            saved = false;
            Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            pbCurrentError.Image = GetImage(Settings.DEFAULT_ERROR_IMAGE_BASE64);
            pbCurrentToBig.Image = GetImage(Settings.DEFAULT_TO_BIG_IMAGE_BASE64);
            numImageSize.Value = Settings.DEFAULT_IMAGE_SIZE;

        }

        private void ChangeImage(PictureBox pb)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "PNG|*.png|JPG|*jpg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var fs = ofd.OpenFile();
                pb.Image = Image.FromStream(fs);
            }
        }

        private void pbCurrentError_Click(object sender, EventArgs e)
        {
            ChangeImage(pbCurrentError);
        }

        private void pbCurrentToBig_Click(object sender, EventArgs e)
        {
            ChangeImage(pbCurrentToBig);
        }
    }
}
