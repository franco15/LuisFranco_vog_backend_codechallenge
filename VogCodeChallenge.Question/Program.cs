using System;

namespace VogCodeChallenge.Question
{
	class Program
	{
		static void Main(string[] args)
		{
			QuestionClass.IterateNames();
			var test = new Test();
			var stringTest = test.TESTModule("test");
			Console.WriteLine(stringTest);
		}

	}
}
