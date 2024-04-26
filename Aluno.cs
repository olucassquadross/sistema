using System.Collections.Generic;

namespace SistemaMediaAlunos
{
    public class Aluno 
    {
        public string Nome { get; set; }
        public List<double> Notas { get; set; } = new List<double>();  // Inicialização da lista

        // Construtores para inicializar Aluno e as Notas
        public Aluno(string nome)
        {
            this.Nome = nome;
            this.Notas = new List<double>();
        }

        public void InserirNota()
        {
            Console.WriteLine("Digite a quantidade de notas para calcular a média");
            int quantidade = int.Parse(Console.ReadLine());


            for  (int i = 0; i < quantidade; i++)
            {
                Console.Write($"Digite a {i}ª nota: ");
                double nota = double.Parse(Console.ReadLine());
                this.Notas.Add(nota);
            }
        }
        public double CalcularMedia()
        {
            double somaNotas = 0;
            foreach (var nota in Notas)
            {
                somaNotas += nota;
            }
            return somaNotas / Notas.Count;
        }

        public string VerificarSituacao()
        {
            double media = CalcularMedia();
            if (media >= 7)
            {
                return "Aprovado";
            }
            else
            {
                return "Reprovado";
            }
        }
    }
}
