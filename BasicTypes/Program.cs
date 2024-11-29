using System.Globalization;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BasicTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Loop3 3 times and run TestNumbers()
            //for (int i = 0; i < 3; i++)
            //{
            //    TestNumbers();
            //}
           
            //--Seperator
           // Console.WriteLine("--------------");
          
            //-TestBoolean
          //  TestBoolean();
           
           // Console.WriteLine("--------------");

            //TestArray();

            ClassTask1();



        }

        private static void ClassTask1()
        {

            //1) Create Array Of Booleans (50) 
              bool[] arr = new bool[50];
            //2) Set ALL ARRAY Items SHOULD BE True
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = true;
            }
            //3) Print Before
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{i}:[{arr[i]}]");
            }

            Console.WriteLine("----------");
            //4) Set ONLY EVEN(זוגי) Index in False
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    arr[i] = false;
                }
            }
            

            //5) Print array After changes
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{i}:[{arr[i]}]");
            }

        }

        #region ---- Test Array---
        private static void TestArray()
        {
            int[] numbers1 = { 1, 2, 3, 4, 5, 6 };
            numbers1[0] = 100;
            numbers1[1] = 200;
            //Print 
            PrintArrayToConsole(numbers1);
            
            //Add 1 to each Cell
            for (int i = 0; i < numbers1.Length; i++)
            {
                numbers1[i] += 1;
            }
            Console.WriteLine();
            //Print
            PrintArrayToConsole(numbers1);

            Console.WriteLine();

            foreach (int itemNum in numbers1)
            {
                Console.WriteLine(itemNum);
            }


            //Assign 10 numbers
            int[] numbers2 = new  int[10];
            


        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr"></param>
        private static void PrintArrayToConsole(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "|");
            }
            Console.WriteLine();
        }

        #endregion

        /// <summary>
        /// Test Numbers will test number types
        /// </summary>
        public static void TestNumbers()
        {
            int x = 10;
            int y = 20;
            int z = x + y;
            z++;
            string s = $"x={x}:y={y}:z={z}";
            Console.WriteLine(s);

            double d = 12.35;
            d += 1.4;

            float f = 13.45f;
            f += 1.22f;
            
            float f2 = f;
            f += 2;

            int num = (int)f;//Will Cut
            Console.WriteLine(num);

            string txtFloat =  $"f={f},f2={f2}";
            Console.WriteLine(txtFloat);



        }

        /// <summary>
        /// TestBoolean Will Test Boolean types
        /// </summary>
        public static void TestBoolean()
        {
            
            bool b1 = true;
            Console.WriteLine($"b1:{b1.ToString().ToUpper()}");
            bool b2 = false;
            bool b3 = b1 == b2;
            if (b3 == b2)
            {
                Console.WriteLine("b1 == b2");
            }

            //--Check and Assign
            string txt = (b3 == b2) ? "b3==b2":"b3!=b2"; 
            Console.WriteLine(txt);



        }

        








    }
}
