namespace Overloading__Overriding
{
    internal class Overloading
    {
        public class Test
        {
            public void print()
            {
                Console.WriteLine("hello");
            }

            public void print(int num)
            {
                Console.WriteLine(num);
            }//같은 이름 함수(메개변수 다르게)
             //오버로딩
            public void print(string str)
            {
                Console.WriteLine(str);
            }
            public void print(string str, int num)
            {
                for(int i = 0; i < num; i++)
                {
                    Console.WriteLine(str);
                }
            }
        }
        static void Main(string[] args)
        {
            //다향성
            //하나의 코드가 여러 가지 형태로 실행될 수 있도록 하는 것
            //오버로딩, 오버라이딩
            //오버로딩: 같은 이름의 메서드를 여러개 정의
            //오버라이딩: 부모 클래스에서 정의된 메서드를 자식 클래스에서 재정의
            Test test = new Test();
            test.print();
            test.print(10);
            test.print("HI");
            test.print("c#은 어렵지 않다!!", 3);
        }
    }
}
