using System;

namespace c_sharp_esercizio_giorno_3_banca
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool apriamoConto = true;

            // fintanto che l'utente accetta di aprire il conto corrente
            while (apriamoConto)
            {

                Console.WriteLine("Ciao, stai aprendo il conto corrente, vuoi procedere?  y/n");

                string rispostaUtente = Convert.ToString(Console.ReadLine());

                if (rispostaUtente == "y")
                {
                    // se utente accetta ci troviamo qui dentro
                    apriamoConto = true;

                    Console.WriteLine("inserisci il tuo nome:");
                    string nomeUtente = Convert.ToString(Console.ReadLine());

                    Console.WriteLine("inserisci il tuo cognome:");
                    string cognomeUtente = Convert.ToString(Console.ReadLine());


                    // se il codice fornito è diverso da 6 ri looppa la richiesta 
                    string numConto;
                    do
                    {
                        Console.WriteLine("inserisci un numero di conto a 6 cifre:");
                        numConto = Convert.ToString(Console.ReadLine());

                        if (numConto.Length != 6)
                        {
                            Console.WriteLine("hai inserito dei valori scorretti, riprova!");
                            Console.WriteLine("\n");
                        }
                    }

                    while (numConto.Length != 6);

                    // creo utente a partire dai dati forniti
                    ContoCorrente utente1 = new ContoCorrente(nomeUtente, cognomeUtente, numConto);

                    Console.WriteLine("\n");
                    Console.WriteLine("creazione Utente riuscita con successo!");
                    Console.WriteLine($"benvenuto utente {nomeUtente.ToUpper()}, {cognomeUtente.ToUpper()} ");
                    Console.WriteLine("\n");

                    Console.WriteLine("devi fare il tuo primo versamento, non sei contento?");

                    string input;
                    int primoVersamento;

                    do
                    {
                        Console.WriteLine("inserisci importo da versare:");
                        input = (Console.ReadLine());

                        // se il tryParse restituisce true, (input è un int) il suo valore viene associato a primoversamento

                        if (int.TryParse(input, out primoVersamento))
                        {
                            if (primoVersamento >= 1000)
                            {
                                Console.WriteLine("\n");

                                // se le condizioni vengono soddisfatte chiamo metodo per depositare e faccio il deposito dei money.
                                utente1.DepositaLaGrana(primoVersamento);
                                Console.WriteLine("\n");
                                Console.WriteLine("primo versamento avvenuto con successo!");
                                Console.WriteLine($" Hai depositato nella banca la bellezza di {utente1.Soldidepositati} Euri!");

                            }
                            else
                            {
                                Console.WriteLine("\n");
                                Console.WriteLine("Devi depositare almeno 1000 euro.");
                                Console.WriteLine("\n");
                            }

                        }
                        else
                        {
                            Console.WriteLine("\n");
                            Console.WriteLine("Errore nel versamento, riprovare.");
                        }
                    }
                    while (primoVersamento <= 999);


                    // vuole anche prelevare?
                    Console.WriteLine("\n");
                    Console.WriteLine("Vuoi prelevare dei soldi?  y/n ");
                    Console.WriteLine("\n");


                    string rispostaPrelievo = Console.ReadLine();
                    int denaroDaPrelevare;

                    // se la risposta è no si esce
                    if (rispostaPrelievo == "n")
                    {
                        apriamoConto = false;
                        Console.WriteLine("Arrivederci!");
                    }
                    // se la risposta è si si procede con il metodo RitiraLaGrana()
                    else if (rispostaPrelievo == "y")
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("inserisci l'importo da prelevare:");
                        Console.WriteLine("\n");
                        denaroDaPrelevare = Convert.ToInt32(Console.ReadLine());
                        utente1.RitiraLaGrana(denaroDaPrelevare);
                        Console.WriteLine($" Hai prelevato {denaroDaPrelevare} euro dal tuo conto!");
                        Console.WriteLine($" Ora sul tuo contoCorrente restano {utente1.Soldidepositati} Euri!");
                        apriamoConto = false;
                    }






                }
                else if (rispostaUtente == "n")
                {
                    // usciamo dal while
                    apriamoConto = false;
                    // se risponde negativo si chiude il programma 
                    Console.WriteLine("Arrivederci!");
                }








            }
            Console.WriteLine("Arrivederci!!");


            // SECONDO ESERCIZIO    

            Console.WriteLine("\n");
            Console.WriteLine("Esercizio Array c#");
            Console.WriteLine("\n");

            // inizializzo un array di stringhe 

            // array con 5 "spazi"
            string[] arrayDiNOmi = new string[5];

            Console.WriteLine("popoliamo l'array");

            // ciclo for per popolare l'array
            for (int i = 0; i < arrayDiNOmi.Length; i++)
            {
                // fai sta roba, fintanto che risposta utente è no ("n")
                string rispostaUtente;
                do
                {
                    Console.WriteLine($"Inserisci un nome da inserire in posizione {i} nell'Array:");
                    string nome = Convert.ToString(Console.ReadLine());
                    arrayDiNOmi[i] = nome;
                    Console.WriteLine($"Hai inserito in posizione {i} il nome {nome.ToUpper()}");
                    Console.WriteLine("È corretto? y/n");
                    rispostaUtente = Convert.ToString(Console.ReadLine());
                }

                while (rispostaUtente == "n");

            }

            Console.WriteLine("\n");

            Console.WriteLine("i Nomi da te inseriti sono:");

            for (int i = 0; i < arrayDiNOmi.Length; i++)
            {
                string nome = arrayDiNOmi[i];
                Console.WriteLine(nome);
            }
            /*
             * 
            Console.WriteLine("Hai inserito questi nomi:");

            string risposta;
            while () { }

            for (int i = 0; i < arrayDiNOmi.Length; i++)
            {
                Console.WriteLine(arrayDiNOmi[i]);
                Console.WriteLine("\n");
                Console.WriteLine("È corretto? y/n");
                Console.Readline
            }

            */







            Console.ReadLine();
        }
    }
}
