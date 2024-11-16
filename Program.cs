using System;
namespace DecisionTreeApp
{
    class calculater
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a,b or c.");
            Console.WriteLine("a is for prime numbers.b is for mirror numbers.c is for decision tree.");
            string response = Console.ReadLine().ToLower();
            if (response == "a")
            {
                Console.WriteLine("is your number less than 1000?");
                string answer1 = Console.ReadLine().ToLower();

                if (answer1 == "yes")
                {
                    int n = 0;
                    int m = 1000;
                    bool check;

                    for (int i = n + 1; i < m; i++)
                    {
                        check = true;
                        for (int j = 2; (check && j < i); j++)
                            if (i % j == 0)
                                check = false;

                        if (check)
                            Console.Write("{0} ", i);
                    }
                }
                else
                {
                    int n = 1000;
                    int m = 10000000;
                    bool check;
                    int condition;

                    for (int i = n + 1; i < m; i++)
                    {
                        check = true;
                        condition = Convert.ToInt32(Math.Sqrt(i));
                        for (int j = 2; (check && j <= condition); j++)
                            if (i % j == 0)
                                check = false;

                        if (check)
                            Console.Write("{0} ", i);
                    }
                }
            }
            else if (response == "b")
            {
                Console.Write("Enter the first number (n): ");
                int n = int.Parse(Console.ReadLine());

                Console.Write("Enter the second number (m): ");
                int m = int.Parse(Console.ReadLine());

                // Ensure n is less than m
                if (n > m)
                {
                    int temp = n;
                    n = m;
                    m = temp;
                }

                Console.WriteLine($"Mirror numbers between {n} and {m}:");
                for (int i = n; i <= m; i++)
                {
                    if (IsMirrorNumber(i))
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.Write("are you happy in your way of living?");
                string qa = "";
                bool IsContinue = true;

                do
                {
                    qa = qa + _01.KeyBoard.GetYesOrNo().ToString().ToLower();

                    switch (qa)
                    {
                        case "y":
                            Console.Write("do have any passion in your life?");
                            break;
                        case "n":
                            Console.Write("Do you have any value for yourself?");
                            break;
                        case "yy":
                            Console.Write("continue on your way:)))))");
                            break;
                        case "yn":
                            Console.Write("why didnt you find that? do you wanna live or just being alive?");
                            break;
                        case "ny":
                            Console.Write("thats a good step,try new things and make wonderful experience to figure out {what do you live for?}");
                            break;
                        case "nn":
                            Console.Write("not glad to hear that:) find your lifestyle to be sure you are walking in the right way!!!");
                            break;
                        default:
                            throw new Exception();
                    }

                } while (IsContinue);
                Console.WriteLine();
                Console.WriteLine("The End!");
            }
        }

        private static bool IsMirrorNumber(int i)
        {
            throw new NotImplementedException();
        }
    }
}