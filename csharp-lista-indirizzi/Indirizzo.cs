using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    internal class Indirizzo
    {
        public string Nome { get; set; }
        public string Cognome { get; set; } 
        public string Strada { get; set; }
        public string Citta { get; set;}
        public string Provincia { get; set; }
        public int ZIP {  get; set; }
        public Indirizzo (string Nome , string Cognome , string Strada , string Citta  , string Provincia , int ZIP)
        {

        }
    }
}
