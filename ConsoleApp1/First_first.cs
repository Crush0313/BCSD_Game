using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class First_first
    {
        enum Estate { 
            idle = 1, 
            attack = 2, 
            killing =5 }

        public static void First() {

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


        }
    }
}
