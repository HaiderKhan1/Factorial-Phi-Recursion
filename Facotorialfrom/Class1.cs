using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facotorialfrom
{
    partial class Form1
    {

            public decimal calcFib(decimal n)
            {
            if ((n == 0) || (n == 1))
            {
                return n;
            }
            else
            {
                return calcFib(n - 1) + calcFib(n - 2);
            }
        }

        public decimal calcPhi(decimal n)
        {
            if ((n == 0) || (n == 1)){
                return n;
            }
            else {
            return (Math.Round(calcFib(n) / calcFib(n - 1),8));
            }
        }


        public void ListFib (decimal size) {
            data = new List<string>();
            richTextBox1.Text = "";

            for (int i = 0; i < size; i++)

            {

                data.Add("Phi:" + calcPhi(i) + "         " + "Fib:" + calcFib(i) + "\n");

          
            }

        }


    }
}
