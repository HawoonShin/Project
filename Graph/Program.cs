namespace Graph
{
    internal class Program
    {
        // 심화 학습 : 인접행렬 그래프
        static bool[,] graph1 =
        {
            {false,false,true,false,true,false,false,false },   //0
            {false,false,true,true,false,false,true,false },    //1
            {false,true,false,false,false,false,true,false },   //2
            {false,false,false,false,false,true,false,true }, //3
            {false,false,false,false,false,false,false,true }, //4
            {false,true,false,true,false,false,false ,false}, //5
            {false,false,true,false,false,false,false,true }, //6
            {false,false,false,false,false,false,true,false }, //7
        };

        static void Main(string[] args)
        {
            List<int>[] graph = new List<int>[8];
            for (int i = 0; i < graph.Length; i++)
            {
                graph[i] = new List<int>();
            }

            graph[0].Add(2);
            graph[0].Add(4);
            graph[1].Add(2);
            graph[1].Add(3);
            graph[1].Add(6);
            graph[2].Add(1);
            graph[2].Add(6);
            graph[3].Add(5);
            graph[3].Add(7);
            graph[4].Add(7);
            graph[5].Add(1);
            graph[5].Add(3);
            graph[6].Add(2);
            graph[6].Add(7);
            graph[7].Add(6);

            // 과제1
            for (int i = 0; i < graph.Length; i++)
            {
                Console.WriteLine($"{i}노드 :");

                for (int j = 0; j < graph.Length; j++)
                {
                    if (graph[i].Contains(j) == true)
                    {
                        Console.WriteLine($"    {j}노드");

                    }
                    else
                    {

                    }

                }
            }

            // 심화과제
            for(int k = 0; k < 8;k++)
            {
                Console.WriteLine($"{k}노드 :");
                for (int l = 0; l < 8;l++)
                {
                    if (graph1[k,l] ==true)
                    {
                        Console.WriteLine($"    {l}노드");
                    }
                }
            }
            
        }
    }
}
