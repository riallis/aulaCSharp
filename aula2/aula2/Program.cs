using System;

namespace aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto[] vet;
            double soma, media;
            int N;

            N = int.Parse(Console.ReadLine());
            vet = new Produto[N];

            for(int i=0; i<N; i++){
                String nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine());
                vet[i] = new Produto(nome, preco);
            }

            soma = 0.0;
            for (int i = 0; i < N; i++)
            {
                soma += vet[i].valor;
            }

            media = soma / N;

            Console.WriteLine("Preço medio = " + media.ToString());

            Console.ReadLine();
            
        }
    }
}
