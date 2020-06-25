using Scientific_Calculator.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scientific_Calculator
{
    public partial class Form1 : Form
    {
        private string swapDirection;
        private NumberSystem numSys; 

        public Form1()
        {
            InitializeComponent();
            swapDirection = "right";
            numSys = new NumberSystem();
            comboBox1.Text = "Decimal";
            comboBox2.Text = "Binary";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (swapDirection == "right")
            {
                if (comboBox1.Text == "Decimal" && comboBox2.Text == "Decimal")
                {
                    textBox2.Text = textBox1.Text;
                }
                if (comboBox1.Text == "Decimal" && comboBox2.Text == "Hexadecimal")
                {
                    textBox2.Text = numSys.DecimalToHex(Convert.ToDouble(textBox1.Text));
                }
                if (comboBox1.Text == "Decimal" && comboBox2.Text == "Octal")
                {
                    textBox2.Text = numSys.DecimalToOctal(Convert.ToDouble(textBox1.Text));
                }
                if (comboBox1.Text == "Decimal" && comboBox2.Text == "Binary")
                {
                    textBox2.Text = numSys.DecimalToBinary(Convert.ToInt32(textBox1.Text));
                }

                if (comboBox1.Text == "Hexadecimal" && comboBox2.Text == "Hexadecimal")
                {
                    textBox2.Text = textBox1.Text;
                }
                if (comboBox1.Text == "Hexadecimal" && comboBox2.Text == "Decimal")
                {
                    textBox2.Text = numSys.HexToDecimal(textBox1.Text).ToString();
                }
                if (comboBox1.Text == "Hexadecimal" && comboBox2.Text == "Octal")
                {
                    textBox2.Text = numSys.HexToOctal(textBox1.Text);
                }
                if (comboBox1.Text == "Hexadecimal" && comboBox2.Text == "Binary")
                {
                    textBox2.Text = numSys.HexToBinary(textBox1.Text);
                }

                if (comboBox1.Text == "Octal" && comboBox2.Text == "Octal")
                {
                    textBox2.Text = textBox1.Text;
                }
                if (comboBox1.Text == "Octal" && comboBox2.Text == "Decimal")
                {
                    textBox2.Text = numSys.OctalToDecimal(textBox1.Text).ToString();
                }
                if (comboBox1.Text == "Octal" && comboBox2.Text == "Hexadecimal")
                {
                    textBox2.Text = numSys.OctalToHex(textBox1.Text);
                }
                if (comboBox1.Text == "Octal" && comboBox2.Text == "Binary")
                {
                    textBox2.Text = numSys.OctalToBinary(textBox1.Text);
                }

                if (comboBox1.Text == "Binary" && comboBox2.Text == "Binary")
                {
                    textBox2.Text = textBox1.Text;
                }
                if (comboBox1.Text == "Binary" && comboBox2.Text == "Decimal")
                {
                    textBox2.Text = numSys.BinaryToDecimal(textBox1.Text).ToString();
                }
                if (comboBox1.Text == "Binary" && comboBox2.Text == "Hexadecimal")
                {
                    textBox2.Text = numSys.BinaryToHex(textBox1.Text);
                }
                if (comboBox1.Text == "Binary" && comboBox2.Text == "Octal")
                {
                    textBox2.Text = numSys.BinaryToOctal(textBox1.Text);
                }
            }
            else
            {
                if (comboBox1.Text == "Decimal" && comboBox2.Text == "Decimal")
                {
                    textBox1.Text = textBox2.Text;
                }
                if (comboBox1.Text == "Decimal" && comboBox2.Text == "Hexadecimal")
                {
                    textBox1.Text = numSys.HexToDecimal(textBox2.Text).ToString();
                }
                if (comboBox1.Text == "Decimal" && comboBox2.Text == "Octal")
                {
                    textBox1.Text = numSys.OctalToDecimal(textBox2.Text).ToString();
                }
                if (comboBox1.Text == "Decimal" && comboBox2.Text == "Binary")
                {
                    textBox1.Text = numSys.BinaryToDecimal(textBox2.Text).ToString();
                }

                if (comboBox1.Text == "Hexadecimal" && comboBox2.Text == "Hexadecimal")
                {
                    textBox1.Text = textBox2.Text;
                }
                if (comboBox1.Text == "Hexadecimal" && comboBox2.Text == "Decimal")
                {
                    textBox1.Text = numSys.DecimalToHex(Convert.ToDouble(textBox2.Text)).ToString();
                }
                if (comboBox1.Text == "Hexadecimal" && comboBox2.Text == "Octal")
                {
                    textBox1.Text = numSys.OctalToHex(textBox2.Text);
                }
                if (comboBox1.Text == "Hexadecimal" && comboBox2.Text == "Binary")
                {
                    textBox1.Text = numSys.BinaryToHex(textBox2.Text);
                }

                if (comboBox1.Text == "Octal" && comboBox2.Text == "Octal")
                {
                    textBox1.Text = textBox2.Text;
                }
                if (comboBox1.Text == "Octal" && comboBox2.Text == "Decimal")
                {
                    textBox1.Text = numSys.DecimalToOctal(Convert.ToDouble(textBox2.Text)).ToString();
                }
                if (comboBox1.Text == "Octal" && comboBox2.Text == "Hexadecimal")
                {
                    textBox1.Text = numSys.HexToOctal(textBox2.Text);
                }
                if (comboBox1.Text == "Octal" && comboBox2.Text == "Binary")
                {
                    textBox1.Text = numSys.BinaryToOctal(textBox2.Text);
                }

                if (comboBox1.Text == "Binary" && comboBox2.Text == "Binary")
                {
                    textBox1.Text = textBox2.Text;
                }
                if (comboBox1.Text == "Binary" && comboBox2.Text == "Decimal")
                {
                    textBox1.Text = numSys.DecimalToBinary(Convert.ToInt32(textBox2.Text)).ToString();
                }
                if (comboBox1.Text == "Binary" && comboBox2.Text == "Hexadecimal")
                {
                    textBox1.Text = numSys.HexToBinary(textBox2.Text);
                }
                if (comboBox1.Text == "Binary" && comboBox2.Text == "Octal")
                {
                    textBox1.Text = numSys.OctalToBinary(textBox2.Text);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (swapDirection == "right")
            {
                swapDirection = "left";
                label1.Text = "<<";
            }
            else
            {
                swapDirection = "right";
                label1.Text = ">>";
            }
        }
    }
}
