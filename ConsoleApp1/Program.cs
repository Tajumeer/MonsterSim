using System.Text;

namespace MonsterSim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            GameManager gameM = new GameManager();
            gameM.GameInit();
        }
    }

}