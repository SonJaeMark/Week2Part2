using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("===================================");
        Console.WriteLine("   Simple Grade Calculator");
        Console.WriteLine("===================================");

        // ── Get Student Name ──
        Console.Write("\nEnter Student Name: ");
        string name = Console.ReadLine();

        // Validation: name cannot be empty
        if (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("\nError: Student name cannot be empty.");
            return;
        }

        // ── Get Numeric Grade ──
        Console.Write("Enter Numeric Grade (0-100): ");
        string input = Console.ReadLine();

        // Validation: must be a valid number
        if (!int.TryParse(input, out int grade))
        {
            Console.WriteLine("\nError: Please enter a valid numeric grade.");
            return;
        }

        // Validation: must be between 0 and 100
        if (grade < 0 || grade > 100)
        {
            Console.WriteLine("\nError: Grade must be between 0 and 100.");
            return;
        }

        // ── Grade Logic ──
        string letterGrade;
        string remarks;
        string status;

        if (grade >= 90 && grade <= 100)
        {
            letterGrade = "A";
            remarks = "Excellent";
            status = "PASS";
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
            remarks = "Good";
            status = "PASS";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
            remarks = "Average";
            status = "PASS";
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
            remarks = "Below Average";
            status = "PASS";
        }
        else
        {
            letterGrade = "F";
            remarks = "Failing";
            status = "FAIL";
        }

        // ── Display Results ──
        Console.WriteLine("\n===================================");
        Console.WriteLine("           RESULTS");
        Console.WriteLine("===================================");
        Console.WriteLine($"  Student Name  : {name}");
        Console.WriteLine($"  Numeric Grade : {grade}");
        Console.WriteLine($"  Letter Grade  : {letterGrade}");
        Console.WriteLine($"  Remarks       : {remarks}");
        Console.WriteLine($"  Status        : {status}");
        Console.WriteLine("===================================");
    }
}