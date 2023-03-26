using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class First_first
    {
        enum Estate
        {
            idle = 1,
            attack = 2,
            killing = 5
        }


        public static void First()
        {
            //1차시-1번째-2강
            sbyte sb = -128;
            byte b = 255;
            short sh = -32767;
            ushort us = 65535;
            int i = -12345678;
            uint ui = 2222222222;
            long l = 11111111111111111;
            ulong ul = 11111111111111111;
            char c = 'F';

            float f = 3.141592f;
            double d = 1.13532;
            decimal de = 13.352343m;

            string STR = "힘스탯";

            bool oneShot = true;

            object valueInt = 31;
            object valueFloat = 0.158f;
            object valueString = "겔겔";
            object valueBool = false;

            Console.WriteLine("Hello, World!");
            Console.WriteLine(sb);
            Console.WriteLine(b);
            Console.WriteLine(sh);
            Console.WriteLine(us);
            Console.WriteLine(i);
            Console.WriteLine(ui);
            Console.WriteLine(l);
            Console.WriteLine(ul);
            Console.WriteLine(c);
            Console.WriteLine(f);
            Console.WriteLine(d);
            Console.WriteLine(de);
            Console.WriteLine(STR);
            Console.WriteLine(oneShot);
            Console.WriteLine(valueInt);
            Console.WriteLine(valueBool);
            Console.WriteLine(valueFloat);
            Console.WriteLine(valueString);

            //1차시-1번째-3강

            sh = (short)us; //부호 = 큰 무부호
            Console.WriteLine(sh);
            ui = (uint)i; //무부호 = 부호
            Console.WriteLine(ui);
            us = (ushort)l; //작 = 큰
            Console.WriteLine(us);
            i = (int)f; //정 = 실
            Console.WriteLine(i);
            STR = us.ToString();
            Console.WriteLine(STR);

            //1차시-1번째-4강

            const int jungSangSu = 100810;
            int? Nullable = null;
            //Console.WriteLine(Nullable.Value);
            var mac = 9;
            Console.WriteLine(mac);
            var vmac = "s";
            Console.WriteLine(vmac);

            //1차시-1번째-5강

            Console.WriteLine(string.Format("기본 : {0}{1}{2}", "a", "ff", "af"));
            Console.WriteLine(string.Format("맞춤 : {0,-5}{1,5}", "fd", "fd"));
            Console.WriteLine(string.Format("진수 : {0:D}{1:D5}", 123, 123));
            Console.WriteLine(string.Format("콤마: {0:N}", 1231223));
            Console.WriteLine(string.Format("소수 : {0:F}", 1.23));

            //보간식
            Console.WriteLine($"{i,-10:D5}");
            //탐색
            STR = "열라 졸려";
            Console.WriteLine(STR);
            Console.WriteLine(STR.IndexOf('열'));
            Console.WriteLine(STR.LastIndexOf('졸'));
            Console.WriteLine(STR.StartsWith('열'));
            Console.WriteLine(STR.EndsWith('열'));
            Console.WriteLine(STR.Contains('열'));
            STR = "im jo1a sleeping";
            Console.WriteLine(STR);
            string st = STR.ToLower();
            Console.WriteLine($"열{st}");
            st = STR.ToUpper();
            Console.WriteLine($"열{st}");
            st = STR.Insert(0, "siii");
            Console.WriteLine($"열{st}");
            st = STR.Remove(0, 4);
            Console.WriteLine(($"열{st}"));
            string[] tyy = st.Split();
            Console.WriteLine($"열{tyy[1]}");
            string saf = st.Substring(4);
            Console.WriteLine($"열{saf}");


            int aa = 40;
            int bb = 12;
            Console.WriteLine($"합{aa + bb}");
            Console.WriteLine($"차{aa - bb}");
            Console.WriteLine($"곱{aa * bb}");
            Console.WriteLine($"나눗셈{aa / bb}");
            Console.WriteLine($"나머지{aa % bb}");

            Console.WriteLine($"5추가{aa += 5}");
            Console.WriteLine($"1추가{aa++}");

            Console.WriteLine($"큰가{aa > bb}");
            Console.WriteLine($"작은가{aa < bb}");
            Console.WriteLine($"같은가{aa == bb}");
            Console.WriteLine($"다른가{aa != bb}");

            Console.WriteLine($"큰고 다른가{aa > bb && aa != bb}");
            Console.WriteLine($"크거나 같은가{aa > bb || aa == bb}");
            int cc = aa > bb ? 0 : 10;
            Console.WriteLine($"{cc}");
            aa -= 40;
            cc = aa > bb ? 0 : 10;
            Console.WriteLine(cc);

            int dd = 255;
            Console.WriteLine(Convert.ToString(dd, 2));
            Console.WriteLine(Convert.ToString(dd >> 2, 2));
            Console.WriteLine(Convert.ToString(dd << 3, 2));

            Console.WriteLine(10 & 6);
            Console.WriteLine(10 | 6);
            Console.WriteLine(10 ^ 6);
            Console.WriteLine(~6);


            char word = 'c';

            if (word == 'd')
            {

                word = 'b';
                Console.WriteLine(122);
            }
            else if (word == 'b')
                Console.WriteLine(word);
            else
            {

                Console.WriteLine(3456);
            }
            switch (word)
            {
                case 'a':
                    Console.WriteLine("aaa");
                    break;
                case 'b':
                    Console.WriteLine("bbb");
                    break;
                case 'c':
                    Console.WriteLine("ccc");
                    break;
            }


            for (int ii = 0; ii < 5; ii++)
            {


                if (ii == 3)
                {
                    continue;
                }
                Console.WriteLine(ii + "번째");
            }

            int iii = 0;
            while (iii < 10)
            {
                Console.WriteLine(iii + "번째");
                iii++;

            }


            Console.WriteLine("번째");
            do
            {
                if (iii > 16)
                    break;
                Console.WriteLine(iii + "번째");
                iii++;
            } while (iii < 20);

            int[] array = { 1, 2, 3, 4 };
            Console.WriteLine(array[3]);
            array[3] = 5;
            Console.WriteLine(array[3]);

            Console.WriteLine(array.Length);

            int[,] esg = new int[3, 4];
            esg[0, 1] = 3;
            esg[0, 3] = 5;

            int[][] hp= new int[2][];
            hp[0] = new int[] {4, 5};
            hp[1] = new int[5];

            int mu = 10;
            float mi = mu / 4.0f;

        }
        }
}
