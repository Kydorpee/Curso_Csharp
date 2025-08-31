using System;


// Quest 1
public class Student
{
    private string name;
    private double[] grade = new double [3];
    private double average;

    public Student(string name)
    {
        this.name = name;
    }

    public void pullGrade()
    {
        for (int i=0; i < 3; i++) 
        {
            Console.Write($"Enter the {i+1}º grade of {name}: ");
            grade[i] = double.Parse(Console.ReadLine());
        }
        
    }
    public void onAverage()
    {
        string answerAverage;
        average = (grade[0] + grade[1] + grade[2]) / 3;
        

        if (average >= 7)
        {
            answerAverage = "approved";
        }
        else if (average >= 5)
        {
            answerAverage = "recovery";
        }
        else
        {
            answerAverage = "flunked";
        }

        Console.WriteLine($"Hello, My name is {name},my averade is {average:F2} i'm {answerAverage}");
    }


    //public static void Main(string[] args)

    //{
    //    //var newStudent = new Student("Pedro Vinicius");
    //    //newStudent.pullGrade();
    //    //newStudent.onAverage();

    //}
}

// Quest 2
public class YearsOld
{
    private string name;
    private int age;

    public YearsOld(string name)
    {
        this.name = name;
    }

    public void getAge()
    {
        Console.Write($"Hello {name}!, how old are you?: ");
        age = int.Parse(Console.ReadLine());
    }

    public void validateAge()
    {
        string maturity;
     
        if (age <= 17) 
        {
            maturity = "child"; 
        }
        else if (age <= 59)
        { 
            maturity = "of age"; 
        }
        else
        {
            maturity = "old";
        }

        Console.WriteLine($"i'm {maturity}");
    }

        
    

    //public static void Main(string[] args)
    //{
    //    var newAge = new YearsOld("Nathan");
    //    newAge.getAge();
    //    newAge.validateAge();

    //}
}

//Quest 3
public class Odds
{
   private int number;

    public Odds()
    {
        
    }

    public void getOdds()
    {
        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());
    }

    public  void verifyOdds()
    {
        string answerOdds = number % 2 == 0 ? "even" : "odd";
        Console.WriteLine($"Your number is {answerOdds}");
    }

   
    //public static void Main(string[] args)
    //{
    //    var newNumber = new Odds();
    //    newNumber.getOdds();
    //    newNumber.verifyOdds();
    //}
}

//Quest 4
