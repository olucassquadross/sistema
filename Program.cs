using System;
using SistemaMediaAlunos;  // Adicionando o using para o namespace onde Aluno está definido

namespace SistemaMediaAlunos
{
    class Program 
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Sistema de Cálculo de Média de Alunos");

            // Criar um objeto Aluno
            Aluno aluno = new Aluno();

            // Exibição da média e situação do aluno
            Console.WriteLine($"A média do aluno {aluno.Nome} é: {aluno.CalcularMedia().ToString("F2")}");
            Console.WriteLine($"Situação: {aluno.VerificarSituacao()}");
        }
    }
}
