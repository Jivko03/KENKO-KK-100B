using System.Web;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        double MRC = 0;
        double Mp;
        double Mm;
        string memory;
        double GT;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

            label10.Visible = false;
            if (textBox1.Text.Length < 12 && calulatorIsON == true)
            {
                label10.Visible = false;
                if (textBox1.Text.Contains(".") && textBox1.Text != null)
                {
                    return;
                }
                else
                {
                    textBox1.Text = textBox1.Text + ".";
                }
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Console.WriteLine(":)");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (calulatorIsON == true)
            {
                //while (calulatorIsON == true)
                // {
                textBox1.Text = "0";
            }
            label10.Visible = false;
            // }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            label10.Visible = false;

            if (textBox1.Text.Length < 12 && calulatorIsON == true)
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calulatorIsON = true;
            label10.Visible = false;
            textBox1.Text = "0";
            FirstNumber = 0;
            Operation = "";
            MRC = 0;
            Mp = 0;
            Mm = 0;
            memory = "";
            GT = 0;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button0_Click(object sender, EventArgs e)
        {
            label10.Visible = false;

            if (textBox1.Text.Length < 12 && calulatorIsON == true)
            {
                label10.Visible = false;
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
        }

        private void button13_Click(object sender, EventArgs e)
        {

            label10.Visible = false;
            if (textBox1.Text.Length < 12 && calulatorIsON == true)
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
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label10.Visible = false;

            if (textBox1.Text.Length < 12 && calulatorIsON == true)
            {
                label10.Visible = false;
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
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label10.Visible = false;

            if (textBox1.Text.Length < 12 && calulatorIsON == true)
            {
                label10.Visible = false;
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
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label10.Visible = false;

            if (textBox1.Text.Length < 12 && calulatorIsON == true)
            {
                label10.Visible = false;
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
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label10.Visible = false;

            if (textBox1.Text.Length < 12 && calulatorIsON == true)
            {
                label10.Visible = false;
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
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label10.Visible = false;

            if (textBox1.Text.Length < 12 && calulatorIsON == true)
            {
                label10.Visible = false;
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
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label10.Visible = false;

            if (textBox1.Text.Length < 12 && calulatorIsON == true)
            {
                label10.Visible = false;
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
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label10.Visible = false;

            if (textBox1.Text.Length < 12 && calulatorIsON == true)
            {
                label10.Visible = false;
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
        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Length < 12 && calulatorIsON == true)
            {
                label10.Visible = false;
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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            calulatorIsON = false;
            label10.Visible = false;
            textBox1.Text = "";
            FirstNumber = 0;
            Operation = "";
            MRC = 0;
            Mp = 0;
            Mm = 0;
            memory = "";
            GT = 0;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            label10.Visible = false;
            if (calulatorIsON == true)
            {
                FirstNumber = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "0";
                Operation = "+";
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (calulatorIsON == true)
            {
                //while (calulatorIsON == true)
                //{
                label10.Visible = false;
                double SecondNumber;
                string Result;
                double placeholder;
                SecondNumber = Convert.ToDouble(textBox1.Text);
                if (Operation == "+")
                {
                    placeholder = (FirstNumber + SecondNumber);
                    Result = Convert.ToString(placeholder);
                    GT += Convert.ToDouble(Result);
                    if (Result.Length > 12)
                    {
                        textBox1.Text = Result.Substring(0, 12);
                    }
                    else
                    {
                        textBox1.Text = Result;
                    }
                    FirstNumber = placeholder;

                }
                // Similar code for subtraction, multiplication, and divisio
                if (Operation == "*")
                {
                    placeholder = (FirstNumber * SecondNumber);
                    Result = Convert.ToString(placeholder);
                    GT += Convert.ToDouble(Result);
                    if (Result.Length > 12)
                    {
                        textBox1.Text = Result.Substring(0, 12);
                    }
                    else
                    {
                        textBox1.Text = Result;
                    }
                    FirstNumber = placeholder;
                }
                if (Operation == "%")
                {
                    placeholder = (FirstNumber % SecondNumber);
                    Result = Convert.ToString(placeholder);
                    GT += Convert.ToDouble(Result);
                    if (Result.Length > 12)
                    {
                        textBox1.Text = Result.Substring(0, 12);
                    }
                    else
                    {
                        textBox1.Text = Result;
                    }
                    FirstNumber = placeholder;
                }
                if (Operation == "/")
                {
                    placeholder = (FirstNumber / SecondNumber);
                    Result = Convert.ToString(placeholder);
                    GT += Convert.ToDouble(Result);
                    if (Result.Length > 12)
                    {
                        textBox1.Text = Result.Substring(0, 12);
                    }
                    else
                    {
                        textBox1.Text = Result;
                    }
                    FirstNumber = placeholder;
                }
                if (Operation == "-")
                {
                    placeholder = (FirstNumber - SecondNumber);
                    Result = Convert.ToString(placeholder);
                    GT += Convert.ToDouble(Result);
                    if (Result.Length > 12)
                    {
                        textBox1.Text = Result.Substring(0, 12);
                    }
                    else
                    {
                        textBox1.Text = Result;
                    }
                    FirstNumber = placeholder;
                }
            }
            //}
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (calulatorIsON == true)
            {
                Mm = Convert.ToDouble(textBox1.Text);
                MRC -= Mm;
                label10.Visible = true;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            label10.Visible = false;
            if (calulatorIsON == true)
            {

                FirstNumber = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "0";
                Operation = "*";
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (calulatorIsON == true)
            {
                FirstNumber = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "0";
                Operation = "%";
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (calulatorIsON == true)
            {
                FirstNumber = Convert.ToDouble(textBox1.Text);
                double Result;
                Result = Math.Sqrt(FirstNumber);
                string squrt = Convert.ToString(Result);
                if (squrt.Length > 13)
                {
                    textBox1.Text = squrt.Substring(0, 13);
                }
                else
                {
                    textBox1.Text = squrt;
                }
                FirstNumber = Result;
                GT += Math.Round(Result, 12);
            }
            label10.Visible = false;

        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (calulatorIsON == true)
            {
                FirstNumber = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "0";
                Operation = "/";
            }
            label10.Visible = false;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (calulatorIsON == true)
            {
                FirstNumber = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "0";
                Operation = "-";
            }
            label10.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && calulatorIsON == true)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
            label10.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (calulatorIsON == true)
            {
                string mrc = Convert.ToString(MRC);
                if (mrc.Length > 12)
                {
                    textBox1.Text = mrc.Substring(0, 12);
                }
                else
                {
                    textBox1.Text = mrc;
                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (calulatorIsON == true)
            {
                Mp = Convert.ToDouble(textBox1.Text);
                MRC += Mp;
                label10.Visible = true;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (calulatorIsON == true)
            {
                string gt = Convert.ToString(GT);
                if (gt.Length > 12)
                {
                    textBox1.Text = gt.Substring(0, 12);
                }
                else
                {
                    textBox1.Text = gt;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
