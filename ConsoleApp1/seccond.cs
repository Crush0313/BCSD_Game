using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    public class seccond
    {
        public static void start()
        {
            int cc = 3;
            int dd = 5;
            Console.WriteLine(Add(cc, dd));
            seccond.muliiple(5, 6);
            Console.WriteLine($"{cc } { dd}");
            qqq();

            //일반적 용법
            Player("ggg", 100);
            //명명적 용법
            Player(ID: "ggg", hp: 100);
            Player(hp: 100, ID: "ggg");
            Startt();
        }

        static public void qqq()
        {
            ADD(3,5);
            ADD(3.3f, 5.8f);
            Console.WriteLine(Sum(3, 7));
            yyy(1, 2, 4);
        }

        static public void ADD(int a, int b)
        {
           Console.WriteLine(a + b);
        }
        static public void ADD(float a, float b)
        {
            Console.WriteLine(a + b);
        }
        static int Sum(int a, int b)
        {
            return a + b;
        }

        public static int Add(int a, int b)
        {
            a++;
            return a+b;
            
        }

        public static void yyy(params int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            Console.WriteLine(sum);
        }

        static public void Player(string ID, int hp)
        {
            Console.WriteLine(ID," ", hp);
        }
       

        public static void muliiple(int a, int b)
        {
            Console.WriteLine($"{a} x {b} = {a* b}");
        }
        static void Startt()
        {

        }


        Playerr Playerr;
        public void name(Playerr target)
        {
            Playerr = new Playerr();
            Console.WriteLine(target.ID);
        }
    }

    public class Playerr
    {
        public string ID = "CR";
        int hp=0;
        int mp;

        public Playerr()
        {
            hp = 30;
        }

        public Playerr(int mp) : this()
        {

            this.mp = mp;
        }

        public int GetHP()
        {
            return hp;
        }

        ~Playerr()
        {
            //삭제됨
        }

    }
    public class Mom
    {
        public string ID;
        protected int cHP;
        private void init()
        {
            ID = "nig";
        }
        public void heal(int hp)
        {
            cHP += 10;
        }
    }
    public class Son : Mom
    {
        public void attack()
        {

        }
        public Son(string id, int hp)
        {
            ID = id;
            cHP = hp;
            heal(20);
            //Init();
        }
    }

    public class human 
    {
        private int cuHP=0;
        public int CUHP
        {
            get => cuHP;
            set
            {
                cuHP = value;
            }
        }
    }

    public class Control 
    { 
        private Abs nAbs;
        public void Awake()
        {
            nAbs = new Abs();
            human human = new human();
            Console.WriteLine(human.CUHP);
            human.CUHP = 100;
            Console.WriteLine(human.CUHP);
            nAbs.aaa = 33;
            nAbs.bbb = 44;
            nAbs.ccc = 66;

        }
    }

    public interface inter
    {
        int inte
        {
            get; set;
        }
    }
    public class interf : inter
    {
        public int inte
        {
            get;set;
        }
    }
    public abstract class Abst
    {
        abstract public int aaa
        {
            get; set; //구현부가 없는 선언
        }
        public int bbb
        {
            get; set;
        }
    }
    public class Abs : Abst //aaa bbb ccc 다 사용 가능
    {
        public override int aaa
        {
            get; set;
        }
        public int ccc
        {
            get; set; 
        }
    }

}
