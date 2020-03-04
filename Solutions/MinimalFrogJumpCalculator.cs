﻿using System;

namespace AlgorithmChallenges.Codility.Solutions
{
    public class MinimalFrogJumpCalculator
    {
        public int Calculate(int X, int Y, int D)
        {
            if (X == Y)
            {
                return 0;
            }

            return (int) Math.Ceiling((double)(Y - X) / D);
        }
    }
}
