using System.Collections.Generic;

namespace SistemaMediaAlunos
{
    public class Aluno 
    {
        public string Nome { get; private set; }
        private List<double> Notas { get; set; } = new List<double>();  // Inicialização da lista de notas

        // Construtor para inicializar o nome do aluno
        public Aluno(string nome)
        {
            Nome = nome;
        }
        
        // Método para adicionar notas
        public void AdicionarNota(double nota)
        {
            Notas.Add(nota);
        }

        // Método para calcular a média
        public double CalcularMedia()
        {
            double somaNotas = 0;
            foreach (var nota in Notas)
            {
                somaNotas += nota;
            }
            return somaNotas / Notas.Count;
        }

        // Método para verificar a situação do aluno
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
