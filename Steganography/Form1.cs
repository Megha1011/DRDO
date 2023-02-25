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

namespace Steganography
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonEcode_Click(object sender, EventArgs e)
        {
            
            Bitmap img = new Bitmap(textFilePath.Text.ToString());
    
           // BitmapData bmpdata = img.LockBits(rect, ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);



            for(int i = 0;i<img.Width;i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                   // Rectangle rect = new Rectangle(i, j, img.Width, img.Height);
                    Color Pixel = img.GetPixel(i, j);

                    if (i < 1 && j < textMessageBox.TextLength)
                    {
                        Console.WriteLine("R = {" + i + "}{" + j + "}" + Pixel.R);
                        Console.WriteLine("G = {" + i + "}{" + j + "}" + Pixel.G);
                        Console.WriteLine("B = {" + i + "}{" + j + "}" + Pixel.B);

                        char letter = Convert.ToChar(textMessageBox.Text.Substring(j, 1));
                        Console.WriteLine("letter"+letter);
                        
                        int value = Convert.ToInt32(letter);

                        Color temp = Color.FromArgb(0,Pixel.R, Pixel.G, value);
                        Console.WriteLine("letter :" + letter + "value :" + value + "color" + temp);

                      //  img.LockBits(rect,ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);

                        
                        img.SetPixel(i, j, temp);
                        Console.WriteLine("after inserting letter :" + Pixel.R + ":" + Pixel.G+ ":" + Pixel.B);


                    }
                }
              
            }

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = "Image Files (*.png,  *.jpg) | *.png;*.jpg";
            savefile.InitialDirectory = @"C:\";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                textFilePath.Text = savefile.FileName.ToString();
                pictureBox1.ImageLocation = textFilePath.Text;

                img.Save(textFilePath.Text);
            }
        }

        private void buttonDecode_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(textFilePath.Text);
            String message = "";


            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color Pixel = img.GetPixel(i, j);

                    if (i < 1 && j < 10)
                    {
                        int value = Pixel.B;
                        Console.WriteLine("decoding"+value);
                        char c = Convert.ToChar(value);

                        String letter = Encoding.ASCII.GetString(new byte[] { Convert.ToByte(c) });

                        //Console.WriteLine("---------------------"+letter);
                        message = message + letter;

                    }
                }

            }
            textMessageBox.Text = message;
        }

        private void buttonOpenfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "Image Files (*.png,  *.jpg) | *.png;*.jpg";
            openfile.InitialDirectory = @"C:\";

            if(openfile.ShowDialog() == DialogResult.OK)
            {
                textFilePath.Text = openfile.FileName.ToString();
                pictureBox1.ImageLocation = textFilePath.Text;
            } 
        }

        private void textFilePath_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
