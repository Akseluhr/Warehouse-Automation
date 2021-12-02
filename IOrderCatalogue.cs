using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Interface för order-katalog.
/// Här finns de generella metoder för alla slags ordrar
/// Syftet är att öka nivån av abstraktion vad gäller orderkataloger/listor
/// Samtliga metoder nedan kan implementeras i tex en JSON-katalog, en katalog som berör datorns minne eller en webbaserad katalog
/// </summary>
namespace ProjektOOP2
{
    public interface IOrderCatalogue
    {
        event ShoppingCartChanged OnItemAdded;
        event OrderListChanged OnOrderDispatched;
        event OrderListChanged OnOrderPending;
        /// <summary>
        /// Returnerar en lista med alla produkter
        /// </summary>
        /// <returns></returns>
        IEnumerable<Product> AllProducts();
        /// <summary>
        /// Returnerar en lista med alla kunder
        /// </summary>
        /// <returns></returns>
        IEnumerable<Customer> AllCustomers();
        /// <summary>
        /// Returnerar en lista med alla order
        /// </summary>
        /// <returns></returns>
        IEnumerable<Order> AllOrders();
        /// <summary>
        /// Returnerar en lista med alla orderLine i shoppingCart
        /// </summary>
        /// <returns></returns>
        IEnumerable<OrderLine> ItemsInShoppingCart();
        /// <summary>
        /// Lägger till en orderLine i shoppingCart listan
        /// </summary>
        /// <param name="orderLine"></param>
        void AddToShoppingCart(OrderLine orderLine);
        /// <summary>
        /// Lägger till en order i listan med orders
        /// </summary>
        /// <param name="order"></param>
        void PlaceOrder(Order order);
        /// <summary>
        /// Kontrollerar huruvida produkterna i beställningen finns i produktkatalogen
        /// </summary>
        /// <param name="orderLine"></param>
        /// <returns>
        /// Returnerar true om de finns, annars false
        /// </returns>
        bool IsPaymentRefunded(List<OrderLine> orderLine);
        /// <summary>
        /// Kontrollerar huruvida produkterna finns i lager,
        /// och är betald för en order, markeras isåfall som levererad
        /// </summary>
        /// <param name="orderLine"></param>
        /// <param name="paymentComplete"></param>
        /// <returns>
        /// False om obetald, False om tillräckligt med produkter inte finns i lager, Annard true.
        /// </returns>
        bool IsOrderDispatched(List<OrderLine> orderLine, bool paymentComplete);
        /// <summary>
        /// Denna metod genererar ett unikt id nummer till varje order
        /// </summary>
        /// <returns></returns>
        int AutoIncrementNumber();
    }
}
