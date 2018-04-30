using System;

namespace contaBancaria
{
    class abrirConta
    {
        public string nome {get; set;}
        public int numeroConta {get; private set;}
        public double saldoConta {get; private set;}

        public abrirConta()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Digite o numero da Conta: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            this.numeroConta = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Digite o nome: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            this.nome = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Haverá algum deposito? s : n ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string deposito = Console.ReadLine();

            if (deposito.Equals("s") || deposito.Equals("S"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Digite o Valor do deposito: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Deposito(double.Parse(Console.ReadLine()));
            }else
            {
                Deposito(0);
            }

            Console.WriteLine("Conta Criada!");
            StatusConta();
            Console.ResetColor();
        }

        public void Deposito(double valorDeposito)
        {
            this.saldoConta += valorDeposito;
            
            if (valorDeposito > 0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Deposito de {valorDeposito} relizado com sucesso"); 
                Console.ResetColor();
            }
            
        }

        public void Saca(double valorSaque)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            this.saldoConta -= valorSaque;
            this.saldoConta -= 5;
            Console.WriteLine($"Saque de {valorSaque} realizado com sucesso");
            Console.ResetColor();
        }

        public void StatusConta()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"Conta: {this.numeroConta}, Cliente: {this.nome}, Saldo: ");
            if(this.saldoConta >= 0)
            {
                Console.WriteLine(this.saldoConta);
            }else
            {
                Console.ForegroundColor = ConsoleColor.Red;   
                Console.WriteLine(this.saldoConta);
            }
             Console.ResetColor();
        }
    }
}