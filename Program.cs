namespace IMAT_GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"la multiplicacion de mi primer y ultimo digito es ID : {Multiply(2, 9)}");
        }

        static int Add(int x, int y)
        {
        
            return x + y;
        }

        static int Multiply(int x, int y)
        {   
            return x * y;   
        }
    }
}