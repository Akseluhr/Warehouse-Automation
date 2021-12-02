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
/// GUI för kundhantering. Här finns möjlighet att ta skapa nya kunder
/// knappar för att modifiera befintliga kundobjekt
/// </summary>
namespace ProjektOOP2
{
    public partial class CustomerManagement : Form
    {
        ICustomerCatalogue customerCatalogue;
        /// <summary>
        /// Konstruktorn tar in interfacet ICustomerCatalogue
        /// customerCatalogue tilldelas instansen av interfacet vilket
        /// ger oss tillgång till interfacets metoder och event.
        /// </summary>
        public CustomerManagement(ICustomerCatalogue cCat)
        {
            InitializeComponent();

            customerCatalogue = cCat;
            customerCatalogue.CustomerChanged += RefreshList;
            RefreshList();
        }
        /// <summary>
        /// Uppdaterar GUI-listan för kunder
        /// </summary>
        public void RefreshList()
        {
            LSTCustomers.Items.Clear();
            foreach (Customer p in customerCatalogue.AllCustomers())
            {
                LSTCustomers.Items.Add(p);
            }
        }

        private void LSTCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Lägger till nya kunder i kundkatalogen, baserat på användarinput
        /// </summary>
        /// <exception>
        /// Kastar exceptions då användarinput är felaktig 
        /// </exception>
        private void BTNAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                customerCatalogue.AddCustomer(new Customer(
                customerCatalogue.AutoIncrementCode(), TXTCustomerName.Text, TXTCustomerPhone.Text, TXTCustomerEmail.Text
                ));
                TXTCustomerName.Clear();
                TXTCustomerPhone.Clear();
                TXTCustomerEmail.Clear();
            }
            catch (EmptyValueException exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        /// <summary>
        /// Uppdaterar kundens namn i produktkatalogen, baserat på vald kund i GUI
        /// </summary>
        /// <exception>
        /// Kastar exceptions då användarinput är felaktig </exception>
        private void BTNUpdateCustomerName_Click(object sender, EventArgs e)
        {
            try
            {
                Customer c = LSTCustomers.SelectedItem as Customer;
                customerCatalogue.UpdateCustomerName(c.CNumber, TXTCustomerName.Text);
            }
            catch (EmptyValueException exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        /// <summary>
        /// Uppdaterar kundens telefonnummer i produktkatalogen, baserat på vald kund i GUI
        /// </summary>
        /// <exception>
        /// Kastar exceptions då användarinput är felaktig 
        /// </exception>
        private void BTNUpdateCustomerPhone_Click(object sender, EventArgs e)
        {
            try
            {
                Customer c = LSTCustomers.SelectedItem as Customer;
                customerCatalogue.UpdateCustomerPhone(c.CNumber, TXTCustomerPhone.Text);
            }
            catch (EmptyValueException exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        /// <summary>
        /// Uppdaterar kundens email i produktkatalogen, baserat på vald kund i GUI
        /// </summary>
        /// <exception>
        /// Kastar exceptions då användarinput är felaktig 
        /// </exception>
        private void BTNUpdateCustomerEmail_Click(object sender, EventArgs e)
        {
            try
            {
                Customer c = LSTCustomers.SelectedItem as Customer;
                customerCatalogue.UpdateCustomerEmail(c.CNumber, TXTCustomerEmail.Text);
            }
            catch (EmptyValueException exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }
    }
}
