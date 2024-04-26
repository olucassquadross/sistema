using System.Collections.Generic;

namespace SistemaMediaAlunos
{
    public class Aluno 
    {
        public string Nome { get; set; }
        private int _quantNotas;
        public List<double> Notas { get; set; } = new List<double>();  // Inicialização da lista

        public Aluno()
        {
            Console.Write("Digite o nome do aluno: ");
            Nome = Console.ReadLine();

            Console.Write("Informe a quantidade de notas: ");
            _quantNotas = int.Parse(Console.ReadLine());
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
