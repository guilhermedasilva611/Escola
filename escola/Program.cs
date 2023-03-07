using System;

/*
Faça um programa para ler três notas e o número de faltas de um aluno e
escrever qual a sua situação final: Aprovado, Reprovado por Falta ou
Reprovado por Média. A média para aprovação é 7,0 e o limite de faltas é 25% do total de aulas.
O número de aulas ministradas no semestre foi de 80. A reprovação por falta sobrepõe a reprovação por Média.
*/
namespace escola
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int repetir = 1;

            do
            {

                Console.WriteLine("Digite as notas:");

                Console.Write("NOTA 1:");
                double nota1 = double.Parse(Console.ReadLine());

                Console.Write("NOTA 2:");
                double nota2 = double.Parse(Console.ReadLine());

                Console.Write("NOTA 3:");
                double nota3 = double.Parse(Console.ReadLine());

                Console.Write("Digite as faltas:");
                int faltas = int.Parse(Console.ReadLine());

                double media = (nota1 + nota2 + nota3) / 3;

                if (faltas > 20)
                {
                    Console.WriteLine("REPROVADO por faltas!");
                }
                else if (media < 7.0)
                {
                    Console.WriteLine("REPROVADO por nota!");
                }
                else
                {
                    Console.WriteLine("APROVADO!");
                }

                Console.WriteLine("deseja repetir o programa? (1)-Sim (2)-Não ");
                repetir = int.Parse(Console.ReadLine());

            } while (repetir == 1);

            Console.WriteLine("---Digite ENTER para ecerrar o programa---");
            Console.ReadLine();


        }
    }
}
