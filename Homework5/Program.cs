using System;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product
            {
                BrandName = "Agusha",
                Price = 2.5,
                
            };
            Product product2 = new Product
            {
                BrandName = "Rostishka",
                Price = 1.7,
            };
            Product product3 = new Product
            {
                BrandName = "Smetana Kaunovskaya",
                Price = 3.9,
            };
            Product product4 = new Product
            {
                BrandName = "Smetana Kiyevskaya",
                Price = 2.9,
            };
            Product product5 = new Product
            {
                BrandName = "Smetana Indeyskaya",
                Price = 2.7,
            };

            Product[] products = new Product[] { product1, product2, product3, product4 ,product5 };
            double max = Max(products);
            double min = Min(products);
            products = ArrMinMax(products, max, min);
            foreach (var product in products)
            {
                Console.WriteLine(product.BrandName+"|"+product.Price);

            }
            Car car1 = new Car();
            car1.Color = "black";
            car1.Name = "Gelendvagen";
            car1.Brand = "Mercedes";
            car1.Model = "G350";

            


        }
        static double Max(Product[] products)
        {
            double max = products[0].Price;
            for (int i = 0; i < products.Length; i++)
            {
                if (max<products[i].Price)
                {
                    max = products[i].Price;
                }
            }
            return max;
            
        }
        static double Min(Product[] products)
        {
            double min = products[0].Price;
            for (int i = 0; i < products.Length; i++)
            {
                if (min > products[i].Price)
                {
                    min = products[i].Price;
                }
            }
            return min;
        }
        static Product[] ArrMinMax(Product[] products,double max, double min)
        {
            Product[] temparr = new Product[products.Length];
            int middle = 2;
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].Price == max)
                {
                        temparr[0] = products[i];

                }
                else if (products[i].Price == min)
                {
                        temparr[products.Length - 1] = products[i];
                }
                else
                {
                    temparr[products.Length - middle] = products[i];
                    middle++;
                }
                
            }
            return temparr;
        }

    }
    
}
