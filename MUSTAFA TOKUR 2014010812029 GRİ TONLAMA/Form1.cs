using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUSTAFA_TOKUR_2014010812029_GRİ_TONLAMA
{
    public partial class Form1 : Form
    {
        Bitmap x, pıc;

        public Form1()
        {
            InitializeComponent();
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "PNG|*.png";
            DialogResult result = saveFileDialog1.ShowDialog();
            ImageFormat format = ImageFormat.Png;
            if (result == DialogResult.OK)
            {
                x.Save(saveFileDialog1.FileName, format);
            }

        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult image = openFileDialog1.ShowDialog();
            if (image == DialogResult.OK)
            {
                pıc = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = pıc;
            }
        }

        private void bt709ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
            if (pictureBox1.Image != null)
            {
                int g = pictureBox1.Width;
                int u = pictureBox1.Height;
                x = new Bitmap(g, u);
                for (int z = 0; z < u; z++)
                {
                    for (int a = 0; a < g; a++)
                    {
                        Color get = pıc.GetPixel(a, z);
                        double bt709 = (get.R * 0.2125) + (get.G * 0.7154) + (get.B * 0.072);
                        int bt = Convert.ToInt32(bt709);
                        Color gri = Color.FromArgb(bt, bt, bt);
                        x.SetPixel(a, z, gri);

                    }

                }
                pictureBox2.Image = x;
            }

            else MessageBox.Show("resim yok");
        }

        private void ortalamaDeğerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
            if (pictureBox1.Image != null)
            {
                int g = pictureBox1.Width;
                int z= pictureBox1.Height;
                x = new Bitmap(g,z);
                for (int q = 0; q < z; q++)
                {
                    for (int ac = 0; ac < g;ac++)
                    {
                    Color ab= pıc.GetPixel(ac, q);
                    double ez=(ab.R+ab.G+ab.B)/3;
                    int ec = Convert.ToInt32(ez);
                    Color gri=Color.FromArgb(ec, ec, ec);
                    x.SetPixel(ac,q,gri);
                    }

           
                }
                pictureBox2.Image=x;
        }
            else MessageBox.Show("resim yok");
        }

        private void lumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
            if (pictureBox1.Image != null)
            {
                int ge = pictureBox1.Width;
                int uz = pictureBox1.Height;
                x = new Bitmap(ge, uz);
                for (int l = 0; l < uz; l++) 

                {
                    for (int i = 0; i < ge; i++)
                    {
                        Color gm = pıc.GetPixel(i, l);
                        double lum = (gm.R * 0.3) + (gm.G * .59) + (gm.B * 0.11);
                        int luma = Convert.ToInt32(lum);
                        Color gri = Color.FromArgb(luma, luma, luma);
                        x.SetPixel(i, l, gri);
                    }
            
                }
                pictureBox2.Image = x;
            }
            else MessageBox.Show("resim yok");

        }

        private void açıklıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
            if (pictureBox1.Image != null) 
            {
                int geni = pictureBox1.Width;
                int uzu = pictureBox1.Height;
                x = new Bitmap(geni, uzu);
                for (int f = 0; f < uzu; f++)
                {
                    for (int g = 0; g < geni; g++)
                    {
                        Color gg = pıc.GetPixel(g, f);
                        int[] aray = { gg.R, gg.G, gg.B };
                        double acıklık = (aray.Max() + aray.Min()) / 2;
                        int acıklı=Convert.ToInt32(acıklık);

                        Color gri = Color.FromArgb(acıklı, acıklı, acıklı);
                        x.SetPixel(g, f, gri);




                    }
              
                }
                pictureBox2.Image=x;



            }
       else MessageBox.Show("resim yok");
        }

        private void kalanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
            if (pictureBox1.Image != null)
            {
                int geniş = pictureBox1.Width;
                int uzunluk = pictureBox1.Height;
                x = new Bitmap(geniş, uzunluk);
                for (int y = 0; y < uzunluk; y++)
                {
                    for (int u = 0; u < geniş; u++)
		
                    {
			 Color gh=pıc.GetPixel(u,y);
            double kala=gh.G;
            int kalan=Convert.ToInt32(kala);
                        Color gri=Color.FromArgb(kalan,kalan,kalan);
                        x.SetPixel(u,y,gri);

			}
                }
                    pictureBox2.Image=x;

            
            }
                else MessageBox.Show( "resim yok");
        }

    }
}
