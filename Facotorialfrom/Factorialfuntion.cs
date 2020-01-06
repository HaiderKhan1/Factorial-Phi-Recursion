using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facotorialfrom
{
    public partial class Form1 : Form
    {

        private long factorial(long n)
        {
            if (n < 2)
            {
                return 1;
            }
            else if (n >= 2)
            {
                return n * factorial(n - 1);
            }
            else
            {
                return -1;
            }
        }
    }

    }

