namespace csharp_lista_indirizzi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //n questo esercizio dovrete leggere un file CSV, che cambia poco da quanto appena visto
            //nel live-coding in classe, e salvare tutti gli indirizzi in esso contenuti all’interno di una lista di oggetti istanziati a partire dalla classe Indirizzo.



            //1 salvo il percorso 
            string path = "C:\\boolean\\addresses.csv";

            //2 apertura e lettura 
            var sorgente = File.ReadAllText(path);

            //3 stampo in terminale
            Console.WriteLine(sorgente);

        }
    }
}
