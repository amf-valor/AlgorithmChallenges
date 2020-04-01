namespace AlgorithmChallenges.Codility.Solutions.EuclideanAlgorithm
{
    /// <summary>
    /// Lesson 12 - ChocolatesByNumber
    /// </summary>
    public class ChocolatesEatenCounter
    {
        public int Count(int N, int M)
        {
            int greatestCommomDivisor = CalculateGreatestCommonDivisor(N, M);
            return N / greatestCommomDivisor;
        }

        private int CalculateGreatestCommonDivisor(int number1, int number2)
        {
            if (number1 % number2 == 0)
            {
                return number2;
            }
            else
            {
                return CalculateGreatestCommonDivisor(number2, number1 % number2);
            }
        }
    }
}
