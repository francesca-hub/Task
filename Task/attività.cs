using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OrganizzatoreTask
{
    class TASK
    {
        //Costruttore: per inizializzare l'oggetto e lo chiamo come la classe
        public TASK(string descrizioneoggetto, string datadiscadenza, string livelloimportanza)
        {
            descrizioneoggetto = Oggetto;
            datadiscadenza = Scadenza;
            livelloimportanza = Livello;
        }

        //Proprietà: titolo, autore, categoria,disponibile...

        public string Oggetto { get; set; }
        public string Scadenza { get; set; }

        public string Livello { get; set; }

        public string OttieniDati
        {
            get
            {
                return ($"{Oggetto}--{Scadenza}--{Livello}");
            }
        }
    }
}
