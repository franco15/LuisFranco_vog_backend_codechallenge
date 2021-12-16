using System;
using System.Collections.Generic;
using System.Text;

namespace VogCodeChallenge.Question
{
	public static class QuestionClass
	{
		static List<string> NamesList = new List<string>()
		{
			"Jimmy",
			"Jeffrey",
			"John"
		};

		public static void IterateNames()
		{
			int i = 0;
			int j = NamesList.Count;
			while (i < j)
				Console.WriteLine(NamesList[i++]);
		}
	}
}
