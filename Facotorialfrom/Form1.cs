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

namespace Facotorialfrom
{
    public partial class Form1 : Form
    {
        private List<string> data;
        private StreamReader reader;
        private StreamWriter writer;
        decimal currentsize;

        public Form1()
        {
        
            InitializeComponent();
            data = new List<string>();
           
            l_result.Width = this.Width - 2 *l_result.Location.X;
            
        }

        private void B_calc_Click(object sender, EventArgs e)
        {
            l_result.Text = calcFib(numericUpDown1.Value).ToString();
            l_phi.Text = calcPhi(numericUpDown1.Value).ToString();
            currentsize = numericUpDown1.Value -1;
            ListFib(currentsize);
 

            for (int i = 0; i < numericUpDown1.Value; i++)

            {

                richTextBox1.Text += "Phi:"  + calcPhi(i) + "         " + "Fib:" + calcFib(i) + "\n" ;
             

            }

  
        }

        private void L_result_Click(object sender, EventArgs e)
        {

        }

        // this funtion show phi is from an older version, this version will display all fib numbers 
        private void C_showphi_CheckedChanged(object sender, EventArgs e)
        {
            if (c_showphi.Checked)
            {
                Form1.ActiveForm.Height = 600;
            } 
            else
            {
                Form1.ActiveForm.Height = 350;
            }

        }

        private void B_readData_Click(object sender, EventArgs e)
        {
            reader = new StreamReader(textBox1.Text);
            //erase the data list
            data = new List<string>();
           
            
            //display fib values
            ListFib(currentsize);
            for (int i = 0; i < currentsize; i++)
            {
                string nextLine = reader.ReadLine();
                if (nextLine == null)//check for the end of file
                {
                    break;
                }
                else
                {
                    data.Add((nextLine));
                    richTextBox1.Text += data[i] + "\n";
                }

            }


            reader.Close();
        }

        private void B_writeData_Click(object sender, EventArgs e)
        {
            
            writer = new StreamWriter(textBox1.Text);
            //write fib values
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                if (i > data.Count - 1)
                {
                    break;
                }
                else
                {
                    writer.WriteLine(data[i].ToString());
                }

            }
            writer.Close();
        }

        private void List_fib_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
