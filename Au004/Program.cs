using System;
using System.Security.Cryptography.X509Certificates;

namespace Aula04
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            string [,] gradeStudant = new string [5, 3];
            for (int i = 0; i < gradeStudant[i, 0].Length; i++)
            {
                Console.Write("Insert Studant Name: ");
                gradeStudant[i, 0] = Console.ReadLine();
                Console.WriteLine("");
                for (int j = 0; j < gradeStudant[i, j].Length; j++)
                {
                    Console.Write($"Insert {gradeStudant[i,0]} grade: ");
                    gradeStudant[i,j] = Console.ReadLine();
                }
            }
           
        }
    }
}