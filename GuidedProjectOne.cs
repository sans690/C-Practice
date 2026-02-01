using System;

class GuidedPracticeOne
{
    static void Main()
    {
        // initialize variables - graded assignments 
        decimal currentAssignments = 5;

        decimal sophia1 = 93;
        decimal sophia2 = 87;
        decimal sophia3 = 98;
        decimal sophia4 = 95;
        decimal sophia5 = 100;
        decimal sophiaGrades = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
        decimal sophiaFinalGrade = sophiaGrades / currentAssignments;

        decimal nicolas1 = 80;
        decimal nicolas2 = 83;
        decimal nicolas3 = 82;
        decimal nicolas4 = 88;
        decimal nicolas5 = 85;
        decimal nicolasGrades = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
        decimal nicolasFinalGrade = nicolasGrades / currentAssignments;

        decimal zahirah1 = 84;
        decimal zahirah2 = 96;
        decimal zahirah3 = 73;
        decimal zahirah4 = 85;
        decimal zahirah5 = 79;
        decimal zahirahGrades = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
        decimal zahirahFinalGrade = zahirahGrades / currentAssignments;

        decimal jeong1 = 90;
        decimal jeong2 = 92;
        decimal jeong3 = 98;
        decimal jeong4 = 100;
        decimal jeong5 = 97;
        decimal jeongGrades = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;
        decimal jeongFinalGrade = jeongGrades / currentAssignments;

        List<decimal> finalGrades = new List<decimal> { sophiaFinalGrade, nicolasFinalGrade, zahirahFinalGrade, jeongFinalGrade };
        List<string> names = new List<string> { "Sophia", "Nicolas", "Zahirah", "Jeong" };


        for (int i = 0; i < names.Count; i++)
        {
            string name = names[i];
            decimal grade = finalGrades[i];
            char score;

            if (finalGrades[i] >= 90)
            {
                score = 'A';
            }
            else if (finalGrades[i] >= 80 && finalGrades[i] <= 89)
            {
                score = 'B';
            }
            else if (finalGrades[i] >= 70 && finalGrades[i] <= 79)
            {
                score = 'C';
            }
            else if (finalGrades[i] >= 60 && finalGrades[i] < 69)
            {
                score = 'D';
            }
            else
            {
                score = 'F';
            }
            Console.WriteLine($"{name}\t{grade}\t{score}");
        }
    }
}