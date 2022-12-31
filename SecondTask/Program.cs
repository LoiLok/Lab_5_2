using System;

class Program
{
    static void Main()
    {
        string[] nums = new string[11] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "-" };
        string str = Console.ReadLine();
        int sum = 0;
        for (int i = 0; i < str.Length; i++)
        {
            string symbol = str[i].ToString();
            if (symbol == "-")
            {
                i += 1;
                symbol = str[i].ToString();
            }
            int check = IndexOf(nums, symbol);
            if (check != -1)
            {
                sum += check;
            }                
        }
        if (sum == 0 && str != "0")
        {
            Console.WriteLine("Число не корректно");
        }
        else
        {
            Console.WriteLine(sum);
        }
    }
    static int IndexOf(string[] nums, string symbol)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == symbol)
            {
                return i;
            }
        }
        return -1;
    }
}