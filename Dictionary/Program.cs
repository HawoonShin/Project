using System; 
// 딕셔너리 및 콘솔 기능이 상용되지 않기에 유징구문을 추가하였으나 변화가 없었습니다.
// 더 추가해야하는 유징문이 있나요?

namespace Dictionary_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 프로그램 시작 시 MonsterData는 몬스터 이름 기준의 string Key 값으로 딕셔너리에 저장한다.
            Dictionary <string, MonsterData> monsterDic = new Dictionary<string, MonsterData>();
            // 이 부분의 딕셔너리가 왜 제대로 작동하지 않는지 모르겠습니다.

            // 최소 5종류 이상 저장한다.
            monsterDic.Add("게이저", new MonsterData("게이저", 90));
            monsterDic.Add("웨어울프", new MonsterData("웨어울프", 30));
            monsterDic.Add("바이콘", new MonsterData("바이콘", 80));
            monsterDic.Add("고스트", new MonsterData("고스트", 40));
            monsterDic.Add("스켈레톤", new MonsterData("스켈리톤", 20));

            // Monster 클래스의 인스턴스 생성 시
            // 생성자를 사용해 딕셔너리에 저장된 MonsterData 클래스의 정보를 불러와
            // 인스턴스의 데이터를 초기화해야 한다.

            // 문제가 잘 이해가 가지 않습니다

            if (monsterDic.ContainsKey("게이저"))    
            {
                MonsterData find = monsterDic["게이저"];  
                Console.WriteLine($"{find.name},{find.hp}");
               // 이 부분 출력이 되지 않는데, 이것도 유징문의 문제인가요?
            }
        }
    }

    //다음의 조건을 충족하는 프로그램을 구현하시오
    // 구현 클래스

    // Monster
    public class Monster
    // 클래스 구현이 아직 잘 모르겠습니다.
    // 밑의 몬스터데이터의 경우 교수님이 하셨던 부분을 보고 따라했지만
    // 몬스터는 무엇을 추가해야 할지 잘 모르겠습니다.

    // MonsterData
    public class MonsterData
    {
        public string name;
        public int hp;

        public MonsterData(string name, int hp)
        {
            this.name = name;
          
            this.hp = hp;
        }
    }

}
