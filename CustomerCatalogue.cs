using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOOP2
{
  /// <summary>
  /// Global delegat som används i eventet Customer changed
  /// </summary>
    public delegate void CustomerCatalogueChanged();
    /// <summary>
    /// Klass CustomerCatalouge som ärver av interface ICustomerCatlouge, instansiering av en lista ed objekt av klassen customer.
    /// publikt event customerchanged och int uniwueCode för att tilldela cnumber i listan md kundobjekt
    /// </summary>
    class CustomerCatalogue : ICustomerCatalogue
    {
        public List<Customer> customers = new List<Customer>();
        public event CustomerCatalogueChanged CustomerChanged;
        private int uniqueCode = 1;

        /// <summary>
        /// //Autoincrementcode ökar värdet på int uniquecode så at nästa tillagda objekt i listan ska få ett unikt värde
        /// </summary>
        public int AutoIncrementCode()
        {
            return uniqueCode++;
        }
        /// <summary>
        /// Add customer kallar på konstruktorn i customer och lägger till ett objekt av klassen customer i listan med customers
        /// event kallas på och uppdaterar i CustomerCatalouge
        /// </summary>
        public void AddCustomer(Customer c)
        {
            customers.Add(c);
            CustomerChanged?.Invoke();
        }
        /// <summary>
        /// Itererar över den ickke generiska listan med kunder och returnerar hela listan
        /// </summary>
        public IEnumerable<Customer> AllCustomers()
        {
            return customers;
        }
        /// <summary>
        /// Tar in en int och en string. Matchar värdet som objektet har i cNumver väljer det objektet och skriver över
        /// värdet som finns som c.phone till det nya inmatade värdet.
        /// </summary>
        public void UpdateCustomerName(int cNumber, string name)
        {
            foreach(Customer c in customers)
            {
                if(c.CNumber == cNumber)
                {
                    c.Name = name;
                    CustomerChanged?.Invoke();
                }
            }
        }
        /// <summary>
        /// Tar in en int och en string. Matchar värdet som objektet har i cNumver väljer det objektet och skriver över
        /// värdet som finns som c.phone till det nya inmatade värdet.
        /// </summary>
        public void UpdateCustomerPhone(int cNumber, string phone)
        {
            foreach (Customer c in customers)
            {
                if (c.CNumber == cNumber)
                {
                    c.Phone = phone;
                    CustomerChanged?.Invoke();
                }
            }
        }
        /// <summary>
        /// Tar in en int och en string. Matchar värdet som objektet har i cNumver väljer det objektet och skriver över
        /// värdet som finns som c.Email till det nya inmatade värdet.
        /// </summary>
        public void UpdateCustomerEmail(int cNumber, string email)
        {
            foreach (Customer c in customers)
            {
                if (c.CNumber == cNumber)
                {
                    c.Email = email;
                    CustomerChanged?.Invoke();
                }
            }
        }
        /// <summary>
        /// Tar in objekt av klassen customer samt en lista med Orders matchar det valda cNumber med c.Number i orderlistan
        /// </summary>
        /// <param name="c">parameter av objektet Customer</param>
        /// <param name="orderList">listparameter av klassen orders</param>
        /// <returns>lista Archived oreders. En lista med kundens alla ordrar som är skickade eller gjorda för över 30dagar sedan</returns>
        public IEnumerable<Order> DisplayCustomerArchivedOrders(Customer c, List<Order> orderList)
        {
            //var customerOrders = from order in orderList
            //                     where order.Customer.CNumber == c.CNumber
            //                     select order;
            //var archivedOrders = from order in customerOrders
            //                     where order.Dispatched == true && order.ODate.AddDays(30) < DateTime.Now
            //                     select order;
            var archivedOrders = orderList.Where(o => o.Customer.CNumber == c.CNumber && (o.Dispatched && o.ODate.AddDays(30) < DateTime.Now));
            return archivedOrders;
        }
        /// <summary>
        /// Tar in objekt av klassen customer samt en lista med Orders matchar det valda cNumber med c.Number i orderlistan
        /// </summary>
        /// <param name="c">parameter av objektet Customer</param>
        /// <param name="orderList">listparameter av klassen orders</param>
        /// <returns>lista Archived oreders. En lista med kundens alla ordrar som är pending eller gjorda för mindre 30dagar sedan</returns>
        public IEnumerable<Order> DisplayCustomerActiveOrders(Customer c, List<Order> orderList)
        {
            //var customerOrders = from order in orderList
            //                     where order.Customer.CNumber == c.CNumber
            //                     select order;
            //var activeOrders = from order in customerOrders
            //                     where order.Dispatched == false || order.ODate.AddDays(30) > DateTime.Now
            //                     select order;
            var activeOrders = orderList.Where(o => o.Customer.CNumber == c.CNumber && (!o.Dispatched || o.ODate.AddDays(30) > DateTime.Now));
            return activeOrders;
        }
    }
}
