using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class enermy
    {
        public virtual void takedamage(int dmg)
        {
            Console.WriteLine($"적 : {dmg} 만큼 체력 감소");
        }
        public void attack()
        {
            Console.WriteLine("크와앙");
        }

    }
    public class goblin : enermy
    {
        public override void takedamage(int dmg)
        {
            Console.WriteLine($"고블린 : {dmg} 만큼 체력 감소");
        }
    }
    public class dragon : enermy
    {
        public override void takedamage(int dmg)
        {
            Console.WriteLine($"드래곤 : {dmg} 만큼 체력 감소");
        }
    }
    public class play
    {
        int dmg = 30;
        public void Hit(enermy enermy)
        {
            enermy.takedamage(dmg);
        }
        private enermy enermy1 = new goblin();
        static private enermy enermy2 = new goblin();
        private goblin goblin1 = (goblin)enermy2;
        static private enermy enermy3 = new enermy();
        private goblin goblin2 = (goblin)enermy3;
    }

    
}
