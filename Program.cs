using System;

namespace SistemaMediaAlunos
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Média de Alunos");

            
            Console.Write("Digite o nome do aluno: ");
            string nomeAluno = Console.ReadLine();


            Aluno aluno = new Aluno(nomeAluno);

            
            Console.Write("Digite a quantidade de notas: ");
            int quantidadeNotas = int.Parse(Console.ReadLine());


            for (int i = 1; i <= quantidadeNotas; i++)
            {
                Console.Write($"Digite a {i}ª nota: ");
                double nota = double.Parse(Console.ReadLine());
                aluno.InserirNota(nota);
            }

            
            Console.WriteLine($"A média do aluno {aluno.Nome} é: {aluno.CalcularMedia().ToString("F2")}");
            Console.WriteLine($"Situação: {aluno.VerificarSituacao()}");
        }
    }
}
