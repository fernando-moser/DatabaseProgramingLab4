using System;
using System.Windows.Forms;

namespace MoserPereiraLab4
{
    /* Fernando Moser Pereira
     * 05/13/2020
     * This form handles book products' data from a dataset
     */
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
        }
        private void Books_Load(object sender, EventArgs e)
        {
            // Gets all records from the Dataset
            FillAllRecords();
            //Updates the navigation bar
            UpdateNavigationPosition();
            try
            {
                //Average label content
                lblAvgPrice.Text = Convert.ToDecimal(productsTableAdapter.GetAverage()).ToString("c");
                //Total Stock label content
                lblTotalStock.Text = productsTableAdapter.GetTotalStock().ToString();
            }
            catch (Exception ex)
            {
                DisplayError(ex, "\nThe program cannot retrieve data and will be closed.");
                Close();
            }

        }
        //Updates the navigation bar
        private void productsBindingSource_CurrentChanged(object sender, EventArgs e) => UpdateNavigationPosition();
        /*
         * Name: UpdateNavigationPosition
        * Send: none
        * Return: none
        * This ftn Updates the nagivation bar
        */
        private void UpdateNavigationPosition() => lblNavigation.Text = $"{productsBindingSource.Position + 1} OF {productsBindingSource.Count}";
        /*
        * Name: FillAllRecords
        * Send: none
        * Return: none
        * This ftn gets all data from the dataset and place it in the GUI
        */
        private void FillAllRecords()
        {
            try
            {
                //Gets all records from dataset
                productsTableAdapter.Fill(booksDataSet.Products);
            }
            catch (Exception ex)
            {
                DisplayError(ex, "\nThe program cannot retrieve data and will be closed.");
                //Closes the form
                Close();
            }
        }
        /*
        * Name: DisplayError
        * Send: none
        * Return: none
        * This ftn gets displays error in a messagebox
        */
        private static void DisplayError(Exception ex, string message) => MessageBox.Show(ex.Message + message, "Error Retrieving Data");

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Gets all records from dataset
            FillAllRecords();
            //Updates the navigation bar
            UpdateNavigationPosition();
            //Resets combobox language
            cboLanquage.ResetText();
            //Resets numeric up and downs values
            nudMin.Value = 0;
            nudMax.Value = 1500;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                SELECT ProductCode, Description, UnitPrice, OnHandQuantity
                FROM Products
                WHERE(OnHandQuantity BETWEEN @min AND @max)
                */
                productsTableAdapter.FillByStock(booksDataSet.Products, (int)nudMin.Value, (int)nudMax.Value);
                UpdateNavigationPosition();
            }
            catch (Exception ex)
            {
                DisplayError(ex, "\nThe program cannot retrieve the specific data.\nAll data will be shown");
                FillAllRecords();
            }
        }

        private void cboLanquage_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                /*
                SELECT ProductCode, Description, UnitPrice, OnHandQuantity
                FROM Products
                WHERE Description like '%' + @Description + '%'
                */
                productsTableAdapter.FillByLanguage(booksDataSet.Products, cboLanquage.Items[cboLanquage.SelectedIndex].ToString());
                UpdateNavigationPosition();
            }
            catch (Exception ex)
            {
                DisplayError(ex, "\nThe program cannot retrieve the specific data.\nAll data will be shown");
                FillAllRecords();
            }
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            /*
            SELECT ProductCode, Description, UnitPrice, OnHandQuantity
            FROM Products
            WHERE(UnitPrice >
                    (SELECT AVG(UnitPrice) AS Expr1 FROM Products AS Products_1))
            ORDER BY UnitPrice
            */
            try
            {
                productsTableAdapter.FillByAboveAveragePrice(booksDataSet.Products);
                UpdateNavigationPosition();
            }
            catch (Exception ex)
            {
                DisplayError(ex, "\nThe program cannot retrieve the specific data.\nAll data will be shown");
                FillAllRecords();
            }
        }
        //Goes to the first item
        private void picFirst_Click(object sender, EventArgs e) => productsBindingSource.MoveFirst();
        //Goes to the previous item
        private void picPrev_Click(object sender, EventArgs e) => productsBindingSource.MovePrevious();
        //Goes to the next item
        private void picNext_Click(object sender, EventArgs e) => productsBindingSource.MoveNext();
        //Goes to the last item
        private void picLast_Click(object sender, EventArgs e) => productsBindingSource.MoveLast();
    }
}
