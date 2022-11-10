public class Calculator
{
    public int Sum(int ValueOne, int ValueTwo) => ValueOne + ValueTwo;

    public int Subtraction(int ValueOne, int ValueTwo) => ValueOne - ValueTwo;

    public int Multiplication(int ValueOne, int ValueTwo) => ValueOne * ValueTwo;

    public int Division(int ValueOne, int ValueTwo) => ValueOne / ValueTwo;

}

class Program
{
    static void Main()
    {
        int NumberOne = 0;
        int NumberTwo = 0;
        int operetor = 0;

        Console.WriteLine("Informe o tipo de operação");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");

        try
        {
            operetor = Int32.Parse(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Valor inserido inválido");
            Console.WriteLine("Encerrando Programa");
        }
        catch (OutOfMemoryException)
        {
            Console.WriteLine("Seu computador não memoria o suficiente");
            Console.WriteLine("Encerrando Programa");

        }
        catch (Exception)
        {
            Console.WriteLine("Ocorreu um erro");
            Console.WriteLine("Encerrando Programa");
        }

        try
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro número");
            NumberOne = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            NumberTwo = Int32.Parse(Console.ReadLine());
        }
        catch (IOException)
        {
            Console.WriteLine("Dado inserido invalido");
            Console.WriteLine("Encerrando Programa");
        }
        catch (FormatException)
        {
            Console.WriteLine("Dado inserido invalido");
            Console.WriteLine("Encerrando Programa");
        }
        catch (OutOfMemoryException)
        {
            Console.WriteLine("Seu computador não tem dado o suficiente");
            Console.WriteLine("Encerrando Programa");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Ocorreu um erro");
            Console.WriteLine("Encerrando Programa");
        }
        catch (Exception)
        {
            Console.WriteLine("Ocorreu um erro");
            Console.WriteLine("Encerrando Programa");
        }


        Calculator Calc = new Calculator();

        switch (operetor)
        {
            case 1:
                Console.Clear();
                Console.WriteLine($"Resultado {Calc.Sum(NumberOne, NumberTwo)}");
                break;

            case 2:
                Console.Clear();
                Console.WriteLine($"Resultado {Calc.Subtraction(NumberOne, NumberTwo)}");
                break;

            case 3:
                Console.Clear();
                Console.WriteLine($"Resultado {Calc.Multiplication(NumberOne, NumberTwo)}");
                break;

            case 4:
                Console.Clear();
                Console.WriteLine($"Resultado {Calc.Division(NumberOne, NumberTwo)}");
                break;
        }
    }
}