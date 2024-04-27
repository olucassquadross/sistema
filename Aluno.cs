using System.Collections.Generic;

namespace SistemaMediaAlunos
{
    class Aluno
    {
        public string Nome { get; set; }
        private List<double> notas;

        public Aluno(string nome)
        {
            Nome = nome;
            notas = new List<double>();
        }

        public void InserirNota(double nota)
        {
            notas.Add(nota);
        }

        public double CalcularMedia()
        {
            if (notas.Count == 0)
                return 0;
            double soma = 0;
            foreach (var nota in notas)
            {
                soma += nota;
            }
            return soma / notas.Count;
        }

        public string VerificarSituacao()
        {
            double media = CalcularMedia();
            if (media >= 7)
                return "Aprovado";
            else if (media >= 5)
                return "Recuperação";
            else
                return "Reprovado";
        }
    }
}
