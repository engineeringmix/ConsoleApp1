using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            /* string str = "SHLfjsSHLfsjfshl".ToUpper();
             int c = Regex.Matches(str, "SHL").Count;

             Console.WriteLine(c);*/




            /* string str = "SHLfjsSHLfsjfshl".ToUpper();  
             int c = 0;
             for (int i = 0; i < str.Length; i++)
             {
                 if (str[i] == 'S')
                 {
                     if (str[i + 1] == 'H')
                     {
                         if (str[i + 2] == 'L')
                         {
                             c += 1;
                         }
                     }
                 }
             }
             Console.WriteLine(c);

             Console.ReadKey();*/



            /*string s, revs = "";
            Console.WriteLine(" Enter string");
            s = Console.ReadLine();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                revs += s[i].ToString();
            }
            if (revs == s)
            {
                Console.WriteLine("String is Palindrome \n Entered String Was {0} and reverse string is {1}", s, revs);
            }
            else
            {
                Console.WriteLine("String is not Palindrome \n Entered String Was {0} and reverse string is {1}", s, revs);
            }
            */


            /* int n, reverse = 0, rem;
             Console.Write("Enter a number: ");
             n = int.Parse(Console.ReadLine());
             while (n == 0)
             {
                 rem = n % 10;
                 reverse = reverse * 10 + rem;
                 n /= 10;
             }
             Console.Write("Reversed Number: " + reverse);

             Console.ReadKey();*/


            /*string _title = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            StringBuilder duplicateChar = new StringBuilder();

            foreach (var item in _title)
            {
                if (result.ToString().IndexOf(item.ToString().ToLower()) == -1)
                {
                    result.Append(item);
                }
                else
                {
                    duplicateChar.Append(item);
                }
            }

            Console.WriteLine(duplicateChar);

            Console.ReadKey();*/


            /*            string _title = Console.ReadLine();
                        string result = "";
                        if (string.IsNullOrEmpty(_title))
                            Console.WriteLine(string.Empty);

                        string[] arr = _title.Split(" ");
                        for (int i = 0; i < arr.Length; i++)
                        {
                            if (i != arr.Length - 1)
                            {
                                result += ReverseString(arr[i]) + " ";
                            }
                            else
                            {
                                result += ReverseString(arr[i]) + " ";
                            }
                        }

                        Console.WriteLine(result);*/

            int n, sum = 0, r;
            Console.Write("Enter the Number= ");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                r = n % 10;
                sum = sum * 10 + r;
                n = n / 10;
            }
            n = sum;
            while (n > 0)
            {
                r = n % 10;
                switch (r)
                {
                    case 1:
                        Console.Write("one ");
                        break;
                    case 2:
                        Console.Write("two ");
                        break;
                    case 3:
                        Console.Write("three ");
                        break;
                    case 4:
                        Console.Write("four ");
                        break;
                    case 5:
                        Console.Write("five ");
                        break;
                    case 6:
                        Console.Write("six ");
                        break;
                    case 7:
                        Console.Write("seven ");
                        break;
                    case 8:
                        Console.Write("eight ");
                        break;
                    case 9:
                        Console.Write("nine ");
                        break;
                    case 0:
                        Console.Write("zero ");
                        break;
                    default:
                        Console.Write("tttt ");
                        break;
                }    
                n = n / 10;
            }

            Console.ReadKey();


        }
    }
}