namespace ConsoleApp1for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0, nomber=0, repit;
            do
            {
                repit = nomber;
                nomber = int.Parse(Console.ReadLine());
                count++;
            } while (repit != nomber || count == 1);
            string text = $"{Convert.ToString(count-1)} {Convert.ToString(count)}";
            Console.WriteLine(text);
        }
    }
}
