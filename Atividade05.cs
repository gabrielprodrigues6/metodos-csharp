/*
Refatore o arquivo Calc.cs, deixe tudo dentro de função, 

Sugestão:
- Crie uma função Menu(){  } , que quando executada chama a função Opção() { }
na última linha do código chame a função Menu();

*/


/*
double numero1;
double numero2;
double resultado = 0;
string opcao;
string continuar = "s";

while (continuar == "s" || continuar == "S")
{
 Console.Clear();
 Console.WriteLine("=== CALCULADORA ===");
 Console.WriteLine("+ Soma");
 Console.WriteLine("- Subtração");
 Console.WriteLine("* Multiplicação");
 Console.WriteLine("/ Divisão");
 Console.Write("Escolha uma opção: ");
 opcao = Console.ReadLine()!;

 Console.Write("Digite o primeiro número: ");
 numero1 = double.Parse(Console.ReadLine()!);

 Console.Write("Digite o segundo número: ");
 numero2 = double.Parse(Console.ReadLine()!);

 if (opcao == "+")
 {
     resultado = numero1 + numero2;
     Console.WriteLine($"Resultado da soma: {resultado}");
 }
 else if (opcao == "-")
 {
     resultado = numero1 - numero2;
     Console.WriteLine($"Resultado da subtração: {resultado}");
 }
 else if (opcao == "*")
 {
     resultado = numero1 * numero2;
     Console.WriteLine($"Resultado da multiplicação: {resultado}");
 }
 else if (opcao == "/")
 {
     resultado = numero1 / numero2;
     Console.WriteLine($"Resultado da divisão: {resultado}");
 }
 else
 {
     Console.WriteLine("Opção inválida.");
 }

Console.WriteLine();
Console.Write("Deseja fazer outro cálculo? (s/n): ");
continuar = Console.ReadLine()!;
}

Console.Write("Fim de programa!!");

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