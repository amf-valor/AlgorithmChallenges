using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmChallenges.Codility.Solutions
{
    public class ChineseFloorAssigner
    {
        public int Assign(int floor)
        {

            if (floor < 1 || floor > 1018)
            {
                throw new InvalidOperationException(" O andar está fora do range especificado de 1 a 1018");
            }

            int[] spacialElevator = new int[floor];
            int floorToAssign = 1;

            for (int i = 0; i < floor; i++)
            {
                while (HasDigit(floorToAssign, 4) || HasDigit(floorToAssign, 13))
                {
                    floorToAssign++;
                }

                spacialElevator[i] = floorToAssign;
                floorToAssign++;
            }

            return spacialElevator[floor - 1];
        }

        private static bool HasDigit(int n, int digit)
        {
            int factor = digit > 9 ? 100 : 10;

            while (n != 0)
            {
                if (n % factor == digit)
                    return true;
                n /= 10;
            }
            return false;
        }
    }
}
