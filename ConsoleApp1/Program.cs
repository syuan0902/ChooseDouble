using System;

namespace ChooseDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入要選取的Double數量: ");
            string line = Console.ReadLine();
            if (int.TryParse(line, out int number))
            {
                foreach (double m_randomDouble in ChooseSomeDouble.PickSomeNumber(number))
                {
                    Console.WriteLine(m_randomDouble);
                }
            }

            else
            {
                Console.WriteLine("請輸入有效的數字");
            }
        }
    }
}
