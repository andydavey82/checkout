using Checkout.Interfaces;
using Checkout.Models;
using System.Windows.Forms;

namespace Checkout
{
    public partial class Pos : Form
    {
        private ICheckout Checkout;
        private IScanned Scanned;

        public Pos()
        {
            InitializeComponent();
            // need to add models as object name is same as namespace
            Checkout = new Models.Checkout();
            Scanned = (IScanned)Checkout;
        }

        // function to scan item and update list, or notify user that product is not found
        private void btnScan_MouseClick(object sender, MouseEventArgs e)
        {
            // get sku
            var sku = txtSku.Text;

            // run scan
            Checkout.Scan(sku);

            // get product
            var product = Scanned.GetLastScanned();
            if (product != null)
            {
                lstItems.Items.Add(new ListViewItem(new[] { product.Sku, product.Cost.ToString() }));
            }
            else
            {
                MessageBox.Show(sku + " Not found!");
            }
        }

        private void btnTotal_Click(object sender, System.EventArgs e)
        {
            // shows total in messageBox
            MessageBox.Show("Total "+Checkout.GetTotal());
        }
    }
}