using System;

namespace aula2
{
    public class Produto
    {
        public string nome {get; private set; }
        public double valor {get; private set; }
        public int quantidadeEmEstoque {get; private set; }

        public void Nome( string nome){
            this.nome = nome;
        }

        public void Valor(double valor){
            this.nome = nome;
        }

        public double valorTotalEmEstoque(){
            return valor * quantidadeEmEstoque;
        }

        public void realizarEntrada(int Quantidade){
            quantidadeEmEstoque += Quantidade;
        }

        public void realizarSaida(int Quantidade){
            quantidadeEmEstoque -= Quantidade;
        }

        public override string ToString(){
            return nome 
                +   ", "
                +   "R$ "
                +   valor.ToString()
                +   ", "
                +   quantidadeEmEstoque
                +   " Unidades, Total: R$ "
                +   valorTotalEmEstoque().ToString();

        }

        public Produto(){
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("Digite os dados do produtos");
            Console.Write("Nome: ");
            this.nome = Console.ReadLine();
            Console.Write("Preço: ");
            this.valor = double.Parse(Console.ReadLine());
            Console.Write("Quantidade em Estoque: ");
            this.quantidadeEmEstoque = int.Parse(Console.ReadLine());

           
        }

        public Produto(String nome, Double preco){
            this.nome = nome;
            this.valor = preco;
        }

    }
}