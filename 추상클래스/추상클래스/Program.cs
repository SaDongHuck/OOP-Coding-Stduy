namespace 추상클래스
{
    internal class Program
    {
        public abstract class parent //추상 클래스 
        {
            private string name = "TOM";

            public string GetName()
            { return name; }
            public void print()
            {
                Console.WriteLine("부모 클래스");
            } //일반 메서드

            public abstract void printName(); //추상메서드 -> 구현이 필요없음 자식클래스 에선 꼭 재정의
        }

        public class child : parent
        {
            public void print()
            {
                Console.WriteLine("자식 클래스");
            }

            public override void printName()
            {
                Console.WriteLine(GetName()); 
            }
        }

        static void Main(string[] args)
        {
            //추상 클래스
            //상속 전용 클래스(객체 생성이 안됨)

            child c = new child();
            c.printName();
           
            
        }
    }
}
