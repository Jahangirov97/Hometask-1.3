namespace Hometask_1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string company = "Firma :";

            string adidasCompany = "Adidas";
            string nikeCompany = "Nike";
            string gucciKompany = "Gucci";
            string totalPrice = "Hamısının birlikdə qiyməti ($) :";
            string numberOfShoes = "Ayaqqabı sayı :";
            string priceOfShoes = "Birinin qiyməti ($) :";


            int adidas = 4;
            int adidasPrice = 200;


            int gucci = 2;
            int gucciPrice = 150;

            int nike = 1;
            int nikePrice = 150;



            float totalAdidas = adidas * adidasPrice;
            float totalGucci = gucci * gucciPrice;
            float totalNike = nike * nikePrice;


            Console.WriteLine(company);
            Console.WriteLine(adidasCompany);
            Console.WriteLine(numberOfShoes);
            Console.WriteLine(adidas);
            Console.WriteLine(priceOfShoes);
            Console.WriteLine(adidasPrice);
            Console.WriteLine(totalPrice);
            Console.WriteLine(totalAdidas);


            Console.WriteLine(company);
            Console.WriteLine(gucciKompany);
            Console.WriteLine(numberOfShoes);
            Console.WriteLine(gucci);
            Console.WriteLine(priceOfShoes);
            Console.WriteLine(adidasPrice);
            Console.WriteLine(totalPrice);
            Console.WriteLine(totalGucci);




            Console.WriteLine(company);
            Console.WriteLine(nikeCompany);
            Console.WriteLine(numberOfShoes);
            Console.WriteLine(nike);
            Console.WriteLine(priceOfShoes);
            Console.WriteLine(nikePrice);
            Console.WriteLine(totalPrice);
            Console.WriteLine(totalNike);






        }
    }
}
        