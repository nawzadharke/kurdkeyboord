using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kurdish_keybord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        

        string lang = "E";
        private void button31_Click(object sender, EventArgs e)
        {
            if (lang == "E")
            {
                lang = "K";
                button31.Text = lang;

            }
            else
            {
  
                lang = "E";
                button31.Text = lang;
                
            }
            nawzad();


        }
        void nawzad()
        {
            if (lang=="E")
            {
                button1.Text = "Q";
                button2.Text = "W";
                button3.Text = "S";
                button4.Text = "A";
                button8.Text = "E";
                button7.Text = "R";
                button12.Text = "T";
                button11.Text = "Y";
                button16.Text = "U";
                button15.Text = "I";
                button20.Text = "O";
                button19.Text = "P";
                button6.Text = "D";
                button5.Text = "F";
                button10.Text = "G";
                button9.Text = "H";
                button14.Text = "J";
                button13.Text = "K";
                button18.Text = "L";
                button24.Text = "M";
                button25.Text = "N";
                button26.Text = "B";
                button27.Text = "V";
                button28.Text = "C";
                button29.Text = "X";
                button30.Text = "Z";
                button34.Text = "0";
                button35.Text = "9";
                button36.Text = "8";
                button37.Text = "7";
                button38.Text = "6";
                button39.Text = "5";
                button40.Text = "4";
                button41.Text = "3";
                button42.Text = "2";
                button43.Text = "1";
                
            }
            else if(lang=="K")
            {


                button1.Text = "ق";
                button2.Text = "و";
                button3.Text = "س";
                button4.Text = "ا";
                button8.Text = "ە";
                button7.Text = "ر";
                button12.Text = "ت";
                button11.Text = "ی";
                button16.Text = "ئ";
                button15.Text = "ح";
                button20.Text = "ێ";
                button19.Text = "پ";
                button6.Text = "د";
                button5.Text = "ف";
                button10.Text = "گ";
                button9.Text = "ه";
                button14.Text = "ژ";
                button13.Text = "ک";
                button18.Text = "ل";
                button24.Text = "م";
                button25.Text = "ن";
                button26.Text = "ب";
                button27.Text = "ڤ";
                button28.Text = "ج";
                button29.Text = "ح";
                button30.Text = "ز";
                button34.Text = "٠";
                button35.Text = "٩";
                button36.Text = "٨";
                button37.Text = "٧";
                button38.Text = "٦";
                button39.Text = "٥";
                button40.Text = "٤";
                button41.Text = "٣";
                button42.Text = "٢";
                button43.Text = "١";
            }
            else if (lang == "s")
            {
                button1.Text = "q";
                button2.Text = "w";
                button3.Text = "s";
                button4.Text = "a";
                button8.Text = "e";
                button7.Text = "r";
                button12.Text = "t";
                button11.Text = "y";
                button16.Text = "u";
                button15.Text = "i";
                button20.Text = "o";
                button19.Text = "p";
                button6.Text = "d";
                button5.Text = "f";
                button10.Text = "g";
                button9.Text = "h";
                button14.Text = "j";
                button13.Text = "k";
                button18.Text = "l";
                button24.Text = "m";
                button25.Text = "n";
                button26.Text = "b";
                button27.Text = "v";
                button28.Text = "c";
                button29.Text = "x";
                button30.Text = "z";
                button34.Text = "0";
                button35.Text = "9";
                button36.Text = "8";
                button37.Text = "7";
                button38.Text = "6";
                button39.Text = "5";
                button40.Text = "4";
                button41.Text = "3";
                button42.Text = "2";
                button43.Text = "1";


            }

            else if (lang == "@")
            {
                button1.Text = "!";
                button2.Text = "@";
                button3.Text = "#";
                button4.Text = "$";
                button8.Text = "%";
                button7.Text = "^";
                button12.Text = "&";
                button11.Text = "*";
                button16.Text = "(";
                button15.Text = ")";
                button20.Text = "{";
                button19.Text = "}";
                button6.Text = "[";
                button5.Text = "]";
                button10.Text = ":";
                button9.Text = ";";
                button14.Text = "'";
                button13.Text = "?";
                button18.Text = "/";
                button24.Text = ">";
                button25.Text = "<";
                button26.Text = ".";
                button27.Text = ",";
                button28.Text = "+";
                button29.Text = "=";
                button30.Text = "|";
                button34.Text = "~";
                button35.Text = "_";
                button36.Text = "-";
                button37.Text = "`";
                button38.Text = "\\";
                button39.Text = "؛";
                button40.Text = "٪";
                button41.Text = "،";
                button42.Text = "_";
                button43.Text = "؟";


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += button1.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += button15.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nawzad();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += button2.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += button8.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += button7.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += button12.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += button11.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += button16.Text;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text += button20.Text;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text += button19.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += button4.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += button3.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += button6.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += button5.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += button10.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += button9.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += button14.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += button13.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += button18.Text;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox1.Text += button24.Text;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox1.Text += button25.Text;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox1.Text += button26.Text;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox1.Text += button27.Text;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            textBox1.Text += button28.Text;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            textBox1.Text += button29.Text;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            textBox1.Text += button30.Text;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + Environment.NewLine;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength>0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.TextLength - 1);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button32_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " ";
        }

        private void button37_Click(object sender, EventArgs e)
        {

            textBox1.Text += button37.Text;
        }

        private void button44_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button34_Click(object sender, EventArgs e)
        {

            textBox1.Text += button34.Text;
        }

        private void button35_Click(object sender, EventArgs e)
        {

            textBox1.Text += button35.Text;
        }

        private void button36_Click(object sender, EventArgs e)
        {

            textBox1.Text += button36.Text;
        }

        private void button38_Click(object sender, EventArgs e)
        {

            textBox1.Text += button38.Text;
        }

        private void button39_Click(object sender, EventArgs e)
        {

            textBox1.Text += button39.Text;
        }

        private void button40_Click(object sender, EventArgs e)
        {

            textBox1.Text += button40.Text;
        }

        private void button41_Click(object sender, EventArgs e)
        {

            textBox1.Text += button41.Text;
        }

        private void button42_Click(object sender, EventArgs e)
        {

            textBox1.Text += button42.Text;
        }

        private void button43_Click(object sender, EventArgs e)
        {

            textBox1.Text += button43.Text;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (button31.Text=="E")
            {
                lang = "s";
                button31.Text = lang;
            }
            else
            {
                lang = "@";
                button31.Text = lang;
                
            }
            nawzad();
        }

        private void button33_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
