using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork03
{
    class SomeProduct
    {
        public int Id;
        public string Title;
        public string Description;

        SomeProduct()
        {
            Id = 252526;
            Title = "Test";
            Description = "TestDescription";
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Console.ReadKey();
        }

        enum PrForProduct
        {
            piece,
            liter,
            kilogram
        }

        class Price
        {
            public int Id;
            public decimal PriceForProduct;
            public DateTime DateTime;
        }

        class SomeProduct
        {
            public int Id;
            public string Title;
            public string Description;

            SomeProduct()
            {
                Id = 252526;
                Title = "Test";
                Description = "TestDescription";
            }
        }

        /// <summary>
        /// Товар
        /// </summary>
        abstract class Product
        {
            public int Id;
            public string Title;
            public string Description;
            public decimal Price;

            public Product(string Description)
            {
                this.Description = Description;
            }

            public void PrintInfo()
            {
                Console.WriteLine(this.Description);
            }

            public void PrintInfo(int Id)
            {
                Console.WriteLine(Id);
            }

        }

        /// <summary>
        /// Вид оплаты
        /// </summary>
        enum PaymentType
        {
            Cash,
            Transfer
        }

        class PaymentCheck
        {
            private static int paementpass
            {
                get { return paementpass; }

                set

                {
                    if (paementpass > 0)
                        Console.WriteLine("Товар оплачен");
                    else
                        paementpass = value;
                }
            }
        }

        /// <summary>
        /// Карзина
        /// </summary>
        class ShoppingCart
        {
            protected int OrderId;
            protected int TotalCount;
            protected bool PaymentPass;
            protected decimal TotalPrice;

            private PaymentCheck paymentCheck;

            public ShoppingCart()
            {
                paymentCheck = new PaymentCheck();
            }

        }

        /// <summary>
        /// Каталог товаров
        /// </summary>
        class Catalog : Product
        {
            public static string Status;

            public Catalog(string Description, string Status) : base(Description)
            {
                Status = Description;
            }
        }


        abstract class Delivery
        {
            public string Address;
        }

        class HomeDelivery : Delivery
        {
            /* ... */
        }

        class PickPointDelivery : Delivery
        {
            /* ... */
        }

        class ShopDelivery : Delivery
        {
            /* ... */
        }

        class Order<TDelivery,
        TStruct> where TDelivery : Delivery
        {
            public TDelivery Delivery;

            public int Number;

            public string Description;

            public void DisplayAddress()
            {
                Console.WriteLine(Delivery.Address);
            }

            // ... Другие поля
        }


    }




    
}
