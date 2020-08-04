using System;

public class Program13
{
	public static void Main()
	{
		int x = 125;

		switch (x % 2)
		{
			case 0:
				Console.WriteLine($"{x} is even value");
				break;
			case 1:
				Console.WriteLine($"{x} is odd Value");
				break;
		}
	}
}