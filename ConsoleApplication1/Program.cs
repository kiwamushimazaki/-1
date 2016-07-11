using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class program1
    {
        static void Main()
        {
            int player;
            int cpu;

            string temp1;

            Console.WriteLine("じゃんけんゲーム");
            Console.WriteLine("1.グー, 2.チョキ, 3.パー");
            Console.WriteLine("1～3のいずれかを選択してください>>> ");

            do
            {

                temp1 = Console.ReadLine();
                player = int.Parse(temp1);

                Random temp2 = new Random();
                cpu = temp2.Next(1, 4);

                while (player == cpu)
                {
                    Console.WriteLine("あいこです ( 'ω' )");
                    Console.WriteLine("もう一度、1.グー, 2.チョキ, 3.パーから選択してください>>> ");
                    temp1 = Console.ReadLine();
                    player = int.Parse(temp1);
                    Random temp3 = new Random();
                    cpu = temp3.Next(1, 4);
                }

                if (player == 1 && cpu == 2 || player == 2 && cpu == 3 || player == 3 && cpu == 1)
                {
                    Console.WriteLine("あなたの勝ちですヽ(〃v〃)ﾉ");
                    Console.WriteLine("もう一度やるときは、1.グー, 2.チョキ, 3.パーから選択してください>>> ");
                    Console.WriteLine("終了するときは、4を選択してください>>>");
                }
                else if (player == 1 && cpu == 3 || player == 2 && cpu == 1 || player == 3 && cpu == 2)
                {
                    Console.WriteLine("あなたの負けです (_　_|||)");
                    Console.WriteLine("もう一度やるときは、1.グー, 2.チョキ, 3.パーから選択してください>>> ");
                    Console.WriteLine("終了するときは、4を選択してください>>>");
                   
                }
            } while (player == 1 || player == 2 || player == 3);
        }
    }
}


