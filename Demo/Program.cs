using System;
namespace Demo
{
    class programe
    {
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

        }
    }
}
