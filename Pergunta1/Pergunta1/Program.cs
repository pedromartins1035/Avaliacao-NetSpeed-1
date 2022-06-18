using System;

namespace Pergunta1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Variaveis
            string programa = "";
            string opcao = "";
            int ano = 0;
            int total = 0;
            int total2000 = 0;
            decimal valor = 0;
            decimal valorFinal = 0;
            decimal desconto = 0;

            //Recebeu valor Sim por padrão
            programa = "S";

            while(programa != "N")
            {
                Console.Clear();
                Console.Write("Digite o valor do carro: ");
                valor = int.Parse(Console.ReadLine());

                Console.Write("Digite o ano do carro: ");
                ano = int.Parse(Console.ReadLine());

                if(ano <= 2000)
                {
                    desconto = 0.12m;
                    total2000 = total2000 + 1;
                    total = total + 1;
                }
                else
                {
                    desconto = 0.07m;
                    total = total + 1;
                }

                desconto = desconto * valor;
                valorFinal = valor - desconto;

                string valorD = "O valor com desconto: " + valorFinal;

                Console.WriteLine(valorD);

                Console.Write("Deseja continuar calculando? (S) Sim - (N) Não :");
                opcao = Console.ReadLine();

                switch (opcao.ToUpper())
                {
                    case "S":
                        programa = "S";
                        break;
                    case "N":
                        programa = "N";
                        break;
                    default:
                        programa = "S";
                        Console.Write("As opções disponíveis são apenas S ou N :");
                        opcao = Console.ReadLine();
                        break;
                }

                Console.Clear();
                
            }

            string TotalC = "Foram calculados: " + total2000 + " carro(s) com ano até 2000";
            string TotalF = "Total geral: " + total;

            Console.WriteLine(TotalC);
            Console.WriteLine(TotalF);

        }
    }
}
