using System.Windows.Forms;

namespace MoserPereiraLab4
{
    /* Fernando Moser Pereira
     * 05/13/2020
     * This form opens two other modal forms to handle either books or customers
     */
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnBooks_Click(object sender, System.EventArgs e)
        {
            //Instantiates and shows a new Books form when clicked
            Books frmBooks = new Books();
            frmBooks.ShowDialog();
        }

        private void btnCustomers_Click(object sender, System.EventArgs e)
        {
            //Instantiates and shows a new Customer form when clicked
            Customer frmCustomer = new Customer();
            frmCustomer.ShowDialog();
        }
    }
}
