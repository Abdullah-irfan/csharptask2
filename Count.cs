using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharptest2
{
    class Count
    {
        public static void qus1()
        {
            //qus1.( input a string )
            string str;
            int l = 0;


            Console.Write("Input the string : ");
            str = Console.ReadLine();
            Console.Write("The string you entered is : {0}\n", str);
            //qus2.(  find the length)
            Console.Write("The string you entered is : {0}\n", str.Length);

            //qus.3(IndividualCharacters )
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i] + "  ");
            }
            //qus.4( reverse order)
            Console.WriteLine();
            l = str.Length - 1;
            while (l >= 0)
            {
                Console.Write("{0} ", str[l]);
                l--;
            }
        }
        public static void irfan()

        {
            //qus.5( o count the total number of words in a string.)
            Console.Write("Enter the  sentance : ");
            String sentence = Console.ReadLine();
            int count = 0, myWord = 1;

            while (count <= sentence.Length - 1)
            {
                if (sentence[count] == ' ' || sentence[count] == '\n' || sentence[count] == '\t')
                {
                    myWord++;
                }
                count++;
            }
            Console.WriteLine("Total number of words in the given string: " + myWord);



        }
        //qus.6( )
        public static void compar()
        {

            Console.Write("Enter Name : ");
            string Name = Console.ReadLine();
            Console.Write("Enter Password : ");
            string Password = Console.ReadLine();

            if (Name == Password)
            {
                Console.WriteLine("sucess");
            }
            else
            {
                Console.WriteLine("try again");
            }


        }
        //qus.7(count a total number of vowel or consonant in a string )
        public static void vowel()
        {

            string a;
            int i = 0; int length, vowels = 0, consonants = 0;
            Console.WriteLine("\n");
            Console.WriteLine("Count the number of vowels and consonants in a string");
            Console.WriteLine("Enter the First String:");
            a = Console.ReadLine();
            length = a.Length;
            while (i < length)
            {
                if (a[i] == 'a' || a[i] == 'e' || a[i] == 'i' || a[i] == 'o' || a[i] == 'u')
                {
                    vowels++;
                }
                else
                {
                    consonants++;
                }
                i++;
            }



            Console.WriteLine("The given string contains the vowels are={0}", vowels);
            Console.WriteLine("THe Given string contains the Consonants are={0}", consonants);

        }
        //qus(8)
        //public static void ASS()
        //{


        //    string[] arr = new string[] { "irfan", "abu" };
        //    Array.Sort(arr);
        //    // reverse array
        //    Array.Reverse(arr);
        //    foreach (string value in arr)
        //    {
        //        Console.Write("ascending order{0}\n", value + " ");
        //    }
        //}
        public static void qus9()
        {
            string value1, value2;
            bool compar;
            Console.Write("Enter the sentance : ");
            value1 = Console.ReadLine();
            Console.Write(" search : ");
            value2 = Console.ReadLine();
            compar = value1.Contains(value2);
            if (compar)
                Console.Write("The given string exists .\n");
            else
                Console.Write("The substring is not  given string exists . \n");
        }
        public static void qus10()
        {
            string str1;
            char[] arr1;
            int length, i;
            length = 0;
            char ch;
            Console.Write("Enter the character : ");
            str1 = Console.ReadLine();
            length = str1.Length;
            arr1 = str1.ToCharArray(0, length);

            for (i = 0; i < length; i++)
            {
                ch = arr1[i];
                if (Char.IsLower(ch))
                    Console.Write(Char.ToUpper(ch));
                else
                    Console.Write(Char.ToLower(ch));
            }
        }
        public static void qus11()
        {
            string find;
            string str;
            Console.Write("Enter the character : ");
            str = Console.ReadLine();
            Console.Write("Enter the given value: ");
            find = Console.ReadLine();
            int index1 = str.IndexOf(find);
            Console.WriteLine("Found '{0}' in '{1}' at position {2}", find, str, index1);


        }
        public static void qus12()
        {
            Console.Write("Enter the string : ");
            string input = Console.ReadLine();
            while (input.Length > 0)
            {
                Console.Write(input[0] + " : ");
                int count = 0;
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[0] == input[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                input = input.Replace(input[0].ToString(), string.Empty);
            }

        }
        public static void qus13()
        {


            Console.Write("Enter a type case : ");
            char ch = (char)Console.Read();
            if (Char.IsLetter(ch))
            {
                if (Char.IsUpper(ch))
                {
                    Console.WriteLine("The character is uppercase.\n");
                }
                else
                {
                    Console.WriteLine("The character is lowercase.\n");
                }
            }
            else
            {
                Console.WriteLine("The entered character is not an alphabetic character.\n");
            }
        }
        //C# Sharp to insert a substring before the first occurrence of a string(20)
        public static void qus14()
        {
            string value = "abdullah irfan";

            string adjusted = value.Insert(9, "bin ");
            Console.WriteLine("INSERT RESULT: " + adjusted);
        }
        //C# Sharp program to compare the last names of two people. It then lists them in alphabetical order.
        public static void qus15()
        {
            List<string> names = new List<string>();
            names.Add("maharoof mohammed");
            names.Add("irfan abdullah");

            names.Sort();
            foreach (string s in names)
                Console.WriteLine(s);

        }
        public static void qus16()
        {

            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            foreach (int i in array)
            {
                Console.WriteLine("element - {0} ", i);

            }

        }
        public static void qus17()
        {
            int[] array = { 2, 4, 6, 8 };
            Console.WriteLine("The given Array are:2, 4, 6, 8");
            Array.Reverse(array);

            Console.WriteLine(String.Join(',', array));
        }

        public static void qus18()
        {

            int[] array = { 1, 2, 3, 4, 5 };
            Console.WriteLine("The given Array are:1, 2, 3, 4, 5");
            int sum = array.Sum();
            Console.WriteLine("the sum of array are:{0}",sum);
        }
        //C# Sharp to copy the elements one array into another array. 
        public static void qus19()
        {
            //    var source = new[] { "abu", "irfan" };
            //    var target = new string[4];

            //    source.CopyTo(target, 1);

            //    foreach (var item in target)
            //    {
            //        Console.WriteLine(item);
            //    }

            //Initialize array   
            string[] array1 = new string[] { "irfan", "abdullah" };
            string[] array2 = new string[array1.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                array2[i] = array1[i];
            }
            Console.WriteLine("original array: ");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write(array1[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("copy array: ");
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write(array2[i] + " ");
            }
            Console.WriteLine();
        }
        //C# Sharp to count a total number of duplicate elements in an array
        public static void qus20()
        {
            int[] array = { 12, 12, 8, 2, 99, 8, };
            var a = new Dictionary<int, int>();
            Console.WriteLine("The given Array are:12, 12, 8, 2, 99, 8\n");
            foreach (var count in array)
            {
                if (a.ContainsKey(count))
                    a[count]++;
                else
                    a[count] = 1;
            }
            foreach (var val in a)
                Console.WriteLine("{0} occurred {1} times", val.Key, val.Value);

        }
        //Merge two arrays of same size sorted in ascending order
        public static void qus21()
        {
                int i = 0;
                int j = 0;

            int[] array1 = new int[5] { 1, 8, 2, 6, 4 };
            Console.WriteLine("The given 1s_Array are: 1, 8, 2, 6, 4");
            int[] array2 = new int[5] { 5, 8, 6, 4, 8 };
            Console.WriteLine("The given 2nd_Array are: 5, 8, 6, 4, 8");
            int[] merged = new int[10];

                for (i = 0, j = 0; i < 5; i++)
                {
                    merged[j++] = array1[i];
                }
                for (i = 0; i < 5; i++)
                {
                    merged[j++] = array2[i];
                }
                Console.WriteLine(" the merged array = ");
                for (i = 0; i < 10; i++)
                {
                    Console.WriteLine("merged[" + (i) + "]: " + merged[i]);
                }
        }
        //21. Write a C# Sharp program to compare (less than, greater than, equal to ) two substrings
        public static void qus22()
        {

            string str1= "computer", str2= "system";

            Console.WriteLine("str1 = '{0}' str2 = '{1}'", str1, str2);
            if (string.Compare(str1, str2) == 0)
            {
                Console.WriteLine("Both strings are equal");
            }
            else if (string.Compare(str1, str2) < 0)
            {
                //5
                Console.WriteLine("The first string is smaller than the second string");
            }
            else
            {
                //6
                Console.WriteLine("The first string is greater than the second string");
            }
        }
        //
        public static void qus23()
        {

        }



}


}




