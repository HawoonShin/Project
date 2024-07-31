namespace List
{
    internal class Program
    {
        //인벤토리 선언
        class Inventory
        {

        }

        //아이템 선언
        class Item
        {

        }

        class Potion : Item
        {
        }
        class Weapon : Item { }
        class Armor : Item { }
        class Accessory : Item { }
        class Food : Item { }

        static void Main(string[] args)
        {
            //인벤토리 리스트 선언?작성?
            List<string> inventroy = new();

            //이벤토리의 상태표시
            Console.WriteLine($"현재 아이템이 {}개 들어있습니다");

            //숫자를 입력 받는다
            int.TryParse(Console.ReadLine(), out int input);
            if (input == 0)
            {
                //0을 입력받을 경우 랜덤 획득한다
                Console.WriteLine("아이템을 랜덤획득합니다.");
                //랜?덤 획득?
                inventroy.Add("랜?덤");
            }
            else if (input > 0 || input < 10)
            {
                //1~9를 누르면 아이템을 제거한다.
                Console.WriteLine("아이템을 제거합니다.");
                inventroy.Remove(input);
                //리무브는 인트로는 받을 수 없는건가요???
            }
            else
            {
                Console.WriteLine("잘못입력하셨습니다.");
            }
        }
    }
}
