namespace inheritance
{
    public class parent
    {
        private int num;

        public void printNum()
        {
            Console.WriteLine("num : " + num);
        }

        public void SetNum(int num)
        {
            this.num = num;
        }
        public int getNum()
        { return num; }
    }

    public class child : parent
    {
        public void print()
        {
            Console.WriteLine("자식클래스 메서드 입니다");
        }

    }//상속 -> 코드를 재사용 할 수 있고 유지보수 하기가 쉬워진다
    internal class Program
    {
        static void Main(string[] args)
        {
            //상속
            //기존 클래스를 재사용해서 새로운 클래스를 만들 수 있는 기능
            //상속하는 클래스를 부모 클래스, 상속받는 클래스를 자식 클래스
            child c = new child();
            c.SetNum(3);
            Console.WriteLine(c.getNum());
            c.print();
        }
    }
}
