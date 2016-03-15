using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MemoryGame
{
    class MyControlEventArgs : EventArgs 
    {
        private string _Name;
        private bool _IsOK;

        public MyControlEventArgs(bool result, string name)
        {
            _IsOK = result;
            _Name = name;
        }
        public string MyName
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public bool IsOK
        {
            get { return _IsOK; }
            set { _IsOK = value; }
        }

             
    }
}
