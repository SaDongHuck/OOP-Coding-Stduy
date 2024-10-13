namespace Encapsulation
{
    internal class Program
    {
        public class person
        {
            //데이터 필드
            private int age; //나이 필드 만듦

            public void setAge(int age)
            { this.age = age; } //this -> 외부에서 클랙스에 접근했을때 자기 객체(클래스가 가진 age)

            public int getAge()
            { return age; } //반환   

        }
        static void Main(string[] args)
        {
            //캡슐화
            //데이터 메서드를 묶음
            //class
            //데이터(필드) 외부에서 접근할 수 없게 만듦
            //메서드를 외부에 접근할 수 있게 만듦
            //알약
            //private 접근제한자를 필드에 적용
            person p = new person();
            p.setAge(10);
            Console.WriteLine(p.getAge());
        }
    }
}
