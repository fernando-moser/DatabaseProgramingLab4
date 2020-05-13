using System;
using System.Windows.Forms;

namespace MoserPereiraLab4
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }
        private void Customer_Load(object sender, EventArgs e)
        {
            //invoicesTableAdapter.Fill(this.booksDataSet.Invoices);
            customersTableAdapter.Fill(booksDataSet.Customers);
            cboCustomerID.Text = "10";
        }

        private void cboCustomerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cboCustomerID.Text);
            /*
            SELECT InvoiceID, CustomerID, InvoiceDate, ProductTotal, SalesTax, Shipping, InvoiceTotal
            FROM Invoices
            WHERE(CustomerID = @id)
            */
            invoicesTableAdapter.FillByCustomerID(booksDataSet.Invoices, int.Parse(cboCustomerID.Text));

            lblID.Text = cboCustomerID.Text;

            double numInvoices = 0, beforeTax = 0, totalTax = 0, totalShipping = 0, total = 0;
            foreach (DataGridViewRow row in dgvInvoices.Rows)
            {
                numInvoices++;
                beforeTax += Convert.ToDouble(row.Cells["dataGridViewTextBoxColumn4"].Value);
                totalTax += Convert.ToDouble(row.Cells["dataGridViewTextBoxColumn5"].Value);
                totalShipping += Convert.ToDouble(row.Cells["dataGridViewTextBoxColumn6"].Value);
                total += Convert.ToDouble(row.Cells["dataGridViewTextBoxColumn7"].Value);

            }
            lblInvoices.Text = numInvoices.ToString();
            lblBeForeTax.Text = beforeTax.ToString("c");
            lblTax.Text = totalTax.ToString("c");
            lblShipping.Text = totalShipping.ToString("c");
            lblTotal.Text = total.ToString("c");

            try
            {
                /*
                   SELECT MAX(InvoiceTotal) AS Expr1
                   FROM Invoices
                   WHERE(CustomerID = @id)
                   */
                lblMax.Text = Convert.ToDouble(invoicesTableAdapter.GetMaximum(int.Parse(cboCustomerID.Text))).ToString("c");

                /*
                SELECT AVG(InvoiceTotal) AS Expr1
                FROM Invoices
                WHERE(CustomerID = @id)
                */
                lblAvg.Text = Convert.ToDouble(invoicesTableAdapter.GetAverage(int.Parse(cboCustomerID.Text))).ToString("c");
            }
            catch (Exception)
            {

                lblMax.Text = "0";
                lblAvg.Text = "0";
            }
        }
    }
}
