using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHALLENGE_200
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lavet af Ricco Jørgensen den 25/01-2021\n\n");


            Console.WriteLine("challenge-201:");
            Console.WriteLine("4556364607935616 -> " + Maskify("4556364607935616"));
            Console.WriteLine("64607935616 -> " + Maskify("64607935616"));
            Console.WriteLine("1 -> " + Maskify("1"));
            Console.WriteLine("--------");

            Console.WriteLine("challenge-202:");
            Console.WriteLine("189 -> " + ExpressFactors(189));
            Console.WriteLine("60 -> " + ExpressFactors(60));
            Console.WriteLine("--------");

            Console.WriteLine("challenge-203:");
            int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
            Console.WriteLine("3 -> " + IsPrime(primes, 3));
            Console.WriteLine("31 -> " + IsPrime(primes, 31));
            Console.WriteLine("50 -> " + IsPrime(primes, 50));
            Console.WriteLine("--------");

            Console.WriteLine("challenge-204:");
            Console.WriteLine("potato -> " + Potatoes("potato"));
            Console.WriteLine("potatopotatopotatopotato -> " + Potatoes("potatopotatopotatopotato"));
            Console.WriteLine("potatopotaheotatopotato -> " + Potatoes("potatopotaheotatopotato"));
            Console.WriteLine("--------");

            Console.WriteLine("challenge-205:"); 
            Console.WriteLine("Hi there! -> [{0}]", string.Join(", ", Encrypt("Hi there!")));
            Console.WriteLine("Sunshine -> [{0}]", string.Join(", ", Encrypt("Sunshine")));
            Console.WriteLine("[72, 33, -73, 84, -12, -3, 13, -13, -68] -> " + Decrypt(new int[] { 72, 33, -73, 84, -12, -3, 13, -13, -68 }));
        }

        public static string Maskify(string toMask)
        {
            if(toMask.Length > 4)
            {
                string maskedString = toMask.Substring(0, toMask.Length - 4);
                maskedString = new String('#', maskedString.Length);
                return maskedString + toMask.Substring(toMask.Length - 4);
            }
            return toMask;
        }

        public static string ExpressFactors(int number)
        {
            //Her vill jeg sikre at <number> altid var et positivt nummer
            int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
            string factorList = "";
            if (number != 0)
            {
                foreach (int item in primes)
                {
                    if ((number % item) == 0)
                    {
                        factorList += item;
                        factorList += ExpressFactors(number / item);
                        break;
                    }
                }
                return string.Join("*", factorList.Replace("*", "").ToCharArray());
            }
            return "";
        }

        public static string IsPrime(int[] primes, int number)
        {
            //Her vill jeg nok også sikre at <number> ikker er højere end det højste i <primes>
            if(Array.BinarySearch(primes, number) < 0)
            {
                return "no";
            }
            return "yes";
        }

        public static int Potatoes(string sentence)
        {
            int potatoAmount = 0;
            int index = 0;
            while (index != -1)
            {
                index = sentence.IndexOf("potato", index);
                if (index != -1)
                {
                    potatoAmount++;
                    index++;
                }
            }
            return potatoAmount;
        }

        public static int[] Encrypt(string sentence)
        {
            char[] chars = sentence.ToCharArray();
            List<int> alphabetIndex = new List<int>();
            int prevChar = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                alphabetIndex.Add(chars[i] - prevChar);
                prevChar = chars[i];
            }
            return alphabetIndex.ToArray();
        }

        public static string Decrypt(int[] encArray)
        {
            string decString = "";
            int prevChar = 0;
            for (int i = 0; i < encArray.Length; i++)
            {
                decString += (Convert.ToChar(prevChar + encArray[i]));
                prevChar = prevChar + encArray[i];
            }
            return decString;
        }
    }
}
