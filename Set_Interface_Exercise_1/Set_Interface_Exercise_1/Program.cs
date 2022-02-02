using System;
using System.Collections.Generic;
using System.Linq;

namespace Set_Interface_Exercise_1
{
    internal class Program
    {
		public static ISet<Student> findDuplicateEntries(List<Student> students)
		{
            //Implement your logic here and change the return statement accordingly
			ISet<Student> result = new HashSet<Student>();
            for (int i = 0; i < students.Count; i++)
            {
                for (int j = i+1; j < students.Count; j++)
                {
					if(students[i].Equals(students[j]))
                    {
						result.Add(students[i]);
                    }
                }
            }
			return result;
		}

		public static void Main(String[] args)
		{
			List<Student> students = new List<Student>();

			students.Add(new Student(1001, "Dean", 111));
			students.Add(new Student(1002, "Harley", 112));
			students.Add(new Student(1003, "Franklin", 113));
			students.Add(new Student(1005, "Arden", 113));
			students.Add(new Student(1100, "Juliet", 112));
			students.Add(new Student(1003, "Franklin", 111));
			students.Add(new Student(1001, "Dean", 114));

			ISet<Student> duplicateStudents = findDuplicateEntries(students);
			Console.WriteLine("Students who have applied for re-evaluation in more than one subject");
			foreach (Student student in duplicateStudents)
				Console.WriteLine(student);
		}
    }
}
