namespace csharp_lista_indirizzi
{
    internal class Program
    {
        static void Main(string[] args)
        {
 
            string path = "C:\\boolean\\addresses.csv";
            StreamReader sorgente = File.OpenText(path);

            List<Indirizzo> IndirizziPersonali = new List<Indirizzo>();


            while (sorgente.EndOfStream == false) 

            try {

                {
                    string? riga = sorgente.ReadLine();
                    string[] separatire = riga.Split(',');

                    string Nome = separatire[0];
                        if (string.IsNullOrEmpty(Nome))
                        {
                            Nome = "nome non completo";
                        }
                            
                    string Cognome = separatire[1];
                        if (string.IsNullOrEmpty(Cognome))
                        {
                            Cognome = "Cognome mancante";
                        }

                    string Strada = separatire[2];
                        if (Strada.Length < 5)
                        {
                            Strada = "dato non completo";
                        }

                    string Citta = separatire[3];
                        if (Strada.Length < 5)
                        {

                        }

                    string Provincia = separatire[4];
                        if (Provincia.Length > 3)
                        {
                            Provincia = "dato non valido";
                        }

                        //int ZIP = int.Parse(separatire[5]);
                        int ZIP = 0 ;
                        if (separatire.Length >= 5 )
                        {
                            if (int.TryParse(separatire[5] , out int parsedZIP))
                            {
                                ZIP= parsedZIP;
                            }
                        }
                        


                        Indirizzo Bo = new Indirizzo(Nome, Cognome, Strada, Citta, Provincia, ZIP);

                    IndirizziPersonali.Add(Bo);
                }

            } catch(FormatException e)
            
            {
                Console.WriteLine("se non sono presenti tutti i dati viene bloccato ");
            }
            catch (Exception e)
            {

                Console.WriteLine($"nessun risultato numero 2 {e.Message}");
            }
            finally
            {

            }


            foreach (var indirizzoFatto in IndirizziPersonali)
            {
                Console.WriteLine(indirizzoFatto.ToString());
            }
        }
    }
}
//ci sono 2 errori con il FormatException , perche mancano le caselle con i  numeri , devo fare in modo che se mancano allora a valore 0 