using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Första GUI som visas. Här kan man välja på att hantera produkter, kunder eller ordrar.
/// </summary>
namespace ProjektOOP2
{
    public partial class Form1 : Form
    {
        IProductCatalogue pCat;
        IOrderCatalogue oCat;
        ICustomerCatalogue cCat;
        public Form1()
        {
            InitializeComponent();

            DialogResult answer = MessageBox.Show("Should we enable JSON-persistent catalogues?", "Persistence", MessageBoxButtons.YesNo);
            if (answer == DialogResult.Yes)
            {
                pCat = new PersistentProductCatalogue("products.json");
                cCat = new PersistentCustomerCatalogue("customers.json");
                oCat = new PersistentOrderCatalogue("orders.json", pCat, cCat);
            }
            else
            {
                pCat = new ProductCatalogue();
                cCat = new CustomerCatalogue();
                oCat = new OrderCatalogue(pCat, cCat);
            }
        }

        private void manageProductsButton_Click(object sender, EventArgs e)
        {
            //IProductCatalogue pCat;
            //DialogResult answer = MessageBox.Show("Should we enable JSON-persistent catalogues?", "Persistence", MessageBoxButtons.YesNo);
            //if (answer == DialogResult.Yes)
            //    pCat = new PersistentProductCatalogue("products.json");
            //else pCat = new ProductCatalogue();
            var pMan = new ProductManagement(pCat);
            pMan.Show();
        }

        private void BTNPlaceOrder_Click(object sender, EventArgs e)
        {
            //IOrderCatalogue oCat;
            //DialogResult answer = MessageBox.Show("Should we enable JSON-persistent catalogues?", "Persistence", MessageBoxButtons.YesNo);
            //if (answer == DialogResult.Yes)
            //    oCat = new PersistentOrderCatalogue("products.json", "customers.json", "orders.json");
            //else oCat = new OrderCatalogue(new ProductCatalogue(), new CustomerCatalogue());
            var PlaceOrder = new Warehouse(oCat, cCat, pCat);
            PlaceOrder.Show();

        }

        private void BTNManageCustomers_Click(object sender, EventArgs e)
        {
            //ICustomerCatalogue cCat;
            //DialogResult answer = MessageBox.Show("Should we enable JSON-persistent catalogues?", "Persistence", MessageBoxButtons.YesNo);
            //if (answer == DialogResult.Yes)
            //    cCat = new PersistentCustomerCatalogue("customers.json");
            //else cCat = new CustomerCatalogue();
            var cMan = new CustomerManagement(cCat);
            cMan.Show();
        }
    }
}
