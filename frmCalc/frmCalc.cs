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

        private void BtnActionNumber(object sender, EventArgs e) 
        {
            var btn = (Button)sender;
            if (newOperation)
            {
                txtDisplay.Clear();
                newOperation = false;

                if (btn.Text == ",")
                {
                    var val = txtDisplay.Text.IndexOf(",");
                    if (val > 0)
                        return;
                }
            }
                txtDisplay.Text += btn.Text;
                if (btn.Text != ",")
                    firstValue = Convert.ToDouble(btn.Text);
        
        }

    }
}