namespace EquationLevel2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {
            txtCofA.Text = "";
            txtCofB.Text = string.Empty;
            txtCofC.Text = string.Empty;
            txtResult.Text = string.Empty;
            txtCofA.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show(
                "Do you want to exit application?",
                "Confirm to exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtCofA.Text);
            double b = double.Parse(txtCofB.Text);
            double c = double.Parse(txtCofC.Text);

            if (a == 0)
            {
                if (b == 0 && c == 0)
                {
                    txtResult.Text = "Infinity No!";
                }
                else if (b == 0 && c != 0)
                {
                    txtResult.Text = "None No!";
                }
                else
                {
                    txtResult.Text = "x=" + (-c / b);
                }
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    lblKetQua.Text = "Vô nghiệm";
                }
                else if (delta == 0)
                {
                    txtResult.Text = "No kép x1=x2=" + (-b / (2 * a));
                }
                else
                {
                    double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                    txtResult.Text = "x1=" + x1 + ";x2=" + x2;
                }
            }
        }
    }
}
