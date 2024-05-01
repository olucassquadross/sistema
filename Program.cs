string nome;

Console.WriteLine("Sistema de Cálculo de Média de Alunos");

InserirNome();

// Criar um objeto Aluno
Aluno aluno=new Aluno(nome);

aluno.InserirNotas();

aluno.ExibirSituacaoAluno();

// Solicitação do nome do aluno
void InserirNome()
{
    Console.Write("Digite o nome do aluno: ");
    nome = Console.ReadLine();
}