using System;

namespace BranchesAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            for (int i = 1; i < 20; i++)
            {
                if(i%3==0)
                {
                    num = num + i;
                    Console.WriteLine(num);
                }
            }
        }
    }
}
