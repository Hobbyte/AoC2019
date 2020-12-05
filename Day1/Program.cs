using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Day1
{
    class Program
    {
        static int CalcMass(int m)
        {
            return m / 3 - 2;
        }

        static int AddFuel(int m)
        {
            if (m <= 0)
                return 0;

            return (m + AddFuel(CalcMass(m)));
        }

        static int CalcTotalFuel(int m)
        {
            int totalFuel = AddFuel(CalcMass(m));

            return totalFuel;
        }

        static void Part1(List<string> lines)
        {
            var sum = lines.Sum(x => CalcMass(int.Parse(x)));

            Console.WriteLine("Part1: " + sum);
        }

        static void Part2(List<string> lines)
        {
            var sum = lines.Sum(x => CalcTotalFuel(Int32.Parse(x)));

            Console.WriteLine("Part2: " + sum);
        }

        static void Test1()
        {
            if (CalcMass(1969) != 654)
                throw new Exception();

            if (CalcMass(100756) != 33583)
                throw new Exception();
        }


        static void Test2()
        {
            if (CalcTotalFuel(14) != 2)
                throw new Exception();
            if (CalcTotalFuel(1969) != 966)
                throw new Exception();
            if (CalcTotalFuel(100756) != 50346)
                throw new Exception();
        }

        static void Main(string[] args)
        {
            Test1();
            Test2();

            string inputPath = "input.txt";
            List<string> lines = new List<string>(File.ReadAllLines(inputPath));

            Part1(lines);
            Part2(lines);
        }
    }
}
