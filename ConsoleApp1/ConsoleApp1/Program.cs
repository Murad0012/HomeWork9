namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "CodeAcademy is a good place to study";
            var res2 = input.Split(' ');
            int count = 0;
            foreach (var item in res2)
            {
                count++;
            }
            Console.WriteLine("Total number of words in the string is : " + count);
        }
    }
}