using System.Threading.Channels;

namespace Mad_Libs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wat is je naam?");
            string? naam;
                naam = Console.ReadLine();
            Console.WriteLine("Geef een zelfstandig naamwoord?");
            string? naamwoord;
            naamwoord = Console.ReadLine();
            Console.WriteLine("geef een adjectief?");
            string? adjectief;
            adjectief = Console.ReadLine();
            Console.WriteLine("Geef een werkwoord?");
            string? werkwoord;
            werkwoord = Console.ReadLine();
            Console.WriteLine($"Op een dag ging {naam} naar de AP Hogeschool. Hij zag daar een {adjectief} {naamwoord} en vond dat zo grappig dat hij begon te {werkwoord}.");
        }
    }
}
