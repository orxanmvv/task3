namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "orxan musayev" ,"musayev orxan" };
            Console.Write(Bosluq(arr)); 
        }
        public static string Bosluq(string[] cumle)
        {
            string result = ""; 
            for (int i = 0; i < cumle.Length; i++)
            {
                for (int j = 0; j < cumle[i].Length; j++)
                {
                    if (cumle[i][j] !=' ') {
                        result += cumle[i][j];
                    }
                    
                }
            }
            return result; 
        }
    }
}

