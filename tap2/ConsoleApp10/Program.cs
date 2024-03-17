namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string arr =  "Orxan Musayev" ;
            Basherf(arr) ;
         
            
            
        }
        public static void  Basherf(string cumle)
        {
            int soz = ' ';
            for (int i = 0; i < cumle.Length; i++)
            { if (soz==' ')
                {
                    Console.WriteLine(cumle[i]);

                }
             soz= cumle[i]; 
            }
           
        }
        
    }
}
