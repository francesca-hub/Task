using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizzatoreTask
{
    class organizzatore
    {
        //lista inizializzata qui
        List<attività> task = new List<attività>();

        //aggiunta task
        public attività AggiungiTask()
        {
            Console.WriteLine("Inserisci descrizione oggetto: ");
            string oggetto = Console.ReadLine();// ciò che scrive l'utenete finisce in oggetto

            Console.WriteLine("Inserisci data di scadenza:");
            string scadenza = Console.ReadLine();

            Console.WriteLine("Inserisci livello importanza: ");
            string livello = Console.ReadLine();

            //creo nuovo task
            attività nuovotask = new attività(oggetto, scadenza, livello);
            attività.Add(nuovotask);
            return nuovotask;



        }

        //per recuperare la lista di task aggiornata
        public List<attività> OttieniListaAgg()
        {

            return task;
        }

        private static void EliminaTask ()
        {
           
        }
    }
}
