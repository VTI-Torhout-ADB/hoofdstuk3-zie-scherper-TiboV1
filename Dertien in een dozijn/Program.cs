namespace Dertien_in_een_dozijn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int doosGrootte = 8;
            int aantalEieren = 124;
            int aantaldozen= aantalEieren/doosGrootte; 
            int aantalOverigeEieren = aantalEieren % doosGrootte;
            Console.WriteLine($"{aantalEieren} eieren passen in {aantaldozen} dozen van doosgrootte:{doosGrootte}. Daarbij zal je nog {aantalOverigeEieren} eieren over hebben.");
        }
    }
}
