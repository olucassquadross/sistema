using System.Collections.Generic;

namespace SistemaMediaAlunos
{
    public class Aluno 
    {
        public string Nome { get; set; }
        public List<double> Notas { get; set; } = new List<double>();  // Inicialização da lista

        // Criação do construtor Aluno

        public Aluno(string nome)
        {
            Nome = nome; // inicializando o atributo Nome
        }


        // Método para adcionar nota

        public void AdicionarNota(double nota)
        {
            Notas.Add(nota);
        }


          // método para calcular a média das notas

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
