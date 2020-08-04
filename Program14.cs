using System;

public class Program14
{
	public static void Main()
	{
		string statementType = "switch";

		switch (statementType)
		{
			case "if.else":
				Console.WriteLine("if...else statement");
				break;
			case "ternary":
				Console.WriteLine("Ternary operator");
				break;
			case "switch":
				Console.WriteLine("switch statement");
				break;
		}
	}
}