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

            //ClassTask1();

            ClassTask2();


        }

        #region -- Class Task 2 ---
        private static void ClassTask2()
        {
            //1)Define array Of Grades 10
            double[] gradesArr = { 55.7, 98, 51, 100, 74, 63, 61, 86, 81, 60 };
            
            //2)Calculate Avg and print it
            double avg = CalculateAvg(gradesArr);
            Console.WriteLine($"AVG={avg}");

            Console.WriteLine("---------");

            //3)Print MAX and Min  Grades
            double max =  GetMaxGrade(gradesArr);
            double min =  GetMinGrade(gradesArr);

            Console.WriteLine($"Max={max},Min={min}");
            //4)Print ALl Grades that are bigger then AVG And How Much
            Console.WriteLine("---------");
            
            PrintAllGradesAboveValue(gradesArr, avg);
         


            //5) Print how much students in each grade range (0-55) (56-68) (69-78) (79-88) (89-100)  
            //5)Get The Array From User 
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="gradesArr"></param>
        /// <param name="value"></param>
        private static void PrintAllGradesAboveValue(double[] gradesArr, double value)
        {
            int counterGradesAbove = 0;
            foreach (double grade in gradesArr)
            {
                if (grade > value)
                {
                    Console.Write(grade + " | ");
                    counterGradesAbove++;
                }
            }

            Console.WriteLine($"({counterGradesAbove} Items found)");
        }

        private static double GetMinGrade(double[] gradesArr)
        {
            double min = double.MaxValue;
            for (int i = 0; i < gradesArr.Length; i++)
            {
                if (gradesArr[i] < min)
                {
                    min = gradesArr[i];
                }
            }
            return min;
        }


        private static double GetMaxGrade(double[] gradesArr)
        {
            double max = double.MinValue;
            foreach (double gradeItem in gradesArr)
            {
                if (gradeItem > max)
                {
                    max = gradeItem;
                }
            }
            return max;
        }


        private static double CalculateAvg(double[] gradesArr)
        {
            double sum = 0;
            for (int i = 0; i < gradesArr.Length; i++)
            {
                sum += gradesArr[i];
            }
            double avg = sum / gradesArr.Length;
            return avg;
        }





        #endregion

        #region --Task1--
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
            PrintBoolArray(arr);

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
            PrintBoolArray(arr);

        }

        public static void PrintBoolArray(bool[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{i}:[{arr[i]}]");
            }
        }
        #endregion

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
