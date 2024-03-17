namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int r = 5;
            Console.WriteLine(CevreArea(r));
            Console.WriteLine(DuzbucaqliArea(15, 20));
            Console.WriteLine(ParalepipedArea(10,10,15));
            Console.WriteLine(UcbucaqArea(4, 6, 8, 5));
        }
        public static int CevreArea(int radius ) {
         int s=radius*radius*3;
            return s;
        
        }
        public static int DuzbucaqliArea(int num1,int num2)
        {
            int s=num1*num2;
            return s;


        }
        public static int ParalepipedArea(int a,int b, int c) {
        
        int s =2*(a*b+a*c+b*c);   
            return s;
        
        }
        public static int UcbucaqArea(int a,int b,int c,int r) {
            int p = (a + b + c) / 2;
            int s = p * r;
            return s;
        
        
        
        }

    }
}
