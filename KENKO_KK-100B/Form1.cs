namespace KENKO_KK_100B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> numbers = new List<int>();
        bool calulatorIsON = false;
        double FirstNumber;
        string Operation;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {
            Console.WriteLine(":)");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //while (calulatorIsON == true)
            // {
            textBox1.Text = "0";
            // }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //  while (calulatorIsON == true)
            // {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "00";
            }
            // }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calulatorIsON = true;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button0_Click(object sender, EventArgs e)
        {
            // while (calulatorIsON == true)
            //{
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
            //}
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //while (calulatorIsON == true)
            // {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
            //}
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // while (calulatorIsON == true)
            // {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
            // }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //while (calulatorIsON == true)
            // {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
            // }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // while (calulatorIsON == true)
            // {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
            // }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // while (calulatorIsON == true)
            //{
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
            // }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //while (calulatorIsON == true)
            //{
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
            //}
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //while (calulatorIsON == true)
            //{
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
            // }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //while (calulatorIsON == true)
            //{
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
            //}
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //while (calulatorIsON == true)
            //{
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            calulatorIsON = false;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            //while (calulatorIsON == true)
            //{
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "+";
            //}
        }

        private void button27_Click(object sender, EventArgs e)
        {
            //while (calulatorIsON == true)
            //{
            double SecondNumber;
            double Result;
            SecondNumber = Convert.ToDouble(textBox1.Text);
            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            // Similar code for subtraction, multiplication, and divisio
            //}
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
