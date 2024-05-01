public class Aluno 
{
    public string Nome { get; private set; }
    public List<double> Notas { get; set; } = new List<double>();  // Inicialização da lista
    
    // Construtor para inicializar o nome do aluno
    public Aluno(string nome)
    {
        Nome=nome;
    }

    // Solicitação do nome do aluno
    public void InserirNome()
    {
        Console.Write("Digite o nome do aluno: ");
        Nome = Console.ReadLine();
    }

    // Método para adicionar notas
    public void AdicionarNota(double nota)
    {
        Notas.Add(nota);
    }
    public void InserirNotas()
    {
        // Solicitação da quantidade de notas a serem inseridas
        Console.Write("Digite a quantidade de notas: ");
        int quantidadeNotas = int.Parse(Console.ReadLine());

        // Laço para inserir as notas
        for (int i = 1; i <= quantidadeNotas; i++)
        {
            Console.Write($"Digite a {i}ª nota: ");
            double nota = double.Parse(Console.ReadLine());
            AdicionarNota(nota);
        }
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

    // Exibição da média e situação do aluno
    public void ExibirSituacaoAluno()
    {
        Console.WriteLine($"A média do aluno {Nome} é: {CalcularMedia().ToString("F2")}");
        Console.WriteLine($"Situação: {VerificarSituacao()}");
    }
}