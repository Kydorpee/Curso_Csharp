using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
		public static void Main(string[] args)
		{
		  	Console.WriteLine ("Digite a 1 nota: ");
        float nota1 = float.Parse(Console.ReadLine());
        Console.WriteLine ("Digite a 2 nota: ");
        float nota2 = float.Parse(Console.ReadLine());
        Console.WriteLine ("Digite a 3 nota: ");
        float nota3 = float.Parse(Console.ReadLine());
        
        float mediaNota = (nota1+nota2+nota3)/3;
        
        if(mediaNota>=7){
            Console.WriteLine("Aprovado");
        }else if (mediaNota>=5){
            Console.WriteLine("Recupedação");
        }else
        {
            Console.WriteLine("Reprovado");
        }
		}
	}
}