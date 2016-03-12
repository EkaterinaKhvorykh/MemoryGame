using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Hard : Form
    {
        public Hard()
        {
            InitializeComponent();
        }

        private void Hard_Load(object sender, EventArgs e)
        {
            StartImage();
            First();
            HandOut();
        }

        int schetchik = 0;
        PictureBox pictures2;
        int pairs2 = 18;
        void StartImage()
        {
            foreach (Control x in Controls)
            {
                if (x is PictureBox)
                {
                    (x as PictureBox).Image = Properties.Resources.que;

                }
            }
        }
        void K(PictureBox previous, PictureBox next)
        {
            if (previous.Tag.ToString() == next.Tag.ToString())
            {
                Application.DoEvents();
                System.Threading.Thread.Sleep(400);
                previous.Visible = true;
                next.Visible = true;

                pairs2--;
                //if (pairs2 == 0) left.Text = "Good game";
                //else
                    //left.Text = "Left to find " + pairs + " pairs";
                //pictures.Dispose();
            }
            else
            {
                Application.DoEvents();
                System.Threading.Thread.Sleep(400);
                previous.Image = Image.FromFile(@"..\\..\\..\\MemoryGame\Resources\que2.png");
                next.Image = Image.FromFile(@"..\\..\\..\\MemoryGame\Resources\que2.png");


            }

        }

        void First()
        {
            foreach (Control x in Controls)
            {
                if (x is PictureBox)
                {
                    (x as PictureBox).Tag = "0";
                }
            }
        }
        void HandOut()
        {
            int[] numbers = new int[36];
            Random r = new Random();

            int i = 0;
            while (i < 36)
            {
                int rand = r.Next(1, 37);
                if (Array.IndexOf(numbers, rand) == -1)
                {
                    numbers[i] = rand;
                    i++;
                }
            }

            for (int j = 0; j < 36; j++)
            {
                if (numbers[j] > 18)
                    numbers[j] -= 18;
            }
            int k = 0;
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    x.Tag = numbers[k].ToString();
                    k++;
                }
            }
        }

        private void PB_Click(object sender, EventArgs e)
        {
            PictureBox wopper1 = (sender as PictureBox);
            string strin = @"..\\..\\..\\MemoryGame\Resources\SuperMario\" + (sender as PictureBox).Tag.ToString() + ".png";
            wopper1.Image = Image.FromFile(strin);
            if (schetchik == 0)
            {
                pictures2 = wopper1;
                schetchik++;
            }
            else
            {
                if (pictures2 == wopper1)
                {

                   schetchik = 0;
                    pictures2.Image = Image.FromFile(@"..\\..\\..\\MemoryGame\Resources\que2.png");
                }
                else
                {
                    K(pictures2, wopper1);
                    schetchik = 0;
                }
            }
        }
                    void Retry()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    (x as PictureBox).Visible = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Retry();
            StartImage();
            First();
            HandOut();
            pairs2 = 8;
            schetchik = 0;
           
        }
    }


           
        }
    

        

        
    

