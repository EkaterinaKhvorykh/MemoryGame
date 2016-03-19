using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;


namespace MemoryGame
{
    public partial class PlayerName : Form
    {
        
        public PlayerName()
        {
            InitializeComponent();
        }

        public void PName()
        {
            var pn = new PlayerName();
            pn.Show(); 
        }
        
    }

    public class Person
    {

       public int ID { get; private set; }
       public string Name { get; set; }
       public bool IsOK { get; set; }

       public Person(int id)
       {
           this.ID = id;
       }

    }

 


}
