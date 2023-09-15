namespace Calculator2
{
    public class Calculator
    {
       public int Add(int a, int b, Adding adding)
       {
            return adding.Add(a, b);
       }
        public int Subtract(int a, int b, Subtract subtract)
        {
            return subtract.Subtracting(a, b);
        }

    }
}