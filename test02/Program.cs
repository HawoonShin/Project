namespace test02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //몬스터 5마리 넣을것이다.
            Monster[] monsters = new Monster[5];

            // 배열에 넣을 각각의 몬스터 
            monsters[0] = new Pikachu("피카츄");
            monsters[1] = new Charmander("파이리");
            monsters[2] = new Squiartle("꼬북이");
            monsters[3] = new Bulbasaur("이상해씨");    //빈괄호는 기본이름
            monsters[4] = new Pikachu("털뭉치"); // 괄호안에는 이름 지정

            foreach (Monster monster in monsters)
            {
                Console.WriteLine($"{monster.name} 공격해!");
                monster.Attack();
                Console.WriteLine();
            }

        }
    }

    // 부모클래스인 몬스터 클래스 생성
    public class Monster
    {
        // private int id;
        public string name;

        //생성자?
        public Monster(string name)
        {
            this.name = name;
        }

        // 추상크래스로 정의하고 밑에서 구현할 것

        public void Attack() 
        {
        }
        
        

    }

  

    // 자식몬스터들 생성
    // 각각 기본이름 필요하고 기술을 쓰는 함수를 생성?

    // 피카츄
    public class Pikachu : Monster
    {
        // 피카츄 기본이름
        public Pikachu(string name) : base(name) 
        {
            //여기서 기본으로 초기화 할수 없는건가....
        }
        //백반볼트 기술
        public void Attack()
        {
            Console.WriteLine("백만볼트");
        }
       
    }

    //파이리
    public class Charmander : Monster
    {
        //파이리 기본이름
        public Charmander(string name) : base(name)
        {

        }
        //화염방사
        public void Attack()
        {
            Console.WriteLine("화염방사!");
        }
    }

    //꼬북이
    public class Squiartle : Monster
    {
        //꼬북이 기본이름
        public Squiartle(string name) : base(name)
        {

        }
        // 물총발사
        public void Attack()
        {
            Console.WriteLine("물총발사!");
        }
    }

    //이상해씨
    public class Bulbasaur : Monster
    {
        // 이상해씨 기본이름
        public Bulbasaur(string name) : base(name)
        {

        }
        // 덩굴채찍
        public void Attack()
        {
            Console.WriteLine("덩굴채찍");
        }
    }



}
