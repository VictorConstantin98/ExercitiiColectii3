using System;

namespace ExercitiiColectii3
{
    class Program
    {
        static void Main(string[] args)
        {
            Librarie diverta = new Librarie();
            Dictionary<Autor, int> dictionarCartiCarturesti = new Dictionary<Autor, int>();

            Librarie carturesti = new Librarie("Carturesti", dictionarCartiCarturesti);
            Autor autorCarturesti1 = new Autor("George R.R. Martin", new DateTime(1954, 10, 15), 5);

            Console.WriteLine(carturesti.ToString());
            carturesti.adaugareAutor(autorCarturesti1);
            Console.WriteLine(carturesti.ToString());
            carturesti.adaugareCarte(autorCarturesti1);
            Console.WriteLine(carturesti.ToString());
            carturesti.adaugareCarte(autorCarturesti1);
            Console.WriteLine(carturesti.ToString());

            Autor autorCarturesti2 = new Autor("Tudor Arghezi", new DateTime(1880, 05, 21), 4.7);
            carturesti.adaugareAutorSiCarte(autorCarturesti2);
            Console.WriteLine(carturesti.ToString());
            carturesti.adaugareAutorSiCarte(autorCarturesti2);
            carturesti.adaugareAutorSiCarte(autorCarturesti2);
            Console.WriteLine(carturesti.ToString());













            //To do
            //Setter nume librarie
            //De adaugat o carte unui autor
            //De adaugat o carte si un autor(Autorul impreuna cu numarul de carti)

            //
        }
    }
}
