namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            q2.Visible = false;
            q3.Visible = false;
            txtAns2.Visible = false;
            txtAns3.Visible = false;
            sub2.Visible = false;
            sub3.Visible = false;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                if (sub1.Visible == true)
                {
                    sub1.PerformClick();
                }
                else if (sub2.Visible == true)
                {
                    sub2.PerformClick();
                }
                else if (sub3.Visible == true)
                {
                    sub3.PerformClick();
                }

                e.Handled = true;
            }
        }
        private void sub1_Click(object sender, EventArgs e)
        {
            Start();
        }
        private void sub2_Click(object sender, EventArgs e)
        {
            Q2();
        }

        private void sub3_Click(object sender, EventArgs e)
        {
            var txt1 = txtAns2.Text;
            if (txt1 == "cf")
            {
                ConvCtoF();
            }
            else if (txt1 == "ck")
            {
                ConvCtoK();
            }
            else if (txt1 == "fc")
            {
                ConvFtoC();
            }
            else if (txt1 == "fk")
            {
                ConvFtoK();
            }
            else if (txt1 == "kc")
            {
                ConvKtoC();
            }
            else if (txt1 == "kf")
            {
                ConvKtoF();
            }
        }

        private void Start()
        {
            string get1 = txtAns1.Text;
            string ans1 = get1.ToLower();


            List<string> c = new List<string> { "celsius", "c" };
            List<string> f = new List<string> { "fahrenheit", "f" };
            List<string> k = new List<string> { "kelvin", "k" };

            if (c.Contains(ans1))
            {
                para.Text = "";
                txtAns2.Visible = true;
                sub2.Visible = true;
                q2.Visible = true;
                q2.Text = "Do you want to convert C to F, or C to K?";
                txtAns1.Visible = false;
                sub1.Visible = false;
                q1.Visible = false;
            }
            else if (f.Contains(ans1))
            {
                para.Text = "";
                txtAns2.Visible = true;
                sub2.Visible = true;
                q2.Visible = true;
                q2.Text = "Do you want to convert F to C, or F to K?";
                txtAns1.Visible = false;
                sub1.Visible = false;
                q1.Visible = false;
            }
            else if (k.Contains(ans1))
            {
                para.Text = "";
                txtAns2.Visible = true;
                sub2.Visible = true;
                q2.Visible = true;
                q2.Text = "Do you want to convert K to C, or K to F?";
                txtAns1.Visible = false;
                sub1.Visible = false;
                q1.Visible = false;
            }
            else
            {
                para.Text = "Invalid input. Please enter Kelvin, Fahrenheit, or Celsius.";
            }
        }
        private void Q2()
        {
            string get2 = txtAns2.Text;
            string ans2 = get2.ToLower();

            string[] array = { "cf", "ck", "fc", "fk", "kc", "kf" };

            if (ans2 == array[0])
            {
                para2.Text = "";
                txtAns3.Visible = true;
                sub3.Visible = true;
                q3.Visible = true;
                q3.Text = "Please input the degree number you would like to convert: ";
                txtAns2.Visible = false;
                sub2.Visible = false;
                q2.Visible = false;
                ConvCtoF();
            }
            else if (ans2 == array[1])
            {
                para2.Text = "";
                txtAns3.Visible = true;
                sub3.Visible = true;
                q3.Visible = true;
                q3.Text = "Please input the degree number you would like to convert: ";
                txtAns2.Visible = false;
                sub2.Visible = false;
                q2.Visible = false;
                ConvCtoK();
            }
            else if (ans2 == array[2])
            {
                para2.Text = "";
                txtAns3.Visible = true;
                sub3.Visible = true;
                q3.Visible = true;
                q3.Text = "Please input the degree number you would like to convert: ";
                txtAns2.Visible = false;
                sub2.Visible = false;
                q2.Visible = false;
                ConvFtoC();
            }
            else if (ans2 == array[3])
            {
                para2.Text = "";
                txtAns3.Visible = true;
                sub3.Visible = true;
                q3.Visible = true;
                q3.Text = "Please input the degree number you would like to convert: ";
                txtAns2.Visible = false;
                sub2.Visible = false;
                q2.Visible = false;
                ConvFtoK();
            }
            else if (ans2 == array[4])
            {
                para2.Text = "";
                txtAns3.Visible = true;
                sub3.Visible = true;
                q3.Visible = true;
                q3.Text = "Please input the degree number you would like to convert: ";
                txtAns2.Visible = false;
                sub2.Visible = false;
                q2.Visible = false;
                ConvKtoC();
            }
            else if (ans2 == array[5])
            {
                para2.Text = "";
                txtAns3.Visible = true;
                sub3.Visible = true;
                q3.Visible = true;
                q3.Text = "Please input the degree number you would like to convert: ";
                txtAns2.Visible = false;
                sub2.Visible = false;
                q2.Visible = false;
                ConvKtoF();
            }
            else
            {
                para2.Text = "Invalid input. Please put something similar to the following: CF, CK, FC, or FK.";
            }
        }

        private void ConvCtoF()
        {
            string get3 = txtAns3.Text;

            if (float.TryParse(get3, out float ans3))
            {
                double v = (ans3 * 1.8) + 32;
                double vFin = Math.Round(v);
                para3.Text = $"The temperature from Celsius to Fahrenheit is: {vFin}";
            }
        }
        private void ConvCtoK()
        {
            string get3 = txtAns3.Text;

            if (float.TryParse(get3, out float ans3))
            {
                double v = ans3 + 273.15;
                double vFin = Math.Round(v);
                para3.Text = $"The temperature from Celsius to Fahrenheit is: {vFin}";
            }
        }
        private void ConvFtoC()
        {
            string get3 = txtAns3.Text;

            if (float.TryParse(get3, out float ans3))
            {
                double v = (ans3 - 32) / 1.8;
                double vFin = Math.Round(v);
                para3.Text = $"The temperature from Celsius to Fahrenheit is: {vFin}";
            }
        }
        private void ConvFtoK()
        {
            string get3 = txtAns3.Text;

            if (float.TryParse(get3, out float ans3))
            {
                double v = (ans3 - 32) * 5/9 + 273.15;
                double vFin = Math.Round(v);
                para3.Text = $"The temperature from Celsius to Fahrenheit is: {vFin}";
            }
        }
        private void ConvKtoC()
        {
            string get3 = txtAns3.Text;

            if (float.TryParse(get3, out float ans3))
            {
                double v = ans3 - 273.15;
                double vFin = Math.Round(v);
                para3.Text = $"The temperature from Celsius to Fahrenheit is: {vFin}";
            }
        }
        private void ConvKtoF()
        {
            string get3 = txtAns3.Text;

            if (float.TryParse(get3, out float ans3))
            {
                double v = (ans3 - 273.15) * 9/5 + 32;
                double vFin = Math.Round(v);
                para3.Text = $"The temperature from Celsius to Fahrenheit is: {vFin}";
            }
        }

    }
}
