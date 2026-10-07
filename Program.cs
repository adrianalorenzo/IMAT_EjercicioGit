namespace IMAT_GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"la resta de mi primer y ultimo digito es ID : {Subtract(2, 9)}");
        }

        static int Add(int x, int y)
        {
        
            return x + y;
        }

        static int Multiply(int x, int y)
        {   
            return x * y;   
        }

        static int Subtract(int x, int y)
        {
            return x - y;
        }
    }
}