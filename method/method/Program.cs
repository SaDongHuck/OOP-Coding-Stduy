namespace method
{
    internal class Program
    {
        public class person
        {
           public void pritnt()
            {
                Console.WriteLine("Hello");
                Console.WriteLine("World");
            } //반환값과 매개변수가 없는 메서드
            public void printHello(string str)
            {
                Console.WriteLine(str);
                Console.WriteLine("Hello");
                Console.WriteLine("World");
            } //매개변수가 있는 메세드

            public int ReTurn()
            {
                return 10;
            }//반환값이 있는 메서드
            public int sum(int a, int b)
            { return a + b; }
        }// 반환값과 매개변수 둘다 있는 메서드
        static void Main(string[] args)
        {
            //메서드
            //메서드는 코드들의 집합
            //메서드 이름, 매개변수, 반환값
            person p = new person();
            p.pritnt();
            p.printHello("안녕");
            int result;
            result = p.ReTurn();
            Console.WriteLine(result);
            int result1;
            result1 = p.sum(1, 2);
            Console.WriteLine(result1);
        }
    }
}
