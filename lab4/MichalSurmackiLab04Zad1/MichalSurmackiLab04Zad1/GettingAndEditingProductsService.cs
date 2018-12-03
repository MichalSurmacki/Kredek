using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MichalSurmackiLab04Zad1
{
    class GettingAndEditingProductsService
    {
        /// <summary>
        /// Funkcja dodająca nowy produkt do bazy danych
        /// </summary>
        /// <param name="price"></param>
        /// <param name="category"></param>
        /// <param name="product"></param>
        /// <param name="amountInStock"></param>
        public Boolean AddProtuctToBase(int price, String category, String product, int amountInStock)
        {
            using(MichalSurmackiLab04Zad01Entities context = new MichalSurmackiLab04Zad01Entities())
            {
                //zmienna pozwalająca dodać dane do bazy danych
                ProductsForSale newProduct = new ProductsForSale();
                //dodanie do zmiennej poszczególnych atrybutów
                newProduct.Price = price;
                newProduct.Category = category;
                newProduct.Product = product;
                newProduct.InStock = amountInStock;
                //sprawdzenie czy w bazie jest może już produkt o danej nazwie
                var checkProductExist = context.ProductsForSales.Where(x => x.Product == product).Count();
                //jeśli w bazie nie ma produktu o takich parametrach - dodanie go do bazy
                if(checkProductExist < 1)
                {
                    context.ProductsForSales.Add(newProduct);
                    context.SaveChanges();
                    return true;
                }
                //jeśli parametry nie są unikatowe zostaje wyświetlony komunikat
                else
                {
                    MessageBox.Show("Istnieje już taki produkt w bazie!", "Komunikat");
                    return false;
                }
            }
        }

        /// <summary>
        /// Metoda odpowiedzialna za dodawanie ilości produktu do bazy danych.
        /// </summary>
        /// <param name="product"></param>
        /// <param name="productID"></param>
        /// <param name="amount"></param>
        public void AddAmountOfProduct(String product, int amount)
        {
            //zmienna pozwalająca na dokonywanie operacji na bazie danych
            using (MichalSurmackiLab04Zad01Entities context = new MichalSurmackiLab04Zad01Entities())
            {
                //sprawdzenie czy produkt o zadanych parametrach istnieje w bazie
                var checkIfProductExist = context.ProductsForSales.Where(x => x.Product == product).Count();
                //jeśli istnieje zostają wykonane następujące isntrukcje
                if(checkIfProductExist == 1)
                {
                    //modyfikacja rekordu z bazy danych
                    ProductsForSale editingProduct = new ProductsForSale();
                    editingProduct = context.ProductsForSales.Where(x => x.Product.Equals(product)).FirstOrDefault();
                    editingProduct.Product = product;
                    int newAmount = Int32.Parse(editingProduct.InStock.ToString());
                    newAmount += amount;
                    editingProduct.InStock = newAmount;
                    context.Entry(editingProduct).State = EntityState.Modified;
                    context.SaveChanges();
                }
                //jeśli przedmiot o zadanych parametrach nie znajduje się w bazie danych - wyświetlenie komunikatu
                else
                {
                    MessageBox.Show("Taki produkt nie istnieje!", "Komunikat");
                }
            }
        }

        /// <summary>
        /// Funckja odpowiedzialna za usuwanie zadanej ilości produktu z bazy danych.
        /// </summary>
        /// <param name="product"></param>
        /// <param name="amount"></param>
        public Boolean DeleteProduct(String product, int amount)
        {
            //zmienna pozwalająca na wykonywanie operacji na bazie danych
            using(MichalSurmackiLab04Zad01Entities context = new MichalSurmackiLab04Zad01Entities())
            {
                //wyszukanie produktu o zadanych parametrach w bazie danych
                var checkIfProductExist = context.ProductsForSales.Where(x => x.Product == product).Count();
                //jeśli produkt istnieje wykonanie instrukcji
                if (checkIfProductExist == 1 && amount!=0)
                {
                    //modyfikacja rekordu z bazy danych
                    ProductsForSale editingProduct = new ProductsForSale();
                    editingProduct = context.ProductsForSales.Where(x => x.Product.Equals(product)).FirstOrDefault();
                    editingProduct.Product = product;
                    int newAmount = Int32.Parse(editingProduct.InStock.ToString());
                    newAmount -= amount;
                    //jeśli pożądana do kupna ilość nie jest większa niż ilość przedmiotu na stanie - zakup jest możliwy
                    if(newAmount >= 0)
                    {
                        editingProduct.InStock = newAmount;
                        context.Entry(editingProduct).State = EntityState.Modified;
                        context.SaveChanges();
                        return true;
                    }
                    //jeśli dokonano próby zakupu przedmiotu, którego ilość jest mniejsza niż pożądana - zakup jest niemożliwy
                    else
                    {
                        return false;
                    }
                }
                //jeśli produkt nie istnieje zwrócenie wartości false.
                else
                {
                    return false;
                }
            }
        }
        /// <summary>
        /// Funckja odpowiedzialna za dodanie do bazy transakcji.
        /// </summary>
        /// <param name="money"></param>
        public void AddTransactionToBase(int money)
        {
            //zmienna pozwalająca na operacje na bazie danych
            using(MichalSurmackiLab04Zad01Entities context = new MichalSurmackiLab04Zad01Entities())
            {
                //tworzenie mowego rekordu
                SoldProduct newTransaction = new SoldProduct();
                DateTime date = DateTime.Now;
                newTransaction.DateOfTransaction = date;
                newTransaction.Price = money;
                //dodanie nowego rekordu do bazy danych, zapisanie zmian
                context.SoldProducts.Add(newTransaction);
                context.SaveChanges();
            }
        }

    }
}
