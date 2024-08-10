namespace GameMapShortestWay
{/// <summary>
 /// ROR 게임은 두 팀으로 나누어서 진행하며, 상대 팀 진영을 먼저 파괴하면 이기는 게임입니다. 
 /// 따라서, 각 팀은 상대 팀 진영에 최대한 빨리 도착하는 것이 유리합니다.
 /// 지금부터 당신은 한 팀의 팀원이 되어 게임을 진행하려고 합니다.
 /// 다음은 5 x 5 크기의 맵에, 당신의 캐릭터가(행: 1, 열: 1) 위치에 있고, 
 /// 상대 팀 진영은(행: 5, 열: 5) 위치에 있는 경우의 예시입니다....
 /// 
 /// URL: https://school.programmers.co.kr/learn/courses/30/lessons/1844
 /// 
 /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            bool[,] graph = new bool[5, 5]
            {
                // 0         1       2        3       4
                {   true,  false,   true,   true,   true},
                {   true,  false,   true,  false,   true},
                {   true,  false,   true,   true,   true},
                {   true,   true,   true,  false,   true},
                {  false,  false,  false,  false,   true}
            };
            bool[] bfsVisited;
            int[] bfsParent;
            Util.BFS(graph, 0, out bfsVisited, out bfsParent);
            PrintGraphSearch(bfsVisited, bfsParent);   
        }
        private static void PrintGraphSearch(bool[] visited, int[] parents)
        {
            Console.WriteLine($"{"Vertex",5} {"Visit",5} {"Parent",5}");
            for (int i = 0; i < visited.Length; i++)
            {
                Console.WriteLine($"{i,5} {visited[i],5} {parents[i],5}");
            }
        }

        const int INF = 99999;
    }

    public class Util
    {
        public static int IndexOf(int[] array, int target)
        {
            int result = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    result = i;
                    break;
                }
            }
            return result;
        }
        public static void BFS(bool[,] graph, int start, out bool[] visited, out int[] parent)
        {
            int size = graph.GetLength(0);
            visited = new bool[size];
            parent = new int[size];

            for (int i = 0; i < size; i++)
            {
                visited[i] = false;
                parent[i] = -1;
            }

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(start);
            visited[start] = true;

            while (queue.Count > 0)
            {
                int vertex = queue.Dequeue();
                for (int i = 0; i < size; i++)
                {
                    if (graph[vertex, i] == true && visited[i] == false)
                    {
                        visited[i] = true;
                        parent[i] = vertex;
                        queue.Enqueue(i);
                    }
                }
            }

        }

    }
}

class Solution
{
    public int solution(int[,] maps)
    {
        int answer = 0;
        return answer;
    }
}

