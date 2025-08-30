public class Student
{
    private string name;
    private int grade1, grade2, grade3;
    private int average;
    public Student (string name) 
    {  
        this.name = name;
    }

    public void pullGrade()
    {
        Console.Write("Enter the first grade: ");
        this.grade1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second grade: ");
        this.grade2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the third grade: ");
        this.grade3 = int.Parse(Console.ReadLine());
    }
    public void onGrade()
    {

        this.average = (this.grade1 + this.grade2 + this.grade3) / 3;

        if (this.average >= 7)
        {
            Console.WriteLine($"Hello, My name is {this.name}, i'm approved");
        }
        else if (this.average >= 5)
        {
            Console.WriteLine($"Hello, My name is {this.name}, i'm recovery");
        }
        else
        {
            Console.WriteLine($"Hello, My name is {this.name}, i'm flunked");
        }
    }

    public static void Main(string[] args)
    {
      var newStudent = new Student("Pedro Vinicius");
        newStudent.pullGrade();
        newStudent.onGrade();
    }
}

