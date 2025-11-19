namespace task6

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Percentage Calculator ===");

            // Asking user for marks
            Console.Write("Enter marks obtained: ");
            bool isMarksValid = int.TryParse(Console.ReadLine(), out int marks);

            // Asking user for total marks
            Console.Write("Enter total marks: ");
            bool isTotalValid = int.TryParse(Console.ReadLine(), out int totalMarks);

            // Validation for incorrect input
            if (!isMarksValid || !isTotalValid)
            {
                Console.WriteLine("Error: Please enter only whole numbers.");
                return;
            }

            // Validation for zero total marks
            if (totalMarks == 0)
            {
                Console.WriteLine("Error: Total marks cannot be zero.");
                return;
            }

            // ================= DEBUGGING NOTES =================
            // At this stage, assuming the user entered:
            // marks = 23
            // totalMarks = 230
            // Both TryParse checks returned true.
            // However, marks / totalMarks is INTEGER division.

            double wrongPercentage = marks / totalMarks * 100;
            Console.WriteLine($"Incorrect Percentage (due to integer division): {wrongPercentage}");

            // Explanation of the bug:
            // Since both 'marks' and 'totalMarks' are integers,
            // marks / totalMarks performs integer division.
            // So 23 / 230 = 0, not 0.1.
            // After that, 0 * 100 = 0 → giving us the wrong output.

            // ================= FIXING THE ISSUE =================
            // To perform floating-point division, one operand must be cast to double.
            // This forces the division to keep decimal precision.

            double correctPercentage = (double)marks / totalMarks * 100;
            Console.WriteLine($"Correct Percentage: {correctPercentage}%");
        }
    }
}
