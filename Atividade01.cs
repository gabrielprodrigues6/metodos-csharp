/*
Uma escola deseja criar um pequeno programa para calcular a média final de um aluno. 
O sistema deve receber o nome do aluno e três notas. Ao final, deve exibir a média e 
informar se o aluno foi aprovado, ficou em recuperação ou foi reprovado.

Código iniciado, o método LerNota ( ) é chamado, ele leva a string como mensagem 9Nota 1:; Nota 2: ...
*/

/*
static double LerNota(string mensagem)
{
    Console.Write(mensagem);
    double nota = double.Parse(Console.ReadLine()!);

    return nota;
}


static void ExecutarSistema()
{
    string nome = LerNomeAluno();

    double nota1 = LerNota("Nota 1: ");
    double nota2 = LerNota("Nota 2: ");
    double nota3 = LerNota("Nota 3: ");

    double media = CalcularMedia(nota1, nota2, nota3);

    string situacao = VerificarSituacao(media);

    ExibirResultado(nome, media, situacao);
}

ExecutarSistema();

*/

/*
static string LerNomeAluno()
{
    Console.Write("Nome do aluno: ");
    string nome = Console.ReadLine()!;

    return nome;
}

static double LerNota(string mensagem)
{
    Console.Write(mensagem);
    double nota = double.Parse(Console.ReadLine()!);

    return nota;
}

static double CalcularMedia(double nota1, double nota2, double nota3)
{
    double media = (nota1 + nota2 + nota3) / 3;

    return media;
}

static string VerificarSituacao(double media)
{
    if (media >= 7)
    {
        return "Aprovado";
    }
    else if (media >= 5)
    {
        return "Recuperação";
    }
    else
    {
        return "Reprovado";
    }
}

static void ExibirResultado(string nome, double media, string situacao)
{
    Console.WriteLine();
    Console.WriteLine("=== RESULTADO FINAL ===");
    Console.WriteLine($"Aluno: {nome}");
    Console.WriteLine($"Média final: {media:F2}");
    Console.WriteLine($"Situação: {situacao}");
    Console.WriteLine();
}

static string LerContinuacao()
{
    Console.Write("Deseja consultar outro aluno? s/n: ");
    string resposta = Console.ReadLine()!;

    return resposta;
}

static bool DesejaContinuar(string resposta)
{
    if (resposta == "s" || resposta == "S")
    {
        return true;
    }
    else
    {
        return false;
    }
}

static void ExecutarSistemaMedia()
{
    Console.Clear();

    string nome = LerNomeAluno();

    double nota1 = LerNota("Nota 1: ");
    double nota2 = LerNota("Nota 2: ");
    double nota3 = LerNota("Nota 3: ");

    double media = CalcularMedia(nota1, nota2, nota3);

    string situacao = VerificarSituacao(media);

    ExibirResultado(nome, media, situacao);

    string resposta = LerContinuacao();

    if (DesejaContinuar(resposta))
    {
        ExecutarSistemaMedia();
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Programa encerrado.");
    }
}

ExecutarSistemaMedia();
*/