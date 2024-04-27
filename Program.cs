using System;
using System.Security.Cryptography.X509Certificates;

namespace SistemaMediaAlunos
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("CR acadêmico");

            
            Dictionary<string, Aluno> alunos = new Dictionary<string, Aluno>();

            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("Para registrar um aluno, digite 1\nPara consultar situação individual de um aluno, digite 2\nPara listar todos os alunos e suas médias, digite 3\nPara consultar média geral da turma, digite 4\nPara sair, digite 5");
                Console.Write("Escolha uma opção: ");
                if (int.TryParse(Console.ReadLine(), out int opcao))
                {
                    switch (opcao)
                    {
                        case 1:
                            AdicionarAluno(alunos);
                            break;
                        case 2:
                            CalcularMediaAluno(alunos);
                            break;
                        case 3:
                            ListarAlunosEMedias(alunos);
                            break;
                        case 4:
                            CalcularMediaGeralTurma(alunos);
                            break;
                        case 5:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Opção inválida. Tente novamente.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                }
            }
        }

        public static void AdicionarAluno(Dictionary<string, Aluno> alunos)
        {
            Console.Write("Digite o nome do aluno: ");
            string nomeAluno = Console.ReadLine();

            Aluno aluno = new Aluno(nomeAluno);

            Console.Write("Digite a quantidade de notas: ");
            if (int.TryParse(Console.ReadLine(), out int quantidadeNotas))
            {
                for (int i = 0; i < quantidadeNotas; i++)
                {
                    Console.Write($"Digite a nota {i + 1}: ");
                    if (double.TryParse(Console.ReadLine(), out double nota))
                    {
                        aluno.InserirNota(nota);
                    }
                    else
                    {
                        Console.WriteLine("Nota inválida. Tente novamente.");
                        i--;
                    }
                }

                alunos.Add(nomeAluno, aluno);
                Console.WriteLine($"Aluno {nomeAluno} adicionado com sucesso!");
            }
            else
            {
                Console.WriteLine("Quantidade inválida. Tente novamente.");
            }
        }

        public static void CalcularMediaAluno(Dictionary<string, Aluno> alunos)
        {
            Console.Write("Digite o nome do aluno: ");
            string nomeAluno = Console.ReadLine();

            if (alunos.ContainsKey(nomeAluno))
            {
                Aluno aluno = alunos[nomeAluno];
                Console.WriteLine($"A média do aluno {aluno.Nome} é: {aluno.CalcularMedia().ToString("F2")}");
                Console.WriteLine($"Situação: {aluno.VerificarSituacao()}");
            }
            else
            {
                Console.WriteLine("Aluno não encontrado.");
            }
        }

        public static void ListarAlunosEMedias(Dictionary<string, Aluno> alunos)
        {
            foreach (var aluno in alunos)
            {
                Console.WriteLine($"Nome: {aluno.Key}, Média: {aluno.Value.CalcularMedia().ToString("F2")}");
            }
        }

        public static void CalcularMediaGeralTurma(Dictionary<string, Aluno> alunos)
        {
            if (alunos.Count > 0)
            {
                double totalMedia = 0;
                foreach (var aluno in alunos)
                {
                    totalMedia += aluno.Value.CalcularMedia();
                }
                double mediaGeral = totalMedia / alunos.Count;
                Console.WriteLine($"Média geral da turma: {mediaGeral.ToString("F2")}");
            }
            else
            {
                Console.WriteLine("Não há alunos registrados.");
            }
        }
    }
}

            