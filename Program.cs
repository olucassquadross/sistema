using System;
using SistemaMediaAlunos;  // Adicionando o using para o namespace onde Aluno está definido

namespace SistemaMediaAlunos
{
    class Program 
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Sistema de Cálculo de Média de Alunos");

            // Solicitação do nome do aluno
            Console.Write("Digite o nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            // Criar um objeto Aluno e fornecer
            // o parâmetro nome fornecido pelo susário
            Aluno aluno = new Aluno(nome);

            

            // Solicitação da quantidade de notas a serem inseridas
            Console.Write("Digite a quantidade de notas: ");
            int quantidadeNotas = int.Parse(Console.ReadLine());

            // chamando o método AdicionarNota que vai adicionar
            // a nota para o objeto aluno passando como parâmetro
            // a nota  fornecida pelo usuário
            aluno.AdicionarNota(nota);

            // Laço para inserir as notas
            for (int i = 1; i <= quantidadeNotas; i++)
            {
                Console.Write($"Digite a {i}ª nota: ");
                double nota = double.Parse(Console.ReadLine());
                // Adiciona uma nota a lista de notas aluno
                aluno.Notas.Add(nota);
            }

            // Exibição da média e situação do aluno
            Console.WriteLine($"A média do aluno {aluno.Nome} é: {aluno.CalcularMedia().ToString("F2")}");
            Console.WriteLine($"Situação: {aluno.VerificarSituacao()}");
        }
    }
}
