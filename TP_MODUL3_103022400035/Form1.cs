namespace TP_MODUL3_103022400035
{
    public partial class Form1 : Form
    {
        double total = 0;
        string input = "";
        string display = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            input += "1";
            display += "1";
            label1.Text = display;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            input += "2";
            display += "2";
            label1.Text = display;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            input += "3";
            display += "3";
            label1.Text = display;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            input += "4";
            display += "4";
            label1.Text = display;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            input += "5";
            display += "5";
            label1.Text = display;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            input += "6";
            display += "6";
            label1.Text = display;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            input += "7";
            display += "7";
            label1.Text = display;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            input += "8";
            display += "8";
            label1.Text = display;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            input += "9";
            display += "9";
            label1.Text = display;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            total += Convert.ToDouble(input);
            display += " + ";
            input = "";

            label1.Text = display;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            input += "0";
            display += "0";
            label1.Text = display;
        }
        private void button12_Click(object sender, EventArgs e)
        {
            total += Convert.ToDouble(input);
            display += " = " + total.ToString();

            label1.Text = display;

            // hasil menjadi input baru 
            input = total.ToString();
            display = input;
            total = 0;
        }
    }
}
