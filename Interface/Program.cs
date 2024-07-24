namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory<Potion> potionInventory = new(10);    //클래스명<타입명> 뒤에는 인스턴스 생성

            potionInventory.Add(new Potion("체력 포션"));   //아이템 추가
            potionInventory.Add(new Potion("마나 포션"));
            potionInventory.Add(new Potion("경험치 포션"));
            potionInventory.Add(new Potion("활력 포션"));

            potionInventory.Remove();   //아이템 제거
            potionInventory.Remove();
            //여기 두개 없앴는데 왜 저는 3개가 출력 되나요..?
            //분명 똑같이 따라 한거 같은데...?

            potionInventory.PrintItemNames();   //리스트 호출
        }
    }

    public abstract class Item  //추상 클래스 선언
    {
        public string Name { get; private set; }    // 생성자? 

        public Item(string name)    //이름 필드 초기화
        {
            this.Name = name;
        }
    }

    public class Potion : Item  //아이템부모 자식포션?
    {
        public Potion(string name) : base(name) { } //생성자로 이름 초기화
    }

    //T에는 'Item'을 상속받은 클래스만 넣을 수 있다.
    public class Inventory<T> where T : Item    //T의 제약상황을 걸어준다.
    {
        private T[] _list;  //아이템 담을 배열 선언
        private int _index; //현재 데이터를 저장할 변수?

        public Inventory(int size) //인벤토리 사이즈
        {
            _list = new T[size];    //배열 인스턴스 생성
        }

        public void Add(T item) //아이템 추가
        {
            if (_index < _list.Length)  //인덱스가 배열 내일 경우
            {
                _list[_index++] = item; //아이템을 추가
                _index++;   //아이템 추가후 위치를 늘리는 과정?
            }
        }
        public void Remove()    //아이템 삭제
        {
            _index--;   //삭제후 위치를 줄이는 과정?
            _list[_index] = null;   //
        }
        public void PrintItemNames()    //아이템 목록을 출력하는 기능
        { 
            Console.WriteLine("아이템 목록 :");  //출력 문구

            foreach (T item in _list)
            {
                if (item != null) //아이템이름이 null이 아니면 실행
                {
                    Console.WriteLine(item.Name);   //아이템 이름 출력
                }
            }
        }
    }
}
