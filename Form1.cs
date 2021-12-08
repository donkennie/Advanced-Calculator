using System;
using System.Drawing;
using System.Windows.Forms;

namespace StandardBasicCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double number, answer;
        bool Pressed_monitor = false;
        int count;
        public void Disable()
        {
            // this is a method to function as a disable() functionality in which to run off the calculator
            button27.Show();
            OFF.Hide();
            textBox1.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            button21.Enabled = false;
            button22.Enabled = false;
            button23.Enabled = false;
            button24.Enabled = false;
            button25.Enabled = false;
            button26.Enabled = false;          
            button28.Enabled = false;
            button29.Enabled = false;
            button30.Enabled = false;
            button31.Enabled = false;
            button32.Enabled = false;
            button33.Enabled = false;
            button34.Enabled = false;
            textBox1.Text = "";
        }

        public void Enable()
        {

            button27.Hide();
            OFF.Show();
            textBox1.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button20.Enabled = true;
            button21.Enabled = true;
            button22.Enabled = true;
            button23.Enabled = true;
            button24.Enabled = true;
            button25.Enabled = true;
            button26.Enabled = true;
            button28.Enabled = true;
            button29.Enabled = true;
            button30.Enabled = true;
            button31.Enabled = true;
            button32.Enabled = true;
            button33.Enabled = true;
            button34.Enabled = true;


        }

       /* private void button14_Click(object sender, EventArgs e)
        {
            
            //  Button 1 to display in red colour
            textBox1.Text += "1";
            textBox1.ForeColor = Color.Red;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            //  Button 3 to display in red colour
            textBox1.Text += "3";
            textBox1.ForeColor = Color.Red;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
            //  Button 0 to display in red colour
            textBox1.Text += "0";
            textBox1.ForeColor = Color.Red;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            
            //  Button . to display in red colour
            textBox1.Text += ".";
            textBox1.ForeColor = Color.Red;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            
            //  Button 2 to display in red colour
            textBox1.Text += "2";
            textBox1.ForeColor = Color.Red;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            
            //  Button 4 to display in red colour
            textBox1.Text += "4";
            textBox1.ForeColor = Color.Red;
        }

        private void button22_Click(object sender, EventArgs e)
        {
           
            //  Button 5 to display in red colour
            textBox1.Text += "5";
            textBox1.ForeColor = Color.Red; 
        }

        private void button25_Click(object sender, EventArgs e)
        {
            
            //  Button 6 to display in red colour
            textBox1.Text += "6";
            textBox1.ForeColor = Color.Red;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //  Button 7 to display in red colour
            
            textBox1.Text += "7";
            textBox1.ForeColor = Color.Red;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //  Button 8 to display in red colour
            
            textBox1.Text += "8";
            textBox1.ForeColor = Color.Red;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            
            //  Button 9 to display in red colour
            textBox1.Text += "9";
            textBox1.ForeColor = Color.Red;
        }*/

        private void OFF_Click(object sender, EventArgs e) // Button off to disable the program
        {
            Disable(); // Here is where we call the disable() method to off
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Enable();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            number = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 1;
            label1.Text = number.ToString() + "+";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            number = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 2;
            label1.Text = number.ToString() + "-";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            number = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 3;
            label1.Text = number.ToString() + "*";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            number = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 4;
            label1.Text = number.ToString() + "/" ;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Compute(); // Compute() method is called to make the functionality of = button
           // label1.Text = number.ToString(); // Equal to(=) button. 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.ForeColor = Color.BlueViolet;
            textBox1.Text = "0"; // This is a clear button. Empty string only appears on the calculator screen. 
            label1.Text = "";
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Apart from having a Clear button, Backspace is also functional in clearing the entered digits one after the other 
            /*int length = textBox1.TextLength - 1; // 
            string text = textBox1.Text;
            textBox1.Clear();
            for(int i= 0; i < length; i++)
//  Button 6 to display in red colour//  Button 6 to display in red colour            {
                textBox1.Text += text[i];
            }*/
            if(textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }

            if(textBox1.Text== "")
            {
                textBox1.Text = "0";
            }
            textBox1.ForeColor = Color.BlueViolet;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.ForeColor = Color.DarkGreen;
            textBox1.Text = "3.141592653589976323";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double ilog = double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("log" + "(" + (textBox1.Text) + ")");
            ilog = Math.Log10(ilog);
            textBox1.Text = System.Convert.ToString(ilog);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox1.ForeColor = Color.BlueViolet;
            label1.Text = "";
                
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (Pressed_monitor))
                textBox1.Text="";
            Pressed_monitor = false;
            Button num = (Button)sender;
            if(num.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text += num.Text;
            }
            else
            {
                textBox1.Text += num.Text;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            double cos = double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("cos" + "(" + (textBox1.Text) + ")");
            cos = Math.Cos(cos);
            textBox1.Text = System.Convert.ToString(cos);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double sin = double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("sin" + "(" + (textBox1.Text) + ")");
            sin = Math.Sin(sin);
            textBox1.Text = System.Convert.ToString(sin);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            double tan = double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("tan" + "(" + (textBox1.Text) + ")");
            tan = Math.Tan(tan);
            textBox1.Text = System.Convert.ToString(tan);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(textBox1.Text) / Convert.ToDouble(100);
            textBox1.Text = Convert.ToString(a);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double sqrt  = double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("sqrt" + "(" + (textBox1.Text) + ")");
            sqrt = Math.Sqrt(sqrt);
            textBox1.Text = System.Convert.ToString(sqrt);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a, 2);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a, 16);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a, 8);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString(a);
        }

        private void button33_Click(object sender, EventArgs e)
        {
           // Button button = (Button)sender;
            //count = button.Text

        }

        private void button34_Click(object sender, EventArgs e)
        {

        }

        public void Compute()     // This is a method to make functionality of Equal to(=) button.
        {
            switch (count)
            {
               // It grants an answer to any operations.
                case 1:
                    answer = number + double.Parse(textBox1.Text);
                    textBox1.Text = answer.ToString();                   
                   break;
                case 2:
                    answer = number - double.Parse(textBox1.Text);
                    textBox1.Text = answer.ToString();
                    break;
                case 3:
                    answer = number * double.Parse(textBox1.Text);
                    textBox1.Text = answer.ToString();
                    break;
                case 4:
                    answer = number / double.Parse(textBox1.Text);
                    textBox1.Text = answer.ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
