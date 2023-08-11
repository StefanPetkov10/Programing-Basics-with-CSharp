using System;

namespace T04._Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int evaluators = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double evaluation;
            int evaluationCount = 0;
            double evaluationSum = 0;

            while (input != "Finish")
            {
                evaluation = 0;

                for (int i = 1; i <= evaluators; i++)
                {
                    evaluation += double.Parse(Console.ReadLine());
                }
                evaluation = evaluation / evaluators;
                Console.WriteLine($"{input} - {evaluation:f2}.");

                evaluationSum += evaluation;
                evaluationCount++;

                input = Console.ReadLine();
            }
            evaluationSum /= evaluationCount;

            Console.WriteLine($"Student's final assessment is {evaluationSum:f2}.");

        }
    }
}
