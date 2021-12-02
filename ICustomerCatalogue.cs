using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Interface för kund-katalog.
/// Här finns generella metoder för alla slags kunder
/// Syftet är att öka nivån av abstraktion vad gäller kundkataloger/listor
/// Samtliga metoder nedan kan implementeras i tex en JSON-katalog, en katalog som berör datorns minne eller en webbaserad katalog
/// </summary>
namespace ProjektOOP2
{
    public interface ICustomerCatalogue
    {
        event CustomerCatalogueChanged CustomerChanged;
        ///<summary>
        ///Lägger till kundobjekt i den valda kundkatalogen (tex presistant eller "vanlig" katalog)
        ///</summary>
        void AddCustomer(Customer c);
        ///<summary>
        ///Uppdaterar kundnamn för en särskild kund som identifieras med cNUmber
        ///</summary>
        ///<param name="cNumber" type="int" value="AutoIncrement" />
        ///<param name="name" type="string" value="userInpur" />
        void UpdateCustomerName(int cNumber, string name);
        ///<summary>
        ///Uppdaterar telefonnummer för en särskild kund som identifieras med cNUmber
        ///</summary>
        ///<param name="cNumber" type="int" value="AutoIncrement" />
        ///<param name="phone" type="string" value="userInpur" />
        void UpdateCustomerPhone(int cNumber, string phone);
        ///<summary>
        //Uppdaterar email för en särskild kund som identifieras med cNUmber
        ///</summary>
        ///<param name="cNumber" type="int" value="AutoIncrement" />
        ///<param name="email" type="string" value="userInpur" />
        void UpdateCustomerEmail(int cNumber, string email);
        ///<summary>
        ///Hämtar hela kundkatalogen med alla kunder
        ///</summary>
        IEnumerable<Customer> AllCustomers();
        ///<summary>
        ///Autoinkrementerar kundID
        ///</summary>
        int AutoIncrementCode();
        ///<summary>
        ///Visar arkiverade ordrar eller orderhistoriken för en särskild kund.
        ///</summary>
        ///<param name="c" type="Customer"/>
        ///<param name="orderList" type="List<Order>" />
        IEnumerable<Order> DisplayCustomerArchivedOrders(Customer c, List<Order> orderList);
        ///<summary>
        ///Visar aktiva ordrarför en särskild kund.
        ///</summary>
        ///<param name="c" type="Customer"/>
        ///<param name="orderList" type="List<Order>" />
        IEnumerable<Order> DisplayCustomerActiveOrders(Customer c, List<Order> orderList);
    }
}
