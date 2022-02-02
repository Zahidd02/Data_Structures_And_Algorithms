using System;
using System.Collections.Generic;

namespace Dictionary_Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Dictionary<string, double> studentMarks = new Dictionary<string, double>();
			studentMarks.Add("Lily", 90.0);
			studentMarks.Add("Robin", 68.0);
			studentMarks.Add("Marshall", 76.5);
			studentMarks.Add("Neil", 67.0);
			studentMarks.Add("Ted", 92.0);

			Dictionary<string, double> maxMinScorers = Student.findMaxMinScorers(studentMarks);

			Console.WriteLine("Details of Top Scorers & Low Scorers\n====================================");
			foreach (KeyValuePair<string, double> item in maxMinScorers)
			{
				Console.WriteLine(item.Key + " -- " + item.Value);
			}
		}
	}
}
