/*
DEsenvolva a solução aqui em Program.cs, quando terminar cole o conteúdo 
no respectivo arquivo
*/

//Atv01.Executar();
//Atv02.Executar();
//Atv03.Executar();
//Atv04.Executar();
//Atv05.Executar(); 
/*
//método com retorno tipo string e vom parâtros tipo string
static string Concatenar(string nome, string sobrenome)
{
    string nomeSobrenome = nome + " " + sobrenome;
    return nomeSobrenome;
}

//método sem retorno tipo string e vom parâtros tipo string
static void Concatenar(string nome, string sobrenome)
{
    string nomeSobrenome = nome + " " + sobrenome;
    Console.WriteLine(nomeSobrenome);
}

//método sem retorno e sem parâmetos
static void Concatenar()
{
    Console.WriteLine("Digite o nome: ");
    string nome = Console.ReadLine()!;

    Console.WriteLine("Digite o sobrenome: ");
    string sobrenome = Console.ReadLine()!;


    string nomeSobrenome = nome + " " + sobrenome;
    Console.WriteLine(nomeSobrenome);
}

// método com retorno tipo string e sem parâmetro

static string Concatenar()
{
    Console.Write("Digite o nome: ");
    string nome = Console.ReadLine()!;

    Console.Write("Digite o sobrenome: ");
    string sobrenome = Console.ReadLine()!;


    string nomeSobrenome = nome + " " + sobrenome;
    return nomeSobrenome;
}

string concatenado = Concatenar();
Console.WriteLine(concatenado);
Console.WriteLine("Fim !");
*/

/*
1-
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

/*
2-
static int LerNumeroTabuada()
{
    Console.Write("Digite o número da tabuada: ");
    int numero = int.Parse(Console.ReadLine()!);

    return numero;
}

static void ExibirTabuada(int numero)
{
    Console.WriteLine();

    int contador = 1;

    while (contador <= 10)
    {
        Console.WriteLine($"{numero} x {contador} = {numero * contador}");
        contador++;
    }

    Console.WriteLine();
}

static string LerContinuacao()
{
    Console.Write("Dejesa consultar outra tabuada? s/n: ");
    String resposta = Console.ReadLine()!;

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

static void ExecutarTabuada()
{
    Console.Clear();

    int numero = LerNumeroTabuada();

    ExibirTabuada(numero);

    string resposta = LerContinuacao();

    if (DesejaContinuar(resposta))
    {
        ExecutarTabuada();
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Programa encerrado.");
    }
}

ExecutarTabuada();
*/

/*
3-
static void ExibirMenuConversao()
{
    Console.Clear();
    Console.WriteLine("=== CONVERSOR DE TEMPERATURA ===");
    Console.WriteLine("1 - Celsius para Fahrenheit");
    Console.WriteLine("2 - Fahrenheit para Celsius");
    Console.Write("Escolha uma opção: ");
}

static string LerOpcaoConversao()
{
    return Console.ReadLine()!;
}

static double LerTemperatura()
{
    Console.Write("Digite a temperatura: ");
    return double.Parse(Console.ReadLine()!);
}

static double ConverterCelsiusParaFahrenheit(double celsius)
{
    return (celsius * 9 / 5) + 32;
}

static double ConverterFahrenheitParaCelsius(double fahrenheit)
{
    return (fahrenheit - 32) * 5 / 9;
}

static void ExibirResultadoConversao(double resultado, string unidade)
{
    Console.WriteLine();
    Console.WriteLine($"Resultado: {resultado:F2} {unidade}");
}

static void ExecutarConversor()
{
    ExibirMenuConversao();

    string opcao = LerOpcaoConversao();
    double temperatura = LerTemperatura();

    switch (opcao)
    {
        case "1":
            double resultadoFahrenheit = ConverterCelsiusParaFahrenheit(temperatura);
            ExibirResultadoConversao(resultadoFahrenheit, "°F");
            break;

        case "2":
            double resultadoCelsius = ConverterFahrenheitParaCelsius(temperatura);
            ExibirResultadoConversao(resultadoCelsius, "°C");
            break;

        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
}

ExecutarConversor();

*/

/*
4-
static string LerNomeCliente()
{
    Console.Write("Digite o nome do cliente: ");
    return Console.ReadLine()!;
}

static double LerValorCompra()
{
    Console.Write("Digite o valor da compra: ");
    return double.Parse(Console.ReadLine()!);
}

static double CalcularDesconto(double valorCompra)
{
    if (valorCompra >= 200)
    {
        return valorCompra * 0.15;
    }

    return valorCompra * 0.05;
}

static double CalcularValorFinal(double valorCompra, double desconto)
{
    return valorCompra - desconto;
}

static void ExibirResumo(string cliente, double valorCompra, double desconto, double valorFinal)
{
    Console.WriteLine();
    Console.WriteLine("=== RESUMO DA COMPRA ===");
    Console.WriteLine($"Cliente: {cliente}");
    Console.WriteLine($"Valor da compra: R$ {valorCompra:F2}");
    Console.WriteLine($"Desconto: R$ {desconto:F2}");
    Console.WriteLine($"Valor final: R$ {valorFinal:F2}");
}

static void ExecutarPrograma()
{
    string cliente = LerNomeCliente();
    double valorCompra = LerValorCompra();

    double desconto = CalcularDesconto(valorCompra);
    double valorFinal = CalcularValorFinal(valorCompra, desconto);

    ExibirResumo(cliente, valorCompra, desconto, valorFinal);
}

ExecutarPrograma();
*/

/*
static void Menu()
{
    Console.Clear();
    Console.WriteLine("=== CALCULADORA ===");
    Console.WriteLine("+ Soma");
    Console.WriteLine("- Subtração");
    Console.WriteLine("* Multiplicação");
    Console.WriteLine("/ Divisão");
    Console.Write("Escolha uma opção: ");
}

static string LerOpcao()
{
    return Console.ReadLine()!;
}

static double LerNumero(string mensagem)
{
    Console.Write(mensagem);
    return double.Parse(Console.ReadLine()!);
}

static double Somar(double numero1, double numero2)
{
    return numero1 + numero2;
}

static double Subtrair(double numero1, double numero2)
{
    return numero1 - numero2;
}

static double Multiplicar(double numero1, double numero2)
{
    return numero1 * numero2;
}

static double Dividir(double numero1, double numero2)
{
    return numero1 / numero2;
}

static void ExibirResultado(string opcao, double resultado)
{
    if (opcao == "+")
    {
        Console.WriteLine($"Resultado da soma: {resultado}");
    }
    else if (opcao == "-")
    {
        Console.WriteLine($"Resultado da subtração: {resultado}");
    }
    else if (opcao == "*")
    {
        Console.WriteLine($"Resultado da multiplicação: {resultado}");
    }
    else if (opcao == "/")
    {
        Console.WriteLine($"Resultado da divisão: {resultado}");
    }
    else
    {
        Console.WriteLine("Opção inválida.");
    }
}

static string PerguntarContinuar()
{
    Console.WriteLine();
    Console.Write("Deseja fazer outro cálculo? (s/n): ");
    return Console.ReadLine()!;
}

static void Opcao()
{
    string continuar = "s";

    while (continuar == "s" || continuar == "S")
    {
        Menu();

        string opcao = LerOpcao();

        double numero1 = LerNumero("Digite o primeiro número: ");
        double numero2 = LerNumero("Digite o segundo número: ");

        double resultado = 0;

        if (opcao == "+")
        {
            resultado = Somar(numero1, numero2);
        }
        else if (opcao == "-")
        {
            resultado = Subtrair(numero1, numero2);
        }
        else if (opcao == "*")
        {
            resultado = Multiplicar(numero1, numero2);
        }
        else if (opcao == "/")
        {
            resultado = Dividir(numero1, numero2);
        }

        ExibirResultado(opcao, resultado);

        continuar = PerguntarContinuar();
    }

    Console.WriteLine("Fim de programa!!");
}

Menu();
Opcao();
*/