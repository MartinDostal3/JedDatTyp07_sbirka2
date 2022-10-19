using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JedDatTyp07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pP = 0;
            int pC = 0;
            int pOL = 0;
            int pZ = 0;
            listBox1.Items.Clear();

            for(int i = 0; i < textBox1.Lines.Count(); i++)
            {
                char znak = char.Parse(textBox1.Lines[i].ToString());
                if((char.IsLower(znak)) || (char.IsUpper(znak)))
                {
                    pP++;
                }
                else if(char.IsDigit(znak))
                {
                    pC++;
                }
                else if(znak == '\\' )
                {
                    pOL++;
                }
                else
                {
                    pZ++;
                }

                if(radioButton1.Checked)
                {
                    if(char.IsUpper(znak))
                    {
                        char malePismeno = char.ToLower(znak);
                        listBox1.Items.Add(znak);
                        listBox1.Items.Add(malePismeno);
                    }
                }
                else
                {
                    if (char.IsLower(znak))
                    {
                        char velkePismeno = char.ToUpper(znak);
                        listBox1.Items.Add(znak);
                        listBox1.Items.Add(velkePismeno);
                    }
                }


            }
            MessageBox.Show("Pocet pismen je: " + pP + "\nPocet cifer je: " + pC + "\nPocet zpetnych lomitek je: " + pOL + "\nPocet jinych znaku je: " + pZ);




        }
    }
}
