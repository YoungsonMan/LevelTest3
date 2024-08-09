using System.Security.Cryptography.X509Certificates;

namespace LevelTest3
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] answer = new string[] { };
            string[] strings = { "sun", "bed", "car" };
            string[] strings2 = { "abce", "abcd", "cdx" };
            int n = 1;
            int n2 = 2;

            //    Array.Sort(strings);
            //    answer = strings.ToArray();

            Array.Sort(strings, (x, y) => x.Substring(n).CompareTo(y.Substring(n)));

            answer = strings.ToArray();

            foreach (string s in strings)
            {
                
                Console.Write(s);
                Console.Write(" ");
            }

            Console.WriteLine();

            Array.Sort(strings2, (x, y) => x.Substring(n2).CompareTo(y.Substring(n2)));
            foreach (string s in strings2)
            {
                Console.Write(s);
                Console.Write(" ");
            }




            //  Console.WriteLine($"{answer}");


            // a = \u0061
            // e = \u0065
            // i = \u0069
            // o = \u006F
            // u = \u0075

            //일단 string -> char
            //  char[] charArray;
            //  charArray = strings[0].ToCharArray();
            //  Console.WriteLine(charArray);

            // 모음 순서를 비교해서 a, e, i, o, u 순서로 순서가 정해지도록 하기
            // Sort라는게 있었다... + substring
            // Array.Sort()


            Console.WriteLine();
            Console.WriteLine(" \u0061 \u0065 \u0069 \u006F \u0075 ");


        }
    }

    // 8번문제
    /// <summary>
    /// 중앙값은 어떤 주어진 값들을 크기의 순서대로 정렬했을 때 가장 중앙에 위치하는 값을 의미합니다. 
    /// 예를 들어 1, 2, 7, 10, 11의 중앙값은 7입니다. 
    /// 정수 배열 array가 매개변수로 주어질 때, 
    /// 중앙값을 return 하도록 solution 함수를 완성해보세요.
    /// ### 입출력 예
    /// |     array      |   result  |
    /// |----------------|-----------|
    /// | [1,2,7,10,11]  |     7     |
    /// | [9, -1, 0]     |     0     |
    /// 
    /// 입출력 예 #1
    ///             본문과 동일합니다.
    /// 입출력 예 #2
    ///             9, -1, 0을 오름차순 정렬하면 -1, 0, 9이고 
    ///             가장 중앙에 위치하는 값은 0입니다.
    /// 
    /// 
    /// </summary>
    public class Solution
    {
        public int solution(int[] array)
        {
            int answer = 0;
            int[] numbers = { };
            Array.Sort(array);
            int mid = array.Length / 2;
            answer = array[mid];
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
 
            return answer;
        }
    }

    // 9 번문제
    /// <summary>
    /// 중앙값은 어떤 주어진 값들을 크기의 순서대로 정렬했을 때 가장 중앙에 위치하는 값을 의미합니다. 
    /// 예를 들어 1, 2, 7, 10, 11의 중앙값은 7입니다. 
    /// 정수 배열 array가 매개변수로 주어질 때, 
    /// 중앙값을 return 하도록 solution 함수를 완성해보세요.
    /// ### 입출력 예
    /// |          strings        |  n  |          return         |
    /// |-------------------------|-----|-------------------------|
    /// | ["sun", "bed", "car"]   |  1  | ["car", "bed", "sun"]   |
    /// | ["abce", "abcd", "cdx"] |  2  | ["abcd", "abce", "cdx"] |
    /// 
    /// 입출력 예 #1
    ///             "sun", "bed", "car"의 1번째 인덱스 값은 각각 "u", "e", "a" 입니다. 
    ///             이를 기준으로 strings를 정렬하면 ["car", "bed", "sun"] 입니다.
    /// 입출력 예 #2
    ///             "abce"와 "abcd", "cdx"의 2번째 인덱스 값은 "c", "c", "x"입니다. 
    ///             따라서 정렬 후에는 "cdx"가 가장 뒤에 위치합니다. 
    ///             "abce"와 "abcd"는 사전순으로 정렬하면 "abcd"가 우선하므로, 
    ///             답은 ["abcd", "abce", "cdx"] 입니다.
    /// 
    /// 
    /// </summary>
    public class Problem9
    {
        public string[] problem9(string[] strings, int n)
        {
            string[] answer = new string[] { };
            answer = strings;
            Array.Sort(strings, (x, y) => x.Substring(n).CompareTo(y.Substring(n)));



            return answer;
        }
    }


}
