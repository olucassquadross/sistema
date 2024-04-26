using System;
using SistemaMediaAlunos;  // Adicionando o using para o namespace onde Aluno está definido

namespace SistemaMediaAlunos
{
    class Program 
    {
        public static void Main(string[] args) 
        {
           Console.WriteLine("Sistema de Cálculo de Média de Alunos");


             // solicita o nome do aluno

            Console.Write("Digite o nome do aluno: ");
            string nome = Console.ReadLine();

            // Criação do objeto Aluno 
            // passando o parâmentro nome fornecido pelo usuário

            Aluno aluno = new Aluno(nome);

            Console.Write("Digite a quantidade de notas: ");
            int quantidadeNotas = int.Parse(Console.ReadLine());

               // loop para adcionar as nootas para o aluno
               // de uma só vez
            for (int i = 1; i <= quantidadeNotas; i++)
            {
                // solicta a nota ao usuário
                Console.Write($"Digite a {i}ª nota: ");
                double nota = double.Parse(Console.ReadLine());

                // chama o método AdicionarNota 
                // que adiciona uma nota passda como 
                // parâmetro pelo usuário a lista de notas
                // do aluno
                aluno.AdicionarNota(nota);
            }

            Console.WriteLine($"A média do aluno {aluno.Nome} é: {aluno.CalcularMedia().ToString("F2")}");
            Console.WriteLine($"Situação: {aluno.VerificarSituacao()}");
        }
    }
}