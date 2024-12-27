using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_student_marks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an array of student marks
            int[] studentMarks = { 90, 80, 70, 60, 50, -1, 30, 20, 10, 0 };

            // Initialize variables to store the results
            int passCount = 0;
            int failCount = 0;
            int invalidMarksCount = 0;

            // Calculate the results using loops
            for (int i = 0; i < studentMarks.Length; i++)
            {
                if (studentMarks[i] < 0)
                {
                    invalidMarksCount++;
                    Console.WriteLine($"Invalid mark {studentMarks[i]} found at index {i}.");
                }
                else if (studentMarks[i] >= 50)
                {
                    passCount++;
                    Console.WriteLine($"Student {i + 1} passed with mark {studentMarks[i]}.");
                }
                else
                {
                    failCount++;
                    Console.WriteLine($"Student {i + 1} failed with mark {studentMarks[i]}.");
                }
            }

            // Display the results
            Console.WriteLine($"Pass count: {passCount}");
            Console.WriteLine($"Fail count: {failCount}");
            Console.WriteLine($"Invalid marks count: {invalidMarksCount}");

            // Check if all students have passed
            if (failCount == 0 && invalidMarksCount == 0)
            {
                Console.WriteLine("All students have passed.");
            }
            else
            {
                Console.WriteLine("Not all students have passed.");
            }
        }
    }
}