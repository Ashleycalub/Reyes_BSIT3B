namespace Reyes_BSIT3B
{
    public partial class QeueingForm : Form
    {
        CashierClass cashier = new CashierClass();
        public QeueingForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQeue.Text = cashier.CashierGeneratedNumber("P -");
            CashierClass.getNumberInQueue = lblQeue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CashierWindowQueueForm cashierwindows = new CashierWindowQueueForm();
            cashierwindows.ShowDialog();
        }
    }
}
