using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MemoryGame
{
    public partial class MyControls : UserControl
    {
        public delegate void MyControlEventHandler(object sender, MyControlEventArgs args);
        public event MyControlEventHandler OnButtonClick;

        public MyControls()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            MyControlEventArgs retvals = new MyControlEventArgs(true, txtName.Text);
                                                       
            OnButtonClick(this, retvals);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MyControlEventArgs retvals = new MyControlEventArgs(false, txtName.Text);
                                                         
            OnButtonClick(this, retvals);
        }
    }
}
