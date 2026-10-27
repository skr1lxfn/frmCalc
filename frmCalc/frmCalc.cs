namespace frmCalc
{
    public partial class frmCalc : Form
    {

        public frmCalc()
        {
            InitializeComponent();
        }

        bool newOperation = true;
        double firstValue;
        double secondValue;
        double result = 0.0;
        string operation = "";


        private void BtnActionNumber(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            if (newOperation)
            {
                txtDisplay.Clear();
                newOperation = false;

                if (btn.Text == ",")
                {
                    if (txtDisplay.Text.Length > 0)
                    {
                        return;
                    }
                    var val = txtDisplay.Text.IndexOf(",");
                        if (val > 0)
                            return;
                }
             }
                txtDisplay.Text += btn.Text;
            }
        
        
        private void operClick(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            operation = btn.Text;
            firstValue = Convert.ToDouble(txtDisplay.Text);
            newOperation = true;
        }
        private void actions(object sender, EventArgs e)
        {
            secondValue = Convert.ToDouble(txtDisplay.Text);
            switch (operation)
            {
                case "+":
                    result = firstValue + secondValue;
                    break;
                case "-":
                    result = firstValue - secondValue;
                    break;
                case "*":
                    result = firstValue * secondValue;
                    break;
                case "/":
                    result = firstValue / secondValue;
                    break;
            }
            txtDisplay.Text = result.ToString();
            newOperation = true;
        }
        private void ClickClear(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            firstValue = 0;
            secondValue = 0;
            newOperation = false;
            result = 0;
            operation = "";
        }
        private void backspaceClick(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
        }


    }
}