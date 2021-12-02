using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Interface för produktkatalog.
/// Här finns de generella metoder för alla slags produktkataloger
/// Syftet är att öka nivån av abstraktion produktkataloger
/// Samtliga metoder nedan kan implementeras i tex en JSON-katalog, en katalog som berör datorns minne eller en webbaserad katalog
/// </summary>
namespace ProjektOOP2
{
    public interface IProductCatalogue
    {
        event ProductCatalogueChanged ProductChanged;
        event ProductCatalogueChanged Restock;
        /// <summary>
        ///  tillderlar ett object i listan ett unikt nummer
        /// </summary>
        /// <returns>ett unikt nummer</returns>
        int AutoIncrementCode();

        /// <summary>
        /// skapar en lista med alla produkter som finns i warehouse
        /// </summary>
        /// <returns>en ienumerable</returns>
        IEnumerable<Product> AllProducts();

        /// <summary>
        /// Lägger till ett produktobjekt i listan av produktobjekt
        /// </summary>
        /// <param name="p"></param>
        void AddProduct(Product p);

        /// <summary>
        /// Hämtar det gamla värdet på produktens pris och skriver över det med ett nytt värde
        /// </summary>
        /// <param name="code"></param>
        /// <param name="price"></param>
        void UpdateProductPrice(int code, double price);

        /// <summary>
        /// Skriver över tidigare lagerstatus med den nya lagerstatusen
        /// </summary>
        /// <param name="code"></param>
        /// <param name="stock"></param>
        void UpdateProductStock(int code, int stock);

        /// <summary>
        /// Visar produkterna som är slut i lager 
        /// </summary>
        /// <returns></returns>
        IEnumerable<Product> DisplayOutOfStockProducts();

        /// <summary>
        ///  Det datum där produkten kommer in i lager nästa gång
        /// </summary>
        /// <returns></returns>
        DateTime NextProductRestock();

        /// <summary>
        /// Varje gång någon lägger en order uppdateras orderstatus
        /// </summary>
        /// <param name="orderLine"></param>
        void UpdateStockAfterOrder(List<OrderLine> orderLine);
    }
}