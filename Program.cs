using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04Leitura
{
    class Program
    {
        static void Main(string[] args)
        {
            // Int32.Parse ( serve para alterar a variavel do tipo String para Int e sempre com Letra maiuscula)
            string nome;
            string sobrenome;
            string segundosobrenome;
            int idade;
            Console.WriteLine("Digite o seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o seu sobrenome: ");
            sobrenome = Console.ReadLine();
            Console.WriteLine("Digite o seu segundo sobrenome");
            segundosobrenome = Console.ReadLine();
            Console.WriteLine("Digite sua idade:");
            idade = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Seja bem-vindo {nome} {sobrenome} {segundosobrenome} de {idade} anos de idade");
            Console.ReadKey();
          

        }






        void Atividade()
        {
            string Criador = "Wendell";
            float lanche = 8.00f;
            float salsicha = 1.50f;
            float hamburger = 2.00f;
            float requeijão = 1.50f;
            float bacon = 2.00f;
            float xtudo = 13.5f;
            float cachorroquente = 12.5f;
            int amodacasa = 15;
            float combo = xtudo + cachorroquente + amodacasa;
            float salsichas = salsicha + salsicha;

            Console.WriteLine($"Bem-vindo ao catalogo digital do {Criador} lanches");
            Console.WriteLine("Confira os Valores:");
            Console.WriteLine($"X-TUDO : hamburguer , bacon e salsicha - R${lanche + hamburger + bacon + salsicha}");
            Console.WriteLine($"Cachorro-Quente Cremoso : 2 salsicha e Requeijão - R${lanche + salsichas + requeijão}");
            Console.WriteLine($"A moda da casa : Salsicha , hamburguer, " +
                $"requeijão e bacon - R${lanche + salsicha + hamburger + requeijão + bacon}");
            Console.WriteLine($"Combo : X-tudo + Cachorro-quente + a moda da casa - R${combo}");
            Console.ReadKey();

        }






    }
}
