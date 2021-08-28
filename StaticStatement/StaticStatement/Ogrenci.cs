using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaticStatement
{
    class Ogrenci
    {
        public static int Numara { get; set; }
        public static void Not()
        {
            MessageBox.Show("Test");
            
        }
    }
}
