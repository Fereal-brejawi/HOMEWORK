using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class griiFr : Form
    {
        Bitmap kaynak, islem;
        public griiFr()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void uygulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void ortalamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;
            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color pixel = kaynak.GetPixel(x, y);
                    int griDeger = (pixel.R + pixel.G + pixel.B) / 3;
                    Color gripixel = Color.FromArgb(griDeger, griDeger, griDeger);
                    islem.SetPixel(x, y, gripixel);



                }
            }
            islemBox.Image = islem;
        }

        private void griiFr_Load(object sender, EventArgs e)
        {

        }

        private void bTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;
            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color pixel = kaynak.GetPixel(x, y);
                    int BTDeger = (int)(pixel.R * 0.2125 + pixel.G * 0.7154 + pixel.B * 0.072);
                    Color BTpixel = Color.FromArgb(BTDeger, BTDeger, BTDeger);
                    islem.SetPixel(x, y, BTpixel);

                }
            }
            islemBox.Image = islem;

        }
        
        private void LumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;
            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color pixel = kaynak.GetPixel(x, y);
                    int lumaDeger = (int)(pixel.R * 0.3 + pixel.G * 0.59 + pixel.B * 0.11);
                    Color lumaPixel = Color.FromArgb(lumaDeger, lumaDeger, lumaDeger);
                    islem.SetPixel(x, y, lumaPixel);

                }
            }
            islemBox.Image = islem;
        }

        private void açıklıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;
            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color pixel = kaynak.GetPixel(x, y);
                    int min = Math.Min(pixel.R, Math.Min((pixel.G), (pixel.B)));
                    int max = Math.Max(pixel.R, Math.Max((pixel.G), (pixel.B)));
                    int deger = (max - min) / 2;
                    Color acıkPixel = Color.FromArgb(deger, deger, deger);
                    islem.SetPixel(x, y, acıkPixel);



                }
            }
            islemBox.Image = islem;
        }

        private void tekRenkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;
            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color pixel = kaynak.GetPixel(x, y);
                    Color myPixel = Color.FromArgb(pixel.R, pixel.R, pixel.R);
                    islem.SetPixel(x, y, myPixel);



                }
            }
            islemBox.Image = islem;
        }

        private void normalizingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;
            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color pixel = kaynak.GetPixel(x, y);
                    int Ir = pixel.R;
                    int Ig = pixel.G;
                    int Ib = pixel.B;
                    int T = (pixel.R + pixel.G + pixel.B);
                    if (T == 0)
                    {
                        Ir = 0;
                        Ig = 0;
                        Ib = 0;
                    }
                    if (T > 0)
                    {
                        Ir = 255 * pixel.R / T;
                        Ig = 255 * pixel.G / T;
                        Ib = 255 * pixel.B / T;
                    }
                    Color NPixel = Color.FromArgb(Ib, Ib, Ib);
                    islem.SetPixel(x, y, NPixel);



                }
            }
            islemBox.Image = islem;
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                kaynak = new Bitmap(openFileDialog1.FileName);
                kaynakBox.Image = kaynak;
            }
        }
    }
}

