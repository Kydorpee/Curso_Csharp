using System;


namespace Aula04
{

    

    public static class Program
    {
        #region Quest 1
        //public static void Main(string[] args)
        //{
        //    string[,] gradeStudant = new string[5, 4];
        //    double[] gradeTotal = new double[5];
        //    double[] gradeAverage = new double[5];

        //    void GetGrade()
        //    {


        //        for (int i = 0; i < 5; i++)
        //        {
        //            Console.Write("Insert studant name : ");
        //            gradeStudant[i, 0] = Console.ReadLine();

        //            for (int j = 1; j <= 3; j++)
        //            {
        //                Console.Write($"Insert grade of {gradeStudant[i, 0]}: ");
        //                gradeStudant[i, j] = Console.ReadLine();
        //                gradeTotal[i] += double.Parse(gradeStudant[i, j]);


        //            }

        //        }

        //    }
        //    void GetAverage()
        //    {

        //        for (int i = 0; i < 5; i++)
        //        {
        //            gradeAverage[i] = gradeTotal[i] / 3;
        //            Console.WriteLine($"Average of {gradeStudant[i, 0]} is: {gradeAverage[i]: F2}");

        //        }
        //    }

        //    GetGrade();
        //    GetAverage();

        //}
        #endregion

        #region Quest 2

        //public static void Main(string[] args) 
        //{
        //    int[,] valuesColum = new int[3, 3];
        //    int[] correctColum = new int[3];
        //    int totalValues = 0;

        //    for (int i = 0; i < 3; i++) 
        //    {
        //        for (int j = 0; j < 3; j++)
        //        {
        //            Console.Write("Insert values: ");
        //            valuesColum[i, j] = int.Parse(Console.ReadLine());

        //            if(i == j)
        //            {
        //                correctColum[i] = valuesColum[i, j];
        //                totalValues += valuesColum[i, j];

        //            }
        //        }
        //    }
        //    foreach (var WriteCollum in correctColum)
        //    {

        //        Console.Write($" A-> {WriteCollum}| " );
        //    }


        //    Console.WriteLine("");
        //    Console.WriteLine($"B -> {totalValues}");
        //}

        #endregion


    }





}