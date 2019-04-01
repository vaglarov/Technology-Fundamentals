using System;

namespace _111._Snowballs
{
    class Program
    {
        static void Main()
        {
            //readData

            int numberSnowballsInput = int.Parse(Console.ReadLine());
            double bestcoeficintBestSnowball = 0;
            int bestSnowballSnow = 0;
            int bestSnowballTime = 0;
            int bestSnowballQuality = 0;
            for (int i = 0; i < numberSnowballsInput; i++)
            {
                int snowballSnowInput = int.Parse(Console.ReadLine());
                int snowballTimeInput = int.Parse(Console.ReadLine());
                int snowballQualityInput = int.Parse(Console.ReadLine());
                double coeficientSwonBall = 0;
                if (snowballTimeInput!=0)
                {
                    coeficientSwonBall =Math.Pow((snowballSnowInput / snowballTimeInput), snowballQualityInput);
                }
                if (coeficientSwonBall>=bestcoeficintBestSnowball)
                {
                    bestcoeficintBestSnowball = coeficientSwonBall;
                    bestSnowballSnow = snowballSnowInput;
                    bestSnowballTime = snowballTimeInput;
                    bestSnowballQuality = snowballQualityInput;
                }
            }
            //print  
            if (numberSnowballsInput!=0)
            {
                Console.WriteLine($"{bestSnowballSnow} : {bestSnowballTime} = {bestcoeficintBestSnowball:f0} ({bestSnowballQuality})");
            }
        }
    }
}
