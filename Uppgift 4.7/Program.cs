using System;
namespace uppgift4_7
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv något");
            string meddelande = Console.ReadLine();

            Console.WriteLine("Det kommer skrivas ut vertikalt, hur många steg åt höger vill du ha det?");
            int steg = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < meddelande.Length; i++)
            {
                for (int j = 0; j < steg; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(meddelande[i]);
            }
        }
    }
}