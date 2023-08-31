namespace InvoiceTotal
{
    public partial class frmInvoiceTotal : Form
    {
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Decimal subTotal = Convert.ToDecimal(txtSubtotal.Text);
            Decimal dPercent = 0;
            Decimal dAmount = 0;
            Decimal total = 0;

            if(subTotal >= 20)
            {
                dPercent = .1m;
            }
            dAmount = subTotal * (dPercent / 100);
            total = subTotal - dAmount;

            txtDiscountAmt.Text = total.ToString("C");
            txtDiscountPct.Text = dPercent.ToString("p2");
            txtTotal.Text = total.ToString("C");  
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}