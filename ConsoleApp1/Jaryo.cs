using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ConsoleApp1
{
    public class Jaryo
    {
    }
    public class arrayl
    {
        public arrayl()
        {
            //컬렉션은 new 로 할당해야 사용 가능
            ArrayList arrayList = new ArrayList();

            //object 타입이라 여러 종류 데이터 저장 가능
            Console.WriteLine(arrayList.Add(10)); //추가
            Console.WriteLine(arrayList.Add(10.3f));
            Console.WriteLine(arrayList[0]);
            Console.WriteLine(arrayList[1]);
            Console.WriteLine(arrayList.Add(4.3f));
            arrayList.Insert(2, "ㅎㅎㅎ"); //끼워넣기
            Console.WriteLine(arrayList[0]);
            Console.WriteLine(arrayList[1]);
            Console.WriteLine(arrayList[2]);
            Console.WriteLine(arrayList[3]);
            //대량 요소추가
            Collection<int> data = new Collection<int>();
            data.Add(300);
            data.Add(400);
            data.Add(500);
            arrayList.AddRange(data);
            p_array(arrayList);
//            arrayList.Sort(); //정렬 (정수 데이터만 있을 때)
            p_array(arrayList);
            arrayList.Remove(400);//인덱스가 아닌 데이터로 삭제 
            arrayList.RemoveAt(1);//인덱스로 삭제 
            p_array(arrayList);
            arrayList.RemoveRange(0, 2); //[0]~[0+2]번 삭제
            p_array(arrayList);
            arrayList.Clear();
            Console.WriteLine(arrayList.Count);

        }
        public void p_array(ArrayList arrayList)
        {
            Console.WriteLine("-------------------------------");
            int ii = arrayList.Count;
            for(int i = 0;i < ii; i++){
                Console.WriteLine(arrayList[i]);
            }
        }

    }
    public class ququ
    {
        public ququ()
        {
            Queue queue = new Queue(); //선언, 메모리 할당
            for (int i = 0; i < 5; i++)
            {
                queue.Enqueue(i); //삽입
            }
            Console.WriteLine($"count : {queue.Count}"); //개수 출력
            Console.WriteLine($"[0] : {queue.Peek()}"); //0번 데이터 출력

            object data = queue.Dequeue(); //디큐
            Console.WriteLine($"DQ : {data}"); // 디큐 출력
            Console.WriteLine($"count : {queue.Count}"); //개수 출력

            queue.Clear(); //전체 삭제
            Console.WriteLine($"count : {queue.Count}"); //개수 출력


        }
    }
    public class stst {
    public stst()
        {
            Stack stack = new Stack();
            for (int i = 0; i < 5; i++)
            {
                stack.Push(i);
                Console.WriteLine('i');
            }
            Console.WriteLine($"count : {stack.Count}"); //개수 출력
            Console.WriteLine($"[0] : {stack.Peek()}"); //최근 데이터 출력

            object data = stack.Pop(); //제거
            Console.WriteLine($"DQ : {data}"); // 제거 출력
            Console.WriteLine($"count : {stack.Count}"); //개수 출력

            stack.Clear();
            Console.WriteLine($"count : {stack.Count}"); //개수 출력

        }
    }
    public class hash
    {
        public hash()
        {
            Hashtable hash = new Hashtable();
            hash["싸움수준"] = "ㄹㅇ 실화냐";
            hash.Add("가슴이", "웅장해진다");
            foreach (object key in hash.Keys)
            {
                Console.WriteLine($"{key} = {hash[key]}");
            }
            Console.WriteLine(hash.ContainsKey("가슴이"));
            Console.WriteLine(hash.ContainsValue("가슴"));
            hash.Remove("싸움수준");
            Console.WriteLine(hash.Count);
            hash.Clear();
            Console.WriteLine(hash.Count);

        }
    }

}
