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
            imgDest.SizeMode = PictureBoxSizeMode.Zoom;
            imgDest.Image = bitmap;
            MessageBox.Show(string.Format("Image saved successfully in {0}", txtDestination.Text));
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

        private void FrmConvert_Load(object sender, EventArgs e)
        {
            //using (Bitmap image = new Bitmap(400, 300))
            //using (Graphics drawing = Graphics.FromImage(image))
            //{
            //drawing.Clear(Color.Transparent);
            //Brush textBrush = new SolidBrush(Color.Black);
            //drawing.DrawString("Preview", new Font("Tahoma", 20, FontStyle.Regular), textBrush, 0, 0);
            //drawing.Save();
            //imgDest.Image = image;
            //}

            string text = "Preview";
            Bitmap bitmap = new Bitmap(1, 1);
            Font font = new Font("Arial", 16, FontStyle.Regular, GraphicsUnit.Pixel);
            Graphics graphics = Graphics.FromImage(bitmap);
            int width = 250; //(int)graphics.MeasureString(text, font).Width;
            int height = 30; //(int)graphics.MeasureString(text, font).Height;
            bitmap = new Bitmap(bitmap, new Size(width, height));
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.TextRenderingHint = TextRenderingHint.AntiAlias;
            graphics.DrawString(text, font, new SolidBrush(Color.FromArgb(255, 0, 0)), 90, 0);

            imgDest.Image = bitmap;
            imgDest.SizeMode = PictureBoxSizeMode.CenterImage;

            graphics.Flush();
            graphics.Dispose();
        }
    }
}
