namespace TestConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 360; i+=10)
            {
                var x = (byte)(Math.Sin(i*(Math.PI/180)) * 120);
                Console.WriteLine(x);
            }
        }
    }
}
