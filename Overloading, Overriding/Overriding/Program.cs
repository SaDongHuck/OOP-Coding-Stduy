namespace Overriding
{
    internal class Program
    {
        public class Parent
        {
            public void print()
            {
                Console.WriteLine("부모 클래스 메서드 입니다");
            }
        }

        public class Child : Parent
        {
            public void print()
            {
                Console.WriteLine("자식 클래스 메서드 입니다");
            }

        }// 부모 클래스에서 상속 받아 재정의(오버라이딩)

        static void Main(string[] args)
        {
            //다향성
            //하나의 코드가 여러 가지 형태로 실행될 수 있도록 하는 것
            //오버로딩, 오버라이딩
            //오버로딩: 같은 이름의 메서드를 여러개 정의
            //오버라이딩: 부모 클래스에서 정의된 메서드를 자식 클래스에서 재정의
            Parent parent = new Parent();
            Child child = new Child();

            parent.print();
            child.print();
        }
    }
}
