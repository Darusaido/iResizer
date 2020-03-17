using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iResizer
{
    public partial class Form1 : Form
    {

        public string FileName;
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var o = new OpenFileDialog();
                o.Multiselect = true;
                
                if (o.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    int x = 0;
                    var u = System.IO.Path.GetDirectoryName(o.FileName);
                    o.FileNames.ToList().ForEach(file =>
                    {
                        FileName = System.IO.Path.GetFileNameWithoutExtension(o.FileNames[x]);
                        using (var srcImage = Image.FromFile(o.FileNames[x]))
                        {
                            using (var newImage = new Bitmap(112, 112))
                            using (var graphics = Graphics.FromImage(newImage))
                            {
                                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                                graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                                graphics.DrawImage(srcImage, new Rectangle(0, 0, 112, 112));
                                newImage.Save(u + "\\" + FileName + " - 112x112.png");
                            }
                        }

                        using (var srcImage = Image.FromFile(o.FileNames[x]))
                        {
                            using (var newImage = new Bitmap(56, 56))
                            using (var graphics = Graphics.FromImage(newImage))
                            {
                                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                                graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                                graphics.DrawImage(srcImage, new Rectangle(0, 0, 56, 56));
                                newImage.Save(u + "\\" + FileName + " - 56x56.png");
                            }
                        }

                        using (var srcImage = Image.FromFile(o.FileNames[x]))
                        {
                            using (var newImage = new Bitmap(28, 28))
                            using (var graphics = Graphics.FromImage(newImage))
                            {
                                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                                graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                                graphics.DrawImage(srcImage, new Rectangle(0, 0, 28, 28));
                                newImage.Save(u + "\\" + FileName + " - 28x28.png");
                            }
                        }

                        FileName = "";
                        x = x + 1;

                    });
                }

                MessageBox.Show("Resizing process has been completed successfully!", "iResizer- Completed!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            catch(Exception U)
            {
                MessageBox.Show(U.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var o = new OpenFileDialog();
                o.Multiselect = true;

                if (o.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    int x = 0;
                    var u = System.IO.Path.GetDirectoryName(o.FileName);
                    o.FileNames.ToList().ForEach(file =>
                    {
                        FileName = System.IO.Path.GetFileNameWithoutExtension(o.FileNames[x]);
                        using (var srcImage = Image.FromFile(o.FileNames[x]))
                        {
                            using (var newImage = new Bitmap(72, 72))
                            using (var graphics = Graphics.FromImage(newImage))
                            {
                                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                                graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                                graphics.DrawImage(srcImage, new Rectangle(0, 0, 72, 72));
                                newImage.Save(u + "\\" + FileName + " - 72x72.png");
                            }
                        }

                        using (var srcImage = Image.FromFile(o.FileNames[x]))
                        {
                            using (var newImage = new Bitmap(36, 36))
                            using (var graphics = Graphics.FromImage(newImage))
                            {
                                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                                graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                                graphics.DrawImage(srcImage, new Rectangle(0, 0, 36, 36));
                                newImage.Save(u + "\\" + FileName + " - 36x36.png");
                            }
                        }

                        using (var srcImage = Image.FromFile(o.FileNames[x]))
                        {
                            using (var newImage = new Bitmap(18, 18))
                            using (var graphics = Graphics.FromImage(newImage))
                            {
                                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                                graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                                graphics.DrawImage(srcImage, new Rectangle(0, 0, 18, 18));
                                newImage.Save(u + "\\" + FileName + " - 18x18.png");
                            }
                        }

                        FileName = "";
                        x = x + 1;

                    });
                }

                MessageBox.Show("Resizing process has been completed successfully!", "iResizer- Completed!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            catch (Exception U)
            {
                MessageBox.Show(U.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
