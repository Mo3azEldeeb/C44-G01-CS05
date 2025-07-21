using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Channels;

namespace Assignment
{
    class Programe
    {
        public static int SumArray(int[] Arr)
        {
            int Sum = 0;
            Arr[0] = 100;
            for (int i = 0; i < Arr.Length; i++)
                Sum += Arr[i];
            return Sum;
        }

        public static int SumArray(ref int[] Arr)
        {
            int Sum = 0;
            Arr[0] = 100;
            for (int i = 0; i < Arr.Length; i++)
                Sum += Arr[i];
            return Sum;
        }
        public static int Fun (int num1  , int num2 )
        {
           int Sum = num1 + num2;
          int  sub=num1 - num2;

            return (Sum);
              
        }
        static int SumOfDigits(int number)
        {
            int sum = 0;
            number = Math.Abs(number);

            while (number > 0)
            {
                sum += number % 10;
            }

            return sum;
        }

        static void Main(String[] args)
        {
            ///Arrays
            #region Q1 
            ////Write a program in C# Sharp to find the sum of all elements of the array.

            //Console.Write("Enter the Number of digits: ");
            //bool IsParsed = int.TryParse(Console.ReadLine(), out int n);

            //int[] arr = new int[n];
            //int sum = 0;

            //Console.WriteLine("Enter the Numbers:");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"number {i+1}: ");
            //     bool IsParsed02 = int.TryParse(Console.ReadLine(), out arr[i]);

            //    sum += arr[i];
            //}

            //Console.WriteLine($"The sum of all numbers  is: {sum}");
            #endregion
            #region Q2
            //// Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            //Console.Write("Enter the size of the arrays: ");
            //bool IsParsed0 = int.TryParse(Console.ReadLine(), out int size);

            //int[] array1 = new int[size];
            //int[] array2 = new int[size];

            //Console.WriteLine("Enter elements for the first array:");
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"Element[{i}] of array1: ");
            //    bool IsParsed01 = int.TryParse(Console.ReadLine(), out array1[i]);
            //}

            //Console.WriteLine("Enter elements for the second array:");
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"Element[{i}] of array2: ");
            //    bool IsParsed02 = int.TryParse(Console.ReadLine(), out array2[i]);
            //}


            //int[] mergedArray = new int[size * 2];
            //for (int i = 0; i < size; i++)
            //{
            //    mergedArray[i] = array1[i];
            //    mergedArray[i + size] = array2[i];
            //}


            //Array.Sort(mergedArray);

            //Console.WriteLine("Merged array in ascending order:");
            //foreach (int num in mergedArray)
            //{
            //    Console.Write(num + " ");
            //}

            //Console.ReadKey();
            #endregion
            #region Q3
            // Write a program in C# Sharp to count the frequency of each element of an array.

            #endregion
            #region Q4
            //// Write a program in C# Sharp to find maximum and minimum element in an array
            //Console.Write("Enter the number of elements in the array: ");
            //bool Isparsed=int.TryParse(Console.ReadLine(), out  int n);

            //int[] arr = new int[n];

            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"Element[{i+1}]: ");
            //    bool IsParsed = int.TryParse(Console.ReadLine(), out arr[i]); // if string?
            //}

            //int max = arr[0];
            //int min = arr[0];

            //for (int i = 1; i < n; i++)
            //{
            //    if (arr[i] > max)
            //        max = arr[i];
            //    if (arr[i] < min)
            //        min = arr[i];
            //}

            //Console.WriteLine($"Maximum element is: {max}");
            //Console.WriteLine($"Minimum element is: {min}");
            #endregion
            #region Q5
            //Console.Write("Enter the number of elements in the array: ");
            //bool Isparsed = int.TryParse(Console.ReadLine(), out int n);

            //int[] arr = new int[n];

            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"Element[{i + 1}]: ");
            //    bool IsParsed = int.TryParse(Console.ReadLine(), out arr[i]); 
            //}

            //Array.Sort(arr);
            //Array.Reverse(arr); 


            //foreach (int num in arr)
            //{
            //    Console.Write(num + " ");
            //}

            //Console.WriteLine($"second largest is: {arr[1]}");

            #endregion
            #region Q6

            #endregion
            #region Q9
            //Console.Write("Enter number of rows: ");
            //bool Isparsed = int.TryParse(Console.ReadLine(), out int D1);

            //Console.Write("Enter number of columns: ");
            //bool Isparsed01 = int.TryParse(Console.ReadLine(), out int D2);

            //int[,] firstArray = new int[D1, D2];
            //int[,] secondArray = new int[D1, D2];

            //Console.WriteLine("Enter elements for the first array:");
            //for (int i = 0; i < D1; i++)
            //{
            //    for (int j = 0; j < D2; j++)
            //    {
            //        Console.Write($"Element[{i},{j}]: ");
            //        firstArray[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}


            //for (int i = 0; i < D1; i++)
            //{
            //    for (int j = 0; j < D2; j++)
            //    {
            //        secondArray[i, j] = firstArray[i, j];
            //    }
            //}


            //Console.WriteLine("Second array after copying:");
            //for (int i = 0; i < D1; i++)
            //{
            //    for (int j = 0; j < D2; j++)
            //    {
            //        Console.Write(secondArray[i, j] + " ");
            //    }
            //}
            #endregion
            #region Q10
            //Console.Write("Enter the number of elements in the array: ");
            //bool Isparsed = int.TryParse(Console.ReadLine(), out int n);

            //int[] arr = new int[n];

            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"Element[{i + 1}]: ");
            //    bool IsParsed = int.TryParse(Console.ReadLine(), out arr[i]);
            //}

            //Array.Sort(arr);
            //Array.Reverse(arr);


            //foreach (int num in arr)
            //{
            //    Console.Write(num + " ");
            //}
            #endregion
            /// Functions
            #region FunQ1
            // by value
            //            Passes a copy of the reference to the array.
            //Modifying elements will affect the original array.
            //Won't affect the original reference outside the method.
            // Method have same reference passed, but cannot modify the reference itself
            //int[] Numbers = { 1, 2, 3 };
            //int result = SumArray(Numbers);
            //Console.WriteLine(result); //105
            //Console.WriteLine(Numbers[0]); //100


            // by ref
            //            Passes the original reference of array
            //Modifying elements will affect the original array.
            //Will affect the original reference outside the method.
            //Method can changes the reference itself
            //int[] numbers = { 1, 2, 3 };
            //int result01 = SumArray(ref numbers);
            //Console.WriteLine(result01); //105
            //Console.WriteLine(numbers[0]); //100


            #endregion
            #region FunQ2

            // it is the same Question

            #endregion
            #region FunQ3
            Console.Write("Enter first number  (n1): ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number (n2): ");
            int n2 = int.Parse(Console.ReadLine());
            int resul = Fun(n1, n2);

            #endregion
            #region Q4
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine() ?? "0");

            int result = SumOfDigits(num);

            Console.WriteLine($"The sum of the digits of the number {num} is: {result}");
            #endregion
        }
    }
}
