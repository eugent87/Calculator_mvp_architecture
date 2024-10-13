
namespace Calculator
{
    public partial class Calculator_Model : Form, ICalculator_View
    {
        public Calculator_Model()
        {
            InitializeComponent();
            guna2CircleButton0.Click += (s, e) => Number_button?.Invoke(this, "0");
            guna2CircleButton1.Click += (s, e) => Number_button?.Invoke(this, "1");
            guna2CircleButton2.Click += (s, e) => Number_button?.Invoke(this, "2");
            guna2CircleButton3.Click += (s, e) => Number_button?.Invoke(this, "3");
            guna2CircleButton4.Click += (s, e) => Number_button?.Invoke(this, "4");
            guna2CircleButton5.Click += (s, e) => Number_button?.Invoke(this, "5");
            guna2CircleButton6.Click += (s, e) => Number_button?.Invoke(this, "6");
            guna2CircleButton7.Click += (s, e) => Number_button?.Invoke(this, "7");
            guna2CircleButton8.Click += (s, e) => Number_button?.Invoke(this, "8");
            guna2CircleButton9.Click += (s, e) => Number_button?.Invoke(this, "9");



            guna2CircleButton_clear.Click += (s, e) => Clear?.Invoke(this, EventArgs.Empty);
            guna2CircleButton_calculate.Click += (s, e) => Calculate?.Invoke(this, EventArgs.Empty);



            guna2CircleButton_plus.Click += (s, e) => Operation?.Invoke(this, "+");
            guna2CircleButton_minus.Click += (s, e) => Operation?.Invoke(this, "-");
            guna2CircleButton_multiply.Click += (s, e) => Operation?.Invoke(this, "*");
            guna2CircleButton_divide.Click += (s, e) => Operation?.Invoke(this, "/");
        }

        public string DisplayText { get => txt.Text; set => txt.Text = value; }

        public event EventHandler Calculate;
        public event EventHandler Clear;
        public event EventHandler<string> Operation;
        public event EventHandler<string> Number_button;

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton4_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton5_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton6_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton7_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton8_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton9_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton0_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton_plus_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton_minus_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton_multiply_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton_divide_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton_clear_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton_calculate_Click(object sender, EventArgs e)
        {

        }
    }
}
