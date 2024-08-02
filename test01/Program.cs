namespace test01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //인트를 정수형으로 받을 경우
            int iLeft = 10;
            int iRight = 20;
            Util.Swap(ref iLeft,ref iRight);
            Console.WriteLine("int 자료형을 사용한 Swap 함수");
            Console.WriteLine($"{iLeft} , {iRight}");

            //그냥 띄어쓰기
            Console.WriteLine();

            //double 형으로 받을 정우
            double dLeft = 3.5;
            double dRight = 8.8;
            Util.Swap(ref  dLeft,ref dRight);
            Console.WriteLine("double 자료형을 사용한 Swap 함수");
            Console.WriteLine($"{dLeft} , {dRight}");
        }
    }

    // 어떤 자료형이던 받을 수 있는 제네릭 T
    // 기능 클래스
    // 스왑 함수
    public static class Util
    {
        public static void Swap<T>(ref T left, ref T right)
        {
            T temp = left;
            left = right;
            right = temp;
        }
    }


}
