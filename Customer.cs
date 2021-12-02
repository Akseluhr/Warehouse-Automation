using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOOP2
{
    public class Customer
    {
        private int cNumber;
        private string name;
        private string phone;
        private string email;
        CustomerCatalogue cl = new CustomerCatalogue();
        public Customer() { }
        /// <summary>
        /// Konstruktor tar in en int. tre strings och tilldelar dessa värden
        /// </summary>
        public Customer(int cNumber, string name, string phone, string email)
        {
            CNumber = cNumber;
            Name = name;
            Phone = phone;
            Email = email;
        }
        /// <summary>
        /// CNumber med tilldelning av egenskaper get set if satsen säter ett vilkor att cNumber ej får vara noll eller negativt
        /// den andra if-satsen har vilkor att cnumber måste vara unikt
        /// </summary>
        public int CNumber
        {
            get { return cNumber; }
            set
            {
                cNumber = value;
            }
        }
        /// <summary>
        /// Name tilldelas egenskaperna get och set, if-satsen kontrollerar så att name inte är null om det är null kastas exeption
        /// </summary>
        public string Name
        {
            get { return name; }
            set
            {
                if(value == null || value == "")
                {
                    throw new EmptyValueException("Name can not be empty");
                }
                name = value;
            }
        }
        /// <summary>
        /// Phone tilldelas egenskaperna get, set. if-satsen kontollerar så att phone inte är null eller en tom sträng, är den det kastas exeption
        /// </summary>
        public string Phone
        {
            get { return phone; }
            set
            {
                if (value == null || value == "")
                {
                    throw new EmptyValueException("Phone can not be empty");
                }
                phone = value;
            }
        }
        /// <summary>
        /// Email tilldelas egenskaperna get, set. if-satsen kontollerar så att email inte är null eller en tom sträng, är den det kastas exeption
        /// </summary>
        public string Email
        {
            get { return email; }
            set
            {
                if (value == null || value == "")
                {
                    throw new EmptyValueException("Email can not be empty");
                }
                email = value;
            }
        }
        /// <summary>
        /// override för de värden som finns i objektet och de converteras till strings för att kunna visas i listbox.
        /// </summary>
        public override string ToString()
        {
            return CNumber + " : " + Name + " " + Phone + "  " + Email + " ";
        }

    }
}
