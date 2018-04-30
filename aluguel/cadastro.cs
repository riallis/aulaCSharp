using System;

namespace Aluguel {
    class cadastro {
        public string nome, email;
        public int NQuarto;

        public cadastro () {
            Console.Write ("Nome: ");
            this.nome = Console.ReadLine ();

            Console.Write ("Email: ");
            this.email = Console.ReadLine ();

            Console.Write ("Quarto: ");
            this.NQuarto = int.Parse (Console.ReadLine ());
        }

        public override string ToString () {
            return nome + ", " + email;
        }
    }
}