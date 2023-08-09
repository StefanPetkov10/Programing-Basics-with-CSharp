using System;

namespace T02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int failedTimes = int.Parse(Console.ReadLine());

            double evaluationSum = 0;
            int evaluationCount = 0;
            int failedCount = 0;

            string lastExercise = string.Empty;
            

            string input = Console.ReadLine();

            while(input != "Enough")
            {
                lastExercise = input;
                int evaluation = int.Parse(Console.ReadLine());

                evaluationSum += evaluation;
                evaluationCount++;

                if (evaluation <=4)
                {
                    failedCount++;
                    if(failedCount == failedTimes)
                    {
                        Console.WriteLine($"You need a break, {failedTimes} poor grades.");
                        break;
                    }
                }
                input = Console.ReadLine();
                
            }
            if (failedCount < failedTimes)
            {
                double average = evaluationSum / evaluationCount;
                Console.WriteLine($"Average score: {average:f2}");
                Console.WriteLine($"Number of problems: {evaluationCount}");
                Console.WriteLine($"Last problem: {lastExercise}");
            }
        }
    }
}
