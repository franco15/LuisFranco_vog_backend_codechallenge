using System;
using System.Collections.Generic;
using System.Text;

namespace VogCodeChallenge.Question
{
	public class Test
	{
		public dynamic TESTModule(dynamic value)
		{
			switch (value)
			{
				case int i when i < 1:
					throw new IntegerBelowOne("Integer values below 1");
				case int i when i <= 4:
					value *= 2;
					break;
				case int i when i > 4:
					value *= 3;
					break;
				case float i when i == 1.0f:
				case float j when j == 2.0f:
					value = 3.0f;
					break;
				case string s:
					value = (string)value.ToUpper();
					break;
				default:
					break;
			}
			return value;
		}
	}

	public class IntegerBelowOne : Exception
	{
		public IntegerBelowOne(string message) : base(message) { }
	}
}
