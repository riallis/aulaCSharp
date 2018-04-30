using System;

namespace Aluguel
{
    class Program
    {
        static void Main(string[] args)
        {
           cadastro[] vet;
            int QtQuarto;
            vet = new cadastro[9];

            Console.Write("Quantos aluguéis serão registrados? ");
            QtQuarto = int.Parse(Console.ReadLine());

            for (int i = 0; i < QtQuarto; i++)
            {
                Console.WriteLine("Dados do " + i + "° aluguel: ");
                vet[i] = new cadastro();
            }

            //vet[QtQuarto].NQuarto.OrderByDescending(x => x).toArray();
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++)
            {
                if (vet[i] != null)
                {
                    Console.WriteLine(i + ": " + vet[i]);
                }
            }

            Console.ReadLine();
        }
    }
}
