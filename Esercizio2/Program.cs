//Indovina valore: Creare e inizializzare un array di interi dimensione N=4;
//Chiedere all'utente di provare ad indovinare un numero.
//Verificare se il numero inserito dall'utente c'è nell'array
//Se c'è stampa "hai vinto", se non c'è stampa "Hai perso".

using System;

namespace Esercizio2
{
    class Program
    {
        static void Main(string[] args)
        {

            int posizione = -1;
            do
            {
                Console.WriteLine("Indovina se un numero è presente in un vettore \n");
                int[] vettore = new int[] { 8, 16, 24, 32 };
                Console.WriteLine("Quale numero vuoi ricercare?\n");
                int key = int.Parse(Console.ReadLine());

                Indovina(vettore, ref posizione, key);
            } while (posizione == -1);
        }

        private static void Indovina(int[] vet, ref int pos, int key)
        {
            for (int i = 0; i < 4; i++)
            {
                if (vet[i] == key)
                {
                    pos = i;
                    break;
                }
            }

            if (pos != -1)
            {
                Console.WriteLine($"Hai vinto!\nL'elemento {key} è stato trovato in posizione {pos + 1} \n");
            }
            else
            {
                Console.WriteLine($"Hai perso!\nL'elemento {key} non è presente nell'array \n");
            }
        }
    }
}
