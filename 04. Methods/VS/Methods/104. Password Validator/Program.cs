using System;

class Program
{
    static void Main(string[] args)
    {
        string passwordInput = Console.ReadLine();
        bool isInclosive6To10Char = IsInclosive6To10Char(passwordInput);
        bool isOnlyLetterAndDigits = IsOnlyLetterAndDigits(passwordInput);
        bool haveAtLeast2Digits = HaveAtLeast2Digits(passwordInput);
        if (haveAtLeast2Digits &&
            isOnlyLetterAndDigits &&
            isInclosive6To10Char)
        {
            Console.WriteLine("Password is valid");
        }
    }

    private static bool HaveAtLeast2Digits(string passwordInput)
    {
            int count = 0;
        for (int i = 0; i < passwordInput.Length; i++)
        {
            char charInWord = passwordInput[i];
            if (Char.IsDigit(charInWord))
            {
                count++;
                if (count>1)
                {
                    
                    return true;

                }
            }
        }
        Console.WriteLine("Password must have at least 2 digits");
        return false;
    }

    private static bool IsOnlyLetterAndDigits(string passwordInput)
    {
        for (int i = 0; i < passwordInput.Length; i++)
        {
            char charInWord = passwordInput[i]; 
            if (!Char.IsLetterOrDigit(charInWord))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                return false;
            }
        }
        return true;
    }

    private static bool IsInclosive6To10Char(string passwordInput)
    {
        if (passwordInput.Length >= 6 && passwordInput.Length <= 10)
        {
            return true;
        }
        else
        {
            Console.WriteLine("Password must be between 6 and 10 characters ");
            return false;
        }
    }
}
