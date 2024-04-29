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
            //Console.WriteLine(sorgente);

            //non va 
            //sorgente.EndOfStream

            List<Indirizzo> IndirizziPersonali = new List<Indirizzo>();





            try
            {

                var separatire = sorgente.Split(',');
                string Nome = separatire[0];
                string Cognome = separatire[1];
                string Strada = separatire[2];
                string Citta = separatire[3];
                string Provincia = separatire[4];

                int ZIP = int.Parse(separatire[5]);

                Indirizzo Bo = new Indirizzo(Nome, Cognome, Strada, Citta, Provincia, ZIP);

                IndirizziPersonali.Add(Bo);

            } catch(FormatException e)
            
            {
                Console.WriteLine("errore");
            }
            foreach (var indirizzoFatto in IndirizziPersonali)
            {
                Console.WriteLine(indirizzoFatto.ToString);
            }
        }
    }
}
