using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace MemoryGame
{
    public partial class Easy : Form
    {
        public Easy()
        {
            InitializeComponent();
        }
         int counter = 0;
         PictureBox pictures;
         int pairs = 8;
         int time = 0;
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
               
                pairs--;
                if (pairs == 0)
                {
                    left.Text = "Good game!";
                    timer1.Stop();
                }
                else
                    left.Text = "Left to find " + pairs + " pairs";
                
            }
            else
            {
               Application.DoEvents();
               System.Threading.Thread.Sleep(400);
               try
               {
                   previous.Image = Image.FromFile(@"..\\..\\..\\MemoryGame\Resources\que2.png");
                   next.Image = Image.FromFile(@"..\\..\\..\\MemoryGame\Resources\que2.png");
               }
               catch (FileNotFoundException)
               {

                   MessageBox.Show("Failed");

               };
                
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            StartImage();
            First();
            HandOut();
   
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
        void HandOut ()
        {
            int[] numbers = new int[16];
            Random r = new Random();

            int i = 0;
            while (i<16)
            {
                int rand = r.Next(1, 17);
                if (Array.IndexOf(numbers, rand) == -1)
                {
                    numbers[i] = rand;
                    i++;
                }
            }

            for (int j = 0; j < 16; j++)
            {
                if (numbers[j] > 8)
                    numbers[j] -= 8;
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
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            PictureBox wopper = (sender as PictureBox);
            try
            {
                string str = @"..\\..\\..\\MemoryGame\Resources\" + (sender as PictureBox).Tag.ToString() + ".png";
         
            wopper.Image = Image.FromFile(str);
            }

            catch (FileNotFoundException)
            {

                MessageBox.Show("Failed");

            };

            if (counter == 0)
            {
                pictures = wopper;
                counter++;
            }

            else
            {
                if (pictures == wopper)
                {
                  
                    counter = 0;
                    pictures.Image = Image.FromFile(@"..\\..\\..\\MemoryGame\Resources\que2.png");
                }
                else
                {
                    K (pictures, wopper);
                    counter = 0;
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

        public void Retry_Click(object sender, EventArgs e)
        {
            Retry();
            StartImage();
            First();
            HandOut();
            pairs = 8;
            counter = 0;
            time = 0;
            timer1.Start();
            //timer1.Tick += new EventHandler(timer1_Tick_1);
           
        }

        
        
        public void timer1_Tick_1(object sender, EventArgs e)
        {
            time += 1;
            label1.Text = "Your time is " + time + " s";
            if (pairs == 0)
            {
                timer1.Stop();
            }
            
        }

        //private double calculateScore(int time)
        //{
        //    //int score = 0;
        //    int flips = 8;
        //    double timeScore = 100f * (20f / time);

        //    double flipScore = 500f * (20f / flips);
        //    double score = timeScore + flipScore;
        //    labelScore.Text = "Your score is " + score;
        //    return score;
        //}

        

       
       
       
    }
}
