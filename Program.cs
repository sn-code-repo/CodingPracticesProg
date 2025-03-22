using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingProg
{
    class Program
    {
        static void Main(string[] args)
        {
            //ReverseString("ABCDEF");
            //ReverseStringUsingCharArr("ABCDEF");
            //Factorial();
            //FibbonacciSeries();
            //FindDuplicateCharacterInString("CSharpCorner");
            //RemoveDuplicateCharInString("CSharpCorner");
            //FindOccuranceofCharacterInString("CSharpCorner");
            //IsNumberPalindrome();
            //ReverseWordOrder();
            //int[] a = new int[] { 3, 4, 5, 4, 3 };
            //RemoveDuplicateArr(5, a);
            RemoveDuplicateArrUsingHashset();
        }
        static void ReverseString(string str)
        {
            string newString = string.Empty;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                newString = newString + str[i];
            }
            Console.WriteLine(newString);
        }
        static void ReverseStringUsingCharArr(string str)
        {
            string newString = string.Empty;
            char[] strAr = str.ToCharArray();
            for (int i = strAr.Length - 1; i >= 0; i--)
            {
                newString = newString + strAr[i];
            }
            Console.WriteLine(newString);
        }
        static void Factorial()
        {
            Console.Write("Please Enter Any Number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number == 0)
            {
                Console.WriteLine(number);
                return;
            }
            int result = 1;
            for (int i = number; i >= 1; i--)
            {
                result = result * i;
            }
            Console.WriteLine(result);
        }
        static void FibbonacciSeries()
        {
            Console.Write("Please Enter Any Number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number == 0)
            {
                Console.WriteLine(number);
                return;
            }
            int a = 0;
            int b = 1;
            Console.WriteLine(a);
            Console.WriteLine(b);
            for (int i = 2; i < number; i++)
            {
                int c = a + b;
                a = b;
                b = c;
                Console.WriteLine(b);
            }
        }
        static void FindDuplicateCharacterInString(string str)
        {
            char[] cArry = str.ToCharArray();
            List<char> newArray = new List<char>();
            StringBuilder stringBuilder = new StringBuilder();
            for (int a = 0; a < cArry.Length; a++)
            {
                char s = cArry[a];
                for (int j = a + 1; j < cArry.Length; j++)
                {
                    if (cArry[a] == cArry[j])
                    {
                        if (!newArray.Contains(cArry[j]))
                        {
                            newArray.Add(cArry[j]);
                            stringBuilder.Append(cArry[j]);
                        }
                    }
                }
            }
            Console.WriteLine(stringBuilder);
        }
        static void RemoveDuplicateCharInString(string str)
        {
            List<char> dChar = new List<char>();
            foreach (char c in str)
            {
                if (!dChar.Contains(c))
                {
                    dChar.Add(c);
                }
            }
            Console.WriteLine(dChar.ToArray());
        }
        static void FindOccuranceofCharacterInString(string str)
        {
            List<char> dChar = new List<char>();
            Dictionary<char, int> keys = new Dictionary<char, int>();
            foreach (char c in str)
            {
                if (!dChar.Contains(c))
                {
                    dChar.Add(c);
                    keys.Add(c, 1);
                }
                else
                {
                    keys.ContainsKey(c);
                    keys[c] = keys[c] + 1;
                }
            }
            foreach (var s in keys)
            {
                Console.Write(s.Key); Console.WriteLine(" Occurance of : " + s.Value);
            }
        }
        private static void FindDuplicateCharacterInString1(string inPutString)
        {

            if (string.IsNullOrEmpty(inPutString))
            {
                Console.WriteLine("Please enter valid Input");
            }
            else
            {
                var list = new List<char>();
                string result = string.Empty;

                foreach (char item in inPutString)
                {
                    if (list.Contains(item))
                    {
                        if (!result.Contains(item))
                            result += item;
                    }
                    else
                    {
                        list.Add(item);
                    }
                }
                Console.WriteLine("Duplicate Found : {0} ", result);
            }
        }
        private static void IsNumberPalindrome()
        {
            Console.Write("Please Enter Any Number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int reminder; int realnumber = 0;
            int tempNumber; bool isPalindrome = false;
            tempNumber = number;
            while (number > 0)
            {
                reminder = number % 10;
                number = number / 10;
                realnumber = realnumber * 10 + reminder;
                if (realnumber == tempNumber)
                    isPalindrome = true;
            }
            if (isPalindrome)
                Console.WriteLine("Palindrome!");
            else
                Console.WriteLine("Not Palindrome!");
        }
        private static void ReverseWordOrder()
        {
            //input: Welcome to Csharp corner, output: corner Csharp to Welcome
            Console.Write("Please Enter Any string : ");
            string str = Convert.ToString(Console.ReadLine());
            string[] strArray = str.Split(' ');
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = strArray.Length - 1; i >= 0; i--)
            {
                stringBuilder.Append(strArray[i] + ' ');
            }
            Console.WriteLine(stringBuilder);
        }

        private static int[] RemoveDuplicateArr(int size, int[] array)
        {
            //array = new int[] { 3, 4, 5, 4, 3 };            
            List<int> nArray = new List<int>();            
            foreach (int a in array)
            {
                if(!nArray.Contains(a))
                {
                    nArray.Add(a);
                }
            }
            foreach(int i in nArray)
            {
                Console.WriteLine(i);
            }
            return nArray.ToArray();
            //for(int i = 0; i<size; i++)
            //{
            //    for(int j = i+1; j< size; j++)
            //    {
            //        if(array[i] == array[j])
            //        {
            //            newArray[i] = array[i];
            //        }
            //    }
            //}
            //foreach (int a in newArray)
            //{
            //    Console.WriteLine(a);
            //}
            //return newArray;
        }

        private static void RemoveDuplicateArrUsingHashset()
        {
            int[] array = new int[] { 5, 3, 2, 3, 4, 5 };
            HashSet<int> nArray = new HashSet<int>();
            foreach (int a in array)
            {
                nArray.Add(a);
            }
            foreach(int i in nArray)
            {
                Console.WriteLine(i);
            }
        }
    }
}
