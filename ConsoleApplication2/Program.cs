using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary;
namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            FightEmulation(5); 
        }

        /*
         * Зачем тебе отдельная бибилитека,если эмуляцию игры ты производишь здесь!?
         */


        /// <summary>
        /// Метод который позволяет произвести эмуляцию боя
        /// </summary>
        /// <param name="groupSize"></param>
        public static void FightEmulation(int groupSize)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("***GREATE TANK BUTTLE***");

            int[] resultArr = { 0, 0 };

            Tank[] firstTeam = new Tank[groupSize];
            Tank[] secondTeam = new Tank[groupSize];

            for (int i = 0; i < groupSize; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("BUTTLE {0}:", i+1);
                firstTeam[i] = new Tank(tankName.Pantera);
                firstTeam[i].printInfo();
                secondTeam[i] = new Tank(tankName.T_34);
                secondTeam[i].printInfo();
                switch (firstTeam[i]^ secondTeam[i])
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("WIN TANK: {0}", firstTeam[i].Name);
                        Console.ResetColor();
                        resultArr[0]++;
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("WIN TANK: {0}", secondTeam[i].Name);
                        Console.ResetColor();
                        resultArr[1]++;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("IT'S A DRAW");
                        Console.ResetColor();
                        break;
                }
                Console.WriteLine();
            }

            if (resultArr[0] > resultArr[1])
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("FIRST TEAM WIN");
                Console.ResetColor();
                return;
            }

            if(resultArr[1]>resultArr[0])
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("SECOND TEAM WIN");
                Console.ResetColor();
                return;
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("IT'S A DRAW");
            Console.ResetColor();
        }
    }
}
