using System.Collections.Generic;

namespace SistemaMediaAlunos
{
    public class Aluno
    {
        public string Nome { get; set; }
        private List<double> notas;

        public Aluno(string nome)
        {
            Nome = nome;
            Notas = new List<double>();
        }

        // Método para inserir notas
        public void InserirNota(double nota)
        {
            Notas.Add(nota);
        }

        public double CalcularMedia()
        {
            if (notas.Count == 0)
                return 0;
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
