namespace test03
{
    internal class Program
    {
        static void Main(string[] args)
        {




        }
    }

    //
    public List<int> Solution(List<int> array)
    {
        List<int> answer = new List<int>();

        //배열을 추가한다
        array = [1, 1, 3, 3, 0, 0, 1, 1];

        // 배열의 크기만큼 쌇을거 반복
            //스택으로 하나씩 쌓아간다
        for (int i = 0; i < array.Count; i++)
        {
            // 앞에 추가한 것과 비교하고 
            if (array[i] == array[i-1] )
            {
                // 다르다면 제거 없이 추가하고 넘어가고
                array.Remove(array[i]);
            }
            else
            {
                // 같다면 추가하지 않고 다음 변수로 넘어가고
                array.Add(array[i]);
            }
        }





        return answer;
    }

}
