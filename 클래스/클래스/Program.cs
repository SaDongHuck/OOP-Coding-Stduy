namespace 클래스
{
    internal class Program
    {
        public class person
        {
            //데이터들 필드
            public int height;
            public int weight;

            //메서드 (함수)
            
            public void printHeight()
            {
                Console.WriteLine("키 : " +  height);
            }

            public void printWeight()
            {
                Console.WriteLine("몸무게 : " + weight);
            }
        }//클래스는 설계도 이다
        static void Main(string[] args)
        {
            //클래스
            //클래스 -> 데이터 와 메서드를 하나로 묶음

            //사람 = 키, 몸무게, 머리카락색깔, 발 사이즈
            //메서드 = 키를 저장, 키를 변경, 머리카락색깔 변경

            //클래스 = 붕어빵 틀
            //객체 = 붕어빵

            person p = new person();

            p.height = 180;
            p.weight = 70;
            p.printHeight();
            p.printWeight();
            
        }
    }
}
