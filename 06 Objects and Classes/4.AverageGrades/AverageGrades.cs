namespace _4.AverageGrades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AverageGrades
    {
        public static void Main()
        {
            var studentGrades = GetStudentsGrades();
            string[] topStudents = studentGrades
                .Where(x => x.AverageGrade >= 5)
                .Select(x => x.Name).Distinct()
                .OrderBy(x => x)
                .ToArray();

            foreach (var student in topStudents)
            {
                double[] studentAverageGrades = studentGrades
                    .Where(x => x.Name == student && x.AverageGrade >= 5)
                    .Select(x => x.AverageGrade)
                    .OrderByDescending(x => x)
                    .ToArray();

                foreach (var studentAverageGrade in studentAverageGrades)
                {
                    Console.WriteLine($"{student} -> {studentAverageGrade:f2}");
                }
            }

        }

        private static Student[] GetStudentsGrades()
        {
            var numbersOfStudents = int.Parse(Console.ReadLine());

            Student[] grades = new Student[numbersOfStudents];

            for (int i = 0; i < numbersOfStudents; i++)
            {
                List<double> studentGrades = new List<double>();

                string[] studentsData = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int j = 1; j < studentsData.Length; j++)
                {
                    studentGrades.Add(double.Parse(studentsData[j]));
                }
                    grades[i] = new Student() { Name = studentsData[0], Grades = studentGrades };

            }
            return grades;
        }
    }
}
