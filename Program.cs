using System;

namespace SistemaMediaAlunos
{
    class Program 
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Média de Alunos");

            // Solicitação do nome do aluno
            Console.Write("Digite o nome do aluno: ");
            string nome = Console.ReadLine();

            // Criar um objeto Aluno usando o construtor
            Aluno aluno = new Aluno(nome);

            // Solicitação da quantidade de notas a serem inseridas
            Console.Write("Digite a quantidade de notas: ");
            int quantidadeNotas = int.Parse(Console.ReadLine());

            // Laço para inserir as notas
            for (int i = 1; i <= quantidadeNotas; i++)
            {
                Console.Write($"Digite a {i}ª nota: ");
                double nota = double.Parse(Console.ReadLine());
                aluno.AdicionarNota(nota); // Delega a adição de notas para a classe Aluno
            }

            // Exibição da média e situação do aluno
            Console.WriteLine($"A média do aluno {aluno.Nome} é: {aluno.CalcularMedia().ToString("F2")}");
            Console.WriteLine($"Situação: {aluno.VerificarSituacao()}");
        }
    }
}

