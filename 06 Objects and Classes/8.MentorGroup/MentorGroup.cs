namespace _8.MentorGroup
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class MentorGroup
    {
        public static void Main()
        {
            var studentsInfo = new SortedDictionary<string, Student>();
            string input = Console.ReadLine();

            while (!input.Equals("end of dates"))
            {
                string[] inputText = input.Split(' ', ',');

                var studentName = inputText[0];

                if (!studentsInfo.ContainsKey(studentName) && inputText.Length > 1)
                {
                    Student student = new Student();
                    for (int i = 1; i < inputText.Length; i++)
                    {
                        if (!studentsInfo.ContainsKey(studentName))
                        {
                            student.Name = studentName;
                            studentsInfo.Add(studentName, student);
                            student.AttendencyDates = new List<DateTime>();
                        }
                        DateTime currentDate = DateTime.ParseExact(inputText[i], "dd'/'MM'/'yyyy", CultureInfo.InvariantCulture);
                        student.AttendencyDates.Add(currentDate);
                    }
                }
                else
                {
                    if (inputText.Length > 1)
                    {
                        for (int i = 1; i < inputText.Length; i++)
                        {
                            DateTime currentDate = DateTime.ParseExact(inputText[i], "dd'/'MM'/'yyyy", CultureInfo.InvariantCulture);
                            studentsInfo[studentName].AttendencyDates.Add(currentDate);
                        }
                    }
                    else
                    {
                        Student student = new Student();
                        student.Name = studentName;
                        studentsInfo.Add(studentName, student);
                    }
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (!input.Equals("end of comments"))
            {
                string[] inputText = input.Split('-');
                var studentName = inputText[0];
                List<string> comments = new List<string>();
                var comment = inputText[1];
                comments.Add(comment);
                if (studentsInfo.ContainsKey(studentName))
                {
                    if (studentsInfo[studentName].Comments != null)
                    {
                        studentsInfo[studentName].Comments.AddRange(comments);
                    }
                    else
                    {
                        studentsInfo[studentName].Comments = comments;
                    }
                }
                input = Console.ReadLine();
            }

            //PRINTING
            foreach (var student in studentsInfo)
            {
                Console.WriteLine(student.Key);
                Console.WriteLine("Comments:");

                if (student.Value.Comments != null)
                {
                    foreach (var comment in student.Value.Comments)
                    {
                        Console.WriteLine($"- {comment}");
                    }
                }

                Console.WriteLine("Dates attended:");
                if (student.Value.AttendencyDates != null)
                {
                    foreach (var date in student.Value.AttendencyDates.OrderBy(x => x))
                    {
                        Console.WriteLine($"-- {date:dd'/'MM'/'yyyy}");
                    }

                }
            }

        }
    }
}
