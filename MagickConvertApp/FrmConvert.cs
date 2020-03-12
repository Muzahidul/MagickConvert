using ImageMagick;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagickConvertApp
{
    public partial class FrmConvert : Form
    {
        private string _SourcePath;
        private string _DestinationPath;
        private MagickImage _SourceImage;

        public FrmConvert()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSelectSourceFile_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtSourceFile.Text = _SourcePath = openFileDialog.FileName;
            }
        }

        private void btnSelectDestination_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtDestination.Text = _DestinationPath = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            _SourceImage = new MagickImage(_SourcePath);
            SetImageFormat(_SourceImage);
            SetImageDimensions(_SourceImage);

            _SourceImage.Write(Path.Combine(_DestinationPath, string.Format("{0}.{1}", Path.GetFileNameWithoutExtension(_SourcePath), cboType.Text.ToLower())));

            Bitmap bitmap = _SourceImage.ToBitmap();

            MessageBox.Show(string.Format("Image saved successfully in {0}", _DestinationPath));
        }

        private void SetImageDimensions(MagickImage image)
        {
            if (cboMeasurement.Text.ToLower() == "pixels")
            {
                image.Resize(Convert.ToInt32(txtWidth.Text), Convert.ToInt32(txtHeight.Text));
            }
            else
            {
                image.Resize(new Percentage(Convert.ToInt32(txtWidth.Text)));
            }
            image.Quality = Convert.ToInt32(txtQuality.Text);
        }

        private void SetImageFormat(MagickImage image)
        {
            switch(cboType.Text.ToLower())
            {
                case "jpg":
                    image.Format = MagickFormat.Jpeg;
                    break;
                case "png":
                    image.Format = MagickFormat.Png;
                    break;
                case "tiff":
                    image.Format = MagickFormat.Tiff;
                    break;
                case "bmp":
                    image.Format = MagickFormat.Bmp;
                    break;
                default:
                    image.Format = MagickFormat.Jpeg; 
                    break;
            }
        }

        private void txtSourceFile_TextChanged(object sender, EventArgs e)
        {
            _SourcePath = txtSourceFile.Text;
        }

        private void txtDestination_TextChanged(object sender, EventArgs e)
        {
            _DestinationPath = txtDestination.Text;
        }
    }
}
