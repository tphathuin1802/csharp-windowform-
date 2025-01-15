namespace EquationLevel1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtCofA_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            txtCofA.Text = "";
            txtCofB.Text = "";
            txtResult.Text = string.Empty;
            txtCofA.Focus();
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            double cofa = double.Parse(txtCofA.Text);
            double cofb = double.Parse(txtCofB.Text);
            if (cofa == 0 && cofb == 0)
            {
                txtResult.Text = "Infinity No";
            }
            else if (cofa == 0 && cofb != 0)
            {
                txtResult.Text = "None No";
            }
            else
            {
                txtResult.Text = "x=" + (-cofb / cofa);

            }
        }
    }
}
