public class Calculator
{
    public int Sum(int ValueOne, int ValueTwo) => ValueOne + ValueTwo;

    public int Subtraction(int ValueOne, int ValueTwo) => ValueOne - ValueTwo;

    public int Multiplication(int ValueOne, int ValueTwo) =>  ValueOne * ValueTwo;

    public int Division(int ValueOne, int ValueTwo) =>  ValueOne / ValueTwo;
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o primeiro número");
        int NumerOne = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número");
        int NumerTwo = Int32.Parse(Console.ReadLine());

        Calculator Calc = new Calculator();

        Console.Clear();

        Console.WriteLine($"A soma dos valores é {Calc.Sum(NumerOne, NumerTwo)}");
        Console.WriteLine($"A Subtração dos valores é {Calc.Subtraction(NumerOne, NumerTwo)}");
        Console.WriteLine($"O produto dos valores é {Calc.Multiplication(NumerOne, NumerTwo)}");
        Console.WriteLine($"A divisão dos valores é {Calc.Division(NumerOne, NumerTwo)}");
    }
}