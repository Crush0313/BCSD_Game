
using System.Net.Cache;
using System.Numerics;

namespace ConsoleApp1
{
    public abstract partial class juice
    {
        public abstract void taste();
    }
    public class wine : juice
    {
            public override void taste()
        {
            Console.WriteLine("쓰다");
        }
    }
    interface IMovingentity {
        void moveto(Vector3 dest);
    }
    public class slime : IMovingentity
    {
        public void moveto(Vector3 destination) {
            Console.WriteLine($"{destination}까지 이동");
        }
    }
    public class game {
        private IMovingentity slime;
        private void Awake()
        {
            slime = new slime();

            slime.moveto(new Vector3(1, 2, 3));
        }
    }
    public class parent 
    { 
        public void meth()
            {
                Console.WriteLine("fff");
            }
    }
    public class child : parent
    {
        public new void meth()
        {
            Console.WriteLine("sss");
        }
    }
    public class ctr
    {
        public ctr()
        {

        parent p = new parent();
        p.meth(); //fff
        child c = new child();
        c.meth(); //sss
        parent pc = new child();
        pc.meth(); //fff
        }
    }
    public class outer
    {
        public class inner
        {
            //
        }
    }

    public struct stat
    {
        public int str;
        public string name;
    }
    public class ggc
    {
        public ggc()
        {
            var a = ("fff", 41);
            a.Item1 = "sss"; //이름.item숫자 로 접근
            var b = (name: "융융웅", Age:342536, male : true); //튜플 내부 변수 이름 설정 가능
            var (Nick, yonse, _) = b; //튜플을 분해해서 저장 가능, 이 때 _로 특정 변수 무시 가능

            stat stat1 = new stat();
            stat stat2;

            stat2.name = "고창석";
            stat2.str = 9999;
        wind.staticrun(); 
        }
    }
    public static class wind
    {
        //public int instancerun() { return 1; }//인스턴스 메소드
        public static int staticrun() { return 1; }


    }
}
namespace MySpace
{
    public static class strex
    {
        public static void pr(this string str)//this 확장할 클래스/형식, 매개변수
        {
            Console.WriteLine(str);
        }
    }
    public class crist
    {   
        public crist()
        {

            string fff = "폐급";
            fff.pr();
        }
    }
}
namespace YourSpace
{
    using MySpace;
    public class crist
    {
    }
}
namespace OurSpace
{
    using MySpace;


    class per
    {
        int age = 0;
    }
    class pson
    {   public pson()
        {

            per p1 = new per();
            per p2 = new per();

        }
    }












    public class crist3
    {
        private void Awake()
        {
            crist chh; //using을 써서 별다른 동작 없이 호출
            YourSpace.crist chhh;//네임스페이스까지 불러서 호출
        }
    }
}
