namespace ConsoleApp1for
{
    public class Logic
    {
        public static string Result(int countList, List<int> list)
        {
            var first = -1;
            var second = -1;
            for (int i = 1; i < countList; i++)
            {
                if (list[i - 1] == list[i] && first == -1)
                {
                    first = i - 1 +1;
                }
                if (list[i - 1] == list[i])
                {
                    second = i +1;
                }
            }
            if (first == -1){
                first = 0;
                second = 0;
            }
            string text = $"{Convert.ToString(first)} {Convert.ToString(second)}";
            return text;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int countList;
            List<int> list = new List<int>();
            countList = int.Parse(Console.ReadLine());
            for (int i = 0; i < countList; i++) { 
                list.Add(int.Parse(Console.ReadLine()));
            }
            
            string text = Logic.Result(countList, list);
            Console.WriteLine(text);
        }
    }
}
