using System;
using System.Collections.Generic;
using System.IO;

namespace OrganizzatoreTask


{
    class Program
    {
        //organizzatore
        private static OrganizzatoreTask organizzatore = new OrganizzatoreTask();

        static void Main(string[] args)
        {
            Console.WriteLine("Gestione task!");



            //inizializzo lista task
            List<attività> task= new List<attività>();

            //Creo un task
            attività task1 = new attività("studiare per l'esame", "21/11/2021", "alto");
            attività task2 = new attività("preparare una torta", "08/05/2021", "basso");
            attività task3 = new attività(" andare a correre", "07/05/2021", "medio");


            //Aggiungiamo alla lista
            task.Add(task1);
            task.Add(task2);
            task.Add(task3);




            do
            {
                //creo menù
                Console.WriteLine("Scegli un'opzione: \n 1. Visualizzare lista task \n 2. Aggiungere un nuovo task \n 3.Elimina task \n 0. Esci");



                char sceltaMenu = Console.ReadKey().KeyChar;

                //listaaggiornata
                List<attività> ListaAgg = OrganizzatoreTask.OttieniListaAgg();

                switch (sceltaMenu)
                {
                    case '1':
                        //Visualizzare lista
                        //scorro sulla lista con un foreach

                        if (ListaAgg.Count > 0)
                        {


                            foreach (var attività in task)
                               
                            {
       
                                Console.WriteLine( );
                                    
                                   
                            }
                        }
                        else
                            Console.WriteLine("lista vuota");

                        break;

                    case '2':

                        //Aggiungere un nuovo libro alla lista
                        attività nuovoLibro = OrganizzatoreTask.AggiungiTask();
                        break;

                    case '3':
                        //elimino task


                       



                       

                    case '0':
                        return;
                }
                continue;



            } while (true);
        }
    }
}
