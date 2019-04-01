using System;

namespace _110._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            //readInput 
            int pokePowerN = int.Parse(Console.ReadLine());
            int originalPokePowerNValue = pokePowerN;
            int distanseBetweenPokeM = int.Parse(Console.ReadLine());
            int exhaustionFactorY = int.Parse(Console.ReadLine());

            //LogicParts
            int countTarget = 0;
            while (pokePowerN >= distanseBetweenPokeM)
            {
                countTarget++;
                pokePowerN -= distanseBetweenPokeM;
                if ((originalPokePowerNValue / 2) == pokePowerN)
                {
                    if (exhaustionFactorY!=0)
                    {
                    pokePowerN /=exhaustionFactorY;

                    }
                }
            }
            Console.WriteLine($"{pokePowerN}\n{countTarget}");
        }
    }
}
