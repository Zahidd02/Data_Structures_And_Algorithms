using System;
using System.Collections.Generic;

namespace ArrayList_Assignment_1
{
    internal class Program
    {
		public static List<Participant> generateListOfFinalists(Participant[] finalists)
		{
			// Implement your logic here and change the return statement accordingly
			List<Participant> result = new List<Participant>();
            foreach (var item in finalists)
            {
				result.Add(item);
            }
			return result;
		}

		public static List<Participant> getFinalistsByTalent(List<Participant> finalists, String talent)
		{
			// Implement your logic here and change the return statement accordingly
			List<Participant> result = new List<Participant>();
            foreach (var item in finalists)
            {
				if(item.getParticipantTalent().Equals(talent))
                {
					result.Add(item);
                }
            }
			return result;
		}

		public static void Main(String[] args)
		{
			Participant finalist1 = new Participant("Hazel", "Singing", 91.2);
			Participant finalist2 = new Participant("Ben", "Instrumental", 95.7);
			Participant finalist3 = new Participant("John", "Singing", 94.5);
			Participant finalist4 = new Participant("Bravo", "Singing", 97.6);

			Participant[] finalists = { finalist1, finalist2, finalist3, finalist4 };

			List<Participant> finalistsList = generateListOfFinalists(finalists);

			Console.WriteLine("Finalists");
			foreach (Participant finalist in finalistsList)
				Console.WriteLine(finalist);

			String talent = "Singing";
			Console.WriteLine("Finalists in " + talent + " category");

			List<Participant> finalistsCategoryList = getFinalistsByTalent(finalistsList, talent);
			foreach (Participant finalist in finalistsCategoryList)
				Console.WriteLine(finalist);
		}
	}
}
