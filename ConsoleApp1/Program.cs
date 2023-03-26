

namespace ConsoleApp1
{
    internal class Program
    {
        static private enermy[] enermyss = new enermy[3];

        static public void Main()
        {
            /*            First_first.First();
                        seccond.start();*/
            play play = new play();
            enermy goblin = new goblin();
            enermy dragon = new dragon();
            play.Hit(dragon);
            play.Hit(goblin);

            enermyss[0] = new goblin();
            enermyss[1] = new dragon();
            enermyss[2] = new goblin();

            for (int i = 0; i < enermyss.Length; i++)
            {
                enermyss[i].attack();
            }
        }

    }
}
