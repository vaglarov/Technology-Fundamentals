using System;

namespace _110._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            //            •	On the first input line - lost games count – integer in the range[0, 1000].
            //•	On the second line – headset price -floating point number in range[0, 1000].
            //•	On the third line – mouse price -floating point number in range[0, 1000].
            //•	On the fourth line – keyboard price -floating point number in range[0, 1000].
            //•	On the fifth line – display price -floating point number in range[0, 1000].
            int lostGameInput = int.Parse(Console.ReadLine());
            double priceHeadsetInput = double.Parse(Console.ReadLine());
            double priceMouseInput = double.Parse(Console.ReadLine());
            double priceKeyboardInput = double.Parse(Console.ReadLine());
            double priceDisplayInput = double.Parse(Console.ReadLine());
            double moneyForHeadset = lostGameInput / 2 * priceHeadsetInput;
            double moneyForMouses = lostGameInput / 3 * priceMouseInput;
            double moneyForKeyboar = lostGameInput / 6 * priceKeyboardInput;
            double moneyForDisplay = lostGameInput / 12 * priceDisplayInput;
            double totalMoney = moneyForHeadset
                + moneyForMouses
                + moneyForKeyboar
                + moneyForDisplay;
            Console.WriteLine($"Rage expenses: {totalMoney:f2} lv.");
        }
    }
}
