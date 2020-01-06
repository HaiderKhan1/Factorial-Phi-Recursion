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
       
        private decimal fib(decimal n)
        {
                decimal number = n - 1; //Need to decrement by 1 since we are starting from 0  
                decimal[] Fib = new decimal[number + 1];
                Fib[0] = 0;
                Fib[1] = 1;
                for (decimal i = 2; i <= number; i++)
                {
                    Fib[i] = Fib[i - 2] + Fib[i - 1];
                }
                return Fib[number];
            
        }

        
  
    }

    }

