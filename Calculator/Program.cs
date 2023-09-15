namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Adding adding = new Adding();
            Subtract subtracting = new Subtract();
            Calculator calculator = new Calculator(adding);
            Console.WriteLine(calculator.Calculate(1, 2));
        }
    }
}