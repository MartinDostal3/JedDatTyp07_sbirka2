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

            for(int i = 0; i < textBox1.Lines.Count(); i++)
            {
                char znak = char.Parse(textBox1.Lines[i].ToString());
                if(znak == '\\' )
                {
                    pOL++;
                }


            }




        }
    }
}
