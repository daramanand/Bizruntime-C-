using System;

public class Program15
{
	public static void Main()
	{
		int x = 5;

		switch (x)
		{
			case 1:
				Console.WriteLine("x = 1");
				break;
			case 2:
				Console.WriteLine("x = 2");
				break;
			case 4:
			case 5:
				Console.WriteLine("x = 4 or x = 5");
				break;
			default:
				Console.WriteLine("x > 5");
				break;
		}
	}
}