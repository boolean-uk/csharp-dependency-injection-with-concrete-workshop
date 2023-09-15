namespace Calculator2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Adding adding = new Adding();
            Subtract subtracting = new Subtract();

            Console.WriteLine(calculator.Add(1, 6, adding));
            Console.WriteLine(calculator.Subtract(7, 6, subtracting));


            //Console.WriteLine(adding.Add(1, 4));
        }
    }
}