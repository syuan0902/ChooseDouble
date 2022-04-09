using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseDouble
{
    class ChooseSomeDouble
    {

        public static double[] PickSomeNumber(int number)
        {
            Random m_random = new Random();
            double[] m_randomDouble = new double[number];
            for (int i = 0; i < number; i++)
            {
                double m_value = m_random.NextDouble();
                m_randomDouble[i] = m_value;
            }
            return m_randomDouble;
        }
    }
}
