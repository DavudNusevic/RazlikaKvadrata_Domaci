using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RazlikaKvadrata_Domaci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            namestanjeKomponenti();
        }

        private void Form1_Resize(object sender, EventArgs e)
        { 
            namestanjeKomponenti();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            
            if( !int.TryParse(textBox1.Text, out a) || !int.TryParse(textBox2.Text, out b) ) 
            {
                MessageBox.Show("Invalidan unos");
                return;
            }

            if (sender == button1)
                textBox3.Text = (a * a - b * b).ToString();
            else
                textBox3.Text = ((a - b) * (a - b)).ToString(); 
        }

        private void namestanjeKomponenti()
        {

            textBox1.Font = label1.Font;
            textBox2.Font = label1.Font;
            label2.Font = label1.Font;
            button1.Font = label1.Font;
            button2.Font = label1.Font;
            textBox3.Font = label1.Font;
            label3.Font = label1.Font;

            //textBox1 pozicioniranje i namestanje velicine
            textBox1.Top = ClientRectangle.Height / 10;
            textBox1.Left = ClientRectangle.Width / 5;
            textBox1.Width = ClientRectangle.Width / 10 * 7;

            //textBox2 pozicioniranje i namestanje velicine
            textBox2.Top = ClientRectangle.Height / 4;
            textBox2.Left = ClientRectangle.Width / 5;
            textBox2.Width = ClientRectangle.Width / 10 * 7;

            //label1 pozicioniranje i namestanje velicine
            label1.Top = textBox1.Top + (textBox1.Height - label1.Height) / 2;
            label1.Left = textBox1.Left - label1.Width - ClientRectangle.Width / 20;
            
            //label2 pozicioniranje i namestanje velicine
            label2.Top = textBox2.Top + (textBox2.Height - label2.Height) / 2;
            label2.Left = textBox2.Left - label1.Width - ClientRectangle.Width / 20;

            //button1 pozicioniranje i namestanje velicine
            button1.Left = textBox1.Left;
            button1.Top = ClientRectangle.Height / 20 * 9;
            button1.Width = textBox1.Width;
            button1.Height = textBox1.Height;

            //button2 pozicioniranje i namestanje velicine
            button2.Left = textBox1.Left;
            button2.Top = button1.Top + (textBox2.Top - textBox1.Top);
            button2.Width = textBox1.Width;
            button2.Height = textBox1.Height;

            //textBox3 pozicioniranje i namestanje velicine
            textBox3.Top = ClientRectangle.Height / 5 * 4;
            textBox3.Left = ClientRectangle.Width / 5;
            textBox3.Width = ClientRectangle.Width / 10 * 7;

            //label3 pozicioniranje i namestanje velicine
            label3.Top = textBox3.Top + (textBox1.Height - label1.Height) / 2;
            label3.Left = textBox1.Left - label1.Width - ClientRectangle.Width / 20;

        }

    }
}
