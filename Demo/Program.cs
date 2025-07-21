using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Demo
{
    class programe
    {
        #region Methods
        public static void PrintShape(string pattern, int count)
        {
            for (int i = 0; i < count; i++) 
            {
                Console.WriteLine(pattern);
            }

        }
        public static void Swap(ref int x,ref int y) 
        { 
            int Temp = x;
            x = y;
            y = Temp;
        }
        public static int sumArray(ref int[] array) 
        {
            int sum = 0;
            if (array != null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                }
            }
            return sum;
        }
        public static void  SumSub(int x, int y ,out int sum , out int sub)
        {
             sum = x + y;
             sub =x-y;
        
        }
        #endregion
        static void Main(string[] args)
        {
            #region 1D Array
            //int[] num = { 1, 2, 3 };

            //num = new int[3];
            //Console.WriteLine($"size of array{num.Length},Dimension Array={num.Rank}");
            //for ( int i = 0; i < num.Length; i++ ) 
            //    Console.WriteLine( num[i] );
            //foreach ( int item in num )
            //    Console.WriteLine( item );
            #region creation
            //int [] num01 = { 1, 2, 3 };
            //int[] num03 = new int[3];
            //int[ ] num04 = {1,2,3 };    
            //   int[] num05 =  [1,2,3];
            #endregion
            #endregion
            #region multi Array
            #region 2D array
            //int[,] Marks = new int[2, 5];
            ////take data from user
            //for (int i = 0; i < Marks.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Grades {i+1}=");
            //    for (int j = 0; j < Marks.GetLength(1); j++)
            //    {
            //        Console.Write($"Subject num{j+1}=");
            //       bool Isparsed= int.TryParse(Console.ReadLine(), out Marks[i,j]);
            //        if ( Isparsed )
            //            j++;
            //    }
            //    Console.WriteLine("================");
            //}
            //for (int i = 0;i < Marks.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Grade{i + 1}");
            //    for(int j = 0;j < Marks.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"mark of sub num {j+1} ={ Marks[i,j]}");
            //    }
            //    Console.WriteLine("================");
            //}
            #endregion
            #region 2D part 2 using one loop
            //int[,] Marks = new int[2, 4];

            //for (int i = 0; i < Marks.Length;)
            //{
            //    bool Isparsed = int.TryParse(Console.ReadLine(), out int studentMarks);
            //    if (Isparsed)
            //    {
            //        ++i; Marks[i/Marks.GetLength(1), i% Marks.GetLength(1)]= studentMarks;
            //    }
            //    Console.WriteLine("================");
            //}
            ////print
            //for (int i = 0; i < Marks.Length; i++) 
            //{ 
            //    Console.WriteLine(Marks[i / Marks.GetLength(1), i % Marks.GetLength(1)]);
            //}


            #endregion

            #endregion
            #region Jagged Array
            //int[ ][] jaggedArray = new int[2][ ];
            //jaggedArray[0]= new int[2];//0 0 0 0
            //jaggedArray[1]= new int[] {10,20};
            //jaggedArray[2]= [2,3,4];
            #endregion
            #region Array method
            //int[] number = { 1, 2, 3, 4, 5, 6, 7, 8,9 };
            //Array.Sort(number);
            //Array.Reverse(number);
            //Array.Clear(number);
            //int[] num2 = new int[4];
            //Array.Copy(number, num2 , 4);
            //Array.ConstrainedCopy(number,1, num2, 1,5);
            //foreach (int item in number) { Console.WriteLine(number); }
            //int[] x = { 1, 2, 3, 4, 5, 8 };
            //x.GetLength(2);





            #endregion
            #region Functions
            ////PrintShape();
            //PrintShape(":)",10); //passing by order
            //PrintShape(count : 5, pattern : "A"); //passing by name
            //PrintShape(count: 10);
            ////  PrintShape(pattern:"/*\"); //invalid {Escape Squense}
            #endregion
            #region Function parameter
            // value type
            //int A = 10, B = 5;
            //Console.WriteLine($"A={A}");
            //Console.WriteLine($"B={B}");
            //Swap(ref A,ref B);
            //Console.WriteLine("Ater swap");
            //Console.WriteLine($"A={A}");
            //Console.WriteLine($"B={B}");
            #endregion

            #region function ref type

            //int[] array = { 1, 2, 3 };
            //int Result = sumArray(array);   
            //Console.WriteLine(Result);
            #endregion
            #region EX02
            /// by value type
            //int[] numbers = { 1, 2, 3 };
            //Console.WriteLine(numbers[0]);//1
            //int result = sumArray(numbers);
            //Console.WriteLine(result);
            //Console.WriteLine(numbers[0]);//1
            /// by ref
            //int[] numbers = { 1, 2, 3 };
            //Console.WriteLine(numbers[0]);//1
            //int result = sumArray(ref numbers);
            //Console.WriteLine(result);
            //Console.WriteLine(numbers[0]);
            #endregion
            #region by out
            //int a = 10, b = 20, sumResult, SubResult;
            //SumSub( a, b ,out  sumResult, out SubResult );
            //Console.WriteLine(sumResult);
            //Console.WriteLine(SubResult);
            #endregion
        }
    }
}
